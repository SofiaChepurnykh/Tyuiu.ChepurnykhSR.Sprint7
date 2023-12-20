using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ChepurnykhSR.Sprint7.Project.V14.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = @"C:C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint7\ChepurnykhSR.DataBase.csv";

            AddDataToCSV(filePath);
        }

        private void AddDataToCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true)) // открытие файла для записи
                {
                    // Пример добавления строчки 
                    writer.WriteLine("Начало маршрута; Конец маршрута");
                }
            }
            catch (Exception ex)
            {
                // Проверка на ошибки
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
