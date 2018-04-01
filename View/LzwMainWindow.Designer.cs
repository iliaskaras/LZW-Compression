namespace TextCompressionLzwFormApplication.View
{
    partial class LzwMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LzwMainWindow));
            this.GeneralWorkDetailButton = new System.Windows.Forms.Button();
            this.GeneralDetailsInfoBox = new System.Windows.Forms.RichTextBox();
            this.CloseDetailsButton = new System.Windows.Forms.Button();
            this.LZWHelpTutorial = new System.Windows.Forms.Button();
            this.LZWAlgorithm = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralWorkDetailButton
            // 
            this.GeneralWorkDetailButton.Location = new System.Drawing.Point(750, 12);
            this.GeneralWorkDetailButton.Name = "GeneralWorkDetailButton";
            this.GeneralWorkDetailButton.Size = new System.Drawing.Size(89, 23);
            this.GeneralWorkDetailButton.TabIndex = 3;
            this.GeneralWorkDetailButton.Text = "Πληροφορίες";
            this.GeneralWorkDetailButton.UseVisualStyleBackColor = true;
            this.GeneralWorkDetailButton.Click += new System.EventHandler(this.GeneralWorkDetailButton_Click);
            // 
            // GeneralDetailsInfoBox
            // 
            this.GeneralDetailsInfoBox.Location = new System.Drawing.Point(537, 41);
            this.GeneralDetailsInfoBox.Name = "GeneralDetailsInfoBox";
            this.GeneralDetailsInfoBox.Size = new System.Drawing.Size(314, 84);
            this.GeneralDetailsInfoBox.TabIndex = 4;
            this.GeneralDetailsInfoBox.Text = resources.GetString("GeneralDetailsInfoBox.Text");
            this.GeneralDetailsInfoBox.Visible = false;
            this.GeneralDetailsInfoBox.TextChanged += new System.EventHandler(this.GeneralDetailsInfoBox_TextChanged);
            // 
            // CloseDetailsButton
            // 
            this.CloseDetailsButton.Location = new System.Drawing.Point(537, 22);
            this.CloseDetailsButton.Name = "CloseDetailsButton";
            this.CloseDetailsButton.Size = new System.Drawing.Size(24, 23);
            this.CloseDetailsButton.TabIndex = 5;
            this.CloseDetailsButton.Text = " x";
            this.CloseDetailsButton.UseVisualStyleBackColor = true;
            this.CloseDetailsButton.Visible = false;
            this.CloseDetailsButton.Click += new System.EventHandler(this.CloseDetailsButton_Click);
            // 
            // LZWHelpTutorial
            // 
            this.LZWHelpTutorial.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LZWHelpTutorial.Location = new System.Drawing.Point(143, 305);
            this.LZWHelpTutorial.Name = "LZWHelpTutorial";
            this.LZWHelpTutorial.Size = new System.Drawing.Size(148, 51);
            this.LZWHelpTutorial.TabIndex = 6;
            this.LZWHelpTutorial.Text = "LZW Αλγόριθμος Βοηθητικής Έκδοσης";
            this.LZWHelpTutorial.UseVisualStyleBackColor = true;
            this.LZWHelpTutorial.Click += new System.EventHandler(this.LZWHelpTutorial_Click);
            // 
            // LZWAlgorithm
            // 
            this.LZWAlgorithm.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LZWAlgorithm.Location = new System.Drawing.Point(143, 371);
            this.LZWAlgorithm.Name = "LZWAlgorithm";
            this.LZWAlgorithm.Size = new System.Drawing.Size(148, 51);
            this.LZWAlgorithm.TabIndex = 7;
            this.LZWAlgorithm.Text = "LZW Αλγόριθμος";
            this.LZWAlgorithm.UseVisualStyleBackColor = true;
            this.LZWAlgorithm.Click += new System.EventHandler(this.LZWAlgorithm_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TextCompressionLzwFormApplication.Properties.Resources.workDetails;
            this.pictureBox3.Location = new System.Drawing.Point(143, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(567, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TextCompressionLzwFormApplication.Properties.Resources.logo_teiser;
            this.pictureBox2.Location = new System.Drawing.Point(342, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TextCompressionLzwFormApplication.Properties.Resources.mPageBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LzwMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextCompressionLzwFormApplication.Properties.Resources.light_green_textured_background;
            this.ClientSize = new System.Drawing.Size(851, 571);
            this.Controls.Add(this.LZWAlgorithm);
            this.Controls.Add(this.LZWHelpTutorial);
            this.Controls.Add(this.CloseDetailsButton);
            this.Controls.Add(this.GeneralDetailsInfoBox);
            this.Controls.Add(this.GeneralWorkDetailButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LzwMainWindow";
            this.Text = "LzwMainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LzwMainWindow_FormClosing);
            this.Load += new System.EventHandler(this.LzwMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button GeneralWorkDetailButton;
        private System.Windows.Forms.RichTextBox GeneralDetailsInfoBox;
        private System.Windows.Forms.Button CloseDetailsButton;
        private System.Windows.Forms.Button LZWHelpTutorial;
        private System.Windows.Forms.Button LZWAlgorithm;

    }
}