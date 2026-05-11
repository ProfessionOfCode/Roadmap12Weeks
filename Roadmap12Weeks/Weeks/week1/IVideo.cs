namespace Roadmap12Weeks.Weeks.week1
{
    internal interface IVideo
    {
        Task TakeAVideoAsync(CancellationToken cancellationToken);
        void TakeAVideo();
    }
}