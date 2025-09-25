using LinScape.Library;

namespace LinScape
{
	public partial class LinScapeForm : Form
	{
		public LinScapeForm()
		{
			InitializeComponent();

			ITranslator translator = new GoogleLoopholeTranslator();

			translator.TargetLanguages.AddRange(new string[]{"de", "pl"});

			string source = "hello";

			var result = translator.Translate(source);
		}
	}
}
