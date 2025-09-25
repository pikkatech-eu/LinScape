namespace LinScape.Library.Gui
{
	partial class TargetLanguageDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetLanguageDialog));
			this._btOK = new Button();
			this._btCancel = new Button();
			this._tplTargetLanguage = new TableLayoutPanel();
			this._lbLanguages = new ListBox();
			this._tplTargetLanguage.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = Color.FromArgb(0, 48, 96);
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 286);
			this._btOK.Margin = new Padding(0);
			this._btOK.Name = "_btOK";
			this._btOK.Size = new Size(80, 32);
			this._btOK.TabIndex = 0;
			this._btOK.Text = "OK";
			this._btOK.UseVisualStyleBackColor = false;
			// 
			// _btCancel
			// 
			this._btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btCancel.BackColor = Color.FromArgb(0, 48, 96);
			this._btCancel.DialogResult = DialogResult.Cancel;
			this._btCancel.Location = new Point(114, 286);
			this._btCancel.Margin = new Padding(0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new Size(80, 32);
			this._btCancel.TabIndex = 0;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = false;
			// 
			// _tplTargetLanguage
			// 
			this._tplTargetLanguage.ColumnCount = 2;
			this._tplTargetLanguage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4F));
			this._tplTargetLanguage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tplTargetLanguage.Controls.Add(this._lbLanguages, 1, 0);
			this._tplTargetLanguage.Dock = DockStyle.Top;
			this._tplTargetLanguage.Location = new Point(0, 0);
			this._tplTargetLanguage.Name = "_tplTargetLanguage";
			this._tplTargetLanguage.RowCount = 1;
			this._tplTargetLanguage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tplTargetLanguage.Size = new Size(377, 246);
			this._tplTargetLanguage.TabIndex = 1;
			// 
			// _lbLanguages
			// 
			this._lbLanguages.Dock = DockStyle.Fill;
			this._lbLanguages.FormattingEnabled = true;
			this._lbLanguages.Location = new Point(7, 3);
			this._lbLanguages.Name = "_lbLanguages";
			this._lbLanguages.Size = new Size(367, 240);
			this._lbLanguages.TabIndex = 0;
			// 
			// TargetLanguageDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.ClientSize = new Size(377, 327);
			this.Controls.Add(this._tplTargetLanguage);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "TargetLanguageDialog";
			this.Text = "User Dialog";
			this._tplTargetLanguage.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel _tplTargetLanguage;
		private ListBox _lbLanguages;
	}
}