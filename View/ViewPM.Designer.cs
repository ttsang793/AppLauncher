namespace View
{
    partial class ViewPM
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.flowButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuPM = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.flowButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelNav, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuPM, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelNav.Controls.Add(this.flowButton);
            this.panelNav.Controls.Add(this.lblTitle);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNav.ForeColor = System.Drawing.Color.White;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.panelNav.Size = new System.Drawing.Size(965, 48);
            this.panelNav.TabIndex = 0;
            // 
            // flowButton
            // 
            this.flowButton.Controls.Add(this.btnRefresh);
            this.flowButton.Controls.Add(this.btnAdd);
            this.flowButton.Controls.Add(this.btnSearch);
            this.flowButton.Controls.Add(this.txtSearch);
            this.flowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButton.Location = new System.Drawing.Point(200, 4);
            this.flowButton.Margin = new System.Windows.Forms.Padding(0);
            this.flowButton.Name = "flowButton";
            this.flowButton.Size = new System.Drawing.Size(761, 40);
            this.flowButton.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(721, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 3;
            this.toolTipMenu.SetToolTip(this.btnRefresh, "Tải lại trang");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::View.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(677, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 2;
            this.toolTipMenu.SetToolTip(this.btnAdd, "Thêm phần mềm");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::View.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(633, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 1;
            this.toolTipMenu.SetToolTip(this.btnSearch, "Tìm phần mềm");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSearch.Location = new System.Drawing.Point(329, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 40);
            this.txtSearch.TabIndex = 0;
            this.toolTipMenu.SetToolTip(this.txtSearch, "Nhập phần mềm cần tìm");
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PHẦN MỀM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuPM
            // 
            this.menuPM.AutoScroll = true;
            this.menuPM.AutoSize = true;
            this.menuPM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(195)))));
            this.menuPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPM.Location = new System.Drawing.Point(0, 48);
            this.menuPM.Margin = new System.Windows.Forms.Padding(0);
            this.menuPM.Name = "menuPM";
            this.menuPM.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.menuPM.Size = new System.Drawing.Size(965, 522);
            this.menuPM.TabIndex = 1;
            // 
            // ViewPM
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(965, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPM";
            this.Text = "ViewPM";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.flowButton.ResumeLayout(false);
            this.flowButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.FlowLayoutPanel flowButton;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel menuPM;
        private System.Windows.Forms.ToolTip toolTipMenu;
    }
}