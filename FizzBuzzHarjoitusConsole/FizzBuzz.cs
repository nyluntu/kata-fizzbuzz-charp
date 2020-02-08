namespace FizzBuzzHarjoitusConsole
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Luku(int syote)
        {
            if (OnkoJaollinenViidellatoista(syote))
            {
                return "FizzBuzz";
            }

            if (OnkoJaollinenKolmella(syote))
            {
                return "Fizz";
            }

            if (OnkoJaollinenViidella(syote))
            {
                return "Buzz";
            }

            return syote.ToString();
        }

        private bool OnkoJaollinenViidellatoista(int syote)
        {
            return OnkoJaollinenKolmella(syote) && OnkoJaollinenViidella(syote);
        }

        private bool OnkoJaollinenKolmella(int syote)
        {
            return syote % 3 == 0;
        }

        private bool OnkoJaollinenViidella(int syote)
        {
            return syote % 5 == 0;
        }
    }
}