namespace WF_C__Main_Project_Game
{
    public partial class RadioButtonFighters : Form
    {
        public static int Fighter { get; set; }

        public RadioButtonFighters()
        {
            InitializeComponent();
        }

        private void RadioButtonFighters_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Fighter = 1;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Fighter = 2;
            radioButton1.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Fighter = 3;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }



        private void sumbitButton_Click(object sender, EventArgs e)
        {
            if (Fighter == 0)
            {
                Fighter = 1;
            }
            this.Close();
        }
    }
}
