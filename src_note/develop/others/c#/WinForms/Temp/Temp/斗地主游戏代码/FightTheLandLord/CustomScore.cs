using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FightTheLandLord
{
    public partial class CustomScore : Form
    {
        public CustomScore()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (tbStartScore.Text.Trim() != "")
            {
                if (Int32.TryParse(tbStartScore.Text.Trim(), out i))
                {
                    DConsole.client1Score = Convert.ToInt32(tbStartScore.Text.Trim());
                    DConsole.client2Score = DConsole.client1Score;
                    DConsole.serverScore = DConsole.client1Score;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请输入一个有效数字","起始分数");
                }
            }

            if (tbRoundScore.Text.Trim() != "")
            {
                if (Int32.TryParse(tbRoundScore.Text.Trim(),out i))
                {
                    DConsole.roundScore = Convert.ToInt32(tbRoundScore.Text.Trim());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请输入一个有效数字","每回合分数");
                }
            }
        }
    }
}
