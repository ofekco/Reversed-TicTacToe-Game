using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormGameSettings : Form
    {
        public FormGameSettings()
        {   
            InitializeComponent();
        }

        public string Player1
        {
            get { return textBoxPlayer1.Text; }
        }

        public bool Is2PlayersGame
        {
            get { return textBoxPlayer2.Enabled; }
        }

        public string Player2
        {
            get { return textBoxPlayer2.Text; }
        }

        public int GameSize
        {
            get { return (int)numericUpDownCols.Value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxPlayer2_Click(object sender, EventArgs e)
        {
            textBoxPlayer2.Enabled = !textBoxPlayer2.Enabled;
            if (textBoxPlayer2.Enabled)
            {
                textBoxPlayer2.Text = "";
            }
            else
            {
                textBoxPlayer2.Text = "[Computer]";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownRows_MouseDown(object sender, MouseEventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;
        }

        private void numericUpDownCols_MouseDown(object sender, MouseEventArgs e)
        {
            numericUpDownRows.Value = numericUpDownCols.Value;
        }
    }
}
