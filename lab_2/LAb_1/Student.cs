using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LAb_1
{
    class Student : Person, IdateAndCopy
    {        
        private Education education;
        private int group;        
        private ArrayList testList = new ArrayList();
        private ArrayList examList = new ArrayList();
        public ArrayList ListExamAndTest = new ArrayList();      


        public Student():
            base()
        {            
            education = Education.Вachelor;
            group = 230;            
        }
        
        public Student(Person person, Education education, int group):
            base()
        {
            First_Name = person.FirstName;
            Last_name = person.LastName;
            date = person.Date;
            this.education = education;
            this.group = group;
        }

        public Student(string First_Name, string Last_name, DateTime date, Education education, int group)
            : base(First_Name, Last_name, date)
        {
            this.education = education;
            this.group = group;
        }

        public Person PersonPr
        {
            set
            {
                FirstName = value.FirstName;
                LastName = value.LastName;
                Date = value.Date;
            }
            get
            {
                return new Person(FirstName, LastName, Date);
            }
        }

        public Education EducationPr
        {
            set
            {
                education = value;
            }
            get
            {
                return education;
            }
        }

        public int Group
        {
            set
            {
                if ((value > 100) && (value <= 599))
                {
                    group = value;
                }
                else
                {
                    throw new System.ArgumentException("Указано недопустимое значение по поле для группы" + "\r\n" + "Допустимые значения: 101-599");
                }
            }
            get
            {
                return group;
            }
        }

        public ArrayList ExamList
        {
            set
            {
                examList = value;
            }
            get
            {
                return examList;
            }
        }

        public double Average
        {
            get
            {
                int sum = 0;                
                foreach (Exam ex in examList)
                {
                    sum += ex.Score;                
                }
                return sum;
            }
        }             
        
        public void AddExams(params Exam[] addEx)
        {            
            examList.AddRange(addEx);
            ListExamAndTest.AddRange(examList);
        }

        public void AddTest(params Test[] addTest)
        {
            testList.AddRange(addTest);
            ListExamAndTest.AddRange(testList);
        }

        public IEnumerable <object> GetExamAndTest()
        {            
            foreach (Object obj in ListExamAndTest)
            {
                yield return obj;
            }
        }
        public IEnumerable<Exam> GetExamScore(int score)
        {
            foreach(Exam ex in examList)
            {
                if (ex.Score > score)
                {
                    yield return ex;
                }
            }            
        }

        public override string ToString()
        {
            string exams = "";
            string zach = "";
            foreach (Exam ex in examList)
            {
                exams += string.Format("\r\n" + "{0}, Оценка: {1}, Дата: {2}", ex.Discipline, ex.Score, ex.Date.ToString("d"));                
            }
            foreach (Test test in testList)
            {
                zach += string.Format("\r\n" + "{0}", test.ToString());
            }
            return string.Format("{0}," + "\r\n" + "Форма обучения: {1}" + "\r\n" + "Группа: {2}" + "\r\n" + "Экзамены:{3}" + "\r\n" + "Зачеты:{4}", base.ToString(), education, group, exams, zach);
        }

        public override string ToShortString()
        {
            return string.Format("{0}," + "\r\n" + "Форма обучения: {1}" + "\r\n" + "Группа: {2}" + "\r\n" + "Средний балл: {3}", base.ToString(), education, group, Average);
        }

        public override object DeepCopy()
        {
            return new Student(First_Name, Last_name, date, EducationPr, Group);            
        }
    }
}
