using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface ILZWTutorialCompressTextController
{
    void lzwTutorialCompressFile(string fileText);
    List<int> lzwTutorialCompressText(string fileText);
    string codeWordListToString(List<int> codeWordsList);
    Boolean checkCharExistanceInCompressedDictionary(string checkDictionaryChar, Dictionary<string, int> uncompressedDictionary);
}

