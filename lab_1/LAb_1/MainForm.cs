using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LAb_1
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }

        Student stud = new Student(new Person("Анатолий", "Миценгендлер", new DateTime(1992, 8, 19)), Education.Specialist, 230);
        

        private void btnStudentToString_Click(object sender, EventArgs e)
        {
            tbInfo.Text = stud.ToShortString() + "\r\n";
            
        }

        private void btnCheckIndexEducation_Click(object sender, EventArgs e)
        {
            foreach (object value in Enum.GetValues(typeof(Education)))
            {
                tbInfo.Text += "\r\n" + "Проверка инексатора [" + value + "]: " + stud[(Education)value].ToString();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {            
            stud.person_pr = new Person();
            stud.education_pr = Education.SecondEducation;
            stud.group_pr = 32;
            tbInfo.Text = stud.ToString() +"\r\n"; 
        }

        private void btnAddExams_Click(object sender, EventArgs e)
        {
            stud.AddExams(new Exam(), new Exam("Математика", 3, new DateTime(2015, 10, 5)));
            tbInfo.Text = stud.ToString(); 
        }

        private void btnOpenFormArraySpeed_Click(object sender, EventArgs e)
        {

            tbInfo.Text = "Подсчет ...";
            Thread arr = new Thread(GetTimeArray);
            arr.IsBackground = true;
            arr.Start();
            
        }

        private void GetTimeArray()
        {
            int sizeArray = 1000;
            Exam[] odnom = new Exam[sizeArray * sizeArray];
            Exam[,] dvum = new Exam[sizeArray, sizeArray];
            Exam[][] zub = new Exam[sizeArray][];
            Random Score_rnd = new Random();

            for (int i = 0; i < odnom.Length; i++)
            {
                odnom[i] = new Exam("Example", Score_rnd.Next(1, 6), DateTime.Now);
            }

            for (int i = 0; i < sizeArray; i++)
            {
                zub[i] = new Exam[sizeArray];
                for (int j = 0; j < sizeArray; j++)
                {
                    dvum[i, j] = new Exam("Example", Score_rnd.Next(1, 6), DateTime.Now);
                    zub[i][j] = new Exam("Example", Score_rnd.Next(1, 6), DateTime.Now);
                }
            }

            int time_odnom;
            int start_odnom;
            int end_odnom;
            int sumScore_odnom = 0;
            start_odnom = Environment.TickCount;
            for (int i = 0; i < odnom.Length; i++)
            {
                sumScore_odnom += odnom[i].Score;
            }
            end_odnom = Environment.TickCount;
            time_odnom = end_odnom - start_odnom;

            int time_dvum;
            int start_dvum;
            int end_dvum;
            int sumScore_dvum = 0;
            start_dvum = Environment.TickCount;
            for (int i = 0; i < dvum.GetLength(0); i++)
            {
                for (int j = 0; j < dvum.GetLength(1); j++)
                {
                    sumScore_dvum += dvum[i, j].Score;
                }
            }
            end_dvum = Environment.TickCount;
            time_dvum = end_dvum - start_dvum;

            int time_zub;
            int start_zub;
            int end_zub;
            int sumScore_zub = 0;
            start_zub = Environment.TickCount;
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    sumScore_zub += zub[i][j].Score;
                }
            }
            end_zub = Environment.TickCount;
            time_zub = end_zub - start_zub;

            Action ac = () =>
            {
                tbInfo.Text = "Время операции:" + "\r\n" + "Одномерный массив: " + time_odnom.ToString() + "\r\n" + "Двумерный массив: " + time_dvum.ToString() + "\r\n" + "Зубчатый массив: " + time_zub.ToString();
            };
            Invoke(ac);
        }
    }
}
