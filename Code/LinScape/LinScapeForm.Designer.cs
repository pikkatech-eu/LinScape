namespace LinScape
{
	partial class LinScapeForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new MenuStrip();
			this.toolStrip1 = new ToolStrip();
			this.statusStrip1 = new StatusStrip();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Font = new Font("Consolas", 10F);
			this.menuStrip1.ImageScalingSize = new Size(20, 20);
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(900, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.ImageScalingSize = new Size(40, 40);
			this.toolStrip1.Location = new Point(0, 40);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(900, 42);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.ImageScalingSize = new Size(20, 20);
			this.statusStrip1.Location = new Point(0, 414);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(900, 36);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(900, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new Font("Consolas", 10F);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "LinScape 1.0";
			this.ResumeLayout(false);
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStrip toolStrip1;
		private StatusStrip statusStrip1;
	}
}
