using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1WinForms
{
    class File
    {
        public string filename = @"C:\Users\Компутер\Downloads\data.txt";
        StreamReader stream;

        public File(string path)
        {
            filename = path;
            CreateStream();
        }
        public File()
        {
            CreateStream();
        }
        ~File()
        {
            stream.Close();
        }

        private void CreateStream()
        {
            stream = new StreamReader(filename);
        }

        private string ReadLine()
        {
            return stream.ReadLine();
        }

        public List<List<float>> GetMatrix()
        {
            List<List<float>> matrix = new List<List<float>>();
            string line;
            while ((line = ReadLine()) != null)
            {
                matrix.Add(lineInList(line));
            }
            return matrix;
        }
        private List<float> lineInList(string line)
        {
            List<float> result = new List<float>();
            return line.Split(',').Select(x => x != "M" ? float.Parse(x.Replace('.', ',')) : float.MaxValue).ToList();
        }

        public void WriteResult(string path, List<List<int>> road)
        {
            using (StreamWriter file = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var line in road)
                {
                    file.WriteLine($"{line[0]} {line[1]}");
                }
            }
        }

    }
}
