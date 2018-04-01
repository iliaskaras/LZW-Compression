using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class LZWDictionaryController
{
    public LZWDictionary uncompressedLZWDictionary = new LZWDictionary();
    public LZWDictionary compressedLZWDictionary = new LZWDictionary();

    public int getMaxPreCompressDictionaryASCII(string textToCompress)
    {
        char[] wordToCompressChars = new char[textToCompress.Length];
        int maxAsciiValue = 0;

        foreach (char c in textToCompress)
                {
                    if ((int)c > maxAsciiValue)
                    {
                        maxAsciiValue = (int)c;
                    } 
                }

        return maxAsciiValue;
    }

    public Dictionary<string, int> getUncompressedDictionary()
    {
        Dictionary<string, int> uncompressedDictionary = new Dictionary<string, int>();

        for (int i = 0; i < 256; i++)
        {
            uncompressedDictionary.Add(System.Text.Encoding.Default.GetString(new byte[1] { Convert.ToByte(i) }), i);
        }
       
        return uncompressedDictionary;
    }

    public Dictionary<int, string> getCompressedDictionary()
    {
        Dictionary<int, string> compressedDictionary = new Dictionary<int, string>();

        for (int i = 0; i < 256; i++)
        {
            compressedDictionary.Add(i, System.Text.Encoding.Default.GetString(new byte[1] { Convert.ToByte(i) }));
        }

        return compressedDictionary;
    }

    public void createUncompressedDictionary()
    {
        Dictionary<string, int> uncompressedDictionary = new Dictionary<string, int>();

        uncompressedDictionary = getUncompressedDictionary();

        this.uncompressedLZWDictionary = new LZWDictionary(uncompressedDictionary);
    }

    public void createCompressedDictionary()
    {
        Dictionary<int, string> compressedDictionary = new Dictionary<int, string>();

        compressedDictionary = getCompressedDictionary();

        this.compressedLZWDictionary = new LZWDictionary(compressedDictionary);
    }

    public void printUncompressedDictionary()
    {
        Dictionary<string, int> uncompressedDictionary = new Dictionary<string, int>();

        uncompressedDictionary = this.uncompressedLZWDictionary.getCompressedStringIntPairDictionary();
        foreach (var pair in uncompressedDictionary)
        {
            Console.WriteLine("Key:{0} --- Value:{1} ----- test : {2}", pair.Key, pair.Value, System.Text.ASCIIEncoding.ASCII.GetByteCount(pair.Key));
        }
    }
}
