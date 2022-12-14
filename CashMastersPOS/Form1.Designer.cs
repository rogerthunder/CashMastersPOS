namespace CashMastersPOS
{
    partial class CashMastersPOS
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
            this.txtItemsPurchased = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalToReturn = new System.Windows.Forms.Label();
            this.lblValuetoRetrun = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price of items being pruchased";
            // 
            // txtItemsPurchased
            // 
            this.txtItemsPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsPurchased.Location = new System.Drawing.Point(26, 46);
            this.txtItemsPurchased.Name = "txtItemsPurchased";
            this.txtItemsPurchased.Size = new System.Drawing.Size(252, 26);
            this.txtItemsPurchased.TabIndex = 1;
            this.txtItemsPurchased.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemsPurchased_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select currency type to pay with";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total paying with $";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AutoSize = true;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(484, 22);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(34, 20);
            this.txtTotalAmount.TabIndex = 4;
            this.txtTotalAmount.Text = "0.0";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(324, 46);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(115, 26);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay!";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalToReturn
            // 
            this.lblTotalToReturn.AutoSize = true;
            this.lblTotalToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalToReturn.Location = new System.Drawing.Point(22, 197);
            this.lblTotalToReturn.Name = "lblTotalToReturn";
            this.lblTotalToReturn.Size = new System.Drawing.Size(138, 20);
            this.lblTotalToReturn.TabIndex = 6;
            this.lblTotalToReturn.Text = "Total to return : ";
            // 
            // lblValuetoRetrun
            // 
            this.lblValuetoRetrun.AutoSize = true;
            this.lblValuetoRetrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuetoRetrun.Location = new System.Drawing.Point(188, 197);
            this.lblValuetoRetrun.MaximumSize = new System.Drawing.Size(700, 200);
            this.lblValuetoRetrun.Name = "lblValuetoRetrun";
            this.lblValuetoRetrun.Size = new System.Drawing.Size(0, 20);
            this.lblValuetoRetrun.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(26, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CashMastersPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(614, 328);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblValuetoRetrun);
            this.Controls.Add(this.lblTotalToReturn);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemsPurchased);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashMastersPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashMasterPOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemsPurchased;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalToReturn;
        private System.Windows.Forms.Label lblValuetoRetrun;
        private System.Windows.Forms.Button btnClear;
    }
}

