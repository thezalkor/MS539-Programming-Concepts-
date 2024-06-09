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
            progress_StartStop.Style = ProgressBarStyle.Marquee;
            textBox_Update.Text = "Progress Bar has Started";
            textBox_Update.BackColor = Color.Green;
            panel_StartStop.BackColor = Color.Beige;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            progress_StartStop.Style = ProgressBarStyle.Blocks;
            textBox_Update.Text = "Progress Bar has Stopped";
            textBox_Update.BackColor = Color.Orange;
            panel_StartStop.BackColor = Color.Red;
        }

        private void checkBox_Update_CheckedChanged(object sender, EventArgs e)
        {
            button_Start.Enabled = checkBox_UpdateStart.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button_Stop.Enabled = checkBox_UpdateStop.Checked;
        }

        private void button_newForm1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
