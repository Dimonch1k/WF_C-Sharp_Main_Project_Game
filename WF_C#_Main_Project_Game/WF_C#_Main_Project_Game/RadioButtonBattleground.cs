using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_C__Main_Project_Game
{
    public partial class RadioButtonBattleground : Form
    {
        public static int Battleground { get; set; }
        public RadioButtonBattleground()
        {
            InitializeComponent();
        }

        private void RadioButtonBattleground_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            Battleground = 1;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            Battleground = 2;
            radioButton1.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Battleground = 3;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void sumbitButton_Click(object sender, EventArgs e)
        {
            if (Battleground == 0)
            {
                Battleground = 1;
            }
            this.Close();
        }
    }
}
