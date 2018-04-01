namespace TextCompressionLzwFormApplication.View
{
    partial class TextCompressionLzwForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SelectFileToCompressButton = new System.Windows.Forms.Button();
            this.SelectedFileDetailsLabel = new System.Windows.Forms.Label();
            this.UncompressedByteLabel = new System.Windows.Forms.Label();
            this.UncompressedByteSizeTextBox = new System.Windows.Forms.TextBox();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.LzwDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProceedToCompressionButton = new System.Windows.Forms.Button();
            this.SelectFileMenuGoBackButton = new System.Windows.Forms.Button();
            this.filePathRichBox = new System.Windows.Forms.RichTextBox();
            this.LZWMethodDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedMaxBitSizeTextbox = new System.Windows.Forms.TextBox();
            this.AlgorithmChooseBitCheckbox = new System.Windows.Forms.CheckedListBox();
            this.CompressedDataPercentanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectAlgorithmBitLabel = new System.Windows.Forms.Label();
            this.compressedFilePathRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decompressedTimeConsumedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decompressedByteSizeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.decompressedFileNameTextBox = new System.Windows.Forms.TextBox();
            this.timeConsumedTextBox = new System.Windows.Forms.TextBox();
            this.timeConsumedlabel = new System.Windows.Forms.Label();
            this.compressedPercentanceTextBox = new System.Windows.Forms.TextBox();
            this.CompressedPercentanceLabel = new System.Windows.Forms.Label();
            this.compressedByteSizeTextBox = new System.Windows.Forms.TextBox();
            this.CompressedByteSizeLabel = new System.Windows.Forms.Label();
            this.CompressedFileDetailsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LZWDecompressButton = new System.Windows.Forms.Button();
            this.LZWCompressButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CompressMenuSelectedFileSize = new System.Windows.Forms.TextBox();
            this.CompressMenuFileName = new System.Windows.Forms.TextBox();
            this.SelectFileDetailsLabel = new System.Windows.Forms.Label();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.BackToSelectFileButton = new System.Windows.Forms.Button();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.LzwDetailsGroupBox.SuspendLayout();
            this.LZWMethodDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNameTextBox.Location = new System.Drawing.Point(226, 141);
            this.FileNameTextBox.Multiline = true;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(169, 32);
            this.FileNameTextBox.TabIndex = 9;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(22, 141);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(117, 21);
            this.FileNameLabel.TabIndex = 8;
            this.FileNameLabel.Text = "Όνομα Αρχείου";
            // 
            // SelectFileToCompressButton
            // 
            this.SelectFileToCompressButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFileToCompressButton.Location = new System.Drawing.Point(143, 6);
            this.SelectFileToCompressButton.Name = "SelectFileToCompressButton";
            this.SelectFileToCompressButton.Size = new System.Drawing.Size(142, 51);
            this.SelectFileToCompressButton.TabIndex = 7;
            this.SelectFileToCompressButton.Text = "Επέλεξε Αρχείο";
            this.SelectFileToCompressButton.UseVisualStyleBackColor = true;
            this.SelectFileToCompressButton.Click += new System.EventHandler(this.SelectFileToCompressButton_Click);
            // 
            // SelectedFileDetailsLabel
            // 
            this.SelectedFileDetailsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedFileDetailsLabel.AutoSize = true;
            this.SelectedFileDetailsLabel.Location = new System.Drawing.Point(55, 68);
            this.SelectedFileDetailsLabel.Name = "SelectedFileDetailsLabel";
            this.SelectedFileDetailsLabel.Size = new System.Drawing.Size(309, 21);
            this.SelectedFileDetailsLabel.TabIndex = 12;
            this.SelectedFileDetailsLabel.Text = "Στοιχεία ασυμπίεστου επιλεγμένου αρχείου";
            // 
            // UncompressedByteLabel
            // 
            this.UncompressedByteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UncompressedByteLabel.AutoSize = true;
            this.UncompressedByteLabel.Location = new System.Drawing.Point(22, 106);
            this.UncompressedByteLabel.Name = "UncompressedByteLabel";
            this.UncompressedByteLabel.Size = new System.Drawing.Size(196, 21);
            this.UncompressedByteLabel.TabIndex = 6;
            this.UncompressedByteLabel.Text = "Μέγεθος Αρχείου σε Bytes";
            // 
            // UncompressedByteSizeTextBox
            // 
            this.UncompressedByteSizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UncompressedByteSizeTextBox.Location = new System.Drawing.Point(226, 106);
            this.UncompressedByteSizeTextBox.Multiline = true;
            this.UncompressedByteSizeTextBox.Name = "UncompressedByteSizeTextBox";
            this.UncompressedByteSizeTextBox.Size = new System.Drawing.Size(169, 32);
            this.UncompressedByteSizeTextBox.TabIndex = 5;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(22, 174);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(138, 21);
            this.FilePathLabel.TabIndex = 13;
            this.FilePathLabel.Text = "Μονοπάτι Αρχείου";
            // 
            // LzwDetailsGroupBox
            // 
            this.LzwDetailsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LzwDetailsGroupBox.AutoSize = true;
            this.LzwDetailsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.LzwDetailsGroupBox.BackgroundImage = global::TextCompressionLzwFormApplication.Properties.Resources.forMain;
            this.LzwDetailsGroupBox.Controls.Add(this.ProceedToCompressionButton);
            this.LzwDetailsGroupBox.Controls.Add(this.SelectFileMenuGoBackButton);
            this.LzwDetailsGroupBox.Controls.Add(this.filePathRichBox);
            this.LzwDetailsGroupBox.Controls.Add(this.FilePathLabel);
            this.LzwDetailsGroupBox.Controls.Add(this.UncompressedByteSizeTextBox);
            this.LzwDetailsGroupBox.Controls.Add(this.UncompressedByteLabel);
            this.LzwDetailsGroupBox.Controls.Add(this.SelectedFileDetailsLabel);
            this.LzwDetailsGroupBox.Controls.Add(this.SelectFileToCompressButton);
            this.LzwDetailsGroupBox.Controls.Add(this.FileNameLabel);
            this.LzwDetailsGroupBox.Controls.Add(this.FileNameTextBox);
            this.LzwDetailsGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.LzwDetailsGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LzwDetailsGroupBox.Location = new System.Drawing.Point(416, 49);
            this.LzwDetailsGroupBox.Name = "LzwDetailsGroupBox";
            this.LzwDetailsGroupBox.Size = new System.Drawing.Size(423, 376);
            this.LzwDetailsGroupBox.TabIndex = 18;
            this.LzwDetailsGroupBox.TabStop = false;
            this.LzwDetailsGroupBox.Enter += new System.EventHandler(this.LzwDetailsGroup_Enter);
            // 
            // ProceedToCompressionButton
            // 
            this.ProceedToCompressionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProceedToCompressionButton.Location = new System.Drawing.Point(247, 262);
            this.ProceedToCompressionButton.Name = "ProceedToCompressionButton";
            this.ProceedToCompressionButton.Size = new System.Drawing.Size(142, 51);
            this.ProceedToCompressionButton.TabIndex = 66;
            this.ProceedToCompressionButton.Text = "Συνέχεια στην Συμπίεση";
            this.ProceedToCompressionButton.UseVisualStyleBackColor = true;
            this.ProceedToCompressionButton.Click += new System.EventHandler(this.ProceedToCompressionButton_Click);
            // 
            // SelectFileMenuGoBackButton
            // 
            this.SelectFileMenuGoBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFileMenuGoBackButton.Location = new System.Drawing.Point(26, 262);
            this.SelectFileMenuGoBackButton.Name = "SelectFileMenuGoBackButton";
            this.SelectFileMenuGoBackButton.Size = new System.Drawing.Size(142, 51);
            this.SelectFileMenuGoBackButton.TabIndex = 65;
            this.SelectFileMenuGoBackButton.Text = "Πίσω";
            this.SelectFileMenuGoBackButton.UseVisualStyleBackColor = true;
            this.SelectFileMenuGoBackButton.Click += new System.EventHandler(this.SelectFileMenuGoBackButton_Click);
            // 
            // filePathRichBox
            // 
            this.filePathRichBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filePathRichBox.Location = new System.Drawing.Point(226, 174);
            this.filePathRichBox.Name = "filePathRichBox";
            this.filePathRichBox.Size = new System.Drawing.Size(169, 32);
            this.filePathRichBox.TabIndex = 41;
            this.filePathRichBox.Text = "";
            // 
            // LZWMethodDetailsGroupBox
            // 
            this.LZWMethodDetailsGroupBox.BackgroundImage = global::TextCompressionLzwFormApplication.Properties.Resources.light_green_textured_background;
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label8);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label4);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.selectedMaxBitSizeTextbox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.AlgorithmChooseBitCheckbox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.CompressedDataPercentanceTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label2);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.SelectAlgorithmBitLabel);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.compressedFilePathRichTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.decompressedTimeConsumedTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label1);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.decompressedByteSizeTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label5);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label6);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label7);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.decompressedFileNameTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.timeConsumedTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.timeConsumedlabel);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.compressedPercentanceTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.CompressedPercentanceLabel);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.compressedByteSizeTextBox);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.CompressedByteSizeLabel);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.CompressedFileDetailsLabel);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label3);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.LZWDecompressButton);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.LZWCompressButton);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label18);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.label17);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.CompressMenuSelectedFileSize);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.CompressMenuFileName);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.SelectFileDetailsLabel);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.BackToMainMenuButton);
            this.LZWMethodDetailsGroupBox.Controls.Add(this.BackToSelectFileButton);
            this.LZWMethodDetailsGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZWMethodDetailsGroupBox.Location = new System.Drawing.Point(69, 93);
            this.LZWMethodDetailsGroupBox.Name = "LZWMethodDetailsGroupBox";
            this.LZWMethodDetailsGroupBox.Size = new System.Drawing.Size(1198, 425);
            this.LZWMethodDetailsGroupBox.TabIndex = 43;
            this.LZWMethodDetailsGroupBox.TabStop = false;
            this.LZWMethodDetailsGroupBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 21);
            this.label8.TabIndex = 98;
            this.label8.Text = "ή";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 21);
            this.label4.TabIndex = 97;
            this.label4.Text = "Πρότεινε το δικό σου Μέγεθος Λεξικού : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // selectedMaxBitSizeTextbox
            // 
            this.selectedMaxBitSizeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedMaxBitSizeTextbox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMaxBitSizeTextbox.Location = new System.Drawing.Point(16, 269);
            this.selectedMaxBitSizeTextbox.Multiline = true;
            this.selectedMaxBitSizeTextbox.Name = "selectedMaxBitSizeTextbox";
            this.selectedMaxBitSizeTextbox.Size = new System.Drawing.Size(47, 29);
            this.selectedMaxBitSizeTextbox.TabIndex = 95;
            this.selectedMaxBitSizeTextbox.Text = "16";
            this.selectedMaxBitSizeTextbox.TextChanged += new System.EventHandler(this.selectedMaxBitSizeTextbox_TextChanged);
            // 
            // AlgorithmChooseBitCheckbox
            // 
            this.AlgorithmChooseBitCheckbox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgorithmChooseBitCheckbox.FormattingEnabled = true;
            this.AlgorithmChooseBitCheckbox.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.AlgorithmChooseBitCheckbox.Location = new System.Drawing.Point(16, 114);
            this.AlgorithmChooseBitCheckbox.Name = "AlgorithmChooseBitCheckbox";
            this.AlgorithmChooseBitCheckbox.Size = new System.Drawing.Size(91, 88);
            this.AlgorithmChooseBitCheckbox.TabIndex = 93;
            this.AlgorithmChooseBitCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AlgorithmChooseBitCheckbox_ItemCheck);
            // 
            // CompressedDataPercentanceTextBox
            // 
            this.CompressedDataPercentanceTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressedDataPercentanceTextBox.Location = new System.Drawing.Point(1019, 347);
            this.CompressedDataPercentanceTextBox.Multiline = true;
            this.CompressedDataPercentanceTextBox.Name = "CompressedDataPercentanceTextBox";
            this.CompressedDataPercentanceTextBox.Size = new System.Drawing.Size(143, 35);
            this.CompressedDataPercentanceTextBox.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 91;
            this.label2.Text = "Ποσοστό Συμπιεσμένων Δεδομένων";
            // 
            // SelectAlgorithmBitLabel
            // 
            this.SelectAlgorithmBitLabel.AutoSize = true;
            this.SelectAlgorithmBitLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAlgorithmBitLabel.Location = new System.Drawing.Point(12, 82);
            this.SelectAlgorithmBitLabel.Name = "SelectAlgorithmBitLabel";
            this.SelectAlgorithmBitLabel.Size = new System.Drawing.Size(221, 21);
            this.SelectAlgorithmBitLabel.TabIndex = 90;
            this.SelectAlgorithmBitLabel.Text = "Επέλεξε Bit Μέγεθος Λεξικού :";
            // 
            // compressedFilePathRichTextBox
            // 
            this.compressedFilePathRichTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressedFilePathRichTextBox.Location = new System.Drawing.Point(557, 217);
            this.compressedFilePathRichTextBox.Name = "compressedFilePathRichTextBox";
            this.compressedFilePathRichTextBox.Size = new System.Drawing.Size(170, 32);
            this.compressedFilePathRichTextBox.TabIndex = 89;
            this.compressedFilePathRichTextBox.Text = "";
            // 
            // decompressedTimeConsumedTextBox
            // 
            this.decompressedTimeConsumedTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompressedTimeConsumedTextBox.Location = new System.Drawing.Point(1019, 254);
            this.decompressedTimeConsumedTextBox.Multiline = true;
            this.decompressedTimeConsumedTextBox.Name = "decompressedTimeConsumedTextBox";
            this.decompressedTimeConsumedTextBox.Size = new System.Drawing.Size(145, 38);
            this.decompressedTimeConsumedTextBox.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 87;
            this.label1.Text = "Χρόνος που καταναλώθηκε";
            // 
            // decompressedByteSizeTextBox
            // 
            this.decompressedByteSizeTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompressedByteSizeTextBox.Location = new System.Drawing.Point(1017, 184);
            this.decompressedByteSizeTextBox.Multiline = true;
            this.decompressedByteSizeTextBox.Name = "decompressedByteSizeTextBox";
            this.decompressedByteSizeTextBox.Size = new System.Drawing.Size(147, 32);
            this.decompressedByteSizeTextBox.TabIndex = 80;
            this.decompressedByteSizeTextBox.TextChanged += new System.EventHandler(this.decompressedByteSizeTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(804, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Μέγεθος Αποσυμπιεσμένου";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 21);
            this.label6.TabIndex = 84;
            this.label6.Text = "Στοιχεία Αποσυμπιεσμένου Αρχείου";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(804, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 82;
            this.label7.Text = "Όνομα Αρχείου";
            // 
            // decompressedFileNameTextBox
            // 
            this.decompressedFileNameTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompressedFileNameTextBox.Location = new System.Drawing.Point(995, 216);
            this.decompressedFileNameTextBox.Multiline = true;
            this.decompressedFileNameTextBox.Name = "decompressedFileNameTextBox";
            this.decompressedFileNameTextBox.Size = new System.Drawing.Size(169, 32);
            this.decompressedFileNameTextBox.TabIndex = 83;
            // 
            // timeConsumedTextBox
            // 
            this.timeConsumedTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeConsumedTextBox.Location = new System.Drawing.Point(589, 252);
            this.timeConsumedTextBox.Multiline = true;
            this.timeConsumedTextBox.Name = "timeConsumedTextBox";
            this.timeConsumedTextBox.Size = new System.Drawing.Size(138, 38);
            this.timeConsumedTextBox.TabIndex = 79;
            // 
            // timeConsumedlabel
            // 
            this.timeConsumedlabel.AutoSize = true;
            this.timeConsumedlabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeConsumedlabel.Location = new System.Drawing.Point(382, 258);
            this.timeConsumedlabel.Name = "timeConsumedlabel";
            this.timeConsumedlabel.Size = new System.Drawing.Size(203, 21);
            this.timeConsumedlabel.TabIndex = 78;
            this.timeConsumedlabel.Text = "Χρόνος που καταναλώθηκε";
            // 
            // compressedPercentanceTextBox
            // 
            this.compressedPercentanceTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressedPercentanceTextBox.Location = new System.Drawing.Point(605, 347);
            this.compressedPercentanceTextBox.Multiline = true;
            this.compressedPercentanceTextBox.Name = "compressedPercentanceTextBox";
            this.compressedPercentanceTextBox.Size = new System.Drawing.Size(143, 35);
            this.compressedPercentanceTextBox.TabIndex = 77;
            // 
            // CompressedPercentanceLabel
            // 
            this.CompressedPercentanceLabel.AutoSize = true;
            this.CompressedPercentanceLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressedPercentanceLabel.Location = new System.Drawing.Point(295, 350);
            this.CompressedPercentanceLabel.Name = "CompressedPercentanceLabel";
            this.CompressedPercentanceLabel.Size = new System.Drawing.Size(304, 21);
            this.CompressedPercentanceLabel.TabIndex = 76;
            this.CompressedPercentanceLabel.Text = "Αναλογία Συμπίεσης (Compression Ratio)";
            // 
            // compressedByteSizeTextBox
            // 
            this.compressedByteSizeTextBox.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressedByteSizeTextBox.Location = new System.Drawing.Point(557, 182);
            this.compressedByteSizeTextBox.Multiline = true;
            this.compressedByteSizeTextBox.Name = "compressedByteSizeTextBox";
            this.compressedByteSizeTextBox.Size = new System.Drawing.Size(169, 32);
            this.compressedByteSizeTextBox.TabIndex = 72;
            // 
            // CompressedByteSizeLabel
            // 
            this.CompressedByteSizeLabel.AutoSize = true;
            this.CompressedByteSizeLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressedByteSizeLabel.Location = new System.Drawing.Point(381, 182);
            this.CompressedByteSizeLabel.Name = "CompressedByteSizeLabel";
            this.CompressedByteSizeLabel.Size = new System.Drawing.Size(176, 21);
            this.CompressedByteSizeLabel.TabIndex = 73;
            this.CompressedByteSizeLabel.Text = "Μέγεθος Συμπιεσμένου";
            // 
            // CompressedFileDetailsLabel
            // 
            this.CompressedFileDetailsLabel.AutoSize = true;
            this.CompressedFileDetailsLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressedFileDetailsLabel.Location = new System.Drawing.Point(443, 150);
            this.CompressedFileDetailsLabel.Name = "CompressedFileDetailsLabel";
            this.CompressedFileDetailsLabel.Size = new System.Drawing.Size(230, 21);
            this.CompressedFileDetailsLabel.TabIndex = 75;
            this.CompressedFileDetailsLabel.Text = "Στοιχεία Συμπιεσμένου Αρχείου";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "Όνομα Αρχείου";
            // 
            // LZWDecompressButton
            // 
            this.LZWDecompressButton.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZWDecompressButton.Location = new System.Drawing.Point(940, 84);
            this.LZWDecompressButton.Name = "LZWDecompressButton";
            this.LZWDecompressButton.Size = new System.Drawing.Size(142, 51);
            this.LZWDecompressButton.TabIndex = 71;
            this.LZWDecompressButton.Text = "LZW Αποσυμπίεση";
            this.LZWDecompressButton.UseVisualStyleBackColor = true;
            this.LZWDecompressButton.Click += new System.EventHandler(this.LZWDecompressButton_Click_1);
            // 
            // LZWCompressButton
            // 
            this.LZWCompressButton.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZWCompressButton.Location = new System.Drawing.Point(506, 82);
            this.LZWCompressButton.Name = "LZWCompressButton";
            this.LZWCompressButton.Size = new System.Drawing.Size(142, 51);
            this.LZWCompressButton.TabIndex = 70;
            this.LZWCompressButton.Text = "LZW Συμπίεση";
            this.LZWCompressButton.UseVisualStyleBackColor = true;
            this.LZWCompressButton.Click += new System.EventHandler(this.LZWCompressButton_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(704, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(196, 21);
            this.label18.TabIndex = 69;
            this.label18.Text = "Μέγεθος Αρχείου σε Bytes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(335, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 21);
            this.label17.TabIndex = 68;
            this.label17.Text = "Όνομα Αρχείου";
            // 
            // CompressMenuSelectedFileSize
            // 
            this.CompressMenuSelectedFileSize.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressMenuSelectedFileSize.Location = new System.Drawing.Point(906, 27);
            this.CompressMenuSelectedFileSize.Multiline = true;
            this.CompressMenuSelectedFileSize.Name = "CompressMenuSelectedFileSize";
            this.CompressMenuSelectedFileSize.Size = new System.Drawing.Size(164, 28);
            this.CompressMenuSelectedFileSize.TabIndex = 67;
            // 
            // CompressMenuFileName
            // 
            this.CompressMenuFileName.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompressMenuFileName.Location = new System.Drawing.Point(460, 27);
            this.CompressMenuFileName.Multiline = true;
            this.CompressMenuFileName.Name = "CompressMenuFileName";
            this.CompressMenuFileName.Size = new System.Drawing.Size(182, 28);
            this.CompressMenuFileName.TabIndex = 66;
            // 
            // SelectFileDetailsLabel
            // 
            this.SelectFileDetailsLabel.AutoSize = true;
            this.SelectFileDetailsLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileDetailsLabel.Location = new System.Drawing.Point(12, 27);
            this.SelectFileDetailsLabel.Name = "SelectFileDetailsLabel";
            this.SelectFileDetailsLabel.Size = new System.Drawing.Size(317, 21);
            this.SelectFileDetailsLabel.TabIndex = 65;
            this.SelectFileDetailsLabel.Text = "Στοιχεία ασυμπίεστου επιλεγμένου αρχείου :";
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.BackToMainMenuButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BackToMainMenuButton.Location = new System.Drawing.Point(16, 366);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(142, 51);
            this.BackToMainMenuButton.TabIndex = 64;
            this.BackToMainMenuButton.Text = "Πίσω στην Αρχική Σελίδα";
            this.BackToMainMenuButton.UseVisualStyleBackColor = true;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // BackToSelectFileButton
            // 
            this.BackToSelectFileButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.BackToSelectFileButton.Location = new System.Drawing.Point(16, 304);
            this.BackToSelectFileButton.Name = "BackToSelectFileButton";
            this.BackToSelectFileButton.Size = new System.Drawing.Size(142, 51);
            this.BackToSelectFileButton.TabIndex = 63;
            this.BackToSelectFileButton.Text = "Πίσω";
            this.BackToSelectFileButton.UseVisualStyleBackColor = true;
            this.BackToSelectFileButton.Click += new System.EventHandler(this.BackToSelectFileButton_Click);
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // TextCompressionLzwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextCompressionLzwFormApplication.Properties.Resources.light_green_textured_background;
            this.ClientSize = new System.Drawing.Size(1284, 556);
            this.Controls.Add(this.LZWMethodDetailsGroupBox);
            this.Controls.Add(this.LzwDetailsGroupBox);
            this.Name = "TextCompressionLzwForm";
            this.Text = "TextCompressionLzwForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextCompressionLzwForm_FormClosing);
            this.LzwDetailsGroupBox.ResumeLayout(false);
            this.LzwDetailsGroupBox.PerformLayout();
            this.LZWMethodDetailsGroupBox.ResumeLayout(false);
            this.LZWMethodDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button SelectFileToCompressButton;
        private System.Windows.Forms.Label SelectedFileDetailsLabel;
        private System.Windows.Forms.Label UncompressedByteLabel;
        private System.Windows.Forms.TextBox UncompressedByteSizeTextBox;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.GroupBox LzwDetailsGroupBox;
        private System.Windows.Forms.RichTextBox filePathRichBox;
        private System.Windows.Forms.GroupBox LZWMethodDetailsGroupBox;
        private System.Windows.Forms.Button SelectFileMenuGoBackButton;
        private System.Windows.Forms.Button ProceedToCompressionButton;
        public System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox selectedMaxBitSizeTextbox;
        private System.Windows.Forms.CheckedListBox AlgorithmChooseBitCheckbox;
        private System.Windows.Forms.TextBox CompressedDataPercentanceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectAlgorithmBitLabel;
        private System.Windows.Forms.RichTextBox compressedFilePathRichTextBox;
        public System.Windows.Forms.TextBox decompressedTimeConsumedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decompressedByteSizeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox decompressedFileNameTextBox;
        public System.Windows.Forms.TextBox timeConsumedTextBox;
        private System.Windows.Forms.Label timeConsumedlabel;
        private System.Windows.Forms.TextBox compressedPercentanceTextBox;
        private System.Windows.Forms.Label CompressedPercentanceLabel;
        private System.Windows.Forms.TextBox compressedByteSizeTextBox;
        private System.Windows.Forms.Label CompressedByteSizeLabel;
        private System.Windows.Forms.Label CompressedFileDetailsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LZWDecompressButton;
        private System.Windows.Forms.Button LZWCompressButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CompressMenuSelectedFileSize;
        private System.Windows.Forms.TextBox CompressMenuFileName;
        private System.Windows.Forms.Label SelectFileDetailsLabel;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Button BackToSelectFileButton;


    }
}