using System;
using System.IO;

namespace PrimerZP
{
    class Excels
    {
        public string Result()
        {
            DateTime date = DateTime.Now;
            string path = @"C:\Users\homepc\source\repos\PrimerZP\index.txt";
            double a = (int)date.DayOfWeek; int price = 0;
            
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                // проверяем количество пододящих 
                while ((line = sr.ReadLine()) != null)
                {
                    var i = DateTime.ParseExact(line.Substring(0, 10), "dd.MM.yyyy", null);
                    if (i >= date.AddDays(-a-1) && i <= date.AddDays(6 - a))
                    {
                        price += Convert.ToInt32(line.Substring(15));
                    }
                }
            }
            return Convert.ToString(price*0.15);
        }
    }
}
