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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenFormArraySpeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentToString
            // 
            this.btnStudentToString.Location = new System.Drawing.Point(294, 12);
            this.btnStudentToString.Name = "btnStudentToString";
            this.btnStudentToString.Size = new System.Drawing.Size(118, 54);
            this.btnStudentToString.TabIndex = 0;
            this.btnStudentToString.Text = "Вывести данные о студенте";
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
            this.btnChange.Location = new System.Drawing.Point(294, 129);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(118, 51);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить личные данные";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAddExams
            // 
            this.btnAddExams.Location = new System.Drawing.Point(294, 186);
            this.btnAddExams.Name = "btnAddExams";
            this.btnAddExams.Size = new System.Drawing.Size(118, 51);
            this.btnAddExams.TabIndex = 5;
            this.btnAddExams.Text = "Добавить элементы в список экзаменов";
            this.btnAddExams.UseVisualStyleBackColor = true;
            this.btnAddExams.Click += new System.EventHandler(this.btnAddExams_Click);
            // 
            // btnCheckIndexEducation
            // 
            this.btnCheckIndexEducation.Location = new System.Drawing.Point(294, 72);
            this.btnCheckIndexEducation.Name = "btnCheckIndexEducation";
            this.btnCheckIndexEducation.Size = new System.Drawing.Size(118, 51);
            this.btnCheckIndexEducation.TabIndex = 6;
            this.btnCheckIndexEducation.Text = "Вывод значений индексатора";
            this.btnCheckIndexEducation.UseVisualStyleBackColor = true;
            this.btnCheckIndexEducation.Click += new System.EventHandler(this.btnCheckIndexEducation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(422, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вывод данных о студенте\r\nметодом ToShortString();";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(422, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Проверить форму обучения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(422, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Изменение данных о студенте\r\nи вывод методом ToString();";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(422, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Заполнение списка экзаменов\r\nи вывод информаци о студенте\r\nметодом ToString();";
            // 
            // btnOpenFormArraySpeed
            // 
            this.btnOpenFormArraySpeed.Location = new System.Drawing.Point(294, 243);
            this.btnOpenFormArraySpeed.Name = "btnOpenFormArraySpeed";
            this.btnOpenFormArraySpeed.Size = new System.Drawing.Size(265, 23);
            this.btnOpenFormArraySpeed.TabIndex = 11;
            this.btnOpenFormArraySpeed.Text = "Время выполнения операций в массивах";
            this.btnOpenFormArraySpeed.UseVisualStyleBackColor = true;
            this.btnOpenFormArraySpeed.Click += new System.EventHandler(this.btnOpenFormArraySpeed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 275);
            this.Controls.Add(this.btnOpenFormArraySpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckIndexEducation);
            this.Controls.Add(this.btnAddExams);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnStudentToString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Полянский, 23Б";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentToString;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAddExams;
        private System.Windows.Forms.Button btnCheckIndexEducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenFormArraySpeed;
    }
}

