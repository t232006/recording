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
		//WaveFileWriter writer;
		//string outputFilename = "record.wav";
		public MemoryStream recStream;
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
			//writer = new WaveFileWriter(outputFilename, waveIn.WaveFormat);
			//Начало записи
			waveIn.StartRecording();
		}
		public void Stop()
		{
			//waveIn.Dispose();
			//waveIn = null;
			//writer.Close();
			//writer = null;
		}
		public void WriteFile(byte[] buffer, int bytesRecorded) 
		{
			//Записываем данные из буфера в файл
			recStream.WriteAsync(buffer, 0, bytesRecorded);
			//writer.Write(buffer, 0, bytesRecorded);

		}
		public Recording(EventHandler<WaveInEventArgs> waveIn_DataAvailable, EventHandler<StoppedEventArgs> waveIn_RecordingStopped)
		{
			waveIn = new WaveIn();
			waveIn.DeviceNumber = 0;
			waveIn.DataAvailable += waveIn_DataAvailable;
			waveIn.RecordingStopped += waveIn_RecordingStopped;
				//Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
			waveIn.WaveFormat = new WaveFormat(16000, 1);
			recStream = new MemoryStream();
		//Инициализируем объект WaveFileWriter
			
		}
	}
}
