namespace LR_15_WinForm_Images
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenFolder = new Button();
            ListFileImages = new ListView();
            openFileDialog = new OpenFileDialog();
            ImagesBox = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)ImagesBox).BeginInit();
            SuspendLayout();
            // 
            // OpenFolder
            // 
            OpenFolder.Location = new Point(12, 12);
            OpenFolder.Name = "OpenFolder";
            OpenFolder.Size = new Size(91, 32);
            OpenFolder.TabIndex = 0;
            OpenFolder.Text = "Open Folder";
            OpenFolder.UseVisualStyleBackColor = true;
            OpenFolder.Click += OpenFolder_Click;
            // 
            // ListFileImages
            // 
            ListFileImages.Location = new Point(14, 67);
            ListFileImages.Name = "ListFileImages";
            ListFileImages.Size = new Size(271, 168);
            ListFileImages.TabIndex = 1;
            ListFileImages.UseCompatibleStateImageBehavior = false;
            ListFileImages.SelectedIndexChanged += ListFileImages_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "file";
            openFileDialog.Multiselect = true;
            openFileDialog.ShowHiddenFiles = true;
            // 
            // ImagesBox
            // 
            ImagesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImagesBox.Location = new Point(333, 68);
            ImagesBox.Name = "ImagesBox";
            ImagesBox.Size = new Size(240, 163);
            ImagesBox.TabIndex = 2;
            ImagesBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 243);
            Controls.Add(ImagesBox);
            Controls.Add(ListFileImages);
            Controls.Add(OpenFolder);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImagesBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OpenFolder;
        private ListView ListFileImages;
        private OpenFileDialog openFileDialog;
        private PictureBox ImagesBox;
        private FolderBrowserDialog folderBrowserDialog;
    }
}