namespace Test;

class Program
{
    static void Main(string[] args)
    {
        List<string> textList = new List<string>();

        Console.WriteLine("Добро пожаловать в программу" 
        + ", которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам");
        Console.WriteLine("\nВыберите одно из следующих действий:");
        Console.WriteLine("[1] Вводить данные с клавиатуры (вводить латинскими буквами или числами) \n[2] Автоматическое введение данных");
        switch (Console.ReadLine())
        {
            case "1":
            while (true)
            {
                Console.Write("Введите строку. Для продолжения введите пустую строку: ");
                string? text = Console.ReadLine();
                if(string.IsNullOrEmpty(text))
                break;
                textList.Add(text);
                Console.WriteLine("Текст \"{0}\" успешно добавлен", text);
            }
            break;
            case "2":
            Random rnd = new Random();
            for (var i = 0; i < rnd.Next(1, 10); i++)
            {
                string text = "";
                for (var j = 0; j < rnd.Next(1, 10); j++)
                {
                    text += rnd.Next(0, 10).ToString();
                }
                textList.Add(text);
                Console.WriteLine("Текст \"{0}\" успешно добавлен", text);
            }
            break;
            default:
            break;
        }
        Console.WriteLine("\nСтроки, длина которых меньше, либо равна 3 символам:");
        List<string> newTextList = textList.Where(i => i.Length <=3).ToList();
        for (var i = 0; i < newTextList.Count; i++)
            Console.WriteLine(newTextList[i]);
    }
}
