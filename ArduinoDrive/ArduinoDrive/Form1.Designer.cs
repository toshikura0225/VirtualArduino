namespace ArduinoDrive
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.radioDigital_2 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_2 = new ArduinoDrive.RadioButton_pin();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioDigital_6 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_6 = new ArduinoDrive.RadioButton_pin();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioInputPullup_6 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_6 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_6 = new ArduinoDrive.RadioButton_pin();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.labelValue_6 = new ArduinoDrive.Label_pin();
			this.trackBar_6 = new ArduinoDrive.TrackBar_pin();
			this.panel15 = new System.Windows.Forms.Panel();
			this.labelValue_9 = new ArduinoDrive.Label_pin();
			this.trackBar_9 = new ArduinoDrive.TrackBar_pin();
			this.panel17 = new System.Windows.Forms.Panel();
			this.labelValue_10 = new ArduinoDrive.Label_pin();
			this.trackBar_10 = new ArduinoDrive.TrackBar_pin();
			this.panel5 = new System.Windows.Forms.Panel();
			this.labelValue_11 = new ArduinoDrive.Label_pin();
			this.trackBar_11 = new ArduinoDrive.TrackBar_pin();
			this.panel9 = new System.Windows.Forms.Panel();
			this.labelValue_5 = new ArduinoDrive.Label_pin();
			this.trackBar_5 = new ArduinoDrive.TrackBar_pin();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labelValue_3 = new ArduinoDrive.Label_pin();
			this.trackBar_3 = new ArduinoDrive.TrackBar_pin();
			this.panel38 = new System.Windows.Forms.Panel();
			this.labelValue_19 = new ArduinoDrive.Label_pin();
			this.trackBar_19 = new ArduinoDrive.TrackBar_pin();
			this.panel6 = new System.Windows.Forms.Panel();
			this.radioInputPullup_2 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_2 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_2 = new ArduinoDrive.RadioButton_pin();
			this.label4 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.radioInputPullup_3 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_3 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_3 = new ArduinoDrive.RadioButton_pin();
			this.panel10 = new System.Windows.Forms.Panel();
			this.radioInputPullup_4 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_4 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_4 = new ArduinoDrive.RadioButton_pin();
			this.panel12 = new System.Windows.Forms.Panel();
			this.radioInputPullup_5 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_5 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_5 = new ArduinoDrive.RadioButton_pin();
			this.panel20 = new System.Windows.Forms.Panel();
			this.radioDigital_3 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_3 = new ArduinoDrive.RadioButton_pin();
			this.panel21 = new System.Windows.Forms.Panel();
			this.radioDigital_4 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_4 = new ArduinoDrive.RadioButton_pin();
			this.panel22 = new System.Windows.Forms.Panel();
			this.radioDigital_5 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_5 = new ArduinoDrive.RadioButton_pin();
			this.panel23 = new System.Windows.Forms.Panel();
			this.radioDigital_7 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_7 = new ArduinoDrive.RadioButton_pin();
			this.panel24 = new System.Windows.Forms.Panel();
			this.labelValue_8 = new ArduinoDrive.Label_pin();
			this.trackBar_8 = new ArduinoDrive.TrackBar_pin();
			this.panel18 = new System.Windows.Forms.Panel();
			this.labelValue_4 = new ArduinoDrive.Label_pin();
			this.trackBar_4 = new ArduinoDrive.TrackBar_pin();
			this.panel25 = new System.Windows.Forms.Panel();
			this.labelValue_7 = new ArduinoDrive.Label_pin();
			this.trackBar_7 = new ArduinoDrive.TrackBar_pin();
			this.panel28 = new System.Windows.Forms.Panel();
			this.radioInputPullup_7 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_7 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_7 = new ArduinoDrive.RadioButton_pin();
			this.panel16 = new System.Windows.Forms.Panel();
			this.radioDigital_8 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_8 = new ArduinoDrive.RadioButton_pin();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.panel33 = new System.Windows.Forms.Panel();
			this.labelValue_18 = new ArduinoDrive.Label_pin();
			this.trackBar_18 = new ArduinoDrive.TrackBar_pin();
			this.panel36 = new System.Windows.Forms.Panel();
			this.labelValue_15 = new ArduinoDrive.Label_pin();
			this.trackBar_15 = new ArduinoDrive.TrackBar_pin();
			this.panel37 = new System.Windows.Forms.Panel();
			this.labelValue_14 = new ArduinoDrive.Label_pin();
			this.trackBar_14 = new ArduinoDrive.TrackBar_pin();
			this.panel39 = new System.Windows.Forms.Panel();
			this.labelValue_12 = new ArduinoDrive.Label_pin();
			this.trackBar_12 = new ArduinoDrive.TrackBar_pin();
			this.panel40 = new System.Windows.Forms.Panel();
			this.labelValue_13 = new ArduinoDrive.Label_pin();
			this.trackBar_13 = new ArduinoDrive.TrackBar_pin();
			this.panel42 = new System.Windows.Forms.Panel();
			this.radioInputPullup_8 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_8 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_8 = new ArduinoDrive.RadioButton_pin();
			this.panel43 = new System.Windows.Forms.Panel();
			this.radioInputPullup_9 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_9 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_9 = new ArduinoDrive.RadioButton_pin();
			this.panel44 = new System.Windows.Forms.Panel();
			this.radioInputPullup_10 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_10 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_10 = new ArduinoDrive.RadioButton_pin();
			this.panel45 = new System.Windows.Forms.Panel();
			this.radioInputPullup_11 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_11 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_11 = new ArduinoDrive.RadioButton_pin();
			this.panel46 = new System.Windows.Forms.Panel();
			this.radioInputPullup_12 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_12 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_12 = new ArduinoDrive.RadioButton_pin();
			this.panel47 = new System.Windows.Forms.Panel();
			this.radioInputPullup_13 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_13 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_13 = new ArduinoDrive.RadioButton_pin();
			this.panel48 = new System.Windows.Forms.Panel();
			this.radioInputPullup_14 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_14 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_14 = new ArduinoDrive.RadioButton_pin();
			this.panel49 = new System.Windows.Forms.Panel();
			this.radioInputPullup_16 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_16 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_16 = new ArduinoDrive.RadioButton_pin();
			this.panel50 = new System.Windows.Forms.Panel();
			this.radioInputPullup_17 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_17 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_17 = new ArduinoDrive.RadioButton_pin();
			this.panel51 = new System.Windows.Forms.Panel();
			this.radioInputPullup_15 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_15 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_15 = new ArduinoDrive.RadioButton_pin();
			this.panel52 = new System.Windows.Forms.Panel();
			this.radioInputPullup_18 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_18 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_18 = new ArduinoDrive.RadioButton_pin();
			this.panel53 = new System.Windows.Forms.Panel();
			this.radioInputPullup_19 = new ArduinoDrive.RadioButton_pin();
			this.radioInput_19 = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_19 = new ArduinoDrive.RadioButton_pin();
			this.panel54 = new System.Windows.Forms.Panel();
			this.radioDigital_9 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_9 = new ArduinoDrive.RadioButton_pin();
			this.panel55 = new System.Windows.Forms.Panel();
			this.radioDigital_10 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_10 = new ArduinoDrive.RadioButton_pin();
			this.panel56 = new System.Windows.Forms.Panel();
			this.radioDigital_11 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_11 = new ArduinoDrive.RadioButton_pin();
			this.panel57 = new System.Windows.Forms.Panel();
			this.radioDigital_12 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_12 = new ArduinoDrive.RadioButton_pin();
			this.panel58 = new System.Windows.Forms.Panel();
			this.radioDigital_13 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_13 = new ArduinoDrive.RadioButton_pin();
			this.panel59 = new System.Windows.Forms.Panel();
			this.radioDigital_14 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_14 = new ArduinoDrive.RadioButton_pin();
			this.panel60 = new System.Windows.Forms.Panel();
			this.radioDigital_15 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_15 = new ArduinoDrive.RadioButton_pin();
			this.panel61 = new System.Windows.Forms.Panel();
			this.radioDigital_16 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_16 = new ArduinoDrive.RadioButton_pin();
			this.panel62 = new System.Windows.Forms.Panel();
			this.radioDigital_17 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_17 = new ArduinoDrive.RadioButton_pin();
			this.panel63 = new System.Windows.Forms.Panel();
			this.radioDigital_18 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_18 = new ArduinoDrive.RadioButton_pin();
			this.panel64 = new System.Windows.Forms.Panel();
			this.radioDigital_19 = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_19 = new ArduinoDrive.RadioButton_pin();
			this.panel66 = new System.Windows.Forms.Panel();
			this.labelValue_2 = new ArduinoDrive.Label_pin();
			this.trackBar_2 = new ArduinoDrive.TrackBar_pin();
			this.panel35 = new System.Windows.Forms.Panel();
			this.labelValue_17 = new ArduinoDrive.Label_pin();
			this.trackBar_17 = new ArduinoDrive.TrackBar_pin();
			this.panel34 = new System.Windows.Forms.Panel();
			this.labelValue_16 = new ArduinoDrive.Label_pin();
			this.trackBar_16 = new ArduinoDrive.TrackBar_pin();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem_COM = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_BaudRate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Interval = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.timerRead = new System.Windows.Forms.Timer(this.components);
			this.panel14 = new System.Windows.Forms.Panel();
			this.radioButton_pin10 = new ArduinoDrive.RadioButton_pin();
			this.radioButton_pin11 = new ArduinoDrive.RadioButton_pin();
			this.radioButton_pin12 = new ArduinoDrive.RadioButton_pin();
			this.panel29 = new System.Windows.Forms.Panel();
			this.radioButton_pin29 = new ArduinoDrive.RadioButton_pin();
			this.radioButton_pin30 = new ArduinoDrive.RadioButton_pin();
			this.label19 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.radioInputPullup_dummy = new ArduinoDrive.RadioButton_pin();
			this.radioInput_dummy = new ArduinoDrive.RadioButton_pin();
			this.radioOutput_dummy = new ArduinoDrive.RadioButton_pin();
			this.panel19 = new System.Windows.Forms.Panel();
			this.radioDigital_dummy = new ArduinoDrive.RadioButton_pin();
			this.radioAnalog_dummy = new ArduinoDrive.RadioButton_pin();
			this.panel26 = new System.Windows.Forms.Panel();
			this.labelValue_dummy = new ArduinoDrive.Label_pin();
			this.trackBar_dummy = new ArduinoDrive.TrackBar_pin();
			this.panel11.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_6)).BeginInit();
			this.panel15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_9)).BeginInit();
			this.panel17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_10)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_11)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_5)).BeginInit();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_3)).BeginInit();
			this.panel38.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_19)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel20.SuspendLayout();
			this.panel21.SuspendLayout();
			this.panel22.SuspendLayout();
			this.panel23.SuspendLayout();
			this.panel24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_8)).BeginInit();
			this.panel18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_4)).BeginInit();
			this.panel25.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_7)).BeginInit();
			this.panel28.SuspendLayout();
			this.panel16.SuspendLayout();
			this.panel33.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_18)).BeginInit();
			this.panel36.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_15)).BeginInit();
			this.panel37.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_14)).BeginInit();
			this.panel39.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_12)).BeginInit();
			this.panel40.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_13)).BeginInit();
			this.panel42.SuspendLayout();
			this.panel43.SuspendLayout();
			this.panel44.SuspendLayout();
			this.panel45.SuspendLayout();
			this.panel46.SuspendLayout();
			this.panel47.SuspendLayout();
			this.panel48.SuspendLayout();
			this.panel49.SuspendLayout();
			this.panel50.SuspendLayout();
			this.panel51.SuspendLayout();
			this.panel52.SuspendLayout();
			this.panel53.SuspendLayout();
			this.panel54.SuspendLayout();
			this.panel55.SuspendLayout();
			this.panel56.SuspendLayout();
			this.panel57.SuspendLayout();
			this.panel58.SuspendLayout();
			this.panel59.SuspendLayout();
			this.panel60.SuspendLayout();
			this.panel61.SuspendLayout();
			this.panel62.SuspendLayout();
			this.panel63.SuspendLayout();
			this.panel64.SuspendLayout();
			this.panel66.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_2)).BeginInit();
			this.panel35.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_17)).BeginInit();
			this.panel34.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_16)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panel29.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel19.SuspendLayout();
			this.panel26.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_dummy)).BeginInit();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM20";
			this.serialPort1.ReadTimeout = 100;
			this.serialPort1.WriteTimeout = 100;
			// 
			// panel4
			// 
			this.panel4.AutoSize = true;
			this.panel4.Location = new System.Drawing.Point(233, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(0, 0);
			this.panel4.TabIndex = 3;
			// 
			// panel11
			// 
			this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel11.AutoSize = true;
			this.panel11.Controls.Add(this.radioDigital_2);
			this.panel11.Controls.Add(this.radioAnalog_2);
			this.panel11.Location = new System.Drawing.Point(233, 78);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(67, 44);
			this.panel11.TabIndex = 3;
			// 
			// radioDigital_2
			// 
			this.radioDigital_2.AutoSize = true;
			this.radioDigital_2.Checked = true;
			this.radioDigital_2.Enabled = false;
			this.radioDigital_2.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_2.Name = "radioDigital_2";
			this.radioDigital_2.PinNumber = ((byte)(2));
			this.radioDigital_2.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_2.TabIndex = 4;
			this.radioDigital_2.TabStop = true;
			this.radioDigital_2.Text = "デジタル";
			this.radioDigital_2.UseVisualStyleBackColor = true;
			this.radioDigital_2.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_2
			// 
			this.radioAnalog_2.AutoSize = true;
			this.radioAnalog_2.Enabled = false;
			this.radioAnalog_2.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_2.Name = "radioAnalog_2";
			this.radioAnalog_2.PinNumber = ((byte)(2));
			this.radioAnalog_2.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_2.TabIndex = 4;
			this.radioAnalog_2.Text = "アナログ";
			this.radioAnalog_2.UseVisualStyleBackColor = true;
			this.radioAnalog_2.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(37, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "4";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(37, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "3";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(32, 395);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "12";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.radioDigital_6);
			this.panel2.Controls.Add(this.radioAnalog_6);
			this.panel2.Location = new System.Drawing.Point(233, 382);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(67, 44);
			this.panel2.TabIndex = 3;
			// 
			// radioDigital_6
			// 
			this.radioDigital_6.AutoSize = true;
			this.radioDigital_6.Enabled = false;
			this.radioDigital_6.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_6.Name = "radioDigital_6";
			this.radioDigital_6.PinNumber = ((byte)(6));
			this.radioDigital_6.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_6.TabIndex = 4;
			this.radioDigital_6.Text = "デジタル";
			this.radioDigital_6.UseVisualStyleBackColor = true;
			this.radioDigital_6.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_6
			// 
			this.radioAnalog_6.AutoSize = true;
			this.radioAnalog_6.Checked = true;
			this.radioAnalog_6.Enabled = false;
			this.radioAnalog_6.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_6.Name = "radioAnalog_6";
			this.radioAnalog_6.PinNumber = ((byte)(6));
			this.radioAnalog_6.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_6.TabIndex = 4;
			this.radioAnalog_6.TabStop = true;
			this.radioAnalog_6.Text = "アナログ";
			this.radioAnalog_6.UseVisualStyleBackColor = true;
			this.radioAnalog_6.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.radioInputPullup_6);
			this.panel1.Controls.Add(this.radioInput_6);
			this.panel1.Controls.Add(this.radioOutput_6);
			this.panel1.Location = new System.Drawing.Point(96, 371);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(109, 66);
			this.panel1.TabIndex = 3;
			// 
			// radioInputPullup_6
			// 
			this.radioInputPullup_6.AutoSize = true;
			this.radioInputPullup_6.Enabled = false;
			this.radioInputPullup_6.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_6.Name = "radioInputPullup_6";
			this.radioInputPullup_6.PinNumber = ((byte)(6));
			this.radioInputPullup_6.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_6.TabIndex = 5;
			this.radioInputPullup_6.TabStop = true;
			this.radioInputPullup_6.Text = "入力（プルアップ）";
			this.radioInputPullup_6.UseVisualStyleBackColor = true;
			this.radioInputPullup_6.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_6
			// 
			this.radioInput_6.AutoSize = true;
			this.radioInput_6.Enabled = false;
			this.radioInput_6.Location = new System.Drawing.Point(3, 25);
			this.radioInput_6.Name = "radioInput_6";
			this.radioInput_6.PinNumber = ((byte)(6));
			this.radioInput_6.Size = new System.Drawing.Size(47, 16);
			this.radioInput_6.TabIndex = 4;
			this.radioInput_6.Text = "入力";
			this.radioInput_6.UseVisualStyleBackColor = true;
			this.radioInput_6.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_6
			// 
			this.radioOutput_6.AutoSize = true;
			this.radioOutput_6.Checked = true;
			this.radioOutput_6.Enabled = false;
			this.radioOutput_6.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_6.Name = "radioOutput_6";
			this.radioOutput_6.PinNumber = ((byte)(6));
			this.radioOutput_6.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_6.TabIndex = 4;
			this.radioOutput_6.TabStop = true;
			this.radioOutput_6.Text = "出力";
			this.radioOutput_6.UseVisualStyleBackColor = true;
			this.radioOutput_6.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 788F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel11, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel13, 3, 6);
			this.tableLayoutPanel1.Controls.Add(this.panel15, 3, 9);
			this.tableLayoutPanel1.Controls.Add(this.panel17, 3, 10);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 11);
			this.tableLayoutPanel1.Controls.Add(this.panel9, 3, 5);
			this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel38, 3, 19);
			this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.panel12, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.panel20, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel21, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.panel22, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.panel23, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.panel24, 3, 8);
			this.tableLayoutPanel1.Controls.Add(this.panel18, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.panel25, 3, 7);
			this.tableLayoutPanel1.Controls.Add(this.panel28, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel16, 2, 8);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
			this.tableLayoutPanel1.Controls.Add(this.label14, 0, 13);
			this.tableLayoutPanel1.Controls.Add(this.label15, 0, 14);
			this.tableLayoutPanel1.Controls.Add(this.label16, 0, 15);
			this.tableLayoutPanel1.Controls.Add(this.label17, 0, 16);
			this.tableLayoutPanel1.Controls.Add(this.label18, 0, 17);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.label20, 0, 18);
			this.tableLayoutPanel1.Controls.Add(this.label21, 0, 19);
			this.tableLayoutPanel1.Controls.Add(this.panel33, 3, 18);
			this.tableLayoutPanel1.Controls.Add(this.panel36, 3, 15);
			this.tableLayoutPanel1.Controls.Add(this.panel37, 3, 14);
			this.tableLayoutPanel1.Controls.Add(this.panel39, 3, 12);
			this.tableLayoutPanel1.Controls.Add(this.panel40, 3, 13);
			this.tableLayoutPanel1.Controls.Add(this.panel42, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.panel43, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.panel44, 1, 10);
			this.tableLayoutPanel1.Controls.Add(this.panel45, 1, 11);
			this.tableLayoutPanel1.Controls.Add(this.panel46, 1, 12);
			this.tableLayoutPanel1.Controls.Add(this.panel47, 1, 13);
			this.tableLayoutPanel1.Controls.Add(this.panel48, 1, 14);
			this.tableLayoutPanel1.Controls.Add(this.panel49, 1, 16);
			this.tableLayoutPanel1.Controls.Add(this.panel50, 1, 17);
			this.tableLayoutPanel1.Controls.Add(this.panel51, 1, 15);
			this.tableLayoutPanel1.Controls.Add(this.panel52, 1, 18);
			this.tableLayoutPanel1.Controls.Add(this.panel53, 1, 19);
			this.tableLayoutPanel1.Controls.Add(this.panel54, 2, 9);
			this.tableLayoutPanel1.Controls.Add(this.panel55, 2, 10);
			this.tableLayoutPanel1.Controls.Add(this.panel56, 2, 11);
			this.tableLayoutPanel1.Controls.Add(this.panel57, 2, 12);
			this.tableLayoutPanel1.Controls.Add(this.panel58, 2, 13);
			this.tableLayoutPanel1.Controls.Add(this.panel59, 2, 14);
			this.tableLayoutPanel1.Controls.Add(this.panel60, 2, 15);
			this.tableLayoutPanel1.Controls.Add(this.panel61, 2, 16);
			this.tableLayoutPanel1.Controls.Add(this.panel62, 2, 17);
			this.tableLayoutPanel1.Controls.Add(this.panel63, 2, 18);
			this.tableLayoutPanel1.Controls.Add(this.panel64, 2, 19);
			this.tableLayoutPanel1.Controls.Add(this.panel66, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel35, 3, 17);
			this.tableLayoutPanel1.Controls.Add(this.panel34, 3, 16);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 20;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 1439);
			this.tableLayoutPanel1.TabIndex = 2;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// panel13
			// 
			this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel13.AutoSize = true;
			this.panel13.Controls.Add(this.labelValue_6);
			this.panel13.Controls.Add(this.trackBar_6);
			this.panel13.Location = new System.Drawing.Point(342, 370);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(364, 69);
			this.panel13.TabIndex = 8;
			// 
			// labelValue_6
			// 
			this.labelValue_6.Enabled = false;
			this.labelValue_6.Location = new System.Drawing.Point(3, 15);
			this.labelValue_6.Name = "labelValue_6";
			this.labelValue_6.PinNumber = ((byte)(6));
			this.labelValue_6.Size = new System.Drawing.Size(358, 16);
			this.labelValue_6.TabIndex = 7;
			this.labelValue_6.Text = "0.00V";
			this.labelValue_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_6
			// 
			this.trackBar_6.Enabled = false;
			this.trackBar_6.LargeChange = 1;
			this.trackBar_6.Location = new System.Drawing.Point(3, 30);
			this.trackBar_6.Maximum = 1023;
			this.trackBar_6.Name = "trackBar_6";
			this.trackBar_6.PinNumber = ((byte)(6));
			this.trackBar_6.Size = new System.Drawing.Size(358, 45);
			this.trackBar_6.TabIndex = 6;
			this.trackBar_6.TickFrequency = 16;
			this.trackBar_6.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel15
			// 
			this.panel15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel15.AutoSize = true;
			this.panel15.Controls.Add(this.labelValue_9);
			this.panel15.Controls.Add(this.trackBar_9);
			this.panel15.Location = new System.Drawing.Point(342, 598);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(364, 69);
			this.panel15.TabIndex = 8;
			// 
			// labelValue_9
			// 
			this.labelValue_9.Enabled = false;
			this.labelValue_9.Location = new System.Drawing.Point(3, 15);
			this.labelValue_9.Name = "labelValue_9";
			this.labelValue_9.PinNumber = ((byte)(9));
			this.labelValue_9.Size = new System.Drawing.Size(358, 16);
			this.labelValue_9.TabIndex = 7;
			this.labelValue_9.Text = "0.00V";
			this.labelValue_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_9
			// 
			this.trackBar_9.Enabled = false;
			this.trackBar_9.LargeChange = 1;
			this.trackBar_9.Location = new System.Drawing.Point(3, 30);
			this.trackBar_9.Maximum = 1023;
			this.trackBar_9.Name = "trackBar_9";
			this.trackBar_9.PinNumber = ((byte)(9));
			this.trackBar_9.Size = new System.Drawing.Size(358, 45);
			this.trackBar_9.TabIndex = 6;
			this.trackBar_9.TickFrequency = 16;
			this.trackBar_9.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel17
			// 
			this.panel17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel17.AutoSize = true;
			this.panel17.Controls.Add(this.labelValue_10);
			this.panel17.Controls.Add(this.trackBar_10);
			this.panel17.Location = new System.Drawing.Point(342, 674);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(364, 69);
			this.panel17.TabIndex = 8;
			// 
			// labelValue_10
			// 
			this.labelValue_10.Enabled = false;
			this.labelValue_10.Location = new System.Drawing.Point(3, 15);
			this.labelValue_10.Name = "labelValue_10";
			this.labelValue_10.PinNumber = ((byte)(10));
			this.labelValue_10.Size = new System.Drawing.Size(358, 16);
			this.labelValue_10.TabIndex = 7;
			this.labelValue_10.Text = "0.00V";
			this.labelValue_10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_10
			// 
			this.trackBar_10.Enabled = false;
			this.trackBar_10.LargeChange = 1;
			this.trackBar_10.Location = new System.Drawing.Point(3, 30);
			this.trackBar_10.Maximum = 1023;
			this.trackBar_10.Name = "trackBar_10";
			this.trackBar_10.PinNumber = ((byte)(10));
			this.trackBar_10.Size = new System.Drawing.Size(358, 45);
			this.trackBar_10.TabIndex = 6;
			this.trackBar_10.TickFrequency = 16;
			this.trackBar_10.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel5.AutoSize = true;
			this.panel5.Controls.Add(this.labelValue_11);
			this.panel5.Controls.Add(this.trackBar_11);
			this.panel5.Location = new System.Drawing.Point(342, 750);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(364, 69);
			this.panel5.TabIndex = 8;
			// 
			// labelValue_11
			// 
			this.labelValue_11.Enabled = false;
			this.labelValue_11.Location = new System.Drawing.Point(3, 15);
			this.labelValue_11.Name = "labelValue_11";
			this.labelValue_11.PinNumber = ((byte)(11));
			this.labelValue_11.Size = new System.Drawing.Size(358, 16);
			this.labelValue_11.TabIndex = 7;
			this.labelValue_11.Text = "0.00V";
			this.labelValue_11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_11
			// 
			this.trackBar_11.Enabled = false;
			this.trackBar_11.LargeChange = 1;
			this.trackBar_11.Location = new System.Drawing.Point(3, 30);
			this.trackBar_11.Maximum = 1023;
			this.trackBar_11.Name = "trackBar_11";
			this.trackBar_11.PinNumber = ((byte)(11));
			this.trackBar_11.Size = new System.Drawing.Size(358, 45);
			this.trackBar_11.TabIndex = 6;
			this.trackBar_11.TickFrequency = 16;
			this.trackBar_11.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel9
			// 
			this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel9.AutoSize = true;
			this.panel9.Controls.Add(this.labelValue_5);
			this.panel9.Controls.Add(this.trackBar_5);
			this.panel9.Location = new System.Drawing.Point(342, 294);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(364, 69);
			this.panel9.TabIndex = 8;
			// 
			// labelValue_5
			// 
			this.labelValue_5.Enabled = false;
			this.labelValue_5.Location = new System.Drawing.Point(3, 15);
			this.labelValue_5.Name = "labelValue_5";
			this.labelValue_5.PinNumber = ((byte)(5));
			this.labelValue_5.Size = new System.Drawing.Size(358, 16);
			this.labelValue_5.TabIndex = 7;
			this.labelValue_5.Text = "0.00V";
			this.labelValue_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_5
			// 
			this.trackBar_5.Enabled = false;
			this.trackBar_5.LargeChange = 1;
			this.trackBar_5.Location = new System.Drawing.Point(3, 30);
			this.trackBar_5.Maximum = 1023;
			this.trackBar_5.Name = "trackBar_5";
			this.trackBar_5.PinNumber = ((byte)(5));
			this.trackBar_5.Size = new System.Drawing.Size(358, 45);
			this.trackBar_5.TabIndex = 6;
			this.trackBar_5.TickFrequency = 16;
			this.trackBar_5.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel7
			// 
			this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel7.AutoSize = true;
			this.panel7.Controls.Add(this.labelValue_3);
			this.panel7.Controls.Add(this.trackBar_3);
			this.panel7.Location = new System.Drawing.Point(342, 142);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(364, 69);
			this.panel7.TabIndex = 8;
			// 
			// labelValue_3
			// 
			this.labelValue_3.Enabled = false;
			this.labelValue_3.Location = new System.Drawing.Point(3, 15);
			this.labelValue_3.Name = "labelValue_3";
			this.labelValue_3.PinNumber = ((byte)(3));
			this.labelValue_3.Size = new System.Drawing.Size(358, 16);
			this.labelValue_3.TabIndex = 7;
			this.labelValue_3.Text = "0.00V";
			this.labelValue_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_3
			// 
			this.trackBar_3.Enabled = false;
			this.trackBar_3.LargeChange = 1;
			this.trackBar_3.Location = new System.Drawing.Point(3, 30);
			this.trackBar_3.Maximum = 1023;
			this.trackBar_3.Name = "trackBar_3";
			this.trackBar_3.PinNumber = ((byte)(3));
			this.trackBar_3.Size = new System.Drawing.Size(358, 45);
			this.trackBar_3.TabIndex = 6;
			this.trackBar_3.TickFrequency = 16;
			this.trackBar_3.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel38
			// 
			this.panel38.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel38.AutoSize = true;
			this.panel38.Controls.Add(this.labelValue_19);
			this.panel38.Controls.Add(this.trackBar_19);
			this.panel38.Location = new System.Drawing.Point(342, 1358);
			this.panel38.Name = "panel38";
			this.panel38.Size = new System.Drawing.Size(364, 77);
			this.panel38.TabIndex = 8;
			// 
			// labelValue_19
			// 
			this.labelValue_19.Enabled = false;
			this.labelValue_19.Location = new System.Drawing.Point(3, 15);
			this.labelValue_19.Name = "labelValue_19";
			this.labelValue_19.PinNumber = ((byte)(19));
			this.labelValue_19.Size = new System.Drawing.Size(358, 16);
			this.labelValue_19.TabIndex = 7;
			this.labelValue_19.Text = "0.000V";
			this.labelValue_19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_19
			// 
			this.trackBar_19.Enabled = false;
			this.trackBar_19.LargeChange = 1;
			this.trackBar_19.Location = new System.Drawing.Point(3, 30);
			this.trackBar_19.Maximum = 1023;
			this.trackBar_19.Name = "trackBar_19";
			this.trackBar_19.PinNumber = ((byte)(19));
			this.trackBar_19.Size = new System.Drawing.Size(358, 45);
			this.trackBar_19.TabIndex = 6;
			this.trackBar_19.TickFrequency = 16;
			this.trackBar_19.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel6
			// 
			this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel6.AutoSize = true;
			this.panel6.Controls.Add(this.radioInputPullup_2);
			this.panel6.Controls.Add(this.radioInput_2);
			this.panel6.Controls.Add(this.radioOutput_2);
			this.panel6.Location = new System.Drawing.Point(96, 67);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(109, 66);
			this.panel6.TabIndex = 3;
			// 
			// radioInputPullup_2
			// 
			this.radioInputPullup_2.AutoSize = true;
			this.radioInputPullup_2.Enabled = false;
			this.radioInputPullup_2.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_2.Name = "radioInputPullup_2";
			this.radioInputPullup_2.PinNumber = ((byte)(2));
			this.radioInputPullup_2.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_2.TabIndex = 5;
			this.radioInputPullup_2.TabStop = true;
			this.radioInputPullup_2.Text = "入力（プルアップ）";
			this.radioInputPullup_2.UseVisualStyleBackColor = true;
			this.radioInputPullup_2.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_2
			// 
			this.radioInput_2.AutoSize = true;
			this.radioInput_2.Enabled = false;
			this.radioInput_2.Location = new System.Drawing.Point(3, 25);
			this.radioInput_2.Name = "radioInput_2";
			this.radioInput_2.PinNumber = ((byte)(2));
			this.radioInput_2.Size = new System.Drawing.Size(47, 16);
			this.radioInput_2.TabIndex = 4;
			this.radioInput_2.Text = "入力";
			this.radioInput_2.UseVisualStyleBackColor = true;
			this.radioInput_2.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_2
			// 
			this.radioOutput_2.AutoSize = true;
			this.radioOutput_2.Checked = true;
			this.radioOutput_2.Enabled = false;
			this.radioOutput_2.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_2.Name = "radioOutput_2";
			this.radioOutput_2.PinNumber = ((byte)(2));
			this.radioOutput_2.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_2.TabIndex = 4;
			this.radioOutput_2.TabStop = true;
			this.radioOutput_2.Text = "出力";
			this.radioOutput_2.UseVisualStyleBackColor = true;
			this.radioOutput_2.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(37, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "5";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel8
			// 
			this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel8.AutoSize = true;
			this.panel8.Controls.Add(this.radioInputPullup_3);
			this.panel8.Controls.Add(this.radioInput_3);
			this.panel8.Controls.Add(this.radioOutput_3);
			this.panel8.Location = new System.Drawing.Point(96, 143);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(109, 66);
			this.panel8.TabIndex = 3;
			// 
			// radioInputPullup_3
			// 
			this.radioInputPullup_3.AutoSize = true;
			this.radioInputPullup_3.Enabled = false;
			this.radioInputPullup_3.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_3.Name = "radioInputPullup_3";
			this.radioInputPullup_3.PinNumber = ((byte)(3));
			this.radioInputPullup_3.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_3.TabIndex = 5;
			this.radioInputPullup_3.TabStop = true;
			this.radioInputPullup_3.Text = "入力（プルアップ）";
			this.radioInputPullup_3.UseVisualStyleBackColor = true;
			this.radioInputPullup_3.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_3
			// 
			this.radioInput_3.AutoSize = true;
			this.radioInput_3.Enabled = false;
			this.radioInput_3.Location = new System.Drawing.Point(3, 25);
			this.radioInput_3.Name = "radioInput_3";
			this.radioInput_3.PinNumber = ((byte)(3));
			this.radioInput_3.Size = new System.Drawing.Size(47, 16);
			this.radioInput_3.TabIndex = 4;
			this.radioInput_3.Text = "入力";
			this.radioInput_3.UseVisualStyleBackColor = true;
			this.radioInput_3.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_3
			// 
			this.radioOutput_3.AutoSize = true;
			this.radioOutput_3.Checked = true;
			this.radioOutput_3.Enabled = false;
			this.radioOutput_3.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_3.Name = "radioOutput_3";
			this.radioOutput_3.PinNumber = ((byte)(3));
			this.radioOutput_3.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_3.TabIndex = 4;
			this.radioOutput_3.TabStop = true;
			this.radioOutput_3.Text = "出力";
			this.radioOutput_3.UseVisualStyleBackColor = true;
			this.radioOutput_3.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel10
			// 
			this.panel10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel10.AutoSize = true;
			this.panel10.Controls.Add(this.radioInputPullup_4);
			this.panel10.Controls.Add(this.radioInput_4);
			this.panel10.Controls.Add(this.radioOutput_4);
			this.panel10.Location = new System.Drawing.Point(96, 219);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(109, 66);
			this.panel10.TabIndex = 3;
			// 
			// radioInputPullup_4
			// 
			this.radioInputPullup_4.AutoSize = true;
			this.radioInputPullup_4.Enabled = false;
			this.radioInputPullup_4.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_4.Name = "radioInputPullup_4";
			this.radioInputPullup_4.PinNumber = ((byte)(4));
			this.radioInputPullup_4.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_4.TabIndex = 5;
			this.radioInputPullup_4.TabStop = true;
			this.radioInputPullup_4.Text = "入力（プルアップ）";
			this.radioInputPullup_4.UseVisualStyleBackColor = true;
			this.radioInputPullup_4.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_4
			// 
			this.radioInput_4.AutoSize = true;
			this.radioInput_4.Enabled = false;
			this.radioInput_4.Location = new System.Drawing.Point(3, 25);
			this.radioInput_4.Name = "radioInput_4";
			this.radioInput_4.PinNumber = ((byte)(4));
			this.radioInput_4.Size = new System.Drawing.Size(47, 16);
			this.radioInput_4.TabIndex = 4;
			this.radioInput_4.Text = "入力";
			this.radioInput_4.UseVisualStyleBackColor = true;
			this.radioInput_4.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_4
			// 
			this.radioOutput_4.AutoSize = true;
			this.radioOutput_4.Checked = true;
			this.radioOutput_4.Enabled = false;
			this.radioOutput_4.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_4.Name = "radioOutput_4";
			this.radioOutput_4.PinNumber = ((byte)(4));
			this.radioOutput_4.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_4.TabIndex = 4;
			this.radioOutput_4.TabStop = true;
			this.radioOutput_4.Text = "出力";
			this.radioOutput_4.UseVisualStyleBackColor = true;
			this.radioOutput_4.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel12
			// 
			this.panel12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel12.AutoSize = true;
			this.panel12.Controls.Add(this.radioInputPullup_5);
			this.panel12.Controls.Add(this.radioInput_5);
			this.panel12.Controls.Add(this.radioOutput_5);
			this.panel12.Location = new System.Drawing.Point(96, 295);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(109, 66);
			this.panel12.TabIndex = 3;
			// 
			// radioInputPullup_5
			// 
			this.radioInputPullup_5.AutoSize = true;
			this.radioInputPullup_5.Enabled = false;
			this.radioInputPullup_5.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_5.Name = "radioInputPullup_5";
			this.radioInputPullup_5.PinNumber = ((byte)(5));
			this.radioInputPullup_5.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_5.TabIndex = 5;
			this.radioInputPullup_5.TabStop = true;
			this.radioInputPullup_5.Text = "入力（プルアップ）";
			this.radioInputPullup_5.UseVisualStyleBackColor = true;
			this.radioInputPullup_5.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_5
			// 
			this.radioInput_5.AutoSize = true;
			this.radioInput_5.Enabled = false;
			this.radioInput_5.Location = new System.Drawing.Point(3, 25);
			this.radioInput_5.Name = "radioInput_5";
			this.radioInput_5.PinNumber = ((byte)(5));
			this.radioInput_5.Size = new System.Drawing.Size(47, 16);
			this.radioInput_5.TabIndex = 4;
			this.radioInput_5.Text = "入力";
			this.radioInput_5.UseVisualStyleBackColor = true;
			this.radioInput_5.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_5
			// 
			this.radioOutput_5.AutoSize = true;
			this.radioOutput_5.Checked = true;
			this.radioOutput_5.Enabled = false;
			this.radioOutput_5.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_5.Name = "radioOutput_5";
			this.radioOutput_5.PinNumber = ((byte)(5));
			this.radioOutput_5.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_5.TabIndex = 4;
			this.radioOutput_5.TabStop = true;
			this.radioOutput_5.Text = "出力";
			this.radioOutput_5.UseVisualStyleBackColor = true;
			this.radioOutput_5.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel20
			// 
			this.panel20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel20.AutoSize = true;
			this.panel20.Controls.Add(this.radioDigital_3);
			this.panel20.Controls.Add(this.radioAnalog_3);
			this.panel20.Location = new System.Drawing.Point(233, 154);
			this.panel20.Name = "panel20";
			this.panel20.Size = new System.Drawing.Size(67, 44);
			this.panel20.TabIndex = 3;
			// 
			// radioDigital_3
			// 
			this.radioDigital_3.AutoSize = true;
			this.radioDigital_3.Enabled = false;
			this.radioDigital_3.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_3.Name = "radioDigital_3";
			this.radioDigital_3.PinNumber = ((byte)(3));
			this.radioDigital_3.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_3.TabIndex = 4;
			this.radioDigital_3.Text = "デジタル";
			this.radioDigital_3.UseVisualStyleBackColor = true;
			this.radioDigital_3.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_3
			// 
			this.radioAnalog_3.AutoSize = true;
			this.radioAnalog_3.Checked = true;
			this.radioAnalog_3.Enabled = false;
			this.radioAnalog_3.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_3.Name = "radioAnalog_3";
			this.radioAnalog_3.PinNumber = ((byte)(3));
			this.radioAnalog_3.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_3.TabIndex = 4;
			this.radioAnalog_3.TabStop = true;
			this.radioAnalog_3.Text = "アナログ";
			this.radioAnalog_3.UseVisualStyleBackColor = true;
			this.radioAnalog_3.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel21
			// 
			this.panel21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel21.AutoSize = true;
			this.panel21.Controls.Add(this.radioDigital_4);
			this.panel21.Controls.Add(this.radioAnalog_4);
			this.panel21.Location = new System.Drawing.Point(233, 230);
			this.panel21.Name = "panel21";
			this.panel21.Size = new System.Drawing.Size(67, 44);
			this.panel21.TabIndex = 3;
			// 
			// radioDigital_4
			// 
			this.radioDigital_4.AutoSize = true;
			this.radioDigital_4.Checked = true;
			this.radioDigital_4.Enabled = false;
			this.radioDigital_4.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_4.Name = "radioDigital_4";
			this.radioDigital_4.PinNumber = ((byte)(4));
			this.radioDigital_4.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_4.TabIndex = 4;
			this.radioDigital_4.TabStop = true;
			this.radioDigital_4.Text = "デジタル";
			this.radioDigital_4.UseVisualStyleBackColor = true;
			this.radioDigital_4.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_4
			// 
			this.radioAnalog_4.AutoSize = true;
			this.radioAnalog_4.Enabled = false;
			this.radioAnalog_4.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_4.Name = "radioAnalog_4";
			this.radioAnalog_4.PinNumber = ((byte)(4));
			this.radioAnalog_4.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_4.TabIndex = 4;
			this.radioAnalog_4.Text = "アナログ";
			this.radioAnalog_4.UseVisualStyleBackColor = true;
			this.radioAnalog_4.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel22
			// 
			this.panel22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel22.AutoSize = true;
			this.panel22.Controls.Add(this.radioDigital_5);
			this.panel22.Controls.Add(this.radioAnalog_5);
			this.panel22.Location = new System.Drawing.Point(233, 306);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(67, 44);
			this.panel22.TabIndex = 3;
			// 
			// radioDigital_5
			// 
			this.radioDigital_5.AutoSize = true;
			this.radioDigital_5.Enabled = false;
			this.radioDigital_5.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_5.Name = "radioDigital_5";
			this.radioDigital_5.PinNumber = ((byte)(5));
			this.radioDigital_5.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_5.TabIndex = 4;
			this.radioDigital_5.Text = "デジタル";
			this.radioDigital_5.UseVisualStyleBackColor = true;
			this.radioDigital_5.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_5
			// 
			this.radioAnalog_5.AutoSize = true;
			this.radioAnalog_5.Checked = true;
			this.radioAnalog_5.Enabled = false;
			this.radioAnalog_5.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_5.Name = "radioAnalog_5";
			this.radioAnalog_5.PinNumber = ((byte)(5));
			this.radioAnalog_5.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_5.TabIndex = 4;
			this.radioAnalog_5.TabStop = true;
			this.radioAnalog_5.Text = "アナログ";
			this.radioAnalog_5.UseVisualStyleBackColor = true;
			this.radioAnalog_5.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel23
			// 
			this.panel23.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel23.AutoSize = true;
			this.panel23.Controls.Add(this.radioDigital_7);
			this.panel23.Controls.Add(this.radioAnalog_7);
			this.panel23.Location = new System.Drawing.Point(233, 458);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(67, 44);
			this.panel23.TabIndex = 3;
			// 
			// radioDigital_7
			// 
			this.radioDigital_7.AutoSize = true;
			this.radioDigital_7.Checked = true;
			this.radioDigital_7.Enabled = false;
			this.radioDigital_7.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_7.Name = "radioDigital_7";
			this.radioDigital_7.PinNumber = ((byte)(7));
			this.radioDigital_7.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_7.TabIndex = 4;
			this.radioDigital_7.TabStop = true;
			this.radioDigital_7.Text = "デジタル";
			this.radioDigital_7.UseVisualStyleBackColor = true;
			this.radioDigital_7.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_7
			// 
			this.radioAnalog_7.AutoSize = true;
			this.radioAnalog_7.Enabled = false;
			this.radioAnalog_7.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_7.Name = "radioAnalog_7";
			this.radioAnalog_7.PinNumber = ((byte)(7));
			this.radioAnalog_7.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_7.TabIndex = 4;
			this.radioAnalog_7.Text = "アナログ";
			this.radioAnalog_7.UseVisualStyleBackColor = true;
			this.radioAnalog_7.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel24
			// 
			this.panel24.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel24.AutoSize = true;
			this.panel24.Controls.Add(this.labelValue_8);
			this.panel24.Controls.Add(this.trackBar_8);
			this.panel24.Location = new System.Drawing.Point(342, 522);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(364, 69);
			this.panel24.TabIndex = 8;
			// 
			// labelValue_8
			// 
			this.labelValue_8.Enabled = false;
			this.labelValue_8.Location = new System.Drawing.Point(3, 15);
			this.labelValue_8.Name = "labelValue_8";
			this.labelValue_8.PinNumber = ((byte)(8));
			this.labelValue_8.Size = new System.Drawing.Size(358, 16);
			this.labelValue_8.TabIndex = 7;
			this.labelValue_8.Text = "LOW";
			this.labelValue_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_8
			// 
			this.trackBar_8.Enabled = false;
			this.trackBar_8.LargeChange = 1;
			this.trackBar_8.Location = new System.Drawing.Point(3, 30);
			this.trackBar_8.Maximum = 1;
			this.trackBar_8.Name = "trackBar_8";
			this.trackBar_8.PinNumber = ((byte)(8));
			this.trackBar_8.Size = new System.Drawing.Size(358, 45);
			this.trackBar_8.TabIndex = 6;
			this.trackBar_8.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel18
			// 
			this.panel18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel18.AutoSize = true;
			this.panel18.Controls.Add(this.labelValue_4);
			this.panel18.Controls.Add(this.trackBar_4);
			this.panel18.Location = new System.Drawing.Point(342, 218);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(364, 69);
			this.panel18.TabIndex = 8;
			// 
			// labelValue_4
			// 
			this.labelValue_4.Enabled = false;
			this.labelValue_4.Location = new System.Drawing.Point(3, 15);
			this.labelValue_4.Name = "labelValue_4";
			this.labelValue_4.PinNumber = ((byte)(4));
			this.labelValue_4.Size = new System.Drawing.Size(358, 16);
			this.labelValue_4.TabIndex = 7;
			this.labelValue_4.Text = "LOW";
			this.labelValue_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_4
			// 
			this.trackBar_4.Enabled = false;
			this.trackBar_4.LargeChange = 1;
			this.trackBar_4.Location = new System.Drawing.Point(3, 30);
			this.trackBar_4.Maximum = 1;
			this.trackBar_4.Name = "trackBar_4";
			this.trackBar_4.PinNumber = ((byte)(4));
			this.trackBar_4.Size = new System.Drawing.Size(358, 45);
			this.trackBar_4.TabIndex = 6;
			this.trackBar_4.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel25
			// 
			this.panel25.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel25.AutoSize = true;
			this.panel25.Controls.Add(this.labelValue_7);
			this.panel25.Controls.Add(this.trackBar_7);
			this.panel25.Location = new System.Drawing.Point(342, 446);
			this.panel25.Name = "panel25";
			this.panel25.Size = new System.Drawing.Size(364, 69);
			this.panel25.TabIndex = 8;
			// 
			// labelValue_7
			// 
			this.labelValue_7.Enabled = false;
			this.labelValue_7.Location = new System.Drawing.Point(3, 15);
			this.labelValue_7.Name = "labelValue_7";
			this.labelValue_7.PinNumber = ((byte)(7));
			this.labelValue_7.Size = new System.Drawing.Size(358, 16);
			this.labelValue_7.TabIndex = 7;
			this.labelValue_7.Text = "LOW";
			this.labelValue_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_7
			// 
			this.trackBar_7.Enabled = false;
			this.trackBar_7.LargeChange = 1;
			this.trackBar_7.Location = new System.Drawing.Point(3, 30);
			this.trackBar_7.Maximum = 1;
			this.trackBar_7.Name = "trackBar_7";
			this.trackBar_7.PinNumber = ((byte)(7));
			this.trackBar_7.Size = new System.Drawing.Size(358, 45);
			this.trackBar_7.TabIndex = 6;
			this.trackBar_7.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel28
			// 
			this.panel28.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel28.AutoSize = true;
			this.panel28.Controls.Add(this.radioInputPullup_7);
			this.panel28.Controls.Add(this.radioInput_7);
			this.panel28.Controls.Add(this.radioOutput_7);
			this.panel28.Location = new System.Drawing.Point(96, 447);
			this.panel28.Name = "panel28";
			this.panel28.Size = new System.Drawing.Size(109, 66);
			this.panel28.TabIndex = 3;
			// 
			// radioInputPullup_7
			// 
			this.radioInputPullup_7.AutoSize = true;
			this.radioInputPullup_7.Enabled = false;
			this.radioInputPullup_7.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_7.Name = "radioInputPullup_7";
			this.radioInputPullup_7.PinNumber = ((byte)(7));
			this.radioInputPullup_7.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_7.TabIndex = 5;
			this.radioInputPullup_7.TabStop = true;
			this.radioInputPullup_7.Text = "入力（プルアップ）";
			this.radioInputPullup_7.UseVisualStyleBackColor = true;
			this.radioInputPullup_7.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_7
			// 
			this.radioInput_7.AutoSize = true;
			this.radioInput_7.Enabled = false;
			this.radioInput_7.Location = new System.Drawing.Point(3, 25);
			this.radioInput_7.Name = "radioInput_7";
			this.radioInput_7.PinNumber = ((byte)(7));
			this.radioInput_7.Size = new System.Drawing.Size(47, 16);
			this.radioInput_7.TabIndex = 4;
			this.radioInput_7.Text = "入力";
			this.radioInput_7.UseVisualStyleBackColor = true;
			this.radioInput_7.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_7
			// 
			this.radioOutput_7.AutoSize = true;
			this.radioOutput_7.Checked = true;
			this.radioOutput_7.Enabled = false;
			this.radioOutput_7.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_7.Name = "radioOutput_7";
			this.radioOutput_7.PinNumber = ((byte)(7));
			this.radioOutput_7.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_7.TabIndex = 4;
			this.radioOutput_7.TabStop = true;
			this.radioOutput_7.Text = "出力";
			this.radioOutput_7.UseVisualStyleBackColor = true;
			this.radioOutput_7.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel16
			// 
			this.panel16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel16.AutoSize = true;
			this.panel16.Controls.Add(this.radioDigital_8);
			this.panel16.Controls.Add(this.radioAnalog_8);
			this.panel16.Location = new System.Drawing.Point(233, 534);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(67, 44);
			this.panel16.TabIndex = 3;
			// 
			// radioDigital_8
			// 
			this.radioDigital_8.AutoSize = true;
			this.radioDigital_8.Checked = true;
			this.radioDigital_8.Enabled = false;
			this.radioDigital_8.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_8.Name = "radioDigital_8";
			this.radioDigital_8.PinNumber = ((byte)(8));
			this.radioDigital_8.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_8.TabIndex = 4;
			this.radioDigital_8.TabStop = true;
			this.radioDigital_8.Text = "デジタル";
			this.radioDigital_8.UseVisualStyleBackColor = true;
			this.radioDigital_8.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_8
			// 
			this.radioAnalog_8.AutoSize = true;
			this.radioAnalog_8.Enabled = false;
			this.radioAnalog_8.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_8.Name = "radioAnalog_8";
			this.radioAnalog_8.PinNumber = ((byte)(8));
			this.radioAnalog_8.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_8.TabIndex = 4;
			this.radioAnalog_8.Text = "アナログ";
			this.radioAnalog_8.UseVisualStyleBackColor = true;
			this.radioAnalog_8.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(37, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 19);
			this.label6.TabIndex = 3;
			this.label6.Text = "2";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(37, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(19, 19);
			this.label7.TabIndex = 3;
			this.label7.Text = "6";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(32, 319);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 19);
			this.label8.TabIndex = 3;
			this.label8.Text = "11";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(32, 547);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 19);
			this.label5.TabIndex = 3;
			this.label5.Text = "14";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.Location = new System.Drawing.Point(32, 471);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 19);
			this.label9.TabIndex = 3;
			this.label9.Text = "13";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label12.Location = new System.Drawing.Point(32, 775);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 19);
			this.label12.TabIndex = 3;
			this.label12.Text = "17";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label12.Click += new System.EventHandler(this.label5_Click);
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label13.Location = new System.Drawing.Point(32, 851);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(29, 19);
			this.label13.TabIndex = 3;
			this.label13.Text = "18";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label13.Click += new System.EventHandler(this.label5_Click);
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label14.Location = new System.Drawing.Point(32, 927);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 19);
			this.label14.TabIndex = 3;
			this.label14.Text = "19";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label14.Click += new System.EventHandler(this.label5_Click);
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label15.Location = new System.Drawing.Point(32, 1003);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(29, 19);
			this.label15.TabIndex = 3;
			this.label15.Text = "23";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label15.Click += new System.EventHandler(this.label5_Click);
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label16.Location = new System.Drawing.Point(32, 1079);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(29, 19);
			this.label16.TabIndex = 3;
			this.label16.Text = "24";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label16.Click += new System.EventHandler(this.label5_Click);
			// 
			// label17
			// 
			this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label17.Location = new System.Drawing.Point(32, 1155);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(29, 19);
			this.label17.TabIndex = 3;
			this.label17.Text = "25";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label17.Click += new System.EventHandler(this.label5_Click);
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label18.Location = new System.Drawing.Point(32, 1231);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(29, 19);
			this.label18.TabIndex = 3;
			this.label18.Text = "26";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label18.Click += new System.EventHandler(this.label5_Click);
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.Location = new System.Drawing.Point(32, 699);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 19);
			this.label10.TabIndex = 3;
			this.label10.Text = "16";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label10.Click += new System.EventHandler(this.label5_Click);
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label11.Location = new System.Drawing.Point(32, 623);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 19);
			this.label11.TabIndex = 3;
			this.label11.Text = "15";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label11.Click += new System.EventHandler(this.label5_Click);
			// 
			// label20
			// 
			this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label20.Location = new System.Drawing.Point(32, 1307);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(29, 19);
			this.label20.TabIndex = 3;
			this.label20.Text = "27";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label20.Click += new System.EventHandler(this.label5_Click);
			// 
			// label21
			// 
			this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label21.Location = new System.Drawing.Point(32, 1387);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(29, 19);
			this.label21.TabIndex = 3;
			this.label21.Text = "28";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label21.Click += new System.EventHandler(this.label5_Click);
			// 
			// panel33
			// 
			this.panel33.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel33.AutoSize = true;
			this.panel33.Controls.Add(this.labelValue_18);
			this.panel33.Controls.Add(this.trackBar_18);
			this.panel33.Location = new System.Drawing.Point(342, 1282);
			this.panel33.Name = "panel33";
			this.panel33.Size = new System.Drawing.Size(364, 69);
			this.panel33.TabIndex = 8;
			// 
			// labelValue_18
			// 
			this.labelValue_18.Enabled = false;
			this.labelValue_18.Location = new System.Drawing.Point(3, 15);
			this.labelValue_18.Name = "labelValue_18";
			this.labelValue_18.PinNumber = ((byte)(18));
			this.labelValue_18.Size = new System.Drawing.Size(358, 16);
			this.labelValue_18.TabIndex = 7;
			this.labelValue_18.Text = "0.000V";
			this.labelValue_18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_18
			// 
			this.trackBar_18.Enabled = false;
			this.trackBar_18.LargeChange = 1;
			this.trackBar_18.Location = new System.Drawing.Point(3, 30);
			this.trackBar_18.Maximum = 1023;
			this.trackBar_18.Name = "trackBar_18";
			this.trackBar_18.PinNumber = ((byte)(18));
			this.trackBar_18.Size = new System.Drawing.Size(358, 45);
			this.trackBar_18.TabIndex = 6;
			this.trackBar_18.TickFrequency = 16;
			this.trackBar_18.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel36
			// 
			this.panel36.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel36.AutoSize = true;
			this.panel36.Controls.Add(this.labelValue_15);
			this.panel36.Controls.Add(this.trackBar_15);
			this.panel36.Location = new System.Drawing.Point(342, 1054);
			this.panel36.Name = "panel36";
			this.panel36.Size = new System.Drawing.Size(364, 69);
			this.panel36.TabIndex = 8;
			// 
			// labelValue_15
			// 
			this.labelValue_15.Enabled = false;
			this.labelValue_15.Location = new System.Drawing.Point(3, 15);
			this.labelValue_15.Name = "labelValue_15";
			this.labelValue_15.PinNumber = ((byte)(15));
			this.labelValue_15.Size = new System.Drawing.Size(358, 16);
			this.labelValue_15.TabIndex = 7;
			this.labelValue_15.Text = "0.000V";
			this.labelValue_15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_15
			// 
			this.trackBar_15.Enabled = false;
			this.trackBar_15.LargeChange = 1;
			this.trackBar_15.Location = new System.Drawing.Point(3, 30);
			this.trackBar_15.Maximum = 1023;
			this.trackBar_15.Name = "trackBar_15";
			this.trackBar_15.PinNumber = ((byte)(15));
			this.trackBar_15.Size = new System.Drawing.Size(358, 45);
			this.trackBar_15.TabIndex = 6;
			this.trackBar_15.TickFrequency = 16;
			this.trackBar_15.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel37
			// 
			this.panel37.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel37.AutoSize = true;
			this.panel37.Controls.Add(this.labelValue_14);
			this.panel37.Controls.Add(this.trackBar_14);
			this.panel37.Location = new System.Drawing.Point(342, 978);
			this.panel37.Name = "panel37";
			this.panel37.Size = new System.Drawing.Size(364, 69);
			this.panel37.TabIndex = 8;
			// 
			// labelValue_14
			// 
			this.labelValue_14.Enabled = false;
			this.labelValue_14.Location = new System.Drawing.Point(3, 15);
			this.labelValue_14.Name = "labelValue_14";
			this.labelValue_14.PinNumber = ((byte)(14));
			this.labelValue_14.Size = new System.Drawing.Size(358, 16);
			this.labelValue_14.TabIndex = 7;
			this.labelValue_14.Text = "0.000V";
			this.labelValue_14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_14
			// 
			this.trackBar_14.Enabled = false;
			this.trackBar_14.LargeChange = 1;
			this.trackBar_14.Location = new System.Drawing.Point(3, 30);
			this.trackBar_14.Maximum = 1023;
			this.trackBar_14.Name = "trackBar_14";
			this.trackBar_14.PinNumber = ((byte)(14));
			this.trackBar_14.Size = new System.Drawing.Size(358, 45);
			this.trackBar_14.TabIndex = 6;
			this.trackBar_14.TickFrequency = 16;
			this.trackBar_14.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel39
			// 
			this.panel39.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel39.AutoSize = true;
			this.panel39.Controls.Add(this.labelValue_12);
			this.panel39.Controls.Add(this.trackBar_12);
			this.panel39.Location = new System.Drawing.Point(342, 826);
			this.panel39.Name = "panel39";
			this.panel39.Size = new System.Drawing.Size(364, 69);
			this.panel39.TabIndex = 8;
			// 
			// labelValue_12
			// 
			this.labelValue_12.Enabled = false;
			this.labelValue_12.Location = new System.Drawing.Point(3, 15);
			this.labelValue_12.Name = "labelValue_12";
			this.labelValue_12.PinNumber = ((byte)(12));
			this.labelValue_12.Size = new System.Drawing.Size(358, 16);
			this.labelValue_12.TabIndex = 7;
			this.labelValue_12.Text = "LOW";
			this.labelValue_12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_12
			// 
			this.trackBar_12.Enabled = false;
			this.trackBar_12.LargeChange = 1;
			this.trackBar_12.Location = new System.Drawing.Point(3, 30);
			this.trackBar_12.Maximum = 1;
			this.trackBar_12.Name = "trackBar_12";
			this.trackBar_12.PinNumber = ((byte)(12));
			this.trackBar_12.Size = new System.Drawing.Size(358, 45);
			this.trackBar_12.TabIndex = 6;
			this.trackBar_12.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel40
			// 
			this.panel40.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel40.AutoSize = true;
			this.panel40.Controls.Add(this.labelValue_13);
			this.panel40.Controls.Add(this.trackBar_13);
			this.panel40.Location = new System.Drawing.Point(342, 902);
			this.panel40.Name = "panel40";
			this.panel40.Size = new System.Drawing.Size(364, 69);
			this.panel40.TabIndex = 8;
			// 
			// labelValue_13
			// 
			this.labelValue_13.Enabled = false;
			this.labelValue_13.Location = new System.Drawing.Point(3, 15);
			this.labelValue_13.Name = "labelValue_13";
			this.labelValue_13.PinNumber = ((byte)(13));
			this.labelValue_13.Size = new System.Drawing.Size(358, 16);
			this.labelValue_13.TabIndex = 7;
			this.labelValue_13.Text = "LOW";
			this.labelValue_13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_13
			// 
			this.trackBar_13.Enabled = false;
			this.trackBar_13.LargeChange = 1;
			this.trackBar_13.Location = new System.Drawing.Point(3, 30);
			this.trackBar_13.Maximum = 1;
			this.trackBar_13.Name = "trackBar_13";
			this.trackBar_13.PinNumber = ((byte)(13));
			this.trackBar_13.Size = new System.Drawing.Size(358, 45);
			this.trackBar_13.TabIndex = 6;
			this.trackBar_13.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel42
			// 
			this.panel42.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel42.AutoSize = true;
			this.panel42.Controls.Add(this.radioInputPullup_8);
			this.panel42.Controls.Add(this.radioInput_8);
			this.panel42.Controls.Add(this.radioOutput_8);
			this.panel42.Location = new System.Drawing.Point(96, 523);
			this.panel42.Name = "panel42";
			this.panel42.Size = new System.Drawing.Size(109, 66);
			this.panel42.TabIndex = 3;
			// 
			// radioInputPullup_8
			// 
			this.radioInputPullup_8.AutoSize = true;
			this.radioInputPullup_8.Enabled = false;
			this.radioInputPullup_8.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_8.Name = "radioInputPullup_8";
			this.radioInputPullup_8.PinNumber = ((byte)(8));
			this.radioInputPullup_8.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_8.TabIndex = 5;
			this.radioInputPullup_8.TabStop = true;
			this.radioInputPullup_8.Text = "入力（プルアップ）";
			this.radioInputPullup_8.UseVisualStyleBackColor = true;
			this.radioInputPullup_8.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_8
			// 
			this.radioInput_8.AutoSize = true;
			this.radioInput_8.Enabled = false;
			this.radioInput_8.Location = new System.Drawing.Point(3, 25);
			this.radioInput_8.Name = "radioInput_8";
			this.radioInput_8.PinNumber = ((byte)(8));
			this.radioInput_8.Size = new System.Drawing.Size(47, 16);
			this.radioInput_8.TabIndex = 4;
			this.radioInput_8.Text = "入力";
			this.radioInput_8.UseVisualStyleBackColor = true;
			this.radioInput_8.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_8
			// 
			this.radioOutput_8.AutoSize = true;
			this.radioOutput_8.Checked = true;
			this.radioOutput_8.Enabled = false;
			this.radioOutput_8.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_8.Name = "radioOutput_8";
			this.radioOutput_8.PinNumber = ((byte)(8));
			this.radioOutput_8.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_8.TabIndex = 4;
			this.radioOutput_8.TabStop = true;
			this.radioOutput_8.Text = "出力";
			this.radioOutput_8.UseVisualStyleBackColor = true;
			this.radioOutput_8.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel43
			// 
			this.panel43.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel43.AutoSize = true;
			this.panel43.Controls.Add(this.radioInputPullup_9);
			this.panel43.Controls.Add(this.radioInput_9);
			this.panel43.Controls.Add(this.radioOutput_9);
			this.panel43.Location = new System.Drawing.Point(96, 599);
			this.panel43.Name = "panel43";
			this.panel43.Size = new System.Drawing.Size(109, 66);
			this.panel43.TabIndex = 3;
			// 
			// radioInputPullup_9
			// 
			this.radioInputPullup_9.AutoSize = true;
			this.radioInputPullup_9.Enabled = false;
			this.radioInputPullup_9.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_9.Name = "radioInputPullup_9";
			this.radioInputPullup_9.PinNumber = ((byte)(9));
			this.radioInputPullup_9.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_9.TabIndex = 5;
			this.radioInputPullup_9.TabStop = true;
			this.radioInputPullup_9.Text = "入力（プルアップ）";
			this.radioInputPullup_9.UseVisualStyleBackColor = true;
			this.radioInputPullup_9.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_9
			// 
			this.radioInput_9.AutoSize = true;
			this.radioInput_9.Enabled = false;
			this.radioInput_9.Location = new System.Drawing.Point(3, 25);
			this.radioInput_9.Name = "radioInput_9";
			this.radioInput_9.PinNumber = ((byte)(9));
			this.radioInput_9.Size = new System.Drawing.Size(47, 16);
			this.radioInput_9.TabIndex = 4;
			this.radioInput_9.Text = "入力";
			this.radioInput_9.UseVisualStyleBackColor = true;
			this.radioInput_9.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_9
			// 
			this.radioOutput_9.AutoSize = true;
			this.radioOutput_9.Checked = true;
			this.radioOutput_9.Enabled = false;
			this.radioOutput_9.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_9.Name = "radioOutput_9";
			this.radioOutput_9.PinNumber = ((byte)(9));
			this.radioOutput_9.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_9.TabIndex = 4;
			this.radioOutput_9.TabStop = true;
			this.radioOutput_9.Text = "出力";
			this.radioOutput_9.UseVisualStyleBackColor = true;
			this.radioOutput_9.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel44
			// 
			this.panel44.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel44.AutoSize = true;
			this.panel44.Controls.Add(this.radioInputPullup_10);
			this.panel44.Controls.Add(this.radioInput_10);
			this.panel44.Controls.Add(this.radioOutput_10);
			this.panel44.Location = new System.Drawing.Point(96, 675);
			this.panel44.Name = "panel44";
			this.panel44.Size = new System.Drawing.Size(109, 66);
			this.panel44.TabIndex = 3;
			// 
			// radioInputPullup_10
			// 
			this.radioInputPullup_10.AutoSize = true;
			this.radioInputPullup_10.Enabled = false;
			this.radioInputPullup_10.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_10.Name = "radioInputPullup_10";
			this.radioInputPullup_10.PinNumber = ((byte)(10));
			this.radioInputPullup_10.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_10.TabIndex = 5;
			this.radioInputPullup_10.TabStop = true;
			this.radioInputPullup_10.Text = "入力（プルアップ）";
			this.radioInputPullup_10.UseVisualStyleBackColor = true;
			this.radioInputPullup_10.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_10
			// 
			this.radioInput_10.AutoSize = true;
			this.radioInput_10.Enabled = false;
			this.radioInput_10.Location = new System.Drawing.Point(3, 25);
			this.radioInput_10.Name = "radioInput_10";
			this.radioInput_10.PinNumber = ((byte)(10));
			this.radioInput_10.Size = new System.Drawing.Size(47, 16);
			this.radioInput_10.TabIndex = 4;
			this.radioInput_10.Text = "入力";
			this.radioInput_10.UseVisualStyleBackColor = true;
			this.radioInput_10.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_10
			// 
			this.radioOutput_10.AutoSize = true;
			this.radioOutput_10.Checked = true;
			this.radioOutput_10.Enabled = false;
			this.radioOutput_10.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_10.Name = "radioOutput_10";
			this.radioOutput_10.PinNumber = ((byte)(10));
			this.radioOutput_10.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_10.TabIndex = 4;
			this.radioOutput_10.TabStop = true;
			this.radioOutput_10.Text = "出力";
			this.radioOutput_10.UseVisualStyleBackColor = true;
			this.radioOutput_10.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel45
			// 
			this.panel45.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel45.AutoSize = true;
			this.panel45.Controls.Add(this.radioInputPullup_11);
			this.panel45.Controls.Add(this.radioInput_11);
			this.panel45.Controls.Add(this.radioOutput_11);
			this.panel45.Location = new System.Drawing.Point(96, 751);
			this.panel45.Name = "panel45";
			this.panel45.Size = new System.Drawing.Size(109, 66);
			this.panel45.TabIndex = 3;
			// 
			// radioInputPullup_11
			// 
			this.radioInputPullup_11.AutoSize = true;
			this.radioInputPullup_11.Enabled = false;
			this.radioInputPullup_11.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_11.Name = "radioInputPullup_11";
			this.radioInputPullup_11.PinNumber = ((byte)(11));
			this.radioInputPullup_11.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_11.TabIndex = 5;
			this.radioInputPullup_11.TabStop = true;
			this.radioInputPullup_11.Text = "入力（プルアップ）";
			this.radioInputPullup_11.UseVisualStyleBackColor = true;
			this.radioInputPullup_11.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_11
			// 
			this.radioInput_11.AutoSize = true;
			this.radioInput_11.Enabled = false;
			this.radioInput_11.Location = new System.Drawing.Point(3, 25);
			this.radioInput_11.Name = "radioInput_11";
			this.radioInput_11.PinNumber = ((byte)(11));
			this.radioInput_11.Size = new System.Drawing.Size(47, 16);
			this.radioInput_11.TabIndex = 4;
			this.radioInput_11.Text = "入力";
			this.radioInput_11.UseVisualStyleBackColor = true;
			this.radioInput_11.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_11
			// 
			this.radioOutput_11.AutoSize = true;
			this.radioOutput_11.Checked = true;
			this.radioOutput_11.Enabled = false;
			this.radioOutput_11.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_11.Name = "radioOutput_11";
			this.radioOutput_11.PinNumber = ((byte)(11));
			this.radioOutput_11.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_11.TabIndex = 4;
			this.radioOutput_11.TabStop = true;
			this.radioOutput_11.Text = "出力";
			this.radioOutput_11.UseVisualStyleBackColor = true;
			this.radioOutput_11.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel46
			// 
			this.panel46.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel46.AutoSize = true;
			this.panel46.Controls.Add(this.radioInputPullup_12);
			this.panel46.Controls.Add(this.radioInput_12);
			this.panel46.Controls.Add(this.radioOutput_12);
			this.panel46.Location = new System.Drawing.Point(96, 827);
			this.panel46.Name = "panel46";
			this.panel46.Size = new System.Drawing.Size(109, 66);
			this.panel46.TabIndex = 3;
			// 
			// radioInputPullup_12
			// 
			this.radioInputPullup_12.AutoSize = true;
			this.radioInputPullup_12.Enabled = false;
			this.radioInputPullup_12.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_12.Name = "radioInputPullup_12";
			this.radioInputPullup_12.PinNumber = ((byte)(12));
			this.radioInputPullup_12.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_12.TabIndex = 5;
			this.radioInputPullup_12.TabStop = true;
			this.radioInputPullup_12.Text = "入力（プルアップ）";
			this.radioInputPullup_12.UseVisualStyleBackColor = true;
			this.radioInputPullup_12.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_12
			// 
			this.radioInput_12.AutoSize = true;
			this.radioInput_12.Enabled = false;
			this.radioInput_12.Location = new System.Drawing.Point(3, 25);
			this.radioInput_12.Name = "radioInput_12";
			this.radioInput_12.PinNumber = ((byte)(12));
			this.radioInput_12.Size = new System.Drawing.Size(47, 16);
			this.radioInput_12.TabIndex = 4;
			this.radioInput_12.Text = "入力";
			this.radioInput_12.UseVisualStyleBackColor = true;
			this.radioInput_12.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_12
			// 
			this.radioOutput_12.AutoSize = true;
			this.radioOutput_12.Checked = true;
			this.radioOutput_12.Enabled = false;
			this.radioOutput_12.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_12.Name = "radioOutput_12";
			this.radioOutput_12.PinNumber = ((byte)(12));
			this.radioOutput_12.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_12.TabIndex = 4;
			this.radioOutput_12.TabStop = true;
			this.radioOutput_12.Text = "出力";
			this.radioOutput_12.UseVisualStyleBackColor = true;
			this.radioOutput_12.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel47
			// 
			this.panel47.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel47.AutoSize = true;
			this.panel47.Controls.Add(this.radioInputPullup_13);
			this.panel47.Controls.Add(this.radioInput_13);
			this.panel47.Controls.Add(this.radioOutput_13);
			this.panel47.Location = new System.Drawing.Point(96, 903);
			this.panel47.Name = "panel47";
			this.panel47.Size = new System.Drawing.Size(109, 66);
			this.panel47.TabIndex = 3;
			// 
			// radioInputPullup_13
			// 
			this.radioInputPullup_13.AutoSize = true;
			this.radioInputPullup_13.Enabled = false;
			this.radioInputPullup_13.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_13.Name = "radioInputPullup_13";
			this.radioInputPullup_13.PinNumber = ((byte)(13));
			this.radioInputPullup_13.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_13.TabIndex = 5;
			this.radioInputPullup_13.TabStop = true;
			this.radioInputPullup_13.Text = "入力（プルアップ）";
			this.radioInputPullup_13.UseVisualStyleBackColor = true;
			this.radioInputPullup_13.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_13
			// 
			this.radioInput_13.AutoSize = true;
			this.radioInput_13.Enabled = false;
			this.radioInput_13.Location = new System.Drawing.Point(3, 25);
			this.radioInput_13.Name = "radioInput_13";
			this.radioInput_13.PinNumber = ((byte)(13));
			this.radioInput_13.Size = new System.Drawing.Size(47, 16);
			this.radioInput_13.TabIndex = 4;
			this.radioInput_13.Text = "入力";
			this.radioInput_13.UseVisualStyleBackColor = true;
			this.radioInput_13.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_13
			// 
			this.radioOutput_13.AutoSize = true;
			this.radioOutput_13.Checked = true;
			this.radioOutput_13.Enabled = false;
			this.radioOutput_13.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_13.Name = "radioOutput_13";
			this.radioOutput_13.PinNumber = ((byte)(13));
			this.radioOutput_13.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_13.TabIndex = 4;
			this.radioOutput_13.TabStop = true;
			this.radioOutput_13.Text = "出力";
			this.radioOutput_13.UseVisualStyleBackColor = true;
			this.radioOutput_13.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel48
			// 
			this.panel48.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel48.AutoSize = true;
			this.panel48.Controls.Add(this.radioInputPullup_14);
			this.panel48.Controls.Add(this.radioInput_14);
			this.panel48.Controls.Add(this.radioOutput_14);
			this.panel48.Location = new System.Drawing.Point(96, 979);
			this.panel48.Name = "panel48";
			this.panel48.Size = new System.Drawing.Size(109, 66);
			this.panel48.TabIndex = 3;
			// 
			// radioInputPullup_14
			// 
			this.radioInputPullup_14.AutoSize = true;
			this.radioInputPullup_14.Enabled = false;
			this.radioInputPullup_14.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_14.Name = "radioInputPullup_14";
			this.radioInputPullup_14.PinNumber = ((byte)(14));
			this.radioInputPullup_14.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_14.TabIndex = 5;
			this.radioInputPullup_14.Text = "入力（プルアップ）";
			this.radioInputPullup_14.UseVisualStyleBackColor = true;
			this.radioInputPullup_14.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_14
			// 
			this.radioInput_14.AutoSize = true;
			this.radioInput_14.Checked = true;
			this.radioInput_14.Enabled = false;
			this.radioInput_14.Location = new System.Drawing.Point(3, 25);
			this.radioInput_14.Name = "radioInput_14";
			this.radioInput_14.PinNumber = ((byte)(14));
			this.radioInput_14.Size = new System.Drawing.Size(47, 16);
			this.radioInput_14.TabIndex = 4;
			this.radioInput_14.TabStop = true;
			this.radioInput_14.Text = "入力";
			this.radioInput_14.UseVisualStyleBackColor = true;
			this.radioInput_14.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_14
			// 
			this.radioOutput_14.AutoSize = true;
			this.radioOutput_14.Enabled = false;
			this.radioOutput_14.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_14.Name = "radioOutput_14";
			this.radioOutput_14.PinNumber = ((byte)(14));
			this.radioOutput_14.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_14.TabIndex = 4;
			this.radioOutput_14.Text = "出力";
			this.radioOutput_14.UseVisualStyleBackColor = true;
			this.radioOutput_14.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel49
			// 
			this.panel49.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel49.AutoSize = true;
			this.panel49.Controls.Add(this.radioInputPullup_16);
			this.panel49.Controls.Add(this.radioInput_16);
			this.panel49.Controls.Add(this.radioOutput_16);
			this.panel49.Location = new System.Drawing.Point(96, 1131);
			this.panel49.Name = "panel49";
			this.panel49.Size = new System.Drawing.Size(109, 66);
			this.panel49.TabIndex = 3;
			// 
			// radioInputPullup_16
			// 
			this.radioInputPullup_16.AutoSize = true;
			this.radioInputPullup_16.Enabled = false;
			this.radioInputPullup_16.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_16.Name = "radioInputPullup_16";
			this.radioInputPullup_16.PinNumber = ((byte)(16));
			this.radioInputPullup_16.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_16.TabIndex = 5;
			this.radioInputPullup_16.Text = "入力（プルアップ）";
			this.radioInputPullup_16.UseVisualStyleBackColor = true;
			this.radioInputPullup_16.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_16
			// 
			this.radioInput_16.AutoSize = true;
			this.radioInput_16.Checked = true;
			this.radioInput_16.Enabled = false;
			this.radioInput_16.Location = new System.Drawing.Point(3, 25);
			this.radioInput_16.Name = "radioInput_16";
			this.radioInput_16.PinNumber = ((byte)(16));
			this.radioInput_16.Size = new System.Drawing.Size(47, 16);
			this.radioInput_16.TabIndex = 4;
			this.radioInput_16.TabStop = true;
			this.radioInput_16.Text = "入力";
			this.radioInput_16.UseVisualStyleBackColor = true;
			this.radioInput_16.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_16
			// 
			this.radioOutput_16.AutoSize = true;
			this.radioOutput_16.Enabled = false;
			this.radioOutput_16.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_16.Name = "radioOutput_16";
			this.radioOutput_16.PinNumber = ((byte)(16));
			this.radioOutput_16.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_16.TabIndex = 4;
			this.radioOutput_16.Text = "出力";
			this.radioOutput_16.UseVisualStyleBackColor = true;
			this.radioOutput_16.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel50
			// 
			this.panel50.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel50.AutoSize = true;
			this.panel50.Controls.Add(this.radioInputPullup_17);
			this.panel50.Controls.Add(this.radioInput_17);
			this.panel50.Controls.Add(this.radioOutput_17);
			this.panel50.Location = new System.Drawing.Point(96, 1207);
			this.panel50.Name = "panel50";
			this.panel50.Size = new System.Drawing.Size(109, 66);
			this.panel50.TabIndex = 3;
			// 
			// radioInputPullup_17
			// 
			this.radioInputPullup_17.AutoSize = true;
			this.radioInputPullup_17.Enabled = false;
			this.radioInputPullup_17.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_17.Name = "radioInputPullup_17";
			this.radioInputPullup_17.PinNumber = ((byte)(17));
			this.radioInputPullup_17.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_17.TabIndex = 5;
			this.radioInputPullup_17.Text = "入力（プルアップ）";
			this.radioInputPullup_17.UseVisualStyleBackColor = true;
			this.radioInputPullup_17.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_17
			// 
			this.radioInput_17.AutoSize = true;
			this.radioInput_17.Checked = true;
			this.radioInput_17.Enabled = false;
			this.radioInput_17.Location = new System.Drawing.Point(3, 25);
			this.radioInput_17.Name = "radioInput_17";
			this.radioInput_17.PinNumber = ((byte)(17));
			this.radioInput_17.Size = new System.Drawing.Size(47, 16);
			this.radioInput_17.TabIndex = 4;
			this.radioInput_17.TabStop = true;
			this.radioInput_17.Text = "入力";
			this.radioInput_17.UseVisualStyleBackColor = true;
			this.radioInput_17.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_17
			// 
			this.radioOutput_17.AutoSize = true;
			this.radioOutput_17.Enabled = false;
			this.radioOutput_17.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_17.Name = "radioOutput_17";
			this.radioOutput_17.PinNumber = ((byte)(17));
			this.radioOutput_17.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_17.TabIndex = 4;
			this.radioOutput_17.Text = "出力";
			this.radioOutput_17.UseVisualStyleBackColor = true;
			this.radioOutput_17.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel51
			// 
			this.panel51.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel51.AutoSize = true;
			this.panel51.Controls.Add(this.radioInputPullup_15);
			this.panel51.Controls.Add(this.radioInput_15);
			this.panel51.Controls.Add(this.radioOutput_15);
			this.panel51.Location = new System.Drawing.Point(96, 1055);
			this.panel51.Name = "panel51";
			this.panel51.Size = new System.Drawing.Size(109, 66);
			this.panel51.TabIndex = 3;
			// 
			// radioInputPullup_15
			// 
			this.radioInputPullup_15.AutoSize = true;
			this.radioInputPullup_15.Enabled = false;
			this.radioInputPullup_15.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_15.Name = "radioInputPullup_15";
			this.radioInputPullup_15.PinNumber = ((byte)(15));
			this.radioInputPullup_15.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_15.TabIndex = 5;
			this.radioInputPullup_15.Text = "入力（プルアップ）";
			this.radioInputPullup_15.UseVisualStyleBackColor = true;
			this.radioInputPullup_15.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_15
			// 
			this.radioInput_15.AutoSize = true;
			this.radioInput_15.Checked = true;
			this.radioInput_15.Enabled = false;
			this.radioInput_15.Location = new System.Drawing.Point(3, 25);
			this.radioInput_15.Name = "radioInput_15";
			this.radioInput_15.PinNumber = ((byte)(15));
			this.radioInput_15.Size = new System.Drawing.Size(47, 16);
			this.radioInput_15.TabIndex = 4;
			this.radioInput_15.TabStop = true;
			this.radioInput_15.Text = "入力";
			this.radioInput_15.UseVisualStyleBackColor = true;
			this.radioInput_15.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_15
			// 
			this.radioOutput_15.AutoSize = true;
			this.radioOutput_15.Enabled = false;
			this.radioOutput_15.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_15.Name = "radioOutput_15";
			this.radioOutput_15.PinNumber = ((byte)(15));
			this.radioOutput_15.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_15.TabIndex = 4;
			this.radioOutput_15.Text = "出力";
			this.radioOutput_15.UseVisualStyleBackColor = true;
			this.radioOutput_15.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel52
			// 
			this.panel52.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel52.AutoSize = true;
			this.panel52.Controls.Add(this.radioInputPullup_18);
			this.panel52.Controls.Add(this.radioInput_18);
			this.panel52.Controls.Add(this.radioOutput_18);
			this.panel52.Location = new System.Drawing.Point(96, 1283);
			this.panel52.Name = "panel52";
			this.panel52.Size = new System.Drawing.Size(109, 66);
			this.panel52.TabIndex = 3;
			// 
			// radioInputPullup_18
			// 
			this.radioInputPullup_18.AutoSize = true;
			this.radioInputPullup_18.Enabled = false;
			this.radioInputPullup_18.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_18.Name = "radioInputPullup_18";
			this.radioInputPullup_18.PinNumber = ((byte)(18));
			this.radioInputPullup_18.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_18.TabIndex = 5;
			this.radioInputPullup_18.Text = "入力（プルアップ）";
			this.radioInputPullup_18.UseVisualStyleBackColor = true;
			this.radioInputPullup_18.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_18
			// 
			this.radioInput_18.AutoSize = true;
			this.radioInput_18.Checked = true;
			this.radioInput_18.Enabled = false;
			this.radioInput_18.Location = new System.Drawing.Point(3, 25);
			this.radioInput_18.Name = "radioInput_18";
			this.radioInput_18.PinNumber = ((byte)(18));
			this.radioInput_18.Size = new System.Drawing.Size(47, 16);
			this.radioInput_18.TabIndex = 4;
			this.radioInput_18.TabStop = true;
			this.radioInput_18.Text = "入力";
			this.radioInput_18.UseVisualStyleBackColor = true;
			this.radioInput_18.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_18
			// 
			this.radioOutput_18.AutoSize = true;
			this.radioOutput_18.Enabled = false;
			this.radioOutput_18.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_18.Name = "radioOutput_18";
			this.radioOutput_18.PinNumber = ((byte)(18));
			this.radioOutput_18.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_18.TabIndex = 4;
			this.radioOutput_18.Text = "出力";
			this.radioOutput_18.UseVisualStyleBackColor = true;
			this.radioOutput_18.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel53
			// 
			this.panel53.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel53.AutoSize = true;
			this.panel53.Controls.Add(this.radioInputPullup_19);
			this.panel53.Controls.Add(this.radioInput_19);
			this.panel53.Controls.Add(this.radioOutput_19);
			this.panel53.Location = new System.Drawing.Point(96, 1363);
			this.panel53.Name = "panel53";
			this.panel53.Size = new System.Drawing.Size(109, 66);
			this.panel53.TabIndex = 3;
			// 
			// radioInputPullup_19
			// 
			this.radioInputPullup_19.AutoSize = true;
			this.radioInputPullup_19.Enabled = false;
			this.radioInputPullup_19.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_19.Name = "radioInputPullup_19";
			this.radioInputPullup_19.PinNumber = ((byte)(19));
			this.radioInputPullup_19.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_19.TabIndex = 5;
			this.radioInputPullup_19.Text = "入力（プルアップ）";
			this.radioInputPullup_19.UseVisualStyleBackColor = true;
			this.radioInputPullup_19.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_19
			// 
			this.radioInput_19.AutoSize = true;
			this.radioInput_19.Checked = true;
			this.radioInput_19.Enabled = false;
			this.radioInput_19.Location = new System.Drawing.Point(3, 25);
			this.radioInput_19.Name = "radioInput_19";
			this.radioInput_19.PinNumber = ((byte)(19));
			this.radioInput_19.Size = new System.Drawing.Size(47, 16);
			this.radioInput_19.TabIndex = 4;
			this.radioInput_19.TabStop = true;
			this.radioInput_19.Text = "入力";
			this.radioInput_19.UseVisualStyleBackColor = true;
			this.radioInput_19.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_19
			// 
			this.radioOutput_19.AutoSize = true;
			this.radioOutput_19.Enabled = false;
			this.radioOutput_19.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_19.Name = "radioOutput_19";
			this.radioOutput_19.PinNumber = ((byte)(19));
			this.radioOutput_19.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_19.TabIndex = 4;
			this.radioOutput_19.Text = "出力";
			this.radioOutput_19.UseVisualStyleBackColor = true;
			this.radioOutput_19.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel54
			// 
			this.panel54.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel54.AutoSize = true;
			this.panel54.Controls.Add(this.radioDigital_9);
			this.panel54.Controls.Add(this.radioAnalog_9);
			this.panel54.Location = new System.Drawing.Point(233, 610);
			this.panel54.Name = "panel54";
			this.panel54.Size = new System.Drawing.Size(67, 44);
			this.panel54.TabIndex = 3;
			// 
			// radioDigital_9
			// 
			this.radioDigital_9.AutoSize = true;
			this.radioDigital_9.Enabled = false;
			this.radioDigital_9.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_9.Name = "radioDigital_9";
			this.radioDigital_9.PinNumber = ((byte)(9));
			this.radioDigital_9.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_9.TabIndex = 4;
			this.radioDigital_9.Text = "デジタル";
			this.radioDigital_9.UseVisualStyleBackColor = true;
			this.radioDigital_9.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_9
			// 
			this.radioAnalog_9.AutoSize = true;
			this.radioAnalog_9.Checked = true;
			this.radioAnalog_9.Enabled = false;
			this.radioAnalog_9.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_9.Name = "radioAnalog_9";
			this.radioAnalog_9.PinNumber = ((byte)(9));
			this.radioAnalog_9.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_9.TabIndex = 4;
			this.radioAnalog_9.TabStop = true;
			this.radioAnalog_9.Text = "アナログ";
			this.radioAnalog_9.UseVisualStyleBackColor = true;
			this.radioAnalog_9.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel55
			// 
			this.panel55.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel55.AutoSize = true;
			this.panel55.Controls.Add(this.radioDigital_10);
			this.panel55.Controls.Add(this.radioAnalog_10);
			this.panel55.Location = new System.Drawing.Point(233, 686);
			this.panel55.Name = "panel55";
			this.panel55.Size = new System.Drawing.Size(67, 44);
			this.panel55.TabIndex = 3;
			// 
			// radioDigital_10
			// 
			this.radioDigital_10.AutoSize = true;
			this.radioDigital_10.Enabled = false;
			this.radioDigital_10.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_10.Name = "radioDigital_10";
			this.radioDigital_10.PinNumber = ((byte)(10));
			this.radioDigital_10.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_10.TabIndex = 4;
			this.radioDigital_10.Text = "デジタル";
			this.radioDigital_10.UseVisualStyleBackColor = true;
			this.radioDigital_10.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_10
			// 
			this.radioAnalog_10.AutoSize = true;
			this.radioAnalog_10.Checked = true;
			this.radioAnalog_10.Enabled = false;
			this.radioAnalog_10.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_10.Name = "radioAnalog_10";
			this.radioAnalog_10.PinNumber = ((byte)(10));
			this.radioAnalog_10.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_10.TabIndex = 4;
			this.radioAnalog_10.TabStop = true;
			this.radioAnalog_10.Text = "アナログ";
			this.radioAnalog_10.UseVisualStyleBackColor = true;
			this.radioAnalog_10.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel56
			// 
			this.panel56.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel56.AutoSize = true;
			this.panel56.Controls.Add(this.radioDigital_11);
			this.panel56.Controls.Add(this.radioAnalog_11);
			this.panel56.Location = new System.Drawing.Point(233, 762);
			this.panel56.Name = "panel56";
			this.panel56.Size = new System.Drawing.Size(67, 44);
			this.panel56.TabIndex = 3;
			// 
			// radioDigital_11
			// 
			this.radioDigital_11.AutoSize = true;
			this.radioDigital_11.Enabled = false;
			this.radioDigital_11.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_11.Name = "radioDigital_11";
			this.radioDigital_11.PinNumber = ((byte)(11));
			this.radioDigital_11.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_11.TabIndex = 4;
			this.radioDigital_11.Text = "デジタル";
			this.radioDigital_11.UseVisualStyleBackColor = true;
			this.radioDigital_11.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_11
			// 
			this.radioAnalog_11.AutoSize = true;
			this.radioAnalog_11.Checked = true;
			this.radioAnalog_11.Enabled = false;
			this.radioAnalog_11.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_11.Name = "radioAnalog_11";
			this.radioAnalog_11.PinNumber = ((byte)(11));
			this.radioAnalog_11.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_11.TabIndex = 4;
			this.radioAnalog_11.TabStop = true;
			this.radioAnalog_11.Text = "アナログ";
			this.radioAnalog_11.UseVisualStyleBackColor = true;
			this.radioAnalog_11.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel57
			// 
			this.panel57.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel57.AutoSize = true;
			this.panel57.Controls.Add(this.radioDigital_12);
			this.panel57.Controls.Add(this.radioAnalog_12);
			this.panel57.Location = new System.Drawing.Point(233, 838);
			this.panel57.Name = "panel57";
			this.panel57.Size = new System.Drawing.Size(67, 44);
			this.panel57.TabIndex = 3;
			// 
			// radioDigital_12
			// 
			this.radioDigital_12.AutoSize = true;
			this.radioDigital_12.Checked = true;
			this.radioDigital_12.Enabled = false;
			this.radioDigital_12.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_12.Name = "radioDigital_12";
			this.radioDigital_12.PinNumber = ((byte)(12));
			this.radioDigital_12.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_12.TabIndex = 4;
			this.radioDigital_12.TabStop = true;
			this.radioDigital_12.Text = "デジタル";
			this.radioDigital_12.UseVisualStyleBackColor = true;
			this.radioDigital_12.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_12
			// 
			this.radioAnalog_12.AutoSize = true;
			this.radioAnalog_12.Enabled = false;
			this.radioAnalog_12.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_12.Name = "radioAnalog_12";
			this.radioAnalog_12.PinNumber = ((byte)(12));
			this.radioAnalog_12.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_12.TabIndex = 4;
			this.radioAnalog_12.Text = "アナログ";
			this.radioAnalog_12.UseVisualStyleBackColor = true;
			this.radioAnalog_12.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel58
			// 
			this.panel58.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel58.AutoSize = true;
			this.panel58.Controls.Add(this.radioDigital_13);
			this.panel58.Controls.Add(this.radioAnalog_13);
			this.panel58.Location = new System.Drawing.Point(233, 914);
			this.panel58.Name = "panel58";
			this.panel58.Size = new System.Drawing.Size(67, 44);
			this.panel58.TabIndex = 3;
			// 
			// radioDigital_13
			// 
			this.radioDigital_13.AutoSize = true;
			this.radioDigital_13.Checked = true;
			this.radioDigital_13.Enabled = false;
			this.radioDigital_13.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_13.Name = "radioDigital_13";
			this.radioDigital_13.PinNumber = ((byte)(13));
			this.radioDigital_13.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_13.TabIndex = 4;
			this.radioDigital_13.TabStop = true;
			this.radioDigital_13.Text = "デジタル";
			this.radioDigital_13.UseVisualStyleBackColor = true;
			this.radioDigital_13.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_13
			// 
			this.radioAnalog_13.AutoSize = true;
			this.radioAnalog_13.Enabled = false;
			this.radioAnalog_13.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_13.Name = "radioAnalog_13";
			this.radioAnalog_13.PinNumber = ((byte)(13));
			this.radioAnalog_13.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_13.TabIndex = 4;
			this.radioAnalog_13.Text = "アナログ";
			this.radioAnalog_13.UseVisualStyleBackColor = true;
			this.radioAnalog_13.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel59
			// 
			this.panel59.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel59.AutoSize = true;
			this.panel59.Controls.Add(this.radioDigital_14);
			this.panel59.Controls.Add(this.radioAnalog_14);
			this.panel59.Location = new System.Drawing.Point(233, 990);
			this.panel59.Name = "panel59";
			this.panel59.Size = new System.Drawing.Size(67, 44);
			this.panel59.TabIndex = 3;
			// 
			// radioDigital_14
			// 
			this.radioDigital_14.AutoSize = true;
			this.radioDigital_14.Enabled = false;
			this.radioDigital_14.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_14.Name = "radioDigital_14";
			this.radioDigital_14.PinNumber = ((byte)(14));
			this.radioDigital_14.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_14.TabIndex = 4;
			this.radioDigital_14.Text = "デジタル";
			this.radioDigital_14.UseVisualStyleBackColor = true;
			this.radioDigital_14.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_14
			// 
			this.radioAnalog_14.AutoSize = true;
			this.radioAnalog_14.Checked = true;
			this.radioAnalog_14.Enabled = false;
			this.radioAnalog_14.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_14.Name = "radioAnalog_14";
			this.radioAnalog_14.PinNumber = ((byte)(14));
			this.radioAnalog_14.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_14.TabIndex = 4;
			this.radioAnalog_14.TabStop = true;
			this.radioAnalog_14.Text = "アナログ";
			this.radioAnalog_14.UseVisualStyleBackColor = true;
			this.radioAnalog_14.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel60
			// 
			this.panel60.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel60.AutoSize = true;
			this.panel60.Controls.Add(this.radioDigital_15);
			this.panel60.Controls.Add(this.radioAnalog_15);
			this.panel60.Location = new System.Drawing.Point(233, 1066);
			this.panel60.Name = "panel60";
			this.panel60.Size = new System.Drawing.Size(67, 44);
			this.panel60.TabIndex = 3;
			// 
			// radioDigital_15
			// 
			this.radioDigital_15.AutoSize = true;
			this.radioDigital_15.Enabled = false;
			this.radioDigital_15.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_15.Name = "radioDigital_15";
			this.radioDigital_15.PinNumber = ((byte)(15));
			this.radioDigital_15.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_15.TabIndex = 4;
			this.radioDigital_15.Text = "デジタル";
			this.radioDigital_15.UseVisualStyleBackColor = true;
			this.radioDigital_15.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_15
			// 
			this.radioAnalog_15.AutoSize = true;
			this.radioAnalog_15.Checked = true;
			this.radioAnalog_15.Enabled = false;
			this.radioAnalog_15.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_15.Name = "radioAnalog_15";
			this.radioAnalog_15.PinNumber = ((byte)(15));
			this.radioAnalog_15.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_15.TabIndex = 4;
			this.radioAnalog_15.TabStop = true;
			this.radioAnalog_15.Text = "アナログ";
			this.radioAnalog_15.UseVisualStyleBackColor = true;
			this.radioAnalog_15.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel61
			// 
			this.panel61.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel61.AutoSize = true;
			this.panel61.Controls.Add(this.radioDigital_16);
			this.panel61.Controls.Add(this.radioAnalog_16);
			this.panel61.Location = new System.Drawing.Point(233, 1142);
			this.panel61.Name = "panel61";
			this.panel61.Size = new System.Drawing.Size(67, 44);
			this.panel61.TabIndex = 3;
			// 
			// radioDigital_16
			// 
			this.radioDigital_16.AutoSize = true;
			this.radioDigital_16.Enabled = false;
			this.radioDigital_16.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_16.Name = "radioDigital_16";
			this.radioDigital_16.PinNumber = ((byte)(16));
			this.radioDigital_16.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_16.TabIndex = 4;
			this.radioDigital_16.Text = "デジタル";
			this.radioDigital_16.UseVisualStyleBackColor = true;
			this.radioDigital_16.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_16
			// 
			this.radioAnalog_16.AutoSize = true;
			this.radioAnalog_16.Checked = true;
			this.radioAnalog_16.Enabled = false;
			this.radioAnalog_16.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_16.Name = "radioAnalog_16";
			this.radioAnalog_16.PinNumber = ((byte)(16));
			this.radioAnalog_16.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_16.TabIndex = 4;
			this.radioAnalog_16.TabStop = true;
			this.radioAnalog_16.Text = "アナログ";
			this.radioAnalog_16.UseVisualStyleBackColor = true;
			this.radioAnalog_16.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel62
			// 
			this.panel62.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel62.AutoSize = true;
			this.panel62.Controls.Add(this.radioDigital_17);
			this.panel62.Controls.Add(this.radioAnalog_17);
			this.panel62.Location = new System.Drawing.Point(233, 1218);
			this.panel62.Name = "panel62";
			this.panel62.Size = new System.Drawing.Size(67, 44);
			this.panel62.TabIndex = 3;
			// 
			// radioDigital_17
			// 
			this.radioDigital_17.AutoSize = true;
			this.radioDigital_17.Enabled = false;
			this.radioDigital_17.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_17.Name = "radioDigital_17";
			this.radioDigital_17.PinNumber = ((byte)(17));
			this.radioDigital_17.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_17.TabIndex = 4;
			this.radioDigital_17.Text = "デジタル";
			this.radioDigital_17.UseVisualStyleBackColor = true;
			this.radioDigital_17.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_17
			// 
			this.radioAnalog_17.AutoSize = true;
			this.radioAnalog_17.Checked = true;
			this.radioAnalog_17.Enabled = false;
			this.radioAnalog_17.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_17.Name = "radioAnalog_17";
			this.radioAnalog_17.PinNumber = ((byte)(17));
			this.radioAnalog_17.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_17.TabIndex = 4;
			this.radioAnalog_17.TabStop = true;
			this.radioAnalog_17.Text = "アナログ";
			this.radioAnalog_17.UseVisualStyleBackColor = true;
			this.radioAnalog_17.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel63
			// 
			this.panel63.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel63.AutoSize = true;
			this.panel63.Controls.Add(this.radioDigital_18);
			this.panel63.Controls.Add(this.radioAnalog_18);
			this.panel63.Location = new System.Drawing.Point(233, 1294);
			this.panel63.Name = "panel63";
			this.panel63.Size = new System.Drawing.Size(67, 44);
			this.panel63.TabIndex = 3;
			// 
			// radioDigital_18
			// 
			this.radioDigital_18.AutoSize = true;
			this.radioDigital_18.Enabled = false;
			this.radioDigital_18.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_18.Name = "radioDigital_18";
			this.radioDigital_18.PinNumber = ((byte)(18));
			this.radioDigital_18.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_18.TabIndex = 4;
			this.radioDigital_18.Text = "デジタル";
			this.radioDigital_18.UseVisualStyleBackColor = true;
			this.radioDigital_18.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_18
			// 
			this.radioAnalog_18.AutoSize = true;
			this.radioAnalog_18.Checked = true;
			this.radioAnalog_18.Enabled = false;
			this.radioAnalog_18.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_18.Name = "radioAnalog_18";
			this.radioAnalog_18.PinNumber = ((byte)(18));
			this.radioAnalog_18.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_18.TabIndex = 4;
			this.radioAnalog_18.TabStop = true;
			this.radioAnalog_18.Text = "アナログ";
			this.radioAnalog_18.UseVisualStyleBackColor = true;
			this.radioAnalog_18.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel64
			// 
			this.panel64.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel64.AutoSize = true;
			this.panel64.Controls.Add(this.radioDigital_19);
			this.panel64.Controls.Add(this.radioAnalog_19);
			this.panel64.Location = new System.Drawing.Point(233, 1374);
			this.panel64.Name = "panel64";
			this.panel64.Size = new System.Drawing.Size(67, 44);
			this.panel64.TabIndex = 3;
			// 
			// radioDigital_19
			// 
			this.radioDigital_19.AutoSize = true;
			this.radioDigital_19.Enabled = false;
			this.radioDigital_19.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_19.Name = "radioDigital_19";
			this.radioDigital_19.PinNumber = ((byte)(19));
			this.radioDigital_19.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_19.TabIndex = 4;
			this.radioDigital_19.Text = "デジタル";
			this.radioDigital_19.UseVisualStyleBackColor = true;
			this.radioDigital_19.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_19
			// 
			this.radioAnalog_19.AutoSize = true;
			this.radioAnalog_19.Checked = true;
			this.radioAnalog_19.Enabled = false;
			this.radioAnalog_19.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_19.Name = "radioAnalog_19";
			this.radioAnalog_19.PinNumber = ((byte)(19));
			this.radioAnalog_19.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_19.TabIndex = 4;
			this.radioAnalog_19.TabStop = true;
			this.radioAnalog_19.Text = "アナログ";
			this.radioAnalog_19.UseVisualStyleBackColor = true;
			this.radioAnalog_19.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel66
			// 
			this.panel66.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel66.AutoSize = true;
			this.panel66.Controls.Add(this.labelValue_2);
			this.panel66.Controls.Add(this.trackBar_2);
			this.panel66.Location = new System.Drawing.Point(342, 66);
			this.panel66.Name = "panel66";
			this.panel66.Size = new System.Drawing.Size(364, 69);
			this.panel66.TabIndex = 8;
			// 
			// labelValue_2
			// 
			this.labelValue_2.Enabled = false;
			this.labelValue_2.Location = new System.Drawing.Point(3, 15);
			this.labelValue_2.Name = "labelValue_2";
			this.labelValue_2.PinNumber = ((byte)(2));
			this.labelValue_2.Size = new System.Drawing.Size(358, 16);
			this.labelValue_2.TabIndex = 7;
			this.labelValue_2.Text = "LOW";
			this.labelValue_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_2
			// 
			this.trackBar_2.Enabled = false;
			this.trackBar_2.LargeChange = 1;
			this.trackBar_2.Location = new System.Drawing.Point(3, 30);
			this.trackBar_2.Maximum = 1;
			this.trackBar_2.Name = "trackBar_2";
			this.trackBar_2.PinNumber = ((byte)(2));
			this.trackBar_2.Size = new System.Drawing.Size(358, 45);
			this.trackBar_2.TabIndex = 6;
			this.trackBar_2.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel35
			// 
			this.panel35.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel35.AutoSize = true;
			this.panel35.Controls.Add(this.labelValue_17);
			this.panel35.Controls.Add(this.trackBar_17);
			this.panel35.Location = new System.Drawing.Point(342, 1206);
			this.panel35.Name = "panel35";
			this.panel35.Size = new System.Drawing.Size(364, 69);
			this.panel35.TabIndex = 8;
			// 
			// labelValue_17
			// 
			this.labelValue_17.Enabled = false;
			this.labelValue_17.Location = new System.Drawing.Point(3, 15);
			this.labelValue_17.Name = "labelValue_17";
			this.labelValue_17.PinNumber = ((byte)(17));
			this.labelValue_17.Size = new System.Drawing.Size(358, 16);
			this.labelValue_17.TabIndex = 7;
			this.labelValue_17.Text = "0.000V";
			this.labelValue_17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_17
			// 
			this.trackBar_17.Enabled = false;
			this.trackBar_17.LargeChange = 1;
			this.trackBar_17.Location = new System.Drawing.Point(3, 30);
			this.trackBar_17.Maximum = 1023;
			this.trackBar_17.Name = "trackBar_17";
			this.trackBar_17.PinNumber = ((byte)(17));
			this.trackBar_17.Size = new System.Drawing.Size(358, 45);
			this.trackBar_17.TabIndex = 6;
			this.trackBar_17.TickFrequency = 16;
			this.trackBar_17.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// panel34
			// 
			this.panel34.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel34.AutoSize = true;
			this.panel34.Controls.Add(this.labelValue_16);
			this.panel34.Controls.Add(this.trackBar_16);
			this.panel34.Location = new System.Drawing.Point(342, 1130);
			this.panel34.Name = "panel34";
			this.panel34.Size = new System.Drawing.Size(364, 69);
			this.panel34.TabIndex = 8;
			// 
			// labelValue_16
			// 
			this.labelValue_16.Enabled = false;
			this.labelValue_16.Location = new System.Drawing.Point(3, 15);
			this.labelValue_16.Name = "labelValue_16";
			this.labelValue_16.PinNumber = ((byte)(16));
			this.labelValue_16.Size = new System.Drawing.Size(358, 16);
			this.labelValue_16.TabIndex = 7;
			this.labelValue_16.Text = "0.000V";
			this.labelValue_16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_16
			// 
			this.trackBar_16.Enabled = false;
			this.trackBar_16.LargeChange = 1;
			this.trackBar_16.Location = new System.Drawing.Point(3, 30);
			this.trackBar_16.Maximum = 1023;
			this.trackBar_16.Name = "trackBar_16";
			this.trackBar_16.PinNumber = ((byte)(16));
			this.trackBar_16.Size = new System.Drawing.Size(358, 45);
			this.trackBar_16.TabIndex = 6;
			this.trackBar_16.TickFrequency = 16;
			this.trackBar_16.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_COM,
            this.toolStripMenuItem_BaudRate,
            this.toolStripMenuItem_Interval});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(956, 26);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem_COM
			// 
			this.toolStripMenuItem_COM.Name = "toolStripMenuItem_COM";
			this.toolStripMenuItem_COM.Size = new System.Drawing.Size(131, 22);
			this.toolStripMenuItem_COM.Text = "COMポート：未接続";
			this.toolStripMenuItem_COM.MouseHover += new System.EventHandler(this.ToolStripMenuItem_COM_MouseHover);
			// 
			// toolStripMenuItem_BaudRate
			// 
			this.toolStripMenuItem_BaudRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
			this.toolStripMenuItem_BaudRate.Name = "toolStripMenuItem_BaudRate";
			this.toolStripMenuItem_BaudRate.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem_BaudRate.Text = "BaudRate：9600";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
			this.toolStripMenuItem2.Text = "9600";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem_Click_BaudRate);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
			this.toolStripMenuItem3.Text = "19200";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem_Click_BaudRate);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(118, 22);
			this.toolStripMenuItem4.Text = "38400";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem_Click_BaudRate);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(118, 22);
			this.toolStripMenuItem5.Text = "57600";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem_Click_BaudRate);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(118, 22);
			this.toolStripMenuItem6.Text = "115200";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem_Click_BaudRate);
			// 
			// toolStripMenuItem_Interval
			// 
			this.toolStripMenuItem_Interval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
			this.toolStripMenuItem_Interval.Name = "toolStripMenuItem_Interval";
			this.toolStripMenuItem_Interval.Size = new System.Drawing.Size(106, 22);
			this.toolStripMenuItem_Interval.Text = "Interval：1000";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(104, 22);
			this.toolStripMenuItem7.Text = "500";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Interval);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(104, 22);
			this.toolStripMenuItem8.Text = "1000";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Interval);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(104, 22);
			this.toolStripMenuItem9.Text = "2000";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Interval);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(104, 22);
			this.toolStripMenuItem10.Text = "3000";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Interval);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(104, 22);
			this.toolStripMenuItem11.Text = "5000";
			this.toolStripMenuItem11.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Interval);
			// 
			// timerRead
			// 
			this.timerRead.Interval = 1000;
			this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
			// 
			// panel14
			// 
			this.panel14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel14.AutoSize = true;
			this.panel14.Controls.Add(this.radioButton_pin10);
			this.panel14.Controls.Add(this.radioButton_pin11);
			this.panel14.Controls.Add(this.radioButton_pin12);
			this.panel14.Location = new System.Drawing.Point(847, 13855);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(109, 66);
			this.panel14.TabIndex = 3;
			// 
			// radioButton_pin10
			// 
			this.radioButton_pin10.AutoSize = true;
			this.radioButton_pin10.Enabled = false;
			this.radioButton_pin10.Location = new System.Drawing.Point(3, 47);
			this.radioButton_pin10.Name = "radioButton_pin10";
			this.radioButton_pin10.PinNumber = ((byte)(6));
			this.radioButton_pin10.Size = new System.Drawing.Size(103, 16);
			this.radioButton_pin10.TabIndex = 5;
			this.radioButton_pin10.TabStop = true;
			this.radioButton_pin10.Text = "入力（プルアップ）";
			this.radioButton_pin10.UseVisualStyleBackColor = true;
			this.radioButton_pin10.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioButton_pin11
			// 
			this.radioButton_pin11.AutoSize = true;
			this.radioButton_pin11.Enabled = false;
			this.radioButton_pin11.Location = new System.Drawing.Point(3, 25);
			this.radioButton_pin11.Name = "radioButton_pin11";
			this.radioButton_pin11.PinNumber = ((byte)(6));
			this.radioButton_pin11.Size = new System.Drawing.Size(47, 16);
			this.radioButton_pin11.TabIndex = 4;
			this.radioButton_pin11.Text = "入力";
			this.radioButton_pin11.UseVisualStyleBackColor = true;
			this.radioButton_pin11.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioButton_pin12
			// 
			this.radioButton_pin12.AutoSize = true;
			this.radioButton_pin12.Checked = true;
			this.radioButton_pin12.Enabled = false;
			this.radioButton_pin12.Location = new System.Drawing.Point(3, 3);
			this.radioButton_pin12.Name = "radioButton_pin12";
			this.radioButton_pin12.PinNumber = ((byte)(6));
			this.radioButton_pin12.Size = new System.Drawing.Size(47, 16);
			this.radioButton_pin12.TabIndex = 4;
			this.radioButton_pin12.TabStop = true;
			this.radioButton_pin12.Text = "出力";
			this.radioButton_pin12.UseVisualStyleBackColor = true;
			this.radioButton_pin12.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel29
			// 
			this.panel29.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel29.AutoSize = true;
			this.panel29.Controls.Add(this.radioButton_pin29);
			this.panel29.Controls.Add(this.radioButton_pin30);
			this.panel29.Location = new System.Drawing.Point(830, 13965);
			this.panel29.Name = "panel29";
			this.panel29.Size = new System.Drawing.Size(67, 44);
			this.panel29.TabIndex = 3;
			// 
			// radioButton_pin29
			// 
			this.radioButton_pin29.AutoSize = true;
			this.radioButton_pin29.Enabled = false;
			this.radioButton_pin29.Location = new System.Drawing.Point(3, 3);
			this.radioButton_pin29.Name = "radioButton_pin29";
			this.radioButton_pin29.PinNumber = ((byte)(19));
			this.radioButton_pin29.Size = new System.Drawing.Size(61, 16);
			this.radioButton_pin29.TabIndex = 4;
			this.radioButton_pin29.Text = "デジタル";
			this.radioButton_pin29.UseVisualStyleBackColor = true;
			this.radioButton_pin29.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioButton_pin30
			// 
			this.radioButton_pin30.AutoSize = true;
			this.radioButton_pin30.Checked = true;
			this.radioButton_pin30.Enabled = false;
			this.radioButton_pin30.Location = new System.Drawing.Point(3, 25);
			this.radioButton_pin30.Name = "radioButton_pin30";
			this.radioButton_pin30.PinNumber = ((byte)(19));
			this.radioButton_pin30.Size = new System.Drawing.Size(60, 16);
			this.radioButton_pin30.TabIndex = 4;
			this.radioButton_pin30.TabStop = true;
			this.radioButton_pin30.Text = "アナログ";
			this.radioButton_pin30.UseVisualStyleBackColor = true;
			this.radioButton_pin30.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// label19
			// 
			this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label19.Location = new System.Drawing.Point(816, 13731);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(29, 19);
			this.label19.TabIndex = 3;
			this.label19.Text = "10";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label19.Click += new System.EventHandler(this.label5_Click);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.ForeColor = System.Drawing.SystemColors.Control;
			this.label22.Location = new System.Drawing.Point(22, 3241);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(41, 12);
			this.label22.TabIndex = 4;
			this.label22.Text = "dummy";
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel3.AutoSize = true;
			this.panel3.Controls.Add(this.radioInputPullup_dummy);
			this.panel3.Controls.Add(this.radioInput_dummy);
			this.panel3.Controls.Add(this.radioOutput_dummy);
			this.panel3.Location = new System.Drawing.Point(120, 6996);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(109, 66);
			this.panel3.TabIndex = 3;
			this.panel3.Visible = false;
			// 
			// radioInputPullup_dummy
			// 
			this.radioInputPullup_dummy.AutoSize = true;
			this.radioInputPullup_dummy.Enabled = false;
			this.radioInputPullup_dummy.Location = new System.Drawing.Point(3, 47);
			this.radioInputPullup_dummy.Name = "radioInputPullup_dummy";
			this.radioInputPullup_dummy.PinNumber = ((byte)(2));
			this.radioInputPullup_dummy.Size = new System.Drawing.Size(103, 16);
			this.radioInputPullup_dummy.TabIndex = 5;
			this.radioInputPullup_dummy.TabStop = true;
			this.radioInputPullup_dummy.Text = "入力（プルアップ）";
			this.radioInputPullup_dummy.UseVisualStyleBackColor = true;
			this.radioInputPullup_dummy.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioInput_dummy
			// 
			this.radioInput_dummy.AutoSize = true;
			this.radioInput_dummy.Enabled = false;
			this.radioInput_dummy.Location = new System.Drawing.Point(3, 25);
			this.radioInput_dummy.Name = "radioInput_dummy";
			this.radioInput_dummy.PinNumber = ((byte)(2));
			this.radioInput_dummy.Size = new System.Drawing.Size(47, 16);
			this.radioInput_dummy.TabIndex = 4;
			this.radioInput_dummy.Text = "入力";
			this.radioInput_dummy.UseVisualStyleBackColor = true;
			this.radioInput_dummy.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioOutput_dummy
			// 
			this.radioOutput_dummy.AutoSize = true;
			this.radioOutput_dummy.Checked = true;
			this.radioOutput_dummy.Enabled = false;
			this.radioOutput_dummy.Location = new System.Drawing.Point(3, 3);
			this.radioOutput_dummy.Name = "radioOutput_dummy";
			this.radioOutput_dummy.PinNumber = ((byte)(2));
			this.radioOutput_dummy.Size = new System.Drawing.Size(47, 16);
			this.radioOutput_dummy.TabIndex = 4;
			this.radioOutput_dummy.TabStop = true;
			this.radioOutput_dummy.Text = "出力";
			this.radioOutput_dummy.UseVisualStyleBackColor = true;
			this.radioOutput_dummy.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel19
			// 
			this.panel19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel19.AutoSize = true;
			this.panel19.Controls.Add(this.radioDigital_dummy);
			this.panel19.Controls.Add(this.radioAnalog_dummy);
			this.panel19.Location = new System.Drawing.Point(257, 6996);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(67, 44);
			this.panel19.TabIndex = 3;
			this.panel19.Visible = false;
			// 
			// radioDigital_dummy
			// 
			this.radioDigital_dummy.AutoSize = true;
			this.radioDigital_dummy.Checked = true;
			this.radioDigital_dummy.Enabled = false;
			this.radioDigital_dummy.Location = new System.Drawing.Point(3, 3);
			this.radioDigital_dummy.Name = "radioDigital_dummy";
			this.radioDigital_dummy.PinNumber = ((byte)(2));
			this.radioDigital_dummy.Size = new System.Drawing.Size(61, 16);
			this.radioDigital_dummy.TabIndex = 4;
			this.radioDigital_dummy.TabStop = true;
			this.radioDigital_dummy.Text = "デジタル";
			this.radioDigital_dummy.UseVisualStyleBackColor = true;
			this.radioDigital_dummy.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// radioAnalog_dummy
			// 
			this.radioAnalog_dummy.AutoSize = true;
			this.radioAnalog_dummy.Enabled = false;
			this.radioAnalog_dummy.Location = new System.Drawing.Point(3, 25);
			this.radioAnalog_dummy.Name = "radioAnalog_dummy";
			this.radioAnalog_dummy.PinNumber = ((byte)(2));
			this.radioAnalog_dummy.Size = new System.Drawing.Size(60, 16);
			this.radioAnalog_dummy.TabIndex = 4;
			this.radioAnalog_dummy.Text = "アナログ";
			this.radioAnalog_dummy.UseVisualStyleBackColor = true;
			this.radioAnalog_dummy.Click += new System.EventHandler(this.radioIO_AD_Click);
			// 
			// panel26
			// 
			this.panel26.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel26.AutoSize = true;
			this.panel26.Controls.Add(this.labelValue_dummy);
			this.panel26.Controls.Add(this.trackBar_dummy);
			this.panel26.Location = new System.Drawing.Point(366, 6996);
			this.panel26.Name = "panel26";
			this.panel26.Size = new System.Drawing.Size(364, 78);
			this.panel26.TabIndex = 8;
			this.panel26.Visible = false;
			// 
			// labelValue_dummy
			// 
			this.labelValue_dummy.Enabled = false;
			this.labelValue_dummy.Location = new System.Drawing.Point(3, 15);
			this.labelValue_dummy.Name = "labelValue_dummy";
			this.labelValue_dummy.PinNumber = ((byte)(2));
			this.labelValue_dummy.Size = new System.Drawing.Size(358, 16);
			this.labelValue_dummy.TabIndex = 7;
			this.labelValue_dummy.Text = "LOW";
			this.labelValue_dummy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// trackBar_dummy
			// 
			this.trackBar_dummy.Enabled = false;
			this.trackBar_dummy.LargeChange = 1;
			this.trackBar_dummy.Location = new System.Drawing.Point(3, 30);
			this.trackBar_dummy.Maximum = 1;
			this.trackBar_dummy.Name = "trackBar_dummy";
			this.trackBar_dummy.PinNumber = ((byte)(2));
			this.trackBar_dummy.Size = new System.Drawing.Size(358, 45);
			this.trackBar_dummy.TabIndex = 6;
			this.trackBar_dummy.Scroll += new System.EventHandler(this.trackBar_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(969, 967);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel14);
			this.Controls.Add(this.panel29);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel26);
			this.Controls.Add(this.panel19);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.Form1_Click);
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel13.ResumeLayout(false);
			this.panel13.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_6)).EndInit();
			this.panel15.ResumeLayout(false);
			this.panel15.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_9)).EndInit();
			this.panel17.ResumeLayout(false);
			this.panel17.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_10)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_11)).EndInit();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_5)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_3)).EndInit();
			this.panel38.ResumeLayout(false);
			this.panel38.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_19)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.panel20.ResumeLayout(false);
			this.panel20.PerformLayout();
			this.panel21.ResumeLayout(false);
			this.panel21.PerformLayout();
			this.panel22.ResumeLayout(false);
			this.panel22.PerformLayout();
			this.panel23.ResumeLayout(false);
			this.panel23.PerformLayout();
			this.panel24.ResumeLayout(false);
			this.panel24.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_8)).EndInit();
			this.panel18.ResumeLayout(false);
			this.panel18.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_4)).EndInit();
			this.panel25.ResumeLayout(false);
			this.panel25.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_7)).EndInit();
			this.panel28.ResumeLayout(false);
			this.panel28.PerformLayout();
			this.panel16.ResumeLayout(false);
			this.panel16.PerformLayout();
			this.panel33.ResumeLayout(false);
			this.panel33.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_18)).EndInit();
			this.panel36.ResumeLayout(false);
			this.panel36.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_15)).EndInit();
			this.panel37.ResumeLayout(false);
			this.panel37.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_14)).EndInit();
			this.panel39.ResumeLayout(false);
			this.panel39.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_12)).EndInit();
			this.panel40.ResumeLayout(false);
			this.panel40.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_13)).EndInit();
			this.panel42.ResumeLayout(false);
			this.panel42.PerformLayout();
			this.panel43.ResumeLayout(false);
			this.panel43.PerformLayout();
			this.panel44.ResumeLayout(false);
			this.panel44.PerformLayout();
			this.panel45.ResumeLayout(false);
			this.panel45.PerformLayout();
			this.panel46.ResumeLayout(false);
			this.panel46.PerformLayout();
			this.panel47.ResumeLayout(false);
			this.panel47.PerformLayout();
			this.panel48.ResumeLayout(false);
			this.panel48.PerformLayout();
			this.panel49.ResumeLayout(false);
			this.panel49.PerformLayout();
			this.panel50.ResumeLayout(false);
			this.panel50.PerformLayout();
			this.panel51.ResumeLayout(false);
			this.panel51.PerformLayout();
			this.panel52.ResumeLayout(false);
			this.panel52.PerformLayout();
			this.panel53.ResumeLayout(false);
			this.panel53.PerformLayout();
			this.panel54.ResumeLayout(false);
			this.panel54.PerformLayout();
			this.panel55.ResumeLayout(false);
			this.panel55.PerformLayout();
			this.panel56.ResumeLayout(false);
			this.panel56.PerformLayout();
			this.panel57.ResumeLayout(false);
			this.panel57.PerformLayout();
			this.panel58.ResumeLayout(false);
			this.panel58.PerformLayout();
			this.panel59.ResumeLayout(false);
			this.panel59.PerformLayout();
			this.panel60.ResumeLayout(false);
			this.panel60.PerformLayout();
			this.panel61.ResumeLayout(false);
			this.panel61.PerformLayout();
			this.panel62.ResumeLayout(false);
			this.panel62.PerformLayout();
			this.panel63.ResumeLayout(false);
			this.panel63.PerformLayout();
			this.panel64.ResumeLayout(false);
			this.panel64.PerformLayout();
			this.panel66.ResumeLayout(false);
			this.panel66.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_2)).EndInit();
			this.panel35.ResumeLayout(false);
			this.panel35.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_17)).EndInit();
			this.panel34.ResumeLayout(false);
			this.panel34.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_16)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel14.ResumeLayout(false);
			this.panel14.PerformLayout();
			this.panel29.ResumeLayout(false);
			this.panel29.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel19.ResumeLayout(false);
			this.panel19.PerformLayout();
			this.panel26.ResumeLayout(false);
			this.panel26.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar_dummy)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel11;
		private RadioButton_pin radioDigital_2;
		private RadioButton_pin radioAnalog_2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private RadioButton_pin radioDigital_6;
		private RadioButton_pin radioAnalog_6;
		private System.Windows.Forms.Panel panel1;
		private RadioButton_pin radioInputPullup_6;
		private RadioButton_pin radioInput_6;
		private RadioButton_pin radioOutput_6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel6;
		private RadioButton_pin radioInputPullup_2;
		private RadioButton_pin radioInput_2;
		private RadioButton_pin radioOutput_2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_BaudRate;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_COM;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Interval;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.Timer timerRead;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel8;
		private RadioButton_pin radioInputPullup_3;
		private RadioButton_pin radioInput_3;
		private RadioButton_pin radioOutput_3;
		private System.Windows.Forms.Panel panel10;
		private RadioButton_pin radioInputPullup_4;
		private RadioButton_pin radioInput_4;
		private RadioButton_pin radioOutput_4;
		private System.Windows.Forms.Panel panel12;
		private RadioButton_pin radioInputPullup_5;
		private RadioButton_pin radioInput_5;
		private RadioButton_pin radioOutput_5;
		private System.Windows.Forms.Panel panel14;
		private RadioButton_pin radioButton_pin10;
		private RadioButton_pin radioButton_pin11;
		private RadioButton_pin radioButton_pin12;
		private System.Windows.Forms.Panel panel16;
		private RadioButton_pin radioDigital_8;
		private RadioButton_pin radioAnalog_8;
		private System.Windows.Forms.Panel panel20;
		private RadioButton_pin radioDigital_3;
		private RadioButton_pin radioAnalog_3;
		private System.Windows.Forms.Panel panel21;
		private RadioButton_pin radioDigital_4;
		private RadioButton_pin radioAnalog_4;
		private System.Windows.Forms.Panel panel22;
		private RadioButton_pin radioDigital_5;
		private RadioButton_pin radioAnalog_5;
		private System.Windows.Forms.Panel panel23;
		private RadioButton_pin radioDigital_7;
		private RadioButton_pin radioAnalog_7;
		private System.Windows.Forms.Panel panel18;
		private Label_pin labelValue_4;
		private TrackBar_pin trackBar_4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel24;
		private Label_pin labelValue_8;
		private TrackBar_pin trackBar_8;
		private System.Windows.Forms.Panel panel25;
		private Label_pin labelValue_7;
		private TrackBar_pin trackBar_7;
		private System.Windows.Forms.Panel panel28;
		private RadioButton_pin radioInputPullup_7;
		private RadioButton_pin radioInput_7;
		private RadioButton_pin radioOutput_7;
		private System.Windows.Forms.Panel panel29;
		private RadioButton_pin radioButton_pin29;
		private RadioButton_pin radioButton_pin30;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel38;
		private Label_pin labelValue_19;
		private TrackBar_pin trackBar_19;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel33;
		private Label_pin labelValue_18;
		private TrackBar_pin trackBar_18;
		private System.Windows.Forms.Panel panel34;
		private Label_pin labelValue_16;
		private TrackBar_pin trackBar_16;
		private System.Windows.Forms.Panel panel35;
		private Label_pin labelValue_17;
		private TrackBar_pin trackBar_17;
		private System.Windows.Forms.Panel panel36;
		private Label_pin labelValue_15;
		private TrackBar_pin trackBar_15;
		private System.Windows.Forms.Panel panel37;
		private Label_pin labelValue_14;
		private TrackBar_pin trackBar_14;
		private System.Windows.Forms.Panel panel39;
		private Label_pin labelValue_12;
		private TrackBar_pin trackBar_12;
		private System.Windows.Forms.Panel panel40;
		private Label_pin labelValue_13;
		private TrackBar_pin trackBar_13;
		private System.Windows.Forms.Panel panel42;
		private RadioButton_pin radioInputPullup_8;
		private RadioButton_pin radioInput_8;
		private RadioButton_pin radioOutput_8;
		private System.Windows.Forms.Panel panel43;
		private RadioButton_pin radioInputPullup_9;
		private RadioButton_pin radioInput_9;
		private RadioButton_pin radioOutput_9;
		private System.Windows.Forms.Panel panel44;
		private RadioButton_pin radioInputPullup_10;
		private RadioButton_pin radioInput_10;
		private RadioButton_pin radioOutput_10;
		private System.Windows.Forms.Panel panel45;
		private RadioButton_pin radioInputPullup_11;
		private RadioButton_pin radioInput_11;
		private RadioButton_pin radioOutput_11;
		private System.Windows.Forms.Panel panel46;
		private RadioButton_pin radioInputPullup_12;
		private RadioButton_pin radioInput_12;
		private RadioButton_pin radioOutput_12;
		private System.Windows.Forms.Panel panel47;
		private RadioButton_pin radioInputPullup_13;
		private RadioButton_pin radioInput_13;
		private RadioButton_pin radioOutput_13;
		private System.Windows.Forms.Panel panel48;
		private RadioButton_pin radioInputPullup_14;
		private RadioButton_pin radioInput_14;
		private RadioButton_pin radioOutput_14;
		private System.Windows.Forms.Panel panel49;
		private RadioButton_pin radioInputPullup_16;
		private RadioButton_pin radioInput_16;
		private RadioButton_pin radioOutput_16;
		private System.Windows.Forms.Panel panel50;
		private RadioButton_pin radioInputPullup_17;
		private RadioButton_pin radioInput_17;
		private RadioButton_pin radioOutput_17;
		private System.Windows.Forms.Panel panel13;
		private Label_pin labelValue_6;
		private TrackBar_pin trackBar_6;
		private System.Windows.Forms.Panel panel15;
		private Label_pin labelValue_9;
		private TrackBar_pin trackBar_9;
		private System.Windows.Forms.Panel panel17;
		private Label_pin labelValue_10;
		private TrackBar_pin trackBar_10;
		private System.Windows.Forms.Panel panel5;
		private Label_pin labelValue_11;
		private TrackBar_pin trackBar_11;
		private System.Windows.Forms.Panel panel9;
		private Label_pin labelValue_5;
		private TrackBar_pin trackBar_5;
		private System.Windows.Forms.Panel panel7;
		private Label_pin labelValue_3;
		private TrackBar_pin trackBar_3;
		private System.Windows.Forms.Panel panel51;
		private RadioButton_pin radioInputPullup_15;
		private RadioButton_pin radioInput_15;
		private RadioButton_pin radioOutput_15;
		private System.Windows.Forms.Panel panel52;
		private RadioButton_pin radioInputPullup_18;
		private RadioButton_pin radioInput_18;
		private RadioButton_pin radioOutput_18;
		private System.Windows.Forms.Panel panel53;
		private RadioButton_pin radioInputPullup_19;
		private RadioButton_pin radioInput_19;
		private RadioButton_pin radioOutput_19;
		private System.Windows.Forms.Panel panel54;
		private RadioButton_pin radioDigital_9;
		private RadioButton_pin radioAnalog_9;
		private System.Windows.Forms.Panel panel55;
		private RadioButton_pin radioDigital_10;
		private RadioButton_pin radioAnalog_10;
		private System.Windows.Forms.Panel panel56;
		private RadioButton_pin radioDigital_11;
		private RadioButton_pin radioAnalog_11;
		private System.Windows.Forms.Panel panel57;
		private RadioButton_pin radioDigital_12;
		private RadioButton_pin radioAnalog_12;
		private System.Windows.Forms.Panel panel58;
		private RadioButton_pin radioDigital_13;
		private RadioButton_pin radioAnalog_13;
		private System.Windows.Forms.Panel panel59;
		private RadioButton_pin radioDigital_14;
		private RadioButton_pin radioAnalog_14;
		private System.Windows.Forms.Panel panel60;
		private RadioButton_pin radioDigital_15;
		private RadioButton_pin radioAnalog_15;
		private System.Windows.Forms.Panel panel61;
		private RadioButton_pin radioDigital_16;
		private RadioButton_pin radioAnalog_16;
		private System.Windows.Forms.Panel panel62;
		private RadioButton_pin radioDigital_17;
		private RadioButton_pin radioAnalog_17;
		private System.Windows.Forms.Panel panel63;
		private RadioButton_pin radioDigital_18;
		private RadioButton_pin radioAnalog_18;
		private System.Windows.Forms.Panel panel64;
		private RadioButton_pin radioDigital_19;
		private RadioButton_pin radioAnalog_19;
		private System.Windows.Forms.Panel panel66;
		private Label_pin labelValue_2;
		private TrackBar_pin trackBar_2;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel panel3;
		private RadioButton_pin radioInputPullup_dummy;
		private RadioButton_pin radioInput_dummy;
		private RadioButton_pin radioOutput_dummy;
		private System.Windows.Forms.Panel panel19;
		private RadioButton_pin radioDigital_dummy;
		private RadioButton_pin radioAnalog_dummy;
		private System.Windows.Forms.Panel panel26;
		private Label_pin labelValue_dummy;
		private TrackBar_pin trackBar_dummy;


	}
}

