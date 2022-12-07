namespace adventofcode2022
{
    public class Day7 : PuzzleBase
    {
        public Day7(string file) : base(file) { }
        public Day7(string[] lines) : base(lines) { }

        public int Part1()
        {
            var baseDir = ParseFileSystem();
            var dirs = FindDirsWithMaxSize(baseDir, 100000);
            var sum = 0;
            foreach (var dir in dirs)
            {
                sum += FindDirSize(dir);
            }
            return sum;
        }

        public int Part2()
        {
            var baseDir = ParseFileSystem();
            var totalUsed = FindDirSize(baseDir);
            var total = 70000000;
            var required = 30000000;
            var unusedSpace = total - totalUsed;
            var missingSpace = required - unusedSpace;

            var candidates = FindDirsWithMinSize(baseDir, missingSpace);
            var minCandiateSize = int.MaxValue;
            foreach(var dir in candidates)
            {
                var dirSize = FindDirSize(dir);
                if (dirSize < minCandiateSize)
                    minCandiateSize = dirSize;
            }
            return minCandiateSize;
        }

        private List<MyDir> FindDirsWithMaxSize(MyDir dir, int maxSize)
        {
            var list = new List<MyDir>();

            var dirSize = FindDirSize(dir);
            if (dirSize <= maxSize)
                list.Add(dir);

            foreach(var subDir in dir.SubDirs)
                list.AddRange(FindDirsWithMaxSize(subDir, maxSize));
            return list;
        }

        private List<MyDir> FindDirsWithMinSize(MyDir dir, int minSize)
        {
            var list = new List<MyDir>();

            var dirSize = FindDirSize(dir);
            if (dirSize >= minSize)
                list.Add(dir);

            foreach (var subDir in dir.SubDirs)
                list.AddRange(FindDirsWithMinSize(subDir, minSize));
            return list;
        }

        private int FindDirSize(MyDir dir)
        {
            var sum = 0;
            sum += dir.Files.Select(f => f.Size).Sum();
            foreach(var d in dir.SubDirs)
            {
                sum += FindDirSize(d);
            }
            return sum;
        }

        private MyDir ParseFileSystem()
        {
            var baseDir = new MyDir { Name = "/" };
            var currentDir = baseDir;
            var isListing = false;
            foreach (var line in Lines)
            {
                if (line.StartsWith("$"))
                {
                    var cmd = line.Substring(2);
                    if (cmd.StartsWith("cd"))
                    {
                        isListing = false;
                        var dirName = cmd.Substring(3);
                        if (dirName == "/")
                        {
                            currentDir = baseDir;
                        }
                        else if (dirName == "..")
                        {
                            if (currentDir.Parent != null)
                            {
                                currentDir = currentDir.Parent;
                            }
                        }
                        else
                        {
                            currentDir = currentDir.SubDirs.Single(d => d.Name == dirName);
                        }
                    }
                    else if (cmd == "ls")
                    {
                        isListing = true;
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
                else if (isListing)
                {
                    if (line.StartsWith("dir"))
                    {
                        var dirName = line.Substring(4);
                        if (currentDir.SubDirs.Any(x => x.Name == dirName))
                            throw new Exception("SubDir with name " + dirName + " already added");
                        var newDir = new MyDir { Name = dirName, Parent = currentDir };
                        currentDir.SubDirs.Add(newDir);
                    }
                    else
                    {
                        var fileSize = int.Parse(line.Split(' ')[0]);
                        var fileName = line.Split(' ')[1];
                        if (currentDir.Files.Any(x => x.Name == fileName))
                            throw new Exception("File with name " + fileName + " already added");
                        currentDir.Files.Add(new MyFile { Name = fileName, Size = fileSize });
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            return baseDir;
        }
    }

    public class MyDir
    {
        public MyDir() { 
            SubDirs = new List<MyDir>();
            Files = new List<MyFile>();
        }
        public string? Name { get; set; }
        public MyDir? Parent { get; set; }
        public List<MyDir>? SubDirs { get; set; }
        public List<MyFile>? Files { get; set; }
    }

    public class MyFile
    {
        public string? Name { get; set; }

        public int Size { get; set; }
    }

}
