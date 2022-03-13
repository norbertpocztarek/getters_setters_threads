using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getters_setters_threads
{
    public partial class Form1 : Form
    {
        NewClass nc = new NewClass("Nor");
        public Form1()
        {
            InitializeComponent();
            nc.Name = "Norber";
            System.Diagnostics.Debug.WriteLine("Nowe imie: " + nc.Name);

        }
        
    }
}
