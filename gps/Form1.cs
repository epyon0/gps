using System.Globalization;
using System.Runtime.CompilerServices;
using System.Management;
using System.Text.RegularExpressions;

namespace gps
{

    public partial class Form1 : Form
    {

        List<SerialDevice> commInterfaces = new List<SerialDevice>();

        public Form1()
        {
            InitializeComponent();
        }
        private void debug(string text, [CallerMemberName] string caller = "", [CallerLineNumber] int number = 0)
        {
            DateTime now = DateTime.Now;

            if (richTextBox1.TextLength + text.Length >= richTextBox1.MaxLength)
            {
                richTextBox1.Clear();
            }

            /*
            foreach (string password in passwords)
            {
                text = text.Replace(password, new string('*', password.Length));
            }
            */

            richTextBox1.AppendText(now.ToString("yyyy-MM-ddTHH:mm:ss.fff K", CultureInfo.InvariantCulture) + $" | {caller}:{number} | " + text + Environment.NewLine);
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
            this.Refresh();
        }

        private List<SerialDevice> getSerialDevices()
        {
            debug("Getting serial devices");
            var devices = new List<SerialDevice>();
            var vidPattern = @"VID_([0-9A-F]{4})";
            var pidPattern = @"PID_([0-9A-F]{4})";

            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                foreach (ManagementObject port in searcher.Get())
                {
                    debug("Device found:");
                    SerialDevice device = new SerialDevice();

                    try {device.DeviceId = port["DeviceID"].ToString(); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}");}
                    try {device.PnpDeviceId = port["PNPDeviceID"].ToString(); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.Caption = port["Caption"].ToString(); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.Name = port["Name"].ToString(); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.Manufacturer = port["Manufacturer"].ToString(); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.ProviderType = port["ProviderType"].ToString(); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.MaxBaudRate = UInt32.Parse(port["MaxBaudRate"].ToString());} catch (Exception ex) {debug($"EXCEPTION: {ex.Message}");}
                    try {device.OSAutoDiscovered = bool.Parse(port["OSAutoDiscovered"].ToString()); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.SupportsRTSCTS = bool.Parse(port["SupportsRTSCTS"].ToString()); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.SupportsXOnXOff = bool.Parse(port["SupportsXOnXoff"].ToString()); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.SettableBaudRate = bool.Parse(port["SettableBaudRate"].ToString()); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }
                    try {device.SettableDataBits = bool.Parse(port["SettableDataBits"].ToString()); } catch (Exception ex) { debug($"EXCEPTION: {ex.Message}"); }

                    Match mVid = Regex.Match(device.PnpDeviceId, vidPattern, RegexOptions.IgnoreCase);
                    Match mPid = Regex.Match(device.PnpDeviceId, pidPattern, RegexOptions.IgnoreCase);

                    if (mVid.Success) device.Vid = mVid.Groups[1].Value;
                    if (mPid.Success) device.Pid = mPid.Groups[1].Value;

                    debug($"  Name = {device.Name}");
                    debug($"  Device ID = {device.DeviceId}");
                    debug($"  PNP Device ID = {device.PnpDeviceId}");
                    debug($"  Caption   = {device.Caption}");
                    debug($"  Manufacturer = {device.Manufacturer}");
                    debug($"  Max Baud Rate = {device.MaxBaudRate}");
                    debug($"  Provider Type = {device.ProviderType}");
                    debug($"  OS Auto Discovered = {device.OSAutoDiscovered}");
                    debug($"  Supports RTSCTS = {device.SupportsRTSCTS}");
                    debug($"  Supports XOn/XOff = {device.SupportsXOnXOff}");
                    debug($"  Settable Baud Rate = {device.SettableBaudRate}");
                    debug($"  Settable Data Bits = {device.SettableDataBits}");
                    debug($"  VID = {device.Vid}");
                    debug($"  PID = {device.Pid}");

                    devices.Add(device);
                }
            }
            return devices;
        }

        private void populateCommInterfaces()
        {
            commComboBox.Items.Clear();
            commInterfaces = getSerialDevices();
            foreach (SerialDevice commInterface in commInterfaces)
            {
                debug($"Add interface [{commInterface.DeviceId}] to commComboBox");
                commComboBox.Items.Add(commInterface.DeviceId);
            }
            commComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            debug("Form loaded");
            populateCommInterfaces();
        }

        private void refreshCommInterfacesButton_Click(object sender, EventArgs e)
        {
            refreshCommInterfacesButton.Enabled = false;
            commComboBox.Enabled = false;
            populateCommInterfaces();
            refreshCommInterfacesButton.Enabled = true;
            commComboBox.Enabled = true;
        }
    }

    public class SerialDevice
    {
        public string DeviceId { get; set; }
        public string PnpDeviceId {  get; set; }
        public string Caption { get; set; }
        public string Vid { get; set; }
        public string Pid { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ProviderType {  get; set; }
        public UInt32 MaxBaudRate { get; set; }
        public bool OSAutoDiscovered {  get; set; }
        public bool SupportsRTSCTS { get; set; }
        public bool SupportsXOnXOff { get; set; }
        public bool SettableBaudRate { get; set; }
        public bool SettableDataBits { get; set; }
    }
}
