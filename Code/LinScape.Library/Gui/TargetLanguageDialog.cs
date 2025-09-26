/***********************************************************************************
* File:         TargetLanguageDialog.cs                                                  *
* Contents:     Class TargetLanguageDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Data;
using Factotum.Dictionaries;

namespace LinScape.Library.Gui
{
	public partial class TargetLanguageDialog : Form
	{
		public TargetLanguageDialog()
		{
			InitializeComponent();

			this._lvLanguages.Items.Clear();

			foreach (var language in Factotum.Dictionaries.Language.Languages)
			{
				ListViewItem lvi = new ListViewItem(new string[]{language.Name, language.Alpha2, language.Alpha3});
				lvi.Tag				= language;

				this._lvLanguages.Items.Add(lvi);
			}

			this._lvLanguages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this._lvLanguages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		public string SelectedLanguageCode
		{
			get
			{
				if (this._lvLanguages.SelectedItems.Count == 1)
				{
					Language language = this._lvLanguages.SelectedItems[0].Tag as Language;

					return !String.IsNullOrEmpty(language.Alpha2) ? language.Alpha2 : language.Alpha3;
				}
				else
				{
					return null;
				}
			}
		}
	}
}
