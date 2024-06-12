namespace SpeachForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			cbLangModel = new ComboBox();
			label1 = new Label();
			groupBox1 = new GroupBox();
			groupBox3 = new GroupBox();
			label3 = new Label();
			groupBox4 = new GroupBox();
			chShowIndicator = new CheckBox();
			txTimeRem = new TextBox();
			label5 = new Label();
			label4 = new Label();
			txTime = new TextBox();
			textBox1 = new TextBox();
			label2 = new Label();
			groupBox2 = new GroupBox();
			button3 = new Button();
			riTextBox = new RichTextBox();
			timer = new System.Windows.Forms.Timer(components);
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// cbLangModel
			// 
			cbLangModel.DisplayMember = "1";
			cbLangModel.FormattingEnabled = true;
			cbLangModel.Items.AddRange(new object[] { "English small", "Russian small" });
			cbLangModel.Location = new Point(134, 12);
			cbLangModel.Name = "cbLangModel";
			cbLangModel.Size = new Size(260, 23);
			cbLangModel.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 17);
			label1.Name = "label1";
			label1.Size = new Size(103, 15);
			label1.TabIndex = 3;
			label1.Text = "Языковая модель";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Location = new Point(9, 56);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(385, 225);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Режимы активности";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(groupBox4);
			groupBox3.Controls.Add(txTime);
			groupBox3.Controls.Add(textBox1);
			groupBox3.Controls.Add(label2);
			groupBox3.Location = new Point(188, 22);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(191, 197);
			groupBox3.TabIndex = 1;
			groupBox3.TabStop = false;
			groupBox3.Text = "Выводить текст по условию";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 88);
			label3.Name = "label3";
			label3.Size = new Size(107, 15);
			label3.TabIndex = 4;
			label3.Text = "Время активности";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(chShowIndicator);
			groupBox4.Controls.Add(txTimeRem);
			groupBox4.Controls.Add(label5);
			groupBox4.Controls.Add(label4);
			groupBox4.Location = new Point(12, 116);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(167, 75);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			// 
			// chShowIndicator
			// 
			chShowIndicator.AutoSize = true;
			chShowIndicator.Location = new Point(146, 19);
			chShowIndicator.Name = "chShowIndicator";
			chShowIndicator.Size = new Size(15, 14);
			chShowIndicator.TabIndex = 3;
			chShowIndicator.TextAlign = ContentAlignment.MiddleRight;
			chShowIndicator.UseVisualStyleBackColor = true;
			chShowIndicator.MouseClick += chShowIndicator_MouseClick;
			// 
			// txTimeRem
			// 
			txTimeRem.Location = new Point(125, 44);
			txTimeRem.Name = "txTimeRem";
			txTimeRem.Size = new Size(36, 23);
			txTimeRem.TabIndex = 2;
			txTimeRem.Text = "0";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(8, 46);
			label5.Name = "label5";
			label5.Size = new Size(111, 15);
			label5.TabIndex = 1;
			label5.Text = "Оставшееся время";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(10, 19);
			label4.Name = "label4";
			label4.Size = new Size(132, 15);
			label4.TabIndex = 0;
			label4.Text = "Индикатор активности";
			// 
			// txTime
			// 
			txTime.Location = new Point(132, 85);
			txTime.Name = "txTime";
			txTime.Size = new Size(47, 23);
			txTime.TabIndex = 2;
			txTime.Text = "3";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 56);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(167, 23);
			textBox1.TabIndex = 1;
			textBox1.Text = "Vosk";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(10, 30);
			label2.Name = "label2";
			label2.Size = new Size(169, 15);
			label2.TabIndex = 0;
			label2.Text = "Контрольное слово (триггер)";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button3);
			groupBox2.Location = new Point(10, 22);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(172, 197);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Выводить текст";
			// 
			// button3
			// 
			button3.Location = new Point(14, 26);
			button3.Name = "button3";
			button3.Size = new Size(152, 23);
			button3.TabIndex = 0;
			button3.Text = "...пока нажата кнопка";
			button3.UseVisualStyleBackColor = true;
			button3.MouseDown += button3_MouseDown;
			button3.MouseUp += button3_MouseUp;
			// 
			// riTextBox
			// 
			riTextBox.Location = new Point(9, 287);
			riTextBox.Name = "riTextBox";
			riTextBox.Size = new Size(385, 207);
			riTextBox.TabIndex = 5;
			riTextBox.Text = "";
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 1000;
			timer.Tick += timer1_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(402, 506);
			Controls.Add(riTextBox);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(cbLangModel);
			MaximizeBox = false;
			Name = "Form1";
			Text = "VoskCheck";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbLangModel;
		private Label label1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button button3;
		private GroupBox groupBox3;
		private Label label2;
		private Label label3;
		private GroupBox groupBox4;
		private CheckBox chShowIndicator;
		private TextBox txTimeRem;
		private Label label5;
		private Label label4;
		private TextBox txTime;
		private TextBox textBox1;
		private RichTextBox riTextBox;
		private System.Windows.Forms.Timer timer;
	}
}