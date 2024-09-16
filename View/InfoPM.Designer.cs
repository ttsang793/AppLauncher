namespace View
{
    partial class InfoPM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.txtTenPM = new System.Windows.Forms.TextBox();
            this.iconPM = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTipPM = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPM)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtTenPM);
            this.panel1.Controls.Add(this.iconPM);
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 260);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(250, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(50, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLink);
            this.groupBox1.Controls.Add(this.txtDuongDan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đường dẫn. VD: C:\\hello.exe";
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.LightGray;
            this.btnLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLink.Location = new System.Drawing.Point(220, 63);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(150, 30);
            this.btnLink.TabIndex = 1;
            this.btnLink.Text = "Import phần mềm";
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            this.btnLink.MouseEnter += new System.EventHandler(this.btnLink_MouseEnter);
            this.btnLink.MouseLeave += new System.EventHandler(this.btnLink_MouseLeave);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDuongDan.Location = new System.Drawing.Point(6, 25);
            this.txtDuongDan.MaxLength = 40000;
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(364, 32);
            this.txtDuongDan.TabIndex = 12;
            // 
            // txtTenPM
            // 
            this.txtTenPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTenPM.Location = new System.Drawing.Point(78, 54);
            this.txtTenPM.MaxLength = 60;
            this.txtTenPM.Name = "txtTenPM";
            this.txtTenPM.Size = new System.Drawing.Size(310, 32);
            this.txtTenPM.TabIndex = 2;
            this.toolTipPM.SetToolTip(this.txtTenPM, "Nhập tên phần mềm");
            // 
            // iconPM
            // 
            this.iconPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPM.Location = new System.Drawing.Point(12, 40);
            this.iconPM.Margin = new System.Windows.Forms.Padding(0);
            this.iconPM.Name = "iconPM";
            this.iconPM.Size = new System.Drawing.Size(60, 60);
            this.iconPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPM.TabIndex = 1;
            this.iconPM.TabStop = false;
            this.toolTipPM.SetToolTip(this.iconPM, "Icon của phần mềm");
            this.iconPM.Click += new System.EventHandler(this.iconPM_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(400, 30);
            this.panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(370, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InfoPM
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPM)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenPM;
        private System.Windows.Forms.PictureBox iconPM;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.ToolTip toolTipPM;
    }
}