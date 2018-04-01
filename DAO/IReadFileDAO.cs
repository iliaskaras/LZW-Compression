using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IReadFileDAO
{
    string readFileText(string filePath);
    byte[] readFileBytes(string filePath);
}

