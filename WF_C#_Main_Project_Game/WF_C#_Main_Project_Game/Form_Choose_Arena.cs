namespace WF_C__Main_Project_Game
{
    public partial class Form_Choose_Arena : Form
    {
        private string fighter1;
        private string fighter2;
        public Form_Choose_Arena()
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
        }

        public Form_Choose_Arena(string fighter1, string fighter2)
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
        }

        private void Form_Choose_Weather_Load(object sender, EventArgs e)
        {

        }


        // LABEL
        private void label1_Click(object sender, EventArgs e)
        {

        }


        // BATTLEGROUND
        private void chooseBattlegroundButton_Click(object sender, EventArgs e)
        {
            Form form = new RadioButtonBattleground();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();


            int fighter = RadioButtonBattleground.Battleground;

            if (fighter == 0)
            {
                chooseBattlegroundButton.Text = "Choose fighter 1";
                chooseBattlegroundButton.BackColor = Color.Gray;
                return;
            }
            if (fighter == 1)
            {
                chooseBattlegroundButton.Text = "Vulcan";
                chooseBattlegroundButton.BackColor = Color.DarkRed;
            }
            if (fighter == 2)
            {
                chooseBattlegroundButton.Text = "Field";
                chooseBattlegroundButton.BackColor = Color.Gold;
            }
            if (fighter == 3)
            {
                chooseBattlegroundButton.Text = "Subway";
                chooseBattlegroundButton.BackColor = Color.DarkGray;
            }

        }


        // SUMBIT BUTTON
        private void sumbitButton_Click(object sender, EventArgs e)
        {
            sumbitButton.Enabled = true;
            string battleground = chooseBattlegroundButton.Text;
            Form form = new Form_Battle(fighter1, fighter2, battleground);
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chooseBattlegroundButton.Text == "Choose Battleground")
            {
                sumbitButton.Enabled = false;
                sumbitButton.Cursor = Cursors.No;
            }
            else
            {
                sumbitButton.Enabled = true;
                sumbitButton.Cursor = Cursors.Hand;
            }
        }
    }
}
