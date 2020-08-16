using System;

namespace HomeWork7.Task2
{
    public class GuessNumberGame
    {
        private readonly int guessNumber;

        public int TryCount { get; private set; }

        public GuessNumberGame()
        {
            Random rnd = new Random();
            this.guessNumber = rnd.Next(1, 101);
            this.TryCount = 0;
        }

        public GuessResult CheckNumber(int number)
        {
            this.TryCount++;
            if (number < this.guessNumber)
                return GuessResult.TooSmall;
            else if (this.guessNumber < number)
                return GuessResult.TooBig;
            else 
                return GuessResult.Guessed;
        }
    }

    public enum GuessResult
    {
        TooSmall,
        TooBig,
        Guessed
    }
}
