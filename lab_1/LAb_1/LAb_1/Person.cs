using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_1
{
    class Person
    {
        private string fName;
        private string lName;
        private DateTime date;

        public string FirstName
        {
            set
            {
                fName = value;            
            }
            get
            {
                return fName;
            }
        }

        public string lName_pr
        {
            set
            {
                lName = value;
            }
            get
            {
                return lName;
            }
        }

        public DateTime date_pr
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
        public int create_year //CreateYear
        {
            set
            {
                date = new DateTime(value, date.Month, date.Day);
            }
            get
            {
                return date.Year;
            }
        }
                
        public Person()
        {
            fName = "Кирилл";
            lName = "Глущенко";
            date = new DateTime(1990, 1, 1);
        }

        public Person(string fName, string lName, DateTime date)
        {
            this.fName = fName;
            this.lName = lName;
            this.date = date;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}" + "\r\n" + "Дата рождения: {2}", fName, lName, date.ToString("d"));
        }
        public virtual string ToShortString()
        {
            return string.Format("{0} {1}", fName, lName);
        }
        
    }
    public enum Education
    {
        Specialist = 0, 
        Вachelor,
        SecondEducation
    }

}
