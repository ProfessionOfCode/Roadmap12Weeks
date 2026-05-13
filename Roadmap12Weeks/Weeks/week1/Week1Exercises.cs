namespace Roadmap12Weeks.Weeks.week1
{
    /// <summary>
    /// Modern C# has many features that can make your code more concise, readable, and maintainable. 
    /// In this class, we will explore some of the most useful features of modern C#, such as:
    /// - Pattern matching
    /// - Records
    /// - Local functions
    /// - Nullable reference types
    /// - Extension members
    /// </summary>
    public class ModernCsharp: IBeforeAfterComparer
    {
        private Camera _camera;

        public ModernCsharp()
        {
            _camera = new Camera();
        }

        public string Before()
        {
            var cameraInfo = CameraExtensionsOldStyle.CameraInfo(_camera);
            Console.WriteLine(cameraInfo);
            return cameraInfo;
        }

        public string After() 
        {
            var cameraInfo = _camera.CameraInfo();       // TODO: use the new extension member syntax
            Console.WriteLine(cameraInfo);
            return cameraInfo;
        }

    }
}
