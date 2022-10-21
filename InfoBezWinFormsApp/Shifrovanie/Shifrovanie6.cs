using InformationSecurityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace InformationSecurityAPI.Shifrovanie
{
    public class Shifrovanie6
    {
        List<char> letter;
        List<char> letter_cryp;
        Shifrovanie5 shifrovanie5;
        BigInteger x;
        BigInteger y;
        public Shifrovanie6()
        {
            letter = new List<char>()
            {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж',
                'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 
                'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'ъ', 'э', 
                'ю', 'я'
            };
            
            letter_cryp = new List<char>()
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ','
            };

            shifrovanie5 = new Shifrovanie5();
        }
        
        public BigInteger NOD(BigInteger a, BigInteger b)
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
            return x * a + y * b;
        }

        public TextRequest6 Result_1(TextRequest6 textRequest6)
        {
            foreach (char input_letter in textRequest6.input_text)
            {
                if (!letter.Contains(input_letter))
                {
                    textRequest6.result_1 = "Ввели что-то неправильно";
                    return textRequest6;
                }
            }
            
            BigInteger _n;
            if (!BigInteger.TryParse(textRequest6.bit_count, out _n) || _n < 2)
            {
                textRequest6.result_1 = "Ввели что-то неправильно";
                return textRequest6;
            }
            
            BigInteger p = 1;
            BigInteger q = 1;
            int num_p_q = 0;

            if (_n == 2)
            {
                p = 3;
                q = 2;
            }
            else
            {
                while (num_p_q < 2)
                {
                    var rng = new RNGCryptoServiceProvider();
                    byte[] bytes = new byte[(int)_n / 8];
                    rng.GetBytes(bytes);
                    BigInteger result = new BigInteger(bytes);
                    
                    if (result < 0)
                    {
                        continue;
                    }
                    
                    if (shifrovanie5.TestMillerRabin(result) == "Вероятно простое")
                    {
                        if (num_p_q == 0)
                        {
                            p *= result;
                            num_p_q += 1;
                        }
                        else
                        {
                            q *= result;
                            num_p_q += 1;
                        }
                    }
                }
            }
            
            BigInteger n = p * q;
            BigInteger fi_n = (p - 1) * (q - 1);
            BigInteger e = 0;

            for (BigInteger i = 2; i < fi_n; i++)
            {
                if (NOD(fi_n, i) == 1) // метод выжно из этого файла, присваивается x и y во время работы
                {
                    e = i;
                    break;
                }
            }

            BigInteger d = y;

            List<BigInteger> shifr_res = new List<BigInteger>();
            
            while (d < 0)
            {
                d = fi_n + d;
            }

            foreach (char input_letter in  textRequest6.input_text)
            {
                shifr_res.Add( shifrovanie5.VozvedenieStepenPoModulu(letter.IndexOf(input_letter), e, n));
            }

            textRequest6.P = p.ToString();
            textRequest6.Q = q.ToString();
            textRequest6.e = e.ToString();
            textRequest6.d = d.ToString();
            textRequest6.fi_n = fi_n.ToString();
            textRequest6.n = n.ToString();
            textRequest6.result_1 = String.Join(",", shifr_res);
            
            return textRequest6;
        }
        
        public TextRequest6 Result_2(TextRequest6 textRequest6)
        {
            foreach (char input_letter in textRequest6.cryptogram)
            {
                if (!letter_cryp.Contains(input_letter))
                {
                    textRequest6.result_2 = "Ввели что-то неправильно";
                    return textRequest6;
                }
            }
            
            BigInteger d;
            BigInteger n;
            if (!BigInteger.TryParse(textRequest6.input_d, out d) || !BigInteger.TryParse(textRequest6.input_n, out n) || n < 0)
            {
                textRequest6.result_2 = "Ввели что-то неправильно";
                return textRequest6;
            }

            List<int> input_message_res = new List<int>();
            string[] cryptogram_numbers = textRequest6.cryptogram.Split(',');
            foreach (string numb in cryptogram_numbers)
            {
                input_message_res.Add((int)shifrovanie5.VozvedenieStepenPoModulu(BigInteger.Parse(numb), d, n));
            }

            textRequest6.result_2 = "";
            foreach (int numb_letter in input_message_res)
            {
                if (numb_letter > letter.Count)
                {
                    textRequest6.result_2 = "Ввели что-то неправильно";
                    return textRequest6;
                }
                textRequest6.result_2 += letter[numb_letter];
            }
            
            return textRequest6;
        }
    }
}