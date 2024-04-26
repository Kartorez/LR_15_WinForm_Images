namespace LR_15_WinForm_Images
{

    public partial class Form1 : Form
    {
        public List<string> FilePath;
        public Form1()
        {
            InitializeComponent();
            FilePath = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateList();

        }
        /*Для папки вибраної користувачем отримати список зображень в ній.
Відобразити його в ListBox. При виборі зображення – відобразити його в
ImageView*/
        private void UpdateList()
        {
            ListFileImages.Items.Clear();
            foreach (string FileEntry in FilePath)
            {
                //â³äîáðàçèâ ëèøå íàçâè
                ListFileImages.Items.Add(Path.GetFileName(FileEntry));
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            /* Вибір файлів вручну
             * openFileDialog1.Filter = "Image Files (*.jpg)|*.jpg|(*.JPEG)|*.JPEG|All Files (*.*)|*.*";
             if (openFileDialog.ShowDialog() == DialogResult.OK)
             {

                 string[] fileEntries = openFileDialog.FileNames;
                 foreach (string fileEntry in fileEntries)
                 {
                     FilePath.Add(fileEntry);
                 }
                 UpdateList();

             }*/
            // вибір усього з папки
            FilePath.Clear();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly);
                    FilePath.Clear();
                    foreach (string file in files)
                    {
                        string extension = Path.GetExtension(file).ToLower();
                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif")
                        {
                            FilePath.Add(file);
                        }
                    }

                    UpdateList();
            }
        }

        private void ListFileImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListFileImages.SelectedItems.Count > 0)
            {
                string SelectedImagePath = FilePath[ListFileImages.SelectedItems[0].Index];
                ImagesBox.ImageLocation = SelectedImagePath;
            }
        }
    }
}
