namespace BankingApp2
{
    partial class OperationsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_perform = new System.Windows.Forms.Button();
            this.radio_withdraw = new System.Windows.Forms.RadioButton();
            this.radio_deposite = new System.Windows.Forms.RadioButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mode of Operation";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(255, 99);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 26);
            this.txt_amount.TabIndex = 3;
            // 
            // btn_perform
            // 
            this.btn_perform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perform.Location = new System.Drawing.Point(125, 247);
            this.btn_perform.Name = "btn_perform";
            this.btn_perform.Size = new System.Drawing.Size(82, 33);
            this.btn_perform.TabIndex = 6;
            this.btn_perform.Text = "Perform";
            this.btn_perform.UseVisualStyleBackColor = true;
            this.btn_perform.Click += new System.EventHandler(this.btn_perform_Click);
            // 
            // radio_withdraw
            // 
            this.radio_withdraw.AutoSize = true;
            this.radio_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_withdraw.Location = new System.Drawing.Point(255, 149);
            this.radio_withdraw.Name = "radio_withdraw";
            this.radio_withdraw.Size = new System.Drawing.Size(93, 24);
            this.radio_withdraw.TabIndex = 7;
            this.radio_withdraw.TabStop = true;
            this.radio_withdraw.Text = "Withdraw";
            this.radio_withdraw.UseVisualStyleBackColor = true;
            // 
            // radio_deposite
            // 
            this.radio_deposite.AutoSize = true;
            this.radio_deposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_deposite.Location = new System.Drawing.Point(255, 193);
            this.radio_deposite.Name = "radio_deposite";
            this.radio_deposite.Size = new System.Drawing.Size(91, 24);
            this.radio_deposite.TabIndex = 8;
            this.radio_deposite.TabStop = true;
            this.radio_deposite.Text = "Deposite";
            this.radio_deposite.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(255, 247);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 335);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.radio_deposite);
            this.Controls.Add(this.radio_withdraw);
            this.Controls.Add(this.btn_perform);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OperationsForm";
            this.Text = "OperationsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_perform;
        private System.Windows.Forms.RadioButton radio_withdraw;
        private System.Windows.Forms.RadioButton radio_deposite;
        private System.Windows.Forms.Button btn_back;
    }
}