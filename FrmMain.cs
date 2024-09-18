using System.Diagnostics;

namespace WFA20240917
{
    public partial class FrmMain : Form
    {
        private static Random rnd = new();
        private Stopwatch sw = new();
        private System.Windows.Forms.Timer timer = new();
        private int catches;
        private TimeSpan lastColorChange;
        public FrmMain()
        {
            InitializeComponent();
            btnClickMe.Click += BtnClickMeClick;
            btnClickMe.MouseEnter += BtnClickMeMouseEnter;
            pnlMain.MouseMove += PnlMain_MouseMove;
            timer.Tick += TmrTick;
        }

        private void TmrTick(object? sender, EventArgs e)
        {
            lblTime.Text = $"{sw.Elapsed.Minutes:00}" +
                $":{sw.Elapsed.Seconds:00}" +
                $":{sw.Elapsed.Milliseconds:000}";
        }

        private void PnlMain_MouseMove(object? sender, MouseEventArgs e)
        {
            if (lastColorChange.Add(new(00, 00, 00, 00, 500)) < sw.Elapsed)
            {
                btnClickMe.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                lastColorChange = sw.Elapsed;
            }
        }

        private void BtnClickMeMouseEnter(object sender, EventArgs e)
        {
            btnClickMe.Location = new(
                x: rnd.Next(pnlMain.Width - btnClickMe.Width),
                y: rnd.Next(pnlMain.Height - btnClickMe.Height));
            if (!sw.IsRunning)
            {
                timer.Start();
                sw.Start();
            }
        }
        private void BtnClickMeClick(object sender, EventArgs e)
        {
            catches++;
            lblCatches.Text = $"catches: {catches:00}";
            BtnClickMeMouseEnter(null, null);
            if(catches >= 5)
            {
                MessageBox.Show(
                    caption: "YOU WIN!",
                    text: $"time: {sw.Elapsed.TotalSeconds} sec.\n" +
                    $"pnl size: [{pnlMain.Width} x {pnlMain.Height}]");
                //Application.Exit();
            }
        }

    }
}
