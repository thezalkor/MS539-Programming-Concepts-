﻿namespace Gui_reference
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button_Return = new Button();
            textBox_Input = new TextBox();
            listBox_Weights = new ListBox();
            button_Add = new Button();
            label1 = new Label();
            errorProvider2 = new ErrorProvider(components);
            button_HelpHandler = new Button();
            button_Remove = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button_Return
            // 
            button_Return.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Return.Location = new Point(333, 387);
            button_Return.Name = "button_Return";
            button_Return.Size = new Size(75, 23);
            button_Return.TabIndex = 0;
            button_Return.Text = "RETURN";
            button_Return.UseVisualStyleBackColor = true;
            button_Return.Click += button_Return_Click;
            // 
            // textBox_Input
            // 
            textBox_Input.Location = new Point(30, 80);
            textBox_Input.Name = "textBox_Input";
            textBox_Input.Size = new Size(100, 23);
            textBox_Input.TabIndex = 1;
            textBox_Input.KeyPress += textBox_Input_KeyPress;
            // 
            // listBox_Weights
            // 
            listBox_Weights.BackColor = Color.Moccasin;
            listBox_Weights.FormattingEnabled = true;
            listBox_Weights.ItemHeight = 15;
            listBox_Weights.Location = new Point(470, 36);
            listBox_Weights.Name = "listBox_Weights";
            listBox_Weights.Size = new Size(298, 304);
            listBox_Weights.TabIndex = 2;
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.Location = new Point(30, 125);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(100, 40);
            button_Add.TabIndex = 3;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 63);
            label1.Name = "label1";
            label1.Size = new Size(120, 14);
            label1.TabIndex = 4;
            label1.Text = "Enter Input Here";
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // button_HelpHandler
            // 
            button_HelpHandler.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button_HelpHandler.Location = new Point(162, 80);
            button_HelpHandler.Name = "button_HelpHandler";
            button_HelpHandler.Size = new Size(75, 23);
            button_HelpHandler.TabIndex = 5;
            button_HelpHandler.Text = "HELP";
            button_HelpHandler.UseVisualStyleBackColor = true;
            button_HelpHandler.Click += button_HelpHandler_Click;
            // 
            // button_Remove
            // 
            button_Remove.BackColor = Color.IndianRed;
            button_Remove.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Remove.Location = new Point(149, 125);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(100, 40);
            button_Remove.TabIndex = 6;
            button_Remove.Text = "REMOVE";
            button_Remove.UseVisualStyleBackColor = false;
            button_Remove.Click += button_Remove_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Remove);
            Controls.Add(button_HelpHandler);
            Controls.Add(label1);
            Controls.Add(button_Add);
            Controls.Add(listBox_Weights);
            Controls.Add(textBox_Input);
            Controls.Add(button_Return);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Return;
        private TextBox textBox_Input;
        private ListBox listBox_Weights;
        private Button button_Add;
        private Label label1;
        private ErrorProvider errorProvider2;
        private Button button_HelpHandler;
        private Button button_Remove;
    }
}