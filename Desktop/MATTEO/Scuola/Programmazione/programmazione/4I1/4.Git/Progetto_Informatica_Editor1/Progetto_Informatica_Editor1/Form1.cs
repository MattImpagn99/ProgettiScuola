using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Progetto_Informatica_Editor1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = richTextBox1.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }    

        

        private void btn_Save_File_Html(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(savefiledialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void btn_Save_File_Css(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(savefiledialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox2.Text);
                }
            }
        }
        private void btn_Open_File(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(openfiledialog.FileName));
                richTextBox1.Text = sr.ReadToEnd();
                sr.Dispose();
            }
        }
    }
}
