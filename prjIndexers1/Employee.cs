using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexers1
{
    public class Employee
    {
        private double salary;
        private string empNumber, jobTitle, name, surname;

        public Employee(string empNumber, string name, string surname, string jobTitle, double salary)
        {
            this.empNumber = empNumber;
            this.name = name;
            this.surname = surname;
            this.jobTitle = jobTitle;
            this.salary = salary;
        }
        //First indexer, allows access using integers
        public object this[int index]
        {
            get
            {
                if (index == 0)

                    return this.empNumber; //returns value based on index
                else if (index == 1)
                    return this.name;
                else if (index == 2)
                    return this.surname;
                else if (index == 3)
                    return this.jobTitle;
                else if (index == 4)
                    return this.salary;
                return null;
            }
            set
            {
                if (index == 0)
                    this.empNumber = (string)value; //sets value based on index
                else if (index == 1)
                    this.name = (string)value;
                else if (index == 2)
                    this.surname = (string)value;
                else if (index == 3)
                    this.jobTitle = (string)value;
                else if (index == 4)
                    this.salary = Convert.ToDouble(value);
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("empnumber"))
                    return this.empNumber; //returns value based on attribute name
                else if (attrName.ToLower().Equals("name"))
                    return this.name;
                else if (attrName.ToLower().Equals("surname"))
                    return this.surname;
                else if (attrName.ToLower().Equals("jobtitle"))
                    return this.jobTitle;
                else if (attrName.ToLower().Equals("salary"))
                    return this.salary;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("empnumber"))
                    this.empNumber = (string)value; //sets value based on attribute name
                else if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (attrName.ToLower().Equals("surname"))
                    this.surname = (string)value;
                else if (attrName.ToLower().Equals("jobtitle"))
                    this.jobTitle = (string)value;
                else if (attrName.ToLower().Equals("salary"))
                    this.salary = Convert.ToDouble(value);
            }
        }

    }
}

