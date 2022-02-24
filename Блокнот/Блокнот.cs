using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнот
{
    public partial class Блокнот : Form
    {
        public Блокнот()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!= 0) 
            {
               DialogResult rez =  MessageBox.Show("Блокнот содержит текст! Сохранить?", "Varning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez==DialogResult.Yes) 
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.ShowDialog();
                }
            
            
            
            }







            this.Close();
        }
    }
}
