﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Natalie_App
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
            components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            panel1 = new Panel();
            label_Date = new Label();
            label_Weight = new Label();
            textBox_Weight = new TextBox();
            listbox_Weights = new ListBox();
            button_Remove = new Button();
            label_EnterWeight = new Label();
            button_Add = new Button();
            textBox_Date = new TextBox();
            errorProvider_Weight = new ErrorProvider(components);
            chart_GrowthTrend = new Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Weight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_GrowthTrend).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label_Date);
            panel1.Controls.Add(label_Weight);
            panel1.Controls.Add(textBox_Weight);
            panel1.Controls.Add(listbox_Weights);
            panel1.Controls.Add(button_Remove);
            panel1.Controls.Add(label_EnterWeight);
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(textBox_Date);
            panel1.Location = new Point(42, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 414);
            panel1.TabIndex = 1;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Date.Location = new Point(138, 155);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(130, 14);
            label_Date.TabIndex = 8;
            label_Date.Text = "Date DD/MM/YYY";
            // 
            // label_Weight
            // 
            label_Weight.AutoSize = true;
            label_Weight.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Weight.Location = new Point(172, 84);
            label_Weight.Name = "label_Weight";
            label_Weight.Size = new Size(54, 14);
            label_Weight.TabIndex = 7;
            label_Weight.Text = "Weight";
            // 
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(148, 172);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(100, 23);
            textBox_Weight.TabIndex = 6;
            // 
            // listbox_Weights
            // 
            listbox_Weights.Dock = DockStyle.Left;
            listbox_Weights.FormattingEnabled = true;
            listbox_Weights.ItemHeight = 15;
            listbox_Weights.Location = new Point(0, 0);
            listbox_Weights.Name = "listbox_Weights";
            listbox_Weights.Size = new Size(96, 414);
            listbox_Weights.TabIndex = 5;
            // 
            // button_Remove
            // 
            button_Remove.BackColor = Color.OrangeRed;
            button_Remove.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Remove.Location = new Point(216, 37);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(75, 23);
            button_Remove.TabIndex = 4;
            button_Remove.Text = "Remove Weight";
            button_Remove.UseVisualStyleBackColor = false;
            button_Remove.Click += button_Remove_Click;
            // 
            // label_EnterWeight
            // 
            label_EnterWeight.AutoSize = true;
            label_EnterWeight.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_EnterWeight.Location = new Point(117, 9);
            label_EnterWeight.Name = "label_EnterWeight";
            label_EnterWeight.Size = new Size(195, 14);
            label_EnterWeight.TabIndex = 3;
            label_EnterWeight.Text = "Enter Natalie's Weight Here.";
            label_EnterWeight.Click += label1_Click;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.SeaGreen;
            button_Add.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.Location = new Point(117, 37);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(75, 23);
            button_Add.TabIndex = 1;
            button_Add.Text = "Add Weight";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(148, 101);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(100, 23);
            textBox_Date.TabIndex = 2;
            textBox_Date.KeyPress += textBox_Weight_Keypress;
            // 
            // errorProvider_Weight
            // 
            errorProvider_Weight.ContainerControl = this;
            // 
            // chart_GrowthTrend
            // 
            chartArea1.Name = "ChartArea1";
            chart_GrowthTrend.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_GrowthTrend.Legends.Add(legend1);
            chart_GrowthTrend.Location = new Point(378, 184);
            chart_GrowthTrend.Name = "chart_GrowthTrend";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_GrowthTrend.Series.Add(series1);
            chart_GrowthTrend.Size = new Size(300, 300);
            chart_GrowthTrend.TabIndex = 9;
            chart_GrowthTrend.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 496);
            Controls.Add(chart_GrowthTrend);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_Weight).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_GrowthTrend).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button_Remove;
        private Label label_EnterWeight;
        private TextBox textBox_Date;
        private Button button_Add;
        private ListBox listbox_Weights;
        private ErrorProvider errorProvider_Weight;
        private TextBox textBox_Weight;
        private Label label_Date;
        private Label label_Weight;
        private Chart chart_GrowthTrend;
    }
}
