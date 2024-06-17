using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.FileFormats;
using NAudio.CoreAudioApi;
using NAudio;

namespace SpeachForm
{
	internal class Recording
	{
		WaveIn waveIn;
		EventHandler<WaveInEventArgs> _waveIn_DataAvailable;
		EventHandler<StoppedEventArgs> _waveIn_RecordingStopped;
		//WaveFileWriter writer;
		//string outputFilename = "record.wav";
		//public MemoryStream recStream;
		public void StopRecording()
		{
			//MessageBox.Show("StopRecording");
			if (waveIn != null)
			{
				waveIn.StopRecording();
			}
		}
		public void Start()
		{
			waveIn = new WaveIn();
			waveIn.DeviceNumber = 0;
			waveIn.DataAvailable += _waveIn_DataAvailable;
			waveIn.RecordingStopped += _waveIn_RecordingStopped;
			waveIn.WaveFormat = new WaveFormat(16000, 1);
			//recStream = new MemoryStream();
			waveIn.StartRecording();
		}
		public void Stop()
		{
			waveIn.Dispose();
			waveIn = null;
		}
		public Recording(EventHandler<WaveInEventArgs> waveIn_DataAvailable, EventHandler<StoppedEventArgs> waveIn_RecordingStopped)
		{
			_waveIn_DataAvailable = waveIn_DataAvailable;
			_waveIn_RecordingStopped = waveIn_RecordingStopped;
		}
	}
}
