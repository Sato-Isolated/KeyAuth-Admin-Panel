namespace KeyAuth_Admin_Panel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExpiredKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extendUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetHwidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 317);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createKeyToolStripMenuItem,
            this.clipboardKeyToolStripMenuItem,
            this.deleteKeysToolStripMenuItem,
            this.banToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            // 
            // createKeyToolStripMenuItem
            // 
            this.createKeyToolStripMenuItem.Name = "createKeyToolStripMenuItem";
            this.createKeyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.createKeyToolStripMenuItem.Text = "Create Key(s)";
            this.createKeyToolStripMenuItem.Click += new System.EventHandler(this.createKeyToolStripMenuItem_Click);
            // 
            // clipboardKeyToolStripMenuItem
            // 
            this.clipboardKeyToolStripMenuItem.Name = "clipboardKeyToolStripMenuItem";
            this.clipboardKeyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.clipboardKeyToolStripMenuItem.Text = "Clipboard Key";
            this.clipboardKeyToolStripMenuItem.Click += new System.EventHandler(this.clipboardKeyToolStripMenuItem_Click);
            // 
            // deleteKeysToolStripMenuItem
            // 
            this.deleteKeysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteExpiredKeyToolStripMenuItem});
            this.deleteKeysToolStripMenuItem.Name = "deleteKeysToolStripMenuItem";
            this.deleteKeysToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteKeysToolStripMenuItem.Text = "Delete Key";
            this.deleteKeysToolStripMenuItem.Click += new System.EventHandler(this.deleteKeysToolStripMenuItem_Click);
            // 
            // deleteExpiredKeyToolStripMenuItem
            // 
            this.deleteExpiredKeyToolStripMenuItem.Name = "deleteExpiredKeyToolStripMenuItem";
            this.deleteExpiredKeyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteExpiredKeyToolStripMenuItem.Text = "Delete Expired Key";
            this.deleteExpiredKeyToolStripMenuItem.Click += new System.EventHandler(this.deleteExpiredKeyToolStripMenuItem_Click);
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.banToolStripMenuItem.Text = "Ban";
            this.banToolStripMenuItem.Click += new System.EventHandler(this.banToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(861, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.ContextMenuStrip = this.contextMenuStrip2;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 3);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(855, 317);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extendUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.resetHwidToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(137, 70);
            // 
            // extendUserToolStripMenuItem
            // 
            this.extendUserToolStripMenuItem.Name = "extendUserToolStripMenuItem";
            this.extendUserToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.extendUserToolStripMenuItem.Text = "Extend User";
            this.extendUserToolStripMenuItem.Click += new System.EventHandler(this.extendUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // resetHwidToolStripMenuItem
            // 
            this.resetHwidToolStripMenuItem.Name = "resetHwidToolStripMenuItem";
            this.resetHwidToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.resetHwidToolStripMenuItem.Text = "Reset Hwid";
            this.resetHwidToolStripMenuItem.Click += new System.EventHandler(this.resetHwidToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Key";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "KeyAuth Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem banToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ToolStripMenuItem createKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExpiredKeyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem extendUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetHwidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipboardKeyToolStripMenuItem;
    }
}

