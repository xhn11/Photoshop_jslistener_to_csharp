using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photoshop_jslistener_to_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resume = 0;
            string text = "";
            for (int i = 0; i < textBox1.Text.Length -15; i++)
            {

                if (textBox1.Text.Substring(i,i+13) == "charIDToTypeID")
                { 
                    text = text+textBox1.Text.Substring(resume,i)+"app.CharIDToTypeID";
                    resume = i+14;
                }
            }

            textBox2.Text = text;
             
        }


    }
}
