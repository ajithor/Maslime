using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eqcl()
        {
            string equals = "=";
            string comma = ",", alpADD = "ADD", alpadd = "add", alpMOV = "MOV", alpmov = "mov" ;

            int index0 = richTextBox2.Text.IndexOf(equals);
            int length0 = equals.Length;

            int indexcomma = richTextBox2.Text.IndexOf(comma);
            int lengthcomma = 1;

            int indexadd = richTextBox2.Text.IndexOf(alpadd);
            int indexADD = richTextBox2.Text.IndexOf(alpADD);
            int indexmov = richTextBox2.Text.IndexOf(alpmov);
            int indexMOV = richTextBox2.Text.IndexOf(alpMOV);

            //int lengthadd = 3, lengthADD = 3, lengthmov = 3, lengthMOV = 3;

            if (index0 >= 0)
            {
                richTextBox2.Select(index0, length0);
                richTextBox2.SelectionColor = Color.Red;
            }
            if (indexcomma >= 0)
            {
                richTextBox2.Select(indexcomma, lengthcomma);
                richTextBox2.SelectionColor = Color.Red;
            }
            if (indexadd >= 0)
            {
                richTextBox2.Select(indexadd, alpadd.Length);
                richTextBox2.SelectionColor = Color.GreenYellow;
            }
            if (indexADD >= 0)
            {
                richTextBox2.Select(indexADD, alpADD.Length);
                richTextBox2.SelectionColor = Color.GreenYellow;


            }
            if (indexmov >= 0)
            {
                richTextBox2.Select(indexmov, alpmov.Length);
                richTextBox2.SelectionColor = Color.GreenYellow;
                    
            }
            if (indexMOV >= 0)
            {
                richTextBox2.Select(indexMOV, alpMOV.Length);
                richTextBox2.SelectionColor = Color.GreenYellow;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Masm files (.asm)|''.asm";
            ofd.Title = "Open a file ...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox2.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Save files (.asm)| '' .asm";
            svf.Title = "Save the file";
            if(svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox2.Text);
                sw.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<5;i++)eqcl();
        }
        
        /*
        //Parallel threading to make concurrent changes to the color of the keywords
        //incompelete bgCode
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            eqcl();
        }
        */
    }
}
