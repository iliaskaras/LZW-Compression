using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface ILZWTutorialDecompressTextController
{
    string LZWTutorialDecompressText(string compressedFileText);
    void LZWTutorialDecompressFile(string fileText);
    List<int> getCompressedTextCodeList(string compressedFileText);
}

