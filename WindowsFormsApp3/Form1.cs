using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int numb = 0;
        private int minMove = 0;

        /// <summary>
        /// Метод генерирует случайное число от 20 до 100
        /// </summary>
        /// <returns></returns>
        static int RndNumb()
        {
            int x = 0;
            Random rnd = new Random();
            return x = rnd.Next(20, 100);
        }

        /// <summary>
        /// Метод расчитывает минимальное кол-во ходов
        /// </summary>
        /// <param name="x">Требуемое число</param>
        /// <returns>Кол-во ходов</returns>
        static int MinMove (int x)
        {
            int y = 0;

            while (x != 1)
            {
                if (x % 2 != 0)
                {
                    x = x - 1;
                    y++;
                }
                x /= 2;
                y++;
            }
            return y;
        }

        /// <summary>
        /// Метод проверки проигрыша/победы
        /// </summary>
        private void Check()
        {
            if (int.Parse(lblCounter.Text) > minMove)
            {
                MessageBox.Show($"Вы проиграли, минимальное число ходов {minMove}");
            }
            if (int.Parse(lblNumber.Text) == numb)
            {
                MessageBox.Show("Поздравляю! Вы выиграли!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
            Check();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
            Check();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCounter.Text = "0";
        }

        private void StripMenu1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCounter.Text = "0";
            numb = RndNumb();
            minMove = MinMove(numb);
            MessageBox.Show($"Получите {numb} за минимальное число ходов");
            lblNumb.Text = numb.ToString();
        }

    }
}
