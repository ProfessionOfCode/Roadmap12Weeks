namespace Roadmap12Weeks.Weeks.week1
{
    internal interface IPhoto
    {
        Task TakeAPhotoAsync(CancellationToken cancellationToken);
        void TakeAPhoto();
    }
}