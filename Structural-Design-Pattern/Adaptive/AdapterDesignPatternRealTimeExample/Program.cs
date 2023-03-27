
using AdapterDesignPatternRealTimeExample;

var reply = new EnglishSpeaker().AskQuestion("How are you?");
Console.WriteLine("...Reply from [German Speaker] translated into English: " + reply);

Console.WriteLine();

reply = new GermanSpeaker().AskQuestion("Wo bist du?");
Console.WriteLine("...Reply From [English Speaker] translated into German: " + reply);