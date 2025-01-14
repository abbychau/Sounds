﻿namespace Sounds
{
    partial class PrefsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrefsDialog));
            this.displayGroup = new System.Windows.Forms.GroupBox();
            this.showInfoPaneBox = new System.Windows.Forms.CheckBox();
            this.showStatusbarBox = new System.Windows.Forms.CheckBox();
            this.showToolbarBox = new System.Windows.Forms.CheckBox();
            this.generalBox = new System.Windows.Forms.GroupBox();
            this.showDialogsBox = new System.Windows.Forms.CheckBox();
            this.timeIncrementBox = new System.Windows.Forms.NumericUpDown();
            this.timeIncrementLabel = new System.Windows.Forms.Label();
            this.volIncrementBox = new System.Windows.Forms.NumericUpDown();
            this.volIncrementLabel = new System.Windows.Forms.Label();
            this.deleteOnTrackChangeBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendDiscordPresenceBox = new System.Windows.Forms.CheckBox();
            this.loadLastPlaylistBox = new System.Windows.Forms.CheckBox();
            this.displayGroup.SuspendLayout();
            this.generalBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeIncrementBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volIncrementBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayGroup
            // 
            resources.ApplyResources(this.displayGroup, "displayGroup");
            this.displayGroup.Controls.Add(this.showInfoPaneBox);
            this.displayGroup.Controls.Add(this.showStatusbarBox);
            this.displayGroup.Controls.Add(this.showToolbarBox);
            this.displayGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.displayGroup.Name = "displayGroup";
            this.displayGroup.TabStop = false;
            // 
            // showInfoPaneBox
            // 
            resources.ApplyResources(this.showInfoPaneBox, "showInfoPaneBox");
            this.showInfoPaneBox.Name = "showInfoPaneBox";
            this.showInfoPaneBox.UseVisualStyleBackColor = true;
            // 
            // showStatusbarBox
            // 
            resources.ApplyResources(this.showStatusbarBox, "showStatusbarBox");
            this.showStatusbarBox.Name = "showStatusbarBox";
            this.showStatusbarBox.UseVisualStyleBackColor = true;
            // 
            // showToolbarBox
            // 
            resources.ApplyResources(this.showToolbarBox, "showToolbarBox");
            this.showToolbarBox.Name = "showToolbarBox";
            this.showToolbarBox.UseVisualStyleBackColor = true;
            // 
            // generalBox
            // 
            resources.ApplyResources(this.generalBox, "generalBox");
            this.generalBox.Controls.Add(this.showDialogsBox);
            this.generalBox.Controls.Add(this.timeIncrementBox);
            this.generalBox.Controls.Add(this.timeIncrementLabel);
            this.generalBox.Controls.Add(this.volIncrementBox);
            this.generalBox.Controls.Add(this.volIncrementLabel);
            this.generalBox.Controls.Add(this.deleteOnTrackChangeBox);
            this.generalBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generalBox.Name = "generalBox";
            this.generalBox.TabStop = false;
            // 
            // showDialogsBox
            // 
            resources.ApplyResources(this.showDialogsBox, "showDialogsBox");
            this.showDialogsBox.Name = "showDialogsBox";
            this.showDialogsBox.UseVisualStyleBackColor = true;
            // 
            // timeIncrementBox
            // 
            resources.ApplyResources(this.timeIncrementBox, "timeIncrementBox");
            this.timeIncrementBox.Name = "timeIncrementBox";
            // 
            // timeIncrementLabel
            // 
            resources.ApplyResources(this.timeIncrementLabel, "timeIncrementLabel");
            this.timeIncrementLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timeIncrementLabel.Name = "timeIncrementLabel";
            // 
            // volIncrementBox
            // 
            resources.ApplyResources(this.volIncrementBox, "volIncrementBox");
            this.volIncrementBox.Name = "volIncrementBox";
            // 
            // volIncrementLabel
            // 
            resources.ApplyResources(this.volIncrementLabel, "volIncrementLabel");
            this.volIncrementLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.volIncrementLabel.Name = "volIncrementLabel";
            // 
            // deleteOnTrackChangeBox
            // 
            resources.ApplyResources(this.deleteOnTrackChangeBox, "deleteOnTrackChangeBox");
            this.deleteOnTrackChangeBox.Name = "deleteOnTrackChangeBox";
            this.deleteOnTrackChangeBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.sendDiscordPresenceBox);
            this.groupBox1.Controls.Add(this.loadLastPlaylistBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // sendDiscordPresenceBox
            // 
            resources.ApplyResources(this.sendDiscordPresenceBox, "sendDiscordPresenceBox");
            this.sendDiscordPresenceBox.Name = "sendDiscordPresenceBox";
            this.sendDiscordPresenceBox.UseVisualStyleBackColor = true;
            // 
            // loadLastPlaylistBox
            // 
            resources.ApplyResources(this.loadLastPlaylistBox, "loadLastPlaylistBox");
            this.loadLastPlaylistBox.Name = "loadLastPlaylistBox";
            this.loadLastPlaylistBox.UseVisualStyleBackColor = true;
            // 
            // PrefsDialog
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.generalBox);
            this.Controls.Add(this.displayGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrefsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.displayGroup.ResumeLayout(false);
            this.displayGroup.PerformLayout();
            this.generalBox.ResumeLayout(false);
            this.generalBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeIncrementBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volIncrementBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox displayGroup;
        private System.Windows.Forms.GroupBox generalBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox showInfoPaneBox;
        private System.Windows.Forms.CheckBox showStatusbarBox;
        private System.Windows.Forms.CheckBox showToolbarBox;
        private System.Windows.Forms.NumericUpDown timeIncrementBox;
        private System.Windows.Forms.Label timeIncrementLabel;
        private System.Windows.Forms.NumericUpDown volIncrementBox;
        private System.Windows.Forms.Label volIncrementLabel;
        private System.Windows.Forms.CheckBox deleteOnTrackChangeBox;
        private System.Windows.Forms.CheckBox showDialogsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sendDiscordPresenceBox;
        private System.Windows.Forms.CheckBox loadLastPlaylistBox;
    }
}