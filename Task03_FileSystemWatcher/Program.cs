using System;
using System.IO;

/*
FileSystemWatcher и наблюдение за состоянием папки.
Отслеживать появление файлов во входной папке,
выполнять задание из них,
сохранять файл с результатом в выходной папке.
*/

class Task03_FileSystemWatcher
{
    static string initialDir = "Files";
    static string backupDir = "Backup";

    static void Main(string[] args)
    {
        SecureDirectories();
        StartWatcher();
        Console.WriteLine("Для окончания программы нажмите любую клавишу...");
        Console.ReadKey();
    }

    private static void SecureDirectories()
    {

    }

    private static void CreateDirectory(string directory)
    {
        
    }

    //
    // Далее все, что связано c FileSystemWatcher
    //

    private static void StartWatcher()
    {
        FileSystemWatcher watcher = new FileSystemWatcher();
        watcher.Path = initialDir;
        watcher.Changed += OnChanged;
        watcher.Created += OnCreated;
        watcher.Deleted += OnDeleted;
        watcher.Renamed += OnRenamed;
        watcher.Error += OnError;
        watcher.EnableRaisingEvents = true;
    }

    private static void OnChanged(object sender, FileSystemEventArgs e)
    {

    }

    // Перенос файла в папку считается за создание
    private static void OnCreated(object sender, FileSystemEventArgs e)
    {

    }

    private static void OnDeleted(object sender, FileSystemEventArgs e)
    {

    }

    private static void OnRenamed(object sender, FileSystemEventArgs e)
    {

    }

    private static void OnError(object sender, ErrorEventArgs e)
    {

    }

    // Будет создавать копии всех текстовых файлов в папке Backup
    private static void CopyFile(string filename)
    {

    }
}
