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
			this._tcLinScape = new TabControl();
			this._tpTranslation = new TabPage();
			this._tlpTranslation = new TableLayoutPanel();
			this.label4 = new Label();
			this.label3 = new Label();
			this._btDeleteTargetLanguage = new Button();
			this.label2 = new Label();
			this.label1 = new Label();
			this._cxTargetLanguages = new ComboBox();
			this._txSourceLanguage = new TextBox();
			this._btAddTargetLanguage = new Button();
			this._txSource = new TextBox();
			this._lvTranslations = new ListView();
			this.Language = new ColumnHeader();
			this.Translation = new ColumnHeader();
			this._btAddToJournal = new Button();
			this._btTranslate = new Button();
			this._txResult = new TextBox();
			this._tpJpurnal = new TabPage();
			this._lvJournal = new ListView();
			this.Source = new ColumnHeader();
			this.ResultingTranslation = new ColumnHeader();
			this._tcLinScape.SuspendLayout();
			this._tpTranslation.SuspendLayout();
			this._tlpTranslation.SuspendLayout();
			this._tpJpurnal.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Font = new Font("Consolas", 10F);
			this.menuStrip1.ImageScalingSize = new Size(20, 20);
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(1243, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.ImageScalingSize = new Size(40, 40);
			this.toolStrip1.Location = new Point(0, 40);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(1243, 42);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.ImageScalingSize = new Size(20, 20);
			this.statusStrip1.Location = new Point(0, 757);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new Size(1243, 36);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// _tcLinScape
			// 
			this._tcLinScape.Controls.Add(this._tpTranslation);
			this._tcLinScape.Controls.Add(this._tpJpurnal);
			this._tcLinScape.Dock = DockStyle.Fill;
			this._tcLinScape.Location = new Point(0, 82);
			this._tcLinScape.Name = "_tcLinScape";
			this._tcLinScape.SelectedIndex = 0;
			this._tcLinScape.Size = new Size(1243, 675);
			this._tcLinScape.TabIndex = 3;
			// 
			// _tpTranslation
			// 
			this._tpTranslation.Controls.Add(this._tlpTranslation);
			this._tpTranslation.Location = new Point(4, 29);
			this._tpTranslation.Name = "_tpTranslation";
			this._tpTranslation.Padding = new Padding(3);
			this._tpTranslation.Size = new Size(1235, 642);
			this._tpTranslation.TabIndex = 0;
			this._tpTranslation.Text = "Translation";
			this._tpTranslation.UseVisualStyleBackColor = true;
			// 
			// _tlpTranslation
			// 
			this._tlpTranslation.ColumnCount = 8;
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpTranslation.ColumnStyles.Add(new ColumnStyle());
			this._tlpTranslation.Controls.Add(this.label4, 0, 2);
			this._tlpTranslation.Controls.Add(this.label3, 0, 1);
			this._tlpTranslation.Controls.Add(this._btDeleteTargetLanguage, 5, 0);
			this._tlpTranslation.Controls.Add(this.label2, 2, 0);
			this._tlpTranslation.Controls.Add(this.label1, 0, 0);
			this._tlpTranslation.Controls.Add(this._cxTargetLanguages, 3, 0);
			this._tlpTranslation.Controls.Add(this._txSourceLanguage, 1, 0);
			this._tlpTranslation.Controls.Add(this._btAddTargetLanguage, 4, 0);
			this._tlpTranslation.Controls.Add(this._txSource, 1, 1);
			this._tlpTranslation.Controls.Add(this._lvTranslations, 1, 2);
			this._tlpTranslation.Controls.Add(this._btAddToJournal, 0, 3);
			this._tlpTranslation.Controls.Add(this._btTranslate, 6, 1);
			this._tlpTranslation.Controls.Add(this._txResult, 1, 3);
			this._tlpTranslation.Dock = DockStyle.Fill;
			this._tlpTranslation.Location = new Point(3, 3);
			this._tlpTranslation.Name = "_tlpTranslation";
			this._tlpTranslation.RowCount = 5;
			this._tlpTranslation.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpTranslation.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpTranslation.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpTranslation.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			this._tlpTranslation.RowStyles.Add(new RowStyle());
			this._tlpTranslation.Size = new Size(1229, 636);
			this._tlpTranslation.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Fill;
			this.label4.Location = new Point(3, 56);
			this.label4.Name = "label4";
			this.label4.Size = new Size(144, 540);
			this.label4.TabIndex = 8;
			this.label4.Text = "Translations";
			this.label4.TextAlign = ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Location = new Point(3, 28);
			this.label3.Name = "label3";
			this.label3.Size = new Size(144, 28);
			this.label3.TabIndex = 6;
			this.label3.Text = "Source";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _btDeleteTargetLanguage
			// 
			this._btDeleteTargetLanguage.Dock = DockStyle.Fill;
			this._btDeleteTargetLanguage.Location = new Point(518, 0);
			this._btDeleteTargetLanguage.Margin = new Padding(0);
			this._btDeleteTargetLanguage.Name = "_btDeleteTargetLanguage";
			this._btDeleteTargetLanguage.Size = new Size(80, 28);
			this._btDeleteTargetLanguage.TabIndex = 5;
			this._btDeleteTargetLanguage.Text = "&Delete";
			this._btDeleteTargetLanguage.UseVisualStyleBackColor = true;
			this._btDeleteTargetLanguage.Click += this.OnDeleteTargetLanguage;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Location = new Point(217, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(154, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Target Languages";
			this.label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(144, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source Language";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _cxTargetLanguages
			// 
			this._cxTargetLanguages.Dock = DockStyle.Fill;
			this._cxTargetLanguages.DropDownStyle = ComboBoxStyle.DropDownList;
			this._cxTargetLanguages.FormattingEnabled = true;
			this._cxTargetLanguages.Location = new Point(374, 0);
			this._cxTargetLanguages.Margin = new Padding(0);
			this._cxTargetLanguages.Name = "_cxTargetLanguages";
			this._cxTargetLanguages.Size = new Size(64, 28);
			this._cxTargetLanguages.TabIndex = 2;
			// 
			// _txSourceLanguage
			// 
			this._txSourceLanguage.Dock = DockStyle.Fill;
			this._txSourceLanguage.Location = new Point(150, 0);
			this._txSourceLanguage.Margin = new Padding(0);
			this._txSourceLanguage.Name = "_txSourceLanguage";
			this._txSourceLanguage.Size = new Size(64, 27);
			this._txSourceLanguage.TabIndex = 3;
			// 
			// _btAddTargetLanguage
			// 
			this._btAddTargetLanguage.Dock = DockStyle.Fill;
			this._btAddTargetLanguage.Location = new Point(438, 0);
			this._btAddTargetLanguage.Margin = new Padding(0);
			this._btAddTargetLanguage.Name = "_btAddTargetLanguage";
			this._btAddTargetLanguage.Size = new Size(80, 28);
			this._btAddTargetLanguage.TabIndex = 4;
			this._btAddTargetLanguage.Text = "&Add";
			this._btAddTargetLanguage.UseVisualStyleBackColor = true;
			this._btAddTargetLanguage.Click += this.OnAddTargetLanguage;
			// 
			// _txSource
			// 
			this._tlpTranslation.SetColumnSpan(this._txSource, 5);
			this._txSource.Dock = DockStyle.Fill;
			this._txSource.Location = new Point(150, 28);
			this._txSource.Margin = new Padding(0);
			this._txSource.Name = "_txSource";
			this._txSource.Size = new Size(448, 27);
			this._txSource.TabIndex = 7;
			this._txSource.KeyDown += this.OnSourceKeyDown;
			// 
			// _lvTranslations
			// 
			this._lvTranslations.Columns.AddRange(new ColumnHeader[] { this.Language, this.Translation });
			this._tlpTranslation.SetColumnSpan(this._lvTranslations, 7);
			this._lvTranslations.Dock = DockStyle.Fill;
			this._lvTranslations.FullRowSelect = true;
			this._lvTranslations.Location = new Point(153, 59);
			this._lvTranslations.Name = "_lvTranslations";
			this._lvTranslations.Size = new Size(1073, 534);
			this._lvTranslations.TabIndex = 9;
			this._lvTranslations.UseCompatibleStateImageBehavior = false;
			this._lvTranslations.View = View.Details;
			this._lvTranslations.SelectedIndexChanged += this.OnTranslationSelected;
			// 
			// Language
			// 
			this.Language.Text = "Language";
			// 
			// Translation
			// 
			this.Translation.Text = "Translation";
			// 
			// _btAddToJournal
			// 
			this._btAddToJournal.Dock = DockStyle.Fill;
			this._btAddToJournal.Location = new Point(3, 599);
			this._btAddToJournal.Name = "_btAddToJournal";
			this._btAddToJournal.Size = new Size(144, 34);
			this._btAddToJournal.TabIndex = 10;
			this._btAddToJournal.Text = "Add to &Journal";
			this._btAddToJournal.UseVisualStyleBackColor = true;
			this._btAddToJournal.Click += this.OnAddToJournal;
			// 
			// _btTranslate
			// 
			this._btTranslate.Dock = DockStyle.Fill;
			this._btTranslate.Location = new Point(598, 28);
			this._btTranslate.Margin = new Padding(0);
			this._btTranslate.Name = "_btTranslate";
			this._btTranslate.Size = new Size(128, 28);
			this._btTranslate.TabIndex = 11;
			this._btTranslate.Text = "Translate";
			this._btTranslate.UseVisualStyleBackColor = true;
			this._btTranslate.Click += this.OnTranslate;
			// 
			// _txResult
			// 
			this._tlpTranslation.SetColumnSpan(this._txResult, 7);
			this._txResult.Dock = DockStyle.Fill;
			this._txResult.Location = new Point(153, 599);
			this._txResult.Name = "_txResult";
			this._txResult.Size = new Size(1073, 27);
			this._txResult.TabIndex = 12;
			// 
			// _tpJpurnal
			// 
			this._tpJpurnal.Controls.Add(this._lvJournal);
			this._tpJpurnal.Location = new Point(4, 29);
			this._tpJpurnal.Name = "_tpJpurnal";
			this._tpJpurnal.Padding = new Padding(3);
			this._tpJpurnal.Size = new Size(1235, 642);
			this._tpJpurnal.TabIndex = 1;
			this._tpJpurnal.Text = "Journal";
			this._tpJpurnal.UseVisualStyleBackColor = true;
			// 
			// _lvJournal
			// 
			this._lvJournal.Columns.AddRange(new ColumnHeader[] { this.Source, this.ResultingTranslation });
			this._lvJournal.Dock = DockStyle.Fill;
			this._lvJournal.FullRowSelect = true;
			this._lvJournal.Location = new Point(3, 3);
			this._lvJournal.Name = "_lvJournal";
			this._lvJournal.Size = new Size(1229, 636);
			this._lvJournal.TabIndex = 0;
			this._lvJournal.UseCompatibleStateImageBehavior = false;
			this._lvJournal.View = View.Details;
			// 
			// Source
			// 
			this.Source.Text = "Source";
			// 
			// ResultingTranslation
			// 
			this.ResultingTranslation.Text = "Translation";
			// 
			// LinScapeForm
			// 
			this.AutoScaleDimensions = new SizeF(9F, 20F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1243, 793);
			this.Controls.Add(this._tcLinScape);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new Font("Consolas", 10F);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "LinScapeForm";
			this.Text = "LinScape 1.0";
			this._tcLinScape.ResumeLayout(false);
			this._tpTranslation.ResumeLayout(false);
			this._tlpTranslation.ResumeLayout(false);
			this._tlpTranslation.PerformLayout();
			this._tpJpurnal.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStrip toolStrip1;
		private StatusStrip statusStrip1;
		private TabControl _tcLinScape;
		private TabPage _tpTranslation;
		private TabPage _tpJpurnal;
		private TableLayoutPanel _tlpTranslation;
		private Label label1;
		private Label label2;
		private ComboBox _cxTargetLanguages;
		private TextBox _txSourceLanguage;
		private Button _btAddTargetLanguage;
		private Button _btDeleteTargetLanguage;
		private Label label3;
		private TextBox _txSource;
		private Label label4;
		private ListView _lvTranslations;
		private ColumnHeader Language;
		private ColumnHeader Translation;
		private Button _btAddToJournal;
		private Button _btTranslate;
		private TextBox _txResult;
		private ListView _lvJournal;
		private ColumnHeader Source;
		private ColumnHeader ResultingTranslation;
	}
}
