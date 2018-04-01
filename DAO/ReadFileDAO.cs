using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadFileDAO : IReadFileDAO
{
    
    public ReadFileDAO(){

    }

    public String readFileText(string filePath)
    {
        string readFileText = null;

        try
        {
            readFileText = File.ReadAllText(filePath, System.Text.Encoding.Default);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
        return readFileText;
    }

    public byte[] readFileBytes(string filePath)
    {
        byte[] readFileBytes = null;

        try
        {
            readFileBytes = File.ReadAllBytes(filePath);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
       
        return readFileBytes;
    }
}

