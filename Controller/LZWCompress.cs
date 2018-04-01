using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCompressionLzwFormApplication.View;

namespace TextCompressionLzwFormApplication
{
    class LZWCompress
    {


        public LZWDictionaryController _LZWDictionaryController = new LZWDictionaryController();
        public WriteFileDAO _writeFileDAO = new WriteFileDAO();
        public IWriteFileController _writeFileController = new WriteFileController();
        public IReadFileController _readTextFileController = new ReadFileController();
        public TextCompressionLzwForm lzwHelpForm = new TextCompressionLzwForm();
        public int maxCodeLen = 16; 
        int codeLen = 9;

        public LZWCompress(TextCompressionLzwForm lzwHelpForm)
        {
            this.lzwHelpForm = lzwHelpForm;
        }

        public LZWCompress()
        {
            
        }

        public String LZWCompressText(string fileText, int maxCodeLen)
        {

            List<String> testListString = new List<String>();
            StringBuilder compressedBinaryText = new StringBuilder();
            this._LZWDictionaryController.createUncompressedDictionary();
            Dictionary<string, int> compressedLZWDictionary = this._LZWDictionaryController.uncompressedLZWDictionary.getCompressedStringIntPairDictionary();

            string previousChar = null;
            string currentChar = null;
            string checkDictionaryChar = null;
            Boolean checkDictionary = false;

            int totalAsciiDictionaryCounter = compressedLZWDictionary.Count - 1;
            int i = 1;


            foreach (char c in fileText)
            {
                currentChar = c.ToString();

                checkDictionaryChar = previousChar + currentChar;
                checkDictionary = checkCharExistanceInUncompressedDictionary(checkDictionaryChar, compressedLZWDictionary);

                if (totalAsciiDictionaryCounter >= Math.Pow(2, maxCodeLen) - 1)
                {
                    totalAsciiDictionaryCounter = 255;
                    this._LZWDictionaryController.createUncompressedDictionary();
                    compressedLZWDictionary = this._LZWDictionaryController.uncompressedLZWDictionary.getCompressedStringIntPairDictionary();
                    codeLen = 9;
                    currentChar = c.ToString();
                    checkDictionary = checkCharExistanceInUncompressedDictionary(checkDictionaryChar, compressedLZWDictionary);
                }

                if (checkDictionary.Equals(true))
                {
                    previousChar = previousChar + currentChar;
                }
                else if (checkDictionary.Equals(false))
                {
                   
                    
                    totalAsciiDictionaryCounter = totalAsciiDictionaryCounter + 1;
                    compressedLZWDictionary.Add(checkDictionaryChar, totalAsciiDictionaryCounter);

                    if (totalAsciiDictionaryCounter > Math.Pow(2, (codeLen)) - 1)
                    {

                        codeLen += 1;
                        compressedBinaryText.Append(Convert.ToString((int)compressedLZWDictionary[previousChar], 2).fillWithZero(codeLen));

                    }
                    else
                    {
                        
                        compressedBinaryText.Append(Convert.ToString((int)compressedLZWDictionary[previousChar], 2).fillWithZero(codeLen));
                        
                    }

                    previousChar = currentChar;

                }

                i = i + 1;
            }

            compressedBinaryText.Append(Convert.ToString((int)compressedLZWDictionary[previousChar], 2).fillWithZero(codeLen));

            return compressedBinaryText.ToString();

        }

        
        public void LZWCompressFile(string filePath,string compressedFilePath,int maxCodeLen)
        {
            DateTime TimeDate1 = DateTime.Now;

            string fileText = _readTextFileController.getSelectedFileDirectoryText(filePath);
            string compressedBinaryText = LZWCompressText(fileText, maxCodeLen);

            byte[] bytesToWrite = compressedBinaryText.binaryToBytes();

            DateTime TimeDate2 = DateTime.Now;
            TimeSpan totalTime = TimeDate2 - TimeDate1;
            this.lzwHelpForm.timeConsumedTextBox.Text = totalTime.Seconds + "." + totalTime.Milliseconds.ToString().PadLeft(3, '0') + " sec";
            _writeFileController.writeToFileBytes(compressedFilePath, bytesToWrite);
            

        }

        
        public Boolean checkCharExistanceInUncompressedDictionary(string checkDictionaryChar, Dictionary<string, int> uncompressedDictionary)
        {

            Boolean checkCharExistance = false;

            if (uncompressedDictionary.ContainsKey(checkDictionaryChar))
                checkCharExistance = true;
            else
                checkCharExistance = false;

            return checkCharExistance;
        }

       
    }
}
