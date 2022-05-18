using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using WindowsInput.Native;
using WindowsInput;

namespace _20220512 {
    public partial class Form1 : Form {
        InputSimulator objSim = new InputSimulator();
        private int countdown = 0;
        private int delay = 0;
        private int count = 0;
        private bool state = false;

        public Form1() {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        private void Form1_Load(object sender, EventArgs e) {
            Thread objThread = new Thread(Main);
            objThread.IsBackground = true;
            objThread.Start();
            label1.Text = "";
        }

        private void Main() {
            state = false;
            lblState.Text = "Status: Not running";
            WaitUntilStateIsTrue();
            lblState.Text = "Status: Running";
            countdown = int.Parse(txtCountdown.Text);

            if (txtCount.Text == "") {
                count = 99;
            } else {
                count = int.Parse(txtCount.Text);
            }

            delay = int.Parse(txtDelay.Text);
            lblCountdownTimer.Text = "Countdown: " + countdown;
            lblCountLeft.Text = "Count: " + count;
            lblDelayTimer.Text = "Delay: " + delay;

            while (countdown > 0) {
                if (IsKeyPressed(67)) {
                    MessageBox.Show("The process has stopped");
                    Main();
                    return;
                }

                if (IsKeyPressed(32)) {
                    MessageBox.Show("The process has stopped");
                    Main();
                    return;
                }

                Thread.Sleep(25);
                lblCountdownTimer.Text = "Countdown: " + countdown;
                countdown -= 25;
            }

            while (count > 0) {
                objSim.Keyboard.TextEntry(boxRoll.Text);
                Thread.Sleep(500);
                objSim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                delay = int.Parse(txtDelay.Text) - 600;

                while (delay > 0) {
                    if (IsKeyPressed(67)) {
                        MessageBox.Show("The process has stopped");
                        Main();
                        return;
                    }

                    if (IsKeyPressed(32)) {
                        for (int i = 0; i < 10; i++) {
                            objSim.Keyboard.KeyPress(VirtualKeyCode.BACK);
                            Thread.Sleep(25);
                        }

                        objSim.Keyboard.TextEntry(txtSpaceEvent.Text.Substring(0, txtSpaceEvent.TextLength - 1));
                        Thread.Sleep(100);
                        objSim.Keyboard.TextEntry(txtSpaceEvent.Text.Substring(txtSpaceEvent.TextLength - 1));
                        Thread.Sleep(500);
                        objSim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        Thread.Sleep(500);
                        objSim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        MessageBox.Show("The process has stopped");
                        Main();
                        return;
                    }

                    Thread.Sleep(25);
                    lblDelayTimer.Text = "Delay: " + delay;
                    delay -= 25;
                }

                objSim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(100);
                lblCountLeft.Text = "Count: " + count;
                count--;
            }

            return;
        }

        private bool IsKeyPressed(int key) {
            int keyState = GetAsyncKeyState(key);
            return (keyState == 32769) ? true : false;
        }

        private void txtCountdown_TextChanged(object sender, EventArgs e) {
            txtCountdown.Text = CleanStringOfNonDigits_V1(txtCountdown.Text);
        }

        private static readonly Regex rxNonDigits = new Regex(@"[^\d]+");

        private string CleanStringOfNonDigits_V1(string s) {
            if (string.IsNullOrEmpty(s)) return s;
            string cleaned = rxNonDigits.Replace(s, "");
            return cleaned;
        }

        private void WaitUntilStateIsTrue() {
            while (state == false) {
                Thread.Sleep(100);
            }

            return;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            state = true;
        }
    }
}