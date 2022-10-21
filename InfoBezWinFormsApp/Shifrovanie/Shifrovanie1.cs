﻿using InformationSecurityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace InformationSecurityAPI.Shifrovanie
{
    public class Shifrovanie1
    {
        List<char> letter;
        List<char> letter2;
        List<char> letter_numbers;
        public Shifrovanie1()
        {
            this.letter = new List<char>() 
            {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж',
                'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч',
                'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',

                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            this.letter2 = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z',

                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            this.letter_numbers = new List<char>()
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
        }

        public string Caesar(TextRequest2 textRequest2)
        {
            List<char> letters;
            List<int> indexes_capital_letters = new List<int>();
            string lower_word = "";

            //верхний регистр в нижний
            for (int i = 0; i < textRequest2.word.Length; i++)
            {
                if (Char.IsUpper(textRequest2.word[i]))
                {
                    indexes_capital_letters.Add(i);
                    lower_word += char.ToLower(textRequest2.word[i]);
                }
                else
                {
                    lower_word += textRequest2.word[i];
                }
            }

            if (textRequest2.key[0] != '-' && !this.letter_numbers.Contains(textRequest2.key[0]))
            {
                return "Ключ неверный";
            }

            for (int i = 1; i < textRequest2.key.Length; i++)
            {
                if (!this.letter_numbers.Contains(textRequest2.key[i]))
                {
                    return "Ключ неверный";
                }
            }

            //если криптограмма, то расшифровка, иначе зашифровка
            letters = textRequest2.language == 2 ? letter : letter2;

            BigInteger big_key = BigInteger.Parse(textRequest2.key);
            big_key %= letters.Count;
            int key = (int)big_key;


            //шифрование или расшифровка слова
            string new_word = "";
            if (!textRequest2.is_cryptogram)
            {
                for (int i = 0; i < lower_word.Length; i++)
                {
                    if (!letters.Contains(lower_word[i]))
                    {
                        return "Вы ввели что-то неправильно";
                    }


                    if (letters.IndexOf(lower_word[i]) + key >= letters.Count)
                    {
                        new_word += letters[letters.IndexOf(lower_word[i]) + key - letters.Count + 1];
                    }
                    else if (letters.IndexOf(lower_word[i]) + key < 0)
                    {
                        new_word += letters[letters.Count - (key * (-1) - letters.IndexOf(lower_word[i])) - 1];
                    }
                    else
                    {
                        new_word += letters[letters.IndexOf(lower_word[i]) + key];
                    }
                }
            }
            else
            {
                for (int i = 0; i < lower_word.Length; i++)
                {
                    if (!letters.Contains(lower_word[i]))
                    {
                        return "Вы ввели что-то неправильно";
                    }

                    if (letters.IndexOf(lower_word[i]) - key >= letters.Count)
                    {
                        new_word += letters[letters.IndexOf(lower_word[i]) + key * (-1) - letters.Count + 1];
                    }
                    else if (letters.IndexOf(lower_word[i]) - key < 0)
                    {
                        new_word += letters[letters.Count - (key - letters.IndexOf(lower_word[i])) - 1];
                    }
                    else
                    {
                        new_word += letters[letters.IndexOf(lower_word[i]) - key];
                    }
                }
            }

            //перевод в верхний регистр
            lower_word = "";
            for (int i = 0; i < new_word.Length; i++)
            {
                if (indexes_capital_letters.Contains(i))
                {
                    lower_word += char.ToUpper(new_word[i]);
                }
                else
                {
                    lower_word += new_word[i];
                }
            }
            new_word = lower_word;

            return new_word;
        }
    }
}
