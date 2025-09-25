/***********************************************************************************
* File:         TargetLanguageDialog.cs                                                  *
* Contents:     Class TargetLanguageDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Data;

namespace LinScape.Library.Gui
{
	public partial class TargetLanguageDialog : Form
	{
		public TargetLanguageDialog()
		{
			InitializeComponent();

			this._lbLanguages.Items.Clear();

			foreach (var language in Factotum.Dictionaries.Language.Languages)
			{
				if (!String.IsNullOrEmpty(language.Alpha2))
				{
					this._lbLanguages.Items.Add(language.Alpha2);
				}
				else
				{
					this._lbLanguages.Items.Add(language.Alpha3);
				}
			}
		}

		public string SelectedLanguage
		{
			get
			{
				try
				{
					return this._lbLanguages.SelectedItem.ToString();
				}
				catch (Exception)
				{
					return null;
				}
			}
		}
	}
}
