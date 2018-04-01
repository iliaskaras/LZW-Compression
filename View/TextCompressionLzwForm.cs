using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCompressionLzwFormApplication.View
{
    public partial class TextCompressionLzwForm : Form
    {
        public TextCompressionLzwForm()
        {
            InitializeComponent();
        }

        private void LzwDetailsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void SelectFileToCompressButton_Click(object sender, EventArgs e)
        {
            FileOperationsController _selectedFileOperations = new FileOperationsController();
            ReadFileController _readTextFileController = new ReadFileController();

            _selectedFileOperations.selectFileDirectory();
            FileNameTextBox.Text = _selectedFileOperations.getSelectedFileDirectoryName();
            filePathRichBox.Text = _selectedFileOperations.getSelectedFileDirectoryPath().ToString();

           
            UncompressedByteSizeTextBox.Text = "Bytes: "+_selectedFileOperations.getSelectedFileDirectorySize() ;
        }

        private void CalcUncompressedByteSizeButton_Click(object sender, EventArgs e)
        {

        }

        private void CompressedPercentanceLabel_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UncompressedFileTextRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToSelectFileButton_Click(object sender, EventArgs e)
        {
            clearTextBoxes(LzwDetailsGroupBox);
            LZWMethodDetailsGroupBox.Hide();
            LzwDetailsGroupBox.Show();
        }

        public void clearTextBoxes(GroupBox groupBoxToClear)
        {
            foreach (Control control in groupBoxToClear.Controls)
            {
                if ((control is TextBox) ||(control is RichTextBox))
                {
                    control.Text = "";
                }
            }
        }

        private void SelectFileMenuGoBackButton_Click(object sender, EventArgs e)
        {
            LzwMainWindow lzwMainWindow = new LzwMainWindow();
            Hide();
            lzwMainWindow.Show();
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            LzwMainWindow lzwMainWindow = new LzwMainWindow();
            Hide();
            lzwMainWindow.Show();
        }

        private void ProceedToCompressionButton_Click(object sender, EventArgs e)
        {
            CompressMenuFileName.Text = FileNameTextBox.Text;
            CompressMenuSelectedFileSize.Text = UncompressedByteSizeTextBox.Text;
            LzwDetailsGroupBox.Hide();
            LZWMethodDetailsGroupBox.Show();
        }

        private void LZWCompressButton_Click_1(object sender, EventArgs e)
        {
            LZWCompress _lzwCompress = new LZWCompress(this);
            IReadFileController _readTextFileController = new ReadFileController();
            IFileOperationsController _fileOperationController = new FileOperationsController();
            string compressedFilePath = null;


            compressedFilePathRichTextBox.Text = filePathRichBox.Text.Remove(filePathRichBox.Text.Length - 4) + "Compressed.txt";
            _lzwCompress.LZWCompressFile(filePathRichBox.Text, compressedFilePathRichTextBox.Text, Convert.ToInt16(selectedMaxBitSizeTextbox.Text));
            compressedFilePath = filePathRichBox.Text.Remove(filePathRichBox.Text.Length - 4) + "Compressed.txt";
            compressedByteSizeTextBox.Text = _fileOperationController.getFileByteSize(compressedFilePath);
        }

        private void LZWDecompressButton_Click_1(object sender, EventArgs e)
        {
            IFileOperationsController _fileOperationController = new FileOperationsController();
            LZWDecompress _lzwDecompress = new LZWDecompress(this);


            string decompressedFilePath = compressedFilePathRichTextBox.Text.Remove(compressedFilePathRichTextBox.Text.Length - 14) + "Uncompressed.txt";
            decompressedFileNameTextBox.Text = decompressedFilePath;
            _lzwDecompress.LZWDecompressFile(compressedFilePathRichTextBox.Text, decompressedFilePath, Convert.ToInt16(selectedMaxBitSizeTextbox.Text));
            decompressedByteSizeTextBox.Text = _fileOperationController.getFileByteSize(decompressedFilePath);
            
            compressedPercentanceTextBox.Text = _lzwDecompress.getCompressionRatio(double.Parse(compressedByteSizeTextBox.Text), double.Parse(decompressedByteSizeTextBox.Text)) + " %";
            CompressedDataPercentanceTextBox.Text = (100 - Convert.ToDouble(compressedPercentanceTextBox.Text.Remove(compressedPercentanceTextBox.Text.Length - 2))).ToString() + " %";
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {

        }

        private void FinalSelectBitSizeButton_Click(object sender, EventArgs e)
        {

        }

        private void AlgorithmChooseBitCheckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                // Uncheck the other items
                for (int i = 0; i < AlgorithmChooseBitCheckbox.Items.Count; i++)
                {
                    if (e.Index != i)
                    {
                        this.AlgorithmChooseBitCheckbox.SetItemChecked(i, false);
                    }
                }
                
            }
            selectedMaxBitSizeTextbox.Text = AlgorithmChooseBitCheckbox.SelectedItem.ToString();
        }

        private void selectedMaxBitSizeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void decompressedByteSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextCompressionLzwForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
