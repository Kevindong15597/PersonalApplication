namespace QuanLyPhongTro
{
    partial class FormMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.frmRoom = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDELETE = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPrice = new System.Windows.Forms.TabPage();
            this.frmPrice = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnAddPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteP = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.frmSession = new System.Windows.Forms.DataGridView();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.btnAddSession = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteS = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmRoom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPrice)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSession)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabRoom);
            this.tabControl.Controls.Add(this.tabPrice);
            this.tabControl.Controls.Add(this.tabSession);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(709, 536);
            this.tabControl.TabIndex = 0;
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.frmRoom);
            this.tabRoom.Controls.Add(this.menuStrip1);
            this.tabRoom.Location = new System.Drawing.Point(4, 25);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(701, 507);
            this.tabRoom.TabIndex = 0;
            this.tabRoom.Text = "Room";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // frmRoom
            // 
            this.frmRoom.AllowUserToAddRows = false;
            this.frmRoom.AllowUserToDeleteRows = false;
            this.frmRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmRoom.Location = new System.Drawing.Point(3, 3);
            this.frmRoom.Name = "frmRoom";
            this.frmRoom.ReadOnly = true;
            this.frmRoom.RowTemplate.Height = 24;
            this.frmRoom.Size = new System.Drawing.Size(574, 501);
            this.frmRoom.TabIndex = 0;
            this.frmRoom.DoubleClick += new System.EventHandler(this.frmRoom_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRoom,
            this.btnDELETE});
            this.menuStrip1.Location = new System.Drawing.Point(577, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(121, 501);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(108, 24);
            this.btnAddRoom.Text = "ADD Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(108, 24);
            this.btnDELETE.Text = "DELETE Room";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // tabPrice
            // 
            this.tabPrice.Controls.Add(this.frmPrice);
            this.tabPrice.Controls.Add(this.menuStrip2);
            this.tabPrice.Location = new System.Drawing.Point(4, 25);
            this.tabPrice.Name = "tabPrice";
            this.tabPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrice.Size = new System.Drawing.Size(641, 507);
            this.tabPrice.TabIndex = 1;
            this.tabPrice.Text = "Price";
            this.tabPrice.UseVisualStyleBackColor = true;
            // 
            // frmPrice
            // 
            this.frmPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmPrice.Location = new System.Drawing.Point(3, 3);
            this.frmPrice.Name = "frmPrice";
            this.frmPrice.RowTemplate.Height = 24;
            this.frmPrice.Size = new System.Drawing.Size(522, 501);
            this.frmPrice.TabIndex = 1;
            this.frmPrice.DoubleClick += new System.EventHandler(this.frmPrice_DoubleClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPrice,
            this.btnDeleteP});
            this.menuStrip2.Location = new System.Drawing.Point(525, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(113, 501);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(100, 24);
            this.btnAddPrice.Text = "ADD Price";
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(100, 24);
            this.btnDeleteP.Text = "DELETE Price";
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.frmSession);
            this.tabSession.Controls.Add(this.menuStrip3);
            this.tabSession.Location = new System.Drawing.Point(4, 25);
            this.tabSession.Name = "tabSession";
            this.tabSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabSession.Size = new System.Drawing.Size(641, 507);
            this.tabSession.TabIndex = 2;
            this.tabSession.Text = "Session";
            this.tabSession.UseVisualStyleBackColor = true;
            // 
            // frmSession
            // 
            this.frmSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSession.Location = new System.Drawing.Point(3, 3);
            this.frmSession.Name = "frmSession";
            this.frmSession.RowTemplate.Height = 24;
            this.frmSession.Size = new System.Drawing.Size(507, 501);
            this.frmSession.TabIndex = 0;
            this.frmSession.DoubleClick += new System.EventHandler(this.frmSession_DoubleClick);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSession,
            this.btnDeleteS});
            this.menuStrip3.Location = new System.Drawing.Point(510, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(128, 501);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // btnAddSession
            // 
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(115, 24);
            this.btnAddSession.Text = "ADD session";
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(115, 24);
            this.btnDeleteS.Text = "DELETE session";
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 549);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Quan Ly Phong Tro";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRoom.ResumeLayout(false);
            this.tabRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmRoom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPrice.ResumeLayout(false);
            this.tabPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPrice)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabSession.ResumeLayout(false);
            this.tabSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSession)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabPrice;
        private System.Windows.Forms.DataGridView frmRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddRoom;
        private System.Windows.Forms.DataGridView frmPrice;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnAddPrice;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.DataGridView frmSession;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem btnAddSession;
        private System.Windows.Forms.ToolStripMenuItem btnDELETE;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteP;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteS;
    }
}

