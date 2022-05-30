using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoseSanchezTomas24
{
    public partial class Form1 : Form
    {
        List<QuestionModel> questions;
        string player;
        int points;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            jugar(questions);
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {

        }

        public void jugar(List<QuestionModel> qu)
        {
            if(qu != null)
            {

            }
            else
            {

            }
        }
    }
}
