namespace WF_C__Main_Project_Game
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();

            

            Create_Label_Start();
        }

        private void Form_Start_Load(object sender, EventArgs e)
        {
        }

        private void Create_Label_Start()
        {
            start_label.BackColor = Color.DarkOrange;
            start_label.ForeColor = Color.Black;
            start_label.Left = (this.ClientSize.Width - start_label.Size.Width) / 2;
            start_label.Top = (this.ClientSize.Height - start_label.Size.Height) / 20;
            start_label.TextAlign = ContentAlignment.MiddleCenter;
        }



        private void Continue_start_button_Click(object sender, EventArgs e)
        {
            Form form = new Form_Choose_Fighters();
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void Info_start_button_Click(object sender, EventArgs e)
        {
            string message = "Game, where you can choose two heroes and manage them. they have buffs and debuffs at different locations. there is also chance to make crit and to dodge the enemy attack.";
            MessageBox.Show(message, "GAME Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Exit_start_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
