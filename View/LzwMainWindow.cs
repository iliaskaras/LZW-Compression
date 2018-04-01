using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCompressionLzwFormApplication.View
{
    public partial class LzwMainWindow : Form
    {
        public LzwMainWindow()
        {
            InitializeComponent();
        }

        private void teiserLogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GeneralWorkDetailButton_Click(object sender, EventArgs e)
        {
            GeneralDetailsInfoBox.Show();
            CloseDetailsButton.Show();
        }

        private void CloseDetailsButton_Click(object sender, EventArgs e)
        {
            GeneralDetailsInfoBox.Hide();
            CloseDetailsButton.Hide();
        }

        private void LZWHelpTutorial_Click(object sender, EventArgs e)
        {
            TextCompressionTutorialLzwForm textCompressionLzwHelpForm = new TextCompressionTutorialLzwForm();
            Hide();
            textCompressionLzwHelpForm.Show();
        }

        private void GeneralDetailsInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LZWAlgorithm_Click(object sender, EventArgs e)
        {
            TextCompressionLzwForm textCompressionLzwForm = new TextCompressionLzwForm();
            Hide();
            textCompressionLzwForm.Show();
        }

        private void LzwMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void LzwMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
