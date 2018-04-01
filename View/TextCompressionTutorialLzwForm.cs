using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextCompressionLzwFormApplication.View;

namespace TextCompressionLzwFormApplication
{
    public partial class TextCompressionTutorialLzwForm : Form
    {


        public TextCompressionTutorialLzwForm()
        {
            InitializeComponent();
            
        }
       
        /* =================================================================================================================================================================*/
        /* =================                                    Form Methods                                                             ===================================*/
        /* =================================================================================================================================================================*/

        private void setUncompressedFileDetails(IFileOperationsController _selectFileController)
        {
            IReadFileController _readTextFileController = new ReadFileController();
        }

        private void unsetUncompressedFileDetails()
        {

        }

        /* =================================================================================================================================================================*/
        /* ==================                                End of Form Methods                                                         ===================================*/
        /* =================================================================================================================================================================*/

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LZWCompressButton_Button(object sender, EventArgs e)
        {
            ILZWTutorialCompressTextController _lzwCompressTextController = new LZWTutorialCompressTextController(this);
            string givenStringToCompress = EnteredTextRichTextBox.Text;

            lzwCompressionDetailDataGridView.Show();
            lzwDecompressionDetailDataGridView.Hide();
            _lzwCompressTextController.lzwTutorialCompressFile(givenStringToCompress);
            
        }

        

        private void LZWDecompressionButton_Click(object sender, EventArgs e)
        {
            LZWTutorialDecompressTextController _lzwCompressTextController = new LZWTutorialDecompressTextController(this);

            lzwCompressionDetailDataGridView.Hide();
            lzwDecompressionDetailDataGridView.Show();
            _lzwCompressTextController.LZWTutorialDecompressFile(this.CompressedTextRichTextBox.Text.ToString());

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

        private void BackToSelectFileButton_Click(object sender, EventArgs e)
        {

            LzwMainWindow lzwMainWindow = new LzwMainWindow();
            Hide();
            lzwMainWindow.Show();
        }

        private void TextCompressionTutorialLzwForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
