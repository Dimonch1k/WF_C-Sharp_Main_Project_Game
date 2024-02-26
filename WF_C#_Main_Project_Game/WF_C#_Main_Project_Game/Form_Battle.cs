namespace WF_C__Main_Project_Game
{
    public partial class Form_Battle : Form
    {
        private string fighter1;
        private string fighter2;
        private string battleground;
        public Form_Battle()
        {
            InitializeComponent();
        }

        public Form_Battle(string fighter1, string fighter2, string battleground)
        {
            InitializeComponent();
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
            this.battleground = battleground;
        }

        private void Form_Battle_Load(object sender, EventArgs e)
        {

        }


    }
}
