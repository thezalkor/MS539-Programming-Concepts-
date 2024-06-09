namespace Gui_reference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (!checkBox_UpdateStart.Checked)
            {
                errorProvider1.SetError(checkBox_UpdateStart, "Box not checked!");
            }
            else
            {
                errorProvider1.SetError(checkBox_UpdateStart, "");
                progress_StartStop.Style = ProgressBarStyle.Marquee;
                textBox_Update.Text = "Progress Bar has Started";
                textBox_Update.BackColor = Color.Green;
                panel_StartStop.BackColor = Color.Beige;
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {

            if (!checkBox_UpdateStop.Checked)
            {
                errorProvider1.SetError(checkBox_UpdateStop, "You didn't check the box!");
            }
            else
            {
                errorProvider1.SetError(checkBox_UpdateStop, "");
                progress_StartStop.Style = ProgressBarStyle.Blocks;
                textBox_Update.Text = "Progress Bar has Started";
                textBox_Update.BackColor = Color.Green;
                panel_StartStop.BackColor = Color.Beige;
            }
        }

        private void checkBox_Update_CheckedChanged(object sender, EventArgs e)
        {
            // button_Start.Enabled = checkBox_UpdateStart.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // button_Stop.Enabled = checkBox_UpdateStop.Checked;
        }

        private void button_newForm1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void num_Error_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Casting as an INT
            int output = (int)num_Error.Value;
            if (output > 20)
            {
                errorProvider1.SetError(num_Error, "Max Input of 20 allowed");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(num_Error, "");
                int outputValidated = (int)num_Error.Value;
            }
        }
    }
}
