namespace TextCompressionLzwFormApplication
{
    partial class TextCompressionTutorialLzwForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextCompressionTutorialLzwForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LZWCompressButton = new System.Windows.Forms.Button();
            this.EnterTextLabel = new System.Windows.Forms.Label();
            this.LZWDecompressionButton = new System.Windows.Forms.Button();
            this.CloseDetailsButton = new System.Windows.Forms.Button();
            this.GeneralDetailsInfoBox = new System.Windows.Forms.RichTextBox();
            this.GeneralWorkDetailButton = new System.Windows.Forms.Button();
            this.lzwHelpGroupBox = new System.Windows.Forms.GroupBox();
            this.detailLZWTable = new System.Windows.Forms.Panel();
            this.lzwCompressionDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.LoopCounterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCharColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousCharColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPlusPreviousCharColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDictionaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDictionaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewPreviousCharColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lzwDecompressionDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.GeneralDetailsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoopCounter2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCodeWordAndStringColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousCodeWordDetailsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousCharKeptStringColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCharKeptStringColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedToDictionaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompressedTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EnteredTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CompressedTextLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackToSelectFileButton = new System.Windows.Forms.Button();
            this.lzwHelpGroupBox.SuspendLayout();
            this.detailLZWTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lzwCompressionDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lzwDecompressionDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LZWCompressButton
            // 
            this.LZWCompressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZWCompressButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LZWCompressButton.Location = new System.Drawing.Point(204, 78);
            this.LZWCompressButton.Name = "LZWCompressButton";
            this.LZWCompressButton.Size = new System.Drawing.Size(142, 51);
            this.LZWCompressButton.TabIndex = 1;
            this.LZWCompressButton.Text = "Συμπίεση";
            this.LZWCompressButton.UseVisualStyleBackColor = true;
            this.LZWCompressButton.Click += new System.EventHandler(this.LZWCompressButton_Button);
            // 
            // EnterTextLabel
            // 
            this.EnterTextLabel.AutoSize = true;
            this.EnterTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnterTextLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EnterTextLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.EnterTextLabel.Location = new System.Drawing.Point(11, 35);
            this.EnterTextLabel.Name = "EnterTextLabel";
            this.EnterTextLabel.Size = new System.Drawing.Size(164, 22);
            this.EnterTextLabel.TabIndex = 4;
            this.EnterTextLabel.Text = "Κείμενο για συμπίεση:";
            // 
            // LZWDecompressionButton
            // 
            this.LZWDecompressionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZWDecompressionButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LZWDecompressionButton.Location = new System.Drawing.Point(704, 78);
            this.LZWDecompressionButton.Name = "LZWDecompressionButton";
            this.LZWDecompressionButton.Size = new System.Drawing.Size(142, 51);
            this.LZWDecompressionButton.TabIndex = 7;
            this.LZWDecompressionButton.Text = "Αποσυμπίεση";
            this.LZWDecompressionButton.UseVisualStyleBackColor = true;
            this.LZWDecompressionButton.Click += new System.EventHandler(this.LZWDecompressionButton_Click);
            // 
            // CloseDetailsButton
            // 
            this.CloseDetailsButton.Location = new System.Drawing.Point(976, 47);
            this.CloseDetailsButton.Name = "CloseDetailsButton";
            this.CloseDetailsButton.Size = new System.Drawing.Size(24, 23);
            this.CloseDetailsButton.TabIndex = 16;
            this.CloseDetailsButton.Text = " x";
            this.CloseDetailsButton.UseVisualStyleBackColor = true;
            this.CloseDetailsButton.Visible = false;
            this.CloseDetailsButton.Click += new System.EventHandler(this.CloseDetailsButton_Click);
            // 
            // GeneralDetailsInfoBox
            // 
            this.GeneralDetailsInfoBox.Location = new System.Drawing.Point(976, 66);
            this.GeneralDetailsInfoBox.Name = "GeneralDetailsInfoBox";
            this.GeneralDetailsInfoBox.Size = new System.Drawing.Size(314, 84);
            this.GeneralDetailsInfoBox.TabIndex = 15;
            this.GeneralDetailsInfoBox.Text = resources.GetString("GeneralDetailsInfoBox.Text");
            this.GeneralDetailsInfoBox.Visible = false;
            // 
            // GeneralWorkDetailButton
            // 
            this.GeneralWorkDetailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneralWorkDetailButton.Location = new System.Drawing.Point(1189, 37);
            this.GeneralWorkDetailButton.Name = "GeneralWorkDetailButton";
            this.GeneralWorkDetailButton.Size = new System.Drawing.Size(89, 23);
            this.GeneralWorkDetailButton.TabIndex = 14;
            this.GeneralWorkDetailButton.Text = "Πληροφορίες";
            this.GeneralWorkDetailButton.UseVisualStyleBackColor = true;
            this.GeneralWorkDetailButton.Click += new System.EventHandler(this.GeneralWorkDetailButton_Click);
            // 
            // lzwHelpGroupBox
            // 
            this.lzwHelpGroupBox.BackgroundImage = global::TextCompressionLzwFormApplication.Properties.Resources.light_green_textured_background;
            this.lzwHelpGroupBox.Controls.Add(this.detailLZWTable);
            this.lzwHelpGroupBox.Controls.Add(this.CompressedTextRichTextBox);
            this.lzwHelpGroupBox.Controls.Add(this.EnteredTextRichTextBox);
            this.lzwHelpGroupBox.Controls.Add(this.CompressedTextLabel);
            this.lzwHelpGroupBox.Controls.Add(this.LZWCompressButton);
            this.lzwHelpGroupBox.Controls.Add(this.EnterTextLabel);
            this.lzwHelpGroupBox.Controls.Add(this.LZWDecompressionButton);
            this.lzwHelpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lzwHelpGroupBox.Location = new System.Drawing.Point(29, 154);
            this.lzwHelpGroupBox.Name = "lzwHelpGroupBox";
            this.lzwHelpGroupBox.Size = new System.Drawing.Size(1209, 432);
            this.lzwHelpGroupBox.TabIndex = 17;
            this.lzwHelpGroupBox.TabStop = false;
            // 
            // detailLZWTable
            // 
            this.detailLZWTable.Controls.Add(this.lzwCompressionDetailDataGridView);
            this.detailLZWTable.Controls.Add(this.lzwDecompressionDetailDataGridView);
            this.detailLZWTable.Location = new System.Drawing.Point(23, 135);
            this.detailLZWTable.Name = "detailLZWTable";
            this.detailLZWTable.Size = new System.Drawing.Size(1171, 300);
            this.detailLZWTable.TabIndex = 18;
            // 
            // lzwCompressionDetailDataGridView
            // 
            this.lzwCompressionDetailDataGridView.AllowUserToOrderColumns = true;
            this.lzwCompressionDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lzwCompressionDetailDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lzwCompressionDetailDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.lzwCompressionDetailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lzwCompressionDetailDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lzwCompressionDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lzwCompressionDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoopCounterColumn,
            this.CurrentCharColumn,
            this.PreviousCharColumn,
            this.CurrentPlusPreviousCharColumn,
            this.InDictionaryColumn,
            this.AddDictionaryColumn,
            this.NewPreviousCharColumn,
            this.OutputColumn});
            this.lzwCompressionDetailDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lzwCompressionDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lzwCompressionDetailDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.lzwCompressionDetailDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lzwCompressionDetailDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lzwCompressionDetailDataGridView.Name = "lzwCompressionDetailDataGridView";
            this.lzwCompressionDetailDataGridView.Size = new System.Drawing.Size(1171, 300);
            this.lzwCompressionDetailDataGridView.TabIndex = 8;
            // 
            // LoopCounterColumn
            // 
            this.LoopCounterColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoopCounterColumn.HeaderText = "Επανάληψη";
            this.LoopCounterColumn.Name = "LoopCounterColumn";
            this.LoopCounterColumn.Width = 121;
            // 
            // CurrentCharColumn
            // 
            this.CurrentCharColumn.HeaderText = "Τρέχων Χαρακτήρας";
            this.CurrentCharColumn.Name = "CurrentCharColumn";
            // 
            // PreviousCharColumn
            // 
            this.PreviousCharColumn.HeaderText = "Προηγούμενος Χαρακτήρας";
            this.PreviousCharColumn.Name = "PreviousCharColumn";
            // 
            // CurrentPlusPreviousCharColumn
            // 
            this.CurrentPlusPreviousCharColumn.HeaderText = "Προηγούμενος + Τρέχων Χαρακτήρες (P+C)";
            this.CurrentPlusPreviousCharColumn.Name = "CurrentPlusPreviousCharColumn";
            // 
            // InDictionaryColumn
            // 
            this.InDictionaryColumn.HeaderText = "Ύπαρξη στην Βιβλιοθήκη";
            this.InDictionaryColumn.Name = "InDictionaryColumn";
            // 
            // AddDictionaryColumn
            // 
            this.AddDictionaryColumn.HeaderText = "Προστέθηκε στην Βιβλιοθήκη";
            this.AddDictionaryColumn.Name = "AddDictionaryColumn";
            // 
            // NewPreviousCharColumn
            // 
            this.NewPreviousCharColumn.HeaderText = "Νέος Προηγούμενος Χαρακτήρας";
            this.NewPreviousCharColumn.Name = "NewPreviousCharColumn";
            // 
            // OutputColumn
            // 
            this.OutputColumn.HeaderText = "Output";
            this.OutputColumn.Name = "OutputColumn";
            // 
            // lzwDecompressionDetailDataGridView
            // 
            this.lzwDecompressionDetailDataGridView.AllowUserToOrderColumns = true;
            this.lzwDecompressionDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lzwDecompressionDetailDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lzwDecompressionDetailDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.lzwDecompressionDetailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lzwDecompressionDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lzwDecompressionDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GeneralDetailsColumn,
            this.LoopCounter2Column,
            this.CurrentCodeWordAndStringColumn,
            this.PreviousCodeWordDetailsColumn,
            this.PreviousCharKeptStringColumn,
            this.CurrentCharKeptStringColumn,
            this.AddedToDictionaryColumn,
            this.Output2Column});
            this.lzwDecompressionDetailDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lzwDecompressionDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lzwDecompressionDetailDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.lzwDecompressionDetailDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lzwDecompressionDetailDataGridView.Name = "lzwDecompressionDetailDataGridView";
            this.lzwDecompressionDetailDataGridView.Size = new System.Drawing.Size(1171, 300);
            this.lzwDecompressionDetailDataGridView.TabIndex = 8;
            this.lzwDecompressionDetailDataGridView.Visible = false;
            // 
            // GeneralDetailsColumn
            // 
            this.GeneralDetailsColumn.HeaderText = "Γενικές Πληροφορίες";
            this.GeneralDetailsColumn.Name = "GeneralDetailsColumn";
            // 
            // LoopCounter2Column
            // 
            this.LoopCounter2Column.HeaderText = "Επανάληψη";
            this.LoopCounter2Column.Name = "LoopCounter2Column";
            // 
            // CurrentCodeWordAndStringColumn
            // 
            this.CurrentCodeWordAndStringColumn.HeaderText = "Λεπτομέρειες τρέχουσας λέξης κώδικα";
            this.CurrentCodeWordAndStringColumn.Name = "CurrentCodeWordAndStringColumn";
            // 
            // PreviousCodeWordDetailsColumn
            // 
            this.PreviousCodeWordDetailsColumn.HeaderText = "Λεπτομέρειες προηγούμενης λέξης κώδικα";
            this.PreviousCodeWordDetailsColumn.Name = "PreviousCodeWordDetailsColumn";
            // 
            // PreviousCharKeptStringColumn
            // 
            this.PreviousCharKeptStringColumn.HeaderText = "Κρατούμενο από τον προηγούμενο χαρακτήρα";
            this.PreviousCharKeptStringColumn.Name = "PreviousCharKeptStringColumn";
            // 
            // CurrentCharKeptStringColumn
            // 
            this.CurrentCharKeptStringColumn.HeaderText = "Κρατούμενο από τον τρέχων χαρακτήρα";
            this.CurrentCharKeptStringColumn.Name = "CurrentCharKeptStringColumn";
            // 
            // AddedToDictionaryColumn
            // 
            this.AddedToDictionaryColumn.HeaderText = "Προστέθηκε στην Βιβλιοθήκη";
            this.AddedToDictionaryColumn.Name = "AddedToDictionaryColumn";
            // 
            // Output2Column
            // 
            this.Output2Column.HeaderText = "Output";
            this.Output2Column.Name = "Output2Column";
            // 
            // CompressedTextRichTextBox
            // 
            this.CompressedTextRichTextBox.Location = new System.Drawing.Point(780, 35);
            this.CompressedTextRichTextBox.Name = "CompressedTextRichTextBox";
            this.CompressedTextRichTextBox.Size = new System.Drawing.Size(221, 22);
            this.CompressedTextRichTextBox.TabIndex = 12;
            this.CompressedTextRichTextBox.Text = "";
            // 
            // EnteredTextRichTextBox
            // 
            this.EnteredTextRichTextBox.Location = new System.Drawing.Point(204, 32);
            this.EnteredTextRichTextBox.Name = "EnteredTextRichTextBox";
            this.EnteredTextRichTextBox.Size = new System.Drawing.Size(218, 25);
            this.EnteredTextRichTextBox.TabIndex = 11;
            this.EnteredTextRichTextBox.Text = "";
            // 
            // CompressedTextLabel
            // 
            this.CompressedTextLabel.AutoSize = true;
            this.CompressedTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CompressedTextLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CompressedTextLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CompressedTextLabel.Location = new System.Drawing.Point(576, 35);
            this.CompressedTextLabel.Name = "CompressedTextLabel";
            this.CompressedTextLabel.Size = new System.Drawing.Size(166, 22);
            this.CompressedTextLabel.TabIndex = 10;
            this.CompressedTextLabel.Text = "Συμπιεσμένο Κείμενο:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TextCompressionLzwFormApplication.Properties.Resources.newLZWHeader;
            this.pictureBox1.Location = new System.Drawing.Point(513, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 111);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BackToSelectFileButton
            // 
            this.BackToSelectFileButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BackToSelectFileButton.Location = new System.Drawing.Point(29, 610);
            this.BackToSelectFileButton.Name = "BackToSelectFileButton";
            this.BackToSelectFileButton.Size = new System.Drawing.Size(142, 51);
            this.BackToSelectFileButton.TabIndex = 64;
            this.BackToSelectFileButton.Text = "Πίσω";
            this.BackToSelectFileButton.UseVisualStyleBackColor = true;
            this.BackToSelectFileButton.Click += new System.EventHandler(this.BackToSelectFileButton_Click);
            // 
            // TextCompressionTutorialLzwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextCompressionLzwFormApplication.Properties.Resources.light_green_textured_background;
            this.ClientSize = new System.Drawing.Size(1304, 682);
            this.Controls.Add(this.BackToSelectFileButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lzwHelpGroupBox);
            this.Controls.Add(this.CloseDetailsButton);
            this.Controls.Add(this.GeneralDetailsInfoBox);
            this.Controls.Add(this.GeneralWorkDetailButton);
            this.Name = "TextCompressionTutorialLzwForm";
            this.Text = "Text Compression - LZW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextCompressionTutorialLzwForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lzwHelpGroupBox.ResumeLayout(false);
            this.lzwHelpGroupBox.PerformLayout();
            this.detailLZWTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lzwCompressionDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lzwDecompressionDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LZWCompressButton;
        private System.Windows.Forms.Label EnterTextLabel;
        private System.Windows.Forms.Button LZWDecompressionButton;
        private System.Windows.Forms.Button CloseDetailsButton;
        private System.Windows.Forms.RichTextBox GeneralDetailsInfoBox;
        private System.Windows.Forms.Button GeneralWorkDetailButton;
        private System.Windows.Forms.GroupBox lzwHelpGroupBox;
        public System.Windows.Forms.DataGridView lzwCompressionDetailDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn LoopCounterColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn CurrentCharColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn PreviousCharColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn CurrentPlusPreviousCharColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn InDictionaryColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn AddDictionaryColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn NewPreviousCharColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn OutputColumn;
        public System.Windows.Forms.DataGridView lzwDecompressionDetailDataGridView;
        private System.Windows.Forms.Label CompressedTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralDetailsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoopCounter2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCodeWordAndStringColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousCodeWordDetailsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousCharKeptStringColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCharKeptStringColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedToDictionaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output2Column;
        public System.Windows.Forms.RichTextBox CompressedTextRichTextBox;
        private System.Windows.Forms.RichTextBox EnteredTextRichTextBox;
        private System.Windows.Forms.Panel detailLZWTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackToSelectFileButton;
    }
}

