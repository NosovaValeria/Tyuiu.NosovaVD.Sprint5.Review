using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NosovaVD.Sprint5.TaskReview.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V16.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";      
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for(int i = 0; i < mas.Length; i++)
                    {
                        if(mas[i].Length == 2)
                        {
                            strLine += "XY "; 
                        }
                        else
                        {
                            strLine += mas[i] + " ";
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }
            return pathSaveFile;
        }
    }
}
