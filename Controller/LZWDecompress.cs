using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCompressionLzwFormApplication.View;


namespace TextCompressionLzwFormApplication
{
    class LZWDecompress
    {
        public LZWDictionaryController _LZWDictionaryController = new LZWDictionaryController();
        public IWriteFileController _writeFileController = new WriteFileController();
        public WriteFileDAO _writeTextFileDAO = new WriteFileDAO();
        public TextCompressionLzwForm lzwHelpForm = new TextCompressionLzwForm();
        public int maxCodeLen = 16; 

        public LZWDecompress(TextCompressionLzwForm lzwHelpForm)
        {
            this.lzwHelpForm = lzwHelpForm;
        }

        public LZWDecompress()
        {
            
        }

        public void LZWDecompressFile(string fileName, string decompressedFilePath, int maxCodeLen)
        {
            DateTime TimeDate1 = DateTime.Now;

            byte[] compressedBytes = File.ReadAllBytes(fileName);
            string compressedCodelenBinary;
            string uncompressedText;
            compressedCodelenBinary = compressedBytes.compressedBytesToCodelenBytes(maxCodeLen); 
            uncompressedText = LZWDecompressText(compressedCodelenBinary, maxCodeLen);


            DateTime TimeDate2 = DateTime.Now;
            TimeSpan totalTime = TimeDate2 - TimeDate1;
            this.lzwHelpForm.decompressedTimeConsumedTextBox.Text = totalTime.Seconds + "." + totalTime.Milliseconds.ToString().PadLeft(3, '0') + " sec";
            _writeFileController.writeToFileText(decompressedFilePath, uncompressedText);
        }

        public string LZWDecompressText(string compressedCodelenBinary, int maxCodeLen)
        {
            List<int> codeWordList = new List<int>();
            int loopCounter = 1;
            int firstCodeKey;
            int currentCodeKey = 0;
            int previousCodeKey = 0;
            string currentCodeValue;
            string previousCodeValue;
            string previousAndCurrentCodeValue;
            int dictKeyCount = 255;
            string value;


            codeWordList = compressedCodelenBinary.getCompressedCodeWordList(maxCodeLen);


            this._LZWDictionaryController.createCompressedDictionary();
            Dictionary<int, string> compressedLZWDictionary = this._LZWDictionaryController.compressedLZWDictionary.getCompressedIntStringPairDictionary();
            StringBuilder decompressedText = new StringBuilder();

            foreach (var codeWord in codeWordList)
            {



                if (dictKeyCount >= Math.Pow(2, maxCodeLen) - 1)
                {
                    dictKeyCount = 255;
                    compressedLZWDictionary.Clear();
                    this._LZWDictionaryController.createCompressedDictionary();
                    compressedLZWDictionary = this._LZWDictionaryController.compressedLZWDictionary.getCompressedIntStringPairDictionary();
                    currentCodeKey = codeWord;
                    
                }
                else
                {
                    currentCodeKey = codeWord;
                   
                }

                if (loopCounter == 1)
                {
                    firstCodeKey = currentCodeKey;
                    decompressedText.Append(compressedLZWDictionary[firstCodeKey]);
                    previousCodeKey = currentCodeKey;

                    loopCounter = -1;
                    continue;
                }

                bool testExistance = compressedLZWDictionary.TryGetValue(currentCodeKey, out value);
                if (testExistance.Equals(true) && loopCounter != 1 )
                {
                    decompressedText.Append(compressedLZWDictionary[currentCodeKey]);
                    previousCodeValue = compressedLZWDictionary[previousCodeKey];
                    string cwValue = compressedLZWDictionary[currentCodeKey];
                    currentCodeValue = cwValue[0].ToString();
                    previousAndCurrentCodeValue = previousCodeValue + currentCodeValue;

                    compressedLZWDictionary.Add(dictKeyCount + 1, previousAndCurrentCodeValue);
                    dictKeyCount += 1;
                  
                    previousCodeKey = currentCodeKey;
                }
                else if (testExistance.Equals(false) && loopCounter != 1 )
                {
                    

                    previousCodeValue = compressedLZWDictionary[previousCodeKey];
                    currentCodeValue = previousCodeValue[0].ToString();
                    previousAndCurrentCodeValue = previousCodeValue + currentCodeValue;

                    decompressedText.Append(previousAndCurrentCodeValue);
                    compressedLZWDictionary.Add(dictKeyCount + 1, previousAndCurrentCodeValue);
                    dictKeyCount += 1;
                   
                    previousCodeKey = currentCodeKey;

                }

            }


            return decompressedText.ToString();
        }


        public string getCompressionRatio(double uncompressedSize,double compressedSize)
        {
            double compressionRatio = 0;

            compressionRatio = (uncompressedSize / compressedSize) * 100;

            return compressionRatio.ToString("0.00");
        }
        

      
    }
}
