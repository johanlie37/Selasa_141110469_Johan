using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("16");
            comboBox1.Items.Add("18");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("22");
            comboBox1.Items.Add("24");
            comboBox1.Items.Add("26");
            comboBox1.Items.Add("28");
            comboBox1.Items.Add("36");
            comboBox1.Items.Add("48");
            comboBox1.Items.Add("72");
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox2.Items.Add(font.Name.ToString());
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (bold.FlatStyle == FlatStyle.Standard)
            {
                bold.FlatStyle = FlatStyle.Popup;


            }
            else
            {
                bold.FlatStyle = FlatStyle.Standard;

            }
            if (bold.FlatStyle == FlatStyle.Popup)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Bold);

            }
        }

        private void itallic_Click(object sender, EventArgs e)
        {

            if (itallic.FlatStyle == FlatStyle.Standard)
            {
                itallic.FlatStyle = FlatStyle.Popup;


            }
            else
            {
                itallic.FlatStyle = FlatStyle.Standard;

            }
            if (itallic.FlatStyle == FlatStyle.Popup)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Italic);

            }

        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (underline.FlatStyle == FlatStyle.Standard)
            {
                underline.FlatStyle = FlatStyle.Popup;


            }
            else
            {
                underline.FlatStyle = FlatStyle.Standard;

            }
            if (underline.FlatStyle == FlatStyle.Popup)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Underline);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(comboBox1.SelectedItem), richTextBox1.Font.Style);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBox2.Text, richTextBox1.Font.Size);
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();
            if (warna == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
    }

