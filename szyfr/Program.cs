using System;

public class Test
{
    public static string[] szyfr = { "qwertyuiopasdfghjklzxcvbnm", "lkjhgfdsamnbvcxzpoiuytrewq" };
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Wybierz jedną z dostępnych opcji:");
            while (true)
            {
                Menu();
                string select = Console.ReadLine();
                if (int.TryParse(select, out int IntResult))
                {
                    if (IntResult == 0)
                    {
                        return;
                    }
                    Program(IntResult);
                }
                else
                {
                    Console.WriteLine("Proszę wybrać opcję z dostępnych");
                }
            }
        }
    }
    public static void Menu()
    {
        string[] MenuOptions = { "[1] Szyfrowanie", "[2] Deszyfrowanie", "[0] Zamknięcie programu" };
        foreach (string option in MenuOptions)
        {
            Console.WriteLine($"{option}");
        }
    }
    public static void Program(int x)
    {
        Console.WriteLine("Wybrano opcję nr " + x);
        int counter = 1;
        string text;
        switch (x)
        {
            case 1:
                Console.WriteLine("Podaj tekst do szyfrowania");
                text = GetString();
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < szyfr[0].Length; j++)
                    {
                        if (string.Equals(text[i], szyfr[0][j]) == true)
                        {
                            counter++;
                            Console.Write(szyfr[1][j]);
                        }
                        else
                    if ((counter == 1) && (j == szyfr[0].Length - 1))
                        {
                            Console.Write(text[i]);
                            counter = 1;
                        }
                    }
                    counter = 1;
                }
                Console.Write("\n");
                break;
            case 2:
                Console.WriteLine("Podaj tekst do deszyfrowania");
                text = GetString();
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < szyfr[1].Length; j++)
                    {
                        if (string.Equals(text[i], szyfr[1][j]) == true)
                        {
                            counter++;
                            Console.Write(szyfr[0][j]);
                        }
                        else
                    if ((counter == 1) && (j == szyfr[1].Length - 1))
                        {
                            Console.Write(text[i]);
                            counter = 1;
                        }
                    }
                    counter = 1;
                }
                Console.Write("\n");
                break;
            default:
                Console.WriteLine("Wybrano opcję która nie istnieje");
                break;
        }
    }
    public static string GetString()
    {
        while (true)
        {
            string text = Console.ReadLine();
            if (text.Trim() != "")
            {
                return text.Trim();
            }
            else
            {
                Console.WriteLine("Proszę podać tekst");
            }
        }
    }
}