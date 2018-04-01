using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCompressionLzwFormApplication
{
    class LZWTutorialDecompressTextController : ILZWTutorialDecompressTextController
    {
        public LZWDictionaryController _LZWDictionaryController = new LZWDictionaryController();
        public WriteFileDAO _writeTextFileDAO = new WriteFileDAO();
        public TextCompressionTutorialLzwForm lzwHelpForm = new TextCompressionTutorialLzwForm();
        IMessageHandler _messageHandler = new MessageHandler();

        public LZWTutorialDecompressTextController(TextCompressionTutorialLzwForm lzwHelpForm)
        {
            this.lzwHelpForm = lzwHelpForm;
        }

        public void LZWTutorialDecompressFile(string fileText)
        {

             DateTime TimeDate1 = DateTime.Now;
             string uncompressedText;
             uncompressedText = LZWTutorialDecompressText(fileText);
             DateTime TimeDate2 = DateTime.Now;

             _writeTextFileDAO.writeToFileText("simpleMethodTextUncompressed.txt", uncompressedText);

        }

        public string LZWTutorialDecompressText(string compressedFileText)
        {
            List<int> codeWordList = new List<int>();
            List<LzwFormDecompressionItems> _lzwFormItems = new List<LzwFormDecompressionItems>();
            int firstTimeFlag = 1;
            int loopCounter = 1;
            int firstCodeKey;
            int currentCodeKey;
            int previousCodeKey = 0;
            string currentCodeValue;
            string previousCodeValue;
            string previousAndCurrentCodeValue;
            int dictKeyCount = 255;
            string value;

            codeWordList = getCompressedTextCodeList(compressedFileText);
            this._LZWDictionaryController.createCompressedDictionary();
            Dictionary<int, string> compressedLZWDictionary = this._LZWDictionaryController.compressedLZWDictionary.getCompressedIntStringPairDictionary();
            StringBuilder decompressedText = new StringBuilder();

            foreach (var codeWord in codeWordList)
            {

                currentCodeKey = codeWord;
                if (firstTimeFlag == 1)
                {
                    firstCodeKey = currentCodeKey;
                    decompressedText.Append(compressedLZWDictionary[firstCodeKey]);
                    previousCodeKey = firstCodeKey;
                    _lzwFormItems.Add(new LzwFormDecompressionItems("First Time so output current's pair value",loopCounter, firstCodeKey.ToString(), compressedLZWDictionary[firstCodeKey], firstCodeKey.ToString(), compressedLZWDictionary[firstCodeKey], true, " - ", " - ", compressedLZWDictionary[firstCodeKey], " - ", " -"));
                    
                }

                bool testExistance = compressedLZWDictionary.TryGetValue(currentCodeKey, out value);
                if (testExistance.Equals(true) && firstTimeFlag != 1)
                {
                    decompressedText.Append(compressedLZWDictionary[currentCodeKey]);

                    previousCodeValue = compressedLZWDictionary[previousCodeKey];
                    string cwValue = compressedLZWDictionary[currentCodeKey];
                    currentCodeValue = cwValue[0].ToString();
                    previousAndCurrentCodeValue = previousCodeValue + currentCodeValue;

                    
                    compressedLZWDictionary.Add(dictKeyCount + 1, previousAndCurrentCodeValue);
                    _lzwFormItems.Add(new LzwFormDecompressionItems("Current Code Key exists in dictionary - output currentCode value,P:=string.pw,C:=string.cw[0]",loopCounter, currentCodeKey.ToString(), compressedLZWDictionary[currentCodeKey], previousCodeKey.ToString(), previousCodeValue, testExistance, currentCodeValue, previousCodeValue,
                                                                    compressedLZWDictionary[currentCodeKey], previousAndCurrentCodeValue,(dictKeyCount + 1).ToString() + previousAndCurrentCodeValue));
                    previousCodeKey = currentCodeKey;
                    dictKeyCount += 1;
                }
                else if (testExistance.Equals(false) && firstTimeFlag != 1)
                {
                    previousCodeValue = compressedLZWDictionary[previousCodeKey];
                    currentCodeValue = previousCodeValue[0].ToString();
                    previousAndCurrentCodeValue = previousCodeValue + currentCodeValue;
                    decompressedText.Append(previousAndCurrentCodeValue);

                    compressedLZWDictionary.Add(dictKeyCount + 1, previousAndCurrentCodeValue);
                    dictKeyCount += 1;
                    _lzwFormItems.Add(new LzwFormDecompressionItems("Current Code Key doesn't exists in dictionary - output P+C value,P:=string.pw,C:=string.pw[0]",loopCounter, currentCodeKey.ToString(), compressedLZWDictionary[currentCodeKey], previousCodeKey.ToString(), previousCodeValue, testExistance, currentCodeValue, previousCodeValue,
                                                                    previousAndCurrentCodeValue, previousAndCurrentCodeValue, (dictKeyCount - 1).ToString() +" | "+ previousAndCurrentCodeValue));
                    previousCodeKey = currentCodeKey;
                }

                firstTimeFlag = 0;
                loopCounter += 1;
            }

            fillTutorialDecompressFormTable(_lzwFormItems);
            return decompressedText.ToString();
        }

        
        public void fillTutorialDecompressFormTable(List<LzwFormDecompressionItems> _lzwFormItems)
        {
            this.lzwHelpForm.lzwDecompressionDetailDataGridView.Rows.Clear();
            foreach (var newGridRowItems in _lzwFormItems)
            {
                this.lzwHelpForm.lzwDecompressionDetailDataGridView.Rows.Add(newGridRowItems.DecompressionDetails, newGridRowItems.LoopCounter, "key:" + newGridRowItems.CurrentCodeWord + " | value:"
                                                                            + newGridRowItems.CurrentCodeWordString, "key:" + newGridRowItems.PreviousCodeWord + " | value:"
                                                                            + newGridRowItems.PreviousCodeWordString, newGridRowItems.PrevKeptString, newGridRowItems.CurrKeptString,
                                                                            newGridRowItems.AddedToDictionary, newGridRowItems.Output);
            }

        }

        public List<int> getCompressedTextCodeList(string compressedFileText)
        {
            List<int> codeWordList = new List<int>();
            string[] splitString = compressedFileText.Split(' ');

            for (int i = 1; i < splitString.Length; i += 1)
            {
                codeWordList.Add(Convert.ToInt32(splitString[i]));
            }

            return codeWordList;
        }
    }


}
