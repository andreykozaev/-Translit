using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ir
{
    class Convert
    {
        public static string toVaso(string text)
        {
            text = toLat(text);

            text = text.Replace("Ъ", "'");
            text = text.Replace("ъ", "'");
            text = text.Replace(" uu", " uw");   /* для замены 'ууыл', 'ууылты' */
            text = text.Replace(" Uu", " Uw");

            text = helper_Vaso.wu(text);

            return text;
        }

        public static string toSoviet(string text)
        {
            text = toLat(text);

            text = text.Replace("Ъ", "H");
            text = text.Replace("ъ", "h");

            return text;
        }

        public static string toKudar(string text)
        {
            text = text.Replace("дзынæн", "джæн");        // цæудзынæн
            text = text.Replace("дзысты", "джысты");      // цæудзысты
            text = text.Replace("дзынæ", "джынæ");        // цæудзынæ
            text = text.Replace("дзыстæм", "джыстæм");    // цæудзыстæм

            text = text.Replace("дзыс", "джыс");      // дзæбæх, цæудзыстæм


            text = text.Replace("дздзæн", "жджен");   // ратæдздзæн
            text = text.Replace("æндзæн", "æнджен");  // скæндзæн
            text = text.Replace("æудзæн", "æуджен");  // рацæудзæн
            text = text.Replace("сдзæн", "сджен");    // райсдзæн
            text = text.Replace("ыдзæн", "ыджен");    // фæхъыздзæн
            text = text.Replace("здзæн", "зджен");    // уыдзæн
            text = text.Replace("йдзæн", "йджен");    // æрзайдзæн
            text = text.Replace("рдзæн", "рджен");    // фæцæрдзæн
            text = text.Replace("тдзæн", "тджен");    // уыдзæн

            text = text.Replace("ндзæ", "нджæ");      // фæндзæм
            text = text.Replace("атдзæ", "атджæ");    // хатдзæг
            text = text.Replace("нтдзæ", "нтджæ");    // сæнтдзæф

            text = text.Replace("дзæб", "джæб");    // дзæбæх
            
            // SubMain
            text = text.Replace("дзæ", "жæ");    // дзæбæх
            //

            text = text.Replace("ндзы", "нджы");    // бындзы


            text = h.regReplace("(?<=\\W)дзы(?=\\W)", "джы", text); // _дзы_
            // MAIN выражение
            text = text.Replace("дз", "ж");    // бындзы
            //


            //---------------- Ц ---------------
            text = text.Replace("цыб", "чыб");    // цыбыр

            text = text.Replace("цц", "чч");    // фыццаг
            text = text.Replace("нц", "нч");    // кæнынц

            text = text.Replace("ц", "ш");    // MAIN выражение

            // Пост выражения
            text = text.Replace("шъ", "цъ");    // цъ - тæ
            text = text.Replace("ыццы", "ышшыы");    // гыццыл




            #region Слова исключения из правил
            text = text.Replace("чындз", "чындж");
            #endregion


            return text;
        }


        private static string toLat(string text)
        {
            #region Русские специфические буквы

            text = text.Replace("Гъ", "H");
            text = text.Replace("гъ", "h");
            // fix. не помню какой

            text = text.Replace("Ё", "Jo");
            text = text.Replace("ё", "jo");
            text = text.Replace("Щ", "Šh");
            text = text.Replace("щ", "šh");
            text = text.Replace("Ю", "Ju");
            text = text.Replace("ю", "ju");
            text = text.Replace("Я", "Ja");
            text = text.Replace("я", "ja");

            #endregion


            #region Осетинские специфические буквы

            text = text.Replace("Хъ", "Q");
            text = text.Replace("хъ", "q");

            text = text.Replace("Ж", "Ž");
            text = text.Replace("ж", "ž");
            text = text.Replace("Х", "X");
            text = text.Replace("х", "x");
            text = text.Replace("Ц", "C");
            text = text.Replace("ц", "c");
            text = text.Replace("Ч", "Č");
            text = text.Replace("ч", "č");
            text = text.Replace("Ш", "Š");
            text = text.Replace("ш", "š");

            #endregion


            #region Базовый алфавит

            text = text.Replace("А", "A");
            text = text.Replace("а", "a");
            text = text.Replace("Æ", "Æ");
            text = text.Replace("æ", "æ");
            text = text.Replace("Б", "B");
            text = text.Replace("б", "b");
            text = text.Replace("В", "V");
            text = text.Replace("в", "v");
            text = text.Replace("Г", "G");
            text = text.Replace("г", "g");
            text = text.Replace("Д", "D");
            text = text.Replace("д", "d");
            text = text.Replace("Е", "E");
            text = text.Replace("е", "e");
            text = text.Replace("З", "Z");
            text = text.Replace("з", "z");
            text = text.Replace("И", "I");
            text = text.Replace("и", "i");
            text = text.Replace("Й", "J");
            text = text.Replace("й", "j");
            text = text.Replace("К", "K");
            text = text.Replace("к", "k");
            text = text.Replace("Л", "L");
            text = text.Replace("л", "l");
            text = text.Replace("М", "M");
            text = text.Replace("м", "m");
            text = text.Replace("Н", "N");
            text = text.Replace("н", "n");
            text = text.Replace("О", "O");
            text = text.Replace("о", "o");
            text = text.Replace("П", "P");
            text = text.Replace("п", "p");
            text = text.Replace("Р", "R");
            text = text.Replace("р", "r");
            text = text.Replace("С", "S");
            text = text.Replace("с", "s");
            text = text.Replace("Т", "T");
            text = text.Replace("т", "t");
            text = text.Replace("У", "U");
            text = text.Replace("у", "u");
            text = text.Replace("Ф", "F");
            text = text.Replace("ф", "f");
            text = text.Replace("Ы", "Y");
            text = text.Replace("ы", "y");
            text = text.Replace("Ь", "");
            text = text.Replace("ь", "");
            text = text.Replace("Э", "E");
            text = text.Replace("э", "e");

            #endregion

            return text;
        }
    }

   
}