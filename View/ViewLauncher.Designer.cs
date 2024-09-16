namespace View
{
    partial class ViewLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLauncher));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnDL = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnDL);
            this.panelMenu.Controls.Add(this.btnPM);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(60, 570);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(140)))), ((int)(((byte)(212)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::View.Properties.Resources.about;
            this.btnAbout.Location = new System.Drawing.Point(0, 510);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 60);
            this.btnAbout.TabIndex = 3;
            this.toolTipMenu.SetToolTip(this.btnAbout, "Giới thiệu");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnDL
            // 
            this.btnDL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDL.FlatAppearance.BorderSize = 0;
            this.btnDL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(140)))), ((int)(((byte)(212)))));
            this.btnDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDL.Image = global::View.Properties.Resources.file;
            this.btnDL.Location = new System.Drawing.Point(0, 60);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(60, 60);
            this.btnDL.TabIndex = 1;
            this.toolTipMenu.SetToolTip(this.btnDL, "File và folder");
            this.btnDL.UseVisualStyleBackColor = true;
            this.btnDL.Click += new System.EventHandler(this.btnDL_Click);
            // 
            // btnPM
            // 
            this.btnPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(140)))), ((int)(((byte)(212)))));
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Image = global::View.Properties.Resources.program;
            this.btnPM.Location = new System.Drawing.Point(0, 0);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(60, 60);
            this.btnPM.TabIndex = 0;
            this.toolTipMenu.SetToolTip(this.btnPM, "Phần mềm");
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(195)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(60, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(975, 570);
            this.panelForm.TabIndex = 2;
            // 
            // ViewLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 570);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 200);
            this.Name = "ViewLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.ViewLauncher_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnDL;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.Button btnAbout;
    }
}