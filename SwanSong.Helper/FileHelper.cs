namespace SwanSong.Helper;

public class FileHelper
{ 
    public static string getGuidFileName(string extension)
    {
        return System.Guid.NewGuid().ToString() + "." + extension;
    }
}