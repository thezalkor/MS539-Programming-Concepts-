namespace Gui_reference
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Start = new Button();
            button_Stop = new Button();
            progress_StartStop = new ProgressBar();
            textBox_Update = new TextBox();
            checkBox_UpdateStart = new CheckBox();
            checkBox_UpdateStop = new CheckBox();
            panel_StartStop = new Panel();
            button_newForm1 = new Button();
            panel_StartStop.SuspendLayout();
            SuspendLayout();
            // 
            // button_Start
            // 
            button_Start.BackColor = SystemColors.ActiveCaption;
            button_Start.Enabled = false;
            button_Start.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Start.Location = new Point(3, 24);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(125, 63);
            button_Start.TabIndex = 0;
            button_Start.Text = "START";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // button_Stop
            // 
            button_Stop.BackColor = Color.DarkOrange;
            button_Stop.Enabled = false;
            button_Stop.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Stop.Location = new Point(134, 24);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(125, 63);
            button_Stop.TabIndex = 1;
            button_Stop.Text = "STOP";
            button_Stop.UseVisualStyleBackColor = false;
            button_Stop.Click += button_Stop_Click;
            // 
            // progress_StartStop
            // 
            progress_StartStop.BackColor = Color.MistyRose;
            progress_StartStop.Location = new Point(59, 136);
            progress_StartStop.Maximum = 630;
            progress_StartStop.Name = "progress_StartStop";
            progress_StartStop.Size = new Size(630, 39);
            progress_StartStop.Step = 100;
            progress_StartStop.TabIndex = 2;
            // 
            // textBox_Update
            // 
            textBox_Update.BackColor = Color.LightCyan;
            textBox_Update.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Update.Location = new Point(220, 103);
            textBox_Update.Name = "textBox_Update";
            textBox_Update.ReadOnly = true;
            textBox_Update.Size = new Size(277, 27);
            textBox_Update.TabIndex = 3;
            // 
            // checkBox_UpdateStart
            // 
            checkBox_UpdateStart.AutoSize = true;
            checkBox_UpdateStart.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_UpdateStart.Location = new Point(3, 3);
            checkBox_UpdateStart.Name = "checkBox_UpdateStart";
            checkBox_UpdateStart.Size = new Size(118, 18);
            checkBox_UpdateStart.TabIndex = 4;
            checkBox_UpdateStart.Text = "Click to Enable";
            checkBox_UpdateStart.UseVisualStyleBackColor = true;
            checkBox_UpdateStart.CheckedChanged += checkBox_Update_CheckedChanged;
            // 
            // checkBox_UpdateStop
            // 
            checkBox_UpdateStop.AutoSize = true;
            checkBox_UpdateStop.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_UpdateStop.Location = new Point(134, 0);
            checkBox_UpdateStop.Name = "checkBox_UpdateStop";
            checkBox_UpdateStop.Size = new Size(118, 18);
            checkBox_UpdateStop.TabIndex = 5;
            checkBox_UpdateStop.Text = "Click to Enable";
            checkBox_UpdateStop.UseVisualStyleBackColor = true;
            checkBox_UpdateStop.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel_StartStop
            // 
            panel_StartStop.BackColor = Color.Plum;
            panel_StartStop.Controls.Add(button_Start);
            panel_StartStop.Controls.Add(checkBox_UpdateStop);
            panel_StartStop.Controls.Add(checkBox_UpdateStart);
            panel_StartStop.Controls.Add(button_Stop);
            panel_StartStop.Location = new Point(232, 181);
            panel_StartStop.Name = "panel_StartStop";
            panel_StartStop.Size = new Size(265, 100);
            panel_StartStop.TabIndex = 6;
            // 
            // button_newForm1
            // 
            button_newForm1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button_newForm1.Location = new Point(317, 407);
            button_newForm1.Name = "button_newForm1";
            button_newForm1.Size = new Size(114, 31);
            button_newForm1.TabIndex = 7;
            button_newForm1.Text = "New Form";
            button_newForm1.UseVisualStyleBackColor = true;
            button_newForm1.Click += button_newForm1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_newForm1);
            Controls.Add(panel_StartStop);
            Controls.Add(textBox_Update);
            Controls.Add(progress_StartStop);
            Name = "Form1";
            Text = "Form1";
            panel_StartStop.ResumeLayout(false);
            panel_StartStop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Start;
        private Button button_Stop;
        private ProgressBar progress_StartStop;
        private TextBox textBox_Update;
        private CheckBox checkBox_UpdateStart;
        private CheckBox checkBox_UpdateStop;
        private Panel panel_StartStop;
        private Button button_newForm1;
    }
}
