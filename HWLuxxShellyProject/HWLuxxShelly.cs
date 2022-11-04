using Microsoft.Win32;

namespace HWLuxxShellyProject
{
    public partial class HWLuxxShelly : Form
    {
        private CancellationTokenSource _canceller;
        public HWLuxxShelly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyName = @"Software\HWiNFO64\Sensors\Custom";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key == null)
                {
                    // Key doesn't exist. Do whatever you want to handle
                    // this case
                }
                else
                {
                    key.DeleteSubKeyTree("shelly");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string keyName = @"Software\HWiNFO64\Sensors";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName , true);

            key.CreateSubKey("Custom");
            key = key.OpenSubKey("Custom", true);


            key.CreateSubKey("shelly");
            key = key.OpenSubKey("shelly", true);

            key.CreateSubKey("Power0");
            key = key.OpenSubKey("Power0", true);

            key.SetValue("Name", textBox2.Text.ToString());
            key.SetValue("Value", 10, RegistryValueKind.DWord);

            _canceller = new CancellationTokenSource();

            // Update the IP and add /status
            UpdatePower shelly = new UpdatePower(textBox1.Text);

            await Task.Run(() =>
            {
                do
                {

                    //shelly.increaseTest();
                 
                    //
                    shelly.refresh();
                    key.SetValue("Value", shelly.PowerGet, RegistryValueKind.DWord);

                    if (_canceller.Token.IsCancellationRequested)
                        break;

                } while (true);
            });

            _canceller.Dispose();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            _canceller.Cancel();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}