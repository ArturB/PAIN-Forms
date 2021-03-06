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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.typeTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.rokTextBox = new System.Windows.Forms.TextBox();
            this.PredkoscTextBox = new System.Windows.Forms.TextBox();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Usuń = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.chooser = new PAIN_Forms.CarTypeChooser();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.typeTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.markaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rokTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PredkoscTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Zapisz, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Usuń, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.idTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooser, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.91065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.25688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // typeTextBox
            // 
            this.typeTextBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.typeTextBox, 2);
            this.typeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeTextBox.Location = new System.Drawing.Point(122, 300);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(232, 31);
            this.typeTextBox.TabIndex = 12;
            this.typeTextBox.Text = "Osobowy";
            this.typeTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rok prod.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prędkość maks.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // markaTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.markaTextBox, 2);
            this.markaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markaTextBox.Location = new System.Drawing.Point(122, 48);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(232, 22);
            this.markaTextBox.TabIndex = 4;
            this.markaTextBox.Validated += new System.EventHandler(this.markaTextBox_Validated);
            // 
            // rokTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rokTextBox, 2);
            this.rokTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rokTextBox.Location = new System.Drawing.Point(122, 93);
            this.rokTextBox.Name = "rokTextBox";
            this.rokTextBox.Size = new System.Drawing.Size(232, 22);
            this.rokTextBox.TabIndex = 5;
            this.rokTextBox.Validated += new System.EventHandler(this.rokTextBox_Validated);
            // 
            // PredkoscTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PredkoscTextBox, 2);
            this.PredkoscTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredkoscTextBox.Location = new System.Drawing.Point(122, 138);
            this.PredkoscTextBox.Name = "PredkoscTextBox";
            this.PredkoscTextBox.Size = new System.Drawing.Size(232, 22);
            this.PredkoscTextBox.TabIndex = 6;
            this.PredkoscTextBox.Validated += new System.EventHandler(this.PredkoscTextBox_Validated);
            // 
            // Zapisz
            // 
            this.Zapisz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zapisz.Location = new System.Drawing.Point(122, 334);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(113, 42);
            this.Zapisz.TabIndex = 7;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Usuń
            // 
            this.Usuń.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usuń.Location = new System.Drawing.Point(241, 334);
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(113, 42);
            this.Usuń.TabIndex = 8;
            this.Usuń.Text = "Usuń";
            this.Usuń.UseVisualStyleBackColor = true;
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // idTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.idTextBox, 2);
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idTextBox.Location = new System.Drawing.Point(122, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(232, 22);
            this.idTextBox.TabIndex = 9;
            this.idTextBox.Visible = false;
            // 
            // chooser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.chooser, 2);
            this.chooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooser.imageIndex = 0;
            this.chooser.Location = new System.Drawing.Point(122, 183);
            this.chooser.Name = "chooser";
            this.chooser.Size = new System.Drawing.Size(232, 114);
            this.chooser.TabIndex = 13;
            this.chooser.typeChanged += new PAIN_Forms.CarTypeChangedHandler(this.choosed_typeChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Usuń;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label typeTextBox;
        private CarTypeChooser chooser;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}