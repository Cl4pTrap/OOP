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
        
        Student student = new Student();
        Student student2;
        Person pr1;
        Person pr2;

        private void btnCreatePerson_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            pr1 = new Person();
            pr2 = (Person)pr1.DeepCopy();
            
            string equa;
            if (pr1.Equals(pr2))
            {
                equa = "Объекты равны";
            }
            else
            {
                equa = "Объекты не равны";
            }
            string hash = "Хэш код Person 1: " + pr1.GetHashCode().ToString() + "\r\n" + "Хэш код Person 2: " + pr2.GetHashCode().ToString();

            tbInfo.Text = "Person 1: " + "\r\n" + pr1.ToString() + "\r\n" + "Person 2: " + pr2.ToString() + "\r\n" + hash + "\r\n" + equa;            
        }        

        private void btnChangeStudent_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            student.AddExams(new Exam(), new Exam("Математика", 3, new DateTime(2015, 10, 5)), new Exam("Информатика", 5, new DateTime(2015, 8, 27)));
            student.AddTest(new Test(), new Test("Социология", true), new Test("Физика", true));
            tbInfo.Text = student.ToString() + "\r\n"; 
        }

        private void btnViewPerson_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            tbInfo.Text = student.PersonPr.ToString();                
        }
        private void btnStudentCopy_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            student2 = (Student)student.DeepCopy();
            student.FirstName = "Анатолий";
            student.LastName = "Красноперов";
            
            tbInfo.Text = student.ToShortString() + "\r\n" + student2.ToShortString();
        }
        private void btnExeption_Click(object sender, EventArgs e)
        {
            try
            {
                student.Group = 950;
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Попытка ввести некорректный номер группы." +  "\r\n"+ "Допустимый диапазон значений <101-599>"), "Некорректное значение");
            }
        }

        private void btnViewExamAndTest_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            string strReturn = "";
            foreach (Object obj in student.GetExamAndTest().ToArray<Object>())
            {
                if (obj is Exam)
                {
                    Exam ex = (Exam)obj;
                    strReturn += ex.ToString() + "\r\n";
                }
                if (obj is Test)
                {
                    Test test = (Test)obj;
                    strReturn += test.ToString() + "\r\n";
                }                
            }
            tbInfo.Text = strReturn;
        }

        private void btnViewExam_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            string strReturn = "";
            foreach (Object obj in student.GetExamScore(3).ToArray<Object>())
            {
                Exam ex = (Exam)obj;
                strReturn += ex.ToString() + "\r\n";    
            }
            tbInfo.Text = strReturn;
        }
    }
}
