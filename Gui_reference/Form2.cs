using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_reference
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            // System Methods Close for closing form, Dispose for handling memory leaks
            this.Close();
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //Should Get User input from the  text box and add it to to the List Display. 
            string newInput = textBox_Input.Text;
            listBox_Weights.Items.Add(newInput);
            textBox_Input.Clear();
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
