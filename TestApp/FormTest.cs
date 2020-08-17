using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestApp
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        QSession questions = null;

        /// <summary>
        /// Загрузка текущего вопроса
        /// </summary>
        private void LoadQuestion()
        {
            this.Text = "Вопрос №" + (questions.CountAnswers + 1);
            this.Text += "   Сложность: " + questions.GetDifficult;
            rtb_Question.Text = questions.GetCurQuestion().QuesionTitle;
        }

        /// <summary>
        /// Загрузка ответов на текущий вопрос
        /// </summary>
        private void LoadAnswers()
        {
            var curQ = questions.GetCurQuestion();
            int count = curQ.Answers.Count(i => i.IsTrue == true);

            if (count == 0) throw new Exception("Answers all is false!");

            tbl_Answers.Controls.Clear();

            if (count > 1)
            {
                foreach (Answer a in questions.GetCurQuestion().Answers)
                {
                    CheckBox cb = new CheckBox()
                    {
                        Text = a.AnswerTitle,
                        Checked = false,
                        Font = new Font("Georgia", 12),
                        AutoSize = true
                    };

                    cb.CheckedChanged += (sender, argc) => { btn_Next.Enabled = true; };

                    tbl_Answers.Controls.Add(cb);
                }
            }
            else
            {
                foreach (Answer a in questions.GetCurQuestion().Answers)
                {
                    RadioButton rb = new RadioButton()
                    {
                        Text = a.AnswerTitle,
                        Checked = false,
                        Font = new Font("Georgia", 12),
                        AutoSize = true
                    };

                    rb.CheckedChanged += (sender, argc) => { btn_Next.Enabled = true; };

                    tbl_Answers.Controls.Add(rb);
                }
            }
        }

        /// <summary>
        /// Сохранение пользовательских ответов
        /// </summary>
        private void SaveAnswers()
        {
            List<bool> answers = new List<bool>(questions.GetCurQuestion().Answers.Count());
            foreach (Control c in tbl_Answers.Controls)
            {
                if (c is RadioButton) answers.Add((c as RadioButton).Checked);
                if (c is CheckBox) answers.Add((c as CheckBox).Checked);
            }
            questions.CheckAnswer(answers);
        }


        private void FormTest_Load(object sender, EventArgs e)
        {
            using (TestContext db = new TestContext())
            {
                questions = new QSession(db);

                LoadQuestion();
                LoadAnswers();
                btn_Next.Enabled = false;
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            SaveAnswers();

            if (questions.LoadNextQuestion() == false)
            {
                MessageBox.Show("Счет = " + questions.GetScore().ToString(), "Тест завершен!");
                this.Close();
                return;
            }

            LoadQuestion();
            LoadAnswers();
            btn_Next.Enabled = false;
        }
    }
}
