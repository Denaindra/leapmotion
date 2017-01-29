namespace HandMotion
{
    partial class Form1
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.statusLable = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(36, 73);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(120, 120);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 75;
            // 
            // statusLable
            // 
            this.statusLable.AutoSize = true;
            this.statusLable.ForeColor = System.Drawing.SystemColors.Control;
            this.statusLable.Location = new System.Drawing.Point(62, 215);
            this.statusLable.Name = "statusLable";
            this.statusLable.Size = new System.Drawing.Size(43, 19);
            this.statusLable.TabIndex = 1;
            this.statusLable.Text = "Status";
            this.statusLable.UseCustomBackColor = true;
            this.statusLable.UseCustomForeColor = true;
            this.statusLable.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 269);
            this.Controls.Add(this.statusLable);
            this.Controls.Add(this.metroProgressSpinner1);
            this.MaximumSize = new System.Drawing.Size(195, 269);
            this.MinimumSize = new System.Drawing.Size(195, 269);
            this.Name = "Form1";
            this.Text = "HandMotion";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel statusLable;
    }
}

