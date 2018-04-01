using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IReadFileController
{
    string getSelectedFileDirectoryText(string filePath);
    byte[] getSelectedFileDirectoryBytes(string filePath);
}
