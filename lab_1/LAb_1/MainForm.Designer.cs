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
            this.btnStudentToString = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAddExams = new System.Windows.Forms.Button();
            this.btnCheckIndexEducation = new System.Windows.Forms.Button();
            this.btnOpenFormArraySpeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentToString
            // 
            this.btnStudentToString.Location = new System.Drawing.Point(294, 12);
            this.btnStudentToString.Name = "btnStudentToString";
            this.btnStudentToString.Size = new System.Drawing.Size(118, 55);
            this.btnStudentToString.TabIndex = 0;
            this.btnStudentToString.Text = "Информация о студенте";
            this.btnStudentToString.UseVisualStyleBackColor = true;
            this.btnStudentToString.Click += new System.EventHandler(this.btnStudentToString_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(12, 12);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(276, 251);
            this.tbInfo.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(294, 133);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(118, 56);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить личные данные";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAddExams
            // 
            this.btnAddExams.Location = new System.Drawing.Point(294, 195);
            this.btnAddExams.Name = "btnAddExams";
            this.btnAddExams.Size = new System.Drawing.Size(118, 68);
            this.btnAddExams.TabIndex = 5;
            this.btnAddExams.Text = "Добавить элементы в список экзаменов";
            this.btnAddExams.UseVisualStyleBackColor = true;
            this.btnAddExams.Click += new System.EventHandler(this.btnAddExams_Click);
            // 
            // btnCheckIndexEducation
            // 
            this.btnCheckIndexEducation.Location = new System.Drawing.Point(294, 73);
            this.btnCheckIndexEducation.Name = "btnCheckIndexEducation";
            this.btnCheckIndexEducation.Size = new System.Drawing.Size(118, 54);
            this.btnCheckIndexEducation.TabIndex = 6;
            this.btnCheckIndexEducation.Text = "Форма обучения";
            this.btnCheckIndexEducation.UseVisualStyleBackColor = true;
            this.btnCheckIndexEducation.Click += new System.EventHandler(this.btnCheckIndexEducation_Click);
            // 
            // btnOpenFormArraySpeed
            // 
            this.btnOpenFormArraySpeed.Location = new System.Drawing.Point(12, 269);
            this.btnOpenFormArraySpeed.Name = "btnOpenFormArraySpeed";
            this.btnOpenFormArraySpeed.Size = new System.Drawing.Size(276, 23);
            this.btnOpenFormArraySpeed.TabIndex = 11;
            this.btnOpenFormArraySpeed.Text = "Время выполнения операций в массивах";
            this.btnOpenFormArraySpeed.UseVisualStyleBackColor = true;
            this.btnOpenFormArraySpeed.Click += new System.EventHandler(this.btnOpenFormArraySpeed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 300);
            this.Controls.Add(this.btnOpenFormArraySpeed);
            this.Controls.Add(this.btnCheckIndexEducation);
            this.Controls.Add(this.btnAddExams);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnStudentToString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LAB 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentToString;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAddExams;
        private System.Windows.Forms.Button btnCheckIndexEducation;
        private System.Windows.Forms.Button btnOpenFormArraySpeed;
    }
}

