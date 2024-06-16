using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Security.Cryptography;
using NAudio.Wave;
using SpeachForm;

namespace SpeachForm
{
	public partial class Form1 : Form
	{
		Recording record;
		Recognizer recogn;
		public Form1()
		{
			InitializeComponent();
		}
		private void waveIn_RecordingStopped(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new EventHandler(waveIn_RecordingStopped), sender, e);
			}
			else
			{
				record.Stop();
			}
		}
		void waveIn_DataAvailable(object sender, WaveInEventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
			}
			else
			{
				//Записываем данные из буфера в файл
				record.WriteFile(e.Buffer, e.BytesRecorded);
				recogn.Source = record.recStream;
				for (int i = 0; i < e.BytesRecorded; i += 2)
				{
					short sample = (short)(e.Buffer[i + 1] << 8 | e.Buffer[i]);
					volumeMeter1.Amplitude = Math.Abs(sample / 32768f);
				}
			}
		}
		private void button3_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				record.Start();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		private void button3_MouseUp(object sender, MouseEventArgs e)
		{
			record.StopRecording();
			riTextBox.Text = recogn.start(Convert.ToByte(cbLangModel.SelectedIndex));
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (chShowIndicator.Checked)
				//byte b = Convert.ToByte()
				if (txTimeRem.Text == "0") return;//timer.Enabled = false;
				else
					txTimeRem.Text = (Convert.ToByte(txTimeRem.Text) - 1).ToString();

		}
		private void chShowIndicator_MouseClick(object sender, MouseEventArgs e)
		{
			if (chShowIndicator.Checked)
				txTimeRem.Text = txTime.Text;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			record = new Recording(waveIn_DataAvailable, waveIn_RecordingStopped);
			recogn = new Recognizer();
			cbLangModel.SelectedIndex = 0;
		}
	}
}