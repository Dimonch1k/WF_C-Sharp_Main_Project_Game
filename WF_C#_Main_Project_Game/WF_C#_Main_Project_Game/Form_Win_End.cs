using System.Reflection;

namespace WF_C__Main_Project_Game
{
    public partial class Form_Win_End : Form
    {
        // KONSTRUCTOR
        public Form_Win_End(string winner)
        {
            InitializeComponent();

            
            Label_End_Game();
            Winner_Label(winner);
        }


        // LOAD FORM
        private void Form_Win_End_Load(object sender, EventArgs e)
        {
        }


        // END GAME LABEL
        public void Label_End_Game()
        {
            end_game_label.Text = "END GAME";
            end_game_label.Left = (this.ClientSize.Width - end_game_label.Size.Width) / 2;
            end_game_label.Top = (this.ClientSize.Height - end_game_label.Size.Height) / 12;
            end_game_label.TextAlign = ContentAlignment.MiddleCenter;
        }


        // WINNER LABEL
        public void Winner_Label(string Winner)
        {
            switch (Winner)
            {
                case "Archer":
                    winner_label.Text = "WINNER ARCHER";
                    winner_label.BackColor = Color.Green;
                    winner_label.ForeColor = Color.GhostWhite;
                    BackgroundImage = Properties.Resources.forest;
                    break;

                case "Mage":
                    winner_label.Text = "WINNER MAGE";
                    winner_label.BackColor = Color.DarkSlateBlue;
                    winner_label.ForeColor = Color.GhostWhite;
                    BackgroundImage = Properties.Resources.Snow_Arena;
                    break;

                case "Warrior":
                    winner_label.Text = "WINNER WARRIOR";
                    winner_label.BackColor = Color.SaddleBrown;
                    winner_label.ForeColor = Color.GhostWhite;
                    break;

                default:
                    winner_label.Text = "No Winner";
                    winner_label.BackColor = Color.DarkRed;
                    winner_label.ForeColor = Color.GhostWhite;
                    break;
            }


            int label_width = winner_label.Size.Width;
            winner_label.Left = (this.ClientSize.Width - label_width) / 2;
            winner_label.Top = (this.ClientSize.Height - end_game_label.Size.Height) / 2;
            winner_label.TextAlign = ContentAlignment.MiddleCenter;
        }


        // OTHER
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
