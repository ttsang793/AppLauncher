namespace View
{
    partial class ButtonPM
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
            this.iconPM = new System.Windows.Forms.PictureBox();
            this.menuPhai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTenPM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPM)).BeginInit();
            this.menuPhai.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPM
            // 
            this.iconPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.iconPM.ContextMenuStrip = this.menuPhai;
            this.iconPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPM.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPM.InitialImage = null;
            this.iconPM.Location = new System.Drawing.Point(0, 0);
            this.iconPM.Margin = new System.Windows.Forms.Padding(0);
            this.iconPM.Name = "iconPM";
            this.iconPM.Size = new System.Drawing.Size(60, 58);
            this.iconPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPM.TabIndex = 0;
            this.iconPM.TabStop = false;
            this.iconPM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPM_MouseClick);
            // 
            // menuPhai
            // 
            this.menuPhai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSua,
            this.btnXoa});
            this.menuPhai.Name = "menuPhai";
            this.menuPhai.Size = new System.Drawing.Size(156, 48);
            // 
            // btnSua
            // 
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 22);
            this.btnSua.Text = "Sửa phần mềm";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 22);
            this.btnXoa.Text = "Xóa phần mềm";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTenPM
            // 
            this.btnTenPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.btnTenPM.ContextMenuStrip = this.menuPhai;
            this.btnTenPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTenPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTenPM.FlatAppearance.BorderSize = 0;
            this.btnTenPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTenPM.Location = new System.Drawing.Point(60, 0);
            this.btnTenPM.Margin = new System.Windows.Forms.Padding(4);
            this.btnTenPM.Name = "btnTenPM";
            this.btnTenPM.Size = new System.Drawing.Size(242, 58);
            this.btnTenPM.TabIndex = 1;
            this.btnTenPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTenPM.UseVisualStyleBackColor = false;
            this.btnTenPM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPM_MouseClick);
            // 
            // ButtonPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.menuPhai;
            this.Controls.Add(this.btnTenPM);
            this.Controls.Add(this.iconPM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ButtonPM";
            this.Size = new System.Drawing.Size(302, 58);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPM_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.iconPM)).EndInit();
            this.menuPhai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPM;
        private System.Windows.Forms.Button btnTenPM;
        private System.Windows.Forms.ContextMenuStrip menuPhai;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
    }
}
