using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_1
{
    class Person
    {
        private string first_name;
        private string second_name;
        private DateTime birth;

       public Person() //default values
            {
            first_name = "";
            second_name = "";
            birth = DateTime.Today;
            }
        
        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }

        public string SecondName
        {
            get
            {
                return second_name;
            }
            set
            {
                second_name = value;
            }
        }

        public DateTime BirthTime
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;  
            }
        }

        public int BirthDate
        {
            get
            {
                return birth.Year;
            }
            set
            {
                birth = Convert.ToDateTime(value);
            }
        }

        public override string ToString()
        {
            return Convert.ToString(first_name + " " + second_name + " " + birth);
        }

        public string ToShortString()
        {
            return Convert.ToString(first_name + " " + second_name);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Person p = obj as Person;
            if ((Object)p == null)
                return false;
            return p.second_name == this.second_name && p.first_name == this.first_name && p.birth == this.birth;
        }

        public static  bool operator == (Person p1, Person p2)
        {
            if (p1.first_name == p2.first_name && p1.second_name == p2.second_name && p1.birth == p2.birth)
                return true;
            else return false;
        }
        public static bool operator != (Person p1, Person p2)
        {
            if (p1.first_name == p2.first_name && p1.second_name == p2.second_name && p1.birth == p2.birth)
                return false;
            else return true;
        }

        /*public bool Equals(Person obj) 
        {
            if (obj == null)
                return false;
            return obj.first_name == this.first_name && obj.second_name == this.second_name;
        }*/

        public override int GetHashCode()
        {
            return first_name.Length + second_name.Length + birth.Day + birth.Month + birth.Year;
        }
    }
}
