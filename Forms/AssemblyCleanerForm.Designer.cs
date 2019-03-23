﻿namespace Reflexil.Forms
{
    partial class AssemblyCleanerForm
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
			this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.Cancel = new System.Windows.Forms.Button();
			this.StepLab = new System.Windows.Forms.Label();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.Directory = new System.Windows.Forms.Label();
			this.Step = new System.Windows.Forms.Label();
			this.WaitLab = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BackgroundWorker
			// 
			this.BackgroundWorker.WorkerReportsProgress = true;
			this.BackgroundWorker.WorkerSupportsCancellation = true;
			this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(505, 112);
			this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(100, 28);
			this.Cancel.TabIndex = 0;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Visible = false;
			// 
			// StepLab
			// 
			this.StepLab.AutoSize = true;
			this.StepLab.Location = new System.Drawing.Point(17, 16);
			this.StepLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.StepLab.Name = "StepLab";
			this.StepLab.Size = new System.Drawing.Size(41, 17);
			this.StepLab.TabIndex = 2;
			this.StepLab.Text = "Step:";
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(21, 73);
			this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(584, 28);
			this.ProgressBar.TabIndex = 3;
			// 
			// Directory
			// 
			this.Directory.Location = new System.Drawing.Point(95, 16);
			this.Directory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Directory.Name = "Directory";
			this.Directory.Size = new System.Drawing.Size(511, 28);
			this.Directory.TabIndex = 4;
			// 
			// Step
			// 
			this.Step.Location = new System.Drawing.Point(95, 16);
			this.Step.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Step.Name = "Step";
			this.Step.Size = new System.Drawing.Size(511, 53);
			this.Step.TabIndex = 5;
			// 
			// WaitLab
			// 
			this.WaitLab.AutoSize = true;
			this.WaitLab.Location = new System.Drawing.Point(21, 119);
			this.WaitLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.WaitLab.Name = "WaitLab";
			this.WaitLab.Size = new System.Drawing.Size(246, 17);
			this.WaitLab.TabIndex = 6;
			this.WaitLab.Text = "Please wait while cleaning assembly...";
			// 
			// AssemblyCleanerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(621, 151);
			this.ControlBox = false;
			this.Controls.Add(this.WaitLab);
			this.Controls.Add(this.Step);
			this.Controls.Add(this.Directory);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.StepLab);
			this.Controls.Add(this.Cancel);
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AssemblyCleanerForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Assembly cleaner";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label StepLab;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label Directory;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.Label WaitLab;
	}
}