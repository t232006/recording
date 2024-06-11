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
		private byte[]? streamBuf;
		private int bytesRead;
		public int BytesRead { set => bytesRead = value; }
		public byte[] StreamBuf { set { streamBuf = value; } }
		private string[] langModel= new string[2] { "model-small-en", "model-small-ru" } ;
		public string LangModel(byte ind)
		{
			return Directory.GetCurrentDirectory()+'\\'+langModel[ind];
		}

		public string Speaker(Model model, bool fromFile)
		{
			Stream source;
			// Output speakers
			SpkModel spkModel = new SpkModel("model-spk");
			VoskRecognizer rec = new VoskRecognizer(model, 16000.0f);
			rec.SetSpkModel(spkModel);
			StringBuilder s = new StringBuilder("");
			if (fromFile)
			{
				source = File.OpenRead("record.wav");
				while ((bytesRead = source.Read(streamBuf, 0, streamBuf.Length)) > 0)
				{
					if (rec.AcceptWaveform(streamBuf, bytesRead))
					{
						s.Append(rec.Result());
					}
					else
					{
						s.Append(rec.PartialResult());
					}
				}
				source.Close();
			}
			else
			{
				while 
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
