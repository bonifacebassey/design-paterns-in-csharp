namespace AdapterDesignPatternRealTimeExample;

public class EnglishSpeaker : INativeSpeaker
{
    public string AnswerFortheQuestion(string Words)
    {
        string reply = "";
        if (Words.Equals("Where are you?", StringComparison.InvariantCultureIgnoreCase))
        {
            reply = "I am in Nigeria";
        }
        return reply;
    }

    public string AskQuestion(string Words)
    {
        Console.WriteLine("Ekaette [English Speaker] asked a question: " + Words);

        var translator = new Translator();
        return translator.TranslateAndTellToOtherPerson(Words, "German");
    }
}
