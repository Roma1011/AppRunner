
namespace AppRunner
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
			this.WhayBox = new System.Windows.Forms.TextBox();
			this.Count = new System.Windows.Forms.TextBox();
			this.RunnerBt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// WhayBox
			// 
			this.WhayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WhayBox.ForeColor = System.Drawing.Color.Maroon;
			this.WhayBox.Location = new System.Drawing.Point(54, 50);
			this.WhayBox.Name = "WhayBox";
			this.WhayBox.Size = new System.Drawing.Size(282, 22);
			this.WhayBox.TabIndex = 0;
			// 
			// Count
			// 
			this.Count.ForeColor = System.Drawing.Color.Maroon;
			this.Count.Location = new System.Drawing.Point(141, 97);
			this.Count.Name = "Count";
			this.Count.Size = new System.Drawing.Size(100, 20);
			this.Count.TabIndex = 1;
			// 
			// RunnerBt
			// 
			this.RunnerBt.Location = new System.Drawing.Point(152, 146);
			this.RunnerBt.Name = "RunnerBt";
			this.RunnerBt.Size = new System.Drawing.Size(75, 36);
			this.RunnerBt.TabIndex = 2;
			this.RunnerBt.Text = "Run";
			this.RunnerBt.UseVisualStyleBackColor = true;
			this.RunnerBt.Click += new System.EventHandler(this.RunnerBt_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(393, 204);
			this.Controls.Add(this.RunnerBt);
			this.Controls.Add(this.Count);
			this.Controls.Add(this.WhayBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Runer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox WhayBox;
		private System.Windows.Forms.TextBox Count;
		private System.Windows.Forms.Button RunnerBt;
	}
}

