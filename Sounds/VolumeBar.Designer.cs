namespace Sounds
{
    partial class VolumeBar
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
            this.components = new System.ComponentModel.Container();
            this.pgVolume = new System.Windows.Forms.ProgressBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgVolume
            // 
            this.pgVolume.Location = new System.Drawing.Point(12, 12);
            this.pgVolume.Name = "pgVolume";
            this.pgVolume.Size = new System.Drawing.Size(100, 23);
            this.pgVolume.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(129, 15);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(19, 15);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VolumeBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 45);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.pgVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VolumeBar";
            this.Text = "VolumeBar";
            this.Load += new System.EventHandler(this.VolumeBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Timer timer1;
    }
}