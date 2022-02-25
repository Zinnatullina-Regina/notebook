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
            if (textBox1.TextLength != 0) 
            {
               DialogResult rez =  MessageBox.Show("Блокнот содержит текст! Сохранить?", "Varning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez==DialogResult.Yes) 
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.FileName = "Безымянный";
                    save.Filter = "Текстовый файл|.txt";
                    
                    if (save.ShowDialog() == DialogResult.OK)
                    {

                        File.WriteAllText(save.FileName, textBox1.Text);
                    }




                }
            
                if(rez == DialogResult.No)
                {
                    textBox1.Clear();
                    this.Close();
                }
            
            }

            this.Close();






        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Блокнот содержит текст! Сохранить?", "Varning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "Безымянный";
                save.Filter = "Текстовый файл|.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {

                    File.WriteAllText(save.FileName, textBox1.Text);
                }




            }

            if (rez == DialogResult.No)
            {
                textBox1.Clear();

            }



        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
         
            open.Filter = "Текстовый файл|.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {

               textBox1.Text = File.ReadAllText(open.FileName);
            
            
            
            }






        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                DialogResult rez = MessageBox.Show("Блокнот не содержит текст! Сохранить?", "Varning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.FileName = "Безымянный";
                    save.Filter = "Текстовый файл|.txt";

                    if (save.ShowDialog() == DialogResult.OK)
                    {

                        File.WriteAllText(save.FileName, textBox1.Text);
                    }




                }

                if (rez == DialogResult.No)
                {
                    textBox1.Clear();
                    this.Close();
                }

            }

            this.Close();


        }
        string str;
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            str = textBox1.SelectedText.ToString();


        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
             str = textBox1.SelectedText.ToString();
             textBox1.Cut();
            
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                textBox1.Paste();
            }
            catch 
            {
                MessageBox.Show("Вам нечего вставлять");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создала Зиннатуллина Регина 09-121 и я без понятия, что тут еще надо");
        }

        private void Блокнот_Load(object sender, EventArgs e)
        {

        }


     

        private void самШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length != 0)
            {
                fontDialog1.Font = textBox1.Font;
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.SelectionFont = fontDialog1.Font;
                }
            }
            else
            {
                fontDialog1.Font = textBox1.Font;
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog1.Font;
                }
            }
        }

        private void изменениеЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox1.SelectedText.Length != 0)
            {

                colorDialog1.Color = textBox1.SelectionColor;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {

                    textBox1.SelectionColor = colorDialog1.Color;
                }
            }
            else
            {
                colorDialog1.Color = textBox1.SelectionColor;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {


                    textBox1.ForeColor = colorDialog1.Color;
                }
            }
        }

       
    }

}
