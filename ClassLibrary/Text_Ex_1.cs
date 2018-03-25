using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Text_Ex_1
    {
        public string Path { get; set; }
        public string[] Lines { get; set; }

        public Text_Ex_1(string path)
        {
            this.Path = path;
            this.Lines = IOUtils.FileToArray(path);
        }

        public string[] NewLines(int k)
        {
            if (k - 1 < Lines.Length && k > 0)
            {
                string[] num = new string[Lines.Length + 1];
                int index = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if (index != k - 1)
                    {
                        num[i] = Lines[index];
                        index++;
                    }
                    else
                    {
                        num[i] = "    ";
                        for (int j = i + 1; j < num.Length; j++)
                        {
                            num[j] = Lines[index];
                            index++;
                        }
                        break;
                    }
                }
                return num;
            }
            else
                return Lines;
        }
    }

}
