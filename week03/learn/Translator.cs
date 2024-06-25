public class Translator
{
    private Dictionary<string, string> _words = new Dictionary<string, string>();

    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car"));   // Output: Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Output: Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // Output: ???
    }

    /// <summary>
    /// Add the translation from 'fromWord' to 'toWord'
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    public void AddWord(string fromWord, string toWord)
    {
        // check if the word already exists in the dictionary
        if (_words.ContainsKey(fromWord))
        {
            Console.WriteLine($"'{fromWord}' is already added with translation");
            return;
        }

        // add the translation to the dictionary
        _words[fromWord] = toWord;
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        string newWord;
        // check if the word exists in the dictionary
        if (_words.ContainsKey(fromWord))
        {
            newWord = _words[fromWord];
        }
        else
        {
            newWord = "???"; // return "???" if no translation is available
        }

        return newWord;
    }
}