namespace DelegatesAndEvents;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"Mail Service: Sending an email ... and Title : {e.Video?.Title}");
    }
}
