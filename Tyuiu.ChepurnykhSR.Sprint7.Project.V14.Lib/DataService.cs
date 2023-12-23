using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Tyuiu.ChepurnykhSR.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string path)
        {
            string[] str = File.ReadAllLines(path);

            //определение количества столбцов и строчек
            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }

        public double CalculateSum(double[] valueSum)
        {
            double sum = 0;


            for (int i = 0; i < valueSum.Length; i++)
            {
                sum += valueSum[i];
            }

            return Math.Round(sum, 2);
        }
        //public string[,] GetMatrix(string path)
        //{
        //    int n = 0, m = 0;
        //    using (var reader = new StreamReader(path))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            var values = line.Split(';');
        //            n = values.Length;

        //            m++;
        //        }
        //    }
        //    string[,] matrix = new string[n, m];
        //    using (var reader = new StreamReader(path))
        //    {
        //        int i = 0;
        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            var values = line.Split(';');

        //            for (int j = 0; j < values.Length; j++)
        //                matrix[i, j] = values[j];
        //        }
        //    }

        //    return matrix;
        //}
    }
}
//
