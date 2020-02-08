using FizzBuzzHarjoitusConsole;
using NUnit.Framework;

namespace FizzBuzzHarjoitusTests
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
    public class FizzBuzzTests
    {
        FizzBuzz _fizzBuzz = null;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void LuodaanFizzBuzzLuokka()
        { 
            Assert.IsInstanceOf<FizzBuzz>(_fizzBuzz);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuYksi()
        { 
            // Act
            string vastaus = _fizzBuzz.Luku(1);

            // Assert
            Assert.AreEqual("1", vastaus);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuKaksi()
        { 
            // Act
            string vastaus = _fizzBuzz.Luku(2);

            // Assert
            Assert.AreEqual("2", vastaus);
        }

        // - Jos luku on kolmella jaollinen, luvun sijaan tulostetaan "Fizz".
        [Test]
        public void TulostaFizzJosLukuOnKolmellaJaollinen()
        { 
            // Act
            string vastaus = _fizzBuzz.Luku(3);

            // Assert
            Assert.AreEqual("Fizz", vastaus);
        }

        // - Jos luku on viidellä jaollinen, luvun sijaan tulostetaan "Buzz".
        [Test]
        public void TulostaBuzzJosLukuOnViidellaJaollinen()
        {
            // Act
            string vastaus = _fizzBuzz.Luku(5); 

            // Assert
            Assert.AreEqual("Buzz", vastaus);
        }

        [Test]
        public void TulostaLukuKunSyotteenaAnnettuKuusi()
        {
            // Act
            string vastaus = _fizzBuzz.Luku(6);

            // Assert
            Assert.AreEqual("Fizz", vastaus);
        }

        // - Jos luku on sekä kolmellä että viidellä jaollinen, luvun sijaan tulostetaan "FizzBuzz".
        [Test]
        public void TulostaFizzBuzzJosLukuOnKolmellaJaViidellaJaollinen()
        {
            // Act
            string vastaus = _fizzBuzz.Luku(15);

            // Assert
            Assert.AreEqual("FizzBuzz", vastaus);
        }
    }
}