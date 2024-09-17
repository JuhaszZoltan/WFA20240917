namespace WFA20240917
{
    public partial class FrmMain : Form
    {
        static Random rnd = new();
        public FrmMain()
        {
            InitializeComponent();
            btnClickMe.Click += BtnClickMeClick;
            btnClickMe.MouseEnter += BtnClickMeMouseEnter;

            //ha a panelen mozog a kurzor -> váltson random színre
            //számold egy változóbán, hogy hányszor sikerült elkapni a gombot
            //5 catch után írja ki az eltelt idõt az MsgBox-ban!
        }

        private void BtnClickMeMouseEnter(object? sender, EventArgs e)
        {
            btnClickMe.Location = new(
                x: rnd.Next(pnlMain.Height - btnClickMe.Height),
                y: rnd.Next(pnlMain.Width - btnClickMe.Width));
        }
        private void BtnClickMeClick(object? sender, EventArgs e) => 
            MessageBox.Show("You WIN!");
    }
}
