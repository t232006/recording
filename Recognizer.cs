using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using Vosk;

namespace recording
{
	internal class Recognizer
	{
		//string WORKDIR = Directory.GetCurrentDirectory();
		private string[] langModel= new string[2] { "model-small-en", "model-small-ru" } ;
		public string LangModel(byte ind)
		{
			return Directory.GetCurrentDirectory()+'\\'+langModel[ind];
		}

		public string Speaker(Model model)
		{
			// Output speakers
			SpkModel spkModel = new SpkModel("model-spk");
			VoskRecognizer rec = new VoskRecognizer(model, 16000.0f);
			rec.SetSpkModel(spkModel);
			StringBuilder s = new StringBuilder("");

			using (Stream source = File.OpenRead("record.wav"))
			{
				byte[] buffer = new byte[4096];
				int bytesRead;
				while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
				{
					if (rec.AcceptWaveform(buffer, bytesRead))
					{
						s.Append(rec.Result());
					}
					else
					{
						s.Append(rec.PartialResult());
					}
				}
			}
			s.Append(rec.FinalResult());
			return s.ToString();
		}

		public string start(byte ind)
		{
			Model model = new Model(LangModel(ind));
			return Speaker(model);
		}
		
	}
}
