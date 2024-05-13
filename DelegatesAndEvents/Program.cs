namespace DelegatesAndEvents;

class Program
{
    public static void Main(String[] args)
    {


        var video = new Video() { Title = "Vidoe 1" };
        var videoEncoder = new VideoEncoder(); // publisher
        var mailService = new MailService();  // Subscriber
        var messageService = new MessageService(); // another subscriber


        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);

    }
}
