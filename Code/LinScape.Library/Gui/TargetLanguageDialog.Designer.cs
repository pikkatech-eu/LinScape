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
			this._lvLanguages = new ListView();
			this.LanguageName = new ColumnHeader();
			this.Alpha2 = new ColumnHeader();
			this.Alpha3 = new ColumnHeader();
			this._tplTargetLanguage.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOK
			// 
			this._btOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this._btOK.BackColor = Color.FromArgb(0, 48, 96);
			this._btOK.DialogResult = DialogResult.OK;
			this._btOK.Location = new Point(9, 500);
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
			this._btCancel.Location = new Point(114, 500);
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
			this._tplTargetLanguage.Controls.Add(this._lvLanguages, 1, 0);
			this._tplTargetLanguage.Dock = DockStyle.Top;
			this._tplTargetLanguage.Location = new Point(0, 0);
			this._tplTargetLanguage.Name = "_tplTargetLanguage";
			this._tplTargetLanguage.RowCount = 1;
			this._tplTargetLanguage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tplTargetLanguage.Size = new Size(839, 367);
			this._tplTargetLanguage.TabIndex = 1;
			// 
			// _lvLanguages
			// 
			this._lvLanguages.Columns.AddRange(new ColumnHeader[] { this.LanguageName, this.Alpha2, this.Alpha3 });
			this._lvLanguages.Dock = DockStyle.Fill;
			this._lvLanguages.FullRowSelect = true;
			this._lvLanguages.Location = new Point(7, 3);
			this._lvLanguages.Name = "_lvLanguages";
			this._lvLanguages.Size = new Size(829, 361);
			this._lvLanguages.TabIndex = 0;
			this._lvLanguages.UseCompatibleStateImageBehavior = false;
			this._lvLanguages.View = View.Details;
			// 
			// LanguageName
			// 
			this.LanguageName.Text = "Name";
			// 
			// Alpha2
			// 
			this.Alpha2.Text = "Alpha2";
			// 
			// Alpha3
			// 
			this.Alpha3.Text = "Alpha3";
			// 
			// TargetLanguageDialog
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(0, 48, 96);
			this.ClientSize = new Size(839, 541);
			this.Controls.Add(this._tplTargetLanguage);
			this.Controls.Add(this._btCancel);
			this.Controls.Add(this._btOK);
			this.Font = new Font("Consolas", 10F);
			this.ForeColor = Color.White;
			this.Icon = (Icon)resources.GetObject("$this.Icon");
			this.Name = "TargetLanguageDialog";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "User Dialog";
			this._tplTargetLanguage.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private Button _btOK;
		private Button _btCancel;
		private TableLayoutPanel _tplTargetLanguage;
		private ListView _lvLanguages;
		private ColumnHeader LanguageName;
		private ColumnHeader Alpha2;
		private ColumnHeader Alpha3;
	}
}