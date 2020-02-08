using System;

namespace FizzBuzzHarjoitusConsole
{
    /**
    * FizzBuzz -harjoitus
    * ===================
    * 
    * Kirjoita ohjelma, joka kysyy käyttäjältä lukua yhden ja sadan väliltä ja tulostaa luvun.
    *
    * - Jos luku on kolmella jaollinen, luvun sijaan tulostetaan "Fizz".
    * - Jos luku on viidellä jaollinen, luvun sijaan tulostetaan "Buzz".
    * - Jos luku on sekä kolmellä että viidellä jaollinen, luvun sijaan tulostetaan "FizzBuzz".
    *
    * Esimerkki ohjelman toiminnasta:
    *
    * 1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz ... aina lukuun 100 asti.
    **/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz -harjoitus");
            Console.WriteLine("===================");
            Console.WriteLine("Anna luku väliltä 1-100 ja paina Enter.");

            int kayttajanSyote = int.Parse(Console.ReadLine());

            var fizzBuzz = new FizzBuzz();
            var vastaus = fizzBuzz.Luku(kayttajanSyote);

            Console.WriteLine();
            Console.WriteLine(vastaus);

        }
    }
}
