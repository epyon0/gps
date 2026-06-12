using System.Globalization;
using System.Runtime.CompilerServices;
using System.Management;
using System.Text.RegularExpressions;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace gps
{

    public partial class Form1 : Form
    {

        List<string> commInterfaces = new List<string>();
        SerialPort sp = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }
        private void debug(string text, [CallerMemberName] string caller = "", [CallerLineNumber] int number = 0)
        {
            DateTime now = DateTime.Now;

            /*
            if (richTextBox1.TextLength + text.Length >= richTextBox1.MaxLength)
            {
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke(new Action(() => richTextBox1.Clear()));
                } else
                {
                    richTextBox1.Clear();
                }
            }
            */

            /*
            foreach (string password in passwords)
            {
                text = text.Replace(password, new string('*', password.Length));
            }
            */

            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{number} | " + text + Environment.NewLine);
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    richTextBox1.ScrollToCaret();
                    this.Refresh();
                }));
            }
            else
            {
                richTextBox1.AppendText(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{number} | " + text + Environment.NewLine);
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();
                this.Refresh();
            }
        }

        private void getSerialDevices()
        {
            commInterfaces.Clear();
            commComboBox.Items.Clear();
            debug("Getting COMM devices");
            commInterfaces = SerialPort.GetPortNames().ToList<string>();

            foreach (string commInterface in commInterfaces)
            {
                commComboBox.Items.Add(commInterface);
            }
            commComboBox.SelectedIndex = 0;
        }

        private SerialPort getSerialData(string device, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            SerialPort serialport = new SerialPort(device, baudRate, parity, dataBits, stopBits);
            serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            debug($"Opening serial interface: {device}");
            if (sp.IsOpen)
            {
                debug($"Serial port already open");
                return sp;
            }

            serialport.Open();
            return serialport;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            debug($"RECV:{Environment.NewLine}{indata}");

            foreach (string line in indata.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                if (line.StartsWith("$GPGGA,"))
                {
                    List<string> gpgga = line.Split(',').ToList();
                    string time = gpgga[1];
                    string lat = gpgga[2];
                    string NS = gpgga[3];
                    string lon = gpgga[4];
                    string EW = gpgga[5];
                    string fix = gpgga[6].Trim();
                    string sats = gpgga[7];
                    string hdop = gpgga[8];
                    string altitude = gpgga[9];
                    string units = gpgga[10];
                    string geoid = gpgga[11];
                    string geoidUnits = gpgga[12];
                    string age = gpgga[13];
                    string stationId = gpgga[14].Trim().Split('*')[0];
                    string chksum = gpgga[14].Trim().Split('*')[1];

                    if (timeLabel.InvokeRequired)
                    {
                        timeLabel.Invoke(new Action(() =>
                        {
                            timeLabel.Text = $"Time (UTC): {time[0]}{time[1]}:{time[2]}{time[3]}:{time[4]}{time[5]}{time[6]}{time[7]}{time[8]}";
                        }));
                    }
                    else
                    {
                        timeLabel.Text = $"Time (UTC): {time[0]}{time[1]}:{time[2]}{time[3]}:{time[4]}{time[5]}{time[6]}{time[7]}{time[8]}";
                    }

                    if (latLabel.InvokeRequired)
                    {
                        latLabel.Invoke(new Action(() =>
                        {
                            latLabel.Text = $"Latitude: {lat[0]}{lat[1]}º {lat[2]}{lat[3]}{lat[4]}{lat[5]}{lat[6]}{lat[7]}{lat[8]} {NS}";
                        }));
                    }
                    else
                    {
                        latLabel.Text = $"Latitude: {lat[0]}{lat[1]}º {lat[2]}{lat[3]}{lat[4]}{lat[5]}{lat[6]}{lat[7]}{lat[8]} {NS}";
                    }

                    if (lonLabel.InvokeRequired)
                    {
                        lonLabel.Invoke(new Action(() =>
                        {
                            lonLabel.Text = $"Longitude: {lon[0]}{lon[1]}{lon[2]}º {lon[3]}{lon[4]}{lon[5]}{lon[6]}{lon[7]}{lon[8]} {EW}";
                        }));
                    }
                    else
                    {
                        lonLabel.Text = $"Longitude: {lon[0]}{lon[1]}{lon[2]}º {lon[3]}{lon[4]}{lon[5]}{lon[6]}{lon[7]}{lon[8]} {EW}";
                    }

                    if (fixLabel.InvokeRequired)
                    {
                        fixLabel.Invoke(new Action(() =>
                        {
                            switch (fix)
                            {
                                case "0":
                                    fixLabel.Text = "Fix: Unvailable/Invlaid";
                                    break;
                                case "1":
                                    fixLabel.Text = "Fix: GPS SPS Mode VALID";
                                    break;
                                case "2":
                                    fixLabel.Text = "Fix: Diff GPS, SPS Mode, VALID";
                                    break;
                                case "6":
                                    fixLabel.Text = "Fix: Dead Reckoning Mode VALID";
                                    break;
                                default:
                                    fixLabel.Text = "Fix: Not Supported";
                                    break;
                            }
                        }));
                    }
                    else
                    {
                        switch (fix)
                        {
                            case "0":
                                fixLabel.Text = "Fix: Unvailable/Invlaid";
                                break;
                            case "1":
                                fixLabel.Text = "Fix: GPS SPS Mode VALID";
                                break;
                            case "2":
                                fixLabel.Text = "Fix: Diff GPS, SPS Mode, VALID";
                                break;
                            case "6":
                                fixLabel.Text = "Fix: Dead Reckoning Mode VALID";
                                break;
                            default:
                                fixLabel.Text = "Fix: Not Supported";
                                break;
                        }
                    }

                    if (satLabel.InvokeRequired)
                    {
                        satLabel.Invoke(new Action(() =>
                        {
                            satLabel.Text = $"Satellites: {sats}";
                        }));
                    }
                    else
                    {
                        satLabel.Text = $"Satellites: {sats}";
                    }

                    if (hdopLabel.InvokeRequired)
                    {
                        hdopLabel.Invoke(new Action(() =>
                        {
                            hdopLabel.Text = $"HDOP: {hdop}";
                        }));
                    }
                    else
                    {
                        hdopLabel.Text = $"HDOP: {hdop}";
                    }

                    if (altitudeLabel.InvokeRequired)
                    {
                        altitudeLabel.Invoke(new Action(() =>
                        {
                            altitudeLabel.Text = $"Altitude: {altitude} {units}";
                        }));
                    }
                    else
                    {
                        altitudeLabel.Text = $"Altitude: {altitude} {units}";
                    }

                    if (geoidSepLabel.InvokeRequired)
                    {
                        geoidSepLabel.Invoke(new Action(() =>
                        {
                            geoidSepLabel.Text = $"Geoid Sep: {geoid} {geoidUnits}";
                        }));
                    }
                    else
                    {
                        geoidSepLabel.Text = $"Geoid Sep: {geoid} {geoidUnits}";
                    }

                    if (stationLabel.InvokeRequired)
                    {
                        stationLabel.Invoke(new Action(() =>
                        {
                            stationLabel.Text = $"Station ID: {stationId}";
                        }));
                    }
                    else
                    {
                        stationLabel.Text = $"Station ID: {stationId}";
                    }

                    if (ageLabel.InvokeRequired)
                    {
                        ageLabel.Invoke(new Action(() =>
                        {
                            ageLabel.Text = $"Age of diff. corr.: {age}";
                        }));
                    }
                    else
                    {
                        ageLabel.Text = $"Age of diff. corr.: {age}";
                    }

                    if (chksumLabel.InvokeRequired)
                    {
                        chksumLabel.Invoke(new Action(() =>
                        {
                            chksumLabel.Text = $"Checksum: {chksum}";
                        }));
                    }
                    else
                    {
                        chksumLabel.Text = $"Checksum: {chksum}";
                    }
                }

                if (line.StartsWith("$GPGSA"))
                {
                    List<string> gpgsa = line.Split(',').ToList();
                    string modeMA = gpgsa[1].Trim();
                    string mode123 = gpgsa[2].Trim();

                    if (modeMA == "M") { modeMA = "Manual"; }
                    if (modeMA == "A") { modeMA = "Automatic"; }
                    if (mode123 == "1") { mode123 = "Fix Unavailable"; }
                    if (mode123 == "2") { mode123 = "2D"; }
                    if (mode123 == "3") { mode123 = "3D"; }

                    List<string> prns = new List<string>();
                    for (int i = 3; i <= 14; i++)
                    {
                        if (gpgsa[i].Trim() != "")
                        {
                            prns.Add(gpgsa[i]);
                        }
                    }
                    string pdop = gpgsa[15];
                    string hdop = gpgsa[16];
                    string vdop = gpgsa[17].Trim().Split('*')[0];
                    // not reciever not showing gnss id field for some reason, probaly NMEA version
                    //string systemId = gpgsa[18];
                    string chksum = gpgsa[17].Trim().Split('*')[1];

                    if (modeLabel.InvokeRequired)
                    {
                        modeLabel.Invoke(new Action(() =>
                        {
                            modeLabel.Text = $"Mode: {mode123} {modeMA}";
                        }));
                    }
                    else
                    {
                        modeLabel.Text = $"Mode: {mode123} {modeMA}";
                    }

                    for (int i = 0; i < prns.Count; i++)
                    {
                        if (int.Parse(prns[i]) >= 0 && int.Parse(prns[i]) < 33)
                        {
                            prns[i] += " [GPS]";
                            continue;
                        }
                        if (int.Parse(prns[i]) >= 33 && int.Parse(prns[i]) < 65)
                        {
                            prns[i] += " [SBAS]";
                            continue;
                        }
                        if (int.Parse(prns[i]) >= 65)
                        {
                            prns[i] += " [GLO]";
                            continue;
                        }
                    }

                    if (prnLabel.InvokeRequired)
                    {
                        prnLabel.Invoke(new Action(() =>
                        {
                            prnLabel.Text = "PRN: ";
                            foreach (string prn in prns)
                            {
                                prnLabel.Text += $" {prn}";
                            }
                        }));
                    }
                    else
                    {
                        prnLabel.Text = "PRN: ";
                        foreach (string prn in prns)
                        {
                            prnLabel.Text += $" {prn}";
                        }
                    }

                    if (pdopLabel.InvokeRequired)
                    {
                        pdopLabel.Invoke(new Action(() =>
                        {
                            pdopLabel.Text = $"PDOP: {pdop}";
                        }));
                    }
                    else
                    {
                        pdopLabel.Text = $"PDOP: {pdop}";
                    }

                    if (hdop2Label.InvokeRequired)
                    {
                        hdop2Label.Invoke(new Action(() =>
                        {
                            hdop2Label.Text = $"HDOP: {hdop}";
                        }));
                    }
                    else
                    {
                        hdop2Label.Text = $"HDOP: {hdop}";
                    }

                    if (vdopLabel.InvokeRequired)
                    {
                        vdopLabel.Invoke(new Action(() =>
                        {
                            vdopLabel.Text = $"VDOP: {vdop}";
                        }));
                    }
                    else
                    {
                        vdopLabel.Text = $"VDOP: {vdop}";
                    }

                    if (chksum3Label.InvokeRequired)
                    {
                        chksum3Label.Invoke(new Action(() =>
                        {
                            chksum3Label.Text = $"Checksum: {chksum}";
                        }));
                    }
                    else
                    {
                        chksum3Label.Text = $"Checksum: {chksum}";
                    }
                }

                if (line.StartsWith("$GPGSV"))
                {
                    List<string> gpgsv = line.Split(',').ToList();
                    string msgNum = gpgsv[1];
                    string msg = gpgsv[2].Trim();
                    string sats = gpgsv[3];
                    string prn = String.Empty;
                    string elevation = String.Empty;
                    string azimuth = String.Empty;
                    string snr = String.Empty;
                    
                    for (int i = 4; i < (gpgsv.Count - 1); i += 4)
                    {
                        if (!gpgsv[i].Contains('*')) { prn += line[i] + ", "; }
                        if ((i + 1) < (line.Length - 1) && !gpgsv[i + 1].Contains('*')) { elevation += gpgsv[i + 1] + ", "; }
                        if ((i + 2) < (line.Length - 1) && !gpgsv[i + 2].Contains('*')) { azimuth   += gpgsv[i + 2] + "°, "; }
                        if ((i + 3) < (line.Length - 1 )&& !gpgsv[i + 3].Contains('*')) { snr       += gpgsv[i + 3] + ", "; }
                    }

                    string gnssId = gpgsv.Last<string>().Split('*')[0];
                    string chksum = gpgsv.Last<string>().Split('*')[1];

                    string[] subItems = { msg, prn, elevation, azimuth, snr, gnssId, chksum };
                    ListViewItem lvi = new ListViewItem(subItems);
                    if (listView1.InvokeRequired)
                    {
                        listView1.Invoke(new Action(() =>
                        {
                            listView1.Items.RemoveAt(int.Parse(msg) - 1);
                            listView1.Items.Insert(int.Parse(msg) - 1, lvi);

                            for (int i = 1; i < listView1.Columns.Count; i++)
                            {
                                if (i == 1 || i == 2 || i == 3 || i == 4)
                                {
                                    listView1.Columns[i].Width = -1;
                                } else
                                {
                                    listView1.Columns[i].Width = -2;
                                }
                                
                            }
                        }));
                    } else
                    {
                        listView1.Items.RemoveAt(int.Parse(msg));
                        listView1.Items.Insert(int.Parse(msg), lvi);
                    }

                    if (msgNum6Label.InvokeRequired)
                    {
                        msgNum6Label.Invoke(new Action(() =>
                        {
                            msgNum6Label.Text = $"Message Number: {msgNum}";
                        }));
                    }
                    else
                    {
                        msgNum6Label.Text = $"Message Number: {msgNum}";
                    }

                    if (satsInView6Label.InvokeRequired)
                    {
                        satsInView6Label.Invoke(new Action(() =>
                        {
                            satsInView6Label.Text = $"Satellites In View: {sats}";
                        }));
                    } else
                    {
                        satsInView6Label.Text = $"Satellites In View: {sats}";
                    }
                }

                if (line.StartsWith("$GPGLL"))
                {
                    List<string> gpgll = line.Split(',').ToList();
                    string lat = gpgll[1];
                    string NS = gpgll[2];
                    string lon = gpgll[3];
                    string EW = gpgll[4];
                    string time = gpgll[5];
                    string status = gpgll[6].Trim();
                    if (status == "A") { status = "Valid"; }
                    if (status == "V") { status = "Invalid"; }
                    string mode = gpgll[7].Trim();
                    mode = mode.Split('*')[0];
                    if (mode == "A") { mode = "Autonomous"; }
                    if (mode == "D") { mode = "DGPS"; }
                    if (mode == "E") { mode = "DR"; }
                    string chksum = gpgll[7].Trim().Split('*')[1];

                    if (lat2Label.InvokeRequired)
                    {
                        lat2Label.Invoke(new Action(() =>
                        {
                            lat2Label.Text = $"Latitude: {lat.Substring(0, 2)}º {lat.Substring(2)} {NS}";
                        }));
                    }
                    else
                    {
                        lat2Label.Text = $"Latitude: {lat.Substring(0, 2)}º {lat.Substring(2)} {NS}";
                    }

                    if (lon2Label.InvokeRequired)
                    {
                        lon2Label.Invoke(new Action(() =>
                        {
                            lon2Label.Text = $"Longitude: {lon.Substring(0, 3)}º {lon.Substring(3)} {EW}";
                        }));
                    }
                    else
                    {
                        lon2Label.Text = $"Longitude: {lon.Substring(0, 3)}º {lon.Substring(3)} {EW}";
                    }

                    if (time2Label.InvokeRequired)
                    {
                        time2Label.Invoke(new Action(() =>
                        {
                            time2Label.Text = $"Time (UTC): {time.Substring(0, 2)}:{time.Substring(2, 2)}:{time.Substring(4)}";
                        }));
                    }
                    else
                    {
                        time2Label.Text = $"Time (UTC): {time.Substring(0, 2)}:{time.Substring(2, 2)}:{time.Substring(4)}";
                    }

                    if (status2Label.InvokeRequired)
                    {
                        status2Label.Invoke(new Action(() =>
                        {
                            status2Label.Text = $"Status: {status}";
                        }));
                    }
                    else
                    {
                        status2Label.Text = $"Status: {status}";
                    }

                    if (mode2Label.InvokeRequired)
                    {
                        mode2Label.Invoke(new Action(() =>
                        {
                            mode2Label.Text = $"Mode: {mode}";
                        }));
                    }
                    else
                    {
                        mode2Label.Text = $"Mode: {mode}";
                    }

                    if (chksum2Label.InvokeRequired)
                    {
                        chksum2Label.Invoke(new Action(() =>
                        {
                            chksum2Label.Text = $"Checksum: {chksum}";
                        }));
                    }
                    else
                    {
                        chksum2Label.Text = $"Checksum: {chksum}";
                    }
                }

                if (line.StartsWith("$GPRMC"))
                {
                    List<string> gpgrmc = line.Split(',').ToList();
                    string time = $"{gpgrmc[1].Substring(0, 2)}:{gpgrmc[1].Substring(2, 2)}:{gpgrmc[1].Substring(4)}";
                    string status = gpgrmc[2].Trim();
                    if (status == "A") { status = "Valid"; }
                    if (status == "V") { status = "Invalid"; }
                    string lat = $"{gpgrmc[3].Substring(0, 2)}º {gpgrmc[3].Substring(2)} {gpgrmc[4]}";
                    string lon = $"{gpgrmc[5].Substring(0, 3)}º {gpgrmc[5].Substring(3)} {gpgrmc[6]}";
                    string speed = $"{gpgrmc[7]} Kn";
                    string track = $"{gpgrmc[8].Trim()}";
                    if (track.Length != 0) { track += "º"; }
                    string date = $"{gpgrmc[9].Substring(0, 2)}/{gpgrmc[9].Substring(2, 2)}/{gpgrmc[9].Substring(4)}";
                    string mag = gpgrmc[10];
                    if (mag.Length != 0) { mag = $"{mag}º {gpgrmc[11]}"; }
                    string mode = gpgrmc[12].Trim().Split('*')[0];
                    if (mode == "A") { mode = "Autonomous"; }
                    if (mode == "D") { mode = "Differential"; }
                    if (mode == "E") { mode = "Estimated"; }
                    if (mode == "M") { mode = "Manual"; }
                    if (mode == "N") { mode = "Invalid"; }
                    string chksum = gpgrmc[12].Trim().Split('*')[1];

                    if (time4Label.InvokeRequired)
                    {
                        time4Label.Invoke(new Action(() =>
                        {
                            time4Label.Text = $"Time (UTC): {time}";
                        }));
                    }
                    else
                    {
                        time4Label.Text = $"Time (UTC): {time}";
                    }

                    if (status4Label.InvokeRequired)
                    {
                        status4Label.Invoke(new Action(() =>
                        {
                            status4Label.Text = $"Status: {status}";
                        }));
                    }
                    else
                    {
                        status4Label.Text = $"Status: {status}";
                    }

                    if (lat4Label.InvokeRequired)
                    {
                        lat4Label.Invoke(new Action(() =>
                        {
                            lat4Label.Text = $"Latitude: {lat}";
                        }));
                    }
                    else
                    {
                        lat4Label.Text = $"Latitude: {lat}";
                    }

                    if (lon4Label.InvokeRequired)
                    {
                        lon4Label.Invoke(new Action(() =>
                        {
                            lon4Label.Text = $"Longitude: {lon}";
                        }));
                    }
                    else
                    {
                        lon4Label.Text = $"Longitude: {lon}";
                    }

                    if (speed4Label.InvokeRequired)
                    {
                        speed4Label.Invoke(new Action(() =>
                        {
                            speed4Label.Text = $"Speed: {speed}";
                        }));
                    }
                    else
                    {
                        speed4Label.Text = $"Speed: {speed}";
                    }

                    if (trueTrack4Label.InvokeRequired)
                    {
                        trueTrack4Label.Invoke(new Action(() =>
                        {
                            trueTrack4Label.Text = $"True Track: {track}";
                        }));
                    }
                    else
                    {
                        trueTrack4Label.Text = $"True Track: {track}";
                    }

                    if (magVar4Label.InvokeRequired)
                    {
                        magVar4Label.Invoke(new Action(() =>
                        {
                            magVar4Label.Text = $"Magnetic Variation: {mag}";
                        }));
                    }
                    else
                    {
                        magVar4Label.Text = $"Magnetic Variation: {mag}";
                    }

                    if (date4Label.InvokeRequired)
                    {
                        date4Label.Invoke(new Action(() =>
                        {
                            date4Label.Text = $"Date: {date}";
                        }));
                    }
                    else
                    {
                        date4Label.Text = $"Date: {date}";
                    }

                    if (mode4Label.InvokeRequired)
                    {
                        mode4Label.Invoke(new Action(() =>
                        {
                            mode4Label.Text = $"Mode: {mode}";
                        }));
                    }
                    else
                    {
                        mode4Label.Text = $"Mode: {mode}";
                    }

                    if (chksum4Label.InvokeRequired)
                    {
                        chksum4Label.Invoke(new Action(() =>
                        {
                            chksum4Label.Text = $"Checksum: {chksum}";
                        }));
                    }
                    else
                    {
                        chksum4Label.Text = $"Checksum: {chksum}";
                    }
                }

                if (line.StartsWith("$GPVTG"))
                {
                    List<string> gpvtg = line.Split(',').ToList();
                    string course = gpvtg[1];
                    string refer = gpvtg[2].Trim();
                    if (refer == "T") { refer = "True Course"; }
                    string degrees = gpvtg[3].Trim();
                    if (gpvtg[4].Trim() == "M") { refer += " " + "(Magnetic)"; }
                    string speed = gpvtg[5];
                    speed += " " + gpvtg[6];
                    string speed2 = gpvtg[7];
                    speed2 += " " + gpvtg[8];
                    string mode = gpvtg[9].Split('*')[0].Trim();
                    if (mode == "A") { mode = "Autonomous"; }
                    if (mode == "D") { mode = "DGPS"; }
                    if (mode == "E") { mode = "DR"; }
                    string chksum = gpvtg[9].Split('*')[1];

                    if (course5Label.InvokeRequired)
                    {
                        course5Label.Invoke(new Action(() =>
                        {
                            course5Label.Text = $"Course: {course}";
                        }));
                    }
                    else
                    {
                        course5Label.Text = $"Course: {course}";
                    }

                    if (reference5Label.InvokeRequired)
                    {
                        reference5Label.Invoke(new Action(() =>
                        {
                            reference5Label.Text = $"Reference: {refer}";
                        }));
                    } else
                    {
                        reference5Label.Text = $"Reference: {refer}";
                    }

                    if (degrees5Label.InvokeRequired)
                    {
                        degrees5Label.Invoke(new Action(() =>
                        {
                            if (degrees != String.Empty) { degrees5Label.Text = $"Degrees: {degrees}°"; } else { degrees5Label.Text = "Degrees:"; }
                        }));
                    } else
                    {
                        if (degrees != String.Empty) { degrees5Label.Text = $"Degrees: {degrees}°"; } else { degrees5Label.Text = "Degrees:"; }
                    }

                    if (speed5Label.InvokeRequired)
                    {
                        speed5Label.Invoke(new Action(() =>
                        {
                            speed5Label.Text = $"Speed: {speed}";
                        }));
                    } else
                    {
                        speed5Label.Text = $"Speed: {speed}";
                    }

                    if (speed52Label.InvokeRequired)
                    {
                        speed52Label.Invoke(new Action(() =>
                        {
                            speed52Label.Text = $"Speed {speed2}";
                        }));
                    } else
                    {
                        speed52Label.Text = $"Speed {speed2}";
                    }

                    if (mode5Label.InvokeRequired)
                    {
                        mode5Label.Invoke(new Action(() =>
                        {
                            mode5Label.Text = $"Mode: {mode}";
                        }));
                    } else
                    {
                        mode5Label.Text = $"Mode: {mode}";
                    }

                    if (chksum5Label.InvokeRequired)
                    {
                        chksum5Label.Invoke(new Action(() =>
                        {
                            chksum5Label.Text = $"Checksum: {chksum}";
                        }));
                    } else
                    {
                        chksum5Label.Text = $"Checksum: {chksum}";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            debug("Form loaded");
        }

        private void refreshCommInterfacesButton_Click(object sender, EventArgs e)
        {
            refreshCommInterfacesButton.Enabled = false;
            commComboBox.Enabled = false;
            getSerialDevices();
            refreshCommInterfacesButton.Enabled = true;
            commComboBox.Enabled = true;
        }

        private void getSerialDataButton_Click(object sender, EventArgs e)
        {
            foreach (string commInterface in commInterfaces)
            {
                if (commInterface == commComboBox.SelectedItem.ToString())
                {
                    int baud = 9600;
                    Parity parity = Parity.None;
                    int dataBits = 8;
                    StopBits stopBits = StopBits.One;

                    switch (parityComboBox.SelectedItem.ToString())
                    {
                        case "None":
                            parity = Parity.None;
                            break;
                        case "Odd":
                            parity = Parity.Odd;
                            break;
                        case "Even":
                            parity = Parity.Even;
                            break;
                        case "Mark":
                            parity = Parity.Mark;
                            break;
                        case "Space":
                            parity = Parity.Space;
                            break;
                        default:
                            parity = Parity.None;
                            break;
                    }

                    switch (stopBitsComboBox.SelectedItem.ToString())
                    {
                        case "None":
                            stopBits = StopBits.None;
                            break;
                        case "1":
                            stopBits = StopBits.One;
                            break;
                        case "1.5":
                            stopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            stopBits = StopBits.Two;
                            break;
                        default:
                            stopBits = StopBits.One;
                            break;
                    }

                    debug($"Connecting with parameters:");
                    debug($"  Device: {commInterface}");
                    debug($"  Baud: {int.Parse(baudNumericUpDown.Value.ToString())}");
                    debug($"  Parity: {parity.ToString()}");
                    debug($"  Data Bits: {int.Parse(dataBitsNumericUpDown.Value.ToString())}");
                    debug($"  Stop Bits: {stopBits.ToString()}");
                    sp = getSerialData(commInterface, int.Parse(baudNumericUpDown.Value.ToString()), parity, int.Parse(dataBitsNumericUpDown.Value.ToString()), stopBits);

                    debug($"Paramters configured:");
                    debug($"  Device: {sp.PortName}");
                    debug($"  Baud: {sp.BaudRate}");
                    debug($"  Parity: {sp.Parity}");
                    debug($"  Data Bits: {sp.DataBits}");
                    debug($"  Stop Bits: {sp.StopBits}");
                    break;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            parityComboBox.SelectedIndex = 0;
            stopBitsComboBox.SelectedIndex = 1;
            for (int i = 0; i < 9; i++)
            {
                listView1.Items.Add($"{i+1}");
            }
            getSerialDevices();
        }

        private void closeSerialConnButton_Click(object sender, EventArgs e)
        {
            debug($"Closing serial interface: {sp.PortName}");
            if (sp.IsOpen)
            {
                sp.Close();
                sp.Dispose();
            }
            else
            {
                debug($"No serial port open");
            }
        }
    }
}
