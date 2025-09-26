using System.Xml.Linq;
using LinScape.Library;
using LinScape.Library.Gui;

namespace LinScape
{
	public partial class LinScapeForm : Form
	{
		private ITranslator _translator = new GoogleLoopholeTranslator();
		private static readonly string _settingsFileName = "settings.json";

		private List<(string Source, string Translation)> _journal = new List<(string Source, string Translation)>();
		private string _journalFileName = "";
		private bool _isJournalDirty = false;

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
					lvi.Tag = translations[language];

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

		private void OnAddToJournal(object sender, EventArgs e)
		{
			if (this._lvTranslations.SelectedItems.Count == 1)
			{
				var pair = (this._txSource.Text, this._txResult.Text);

				this._journal.Add(pair);

				this.UpdateJournal();

				this._isJournalDirty = true;

				this.UpdateStatusStrip();
			}
		}

		private void UpdateJournal()
		{
			this._lvJournal.Items.Clear();

			foreach (var language in this._journal)
			{
				ListViewItem lvi = new ListViewItem(new string[] { language.Source, language.Translation });
				lvi.Tag = language;

				this._lvJournal.Items.Add(lvi);
			}

			this._lvJournal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvJournal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void OnSourceKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.OnTranslate(sender, e);
			}
		}

		private void OnTranslationSelected(object sender, EventArgs e)
		{
			if (this._lvTranslations.SelectedItems.Count == 1)
			{
				this._txResult.Text = this._lvTranslations.SelectedItems[0].Tag as string;
			}
		}

		private void OnJournalNew(object sender, EventArgs e)
		{
			this._journal.Clear();
			this.UpdateJournal();
			this._journalFileName = "";
			this._isJournalDirty = false;

			this.UpdateStatusStrip();
		}

		private void OnJournalLoad(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter		= "XML files (*xml)|*.xml";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._journalFileName = dialog.FileName;
				this.LoadJournal(this._journalFileName);

				this.UpdateJournal();

				this._isJournalDirty = false;

				this.UpdateStatusStrip();
			}
		}

		private void OnJournalSave(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(this._journalFileName))
			{
				this.SaveJournal(this._journalFileName);

				this._isJournalDirty = false;

				this.UpdateStatusStrip();
			}
			else
			{
				this.OnJournalSaveAs(sender, e);
			}
		}

		private void OnJournalSaveAs(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter		= "XML files (*xml)|*.xml";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._journalFileName = dialog.FileName;
				this.SaveJournal(this._journalFileName);

				this._isJournalDirty = false;

				this.UpdateStatusStrip();
			}
		}

		/*
		\begin{tabularx}{0.4\textwidth}{|l|X|}
			\hline
			Source & Translation	\\
			\hline
			source1 & translation1 	\\
			...
			sourceN & translationN 	\\
			\hline
			\end{tabularx}
		 */

		private void OnJournalExportAsTeXTable(object sender, EventArgs e)
		{
			float width = 1.0f;

			string result = $"begin{{tabularx}}{{{width}\\textwidth}}{{|l|X|}}\n";
			result += "\\hline\n";
			result += "Source & Translation\t\\\\\n";
			result += "\\hline\n";

			foreach (var item in this._journal)
			{
				result += $"{item.Source} & {item.Translation}\t\\\\\n";
			}

			result += "\\hline\n";

			result += "\\end{tabularx}";

			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter		= "TeX files (*.tex)|*.tex";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(dialog.FileName))
				{
					writer.Write(result);
				}
			}
		}

		private void OnJournalQuit(object sender, EventArgs e)
		{
			if (this._isJournalDirty)
			{
				if (MessageBox.Show("Jornal has been changed", "Unsaved changes in journal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					this.Close();
				}
				else
				{
					this.OnJournalSave(sender, e);
				}
			}
		}

		private void SaveJournal(string fileName)
		{
			XElement x = new XElement("Journal");

			foreach (var item in this._journal)
			{
				XElement xItem = new XElement("Item", new XAttribute("Source", item.Source), new XAttribute("Translation", item.Translation));
				x.Add(xItem);
			}

			x.Save(fileName);
		}

		private void LoadJournal(string fileName)
		{
			this._journal.Clear();

			XElement x = XElement.Load(fileName);

			foreach (XElement xItem in x.Elements("Item"))
			{
				string source = xItem.Attribute("Source").Value;
				string translation = xItem.Attribute("Translation").Value;

				this._journal.Add((source, translation));
			}
		}

		private void UpdateStatusStrip()
		{
			string dirtiness = this._isJournalDirty ? "*" : "";
			this._lblStatus.Text = $"{dirtiness} {this._journalFileName}";
		}
	}
}
