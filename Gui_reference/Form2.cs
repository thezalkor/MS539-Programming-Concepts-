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
            //Counts the entries and displays error if more than 10 would be entered. Stops inputs
            if (listBox_Weights.Items.Count > 10)
            {
                errorProvider2.SetError(listBox_Weights, "Maximum entries reached : 10");
            }
            else
            {
                errorProvider2.SetError(listBox_Weights, "");
                string newInput = textBox_Input.Text;
                listBox_Weights.Items.Add(newInput);
                textBox_Input.Clear();
            }

            /*Should Get User input from the  text box and add it to to the List Display. 
            string newInput = textBox_Input.Text;
            listBox_Weights.Items.Add(newInput);
            textBox_Input.Clear();*/
        }

        private void textBox_Input_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //Checks for certain inputs. Only whole numbers and Decimal numbers Displays error if anything else is tried. 
            if (char.IsControl(e.KeyChar))
            {
                errorProvider2.SetError(textBox_Input, "");
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                errorProvider2.SetError(textBox_Input, "");
                return;
            }

            if (e.KeyChar == '.' && textBox_Input.Text.IndexOf('.') == -1)
            {
                errorProvider2.SetError(textBox_Input, "");
                return;
            }

            e.Handled = true;
            errorProvider2.SetError(textBox_Input, "Only Decimal or Whole Numbers Allowed");
        }

        private void button_HelpHandler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Whole Number example : 8  \n Decimal Number Example : 6.2 ");
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if(listBox_Weights.Items.Count > 0)
            {
                listBox_Weights.Items.RemoveAt(0);
                errorProvider2.SetError(listBox_Weights, "");
            }
            else
            {
                errorProvider2.SetError(listBox_Weights, "No entries to remove!");
            }
        }
    }
}
