using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class AlarmClockForm : Form
    {

        private string MusicFileName;
        public AlarmClockForm()
        {
            InitializeComponent();

            CurrentTime.Text = getTime();
            CurrentTimeTimer.Start();

            MusicFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\alarm2.mp3";

            AlarmClockLabel.Text = "";
        }

        private void MusicDownloader_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "WAV Music Files|*.wav";
            ;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string musicFileName = dialog.SafeFileName;
                MusicFileName = dialog.FileName;
                MusicFilePath.Text = musicFileName;
            }
        }

        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = getTime();
        }

        private string getTime()
        {
            string hours = DateTime.Now.Hour.ToString("00");
            string minutes = DateTime.Now.Minute.ToString("00");
            string seconds = DateTime.Now.Second.ToString("00");

            return hours + " :  " + minutes + " :  " + seconds;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            string maskedText = EnteringTimeTextBox.Text;
            string[] timeData = maskedText.Split(':');

            for(int i = 0; i < timeData.Length; i++)
            {
                timeData[i] = timeData[i].Trim();
            }

            bool enteringTimeIsFilled = true;
            string formattedEnteringTime = "{0} :  {1} :  {2}";
            foreach (string time in timeData)
            {
                if (time.Length != 2)
                {
                    enteringTimeIsFilled = false;
                }
                
            }


            if (enteringTimeIsFilled)
            {
                formattedEnteringTime = String.Format(formattedEnteringTime, timeData);
                AlarmClockLabel.Text = formattedEnteringTime;
                EnteringTimeTextBox.Text = "";
                AlarmTimer.Start();
            }
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if(CurrentTime.Text == AlarmClockLabel.Text)
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = MusicFileName;
                myPlayer.Play();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            AlarmClockLabel.Text = "";
            AlarmTimer.Stop();
        }
    }
}
