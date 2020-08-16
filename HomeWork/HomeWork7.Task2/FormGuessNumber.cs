using System;
using System.Windows.Forms;

namespace HomeWork7.Task2
{
    public partial class formGuessNumber : Form
    {
        private readonly GuessNumberGame guessNumberGame;

        public formGuessNumber()
        {
            InitializeComponent();
            this.guessNumberGame =  new GuessNumberGame();
        }

        private void btnGuessNumber_Click(object sender, EventArgs e)
        {
            int guessNumber = (int)nudGuessNumber.Value;
            GuessResult result = this.guessNumberGame.CheckNumber(guessNumber);
            switch (result)
            {
                case GuessResult.TooSmall:
                    lblResult.Text = $"Ваше число слишком маленькое. Попыток: {this.guessNumberGame.TryCount}";
                    break;
                case GuessResult.TooBig:
                    lblResult.Text = $"Ваше число слишком большое. Попыток: {this.guessNumberGame.TryCount}";
                    break;
                case GuessResult.Guessed:
                    string winMessage = $"Поздравляем! Вы выиграли!!! Всего попыток: {this.guessNumberGame.TryCount}";
                    MessageBox.Show(winMessage);
                    lblResult.Text = winMessage;
                    gbGuessNumber.Enabled = false;
                    break;
            }
        }
    }
}
