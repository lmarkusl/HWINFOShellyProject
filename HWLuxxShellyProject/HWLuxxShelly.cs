using Microsoft.Win32;
using System.Windows.Forms;

namespace HWLuxxShellyProject
{
    public partial class HWLuxxShelly : Form
    {
        private CancellationTokenSource _canceller;
        public HWLuxxShelly()
        {
            InitializeComponent();
            textBox1.Text = HWLuxxShellyProject.Properties.Settings1.Default.url;
            valueMSupdate.Text = HWLuxxShellyProject.Properties.Settings1.Default.updateTime.ToString();
            textBox2.Text = HWLuxxShellyProject.Properties.Settings1.Default.nameReg;
            RunStart.Checked = HWLuxxShellyProject.Properties.Settings1.Default.startUpRun;


            //if (RunStart.Checked.Equals(true))
            //{
            //startBtn.PerformClick();
            //}

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
            UpdatePower shelly = new UpdatePower(textBox1.Text, rb_plusplugs.Checked);

            await Task.Run(() =>
            {
                do
                {

                    //shelly.increaseTest();
                 
                    //
                    shelly.refresh();
                    key.SetValue("Value", shelly.PowerGet, RegistryValueKind.DWord);
                    System.Threading.Thread.Sleep(200);

                    if (_canceller.Token.IsCancellationRequested)
                        break;

                } while (true);
            });

            _canceller.Dispose();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }



        private void Form1_Shown(Object sender, EventArgs e)
        {
            if (RunStart.Checked.Equals(true))
            {
                startBtn.PerformClick();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _canceller.Cancel();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void d_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            HWLuxxShellyProject.Properties.Settings1.Default.url = textBox1.Text;
            HWLuxxShellyProject.Properties.Settings1.Default.updateTime = Int32.Parse(valueMSupdate.Text);
            HWLuxxShellyProject.Properties.Settings1.Default.nameReg = textBox2.Text;
            HWLuxxShellyProject.Properties.Settings1.Default.startUpRun = RunStart.Checked;
            HWLuxxShellyProject.Properties.Settings1.Default.Save();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_plugS_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}