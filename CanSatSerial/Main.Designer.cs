namespace CanSatSerial
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.setTab = new System.Windows.Forms.TabPage();
            this.splitbysemicolonSw = new System.Windows.Forms.CheckBox();
            this.reset = new System.Windows.Forms.Button();
            this.serialSend = new System.Windows.Forms.Button();
            this.serialMessage = new System.Windows.Forms.TextBox();
            this.serialLog = new System.Windows.Forms.RichTextBox();
            this.serialStop = new System.Windows.Forms.Button();
            this.serialRenew = new System.Windows.Forms.Button();
            this.serialStart = new System.Windows.Forms.Button();
            this.serialBaudLabel = new System.Windows.Forms.Label();
            this.serialBaud = new System.Windows.Forms.NumericUpDown();
            this.serialLabel = new System.Windows.Forms.Label();
            this.serialPorts = new System.Windows.Forms.ComboBox();
            this.tableTab = new System.Windows.Forms.TabPage();
            this.table = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedLblLabel = new System.Windows.Forms.Label();
            this.phaseLblLabel = new System.Windows.Forms.Label();
            this.phaseLabel = new System.Windows.Forms.Label();
            this.gps2Label = new System.Windows.Forms.Label();
            this.gps1Label = new System.Windows.Forms.Label();
            this.gpsLblLabel = new System.Windows.Forms.Label();
            this.heightbarLabel = new System.Windows.Forms.Label();
            this.heightbarLblLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLblLabel = new System.Windows.Forms.Label();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.OpenCharts = new System.Windows.Forms.Button();
            this.OpenMonitor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.setTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialBaud)).BeginInit();
            this.tableTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.dataTab.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.ImageLocation = "logo.png";
            this.logoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoBox.InitialImage")));
            this.logoBox.Location = new System.Drawing.Point(460, 12);
            this.logoBox.MinimumSize = new System.Drawing.Size(200, 125);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(200, 125);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // serial
            // 
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Flow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(465, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интеллект-Р";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Flow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(466, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "© 2018, г. Феодосия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Flow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(490, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Монитор v.2";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numberLabel.Location = new System.Drawing.Point(372, 16);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(13, 13);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "0";
            // 
            // setTab
            // 
            this.setTab.Controls.Add(this.splitbysemicolonSw);
            this.setTab.Controls.Add(this.reset);
            this.setTab.Controls.Add(this.serialSend);
            this.setTab.Controls.Add(this.serialMessage);
            this.setTab.Controls.Add(this.serialLog);
            this.setTab.Controls.Add(this.serialStop);
            this.setTab.Controls.Add(this.serialRenew);
            this.setTab.Controls.Add(this.serialStart);
            this.setTab.Controls.Add(this.serialBaudLabel);
            this.setTab.Controls.Add(this.serialBaud);
            this.setTab.Controls.Add(this.serialLabel);
            this.setTab.Controls.Add(this.serialPorts);
            this.setTab.Location = new System.Drawing.Point(4, 22);
            this.setTab.Name = "setTab";
            this.setTab.Size = new System.Drawing.Size(434, 299);
            this.setTab.TabIndex = 2;
            this.setTab.Text = "Настройки";
            this.setTab.UseVisualStyleBackColor = true;
            // 
            // splitbysemicolonSw
            // 
            this.splitbysemicolonSw.AutoSize = true;
            this.splitbysemicolonSw.Checked = true;
            this.splitbysemicolonSw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.splitbysemicolonSw.Location = new System.Drawing.Point(327, 29);
            this.splitbysemicolonSw.Name = "splitbysemicolonSw";
            this.splitbysemicolonSw.Size = new System.Drawing.Size(15, 14);
            this.splitbysemicolonSw.TabIndex = 13;
            this.splitbysemicolonSw.UseVisualStyleBackColor = true;
            this.splitbysemicolonSw.CheckedChanged += new System.EventHandler(this.splitbysemicolonSw_CheckedChanged);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.ForeColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(351, 26);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 48);
            this.reset.TabIndex = 12;
            this.reset.Text = "Сброс данных";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // serialSend
            // 
            this.serialSend.Location = new System.Drawing.Point(351, 270);
            this.serialSend.Name = "serialSend";
            this.serialSend.Size = new System.Drawing.Size(75, 23);
            this.serialSend.TabIndex = 11;
            this.serialSend.Text = "Отправить";
            this.serialSend.UseVisualStyleBackColor = true;
            this.serialSend.Click += new System.EventHandler(this.serialSend_Click);
            // 
            // serialMessage
            // 
            this.serialMessage.Location = new System.Drawing.Point(8, 272);
            this.serialMessage.Name = "serialMessage";
            this.serialMessage.Size = new System.Drawing.Size(337, 20);
            this.serialMessage.TabIndex = 10;
            // 
            // serialLog
            // 
            this.serialLog.Location = new System.Drawing.Point(8, 82);
            this.serialLog.Name = "serialLog";
            this.serialLog.ReadOnly = true;
            this.serialLog.Size = new System.Drawing.Size(418, 182);
            this.serialLog.TabIndex = 9;
            this.serialLog.Text = "";
            // 
            // serialStop
            // 
            this.serialStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialStop.ForeColor = System.Drawing.Color.DarkRed;
            this.serialStop.Location = new System.Drawing.Point(181, 52);
            this.serialStop.Name = "serialStop";
            this.serialStop.Size = new System.Drawing.Size(164, 23);
            this.serialStop.TabIndex = 8;
            this.serialStop.Text = "Отключиться";
            this.serialStop.UseVisualStyleBackColor = true;
            this.serialStop.Click += new System.EventHandler(this.serialStop_Click);
            // 
            // serialRenew
            // 
            this.serialRenew.Location = new System.Drawing.Point(135, 24);
            this.serialRenew.Name = "serialRenew";
            this.serialRenew.Size = new System.Drawing.Size(75, 23);
            this.serialRenew.TabIndex = 7;
            this.serialRenew.Text = "Обновить";
            this.serialRenew.UseVisualStyleBackColor = true;
            this.serialRenew.Click += new System.EventHandler(this.serialRenew_Click);
            // 
            // serialStart
            // 
            this.serialStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialStart.ForeColor = System.Drawing.Color.Green;
            this.serialStart.Location = new System.Drawing.Point(8, 52);
            this.serialStart.Name = "serialStart";
            this.serialStart.Size = new System.Drawing.Size(164, 23);
            this.serialStart.TabIndex = 5;
            this.serialStart.Text = "Подключиться";
            this.serialStart.UseVisualStyleBackColor = true;
            this.serialStart.Click += new System.EventHandler(this.serialStart_Click);
            // 
            // serialBaudLabel
            // 
            this.serialBaudLabel.AutoSize = true;
            this.serialBaudLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialBaudLabel.Location = new System.Drawing.Point(284, 27);
            this.serialBaudLabel.Name = "serialBaudLabel";
            this.serialBaudLabel.Size = new System.Drawing.Size(37, 15);
            this.serialBaudLabel.TabIndex = 4;
            this.serialBaudLabel.Text = "бит/с";
            // 
            // serialBaud
            // 
            this.serialBaud.Location = new System.Drawing.Point(216, 26);
            this.serialBaud.Maximum = new decimal(new int[] {
            256000,
            0,
            0,
            0});
            this.serialBaud.Minimum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.serialBaud.Name = "serialBaud";
            this.serialBaud.Size = new System.Drawing.Size(66, 20);
            this.serialBaud.TabIndex = 2;
            this.serialBaud.Value = new decimal(new int[] {
            38400,
            0,
            0,
            0});
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialLabel.Location = new System.Drawing.Point(5, 5);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(255, 17);
            this.serialLabel.TabIndex = 1;
            this.serialLabel.Text = "Настройки последовательного порта";
            // 
            // serialPorts
            // 
            this.serialPorts.FormattingEnabled = true;
            this.serialPorts.Location = new System.Drawing.Point(8, 25);
            this.serialPorts.Name = "serialPorts";
            this.serialPorts.Size = new System.Drawing.Size(121, 21);
            this.serialPorts.TabIndex = 0;
            // 
            // tableTab
            // 
            this.tableTab.Controls.Add(this.table);
            this.tableTab.Location = new System.Drawing.Point(4, 22);
            this.tableTab.Name = "tableTab";
            this.tableTab.Padding = new System.Windows.Forms.Padding(3);
            this.tableTab.Size = new System.Drawing.Size(434, 299);
            this.tableTab.TabIndex = 1;
            this.tableTab.Text = "Таблица";
            this.tableTab.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.height,
            this.spd,
            this.gpsLat,
            this.gpsLon,
            this.phase});
            this.table.Location = new System.Drawing.Point(7, 7);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(421, 286);
            this.table.TabIndex = 0;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 65;
            // 
            // height
            // 
            this.height.HeaderText = "Высота";
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Width = 70;
            // 
            // spd
            // 
            this.spd.HeaderText = "Скорость спуска";
            this.spd.Name = "spd";
            this.spd.ReadOnly = true;
            this.spd.Width = 118;
            // 
            // gpsLat
            // 
            this.gpsLat.HeaderText = "Широта";
            this.gpsLat.Name = "gpsLat";
            this.gpsLat.ReadOnly = true;
            this.gpsLat.Width = 70;
            // 
            // gpsLon
            // 
            this.gpsLon.HeaderText = "Долгота";
            this.gpsLon.Name = "gpsLon";
            this.gpsLon.ReadOnly = true;
            this.gpsLon.Width = 75;
            // 
            // phase
            // 
            this.phase.HeaderText = "Фаза полета";
            this.phase.Name = "phase";
            this.phase.ReadOnly = true;
            this.phase.Width = 99;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.speedLabel);
            this.dataTab.Controls.Add(this.speedLblLabel);
            this.dataTab.Controls.Add(this.phaseLblLabel);
            this.dataTab.Controls.Add(this.phaseLabel);
            this.dataTab.Controls.Add(this.gps2Label);
            this.dataTab.Controls.Add(this.gps1Label);
            this.dataTab.Controls.Add(this.gpsLblLabel);
            this.dataTab.Controls.Add(this.heightbarLabel);
            this.dataTab.Controls.Add(this.heightbarLblLabel);
            this.dataTab.Controls.Add(this.timeLabel);
            this.dataTab.Controls.Add(this.timeLblLabel);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(434, 299);
            this.dataTab.TabIndex = 0;
            this.dataTab.Text = "Прием";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(243, 121);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(42, 46);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "0";
            // 
            // speedLblLabel
            // 
            this.speedLblLabel.AutoSize = true;
            this.speedLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLblLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.speedLblLabel.Location = new System.Drawing.Point(245, 90);
            this.speedLblLabel.Name = "speedLblLabel";
            this.speedLblLabel.Size = new System.Drawing.Size(141, 31);
            this.speedLblLabel.TabIndex = 9;
            this.speedLblLabel.Text = "Скорость:";
            // 
            // phaseLblLabel
            // 
            this.phaseLblLabel.AutoSize = true;
            this.phaseLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phaseLblLabel.Location = new System.Drawing.Point(245, 13);
            this.phaseLblLabel.Name = "phaseLblLabel";
            this.phaseLblLabel.Size = new System.Drawing.Size(183, 31);
            this.phaseLblLabel.TabIndex = 8;
            this.phaseLblLabel.Text = "Фаза полёта:";
            // 
            // phaseLabel
            // 
            this.phaseLabel.AutoSize = true;
            this.phaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phaseLabel.Location = new System.Drawing.Point(243, 44);
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(42, 46);
            this.phaseLabel.TabIndex = 7;
            this.phaseLabel.Text = "0";
            // 
            // gps2Label
            // 
            this.gps2Label.AutoSize = true;
            this.gps2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gps2Label.Location = new System.Drawing.Point(6, 244);
            this.gps2Label.Name = "gps2Label";
            this.gps2Label.Size = new System.Drawing.Size(42, 46);
            this.gps2Label.TabIndex = 6;
            this.gps2Label.Text = "0";
            // 
            // gps1Label
            // 
            this.gps1Label.AutoSize = true;
            this.gps1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gps1Label.Location = new System.Drawing.Point(6, 198);
            this.gps1Label.Name = "gps1Label";
            this.gps1Label.Size = new System.Drawing.Size(42, 46);
            this.gps1Label.TabIndex = 5;
            this.gps1Label.Text = "0";
            // 
            // gpsLblLabel
            // 
            this.gpsLblLabel.AutoSize = true;
            this.gpsLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpsLblLabel.Location = new System.Drawing.Point(8, 167);
            this.gpsLblLabel.Name = "gpsLblLabel";
            this.gpsLblLabel.Size = new System.Drawing.Size(79, 31);
            this.gpsLblLabel.TabIndex = 4;
            this.gpsLblLabel.Text = "GPS:";
            // 
            // heightbarLabel
            // 
            this.heightbarLabel.AutoSize = true;
            this.heightbarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightbarLabel.Location = new System.Drawing.Point(6, 121);
            this.heightbarLabel.Name = "heightbarLabel";
            this.heightbarLabel.Size = new System.Drawing.Size(42, 46);
            this.heightbarLabel.TabIndex = 3;
            this.heightbarLabel.Text = "0";
            // 
            // heightbarLblLabel
            // 
            this.heightbarLblLabel.AutoSize = true;
            this.heightbarLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightbarLblLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.heightbarLblLabel.Location = new System.Drawing.Point(6, 90);
            this.heightbarLblLabel.Name = "heightbarLblLabel";
            this.heightbarLblLabel.Size = new System.Drawing.Size(115, 31);
            this.heightbarLblLabel.TabIndex = 2;
            this.heightbarLblLabel.Text = "Высота:";
            this.heightbarLblLabel.Click += new System.EventHandler(this.heightbarLblLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(6, 44);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(42, 46);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "0";
            // 
            // timeLblLabel
            // 
            this.timeLblLabel.AutoSize = true;
            this.timeLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLblLabel.Location = new System.Drawing.Point(3, 13);
            this.timeLblLabel.Name = "timeLblLabel";
            this.timeLblLabel.Size = new System.Drawing.Size(104, 31);
            this.timeLblLabel.TabIndex = 0;
            this.timeLblLabel.Text = "Время:";
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.dataTab);
            this.mainTabs.Controls.Add(this.tableTab);
            this.mainTabs.Controls.Add(this.setTab);
            this.mainTabs.Location = new System.Drawing.Point(12, 12);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(442, 325);
            this.mainTabs.TabIndex = 0;
            // 
            // OpenCharts
            // 
            this.OpenCharts.Location = new System.Drawing.Point(471, 254);
            this.OpenCharts.Name = "OpenCharts";
            this.OpenCharts.Size = new System.Drawing.Size(175, 21);
            this.OpenCharts.TabIndex = 10;
            this.OpenCharts.Text = "Графики";
            this.OpenCharts.UseVisualStyleBackColor = true;
            this.OpenCharts.Click += new System.EventHandler(this.OpenChart_Click);
            // 
            // OpenMonitor
            // 
            this.OpenMonitor.Location = new System.Drawing.Point(471, 227);
            this.OpenMonitor.Name = "OpenMonitor";
            this.OpenMonitor.Size = new System.Drawing.Size(175, 21);
            this.OpenMonitor.TabIndex = 11;
            this.OpenMonitor.Text = "Монитор (в отдельном окне)";
            this.OpenMonitor.UseVisualStyleBackColor = true;
            this.OpenMonitor.Click += new System.EventHandler(this.OpenMonitor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 341);
            this.Controls.Add(this.OpenMonitor);
            this.Controls.Add(this.OpenCharts);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.mainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RosCanSat Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.setTab.ResumeLayout(false);
            this.setTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialBaud)).EndInit();
            this.tableTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoBox;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TabPage setTab;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button serialSend;
        private System.Windows.Forms.TextBox serialMessage;
        private System.Windows.Forms.RichTextBox serialLog;
        private System.Windows.Forms.Button serialStop;
        private System.Windows.Forms.Button serialRenew;
        private System.Windows.Forms.Button serialStart;
        private System.Windows.Forms.Label serialBaudLabel;
        private System.Windows.Forms.NumericUpDown serialBaud;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.ComboBox serialPorts;
        private System.Windows.Forms.TabPage tableTab;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.Label phaseLblLabel;
        private System.Windows.Forms.Label phaseLabel;
        private System.Windows.Forms.Label gps2Label;
        private System.Windows.Forms.Label gps1Label;
        private System.Windows.Forms.Label gpsLblLabel;
        private System.Windows.Forms.Label heightbarLabel;
        private System.Windows.Forms.Label heightbarLblLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLblLabel;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.Button OpenCharts;
        private System.Windows.Forms.Button OpenMonitor;
        private System.Windows.Forms.CheckBox splitbysemicolonSw;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label speedLblLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn spd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn phase;
    }
}

