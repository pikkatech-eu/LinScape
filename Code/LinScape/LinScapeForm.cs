using LinScape.Library;
using LinScape.Library.Gui;

namespace LinScape
{
	public partial class LinScapeForm : Form
	{
		private ITranslator _translator = new GoogleLoopholeTranslator();
		private static readonly string _settingsFileName = "settings.json";

		public LinScapeForm()
		{
			InitializeComponent();

			try
			{
				this._translator.LoadProperties(_settingsFileName);
			}
			catch (Exception)
			{
			}

			this._txSourceLanguage.Text = this._translator.SourceLanguage;
			this.UpdateTargetLanguages();
		}

		private void UpdateTargetLanguages()
		{
			this._cxTargetLanguages.Items.Clear();

			foreach (string language in this._translator.TargetLanguages)
			{
				this._cxTargetLanguages.Items.Add(language);
			}

			if (this._translator.TargetLanguages.Count > 0)
			{
				this._cxTargetLanguages.SelectedIndex = 0;
			}
		}

		private void OnAddTargetLanguage(object sender, EventArgs e)
		{
			TargetLanguageDialog dialog = new TargetLanguageDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string language = dialog.SelectedLanguageCode;

				if (!this._translator.TargetLanguages.Contains(language))
				{
					this._translator.TargetLanguages.Add(language);
					this._translator.SaveProperties(_settingsFileName);
					this.UpdateTargetLanguages();
				}
			}
		}

		private void OnDeleteTargetLanguage(object sender, EventArgs e)
		{
			int index = this._cxTargetLanguages.SelectedIndex;

			if (index >= 0)
			{
				string language = this._cxTargetLanguages.SelectedItem.ToString();

				if (MessageBox.Show($"Delete language {language}?", "Target lsnguage about to be deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					this._translator.TargetLanguages.RemoveAt(index);
					this.UpdateTargetLanguages();
					this._translator.SaveProperties(_settingsFileName);
				}
			}
		}

		private void OnTranslate(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			try
			{
				Dictionary<string, string> translations = this._translator.Translate(this._txSource.Text);

				this._lvTranslations.Items.Clear();

				foreach (string language in translations.Keys)
				{
					ListViewItem lvi = new ListViewItem(new string[] { language, translations[language] });
					lvi.Tag = language;

					this._lvTranslations.Items.Add(lvi);
				}

				this._lvTranslations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				this._lvTranslations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
			catch (Exception)
			{
			}

			this.Cursor = Cursors.Default;
		}

		private void OnAddToJopurnal(object sender, EventArgs e)
		{

		}

		private void OnSourceKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.OnTranslate(sender, e);
			}
		}
	}
}
