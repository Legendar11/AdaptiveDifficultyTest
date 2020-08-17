namespace TestApp
{
    partial class FormTest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.rtb_Question = new System.Windows.Forms.RichTextBox();
            this.grpBox_Answers = new System.Windows.Forms.GroupBox();
            this.tbl_Answers = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBox_Answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Finish, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Question, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBox_Answers, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Next, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.btn_Help, 3, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 456);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Finish
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Finish, 2);
            this.btn_Finish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Finish.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Finish.Location = new System.Drawing.Point(60, 408);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(108, 45);
            this.btn_Finish.TabIndex = 4;
            this.btn_Finish.Text = "Завершить";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 
            // rtb_Question
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtb_Question, 10);
            this.rtb_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Question.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Question.Location = new System.Drawing.Point(3, 3);
            this.rtb_Question.Name = "rtb_Question";
            this.tableLayoutPanel1.SetRowSpan(this.rtb_Question, 5);
            this.rtb_Question.Size = new System.Drawing.Size(568, 219);
            this.rtb_Question.TabIndex = 0;
            this.rtb_Question.Text = "";
            // 
            // grpBox_Answers
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpBox_Answers, 8);
            this.grpBox_Answers.Controls.Add(this.tbl_Answers);
            this.grpBox_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox_Answers.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBox_Answers.Location = new System.Drawing.Point(60, 228);
            this.grpBox_Answers.Name = "grpBox_Answers";
            this.tableLayoutPanel1.SetRowSpan(this.grpBox_Answers, 4);
            this.grpBox_Answers.Size = new System.Drawing.Size(450, 174);
            this.grpBox_Answers.TabIndex = 1;
            this.grpBox_Answers.TabStop = false;
            this.grpBox_Answers.Text = "Варианты ответов:";
            // 
            // tbl_Answers
            // 
            this.tbl_Answers.ColumnCount = 1;
            this.tbl_Answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Answers.Location = new System.Drawing.Point(3, 25);
            this.tbl_Answers.Name = "tbl_Answers";
            this.tbl_Answers.RowCount = 4;
            this.tbl_Answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Answers.Size = new System.Drawing.Size(444, 146);
            this.tbl_Answers.TabIndex = 0;
            // 
            // btn_Next
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Next, 2);
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Next.Location = new System.Drawing.Point(402, 408);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(108, 45);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Далее";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Help
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Help, 2);
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Help.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Help.Location = new System.Drawing.Point(174, 408);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(108, 45);
            this.btn_Help.TabIndex = 5;
            this.btn_Help.Text = "Справка";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpBox_Answers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.RichTextBox rtb_Question;
        private System.Windows.Forms.GroupBox grpBox_Answers;
        private System.Windows.Forms.TableLayoutPanel tbl_Answers;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Help;
    }
}

