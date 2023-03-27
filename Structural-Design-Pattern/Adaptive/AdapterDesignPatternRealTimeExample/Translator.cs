namespace AdapterDesignPatternRealTimeExample;

// Translator can translate both English and German
public class Translator : ITarget
{
    private static Dictionary<string, string> EnglishGermanDictionary = new();
    private static Dictionary<string, string> GermanEnglishDictionary = new();

    private EnglishSpeaker englishSpeaker = new();
    private GermanSpeaker germanSpeaker = new();

    static Translator()
    {
        EnglishGermanDictionary.Add("How are you?", "Wie geht es dir?");
        EnglishGermanDictionary.Add("I am in Nigeria", "Ich bin in Nigeria");
        GermanEnglishDictionary.Add("Es geht mir gut", "I am fine");
        GermanEnglishDictionary.Add("Wo bist du?", "Where are you?");
    }

    public string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage)
    {
        if (convertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
        {
            var englishWords = ConvertToEnglish(words);
            Console.WriteLine($"\tTranslator Converted '{words}' to '{englishWords}' and sends the question to EnglishSpeaker");

            var englishWordsReply = englishSpeaker.AnswerFortheQuestion(englishWords);
            Console.WriteLine($"\tTranslator Got reply from EnglishSpeaker in English: '{englishWordsReply}'");

            var germanConverted = ConvertToGerman(englishWordsReply);
            Console.WriteLine($"\tTranslator Converted '{englishWordsReply}' to  '{germanConverted}' and sends it back to GermanSpeaker\n");

            return germanConverted;
        }
        else if (convertToWhichLanguage.Equals("German", StringComparison.InvariantCultureIgnoreCase))
        {
            var germanWords = ConvertToGerman(words);
            Console.WriteLine($"\tTranslator Converted '{words}' to '{germanWords}' and sends the question to GermanSpeaker");

            var germanWordsReply = germanSpeaker.AnswerFortheQuestion(germanWords);
            Console.WriteLine($"\tTranslator Got reply from GermanSpeaker in German: '{germanWordsReply}'");

            var englishConverted = ConvertToEnglish(germanWordsReply);
            Console.WriteLine($"\tTranslator Converted '{germanWordsReply}' to  '{englishConverted}' and sends it back to EnglishSpeaker\n");

            return englishConverted;
        }
        else
        {
            return "Sorry Cannot Covert";
        }
    }

    public string ConvertToGerman(string words)
    {
        return EnglishGermanDictionary[words];
    }
    public string ConvertToEnglish(string words)
    {
        return GermanEnglishDictionary[words];
    }
}
