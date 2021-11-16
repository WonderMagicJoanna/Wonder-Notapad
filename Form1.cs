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

namespace WM__Notapad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filelocation_;
       

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Wonder Magic Joanna https://wonder-magic.tk");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void copy_Click(object sender, EventArgs e)
        {
            tekst.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            tekst.Paste();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tekst.Clear();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            tekst.Redo();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            tekst.Undo();
        }

        private void open__Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
              Stream x = op.OpenFile();
                filelocation_ = op.FileName;
                using (StreamReader y = new StreamReader(x))
                {
                    tekst.Text = y.ReadToEnd();
                }

            }
            

        }

        private void saveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(tekst.Text);
                file.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(filelocation_, tekst.Text);

        }

        private void Font1_ButtonClick(object sender, EventArgs e)
        {
            
            fontdlg.ShowColor = true;
            fontdlg.ShowApply = true;
            fontdlg.ShowEffects = true;
            fontdlg.ShowHelp = true;
            fontdlg.MinSize = 1;
            if (fontdlg.ShowDialog() != DialogResult.Cancel)
            {
               
               tekst.Font = fontdlg.Font;
                tekst.ForeColor = fontdlg.Color;
               
            }

        }

        private void hidebutton_Click(object sender, EventArgs e)
        {
            
            if(toolStrip1.Visible == false)
            {
                toolStrip1.Visible = true;
            }
            else
            {
                toolStrip1.Visible = false;
            }
            showhide.Visible = true;
        }

        private void tekst_TextChanged(object sender, EventArgs e)
        {

        }

        private void showhide_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            showhide.Visible = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void colortekst_Click(object sender, EventArgs e)
        {
            
            if (colorchoose.ShowDialog() != DialogResult.Cancel)
            {

                tekst.BackColor = colorchoose.Color;
               

            }
        }

        private void close__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}