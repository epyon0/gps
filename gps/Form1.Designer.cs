namespace gps
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
            richTextBox1 = new RichTextBox();
            commComboBox = new ComboBox();
            refreshCommInterfacesButton = new Button();
            getSerialDataButton = new Button();
            closeSerialConnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            baudNumericUpDown = new NumericUpDown();
            dataBitsNumericUpDown = new NumericUpDown();
            parityComboBox = new ComboBox();
            stopBitsComboBox = new ComboBox();
            timeLabel = new Label();
            latLabel = new Label();
            lonLabel = new Label();
            groupBox1 = new GroupBox();
            ageLabel = new Label();
            stationLabel = new Label();
            chksumLabel = new Label();
            geoidSepLabel = new Label();
            altitudeLabel = new Label();
            hdopLabel = new Label();
            satLabel = new Label();
            fixLabel = new Label();
            groupBox2 = new GroupBox();
            chksum3Label = new Label();
            gnssIdLabel = new Label();
            vdopLabel = new Label();
            hdop2Label = new Label();
            modeLabel = new Label();
            pdopLabel = new Label();
            prnLabel = new Label();
            groupBox3 = new GroupBox();
            chksum2Label = new Label();
            mode2Label = new Label();
            status2Label = new Label();
            lat2Label = new Label();
            time2Label = new Label();
            lon2Label = new Label();
            groupBox4 = new GroupBox();
            chksum4Label = new Label();
            mode4Label = new Label();
            magVar4Label = new Label();
            date4Label = new Label();
            trueTrack4Label = new Label();
            speed4Label = new Label();
            lon4Label = new Label();
            time4Label = new Label();
            lat4Label = new Label();
            status4Label = new Label();
            groupBox5 = new GroupBox();
            chksum5Label = new Label();
            mode5Label = new Label();
            speed52Label = new Label();
            speed5Label = new Label();
            course5Label = new Label();
            degrees5Label = new Label();
            reference5Label = new Label();
            groupBox6 = new GroupBox();
            msgNum6Label = new Label();
            satsInView6Label = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)baudNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataBitsNumericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Lime;
            richTextBox1.Location = new Point(12, 585);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1418, 333);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // commComboBox
            // 
            commComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            commComboBox.FlatStyle = FlatStyle.Flat;
            commComboBox.FormattingEnabled = true;
            commComboBox.Location = new Point(110, 12);
            commComboBox.Name = "commComboBox";
            commComboBox.Size = new Size(156, 19);
            commComboBox.TabIndex = 1;
            // 
            // refreshCommInterfacesButton
            // 
            refreshCommInterfacesButton.FlatStyle = FlatStyle.Flat;
            refreshCommInterfacesButton.Location = new Point(12, 173);
            refreshCommInterfacesButton.Name = "refreshCommInterfacesButton";
            refreshCommInterfacesButton.Size = new Size(254, 23);
            refreshCommInterfacesButton.TabIndex = 2;
            refreshCommInterfacesButton.Text = "Refresh";
            refreshCommInterfacesButton.UseVisualStyleBackColor = true;
            refreshCommInterfacesButton.Click += refreshCommInterfacesButton_Click;
            // 
            // getSerialDataButton
            // 
            getSerialDataButton.FlatStyle = FlatStyle.Flat;
            getSerialDataButton.Location = new Point(12, 202);
            getSerialDataButton.Name = "getSerialDataButton";
            getSerialDataButton.Size = new Size(75, 23);
            getSerialDataButton.TabIndex = 3;
            getSerialDataButton.Text = "Connect";
            getSerialDataButton.UseVisualStyleBackColor = true;
            getSerialDataButton.Click += getSerialDataButton_Click;
            // 
            // closeSerialConnButton
            // 
            closeSerialConnButton.FlatStyle = FlatStyle.Flat;
            closeSerialConnButton.Location = new Point(191, 202);
            closeSerialConnButton.Name = "closeSerialConnButton";
            closeSerialConnButton.Size = new Size(75, 23);
            closeSerialConnButton.TabIndex = 4;
            closeSerialConnButton.Text = "Close";
            closeSerialConnButton.UseVisualStyleBackColor = true;
            closeSerialConnButton.Click += closeSerialConnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(40, 11);
            label1.TabIndex = 5;
            label1.Text = "Baud:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 11);
            label2.TabIndex = 6;
            label2.Text = "Data Bits:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 11);
            label3.TabIndex = 7;
            label3.Text = "Stop Bits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(54, 11);
            label4.TabIndex = 8;
            label4.Text = "Parity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(75, 11);
            label6.TabIndex = 10;
            label6.Text = "Interface:";
            // 
            // baudNumericUpDown
            // 
            baudNumericUpDown.BorderStyle = BorderStyle.None;
            baudNumericUpDown.Location = new Point(110, 54);
            baudNumericUpDown.Maximum = new decimal(new int[] { 3000000, 0, 0, 0 });
            baudNumericUpDown.Name = "baudNumericUpDown";
            baudNumericUpDown.Size = new Size(156, 14);
            baudNumericUpDown.TabIndex = 11;
            baudNumericUpDown.Value = new decimal(new int[] { 9600, 0, 0, 0 });
            // 
            // dataBitsNumericUpDown
            // 
            dataBitsNumericUpDown.BorderStyle = BorderStyle.None;
            dataBitsNumericUpDown.Location = new Point(110, 84);
            dataBitsNumericUpDown.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            dataBitsNumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            dataBitsNumericUpDown.Name = "dataBitsNumericUpDown";
            dataBitsNumericUpDown.Size = new Size(156, 14);
            dataBitsNumericUpDown.TabIndex = 12;
            dataBitsNumericUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // parityComboBox
            // 
            parityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            parityComboBox.FlatStyle = FlatStyle.Flat;
            parityComboBox.FormattingEnabled = true;
            parityComboBox.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
            parityComboBox.Location = new Point(110, 143);
            parityComboBox.Name = "parityComboBox";
            parityComboBox.Size = new Size(156, 19);
            parityComboBox.TabIndex = 14;
            // 
            // stopBitsComboBox
            // 
            stopBitsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stopBitsComboBox.FlatStyle = FlatStyle.Flat;
            stopBitsComboBox.FormattingEnabled = true;
            stopBitsComboBox.Items.AddRange(new object[] { "None", "1", "1.5", "2" });
            stopBitsComboBox.Location = new Point(110, 113);
            stopBitsComboBox.Name = "stopBitsComboBox";
            stopBitsComboBox.Size = new Size(156, 19);
            stopBitsComboBox.TabIndex = 16;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(6, 14);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(82, 11);
            timeLabel.TabIndex = 17;
            timeLabel.Text = "Time (UTC):";
            // 
            // latLabel
            // 
            latLabel.AutoSize = true;
            latLabel.Location = new Point(6, 36);
            latLabel.Name = "latLabel";
            latLabel.Size = new Size(68, 11);
            latLabel.TabIndex = 18;
            latLabel.Text = "Latitude:";
            // 
            // lonLabel
            // 
            lonLabel.AutoSize = true;
            lonLabel.Location = new Point(6, 58);
            lonLabel.Name = "lonLabel";
            lonLabel.Size = new Size(75, 11);
            lonLabel.TabIndex = 19;
            lonLabel.Text = "Longitude:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ageLabel);
            groupBox1.Controls.Add(stationLabel);
            groupBox1.Controls.Add(chksumLabel);
            groupBox1.Controls.Add(geoidSepLabel);
            groupBox1.Controls.Add(altitudeLabel);
            groupBox1.Controls.Add(hdopLabel);
            groupBox1.Controls.Add(satLabel);
            groupBox1.Controls.Add(fixLabel);
            groupBox1.Controls.Add(timeLabel);
            groupBox1.Controls.Add(lonLabel);
            groupBox1.Controls.Add(latLabel);
            groupBox1.Location = new Point(272, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 254);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "GPGGA";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(6, 190);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(138, 11);
            ageLabel.TabIndex = 27;
            ageLabel.Text = "Age of diff. corr.:";
            // 
            // stationLabel
            // 
            stationLabel.AutoSize = true;
            stationLabel.Location = new Point(6, 212);
            stationLabel.Name = "stationLabel";
            stationLabel.Size = new Size(82, 11);
            stationLabel.TabIndex = 26;
            stationLabel.Text = "Station ID:";
            // 
            // chksumLabel
            // 
            chksumLabel.AutoSize = true;
            chksumLabel.Location = new Point(6, 234);
            chksumLabel.Name = "chksumLabel";
            chksumLabel.Size = new Size(68, 11);
            chksumLabel.TabIndex = 25;
            chksumLabel.Text = "Checksum:";
            // 
            // geoidSepLabel
            // 
            geoidSepLabel.AutoSize = true;
            geoidSepLabel.Location = new Point(6, 168);
            geoidSepLabel.Name = "geoidSepLabel";
            geoidSepLabel.Size = new Size(75, 11);
            geoidSepLabel.TabIndex = 24;
            geoidSepLabel.Text = "Geoid Sep:";
            // 
            // altitudeLabel
            // 
            altitudeLabel.AutoSize = true;
            altitudeLabel.Location = new Point(6, 146);
            altitudeLabel.Name = "altitudeLabel";
            altitudeLabel.Size = new Size(68, 11);
            altitudeLabel.TabIndex = 23;
            altitudeLabel.Text = "Altitude:";
            // 
            // hdopLabel
            // 
            hdopLabel.AutoSize = true;
            hdopLabel.Location = new Point(6, 124);
            hdopLabel.Name = "hdopLabel";
            hdopLabel.Size = new Size(40, 11);
            hdopLabel.TabIndex = 22;
            hdopLabel.Text = "HDOP:";
            // 
            // satLabel
            // 
            satLabel.AutoSize = true;
            satLabel.Location = new Point(6, 102);
            satLabel.Name = "satLabel";
            satLabel.Size = new Size(82, 11);
            satLabel.TabIndex = 21;
            satLabel.Text = "Satellites:";
            // 
            // fixLabel
            // 
            fixLabel.AutoSize = true;
            fixLabel.Location = new Point(6, 80);
            fixLabel.Name = "fixLabel";
            fixLabel.Size = new Size(33, 11);
            fixLabel.TabIndex = 20;
            fixLabel.Text = "Fix:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(chksum3Label);
            groupBox2.Controls.Add(gnssIdLabel);
            groupBox2.Controls.Add(vdopLabel);
            groupBox2.Controls.Add(hdop2Label);
            groupBox2.Controls.Add(modeLabel);
            groupBox2.Controls.Add(pdopLabel);
            groupBox2.Controls.Add(prnLabel);
            groupBox2.Location = new Point(532, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 180);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "GPGSA";
            // 
            // chksum3Label
            // 
            chksum3Label.AutoSize = true;
            chksum3Label.Location = new Point(6, 158);
            chksum3Label.Name = "chksum3Label";
            chksum3Label.Size = new Size(68, 11);
            chksum3Label.TabIndex = 23;
            chksum3Label.Text = "Checksum:";
            // 
            // gnssIdLabel
            // 
            gnssIdLabel.AutoSize = true;
            gnssIdLabel.Location = new Point(6, 134);
            gnssIdLabel.Name = "gnssIdLabel";
            gnssIdLabel.Size = new Size(61, 11);
            gnssIdLabel.TabIndex = 22;
            gnssIdLabel.Text = "GNSS ID:";
            // 
            // vdopLabel
            // 
            vdopLabel.AutoSize = true;
            vdopLabel.Location = new Point(6, 110);
            vdopLabel.Name = "vdopLabel";
            vdopLabel.Size = new Size(40, 11);
            vdopLabel.TabIndex = 21;
            vdopLabel.Text = "VDOP:";
            // 
            // hdop2Label
            // 
            hdop2Label.AutoSize = true;
            hdop2Label.Location = new Point(6, 86);
            hdop2Label.Name = "hdop2Label";
            hdop2Label.Size = new Size(40, 11);
            hdop2Label.TabIndex = 20;
            hdop2Label.Text = "HDOP:";
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Location = new Point(6, 14);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(40, 11);
            modeLabel.TabIndex = 17;
            modeLabel.Text = "Mode:";
            // 
            // pdopLabel
            // 
            pdopLabel.AutoSize = true;
            pdopLabel.Location = new Point(6, 62);
            pdopLabel.Name = "pdopLabel";
            pdopLabel.Size = new Size(40, 11);
            pdopLabel.TabIndex = 19;
            pdopLabel.Text = "PDOP:";
            // 
            // prnLabel
            // 
            prnLabel.AutoSize = true;
            prnLabel.Location = new Point(6, 38);
            prnLabel.Name = "prnLabel";
            prnLabel.Size = new Size(33, 11);
            prnLabel.TabIndex = 18;
            prnLabel.Text = "PRN:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chksum2Label);
            groupBox3.Controls.Add(mode2Label);
            groupBox3.Controls.Add(status2Label);
            groupBox3.Controls.Add(lat2Label);
            groupBox3.Controls.Add(time2Label);
            groupBox3.Controls.Add(lon2Label);
            groupBox3.Location = new Point(12, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(254, 156);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "GPGLL";
            // 
            // chksum2Label
            // 
            chksum2Label.AutoSize = true;
            chksum2Label.Location = new Point(6, 134);
            chksum2Label.Name = "chksum2Label";
            chksum2Label.Size = new Size(68, 11);
            chksum2Label.TabIndex = 22;
            chksum2Label.Text = "Checksum:";
            // 
            // mode2Label
            // 
            mode2Label.AutoSize = true;
            mode2Label.Location = new Point(6, 110);
            mode2Label.Name = "mode2Label";
            mode2Label.Size = new Size(40, 11);
            mode2Label.TabIndex = 21;
            mode2Label.Text = "Mode:";
            // 
            // status2Label
            // 
            status2Label.AutoSize = true;
            status2Label.Location = new Point(6, 86);
            status2Label.Name = "status2Label";
            status2Label.Size = new Size(54, 11);
            status2Label.TabIndex = 20;
            status2Label.Text = "Status:";
            // 
            // lat2Label
            // 
            lat2Label.AutoSize = true;
            lat2Label.Location = new Point(6, 14);
            lat2Label.Name = "lat2Label";
            lat2Label.Size = new Size(68, 11);
            lat2Label.TabIndex = 17;
            lat2Label.Text = "Latitude:";
            // 
            // time2Label
            // 
            time2Label.AutoSize = true;
            time2Label.Location = new Point(6, 62);
            time2Label.Name = "time2Label";
            time2Label.Size = new Size(82, 11);
            time2Label.TabIndex = 19;
            time2Label.Text = "Time (UTC):";
            // 
            // lon2Label
            // 
            lon2Label.AutoSize = true;
            lon2Label.Location = new Point(6, 38);
            lon2Label.Name = "lon2Label";
            lon2Label.Size = new Size(68, 11);
            lon2Label.TabIndex = 18;
            lon2Label.Text = "Longitude";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chksum4Label);
            groupBox4.Controls.Add(mode4Label);
            groupBox4.Controls.Add(magVar4Label);
            groupBox4.Controls.Add(date4Label);
            groupBox4.Controls.Add(trueTrack4Label);
            groupBox4.Controls.Add(speed4Label);
            groupBox4.Controls.Add(lon4Label);
            groupBox4.Controls.Add(time4Label);
            groupBox4.Controls.Add(lat4Label);
            groupBox4.Controls.Add(status4Label);
            groupBox4.Location = new Point(272, 272);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(254, 260);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "GPGRMC";
            // 
            // chksum4Label
            // 
            chksum4Label.AutoSize = true;
            chksum4Label.Location = new Point(6, 239);
            chksum4Label.Name = "chksum4Label";
            chksum4Label.Size = new Size(68, 11);
            chksum4Label.TabIndex = 26;
            chksum4Label.Text = "Checksum:";
            // 
            // mode4Label
            // 
            mode4Label.AutoSize = true;
            mode4Label.Location = new Point(6, 214);
            mode4Label.Name = "mode4Label";
            mode4Label.Size = new Size(40, 11);
            mode4Label.TabIndex = 25;
            mode4Label.Text = "Mode:";
            // 
            // magVar4Label
            // 
            magVar4Label.AutoSize = true;
            magVar4Label.Location = new Point(6, 189);
            magVar4Label.Name = "magVar4Label";
            magVar4Label.Size = new Size(138, 11);
            magVar4Label.TabIndex = 24;
            magVar4Label.Text = "Magnetic Variation:";
            // 
            // date4Label
            // 
            date4Label.AutoSize = true;
            date4Label.Location = new Point(6, 164);
            date4Label.Name = "date4Label";
            date4Label.Size = new Size(40, 11);
            date4Label.TabIndex = 23;
            date4Label.Text = "Date:";
            // 
            // trueTrack4Label
            // 
            trueTrack4Label.AutoSize = true;
            trueTrack4Label.Location = new Point(6, 139);
            trueTrack4Label.Name = "trueTrack4Label";
            trueTrack4Label.Size = new Size(82, 11);
            trueTrack4Label.TabIndex = 22;
            trueTrack4Label.Text = "True Track:";
            // 
            // speed4Label
            // 
            speed4Label.AutoSize = true;
            speed4Label.Location = new Point(6, 114);
            speed4Label.Name = "speed4Label";
            speed4Label.Size = new Size(47, 11);
            speed4Label.TabIndex = 21;
            speed4Label.Text = "Speed:";
            // 
            // lon4Label
            // 
            lon4Label.AutoSize = true;
            lon4Label.Location = new Point(6, 89);
            lon4Label.Name = "lon4Label";
            lon4Label.Size = new Size(75, 11);
            lon4Label.TabIndex = 20;
            lon4Label.Text = "Longitude:";
            // 
            // time4Label
            // 
            time4Label.AutoSize = true;
            time4Label.Location = new Point(6, 14);
            time4Label.Name = "time4Label";
            time4Label.Size = new Size(82, 11);
            time4Label.TabIndex = 17;
            time4Label.Text = "Time (UTC):";
            // 
            // lat4Label
            // 
            lat4Label.AutoSize = true;
            lat4Label.Location = new Point(6, 64);
            lat4Label.Name = "lat4Label";
            lat4Label.Size = new Size(68, 11);
            lat4Label.TabIndex = 19;
            lat4Label.Text = "Latitude:";
            // 
            // status4Label
            // 
            status4Label.AutoSize = true;
            status4Label.Location = new Point(6, 39);
            status4Label.Name = "status4Label";
            status4Label.Size = new Size(54, 11);
            status4Label.TabIndex = 18;
            status4Label.Text = "Status:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(chksum5Label);
            groupBox5.Controls.Add(mode5Label);
            groupBox5.Controls.Add(speed52Label);
            groupBox5.Controls.Add(speed5Label);
            groupBox5.Controls.Add(course5Label);
            groupBox5.Controls.Add(degrees5Label);
            groupBox5.Controls.Add(reference5Label);
            groupBox5.Location = new Point(12, 393);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(254, 186);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "GPVTG";
            // 
            // chksum5Label
            // 
            chksum5Label.AutoSize = true;
            chksum5Label.Location = new Point(6, 164);
            chksum5Label.Name = "chksum5Label";
            chksum5Label.Size = new Size(68, 11);
            chksum5Label.TabIndex = 23;
            chksum5Label.Text = "Checksum:";
            // 
            // mode5Label
            // 
            mode5Label.AutoSize = true;
            mode5Label.Location = new Point(6, 139);
            mode5Label.Name = "mode5Label";
            mode5Label.Size = new Size(40, 11);
            mode5Label.TabIndex = 22;
            mode5Label.Text = "Mode:";
            // 
            // speed52Label
            // 
            speed52Label.AutoSize = true;
            speed52Label.Location = new Point(6, 114);
            speed52Label.Name = "speed52Label";
            speed52Label.Size = new Size(47, 11);
            speed52Label.TabIndex = 21;
            speed52Label.Text = "Speed:";
            // 
            // speed5Label
            // 
            speed5Label.AutoSize = true;
            speed5Label.Location = new Point(6, 89);
            speed5Label.Name = "speed5Label";
            speed5Label.Size = new Size(47, 11);
            speed5Label.TabIndex = 20;
            speed5Label.Text = "Speed:";
            // 
            // course5Label
            // 
            course5Label.AutoSize = true;
            course5Label.Location = new Point(6, 14);
            course5Label.Name = "course5Label";
            course5Label.Size = new Size(54, 11);
            course5Label.TabIndex = 17;
            course5Label.Text = "Course:";
            // 
            // degrees5Label
            // 
            degrees5Label.AutoSize = true;
            degrees5Label.Location = new Point(6, 64);
            degrees5Label.Name = "degrees5Label";
            degrees5Label.Size = new Size(61, 11);
            degrees5Label.TabIndex = 19;
            degrees5Label.Text = "Degrees:";
            // 
            // reference5Label
            // 
            reference5Label.AutoSize = true;
            reference5Label.Location = new Point(6, 39);
            reference5Label.Name = "reference5Label";
            reference5Label.Size = new Size(75, 11);
            reference5Label.TabIndex = 18;
            reference5Label.Text = "Reference:";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(msgNum6Label);
            groupBox6.Controls.Add(satsInView6Label);
            groupBox6.Location = new Point(532, 201);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(209, 65);
            groupBox6.TabIndex = 28;
            groupBox6.TabStop = false;
            groupBox6.Text = "GPGSV";
            // 
            // msgNum6Label
            // 
            msgNum6Label.AutoSize = true;
            msgNum6Label.Location = new Point(6, 11);
            msgNum6Label.Name = "msgNum6Label";
            msgNum6Label.Size = new Size(110, 11);
            msgNum6Label.TabIndex = 17;
            msgNum6Label.Text = "Message Number:";
            // 
            // satsInView6Label
            // 
            satsInView6Label.AutoSize = true;
            satsInView6Label.Location = new Point(6, 38);
            satsInView6Label.Name = "satsInView6Label";
            satsInView6Label.Size = new Size(138, 11);
            satsInView6Label.TabIndex = 19;
            satsInView6Label.Text = "Satellites In View:";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(538, 272);
            listView1.Name = "listView1";
            listView1.Size = new Size(892, 296);
            listView1.TabIndex = 29;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MSG";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PRN";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Elevation";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Azimuth";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SNR";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "GNSS ID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "CHKSUM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 930);
            Controls.Add(listView1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(stopBitsComboBox);
            Controls.Add(parityComboBox);
            Controls.Add(dataBitsNumericUpDown);
            Controls.Add(baudNumericUpDown);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeSerialConnButton);
            Controls.Add(getSerialDataButton);
            Controls.Add(refreshCommInterfacesButton);
            Controls.Add(commComboBox);
            Controls.Add(richTextBox1);
            Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "GPS";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)baudNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataBitsNumericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox commComboBox;
        private Button refreshCommInterfacesButton;
        private Button getSerialDataButton;
        private Button closeSerialConnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label date4Label;
        private Label label6;
        private NumericUpDown baudNumericUpDown;
        private NumericUpDown dataBitsNumericUpDown;
        private ComboBox parityComboBox;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox stopBitsComboBox;
        private Label timeLabel;
        private Label latLabel;
        private Label lonLabel;
        private GroupBox groupBox1;
        private Label fixLabel;
        private Label satLabel;
        private Label hdopLabel;
        private Label altitudeLabel;
        private GroupBox groupBox2;
        private Label vdopLabel;
        private Label hdop2Label;
        private Label modeLabel;
        private Label pdopLabel;
        private Label prnLabel;
        private Label geoidSepLabel;
        private Label chksumLabel;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label chksum2Label;
        private Label time2Label;
        private Label status2Label;
        private Label mode2Label;
        private Label lat2Label;
        private Label lon2Label;
        private Label ageLabel;
        private Label stationLabel;
        private Label chksum3Label;
        private Label gnssIdLabel;
        private GroupBox groupBox4;
        private Label trueTrack4Label;
        private Label speed4Label;
        private Label lon4Label;
        private Label time4Label;
        private Label lat4Label;
        private Label status4Label;
        private Label chksum4Label;
        private Label mode4Label;
        private Label magVar4Label;
        private GroupBox groupBox5;
        private Label chksum5Label;
        private Label mode5Label;
        private Label speed52Label;
        private Label speed5Label;
        private Label course5Label;
        private Label degrees5Label;
        private Label reference5Label;
        private GroupBox groupBox6;
        private Label msgNum6Label;
        private Label satsInView6Label;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
