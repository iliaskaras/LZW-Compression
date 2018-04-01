using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IWriteFileController
{

    void writeToFileText(string filePath, string fileText);
    void writeToFileBytes(string filePath, byte[] bytes);

}

