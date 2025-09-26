/***********************************************************************************
* File:         GoogleLoopholeTranslator.cs                                        *
* Contents:     Class GoogleLoopholeTranslator                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-09-25 20:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json;

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

				if (translation != null)
				{
					result.Add(targetLanguage, translation);
				}
			}

			return result;
		}

		public void SaveProperties(string fileName)
		{
			var options = new JsonSerializerOptions {WriteIndented = true};
			string json = JsonSerializer.Serialize<GoogleLoopholeTranslator>(this, options);

			using (StreamWriter writer = new StreamWriter(fileName))
			{
				writer.Write(json);
			}
		}

		public void LoadProperties(string fileName)
		{
			using (StreamReader reader = new StreamReader(fileName))
			{
				string json = reader.ReadToEnd();

				var temp = JsonSerializer.Deserialize<GoogleLoopholeTranslator>(json);

				this.SourceLanguage		= temp.SourceLanguage;
				this.TargetLanguages	= temp.TargetLanguages;
			}
		}

		private string Translate(string source, string targetLanguage)
		{
			string url = $"{SIMPLE_BASE_URL}?client={GTX_CLIENT}&dt={TASK}&sl={this.SourceLanguage}&tl={targetLanguage}&q={source}";

			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = client.Send(request);

				if (!response.IsSuccessStatusCode)
				{
					return null;
				}

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
