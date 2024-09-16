namespace View
{
    partial class ViewDL
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
            this.menuDL = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
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
            this.tableLayoutPanel1.Controls.Add(this.menuDL, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 570);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(34)))), ((int)(((byte)(79)))));
            this.panelNav.Controls.Add(this.flowButton);
            this.panelNav.Controls.Add(this.lblTitle);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.btnRefresh.Image = global::View.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(721, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 3;
            this.toolTipButton.SetToolTip(this.btnRefresh, "Tải lại trang");
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
            this.toolTipButton.SetToolTip(this.btnAdd, "Thêm file/folder");
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
            this.toolTipButton.SetToolTip(this.btnSearch, "Tìm file/folder");
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
            this.toolTipButton.SetToolTip(this.txtSearch, "Nhập file/folder cần tìm");
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DỮ LIỆU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuDL
            // 
            this.menuDL.AutoScroll = true;
            this.menuDL.AutoSize = true;
            this.menuDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(197)))));
            this.menuDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuDL.Location = new System.Drawing.Point(0, 48);
            this.menuDL.Margin = new System.Windows.Forms.Padding(0);
            this.menuDL.Name = "menuDL";
            this.menuDL.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.menuDL.Size = new System.Drawing.Size(965, 522);
            this.menuDL.TabIndex = 1;
            // 
            // ViewDL
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(965, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDL";
            this.Text = "ViewDL";
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
        private System.Windows.Forms.FlowLayoutPanel menuDL;
        private System.Windows.Forms.ToolTip toolTipButton;
    }
}