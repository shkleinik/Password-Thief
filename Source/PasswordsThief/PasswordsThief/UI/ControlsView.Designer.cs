namespace PasswordsThief.UI
{
    partial class ControlsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlsView));
            this.dgvControlsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlsView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvControlsView
            // 
            this.dgvControlsView.AllowUserToAddRows = false;
            this.dgvControlsView.AllowUserToDeleteRows = false;
            this.dgvControlsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvControlsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlsView.Location = new System.Drawing.Point(13, 13);
            this.dgvControlsView.Name = "dgvControlsView";
            this.dgvControlsView.ReadOnly = true;
            this.dgvControlsView.Size = new System.Drawing.Size(489, 300);
            this.dgvControlsView.TabIndex = 0;
            this.dgvControlsView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.On_dgvControlsView_RowHeaderDoubleClick);
            // 
            // ControlsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 325);
            this.Controls.Add(this.dgvControlsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ControlsView";
            this.Text = "ControlsView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControlsView;
    }
}