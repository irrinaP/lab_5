using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsErrors
    {
        public void Words(string Path)
        {
            var Errors = new List<string>() { "пок", "пака", "пако", "до здвидания", "до свиданя" };
            string[] array1 = Directory.GetFiles(Path, "*.txt");
            for (int Index = 0; Index < Errors.Count; ++Index)
            {
                if (Errors[Index] == "пок" || Errors[Index] == "пака" || Errors[Index] == "пако")
                {
                    string Word = Errors[Index];
                    foreach (string File in array1)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = System.IO.File.OpenText(File))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(Word, "пока");

                        using (StreamWriter file = new StreamWriter(File))
                        {
                            file.Write(str);
                        }
                    }
                }
                if (Errors[Index] == "до здвидания" || Errors[Index] == "до свиданя")
                {
                    string Word = Errors[Index];
                    foreach (string File in array1)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = System.IO.File.OpenText(File))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(Word, "до свидания");

                        using (StreamWriter file = new StreamWriter(File))
                        {
                            file.Write(str);
                        }
                    }
                }

            }

        }
    }
