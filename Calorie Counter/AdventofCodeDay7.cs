using System.Text.RegularExpressions;

namespace Calorie_Counter
{
    public class AdventofCodeDay7
    {
        public static void FreeUpSpace()
        {
            var commands = File.ReadAllLines("C:\\Users\\rmaye\\source\\repos\\Calorie Counter\\Calorie Counter\\Day7.txt");
            int smallFolders = 0, totalSpace = 70000000, updateReq = 40000000;
            Dictionary<int, Directory> folders = new();
            folders.Add(0, new Directory("$ cd /"));
            foreach (string command in commands)
            {
                switch (command.Substring(0, 2))
                {
                    case "$ ":
                        if (command == "$ ls" || command == "$ cd /")
                            break;
                        else if (command == "$ cd ..")
                        {
                            for (int i = folders.Last().Key; i >= 0; i--)
                            {
                                if (folders[i].Active == true)
                                {
                                    folders[i].Active = false;
                                    break;
                                }
                            }
                            break;
                        }
                        else
                            folders.Add(folders.Last().Key + 1, new Directory(command));
                        break;
                    case "di":
                        break;
                    default:
                        int numbers = Int32.Parse(Regex.Replace(command, @"[a-zA-Z .]", ""));
                        foreach (var folder in folders)
                        {
                            if (folder.Value.Active == false)
                                continue;
                            else if (folder.Value.Active == true)
                                folder.Value.fileSize += numbers;
                        }
                        break;
                }
            }
            foreach (var folder in folders)
            {
                if (folder.Value.fileSize <= 100000)                                              // Finding small folder sizes (less than 100 KB)
                {
                    smallFolders += folder.Value.fileSize;
                }
            }
            Console.WriteLine($"File size for folders under 100 KB: {smallFolders}");
            Console.WriteLine($"Storage Allocation: {folders[0].fileSize}/{totalSpace}");        // Finding smallest folder to delete
            int spaceNeeded = folders[0].fileSize - updateReq;
            Console.WriteLine($"Amount needed for deletion: {spaceNeeded}");
            Directory deleteFolder = new();
            foreach (var folder in folders)
            {
                if (folder.Value.fileSize > spaceNeeded && folder.Value.fileSize < deleteFolder.fileSize)
                {
                    deleteFolder = folder.Value;
                }
            }
            Console.WriteLine($"The folder to be deleted is {deleteFolder.Name} with a file size of {deleteFolder.fileSize} bytes. Delete (y/n)?");
            Console.ReadKey();
        }
    }
    public class Directory
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public int fileSize { get; set; }

        public Directory()
        {
            Name = "";
            fileSize = 999999999;
            Active = false;
        }
        public Directory(string command)
        {
            Name = command.Substring(5);
            fileSize = 0;
            Active = true;
        }
    }
}
