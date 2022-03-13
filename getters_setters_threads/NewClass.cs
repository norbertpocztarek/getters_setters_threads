using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters_threads
{
    class NewClass
    {
        //getters and setters with some logic
        private string name;  //in code write snipets: propfull + 2xTab key

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "Norbert")
                    name = value;
                else
                    System.Diagnostics.Debug.WriteLine("Podane imie:" + value + " jest nieprawidłowe.");
            }
        }

        public NewClass(string name) //constructor - everything what is inside will be done when I will inicialise that class in main class, constructor has always the same name what a class has
        {
            this.name = name; //a word "this" it's always telling about that variable is from this class, that's mean to private variable "name" from class NewClass i will give value from iniciation part in main class
            System.Diagnostics.Debug.WriteLine("Constructor works and his name is: " + name);
        }

        public void setName(string n) //setter is giving access to change variable/s which are private in class
        {
            name = n;
        }

        public string getName() //getter is giving access to get value of variable
        {
            return name;
        }

       

    }
}
