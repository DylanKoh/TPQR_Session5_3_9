using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_3_9
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new LoginForm()).ShowDialog();
            Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Hide();
            (new AssignSeat()).ShowDialog();
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Hide();
            (new EnterMarks()).ShowDialog();
            Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Hide();
            (new ViewResults()).ShowDialog();
            Close();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Hide();
            (new AnalyzeResults()).ShowDialog();
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Hide();
            (new CalculateBonus()).ShowDialog();
            Close();
        }
    }
}
