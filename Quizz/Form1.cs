using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Quizz : Form
    {
        public Quizz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUserGreeting.Visible = false;
            lblQuestion.Visible = false;
            rbRéponse2.Visible = false;
            rbRéponse1.Visible = false;
            rbRéponse3.Visible = false;
        }

        private void cmdUserName_Click(object sender, EventArgs e)
        {
            cmdUserName.Visible = false;
            txtUserName.Visible = false;
            lblUserName.Visible = false;
            lblUserGreeting.Visible = true;
            lblQuestion.Visible = true;
            rbRéponse2.Visible = true;
            rbRéponse1.Visible = true;
            rbRéponse3.Visible = true;
        }

        private void lblUserGreeting_Click(object sender, EventArgs e)
        {

        }
    }
}
