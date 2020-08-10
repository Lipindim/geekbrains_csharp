using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork5.Task2
{
    class Program
    {
        /* Липин Дмитрий
        Задание 2
        Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        а) Вывести только те слова сообщения,  которые содержат не более n букв.
        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        в) Найти самое длинное слово сообщения.
        г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.*/
        static void Main(string[] args)
        {
            string text = @"Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
                        а) Вывести только те слова сообщения,  которые содержат не более n букв.
                        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
                        в) Найти самое длинное слово сообщения.
                        г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
                        д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.";
            
            Console.WriteLine($"Текст:\n{text}");
            string wordsNotMoreLength = string.Join(", ", 
                Message.GetNotMoreLengthWords(text, 4)
                .ToArray());
            Console.WriteLine($"Слова, содержащие не более 4-х букв:\n{wordsNotMoreLength}");
            Console.WriteLine($"Удаляем из текста все слова, заканчивающиеся на 'е':\n{Message.DeleteWordsWithLastSymbol(text, 'е')}");
            Console.WriteLine($"Самое длинное слово в тексте: {Message.GetTheLongestWord(text)}");
            Console.WriteLine($"Все самые длинные слова в тексте: {Message.GetLongestWords(text)}");
            string[] analyzedWords = { "слов", "возвращает", "в" };
            Dictionary<string, int> frequencyAnalysisResult = Message.GetFrequencyAnalysis(analyzedWords, text);
            string resultString = string.Join(", ",
                frequencyAnalysisResult.Select(x => $"{x.Key}:{x.Value}")
                .ToArray());
            Console.WriteLine($"Результат частотного анализа:\n{resultString}");
        }
    }
}
