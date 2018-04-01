using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextCompressionLzwFormApplication
{

    class LZWTutorialCompressTextController :  ILZWTutorialCompressTextController
    {
        public LZWDictionaryController _LZWDictionaryController = new LZWDictionaryController();
        public WriteFileDAO _writeTextFileDAO = new WriteFileDAO();
        public TextCompressionTutorialLzwForm lzwHelpForm = new TextCompressionTutorialLzwForm();
        IMessageHandler _messageHandler = new MessageHandler();
        IWriteFileController _writeTextFileController = new WriteFileController();

        public LZWTutorialCompressTextController(TextCompressionTutorialLzwForm lzwHelpForm)
        {
            this.lzwHelpForm = lzwHelpForm;
        }

        public void lzwTutorialCompressFile(string fileText)
        {
            
            _writeTextFileController.writeToFileText("simpleMethodText.txt", fileText);
            List<int> compressedCodeWordsList = new List<int>();
            compressedCodeWordsList = lzwTutorialCompressText(fileText);

            string compressedCodeWordsString;
            compressedCodeWordsString = codeWordListToString(compressedCodeWordsList);
            this.lzwHelpForm.CompressedTextRichTextBox.Text = "";
            this.lzwHelpForm.CompressedTextRichTextBox.Text = compressedCodeWordsString;
            _writeTextFileController.writeToFileText("simpleMethodTextCompressed.txt", compressedCodeWordsString);

        }

        public List<int> lzwTutorialCompressText(string fileText)
        {
            DateTime TimeDate1 = DateTime.Now;
            List<LzwFormCompressionItems> _lzwFormItems = new List<LzwFormCompressionItems>();
            List<int> compressed = new List<int>();
            this._LZWDictionaryController.createUncompressedDictionary();
            Dictionary<string, int> compressedLZWDictionary = this._LZWDictionaryController.uncompressedLZWDictionary.getCompressedStringIntPairDictionary();

            string previousChar = null;
            string currentChar = null;
            string checkDictionaryChar = null;
            string dictionaryAddedPair = null;
            Boolean checkDictionary = false;
            int dictionaryCount = compressedLZWDictionary.Count - 1;
            int loopCounter = 1;
            foreach (char c in fileText)
            {
                currentChar = c.ToString();
                checkDictionaryChar = previousChar + currentChar;
                checkDictionary = checkCharExistanceInCompressedDictionary(checkDictionaryChar, compressedLZWDictionary);
                if (checkDictionary.Equals(true))
                {
                     previousChar = previousChar + currentChar;

                     _lzwFormItems.Add(new LzwFormCompressionItems(loopCounter, currentChar, previousChar, checkDictionaryChar, checkDictionary, " - ", previousChar + currentChar, " - "));
                }
                else
                {
                    compressed.Add(compressedLZWDictionary[previousChar]);
                    dictionaryCount = dictionaryCount + 1;
                    compressedLZWDictionary.Add(checkDictionaryChar, dictionaryCount);
                    dictionaryAddedPair = "key:" + checkDictionaryChar + " value:" + dictionaryCount;
                    _lzwFormItems.Add(new LzwFormCompressionItems(loopCounter, currentChar, previousChar, checkDictionaryChar, checkDictionary, dictionaryAddedPair, currentChar, compressedLZWDictionary[previousChar].ToString()));
                    previousChar = currentChar;
                }

                loopCounter = loopCounter + 1;
            }

            try
            {
                _lzwFormItems.Add(new LzwFormCompressionItems(loopCounter, " - ", previousChar, " - ", false, " - ", " - ", compressedLZWDictionary[previousChar].ToString()));
                compressed.Add(compressedLZWDictionary[previousChar]);
            }
            catch (ArgumentNullException ex)
            {
                _messageHandler.youMustTypeTextToCompressMessage();
                Console.WriteLine(ex);
            }

            DateTime TimeDate2 = DateTime.Now;

            fillHelpCompressFormTable(_lzwFormItems);
            return compressed;
        }

        public void fillHelpCompressFormTable(List<LzwFormCompressionItems> _lzwFormItems)
        {
            this.lzwHelpForm.lzwCompressionDetailDataGridView.Rows.Clear();
            foreach(var newGridRowItems in _lzwFormItems)
            {
                this.lzwHelpForm.lzwCompressionDetailDataGridView.Rows.Add(newGridRowItems.LoopCounter, newGridRowItems.CurrentChar, newGridRowItems.PreviousChar, newGridRowItems.CurrAndPrevChar,
                                                                newGridRowItems.InDictionary, newGridRowItems.AddedToDictionary, newGridRowItems.NewPreviousChar, newGridRowItems.Output);

            }
            
        }

     
        public string codeWordListToString(List<int> codeWordsList)
        {
            StringBuilder codeWordsString = new StringBuilder();

            foreach (var codeWord in codeWordsList)
            {
                codeWordsString.Append(" " + codeWord.ToString());
            }

            return codeWordsString.ToString();
        }

        public Boolean checkCharExistanceInCompressedDictionary(string checkDictionaryChar, Dictionary<string, int> uncompressedDictionary)
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
