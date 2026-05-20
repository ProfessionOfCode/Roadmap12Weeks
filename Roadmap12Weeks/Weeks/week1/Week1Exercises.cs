using System.Reflection;
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

    /// <summary>
    /// Implements synchronous and asynchronous file-read operations used for before/after comparisons via
    /// IBeforeAfterComparerAsync.s
    /// </summary>
    /// <remarks>Builds the file path from the executing assembly's full name and throws FileNotFoundException
    /// if the target file is missing. The Before/After methods use File.ReadAllText/File.ReadAllTextAsync and the
    /// BeforeAsync/AfterAsync methods use a FileStream with ReadExactly/ReadExactlyAsync to read the file
    /// contents.</remarks>
    public class AsyncAwaitManagement : IBeforeAfterComparerAsync
    {
        private readonly string _filePath;

        public AsyncAwaitManagement()
        {
            _filePath = Path.Combine(Path.GetFullPath(path: AppContext.BaseDirectory), "Weeks", "week1", "fileIO.txt");

            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException($"The file {_filePath} does not exist.");
            }
        }

        public string After()
        {
            using var fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
            var buffer = new byte[fileStream.Length];
            fileStream.ReadExactly(buffer);
            return $"File content read synchronously: {Encoding.UTF8.GetString(buffer)}";
        }

        public async Task<string> AfterAsync()
        {
            using var fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
            var buffer = new byte[fileStream.Length];
            await fileStream.ReadExactlyAsync(buffer);
            return $"File content read asynchronously: {Encoding.UTF8.GetString(buffer)}";
        }

        public string Before()
        {           
            var fileContent = File.ReadAllText(_filePath);

            return $"File content read synchronously: {fileContent}";
        }

        public async Task<string> BeforeAsync()
        {
            var fileContent = await File.ReadAllTextAsync(_filePath);
            return $"File content read asynchronously: {fileContent}";
        }

        // read file synchronously

    }
}
