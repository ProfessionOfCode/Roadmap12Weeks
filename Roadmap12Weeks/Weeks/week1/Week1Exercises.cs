using System.Text;

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
    public class ModernCsharp : IBeforeAfterComparer
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
            var cameraInfo = _camera.CameraInfo();
            Console.WriteLine(cameraInfo);
            return cameraInfo;
        }

    }

    /// <summary>
    /// Implementation of memory optimization techniques in C# 8.0 and later versions, such as: Span<T>, Memory<T>, and stackalloc. 
    /// These features allow you to work with large data structures more efficiently and reduce memory allocations.
    /// </summary>
    public class MemoryManagement : IBeforeAfterComparer
    {
        private string[] _largeArray;
        public MemoryManagement()
        {
            _largeArray = ["James", "Mary", "Kylian", "Lucie", 
                "James", "Mary", "Kylian", "Lucie", "James", "Mary", 
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie", 
                "James", "Mary", "Kylian", "Lucie", "James", "Mary", 
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary", 
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie", "James", "Mary",
                "Kylian", "Lucie", "James", "Mary", "Kylian", "Lucie",
                "James", "Mary", "Kylian", "Lucie"
            ];
        }
        public string Before()
        {
            var upperCaseNames = new StringBuilder();
            var count = 0;
            foreach (var item in _largeArray[..30])
            {
                var itemInUpperCase = item.ToUpper();

                if(count == 29)
                {
                    upperCaseNames.Append(itemInUpperCase);
                    break;
                }
                else
                {
                    upperCaseNames.Append(itemInUpperCase).Append(", ");
                }
                
                count++;
            }
            
            return $"Memory management before C# 8.0. {upperCaseNames}";
        }
        public string After()
        {
            // Using Span<T> to process the large array without allocating additional memory for intermediate results
            var upperCaseNames = new StringBuilder();
            var namesSpan = _largeArray.AsSpan();
            var count = 0;
            foreach (var name in namesSpan[..30])
            {
                var itemInUpperCase = name.ToUpper();
                if (count == 29)
                {
                    upperCaseNames.Append(itemInUpperCase);
                    break;
                }
                else
                {
                    upperCaseNames.Append(itemInUpperCase).Append(", ");
                }

                count++;
            }
            
            return $"Memory management after C# 8.0. {upperCaseNames}";
        }

    }
}
