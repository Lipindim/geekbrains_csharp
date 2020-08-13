using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "example.txt";
            byte[] readFileStreamResult = ReadFileFileStream(fileName);
            byte[] readBufferedStreamResult = ReadFileBufferedStream(fileName);
            string readStreamReaderResult = ReadFileStreamReader(fileName);
            int[] readBinaryReaderResult = ReadFileBinaryReader(fileName);
            Console.WriteLine($"Результаты чтения файла '{fileName}'");
            Console.WriteLine($"File Stream:\n{ GetString(readFileStreamResult) }");
            Console.WriteLine($"Buffered Stream:\n{ GetString(readBufferedStreamResult) }");
            Console.WriteLine($"Stream Reader:\n{ readStreamReaderResult }");
            Console.WriteLine($"Binary Reader:\n{ GetString(readBinaryReaderResult) }");

            Console.ReadKey();

        }

        static string GetString<T>(T[] array)
        {
            return string.Join(" ", array.Select(x => x.ToString()));
        }

        static byte[] ReadFileFileStream(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        static byte[] ReadFileBufferedStream(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fs))
                {
                    byte[] buffer = new byte[fs.Length];
                    bufferedStream.Read(buffer, 0, buffer.Length);
                    return buffer;
                }
            }
        }

        static string ReadFileStreamReader(string filename)
        {
            using (StreamReader streamReader = new StreamReader(filename))
            {
                return streamReader.ReadToEnd();
            }
        }

        static int[] ReadFileBinaryReader(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    List<int> buffer = new List<int>();
                    while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                    {
                        long endOfStreamBytes = binaryReader.BaseStream.Length - binaryReader.BaseStream.Position;
                        if (endOfStreamBytes == 1)
                            buffer.Add(binaryReader.ReadByte());
                        else if (endOfStreamBytes <= 3)
                            buffer.Add(binaryReader.ReadInt16());
                        else
                            buffer.Add(binaryReader.ReadInt32());
                    }
                    return buffer.ToArray();
                }
            }
        }

    }
}
