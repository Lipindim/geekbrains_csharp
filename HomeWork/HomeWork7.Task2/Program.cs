using System;
using System.Windows.Forms;

namespace HomeWork7.Task2
{
    static class Program
    {
        /*Липин Дмитрий
        Задание 2
        Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
        a) Для ввода данных от человека используется элемент TextBox;
        б) **Реализовать отдельную форму c TextBox для ввода числа.*/
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formGuessNumber());
        }
    }
}
