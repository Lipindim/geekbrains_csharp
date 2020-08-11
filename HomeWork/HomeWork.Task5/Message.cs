using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork5.Task2
{
    /// <summary>
    /// Класс для работы с текстом.
    /// </summary>
    public static class Message
    {
        /// <summary>
        /// Получить слова из текста, содержащих не более указанного количества символов.
        /// </summary>
        /// <param name="text">Заданный текст.</param>
        /// <param name="maxWordLength">Максимальное количество символов в слове.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetNotMoreLengthWords(string text, int maxWordLength)
        {
            Regex regex = new Regex($"\\b\\w{{1,{maxWordLength}}}\\b");
            
            List<string> words = new List<string>();
            foreach (var match in regex.Matches(text))
                words.Add(match.ToString());

            return words;
        }

        /// <summary>
        /// Удалить из текста слова, заканчивающиеся на указанный символ.
        /// </summary>
        /// <param name="text">Заданный текст.</param>
        /// <param name="lastSymbol">Последний символ в слове.</param>
        /// <returns></returns>
        public static string DeleteWordsWithLastSymbol(string text, char lastSymbol)
        {
            Regex regex = new Regex($"\\b\\w+{lastSymbol}\\b");
            StringBuilder stringBuilder = new StringBuilder(text);

            foreach (Match match in regex.Matches(text)
                                         .Cast<Match>()
                                         .OrderByDescending(x => x.Index))
                stringBuilder.Remove(match.Index, match.Length);

            return stringBuilder.ToString();
        }

        /// <summary>
        ///  Получить самое длинное слово в тексте.
        /// </summary>
        /// <param name="text">Заданный текст.</param>
        /// <returns></returns>
        public static string GetTheLongestWord(string text)
        {
            Regex regex = new Regex(@"\b\w+\b");

            string longestWord = string.Empty;
            foreach (var match in regex.Matches(text))
            {
                string word = match.ToString();
                if (longestWord.Length < word.Length)
                    longestWord = word;
            }

            return longestWord;
        }
        
        /// <summary>
        /// Получить самые длинные слова из текста, объединённые в одну строку.
        /// </summary>
        /// <param name="text">Заданный текст.</param>
        /// <returns></returns>
        public static string GetLongestWords(string text)
        {
            int longestWordLength = GetTheLongestWord(text).Length;

            Regex regex = new Regex(@"\b\w+\b");

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var match in regex.Matches(text))
            {
                string word = match.ToString();
                if (longestWordLength == word.Length)
                    stringBuilder.Append($"{word} ");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Получить частотный анализ текста.
        /// </summary>
        /// <param name="analyzedWords">Список слов, которые нужно проанализировать.</param>
        /// <param name="text">Заданный текст.</param>
        /// <returns>Словарь, слово: количество его вхождений в текст.</returns>
        public static Dictionary<string, int> GetFrequencyAnalysis(IEnumerable<string> analyzedWords, string text)
        {
            Dictionary<string, int> analizedWordsDictionary = analyzedWords.ToDictionary(x => x, y => 0);
            foreach (string word in analyzedWords)
            {
                Regex regex = new Regex($"\\b{word}\\b");
                int matchesCount = regex.Matches(text).Count;
                analizedWordsDictionary[word] = matchesCount;
            }

            return analizedWordsDictionary;
        }
    }
}
