using System.Globalization;
using System.Runtime.CompilerServices;
using System.Management;
using System.Text.RegularExpressions;
using System.IO.Ports;

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

            /*
            foreach (string password in passwords)
            {
                text = text.Replace(password, new string('*', password.Length));
            }
            */

            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action(() => {
                    richTextBox1.AppendText(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{number} | " + text + Environment.NewLine);
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    richTextBox1.ScrollToCaret();
                    this.Refresh();
                }));
            } else
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
            debug($"SERIAL DATA RECV: {indata}");
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
                    sp = getSerialData(commInterface, 9600, Parity.None, 8, StopBits.One);
                    break;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            getSerialDevices();
        }

        private void closeSerialConnButton_Click(object sender, EventArgs e)
        {
            debug($"Closing serial interface: {sp.PortName}");
            if (sp.IsOpen)
            {
                sp.Close();
            } else
            {
                debug($"No serial port open");
            }
        }
    }
}
