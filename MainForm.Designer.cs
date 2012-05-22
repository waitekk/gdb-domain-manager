namespace gdb_domain_manager
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgA = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgB = new System.Windows.Forms.DataGridView();
            this.checkBoxA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DomainA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DomainB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeGDB_A = new System.Windows.Forms.Button();
            this.btnChangeGDB_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gdbA = new System.Windows.Forms.Label();
            this.gdbB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshDomainInfoA = new System.Windows.Forms.Button();
            this.btnRefreshDomainListB = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshDomainInfoA);
            this.groupBox1.Controls.Add(this.gdbA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChangeGDB_A);
            this.groupBox1.Controls.Add(this.dgA);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A";
            // 
            // dgA
            // 
            this.dgA.AllowUserToAddRows = false;
            this.dgA.AllowUserToDeleteRows = false;
            this.dgA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxA,
            this.DomainA,
            this.DescriptionA});
            this.dgA.Location = new System.Drawing.Point(7, 84);
            this.dgA.Name = "dgA";
            this.dgA.ReadOnly = true;
            this.dgA.Size = new System.Drawing.Size(357, 248);
            this.dgA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshDomainListB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gdbB);
            this.groupBox2.Controls.Add(this.btnChangeGDB_B);
            this.groupBox2.Controls.Add(this.dgB);
            this.groupBox2.Location = new System.Drawing.Point(389, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B";
            // 
            // dgB
            // 
            this.dgB.AllowUserToAddRows = false;
            this.dgB.AllowUserToDeleteRows = false;
            this.dgB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxB,
            this.DomainB,
            this.DescriptionB});
            this.dgB.Location = new System.Drawing.Point(7, 84);
            this.dgB.Name = "dgB";
            this.dgB.ReadOnly = true;
            this.dgB.Size = new System.Drawing.Size(357, 248);
            this.dgB.TabIndex = 1;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkBoxA.Frozen = true;
            this.checkBoxA.HeaderText = "";
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.ReadOnly = true;
            this.checkBoxA.Width = 5;
            // 
            // DomainA
            // 
            this.DomainA.HeaderText = "Name";
            this.DomainA.Name = "DomainA";
            this.DomainA.ReadOnly = true;
            // 
            // DescriptionA
            // 
            this.DescriptionA.HeaderText = "Description";
            this.DescriptionA.Name = "DescriptionA";
            this.DescriptionA.ReadOnly = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkBoxB.Frozen = true;
            this.checkBoxB.HeaderText = "";
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.ReadOnly = true;
            this.checkBoxB.Width = 5;
            // 
            // DomainB
            // 
            this.DomainB.HeaderText = "Name";
            this.DomainB.Name = "DomainB";
            this.DomainB.ReadOnly = true;
            // 
            // DescriptionB
            // 
            this.DescriptionB.HeaderText = "Description";
            this.DescriptionB.Name = "DescriptionB";
            this.DescriptionB.ReadOnly = true;
            // 
            // btnChangeGDB_A
            // 
            this.btnChangeGDB_A.Location = new System.Drawing.Point(275, 14);
            this.btnChangeGDB_A.Name = "btnChangeGDB_A";
            this.btnChangeGDB_A.Size = new System.Drawing.Size(89, 23);
            this.btnChangeGDB_A.TabIndex = 1;
            this.btnChangeGDB_A.Text = "Change GDB";
            this.btnChangeGDB_A.UseVisualStyleBackColor = true;
            this.btnChangeGDB_A.Click += new System.EventHandler(this.btnChangeGDB_A_Click);
            // 
            // btnChangeGDB_B
            // 
            this.btnChangeGDB_B.Location = new System.Drawing.Point(275, 14);
            this.btnChangeGDB_B.Name = "btnChangeGDB_B";
            this.btnChangeGDB_B.Size = new System.Drawing.Size(89, 23);
            this.btnChangeGDB_B.TabIndex = 2;
            this.btnChangeGDB_B.Text = "Change GDB";
            this.btnChangeGDB_B.UseVisualStyleBackColor = true;
            this.btnChangeGDB_B.Click += new System.EventHandler(this.btnChangeGDB_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current GDB:";
            // 
            // gdbA
            // 
            this.gdbA.AutoEllipsis = true;
            this.gdbA.Location = new System.Drawing.Point(76, 19);
            this.gdbA.Name = "gdbA";
            this.gdbA.Size = new System.Drawing.Size(193, 18);
            this.gdbA.TabIndex = 3;
            this.gdbA.Text = "not set";
            // 
            // gdbB
            // 
            this.gdbB.AutoEllipsis = true;
            this.gdbB.Location = new System.Drawing.Point(82, 19);
            this.gdbB.Name = "gdbB";
            this.gdbB.Size = new System.Drawing.Size(187, 23);
            this.gdbB.TabIndex = 3;
            this.gdbB.Text = "not set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current GDB:";
            // 
            // btnRefreshDomainInfoA
            // 
            this.btnRefreshDomainInfoA.AutoSize = true;
            this.btnRefreshDomainInfoA.Location = new System.Drawing.Point(9, 40);
            this.btnRefreshDomainInfoA.Name = "btnRefreshDomainInfoA";
            this.btnRefreshDomainInfoA.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshDomainInfoA.TabIndex = 4;
            this.btnRefreshDomainInfoA.Text = "Refresh Domain List";
            this.btnRefreshDomainInfoA.UseVisualStyleBackColor = true;
            this.btnRefreshDomainInfoA.Click += new System.EventHandler(this.btnRefreshDomainInfoA_Click);
            // 
            // btnRefreshDomainListB
            // 
            this.btnRefreshDomainListB.AutoSize = true;
            this.btnRefreshDomainListB.Location = new System.Drawing.Point(6, 45);
            this.btnRefreshDomainListB.Name = "btnRefreshDomainListB";
            this.btnRefreshDomainListB.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshDomainListB.TabIndex = 5;
            this.btnRefreshDomainListB.Text = "Refresh Domain List";
            this.btnRefreshDomainListB.UseVisualStyleBackColor = true;
            this.btnRefreshDomainListB.Click += new System.EventHandler(this.btnRefreshDomainListB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ArcGIS Geodatabase Domain Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionB;
        private System.Windows.Forms.Button btnChangeGDB_A;
        private System.Windows.Forms.Button btnChangeGDB_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gdbA;
        private System.Windows.Forms.Label gdbB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefreshDomainInfoA;
        private System.Windows.Forms.Button btnRefreshDomainListB;
    }
}

