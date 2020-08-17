using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TestApp
{
    public class QSession
    {
        private List<CategorySet> sets = null;
        private List<Category> categories = null;
        public int CountAnswers = 0;

        private class CategoryAnswer
        {
            public Category category;

            public int countTrue;
            public int countFalse;
            public int curQuestionIndex;

            public CategoryAnswer()
            {
                countTrue = countFalse = curQuestionIndex = 0;
            }
        }

        private List<CategoryAnswer> answers = new List<CategoryAnswer>();
        private int curCategoryIndex = 0;

        private struct QuestionAnswer
        {
            public Question question;
            public Category category;
            public bool isTrue;
        }

        public string GetDifficult => answers[curCategoryIndex].category.Name;
        
        private List<QuestionAnswer> qanswers = new List<QuestionAnswer>();

        public QSession(TestContext db)
        {
            sets = db.CategorySet.ToList();
            categories = db.Categories.Include(x => x.Questions.Select(y => y.Answers)).ToList();

            answers.Add(new CategoryAnswer() { category = categories[0] });
        }

        private bool LoadNext()
        {
            var curCategory = answers[curCategoryIndex].category;

            var nextSet = sets.Where(x => x.Current.Id == curCategory.Id && x.Type == "next");
            if (nextSet.Count() == 0) return false;
            var next = nextSet.First().Other;

            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].category.Id == next.Id)
                {
                    curCategoryIndex = i;
                    answers[curCategoryIndex].category.PrevCount++;
                    return true;
                }
            }

            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Id == next.Id)
                {
                    answers.Add(new CategoryAnswer() { category = categories[i] });
                    curCategoryIndex++;
                    return true;
                }
            }
            
            return false;
        }

        private bool LoadPrev()
        {
            var curCategory = answers[curCategoryIndex].category;

            var prevSet = sets.Where(x => x.Current.Id == curCategory.Id && x.Type == "prev");
            if (prevSet.Count() != 0)
            {
                var prev = prevSet.First().Other;

                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i].category.Id == prev.Id)
                    {
                        curCategoryIndex = i;
                        return true;
                    }
                }
            }

            return false;
        }

        private bool LoadCurQuestion()
        {
            var curCategory = answers[curCategoryIndex];
            var countTrue = curCategory.countTrue;
            var countFalse = curCategory.countFalse;

            answers[curCategoryIndex].curQuestionIndex++;

            if ((countTrue + countFalse) == curCategory.category.Questions.Count)
            {
                if (countTrue >= countFalse)
                {
                    return LoadNext();
                }
                else
                {
                    if (LoadPrev() == false) return false;
                    answers[curCategoryIndex].category.NextCount++;

                    curCategory = answers[curCategoryIndex];
                    countTrue = curCategory.countTrue;
                    countFalse = curCategory.countFalse;

                    return (countTrue + countFalse) != curCategory.category.Questions.Count;
                } 
            }

            if (countTrue == curCategory.category.NextCount)
            {
                return LoadNext();
            }

            if (countFalse == curCategory.category.PrevCount)
            {
                if (LoadPrev() == false) return false;
                answers[curCategoryIndex].category.NextCount++;

                curCategory = answers[curCategoryIndex];
                countTrue = curCategory.countTrue;
                countFalse = curCategory.countFalse;

                return (countTrue + countFalse) != curCategory.category.Questions.Count;
            }
            
            return true;
        }

        public bool CheckAnswer(List<bool> ans)
        {
            List<Answer> true_ans = new List<Answer>();
            foreach (var a in GetCurQuestion().Answers) true_ans.Add(a);

            for (int i = 0; i < true_ans.Count; i++)
            {
                if (true_ans[i].IsTrue != ans[i])
                {
                    answers[curCategoryIndex].countFalse++;
                    return false;
                }
            }

            answers[curCategoryIndex].countTrue++;
            return true;
        }

        public Question GetCurQuestion()
        {
            var curCategory = answers[curCategoryIndex].category;
            return curCategory.Questions.ToList()[answers[curCategoryIndex].curQuestionIndex];
        }

        public bool LoadNextQuestion()
        {
            CountAnswers++;

            return LoadCurQuestion();
        }

        public double GetScore()
        {
            double sum = 0;

            foreach (var answer in answers)
            {
                for(int i = 0; i < (answer.curQuestionIndex - answer.countFalse); i++)
                {
                    sum += answer.category.Coef * answer.category.Questions.ToList()[i].Mark;
                }
            }

            return sum;
        }
        
    }
}
