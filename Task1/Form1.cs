using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;

namespace Task1
{
    public partial class Form1 : Form
    {
        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            return files;
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Task1_Click(object sender, EventArgs e)
        {
            var files = GetFiles("V:\\ispp21")
              .Select(file => new { file.FullName, Size = file.Length << 10 });
            var result = new List<FileInfo>();
            FIlesdataGridView1.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var files1 = GetFiles(@"V:\ispp21");
            var results1 = files1.Select(f => new { f.Extension }).Distinct();
            FIlesdataGridView1.DataSource = results1.ToList();
        }
    }
}
