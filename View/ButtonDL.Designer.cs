namespace View
{
    partial class ButtonDL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.iconDL = new System.Windows.Forms.PictureBox();
            this.menuPhai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTenDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconDL)).BeginInit();
            this.menuPhai.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconDL
            // 
            this.iconDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(201)))), ((int)(((byte)(233)))));
            this.iconDL.ContextMenuStrip = this.menuPhai;
            this.iconDL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDL.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconDL.InitialImage = null;
            this.iconDL.Location = new System.Drawing.Point(0, 0);
            this.iconDL.Margin = new System.Windows.Forms.Padding(0);
            this.iconDL.Name = "iconDL";
            this.iconDL.Size = new System.Drawing.Size(60, 58);
            this.iconDL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconDL.TabIndex = 1;
            this.iconDL.TabStop = false;
            this.iconDL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDL_MouseClick);
            // 
            // menuPhai
            // 
            this.menuPhai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSua,
            this.btnXoa});
            this.menuPhai.Name = "menuPhai";
            this.menuPhai.Size = new System.Drawing.Size(134, 48);
            // 
            // btnSua
            // 
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 22);
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 22);
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTenDL
            // 
            this.btnTenDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.btnTenDL.ContextMenuStrip = this.menuPhai;
            this.btnTenDL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTenDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTenDL.FlatAppearance.BorderSize = 0;
            this.btnTenDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenDL.Location = new System.Drawing.Point(60, 0);
            this.btnTenDL.Margin = new System.Windows.Forms.Padding(4);
            this.btnTenDL.Name = "btnTenDL";
            this.btnTenDL.Size = new System.Drawing.Size(242, 58);
            this.btnTenDL.TabIndex = 2;
            this.btnTenDL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTenDL.UseVisualStyleBackColor = false;
            this.btnTenDL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDL_MouseClick);
            // 
            // ButtonDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnTenDL);
            this.Controls.Add(this.iconDL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ButtonDL";
            this.Size = new System.Drawing.Size(302, 58);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDL_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.iconDL)).EndInit();
            this.menuPhai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconDL;
        private System.Windows.Forms.Button btnTenDL;
        private System.Windows.Forms.ContextMenuStrip menuPhai;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
    }
}
