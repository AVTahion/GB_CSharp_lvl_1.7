using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private int numb = 0;

        /// <summary>
        /// Метод генерирует случайное число от 1 до 100
        /// </summary>
        /// <returns></returns>
        static int RndNumb()
        {
            int x = 0;
            Random rnd = new Random();
            return x = rnd.Next(1, 100);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBoxUserAnswr.Text = "0";
            MessageBox.Show("Угадайте число от 1 до 100");
            numb = RndNumb();
            
        }

        private void txtBoxUserAnswr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(txtBoxUserAnswr.Text) == numb)
                {
                    MessageBox.Show($"Поздравляю вы угадали!");
                }
                else
                {
                    if (int.Parse(txtBoxUserAnswr.Text) > numb)
                    {
                        MessageBox.Show($"Загаданное число меньше, попробуйте еще раз");
                    }
                    else
                    {
                        if (int.Parse(txtBoxUserAnswr.Text) < numb)
                        {
                            MessageBox.Show($"Загаданное число больше, попробуйте еще раз");
                        }
                    }
                }
            }
        }
    }
}
