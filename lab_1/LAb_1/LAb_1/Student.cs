using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_1
{
    class Student
    {
        private Person person;
        private Education education;
        private int group;
        private Exam[] exam_list = new Exam[0];

        public Student()
        {
            person = new Person();
            education = Education.Вachelor;
            group = 230;            
        }
        public Student(Person person, Education education, int group)
        {
            this.person = person;
            this.education = education;
            this.group = group;
        }

        public Person person_pr
        {
            set
            {
                person = value;
            }
            get 
            {
                return person;
            }
        }
        public Education education_pr
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
        public int group_pr
        {
            set
            {
                group = value;
            }
            get
            {
                return group;
            }
        }
        public Exam[] exam_list_pr
        {
            set
            {
                exam_list = value;
            }
            get
            {
                return exam_list;
            }
        }
        public double Average
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < exam_list.Length; i++)
                {
                    sum += exam_list[i].Score;                    
                }
                return sum;
            }
        }
        public bool this[Education val]
        {
            get
            {
                if (education == val)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
        public void AddExams(params Exam[] addEx)
        {            
            for (int i = 0; i < addEx.Length; i++)
            {
                Array.Resize(ref exam_list, exam_list.Length + 1);
                exam_list[exam_list.Length - 1] = addEx[i];
            }
        }
        public override string ToString()
        {
            string exams = "";
            for (int i = 0; i < exam_list.Length; i++)
            {
                exams += string.Format("\r\n" + "{0}, Оценка: {1}, Дата: {2}", exam_list[i].Discipline, exam_list[i].Score, exam_list[i].Date.ToString("d"));
            }
            return string.Format("{0}," + "\r\n" + "Форма обучения: {1}" + "\r\n" + "Группа: {2}" + "\r\n" + "Экзамены:{3}", person.ToString(), education, group, exams);           
        }
        public string ToShortString()
        {
            return string.Format("{0}," + "\r\n" + "Форма обучения: {1}" + "\r\n" + "Группа: {2}" + "\r\n" + "Средний балл: {3}", person.ToString(), education, group, Average); 
        }
    }
}
