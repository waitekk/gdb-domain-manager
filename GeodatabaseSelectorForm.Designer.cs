namespace gdb_domain_manager
{
    partial class GeodatabaseSelectorForm
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
            this.geodatabaseSelector1 = new gdb_domain_manager.GeodatabaseSelector();
            this.SuspendLayout();
            // 
            // geodatabaseSelector1
            // 
            this.geodatabaseSelector1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.geodatabaseSelector1.Location = new System.Drawing.Point(8, 10);
            this.geodatabaseSelector1.Name = "geodatabaseSelector1";
            this.geodatabaseSelector1.Size = new System.Drawing.Size(365, 143);
            this.geodatabaseSelector1.TabIndex = 0;
            // 
            // GeodatabaseSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 165);
            this.Controls.Add(this.geodatabaseSelector1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "GeodatabaseSelectorForm";
            this.Text = "GeodatabaseSelectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        public GeodatabaseSelector geodatabaseSelector1;
    }
}