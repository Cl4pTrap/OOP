using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_1
{
    class Person : IdateAndCopy
    {
        protected string First_Name;
        protected string Last_name;
        protected DateTime date;

        public string FirstName
        {
            set
            {
                First_Name = value;            
            }
            get
            {
                return First_Name;
            }
        }

        public string LastName
        {
            set
            {
                Last_name = value;
            }
            get
            {
                return Last_name;
            }
        }

        public DateTime Date
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
        public int CreateYear
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
            First_Name = "Анатолий";
            Last_name = "Миценгендлер";
            date = new DateTime(1990, 1, 1);
        }

        public Person(string fName, string lName, DateTime date)
        {
            this.First_Name = fName;
            this.Last_name = lName;
            this.date = date;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}" + "\r\n" + "Дата рождения: {2}", First_Name, Last_name, date.ToString("d"));
        }
        public virtual string ToShortString()
        {
            return string.Format("{0} {1}", First_Name, Last_name);
        }
        public virtual object DeepCopy()
        {
            return new Person(FirstName, LastName, Date);
        }
        public static bool operator == (Person op1, Person op2)
        {
            bool result = false;
            if (op1.GetHashCode() == op2.GetHashCode())
            {
                if ((op1.FirstName == op2.FirstName) && (op1.LastName == op2.LastName) && (op1.Date == op2.Date))
                {
                    result = true;
                }                
            }
            return result; 
        }
        public static bool operator !=(Person op1, Person op2)
        {
            bool result = true;
            if (op1.GetHashCode() != op2.GetHashCode())
            {                
                if ((op1.FirstName == op2.FirstName) && (op1.LastName == op2.LastName) && (op1.Date == op2.Date))
                {
                    result = false;
                }
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            bool result = false;            
            if ((obj is Person) || (obj is Student))
            {
                if (this == (Person)obj)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        public override int GetHashCode()
        {            
            string hash = First_Name.Length.ToString() + Last_name.Length.ToString() + date.Year.ToString() + date.Month.ToString() + date.Day.ToString();
            return int.Parse(hash);
        }
        
    }
}
