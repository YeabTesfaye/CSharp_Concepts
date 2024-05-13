namespace DelegatesAndEvents;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"Message Service : Sending a text message .... and Title : {e.Video?.Title}");
    }
}
