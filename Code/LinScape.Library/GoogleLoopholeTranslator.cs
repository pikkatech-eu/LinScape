/***********************************************************************************
* File:         GoogleLoopholeTranslator.cs                                        *
* Contents:     Class GoogleLoopholeTranslator                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-25 20:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LinScape.Library
{
	public class GoogleLoopholeTranslator : ITranslator
	{
		private static string SIMPLE_BASE_URL = "https://translate.googleapis.com/translate_a/single";
		private static string GTX_CLIENT = "gtx";
		private static string TASK = "t";

		#region Properties
		/// <summary>
		/// Gets and sets the ISO code of the source language (default: "en").
		/// </summary>
		public string		SourceLanguage	{get;set;}	= "en";

		/// <summary>
		/// List of target languages.
		/// </summary>
		public List<string>	TargetLanguages	{get;set;}	= new List<string>();
		#endregion

		/// <summary>
		/// Translates a string in the defined source language into strings in the defined target languages.
		/// </summary>
		/// <param name="source">Word in the source language.</param>
		/// <returns></returns>
		public Dictionary<string, string> Translate(string source)
		{
			Dictionary<string, string> result = new Dictionary<string, string>();

			foreach (string targetLanguage in this.TargetLanguages)
			{
				string translation = this.Translate(source, targetLanguage);
				result.Add(targetLanguage, translation);
			}

			return result;
		}

		private string Translate(string source, string targetLanguage)
		{
			string url = $"{SIMPLE_BASE_URL}?client={GTX_CLIENT}&dt={TASK}&sl={this.SourceLanguage}&tl={targetLanguage}&q={source}";

			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = client.Send(request);

				using (StreamReader reader = new StreamReader(response.Content.ReadAsStream()))
				{
					string json = reader.ReadToEnd();

					JsonDocument doc = JsonDocument.Parse(json);
					JsonElement root = doc.RootElement;

					string translation = root[0][0][0].GetString();

					return translation;
				}
			}
		}
	}
}
