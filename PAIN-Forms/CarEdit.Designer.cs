﻿namespace PAIN_Forms
{
    partial class CarEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.rokTextBox = new System.Windows.Forms.TextBox();
            this.PredkoscTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Usuń = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.markaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rokTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PredkoscTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Usuń, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rok prod.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prędkość maks.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // markaTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.markaTextBox, 2);
            this.markaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markaTextBox.Location = new System.Drawing.Point(122, 52);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(232, 22);
            this.markaTextBox.TabIndex = 4;
            // 
            // rokTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rokTextBox, 2);
            this.rokTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rokTextBox.Location = new System.Drawing.Point(122, 101);
            this.rokTextBox.Name = "rokTextBox";
            this.rokTextBox.Size = new System.Drawing.Size(232, 22);
            this.rokTextBox.TabIndex = 5;
            // 
            // PredkoscTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PredkoscTextBox, 2);
            this.PredkoscTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredkoscTextBox.Location = new System.Drawing.Point(122, 150);
            this.PredkoscTextBox.Name = "PredkoscTextBox";
            this.PredkoscTextBox.Size = new System.Drawing.Size(232, 22);
            this.PredkoscTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(122, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usuń
            // 
            this.Usuń.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usuń.Location = new System.Drawing.Point(241, 330);
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(113, 46);
            this.Usuń.TabIndex = 8;
            this.Usuń.Text = "Usuń";
            this.Usuń.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(122, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // CarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarEdit";
            this.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Text = "Edytuj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarEdit_FormClosing);
            this.Load += new System.EventHandler(this.CarEdit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox rokTextBox;
        private System.Windows.Forms.TextBox PredkoscTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Usuń;
        private System.Windows.Forms.TextBox textBox1;
    }
}