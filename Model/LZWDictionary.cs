using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LZWDictionary
{
    public Dictionary<string, int> compressedStringIntPairDictionary = new Dictionary<string, int>();
    public Dictionary<int, string> compressedIntStringPairDictionary = new Dictionary<int, string>();

    public LZWDictionary(Dictionary<string, int> compressedStringIntDictionary)
    {
        this.compressedStringIntPairDictionary = compressedStringIntDictionary;
    }

    public LZWDictionary(Dictionary<int, string> compressedDictionary)
    {
        this.compressedIntStringPairDictionary = compressedDictionary;

    }

    public LZWDictionary()
    {

    }

    public void setCompressedIntStringPairDictionary(Dictionary<int, string> compressedDictionary)
    {
        this.compressedIntStringPairDictionary = compressedDictionary;
    }

    public Dictionary<int, string> getCompressedIntStringPairDictionary()
    {
        return this.compressedIntStringPairDictionary;
    }

    public void setCompressedStringIntPairDictionary(Dictionary<string, int> uncompressedDictionary)
    {
        this.compressedStringIntPairDictionary = uncompressedDictionary;
    }

    public Dictionary<string, int> getCompressedStringIntPairDictionary()
    {
        return this.compressedStringIntPairDictionary;
    }

}

