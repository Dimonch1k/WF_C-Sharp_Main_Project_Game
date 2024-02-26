namespace WF_C__Main_Project_Game
{
    public partial class Form_Choose_Fighters : Form
    {

        public Form_Choose_Fighters()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form_Choose_Fighters_Load(object sender, EventArgs e)
        {

        }


        // BUTTONS CLICK   
        // BUTTONS TEXT CHANGED - Color changed and Check button Sumbit ENABLED

        private void chooseFighter1Button_Click(object sender, EventArgs e)
        {
            Form form = new RadioButtonFighters();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();


            int fighter = RadioButtonFighters.Fighter;

            if (fighter == 0)
            {
                chooseFighter1_Button.Text = "Choose fighter 1";
                chooseFighter1_Button.BackColor = Color.Gray;
                return;
            }
            if (fighter == 1)
            {
                chooseFighter1_Button.Text = "Archer";
                chooseFighter1_Button.BackColor = Color.DarkSeaGreen;
            }
            if (fighter == 2)
            {
                chooseFighter1_Button.Text = "Mage";
                chooseFighter1_Button.BackColor = Color.DarkCyan;
            }
            if (fighter == 3)
            {
                chooseFighter1_Button.Text = "Warrior";
                chooseFighter1_Button.BackColor = Color.DarkOrange;
            }
        }

        private void chooseFighter2Button_Click(object sender, EventArgs e)
        {
            Form form = new RadioButtonFighters();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            int fighter = RadioButtonFighters.Fighter;

            if (fighter == 0)
            {
                chooseFighter2_Button.Text = "Choose fighter 1";
                chooseFighter2_Button.BackColor = Color.Gray;
                return;
            }
            if (fighter == 1)
            {
                chooseFighter2_Button.Text = "Archer";
                chooseFighter2_Button.BackColor = Color.DarkSeaGreen;
            }
            if (fighter == 2)
            {
                chooseFighter2_Button.Text = "Mage";
                chooseFighter2_Button.BackColor = Color.DarkCyan;
            }
            if (fighter == 3)
            {
                chooseFighter2_Button.Text = "Warrior";
                chooseFighter2_Button.BackColor = Color.DarkOrange;
            }
        }


        // SUMBIT BUTTON
        private void sumbitButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button_Sumbit.Enabled = true;
            string fighter1 = chooseFighter1_Button.Text;
            string fighter2 = chooseFighter2_Button.Text;
            Form form = new Form_Choose_Arena(fighter1, fighter2);
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }





        // TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chooseFighter1_Button.Text == "Choose Fighter 1" || chooseFighter2_Button.Text == "Choose Fighter 2")
            {
                button_Sumbit.Enabled = false;
                button_Sumbit.Cursor = Cursors.No;
            }
            else
            {
                button_Sumbit.Enabled = true;
                button_Sumbit.Cursor = Cursors.Hand;
            }
        }



        // OTHER
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
