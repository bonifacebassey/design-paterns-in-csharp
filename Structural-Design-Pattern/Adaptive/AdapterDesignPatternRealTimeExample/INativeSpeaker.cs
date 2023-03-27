namespace AdapterDesignPatternRealTimeExample;

public interface INativeSpeaker
{
    string AskQuestion(string Words);
    string AnswerFortheQuestion(string Words);
}
