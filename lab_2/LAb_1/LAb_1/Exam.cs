using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_1
{
    class Exam
    {
        public string Discipline
        {
            set;
            get;
        }
        public int Score
        {
            set;
            get;
        }
        public DateTime Date
        {
            set;
            get;
        }

        public Exam()
        {
            Discipline = "История";
            Score = 4;
            Date = new DateTime(2015, 9, 28);
        }
        public Exam(string dis, int score, DateTime date)
        {
            Discipline = dis;
            Score = score;
            Date = date;        
        }
        public override string ToString()
        {
            return string.Format("Предмет: {0}, Оценка: {1}, Дата: {2}", Discipline, Score, Date.ToString("d"));
        }
    }
}
