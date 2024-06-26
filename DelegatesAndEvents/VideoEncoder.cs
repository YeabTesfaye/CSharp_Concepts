namespace DelegatesAndEvents;
public class VideoEncoder
{
    // 1 -  Define a delegate
    // 2 - Define an event based on that delegate
    // 3 - Raise the event 
    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    public event VideoEncodedEventHandler? VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding Video .......");
        Thread.Sleep(3000);
        OnVideoEncoded(video);
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
    }
}