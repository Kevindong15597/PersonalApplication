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
            this.tabPrice = new System.Windows.Forms.TabPage();
            this.frmPrice = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aDDPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.frmSession = new System.Windows.Forms.DataGridView();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.btnAddSession = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl.Controls.Add(this.tabRoom);
            this.tabControl.Controls.Add(this.tabPrice);
            this.tabControl.Controls.Add(this.tabSession);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(493, 414);
            this.tabControl.TabIndex = 0;
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.frmRoom);
            this.tabRoom.Controls.Add(this.menuStrip1);
            this.tabRoom.Location = new System.Drawing.Point(4, 25);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(485, 385);
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
            this.frmRoom.Size = new System.Drawing.Size(376, 379);
            this.frmRoom.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRoom});
            this.menuStrip1.Location = new System.Drawing.Point(379, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(103, 379);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(90, 24);
            this.btnAddRoom.Text = "ADD Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // tabPrice
            // 
            this.tabPrice.Controls.Add(this.frmPrice);
            this.tabPrice.Controls.Add(this.menuStrip2);
            this.tabPrice.Location = new System.Drawing.Point(4, 25);
            this.tabPrice.Name = "tabPrice";
            this.tabPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrice.Size = new System.Drawing.Size(485, 385);
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
            this.frmPrice.Size = new System.Drawing.Size(384, 379);
            this.frmPrice.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDPriceToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(387, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(95, 379);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aDDPriceToolStripMenuItem
            // 
            this.aDDPriceToolStripMenuItem.Name = "aDDPriceToolStripMenuItem";
            this.aDDPriceToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aDDPriceToolStripMenuItem.Text = "ADD Price";
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.frmSession);
            this.tabSession.Controls.Add(this.menuStrip3);
            this.tabSession.Location = new System.Drawing.Point(4, 25);
            this.tabSession.Name = "tabSession";
            this.tabSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabSession.Size = new System.Drawing.Size(485, 385);
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
            this.frmSession.Size = new System.Drawing.Size(369, 379);
            this.frmSession.TabIndex = 0;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSession});
            this.menuStrip3.Location = new System.Drawing.Point(372, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(110, 379);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // btnAddSession
            // 
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(97, 24);
            this.btnAddSession.Text = "ADD session";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 411);
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
        private System.Windows.Forms.ToolStripMenuItem aDDPriceToolStripMenuItem;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.DataGridView frmSession;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem btnAddSession;
    }
}

