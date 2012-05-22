namespace gdb_domain_manager
{
    partial class GeodatabaseSelector
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
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.rbSDE = new System.Windows.Forms.RadioButton();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(13, 14);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(148, 17);
            this.rbFile.TabIndex = 0;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "File geodatabase (*.GDB)";
            this.rbFile.UseVisualStyleBackColor = true;
            this.rbFile.CheckedChanged += new System.EventHandler(this.rbFile_CheckedChanged);
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(13, 38);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(174, 17);
            this.rbPersonal.TabIndex = 1;
            this.rbPersonal.TabStop = true;
            this.rbPersonal.Text = "Personal geodatabase (*.MDB)";
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.CheckedChanged += new System.EventHandler(this.rbPersonal_CheckedChanged);
            // 
            // rbSDE
            // 
            this.rbSDE.AutoSize = true;
            this.rbSDE.Location = new System.Drawing.Point(13, 62);
            this.rbSDE.Name = "rbSDE";
            this.rbSDE.Size = new System.Drawing.Size(132, 17);
            this.rbSDE.TabIndex = 2;
            this.rbSDE.TabStop = true;
            this.rbSDE.Text = "ArcSDE connection file";
            this.rbSDE.UseVisualStyleBackColor = true;
            this.rbSDE.CheckedChanged += new System.EventHandler(this.rbSDE_CheckedChanged);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(227, 35);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 3;
            this.openFileBtn.Text = "Open...";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(112, 102);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GeodatabaseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.rbSDE);
            this.Controls.Add(this.rbPersonal);
            this.Controls.Add(this.rbFile);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "GeodatabaseSelector";
            this.Size = new System.Drawing.Size(365, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.RadioButton rbSDE;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button3;
    }
}
