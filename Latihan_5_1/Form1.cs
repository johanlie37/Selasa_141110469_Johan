using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                jenisFont.Items.Add(oneFontFamily.Name);
            }

            int[] uk = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int i in uk)
            {
                comboBoxSize.Items.Add(i);
            }

            jenisFont.Text = this.Konten.Font.Name.ToString();
            comboBoxSize.Text = this.Konten.Font.Size.ToString();

         
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void ubahFontdanUkuran()
        {
            Font fontLama, fontBaru;
            string namaFont;
            float ukuran = 12;
            FontStyle gaya = 0;
            byte charset = 0;

            namaFont = jenisFont.Text;

            if (string.IsNullOrEmpty(comboBoxSize.Text))
            {
                ukuran = 12;
            }
            else
            {
                ukuran = float.Parse(comboBoxSize.Text);
            }

            fontLama = Konten.SelectionFont;

            if (fontLama == null)
            {
                gaya = FontStyle.Regular;
            }
            else
            {
                gaya = fontLama.Style;
                charset = fontLama.GdiCharSet;
            }

            fontBaru = new Font(namaFont, ukuran, gaya, GraphicsUnit.Point, charset);
            Konten.SelectionFont = fontBaru;
            Konten.Focus();
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            string filename = "";

            saveDlg.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt"; //Don't include space when when typing *.ext. Because space is treated as extension
            saveDlg.DefaultExt = "*.rtf";
            saveDlg.FilterIndex = 1;
            saveDlg.Title = "Save the contents";

            DialogResult retval = saveDlg.ShowDialog();
            if (retval == DialogResult.OK)
                filename = saveDlg.FileName;
            else
                return;

            RichTextBoxStreamType stream_type;
            if (saveDlg.FilterIndex == 2)
                stream_type = RichTextBoxStreamType.PlainText;
            else
                stream_type = RichTextBoxStreamType.RichText;

            //Richtext 01_05: Now its time to save the content
            Konten.SaveFile(filename, stream_type);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_open = new OpenFileDialog();

            file_open.Filter = "Rich Text File (*.rtf)|*.rtf| Plain Text File (*.txt)|*.txt";
            file_open.FilterIndex = 1;
            file_open.Title = "Open text or RTF file";

            RichTextBoxStreamType stream_type;
            stream_type = RichTextBoxStreamType.RichText;
            if (DialogResult.OK == file_open.ShowDialog())
            {
                if (string.IsNullOrEmpty(file_open.FileName))
                    return;
                if (file_open.FilterIndex == 2)
                    stream_type = RichTextBoxStreamType.PlainText;
                Konten.LoadFile(file_open.FileName, stream_type);
            }
        }

        private void closeFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void bold_Click(object sender, EventArgs e)
        {
            Font cekFont = Konten.SelectionFont;
            if (cekFont != null)
            {
                Konten.SelectionFont = new Font(cekFont, cekFont.Style ^ FontStyle.Bold);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ittalic_Click(object sender, EventArgs e)
        {
            Font cekFont = Konten.SelectionFont;
            if (cekFont != null)
            {
                Konten.SelectionFont = new Font(cekFont, cekFont.Style ^ FontStyle.Italic);
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            Font cekFont = Konten.SelectionFont;
            if (cekFont != null)
            {
                Konten.SelectionFont = new Font(cekFont, cekFont.Style ^ FontStyle.Underline);
            }
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            var warna = new ColorDialog();

            if (warna.ShowDialog() == DialogResult.OK)
            {
                Konten.SelectionColor = warna.Color;
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void Konten_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.klikKanan.Show(this, e.X, e.Y);
                if (Konten.SelectionLength == 0)
                {
                    klikKanan.Items[0].Enabled = false;
                    klikKanan.Items[2].Enabled = false;
                    klikKanan.Items[4].Enabled = false;
                }
                else
                {
                    klikKanan.Items[0].Enabled = true;
                    klikKanan.Items[2].Enabled = true;
                    klikKanan.Items[4].Enabled = true;
                }
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konten.Copy();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konten.Paste();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konten.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konten.SelectedText = "";
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void jenisFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ubahFontdanUkuran();
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ubahFontdanUkuran();
        }

        private void Konten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tree_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                Konten.BackColor = colorDialog1.Color;
            }
        }

        private void bgcolor_Click(object sender, EventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                Konten.BackColor = colorDialog1.Color;
            }
        }
    }
    }
