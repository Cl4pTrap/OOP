namespace LAb_1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnViewPerson = new System.Windows.Forms.Button();
            this.btnStudentCopy = new System.Windows.Forms.Button();
            this.btnExeption = new System.Windows.Forms.Button();
            this.btnViewExamAndTest = new System.Windows.Forms.Button();
            this.btnViewExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.Location = new System.Drawing.Point(260, 12);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(118, 54);
            this.btnCreatePerson.TabIndex = 0;
            this.btnCreatePerson.Text = "Создать 2 объекта\r\nтипа Person";
            this.btnCreatePerson.UseVisualStyleBackColor = true;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.Location = new System.Drawing.Point(12, 12);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(242, 225);
            this.tbInfo.TabIndex = 3;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(260, 72);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(118, 51);
            this.btnCreateStudent.TabIndex = 4;
            this.btnCreateStudent.Text = "Создать объект Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnChangeStudent_Click);
            // 
            // btnViewPerson
            // 
            this.btnViewPerson.Location = new System.Drawing.Point(260, 129);
            this.btnViewPerson.Name = "btnViewPerson";
            this.btnViewPerson.Size = new System.Drawing.Size(118, 51);
            this.btnViewPerson.TabIndex = 5;
            this.btnViewPerson.Text = "Вывести значение\r\nсвойства типа Person";
            this.btnViewPerson.UseVisualStyleBackColor = true;
            this.btnViewPerson.Click += new System.EventHandler(this.btnViewPerson_Click);
            // 
            // btnStudentCopy
            // 
            this.btnStudentCopy.Location = new System.Drawing.Point(260, 186);
            this.btnStudentCopy.Name = "btnStudentCopy";
            this.btnStudentCopy.Size = new System.Drawing.Size(118, 51);
            this.btnStudentCopy.TabIndex = 13;
            this.btnStudentCopy.Text = "DeepCopy();";
            this.btnStudentCopy.UseVisualStyleBackColor = true;
            this.btnStudentCopy.Click += new System.EventHandler(this.btnStudentCopy_Click);
            // 
            // btnExeption
            // 
            this.btnExeption.Location = new System.Drawing.Point(260, 243);
            this.btnExeption.Name = "btnExeption";
            this.btnExeption.Size = new System.Drawing.Size(118, 54);
            this.btnExeption.TabIndex = 15;
            this.btnExeption.Text = "Вызов исключения";
            this.btnExeption.UseVisualStyleBackColor = true;
            this.btnExeption.Click += new System.EventHandler(this.btnExeption_Click);
            // 
            // btnViewExamAndTest
            // 
            this.btnViewExamAndTest.Location = new System.Drawing.Point(12, 243);
            this.btnViewExamAndTest.Name = "btnViewExamAndTest";
            this.btnViewExamAndTest.Size = new System.Drawing.Size(118, 54);
            this.btnViewExamAndTest.TabIndex = 17;
            this.btnViewExamAndTest.Text = "Вывести список\r\nвсех зачетов\r\nи экзаменов";
            this.btnViewExamAndTest.UseVisualStyleBackColor = true;
            this.btnViewExamAndTest.Click += new System.EventHandler(this.btnViewExamAndTest_Click);
            // 
            // btnViewExam
            // 
            this.btnViewExam.Location = new System.Drawing.Point(136, 243);
            this.btnViewExam.Name = "btnViewExam";
            this.btnViewExam.Size = new System.Drawing.Size(118, 54);
            this.btnViewExam.TabIndex = 18;
            this.btnViewExam.Text = "Вывести список\r\nвсех экзаменов\r\nс оценкой выше 3";
            this.btnViewExam.UseVisualStyleBackColor = true;
            this.btnViewExam.Click += new System.EventHandler(this.btnViewExam_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 307);
            this.Controls.Add(this.btnViewExam);
            this.Controls.Add(this.btnViewExamAndTest);
            this.Controls.Add(this.btnExeption);
            this.Controls.Add(this.btnStudentCopy);
            this.Controls.Add(this.btnViewPerson);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnCreatePerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnViewPerson;
        private System.Windows.Forms.Button btnStudentCopy;
        private System.Windows.Forms.Button btnExeption;
        private System.Windows.Forms.Button btnViewExamAndTest;
        private System.Windows.Forms.Button btnViewExam;
    }
}

