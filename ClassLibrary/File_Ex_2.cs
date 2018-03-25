using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class File_Ex_2
    {
        public string[] Path { get; set; }
        //public byte[] FileText1 { get; set; }
        //public byte[] FileText2 { get; set; }
        public List<byte[]> Files { get; set; }

        public File_Ex_2(string[] path)
        {
            this.Path = path;
            //this.FileText1 = IOUtils.FileToBytes(path[0]);
            //this.FileText2 = IOUtils.FileToBytes(path[1]);
            List<byte[]> files = new List<byte[]>();
            for (int i = 0; i <path.Length;i++)
            {
                files.Add(IOUtils.FileToBytes(path[i]));
            }
            this.Files = files;
        }

        public void Swap()
        {
            //List<byte> temp = new List<byte>();
            //int index = 0;
            //for (int i = Files.Count - 1; i <= 0; i--)
            //{
            //    temp[index] = Files[i];
            //}
            //Files = temp;

            //меням местами 1 и последний, 2 и предпоследний и тд
            for (int i = 0; i < Files.Count; i++)
            {
                byte[] tmp = Files[Files.Count - 1 - i];
                Files[Files.Count - 1 - i] = Files[i];
                Files[i] = tmp;

            }

            /*if (FileText1.Length >= FileText2.Length)
            {
                byte[] tmp = new byte [FileText1.Length];
                tmp = FileText1;
                FileText1 = FileText2;
                FileText2 = tmp;

            }
            else
            {
                byte[] tmp = new byte[FileText2.Length];
                tmp = FileText2;
                FileText2 = FileText1;
                FileText1 = tmp;
            }*/
        }
    }
}