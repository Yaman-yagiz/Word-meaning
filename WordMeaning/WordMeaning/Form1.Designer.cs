﻿
namespace WordMeaning
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ControlBTN = new System.Windows.Forms.Button();
            this.MeaningTBOX = new System.Windows.Forms.TextBox();
            this.LevelCBOX = new System.Windows.Forms.ComboBox();
            this.ScoreLBL = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TestYapMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(118, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 199);
            this.listBox1.TabIndex = 0;
            // 
            // ControlBTN
            // 
            this.ControlBTN.Location = new System.Drawing.Point(12, 78);
            this.ControlBTN.Name = "ControlBTN";
            this.ControlBTN.Size = new System.Drawing.Size(75, 23);
            this.ControlBTN.TabIndex = 1;
            this.ControlBTN.Text = "Kontrol";
            this.ControlBTN.UseVisualStyleBackColor = true;
            this.ControlBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // MeaningTBOX
            // 
            this.MeaningTBOX.Location = new System.Drawing.Point(12, 52);
            this.MeaningTBOX.Name = "MeaningTBOX";
            this.MeaningTBOX.Size = new System.Drawing.Size(100, 20);
            this.MeaningTBOX.TabIndex = 2;
            // 
            // LevelCBOX
            // 
            this.LevelCBOX.FormattingEnabled = true;
            this.LevelCBOX.Location = new System.Drawing.Point(12, 25);
            this.LevelCBOX.Name = "LevelCBOX";
            this.LevelCBOX.Size = new System.Drawing.Size(100, 21);
            this.LevelCBOX.TabIndex = 3;
            this.LevelCBOX.SelectedValueChanged += new System.EventHandler(this.LevelCBOX_SelectedValueChanged);
            // 
            // ScoreLBL
            // 
            this.ScoreLBL.AutoSize = true;
            this.ScoreLBL.Location = new System.Drawing.Point(9, 104);
            this.ScoreLBL.Name = "ScoreLBL";
            this.ScoreLBL.Size = new System.Drawing.Size(76, 13);
            this.ScoreLBL.TabIndex = 4;
            this.ScoreLBL.Text = "Doğru Cevap: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestYapMENU});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TestYapMENU
            // 
            this.TestYapMENU.Name = "TestYapMENU";
            this.TestYapMENU.Size = new System.Drawing.Size(61, 20);
            this.TestYapMENU.Text = "Test Yap";
            this.TestYapMENU.Click += new System.EventHandler(this.TestYapMENU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 238);
            this.Controls.Add(this.ScoreLBL);
            this.Controls.Add(this.LevelCBOX);
            this.Controls.Add(this.MeaningTBOX);
            this.Controls.Add(this.ControlBTN);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ControlBTN;
        private System.Windows.Forms.TextBox MeaningTBOX;
        private System.Windows.Forms.ComboBox LevelCBOX;
        private System.Windows.Forms.Label ScoreLBL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TestYapMENU;
    }
}

