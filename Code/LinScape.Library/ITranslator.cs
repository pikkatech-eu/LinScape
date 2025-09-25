/***********************************************************************************
* File:         ITranslator.cs                                                     *
* Contents:     Interface ITranslator                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-25 19:54                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LinScape.Library
{
	public interface ITranslator
	{
		#region Properties
		/// <summary>
		/// Gets and sets the ISO code of the source language (default: "en").
		/// </summary>
		string			SourceLanguage	{get;set;}

		/// <summary>
		/// List of target languages.
		/// </summary>
		List<string>	TargetLanguages	{get;set;}
		#endregion

		/// <summary>
		/// Translates a string in the defined source language into strings in the defined target languages.
		/// </summary>
		/// <param name="source">Word in the source language.</param>
		/// <returns></returns>
		Dictionary<string, string> Translate(string source);
	}
}
