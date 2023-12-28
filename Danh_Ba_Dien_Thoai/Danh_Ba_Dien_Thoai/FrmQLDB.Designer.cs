namespace Danh_Ba_Dien_Thoai
{
    partial class FrmQLDB
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnChan = new System.Windows.Forms.Button();
            this.btnBlock = new FontAwesome.Sharp.IconButton();
            this.btnGuiMail = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(283, 102);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(45, 28);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(368, 102);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(45, 28);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(319, 102);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(54, 28);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = ".";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH BẠ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoVaTen";
            this.Column1.HeaderText = "Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 380;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvData.Location = new System.Drawing.Point(1, 194);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(429, 491);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnChan
            // 
            this.BtnChan.Location = new System.Drawing.Point(253, 145);
            this.BtnChan.Name = "BtnChan";
            this.BtnChan.Size = new System.Drawing.Size(75, 30);
            this.BtnChan.TabIndex = 9;
            this.BtnChan.Text = "Chặn";
            this.BtnChan.UseVisualStyleBackColor = true;
            this.BtnChan.Click += new System.EventHandler(this.BtnChan_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.Transparent;
            this.btnBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnBlock.IconColor = System.Drawing.Color.White;
            this.btnBlock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBlock.IconSize = 30;
            this.btnBlock.Location = new System.Drawing.Point(242, 102);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(45, 28);
            this.btnBlock.TabIndex = 10;
            this.btnBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnGuiMail
            // 
            this.btnGuiMail.BackColor = System.Drawing.Color.Transparent;
            this.btnGuiMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiMail.FlatAppearance.BorderSize = 0;
            this.btnGuiMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiMail.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnGuiMail.IconColor = System.Drawing.Color.White;
            this.btnGuiMail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuiMail.IconSize = 30;
            this.btnGuiMail.Location = new System.Drawing.Point(200, 102);
            this.btnGuiMail.Name = "btnGuiMail";
            this.btnGuiMail.Size = new System.Drawing.Size(45, 28);
            this.btnGuiMail.TabIndex = 11;
            this.btnGuiMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuiMail.UseVisualStyleBackColor = false;
            this.btnGuiMail.Click += new System.EventHandler(this.btnGuiMail_Click);
            // 
            // FrmQLDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(425, 673);
            this.Controls.Add(this.btnGuiMail);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.BtnChan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Name = "FrmQLDB";
            this.Text = "Danh bạ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQLDB_FormClosing);
            this.Load += new System.EventHandler(this.FrmQLDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnChan;
        private FontAwesome.Sharp.IconButton btnBlock;
        private FontAwesome.Sharp.IconButton btnGuiMail;
    }
}