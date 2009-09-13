namespace PasswordsThief.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblProcesses = new System.Windows.Forms.Label();
            this.cbProcesses = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblProcessWindows = new System.Windows.Forms.Label();
            this.cbWindows = new System.Windows.Forms.ComboBox();
            this.btnGetControls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcesses
            // 
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Location = new System.Drawing.Point(26, 32);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(133, 13);
            this.lblProcesses.TabIndex = 0;
            this.lblProcesses.Text = "Current running processes:";
            // 
            // cbProcesses
            // 
            this.cbProcesses.Location = new System.Drawing.Point(29, 48);
            this.cbProcesses.Name = "cbProcesses";
            this.cbProcesses.Size = new System.Drawing.Size(424, 21);
            this.cbProcesses.TabIndex = 1;
            this.cbProcesses.Text = "Select process from list";
            this.cbProcesses.SelectedIndexChanged += new System.EventHandler(this.On_CbProcesses_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(459, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.On_BtnRefresh_Click);
            // 
            // lblProcessWindows
            // 
            this.lblProcessWindows.AutoSize = true;
            this.lblProcessWindows.Location = new System.Drawing.Point(29, 95);
            this.lblProcessWindows.Name = "lblProcessWindows";
            this.lblProcessWindows.Size = new System.Drawing.Size(92, 13);
            this.lblProcessWindows.TabIndex = 3;
            this.lblProcessWindows.Text = "Process windows:";
            // 
            // cbWindows
            // 
            this.cbWindows.Location = new System.Drawing.Point(32, 112);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(421, 21);
            this.cbWindows.TabIndex = 4;
            this.cbWindows.Text = "Nothing selected";
            // 
            // btnGetControls
            // 
            this.btnGetControls.Location = new System.Drawing.Point(459, 110);
            this.btnGetControls.Name = "btnGetControls";
            this.btnGetControls.Size = new System.Drawing.Size(94, 23);
            this.btnGetControls.TabIndex = 6;
            this.btnGetControls.Text = "Get controls";
            this.btnGetControls.UseVisualStyleBackColor = true;
            this.btnGetControls.Click += new System.EventHandler(this.On_BtnGetControls_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 176);
            this.Controls.Add(this.btnGetControls);
            this.Controls.Add(this.cbWindows);
            this.Controls.Add(this.lblProcessWindows);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbProcesses);
            this.Controls.Add(this.lblProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Passwords Thief";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.ComboBox cbProcesses;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblProcessWindows;
        private System.Windows.Forms.ComboBox cbWindows;
        private System.Windows.Forms.Button btnGetControls;
    }
}