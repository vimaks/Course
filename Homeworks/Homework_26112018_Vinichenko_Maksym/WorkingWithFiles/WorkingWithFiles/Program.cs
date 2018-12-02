using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{    
    class Program
    {
        static void Main(string[] args)
        {
            
            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            directory.Parent.CreateSubdirectory("SomeDir");
            string path = directory.Parent.FullName + "\\SomeDir\\";
            //Помним что есть Path.Combine(), как то Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SomeDir")
            string tempText = "";
            using (var file1 = File.Create(path + "text1.txt"))
            {
                file1.Close();
            }

            using (Stream s = new FileStream(path + "text1.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                string text = "Jackdaws love my big sphinx of quartz.";                
                byte[] arrBytes = text.SelectMany(c => BitConverter.GetBytes(c)).Where(a => a != 0).ToArray();
                //Если у Вас появились нули то самое быстрое костыльное решение - их отфильтровать на этапе преобразования. Проблема в кодировке
                //Потому как если получить байты таким образом var smt = Encoding.ASCII.GetBytes(text.ToCharArray()); то лишних нулей уже нет     
                //А так Encoding.UTF32.GetBytes(text.ToCharArray()) нулей будет еще больше
                //видимо у Вас сам файлик Program.cs сохранен в UTF16 или чем-то подобном
                s.Write(arrBytes, 0, arrBytes.Length);
                s.Flush();
            }

            using (StreamReader sr = new StreamReader(path + "text1.txt"))
            {                
                string text = sr.ReadToEnd();                
                //tempText = tempText.Replace("\0", String.Empty);
            }

            using (StreamWriter sw = new StreamWriter(path + "text2.txt"))
            {
                sw.Write(tempText);
            }

            FileInfo fi = new FileInfo(path + "text3.txt");
            if (!fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.Write(tempText);
                }
            }

            using (var file = File.Create(path + "text4.txt"))
            {
                byte[] arrBytes = tempText.SelectMany(c => BitConverter.GetBytes(c)).ToArray();
                file.Write(arrBytes, 0, arrBytes.Length);
                file.Flush();
                file.Close();
            }
        }
    }
}
