using System;
using System.IO;

namespace PrimerZP
{
    class Excels
    {
        public string goal = "175.000";        
        string path = @"C:\Users\homepc\source\repos\PrimerZP\index.txt";

        // подстчет примерной недельной зарплаты
        public string Result(DateTime date)
        {
            double a = (int)date.DayOfWeek; int price = 0;a--;
            
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                // проверяем даты понтажей и суммируем необходимый прайс 
                while ((line = sr.ReadLine()) != null)
                {
                    var i = DateTime.ParseExact(line.Substring(0, 10), "dd.MM.yyyy", null);
                    if (i >= date.AddDays(-a) && i <= date.AddDays(6 - a))
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

        // подсказка к зарплате
        public string Hint(int price)
        {
            string result = "";
            int x = Int32.Parse(goal.Replace(".", "")) / 4;
            if (price > x)
            {
                if ((price - x) > 10000)
                {
                    result = "Да ты просто красавец, Вауся! \nБолее 5000 сверх требуемого!";
                }
                if ((price - x) > 1000 && (price - x) < 10000)
                {
                    result = "А ты явно не плох, паренек!";
                }
                if ((price - x) < 1000)
                {
                    result = "Уверенно движешься к цели";
                }
            }
            else if (x == price)
            {
                result = "Тютелька в Тютельку!";
            }
            else if (x > price)
            {
                if ((x - price) > 10000)
                {
                   result = "Явно не твоя неделя";
                }
                if ((x - price) > 1000 && (x - price) < 5000)
                {
                    result = "Нехватает совсем малость, поднажми малость";
                }
                if ((x - price) < 1000)
                {
                    result = "Ай, ну как так, такие пустяки остались";
                }
            }

            return result;
        }
    }
}
