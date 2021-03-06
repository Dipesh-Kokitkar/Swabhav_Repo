﻿namespace BankingApp2
{
    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lab_inital = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.doOperationToolStripMenuItem,
            this.passbookToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(633, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // doOperationToolStripMenuItem
            // 
            this.doOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doTransactionToolStripMenuItem});
            this.doOperationToolStripMenuItem.Name = "doOperationToolStripMenuItem";
            this.doOperationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.doOperationToolStripMenuItem.Text = "Operation";
            this.doOperationToolStripMenuItem.Click += new System.EventHandler(this.doOperationToolStripMenuItem_Click);
            // 
            // doTransactionToolStripMenuItem
            // 
            this.doTransactionToolStripMenuItem.Name = "doTransactionToolStripMenuItem";
            this.doTransactionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.doTransactionToolStripMenuItem.Text = "Do Transaction";
            this.doTransactionToolStripMenuItem.Click += new System.EventHandler(this.doTransactionToolStripMenuItem_Click);
            // 
            // passbookToolStripMenuItem
            // 
            this.passbookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTransactionsToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.passbookToolStripMenuItem.Name = "passbookToolStripMenuItem";
            this.passbookToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.passbookToolStripMenuItem.Text = "Passbook";
            // 
            // showTransactionsToolStripMenuItem
            // 
            this.showTransactionsToolStripMenuItem.Name = "showTransactionsToolStripMenuItem";
            this.showTransactionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showTransactionsToolStripMenuItem.Text = "Show Transactions";
            this.showTransactionsToolStripMenuItem.Click += new System.EventHandler(this.showTransactionsToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "user";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(530, 81);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 29);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_inital
            // 
            this.lab_inital.AutoSize = true;
            this.lab_inital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_inital.Location = new System.Drawing.Point(23, 193);
            this.lab_inital.Name = "lab_inital";
            this.lab_inital.Size = new System.Drawing.Size(598, 20);
            this.lab_inital.TabIndex = 11;
            this.lab_inital.Text = "Currently no user logged in .Select account Menu and Login or Register into Syste" +
    "m";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 402);
            this.Controls.Add(this.lab_inital);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Bank App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lab_inital;
    }
}

