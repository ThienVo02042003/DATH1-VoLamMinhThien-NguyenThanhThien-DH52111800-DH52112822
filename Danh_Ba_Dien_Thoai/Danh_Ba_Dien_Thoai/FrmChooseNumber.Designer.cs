namespace Danh_Ba_Dien_Thoai
{
    partial class FrmChooseNumber
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
            this.lblPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.rbSDT1 = new System.Windows.Forms.RadioButton();
            this.rbSDT2 = new System.Windows.Forms.RadioButton();
            this.lblPhoneNumber2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhoneNumber1
            // 
            this.lblPhoneNumber1.Enabled = false;
            this.lblPhoneNumber1.Location = new System.Drawing.Point(182, 112);
            this.lblPhoneNumber1.Name = "lblPhoneNumber1";
            this.lblPhoneNumber1.Size = new System.Drawing.Size(200, 22);
            this.lblPhoneNumber1.TabIndex = 0;
            // 
            // rbSDT1
            // 
            this.rbSDT1.AutoSize = true;
            this.rbSDT1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbSDT1.Location = new System.Drawing.Point(122, 235);
            this.rbSDT1.Name = "rbSDT1";
            this.rbSDT1.Size = new System.Drawing.Size(123, 20);
            this.rbSDT1.TabIndex = 1;
            this.rbSDT1.TabStop = true;
            this.rbSDT1.Text = "Số Điện Thoại 1";
            this.rbSDT1.UseVisualStyleBackColor = true;
            // 
            // rbSDT2
            // 
            this.rbSDT2.AutoSize = true;
            this.rbSDT2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbSDT2.Location = new System.Drawing.Point(122, 285);
            this.rbSDT2.Name = "rbSDT2";
            this.rbSDT2.Size = new System.Drawing.Size(123, 20);
            this.rbSDT2.TabIndex = 2;
            this.rbSDT2.TabStop = true;
            this.rbSDT2.Text = "Số Điện Thoại 2";
            this.rbSDT2.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber2
            // 
            this.lblPhoneNumber2.Enabled = false;
            this.lblPhoneNumber2.Location = new System.Drawing.Point(185, 175);
            this.lblPhoneNumber2.Name = "lblPhoneNumber2";
            this.lblPhoneNumber2.Size = new System.Drawing.Size(197, 22);
            this.lblPhoneNumber2.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(147, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 43);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Điện Thoại 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(37, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Điện Thoại 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(68, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "CHỌN SỐ CHẶN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmChooseNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPhoneNumber2);
            this.Controls.Add(this.rbSDT2);
            this.Controls.Add(this.rbSDT1);
            this.Controls.Add(this.lblPhoneNumber1);
            this.Name = "FrmChooseNumber";
            this.Text = "Chọn số chặn";
            this.Load += new System.EventHandler(this.FrmChooseNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblPhoneNumber1;
        private System.Windows.Forms.RadioButton rbSDT1;
        private System.Windows.Forms.RadioButton rbSDT2;
        private System.Windows.Forms.TextBox lblPhoneNumber2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}