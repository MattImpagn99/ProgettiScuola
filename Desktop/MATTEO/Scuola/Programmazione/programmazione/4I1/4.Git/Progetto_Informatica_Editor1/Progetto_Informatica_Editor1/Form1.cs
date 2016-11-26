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

            string path = @"C:\Users\Ospite\Desktop\MATTEO\Scuola\Programmazione\programmazione\4I1\4.Git\stringa.txt";
            string riga;
            StreamReader sr = new StreamReader(path);
            while ((riga = sr.ReadLine()) != null)
            {
                richTextBox1.Text = richTextBox1.Text + riga;
            }
        }
        private void UpdateBrowser()
        {
            webBrowser2.DocumentText = richTextBox1.Text.Replace("CSS", richTextBox2.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateBrowser();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateBrowser();
        }                       

        private void btn_Save_File_Html(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "txt Files (*txt)|*.txt|All Files (*.*)|*.*|html (*.html)|*.html";
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
            savefiledialog.Filter = "txt Files (*txt)|*.txt|All Files (*.*)|*.*|html (*.html)|*.html";
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

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btn_Esc(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
