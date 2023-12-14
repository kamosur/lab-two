using lab_2.DictionaryComponents;

namespace lab_2;

public class Class1
{
    public static void Start()
    {
        var wordsDictionary = new SingleRootWordsDictionary(new List<List<Word>>());
        var word = string.Empty;
        while (word != "q")
        {
            word = Console.ReadLine();
            if (wordsDictionary.WordSearch(word) is null)
            {
                Console.WriteLine("хотите ли внести слово в словарь (y/n)?");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    wordsDictionary.AddNewWord(word);
                }
            }
            else
            {
                var collection = wordsDictionary.WordSearch(word);
                Console.WriteLine("Известные однокоренные слова: ");
                foreach (var i in collection)
                {
                    PrintWord(i);
                }
            }
        }
    }
    
    public static void PrintWord(Word word)
    {
        for (int j = 0; j < word.Prefix.Count - 1; j++)
        {

            Console.Write(word.Prefix[j] + "-");

        }
        
        Console.Write(word.Root + "-");
        for (int j = 0; j < word.Postfix.Count - 2; j++)
        {

            Console.Write(word.Postfix[j] + "-");

        }
        Console.WriteLine(word.Postfix[^2]);
    }
}