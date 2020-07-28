using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Helpers
{
    public static class ExtraConsole
    {
        public static uint ReadUintFromConsole()
        {
            return ReadFromConsole(new TryParseDelegate<uint>(uint.TryParse), 
                "Нужно ввести целое положительное число. Пожалуйста, повторите попытку.");
        }

        public static int ReadIntFromConsole()
        {
            return ReadFromConsole(new TryParseDelegate<int>(int.TryParse),
                "Нужно ввести положительное число. Пожалуйста, повторите попытку.");
        }

        private static T ReadFromConsole<T>(TryParseDelegate<T> tryParseMethod, string errorMessage)
        {
            bool inputSuccess = false;
            T parsedValue;
            do
            {
                string input = Console.ReadLine();
                if (tryParseMethod(input, out parsedValue))
                    inputSuccess = true;
                else
                    Console.WriteLine(errorMessage);
            }
            while (!inputSuccess);

            return parsedValue;
        }


        public delegate bool TryParseDelegate<T>(string input, out T parsedValue);
    }
}
