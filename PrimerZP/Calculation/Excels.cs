using System;
using System.IO;

namespace PrimerZP
{
    class Excels
    {
        public string goal = Properties.Settings.Default.goal;
        string pathJukov = @"Jukov.txt";

        // подстчет примерной недельной зарплаты
        public string Result(DateTime date)
        {
            double a = (int)date.DayOfWeek; int price = 0;a--;
            
            using (StreamReader sr = new StreamReader(pathJukov, System.Text.Encoding.Default))
            {
                string line;
                // проверяем даты понтажей и суммируем необходимый прайс 
                while ((line = sr.ReadLine()) != null)
                {
                    var i = DateTime.ParseExact(line.Substring(0, 10), "dd.MM.yyyy", null);
                    if (i >= date.AddDays(-a) && i <= date.AddDays(6 - a))
                    {
                        price += Convert.ToInt32(line.Substring(17));
                    }
                }
                sr.Close();
            }
            return Convert.ToString(price);
            
        }

        // добавление данных в "базу"
        public void EnterData(string line)
        {
            using (StreamWriter sw = new StreamWriter(pathJukov, true, System.Text.Encoding.Default))
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

            // выбраны подсказки с "словами"
            if (!Properties.Settings.Default.govno) { 
            if (price > x)
            {
                if ((price - x) > 10000)
                {
                    result = $"Да ты просто красавец, Вауся! \n{price-x} сверх требуемого!";
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
                    result = "Немного не хватает, поднажми малость";
                }
                if ((x - price) < 1000)
                {
                    result = "Ай, ну как так, такие пустяки остались";
                }
            }
            }
            // выбраны подсказки с "деньгами"
            else {
                if (price > x)
                {
                    result = $"Превышение цели на {price - x} рублей. \nТак держать!";
                }
                else if (x == price)
                {
                    result = "Тютелька в Тютельку!";
                }
                else if (x > price)
                {
                    result = $"До цели не хватает {x - price} рублей. \nПоднажми немного!";

                }
            }
            
            return result;
        }
    }
}
