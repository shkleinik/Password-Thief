namespace PasswordsThief.UI
{
    partial class ControlDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDetails));
            this.dgvControlDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvControlDetails
            // 
            this.dgvControlDetails.AllowUserToAddRows = false;
            this.dgvControlDetails.AllowUserToDeleteRows = false;
            this.dgvControlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlDetails.Location = new System.Drawing.Point(13, 13);
            this.dgvControlDetails.Name = "dgvControlDetails";
            this.dgvControlDetails.ReadOnly = true;
            this.dgvControlDetails.Size = new System.Drawing.Size(755, 281);
            this.dgvControlDetails.TabIndex = 0;
            // 
            // ControlDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 306);
            this.Controls.Add(this.dgvControlDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlDetails";
            this.Text = "ControlDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControlDetails;
    }
}