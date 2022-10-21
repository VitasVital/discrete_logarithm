using InformationSecurityAPI.Shifrovanie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace InfoBezWinFormsApp
{
    public partial class Form2 : Form
    {
        List<char> letter;
        List<char> letter_cryp;
        Shifrovanie5 shifr5;
        BigInteger x;
        BigInteger y;
        BigInteger count_iteration;
        public Form2()
        {
            InitializeComponent();

            letter = new List<char>()
            {
                'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж',
                'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О',
                'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч',
                'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я',

                'а', 'б', 'в', 'г', 'д', 'е', 'ж',
                'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч',
                'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
            };

            letter_cryp = new List<char>()
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ','
            };

            shifr5 = new Shifrovanie5();
        }

        public void NOD(BigInteger a, BigInteger b)
        {
            List<BigInteger[]> list = new List<BigInteger[]>();
            list.Add(new BigInteger[6]);
            list[0][0] = a;
            list[0][1] = b;

            list[0][2] = a % b;
            list[0][3] = a / b;

            int ind = 0;
            while (list[ind][2] != 0)
            {
                ind += 1;

                list.Add(new BigInteger[6]);

                list[ind][0] = list[ind - 1][1];
                list[ind][1] = list[ind - 1][2];

                list[ind][2] = list[ind][0] % list[ind][1];
                list[ind][3] = list[ind][0] / list[ind][1];
            }

            list[ind][4] = 0;
            list[ind][5] = 1;
            while (ind != 0)
            {
                ind -= 1;

                list[ind][4] = list[ind + 1][5];
                list[ind][5] = list[ind + 1][4] - list[ind + 1][5] * list[ind][3];
            }

            x = list[ind][4];
            y = list[ind][5];
        }

        BigInteger GCD(BigInteger a, BigInteger b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                BigInteger min;
                BigInteger max;
                if (a > b)
                {
                    min = b;
                    max = a;
                }
                else
                {
                    min = a;
                    max = b;
                }
                //вызываем метод с новыми аргументами
                return GCD(max - min, min);
            }
        }

        BigInteger ro_Pollard(BigInteger n)
        {
            BigInteger x = 4;
            BigInteger y = 1;
            BigInteger i = 0;
            BigInteger stage = 2;

            count_iteration = 0;
            while (BigInteger.GreatestCommonDivisor(n, BigInteger.Abs(x - y)) == 1)
            {
                if (i == stage)
                {
                    y = x;
                    stage = stage * 2;
                }
                x = (x * x - 1) % n;
                i = i + 1;

                count_iteration += 1;
            }
            return BigInteger.GreatestCommonDivisor(n, BigInteger.Abs(x - y));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();

            BigInteger n = BigInteger.Parse(textBox3.Text);
            BigInteger _e = BigInteger.Parse(textBox2.Text);
            BigInteger p = ro_Pollard(n);
            BigInteger q = n / p;
            textBox5.Text = p.ToString();
            textBox6.Text = q.ToString();
            BigInteger fi_n = (p - 1) * (q - 1);

            NOD(fi_n, _e);

            BigInteger d = y;

            while (d < 0)
            {
                d = fi_n + d;
            }

            // расшифровка

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!letter_cryp.Contains(textBox1.Text[i]))
                {
                    textBox4.Text = "Ввели что-то неправильно";
                    return;
                }
            }

            string rashifr = shifr5.VozvedenieStepenPoModulu(BigInteger.Parse(textBox1.Text), d, n).ToString();

            textBox4.Text = "";
            //for (int i = 0; i < rashifr.Length; i += 2)
            //{
            //    string number = "";
            //    number += rashifr[i];
            //    number += rashifr[i + 1];
            //    textBox4.Text += letter[Convert.ToInt16(number) - 16];
            //}

            stopwatch.Stop();
            //смотрим сколько миллисекунд было затрачено на выполнение
            textBox7.Text = stopwatch.ElapsedMilliseconds.ToString();
            textBox8.Text = count_iteration.ToString();
        }
    }
}
