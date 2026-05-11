namespace Roadmap12Weeks.Weeks.week1
{
    public static class CameraExtensions
    {
       extension(Camera camera)
       {
          string CameraInfo() =>$"{camera}, This is a camera that can take photos and videos.";
       }

    }

    public static class CameraExtensionsOldStyle
    {
        public static string CameraInfo(this Camera camera) => $"{camera}, This is a camera that can take photos and videos.";
    }
}
