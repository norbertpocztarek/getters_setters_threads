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
using System.Threading;

namespace getters_setters_threads
{
    public partial class Form1 : Form
    {
        NewClass nc = new NewClass();
        #region GUI Delegate Declarations
        public delegate void GUIStatus(string paramString);
        #endregion

        
        public Form1()
        {
            InitializeComponent();
           
            //Debug.WriteLine("Nowe imie: " + nc.Name);
        }

        /*
        public void DoGUIStatusCAN(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIStatus delegateMethod = new GUIStatus(this.DoGUIStatusCAN);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
            {
                this.textBox1.Text = paramString + "\r\n";
                this.textBox1.ScrollToCaret();

            }
        }
        */

        void d_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           Debug.WriteLine("Property {0} just changed", e.PropertyName);
           richTextBox1.AppendText(nc.Name + "\r\n");
           //richTextBox1.ScrollToCaret();
           //showChanges();
           //DoGUIStatusCAN(nc.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NewClass nc = new NewClass();
            //nc.PropertyChanged += d_PropertyChanged;

            nc.Name = "Jamajka";
        }

        private void showChanges()
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NewClass nc = new NewClass();
            nc.PropertyChanged += d_PropertyChanged;
            int i = 0;
            nc.Name = "";
            while (nc.Name != "Nor100")
            {
                //Thread.Sleep(100);
                nc.Name = "Nor"+ i++;
                
            }
        }
    }
}
