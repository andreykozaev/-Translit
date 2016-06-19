using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ir
{
    class Lat
    {

        public static string soviet(string lat)
        {
            lat = lat.Replace("H", "Гъ");
            lat = lat.Replace("h", "гъ");

            lat = rus(lat);
            lat = generalIr(lat);
            lat = general(lat);

            return lat;
        }

        private static string rus(string lat)
        {
            lat = lat.Replace("Jo", "Ё");
            lat = lat.Replace("jo", "ё");
            lat = lat.Replace("Šh", "Щ");
            lat = lat.Replace("šh", "щ");
            lat = lat.Replace("ju", "ю");
            lat = lat.Replace("Ja", "Я");
            lat = lat.Replace("Я", "Ja");
            lat = lat.Replace("ja", "я");

            return lat;
        }

        private static string general(string lat)
        {
            lat = lat.Replace("A", "А");
            lat = lat.Replace("a", "а");
            lat = lat.Replace("Æ", "Æ");
            lat = lat.Replace("æ", "æ");
            lat = lat.Replace("B", "Б");
            lat = lat.Replace("b", "б");
            lat = lat.Replace("V", "В");
            lat = lat.Replace("v", "в");
            lat = lat.Replace("G", "Г");
            lat = lat.Replace("g", "г");
            lat = lat.Replace("D", "Д");
            lat = lat.Replace("d", "д");
            lat = lat.Replace("E", "Е");
            lat = lat.Replace("e", "е");
            lat = lat.Replace("Z", "З");
            lat = lat.Replace("z", "з");
            lat = lat.Replace("I", "И");
            lat = lat.Replace("i", "и");
            lat = lat.Replace("J", "Й");
            lat = lat.Replace("j", "й");
            lat = lat.Replace("K", "К");
            lat = lat.Replace("k", "к");
            lat = lat.Replace("L", "Л");
            lat = lat.Replace("l", "л");
            lat = lat.Replace("M", "М");
            lat = lat.Replace("m", "м");
            lat = lat.Replace("N", "Н");
            lat = lat.Replace("n", "н");
            lat = lat.Replace("O", "О");
            lat = lat.Replace("o", "о");
            lat = lat.Replace("P", "П");
            lat = lat.Replace("p", "п");
            lat = lat.Replace("R", "Р");
            lat = lat.Replace("r", "р");
            lat = lat.Replace("S", "С");
            lat = lat.Replace("s", "с");
            lat = lat.Replace("T", "Т");
            lat = lat.Replace("t", "т");
            lat = lat.Replace("U", "У");
            lat = lat.Replace("u", "у");
            lat = lat.Replace("F", "Ф");
            lat = lat.Replace("f", "ф");
            lat = lat.Replace("Y", "Ы");
            lat = lat.Replace("y", "ы");
            lat = lat.Replace("E", "Э");
            lat = lat.Replace("e", "э");

            return lat;
        }

        private static string generalIr(string lat)
        {
            lat = lat.Replace("Q", "Хъ");
            lat = lat.Replace("q", "хъ");

            lat = lat.Replace("Ž", "Ж");
            lat = lat.Replace("ž", "ж");
            lat = lat.Replace("X", "Х");
            lat = lat.Replace("x", "х");
            lat = lat.Replace("C", "Ц");
            lat = lat.Replace("c", "ц");
            lat = lat.Replace("Č", "Ч");
            lat = lat.Replace("č", "ч");
            lat = lat.Replace("Š", "Ш");
            lat = lat.Replace("š", "ш");
            lat = lat.Replace("'", "ъ");

            return lat;
        }
    
    }
}
