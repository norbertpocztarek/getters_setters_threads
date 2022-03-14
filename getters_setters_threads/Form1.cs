using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace getters_setters_threads
{
    public partial class Form1 : Form
    {
        NewClass nc = new NewClass("Nor");
        public Form1()
        {
            InitializeComponent();
           
            Debug.WriteLine("Nowe imie: " + nc.Name);
        }

        static void d_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           Debug.WriteLine("Property {0} just changed", e.PropertyName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewClass nc = new NewClass("Nor");
            nc.PropertyChanged += d_PropertyChanged;

            nc.Name = "Jamajka";
        }

        private void showChanges()
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewClass nc = new NewClass("");
            nc.PropertyChanged += d_PropertyChanged;
            int i = 0;

            while (nc.Name != "Nor100")
            {
                nc.Name = "Nor"+ i++;
                richTextBox1.AppendText(nc.Name + "\r\n");
                richTextBox1.ScrollToCaret();
                showChanges();
            }
        }
    }
}
