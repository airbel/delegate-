using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp2_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DelegateExample exDeg = new DelegateExample();
            exDeg.Run();
        }
    }

    class DelegateExample
    {
        public void Run()
        {
            InvokeDelegate(WriteToTextBox);
        }
        public delegate bool DelegateInvoker(string input1);
        public void InvokeDelegate(DelegateInvoker func)
        {
            var ret = func("hello word");
            Console.WriteLine(string.Format(" > delegate returned{0}", ret));
        }
        public bool WriteToTextBox(string input)
        {
            Console.WriteLine(string.Format("writeToConsole: '{0}'", input));
            return true;
        }


    }

   

}
