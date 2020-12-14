using System;
using System.IO;

namespace PrimerZP
{
    class Excels
    {
        string path = @"C:\Users\homepc\source\repos\PrimerZP\index.txt";

        // подстчет примерной недельной зарплаты
        public string Result()
        {
            DateTime date = DateTime.Now;
            double a = (int)date.DayOfWeek; int price = 0;
            
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                // проверяем даты понтажей и суммируем необходимый прайс 
                while ((line = sr.ReadLine()) != null)
                {
                    var i = DateTime.ParseExact(line.Substring(0, 10), "dd.MM.yyyy", null);
                    if (i >= date.AddDays(-a-1) && i <= date.AddDays(6 - a))
                    {
                        price += Convert.ToInt32(line.Substring(15));
                    }
                }
                sr.Close();
            }
            return Convert.ToString(price);
        }

        // добавление данных в "базу"
        public void EnterData(string line)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.Write(line);
                sw.Close();
            }
        }
    }
}
