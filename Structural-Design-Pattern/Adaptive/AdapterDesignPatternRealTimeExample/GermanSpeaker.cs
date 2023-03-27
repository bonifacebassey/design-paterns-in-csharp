namespace AdapterDesignPatternRealTimeExample;

public class GermanSpeaker : INativeSpeaker
{
    public string AnswerFortheQuestion(string Words)
    {
        string reply = "";
        if (Words.Equals("Wie geht es dir?", StringComparison.InvariantCultureIgnoreCase))
        {
            reply = "Es geht mir gut";
        }
        return reply;
    }

    public string AskQuestion(string Words)
    {
        Console.WriteLine("Wolfgang [German Speaker] asked a question: " + Words);

        var translator = new Translator();
        return translator.TranslateAndTellToOtherPerson(Words, "English");
    }
}
