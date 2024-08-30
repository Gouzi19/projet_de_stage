using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print
{
    public class Conversion
    {
        static string[] units = { "", "Un", "Deux", "Trois", "Quatre", "Cinq", " Six", "Sept", "Huit", "Neuf" };
        static string[] teens = { "Dix", "Onze", "Douze", "Treize", "Quatorze", "Quinze", "Seize", "Dix-sept", "Dix-huit", "Dix-neuf" };
        static string[] tens = { "", "Dix", "Vingt", "Trente", "Quarante", "Cinquante", "Soixante", "Soixante-dix", "Quatre-vingt", "Quatre-vingt-dix" };

        public static string NumberToWords(int number)
        {
            //verifier si le chiffre est zero
            if (number == 0)
                return "zero";

            //verfier si le chiffre est negatif
            if (number < 0)
                return "moins " + NumberToWords(Math.Abs(number));

            string words = "";//delaration du variable qui va contenir le chiffre en lettre

            if ((number / 1000000000) > 0)// on commence par les milliad 
            {
                words += NumberToWords(number / 1000000000) + " Milliard ";// on cherche combien il y a des million
                number %= 1000000000;// on decale des miilliad vres les million
            }

            if ((number / 1000000) > 0)//les million 
            {
                words += NumberToWords(number / 1000000) + " Million";// on cherche combien il y a des million
                number %= 1000000;// on decale des miillion vres les mille
            }

            if ((number / 1000) > 0)
            {
                if ((number / 1000) == 1)// on verifie si il y a mille pour ecrire mille ou lieu de un mille
                    words += " Mille ";
                else
                    words += NumberToWords(number / 1000) + " Mille";// on cherche combien il y a des mille

                number %= 1000;// on decale des mille vres les cent
            }

            if ((number / 100) > 0)
            {
                if ((number / 100) == 1)// on verifie si il y a mille pour ecrire cent ou lieu de un cent
                    words += " Cent";
                else
                    words += NumberToWords(number / 100) + " Cent";// on cherche combien il y a des mille
                if (number % 100 == 0)
                    words += "s";

                number %= 100;// on decale des cent vres les dizaine
            }

            if (number > 0)
            {
                words += " ";
                if (number < 10)//on verifie si le nombre est inferieure a 10
                    words += units[number]; //on cherche dans le correspondant du chiffre dans le tableau des unite
                else if (number < 20)//on verifie si le nombre est inferieure a 20
                    words += teens[number - 10];//on cherche dans le correspondant du chiffre dans le tableau des dizaine(10,19)
                else
                {
                    if ((number / 10) == 7 || (number / 10) == 9)//on verifie si on a  7 ou 9 dans les dizaine pour decremente d'un pas
                    {
                        words += tens[(number / 10) - 1];//on decremente d'un pas pour evite des repetision du teme "dix"
                        number %= 10;
                        words += "-" + teens[number];
                    }
                    else
                    {

                        words += tens[number / 10];//sinon on cherche le dizane correspindant(10,90)
                        if ((number / 10) == 8 && number % 10 == 0) // Ajoute un "s" à "quatre-vingt" si pas suivi d'un autre chiffre
                            words += "s";
                        if ((number % 10) > 0)
                            words += " " + units[number % 10];//on ajoute l'unite si il y a
                    }
                }
            }

            return words;
        }

    }
}
