using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Drawing;


namespace ir
{
    class helper_Vaso
    {
        public static string wu(string cyr)
        {
            #region Замена 'u' на 'w'
            for (int i = 0; i <= cyr.Length; i++)
            {
                int iU = cyr.IndexOf('u', i);
                if (iU == -1) break;
                // берем местополоңение 'u'. если 'u' не нашел - выйти из цикла

                if (isVowel(cyr[(iU + 1)]) || isVowel(cyr[(iU - 1)]))
                {
                    cyr = cyr.Remove(iU, 1);
                    cyr = cyr.Insert(iU, "w");
                    // удаляем 'u' и ставим туда 'w'
                }
                // если перед или после найденной 'u' есть гласная

                i = iU;
                // смещаем i вперед
            }
            // заменяем все 'u' на 'w'
            #endregion

            #region Замена 'U' на 'W'
            for (int i = 0; i <= cyr.Length; i++)
            {
                int iU = cyr.IndexOf('U', i);
                if (iU == -1) break;
                // берем местополоңение 'u'. если 'u' не нашел - выйти из цикла

                if (isVowel(cyr[(iU + 1)]) || isVowel(cyr[(iU - 1)]))
                {
                    cyr = cyr.Remove(iU, 1);
                    cyr = cyr.Insert(iU, "W");
                    // удаляем 'u' и ставим туда 'w'
                }
                // если перед или после найденной 'u' есть гласная

                i = iU;
                // смещаем i вперед
            }
            // заменяем все 'U' на 'W'
            #endregion

            return cyr;
        }


        private static bool isVowel(char letter)
        {
            switch (letter)
            {
                case 'y': return true;
                case 'a': return true;
                case 'e': return true;
                case 'i': return true;
                case 'o': return true;
                case 'u': return true;
                case 'w': return true;
                case 'æ': return true;
                case 'Y': return true;
                case 'A': return true;
                case 'E': return true;
                case 'I': return true;
                case 'O': return true;
                case 'U': return true;
                case 'W': return true;
                case 'Æ': return true;
                default: return false;
            }
            // присланная буква гласная(true/false)?
        }
    }

    class h
    {
        public static string reg(string pattern, string str)
        {
            var r = new Regex(pattern);
            return r.Match(str).Value;
        }

        public static string regDelete(string pattern, string str)
        {
            var r = new Regex(pattern);
            return r.Replace(str, string.Empty);
        }

        public static string regReplace(string whatToReplace_pattern, string withWhatToReplace, string inWhatStringReplace)
        {
            var r = new Regex(whatToReplace_pattern);
            return r.Replace(inWhatStringReplace, withWhatToReplace);
        }

        
    }
}
