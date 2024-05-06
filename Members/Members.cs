using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member public field
        public int age;

        public string JobTitle {
            // member property that ex´pses jobtitle safely 
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }

        }

        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}," +
                    " im {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is [0]", salary);
        }

        //member constructor
        public Members()
        {
            age = 2123;
            memberName = "Lolan";
            salary = 9000000;
            jobTitle = "General";
            Console.WriteLine("Object Created");
        }
    }
}
