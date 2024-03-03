using System.IO;

class FDHandling
{
    public void CreateFile()
    {
        var folderPath=@"E:\Semester\Sadik 6th Sem\NetCentric.Vedas2080\Consoleapp\CG_FileIO";//@ is used to specify the path of the directory or
        // var filePath=$"{folderPath}\\student.txt";
        // File.WriteAllText(filePath,"Hello sadik ghimire");
        // Console.WriteLine("Your File created successfully");

        //Create 10 text files with names in format FileA1.txt, FileB2.txt......
        //Each file should contain current datetime as its content
        // string currentDateTime=DateTime.Now.ToString();

        for(int i=1;i<=10;i++)
        {
            var filePath=$"{folderPath}\\File{(char)('A' + (i - 1))}{i}.txt";
            File.WriteAllText(filePath,DateTime.Now.ToLongDateString());
        }
        Console.WriteLine("All files created");
    }
    public void ReadFile()
    {
        var filePath=@"E:\Semester\Sadik 6th Sem\NetCentric.Vedas2080\notes.txt";
        var fileContent=File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

        //Read file and count number of words and sentences
        var sentences=fileContent.Split(['.','?','!']);
        Console.WriteLine($"Number of sentences: {sentences.Length}");
        // foreach(var sentence in sentences)
        // {
        //     Console.WriteLine(sentence);
        // }

        var words=fileContent.Split([" " ,"\n",":","-","\\",".","//",","],StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Number of words: {words.Length}");
        foreach(var word in words)
        {
            Console.WriteLine(word);
        }
        
    }

}