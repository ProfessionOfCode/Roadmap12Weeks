using System.Security.Cryptography.X509Certificates;

namespace Roadmap12Weeks.Weeks.week1
{
    public class Camera : IPhoto, IVideo, IAudio, IMicrophone
    {
        public void TakeAPhoto()
        {
            throw new NotImplementedException();
        }

        public Task TakeAPhotoAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void TakeAVideo()
        {
            throw new NotImplementedException();
        }

        public Task TakeAVideoAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        override public string ToString()
        {
            return $"Camera {DateTime.Now.Ticks}";
        }
    }
}
