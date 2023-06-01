using System.Net.Http;
namespace WinFormsAppLamp
{
    public partial class Lighting : Form
    {
        static readonly HttpClient clientESP = new HttpClient();
        public Lighting()
        {
            InitializeComponent();
        }

        private static async Task Requests(string switcher, string lamp)
        {
            string URL = ($"http://192.168.0.10/{switcher}?lamp={lamp}");
            using HttpResponseMessage response = await clientESP.GetAsync(URL);
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Interruptor ligado
                await Requests("on", "D4");
                checkBox1.Text = "Turn Off";
                checkBox1.BackColor = Color.FromArgb(255, 255, 224);
                checkBox1.ForeColor = SystemColors.ActiveCaptionText;


            }
            else
            {
                // Interruptor desligado
                await Requests("off", "D4");
                checkBox1.Text = "Turn On";
                checkBox1.BackColor = Color.FromArgb(55, 55, 39);
                checkBox1.ForeColor = SystemColors.ButtonFace;
            }
        }

        private async void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // Interruptor ligado
                await Requests("on", "D8");
                checkBox2.Text = "Turn Off";
                checkBox2.BackColor = Color.FromArgb(255, 255, 224);
                checkBox2.ForeColor = SystemColors.ActiveCaptionText;
            }
            else
            {
                // Interruptor desligado
                await Requests("off", "D8");
                checkBox2.Text = "Turn On";
                checkBox2.BackColor = Color.FromArgb(55, 55, 39);
                checkBox2.ForeColor = SystemColors.ButtonFace;
            }
        }
    }
}