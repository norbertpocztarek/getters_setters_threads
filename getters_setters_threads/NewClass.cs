using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace getters_setters_threads
{
    class NewClass
    {
        //getters and setters with some logic, first it needs private variable, next getter and setter for that variable, mostly is common to use name of variable with first letter up
        private string name;  //in code write snipets: propfull + 2xTab key

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged();
                }
            }
        }

        //-- INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public NewClass(string name) //constructor - everything what is inside will be done when I will inicialise that class in main class, constructor has always the same name what a class has
        {
            this.name = name; //a word "this" it's always telling about that variable is from this class, that's mean to private variable "name" from class NewClass i will give value from iniciation part in main class
            System.Diagnostics.Debug.WriteLine("Constructor works and his name is: " + name);
        }
    }
}
