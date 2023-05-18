#pragma warning disable CS8604
#pragma warning disable CS8600
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        Console.WriteLine("Выберите операцию (1-4):");
        Console.WriteLine("1) Перемешать буквы");
        Console.WriteLine("2) Написать наоборот");
        Console.WriteLine("3) Вывести слово дважды");
        //Console.WriteLine("4) Убрать все гласные из слова");

        int qwe = int.Parse(Console.ReadLine());


        switch (qwe)
        {
            case 1:
                string peremeshatWord = Peremeshka(word);
                Console.WriteLine(peremeshatWord);
                break;
            case 2:
                string reversedWord = Reverse(word);
                Console.WriteLine(reversedWord);
                break;
            case 3:
                string doubledWord = Double(word);
                Console.WriteLine(doubledWord);
                break;
            //case 4:
            //    string bezglasnWord = Bezglasn(word);
            //    Console.WriteLine(bezglasnWord);
            //    break;
            default:
                Console.WriteLine("Некорректная операция");
                break;
        }
    }

    static string Peremeshka(string word)
    {
        char[] chars = word.ToCharArray();
        Random rand = new Random();
        for (int i = chars.Length - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
        return new string(chars);
    }

    static string Reverse(string word)
    {
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    static string Double(string word)
    {
        return word + " " + word;
    }

    //static string Bezglasn(string word)
    //{
    //    string glasn = "уеаоюэяиУЕАОЭЯИЮeyuioaEYUIOA";
    //    char[] chars = word.ToCharArray();
    //    string result = "";
    //    foreach (char c in chars)
    //    {
    //        if (glasn.IndexOf(c) == -1)
    //        {
    //            result += c;
    //        }
    //    }
    //    return result;
    //}
}