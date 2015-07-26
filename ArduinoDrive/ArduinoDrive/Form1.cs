using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoDrive {

    public partial class Form1 : Form {
		
		VirtualArduino virtualArduino;

		/// <summary>
		/// ピン設定
		/// </summary>
		class PinConfig {
			public RadioButton_pin radioOutput; public RadioButton_pin radioInput; public RadioButton_pin radioInputPullup;	// 入出力モード
			public RadioButton_pin radioDigital; public RadioButton_pin radioAnalog;										// ＡＤモード
			public Label_pin labelValue; public TrackBar_pin trackBar;														// ピン値

			public PinConfig(RadioButton_pin argOutput, RadioButton_pin argInput, RadioButton_pin argInputPullup, RadioButton_pin argDigital, RadioButton_pin argAnalog, Label_pin argValue, TrackBar_pin argBar) {

				this.radioOutput = argOutput; this.radioInput = argInput; this.radioInputPullup = argInputPullup;
				this.radioDigital = argDigital; this.radioAnalog = argAnalog;
				this.labelValue = argValue; this.trackBar = argBar;
			}
		}
		PinConfig[] pinConfig;


		public Form1() {

            InitializeComponent();

			// ピン設定（内部変数値）を初期化
			pinConfig = new PinConfig[20];
			this.pinConfig[0] = new PinConfig(radioOutput_dummy, radioInput_dummy, radioInputPullup_dummy, radioDigital_dummy, radioAnalog_dummy, labelValue_dummy, trackBar_dummy);
			this.pinConfig[1] = new PinConfig(radioOutput_dummy, radioInput_dummy, radioInputPullup_dummy, radioDigital_dummy, radioAnalog_dummy, labelValue_dummy, trackBar_dummy);
			this.pinConfig[2] = new PinConfig(radioOutput_2, radioInput_2, radioInputPullup_2, radioDigital_2, radioAnalog_2, labelValue_2, trackBar_2);
			this.pinConfig[3] = new PinConfig(radioOutput_3, radioInput_3, radioInputPullup_3, radioDigital_3, radioAnalog_3, labelValue_3, trackBar_3);
			this.pinConfig[4] = new PinConfig(radioOutput_4, radioInput_4, radioInputPullup_4, radioDigital_4, radioAnalog_4, labelValue_4, trackBar_4);
			this.pinConfig[5] = new PinConfig(radioOutput_5, radioInput_5, radioInputPullup_5, radioDigital_5, radioAnalog_5, labelValue_5, trackBar_5);
			this.pinConfig[6] = new PinConfig(radioOutput_6, radioInput_6, radioInputPullup_6, radioDigital_6, radioAnalog_6, labelValue_6, trackBar_6);
			this.pinConfig[7] = new PinConfig(radioOutput_7, radioInput_7, radioInputPullup_7, radioDigital_7, radioAnalog_7, labelValue_7, trackBar_7);
			this.pinConfig[8] = new PinConfig(radioOutput_8, radioInput_8, radioInputPullup_8, radioDigital_8, radioAnalog_8, labelValue_8, trackBar_8);
			this.pinConfig[9] = new PinConfig(radioOutput_9, radioInput_9, radioInputPullup_9, radioDigital_9, radioAnalog_9, labelValue_9, trackBar_9);
			this.pinConfig[10] = new PinConfig(radioOutput_10, radioInput_10, radioInputPullup_10, radioDigital_10, radioAnalog_10, labelValue_10, trackBar_10);
			this.pinConfig[11] = new PinConfig(radioOutput_11, radioInput_11, radioInputPullup_11, radioDigital_11, radioAnalog_11, labelValue_11, trackBar_11);
			this.pinConfig[12] = new PinConfig(radioOutput_12, radioInput_12, radioInputPullup_12, radioDigital_12, radioAnalog_12, labelValue_12, trackBar_12);
			this.pinConfig[13] = new PinConfig(radioOutput_13, radioInput_13, radioInputPullup_13, radioDigital_13, radioAnalog_13, labelValue_13, trackBar_13);
			this.pinConfig[14] = new PinConfig(radioOutput_14, radioInput_14, radioInputPullup_14, radioDigital_14, radioAnalog_14, labelValue_14, trackBar_14);
			this.pinConfig[15] = new PinConfig(radioOutput_15, radioInput_15, radioInputPullup_15, radioDigital_15, radioAnalog_15, labelValue_15, trackBar_15);
			this.pinConfig[16] = new PinConfig(radioOutput_16, radioInput_16, radioInputPullup_16, radioDigital_16, radioAnalog_16, labelValue_16, trackBar_16);
			this.pinConfig[17] = new PinConfig(radioOutput_17, radioInput_17, radioInputPullup_17, radioDigital_17, radioAnalog_17, labelValue_17, trackBar_17);
			this.pinConfig[18] = new PinConfig(radioOutput_18, radioInput_18, radioInputPullup_18, radioDigital_18, radioAnalog_18, labelValue_18, trackBar_18);
			this.pinConfig[19] = new PinConfig(radioOutput_19, radioInput_19, radioInputPullup_19, radioDigital_19, radioAnalog_19, labelValue_19, trackBar_19);


			virtualArduino = new VirtualArduino(this.serialPort1);

			DisableForms();

		}


		#region 入出力モード＆ＡＤモードをクリック
		private void radioIO_AD_Click(object sender, EventArgs e) {

			byte pinNumber = ((RadioButton_pin)sender).PinNumber;			// ピン番号
			VirtualArduino.PinMode pinMode = VirtualArduino.PinMode.OUTPUT;	// 入出力モード
			VirtualArduino.AD pinAD = VirtualArduino.AD.DIGITAL;			// ＡＤモード

			// 入出力モード
			if (this.pinConfig[pinNumber].radioOutput.Checked) pinMode = VirtualArduino.PinMode.OUTPUT;
			else if (this.pinConfig[pinNumber].radioInput.Checked) pinMode = VirtualArduino.PinMode.INPUT;
			else if (this.pinConfig[pinNumber].radioInputPullup.Checked) pinMode = VirtualArduino.PinMode.INPUT_PULLUP;

			// ＡＤモード
			if (this.pinConfig[pinNumber].radioDigital.Checked) pinAD = VirtualArduino.AD.DIGITAL;
			else if (this.pinConfig[pinNumber].radioAnalog.Checked) pinAD = VirtualArduino.AD.ANALOG;




			// TrackBarのレンジを変更
			switch (pinAD) {
				case VirtualArduino.AD.DIGITAL:

					this.pinConfig[pinNumber].radioInput.Enabled = true;
					this.pinConfig[pinNumber].radioInputPullup.Enabled = true;

					this.pinConfig[pinNumber].trackBar.Maximum = 1;
					this.pinConfig[pinNumber].trackBar.TickFrequency = 1;

					this.pinConfig[pinNumber].labelValue.Text = (this.pinConfig[pinNumber].trackBar.Value == 0) ? "LOW" : "HIGH";

					break;

				case VirtualArduino.AD.ANALOG:

					if (pinNumber <= 13) {
						this.pinConfig[pinNumber].radioInput.Enabled = false;
						this.pinConfig[pinNumber].radioInputPullup.Enabled = false;
						this.pinConfig[pinNumber].radioOutput.Checked = true;
						pinMode = VirtualArduino.PinMode.OUTPUT;
					}

					this.pinConfig[pinNumber].trackBar.Maximum = (pinMode == VirtualArduino.PinMode.OUTPUT) ? 255 : 1023;
					this.pinConfig[pinNumber].trackBar.TickFrequency = 16;

					this.pinConfig[pinNumber].labelValue.Text
						= (pinMode == VirtualArduino.PinMode.OUTPUT)
						? (5.0 * this.pinConfig[pinNumber].trackBar.Value / 255).ToString("F2") + "V"
						: (5.0 * this.pinConfig[pinNumber].trackBar.Value / 1024).ToString("F3") + "V";

					break;
			}

			// TrackBarの有効／無効を変更
			switch (pinMode) {

				case VirtualArduino.PinMode.OUTPUT:

					if (pinNumber != 3 && pinNumber != 5 && pinNumber != 6 && pinNumber != 9 && pinNumber != 10 && pinNumber != 11) {
						this.pinConfig[pinNumber].radioAnalog.Enabled = false;
						this.pinConfig[pinNumber].radioDigital.Checked = true;
						pinAD = VirtualArduino.AD.DIGITAL;
					}
					else {
						this.pinConfig[pinNumber].radioAnalog.Enabled = true;
					}

					this.pinConfig[pinNumber].trackBar.Enabled = true;
					break;

				case VirtualArduino.PinMode.INPUT:
				case VirtualArduino.PinMode.INPUT_PULLUP:

					if (pinNumber <= 13) {
						this.pinConfig[pinNumber].radioAnalog.Enabled = false;
					}


					this.pinConfig[pinNumber].trackBar.Enabled = false;

					break;
			}


			// 入出力設定を送信
			virtualArduino.setPinMode(pinNumber, pinMode, pinAD);


			// 入出力値を送信
			if (this.pinConfig[pinNumber].radioOutput.Checked) {
				virtualArduino.setPinValue(pinNumber, this.pinConfig[pinNumber].trackBar.Value);
			}

		}
		#endregion





		#region trackBarをスクロール
		private void trackBar_Scroll(object sender, EventArgs e) {


			TrackBar_pin trackBar = (TrackBar_pin)sender;
			byte pinNumber = ((TrackBar_pin)sender).PinNumber;

			// 出力
			virtualArduino.setPinValue(pinNumber, this.pinConfig[pinNumber].trackBar.Value);

			// 表示
			if (this.pinConfig[pinNumber].radioDigital.Checked) {
				// デジタルモードの場合
				this.pinConfig[pinNumber].labelValue.Text = (trackBar.Value == 0) ? "LOW" : "HIGH";
			}
			else {
				// アナログモードの場合
				this.pinConfig[pinNumber].labelValue.Text = trackBar.Value.ToString();


				this.pinConfig[pinNumber].labelValue.Text
					= (this.pinConfig[pinNumber].radioOutput.Checked)
					? (5.0 * this.pinConfig[pinNumber].trackBar.Value / 255).ToString("F2") + "V"
					: (5.0 * this.pinConfig[pinNumber].trackBar.Value / 1024).ToString("F3") + "V";
			}
		}

		#endregion



		/// <summary>
		/// 通信を開始し、ボードを初期化後にフォームを有効化
		/// </summary>
		private void startConnection() {

			// COMポートオーブン
			try {

				serialPort1.Open();

			} catch (Exception exc) {

				stopConnection();

				MessageBox.Show("\"" + serialPort1.PortName + "\"を開くことができません");

				Console.WriteLine(exc.ToString());
				return;
			}


			// ピン設定（Arduino）を初期化
			try {

				for (int i = 0; i < pinConfig.Length; i++) {

					if (i == 0 || i == 1) continue;		// 通信ピンは設定しない

					radioIO_AD_Click((object)pinConfig[i].radioOutput, null);	// ピン設定ラジオボタンの押下時と同じ処理（ラジオボタンの初期設定を使用）

				}

				Console.WriteLine("\n\n--- pin initializatoin is completed. ---\n");

			} catch (VirtualArduino.TimeoutException exc) {


				MessageBox.Show("ボードの初期化ができません");

				stopConnection();

				Console.WriteLine(exc.ToString());
				return;
			}

			// フォームを有効化
			EnableForms();

		}


		/// <summary>
		/// 通信を停止し、フォームを無効化　▲保留
		/// </summary>
		private void stopConnection() {
			DisableForms();
			serialPort1.Close();
			toolStripMenuItem_COM.Text = "COMポート：未接続";
		}

		/// <summary>
		/// ボーレート選択時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem_Click_BaudRate(object sender, EventArgs e) {

			this.serialPort1.BaudRate = int.Parse(((ToolStripMenuItem)sender).Text);
		}

		/// <summary>
		/// ＣＯＭポート選択時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem_Click_COM(object sender, EventArgs e) {

			this.serialPort1.PortName = ((ToolStripMenuItem)sender).Text;

			toolStripMenuItem_COM.Text = "COMポート：" + serialPort1.PortName;

			startConnection();
		}

		private void toolStripMenuItem_Click_切断(object sender, EventArgs e) {
			stopConnection();
		}

		/// <summary>
		/// フォームを有効化
		/// </summary>
		private void EnableForms() {

			// ボーレート設定
			toolStripMenuItem_BaudRate.Enabled = false;

			// ＣＯＭポート設定
			toolStripMenuItem_COM.DropDownItems.Clear();
			ToolStripMenuItem tsmiNew = new ToolStripMenuItem("切断");
			tsmiNew.Name = "切断";
			tsmiNew.Click += new EventHandler(toolStripMenuItem_Click_切断);
			toolStripMenuItem_COM.DropDownItems.Add(tsmiNew);

			// ボード設定フォーム
			for (int i = 0; i < this.pinConfig.Length; i++) {
				if (this.pinConfig[i].radioDigital.Checked || (this.pinConfig[i].radioAnalog.Checked && (i == 3 || i == 5 || i == 6 || i == 9 || i == 10 || i == 11))) {
					this.pinConfig[i].radioOutput.Enabled = true;
				}

				if (this.pinConfig[i].radioDigital.Checked || (this.pinConfig[i].radioAnalog.Checked && i > 13)) {
					this.pinConfig[i].radioInput.Enabled = true;
					this.pinConfig[i].radioInputPullup.Enabled = true;
				}

				this.pinConfig[i].radioDigital.Enabled = true;

				if (this.pinConfig[i].radioOutput.Checked && (i == 3 || i == 5 || i == 6 || i == 9 || i == 10 || i == 11)  || ( ! this.pinConfig[i].radioOutput.Checked && i >= 14)) {
					this.pinConfig[i].radioAnalog.Enabled = true;
				}

				this.pinConfig[i].labelValue.Enabled = true;
				if (this.pinConfig[i].radioOutput.Checked) {
					this.pinConfig[i].trackBar.Enabled = true;
				}
			}

			// データ読込み通信間隔
			toolStripMenuItem_Interval.Enabled = false;
			timerRead.Start();
		}

		/// <summary>
		/// フォームを無効化
		/// </summary>
		private void DisableForms() {

			// ボーレート設定
			toolStripMenuItem_BaudRate.Enabled = true;


			// ＣＯＭポート設定
			string[] strPortNamaes = System.IO.Ports.SerialPort.GetPortNames();
			// ToolStripMenuItemにポートリストを追加
			for (int i = 0; i < strPortNamaes.Length; i++) {

				if (!toolStripMenuItem_COM.DropDownItems.ContainsKey(strPortNamaes[i])) {
					// 追加していないポートのみ追加
					ToolStripMenuItem tsmiNew = new ToolStripMenuItem(strPortNamaes[i]);
					tsmiNew.Name = strPortNamaes[i];
					tsmiNew.Click += new EventHandler(toolStripMenuItem_Click_COM);
					toolStripMenuItem_COM.DropDownItems.Add(tsmiNew);
				}

				toolStripMenuItem_COM.DropDownItems.RemoveByKey("切断");

			}

			// ボード設定フォーム
			for (int i = 0; i < this.pinConfig.Length; i++) {
				this.pinConfig[i].radioOutput.Enabled = false;
				this.pinConfig[i].radioInput.Enabled = false;
				this.pinConfig[i].radioInputPullup.Enabled = false;
				this.pinConfig[i].radioDigital.Enabled = false;
				this.pinConfig[i].radioAnalog.Enabled = false;
				this.pinConfig[i].labelValue.Enabled = false;
				this.pinConfig[i].trackBar.Enabled = false;
			}

			// データ読込み通信間隔
			toolStripMenuItem_Interval.Enabled = true;
			timerRead.Stop();
		}


		#region その他処理
		private void Form1_Click(object sender, EventArgs e) {

			tableLayoutPanel1.Focus();
		}

		private void tableLayoutPanel1_Click(object sender, EventArgs e) {

			tableLayoutPanel1.Focus();
		}
		#endregion


		private void ToolStripMenuItem_COM_MouseHover(object sender, EventArgs e) {
			
			if ( ! serialPort1.IsOpen) {
				// 通信切断中
				
				// 存在するCOMポート
				string[] strPortNamaes = System.IO.Ports.SerialPort.GetPortNames();

				// ToolStripMenuItemにポートリストを追加
				for (int i = 0; i < strPortNamaes.Length; i++) {

					if (!toolStripMenuItem_COM.DropDownItems.ContainsKey(strPortNamaes[i])) {
						// 追加していないポートのみ追加

						ToolStripMenuItem tsmiNew = new ToolStripMenuItem(strPortNamaes[i]);
						tsmiNew.Name = strPortNamaes[i];
						tsmiNew.Click += new EventHandler(toolStripMenuItem_Click_COM);
						toolStripMenuItem_COM.DropDownItems.Add(tsmiNew);
					}
				}
			}
		}

		private void ToolStripMenuItem_Click_Interval(object sender, EventArgs e) {

			timerRead.Interval = int.Parse(((ToolStripMenuItem)sender).Text);

			toolStripMenuItem_Interval.Text = "Interval：" + timerRead.Interval;

		}


		private void timerRead_Tick(object sender, EventArgs e) {

			for (byte b = 0; b < this.pinConfig.Length; b++) {

				if (this.pinConfig[b].radioInput.Checked || this.pinConfig[b].radioInputPullup.Checked) {

					int value = virtualArduino.getPinValue(b);

					try {
						this.pinConfig[b].trackBar.Value = value;
						//this.pinConfig[b].labelValue.Text = value.ToString();

						if (this.pinConfig[b].radioDigital.Checked) {
							this.pinConfig[b].labelValue.Text = (value == 0) ? "LOW" : "HIGH";
						}
						else {
							this.pinConfig[b].labelValue.Text
								= (this.pinConfig[b].radioOutput.Checked)
								? (5.0 * this.pinConfig[b].trackBar.Value / 255).ToString("F2") + "V"
								: (5.0 * this.pinConfig[b].trackBar.Value / 1024).ToString("F3") + "V";
						}
					} catch (Exception) { }
				}
			}

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

		}

		private void label3_Click(object sender, EventArgs e) {

		}

		private void label5_Click(object sender, EventArgs e) {

		}
	}
}
