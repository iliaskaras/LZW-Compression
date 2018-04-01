using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IWriteFileDAO
{
    void writeToFileBytes(string filePath, byte[] bytes);
    void writeToFileText(string filePath, string textToWrite);
   
}

