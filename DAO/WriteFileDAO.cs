using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WriteFileDAO : IWriteFileDAO
{
    public void writeToFileBytes(string filePath,byte[] bytes)
    {
        try
        {
            File.WriteAllBytes(filePath, bytes);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }

    public void writeToFileText(string filePath, string textToWrite)
    {
        try
        {
            File.WriteAllText(filePath, textToWrite,System.Text.Encoding.Default);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }  
}

