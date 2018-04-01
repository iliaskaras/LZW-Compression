using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LzwFormDecompressionItems
{
    public LzwFormDecompressionItems(string decompressionDetails,int loopCounter, string currentCodeWord, string currentCodeWordString, string previousCodeWord, string previousCodeWordString, Boolean inDictionary, string currKeptString, string prevKeptString, string output, string currAndPrevString, string addedToDictionary)
    {
        this.decompressionDetails = decompressionDetails;
        this.loopCounter = loopCounter;
        this.currentCodeWord = currentCodeWord;
        this.currentCodeWordString = currentCodeWordString;
        this.previousCodeWord = previousCodeWord;
        this.previousCodeWordString = previousCodeWordString;
        this.inDictionary = inDictionary;
        this.currKeptString = currKeptString;
        this.prevKeptString = prevKeptString;
        this.output = output;
        this.currAndPrevChar = currAndPrevString;
        this.addedToDictionary = addedToDictionary;

    }

    string decompressionDetails;

    public string DecompressionDetails
    {
        get { return decompressionDetails; }
        set { decompressionDetails = value; }
    }
    int loopCounter;

    public int LoopCounter
    {
        get { return loopCounter; }
        set { loopCounter = value; }
    }
    string currentCodeWord;

    public string CurrentCodeWord
    {
        get { return currentCodeWord; }
        set { currentCodeWord = value; }
    }
    string currentCodeWordString;

    public string CurrentCodeWordString
    {
        get { return currentCodeWordString; }
        set { currentCodeWordString = value; }
    }
    string previousCodeWord;

    public string PreviousCodeWord
    {
        get { return previousCodeWord; }
        set { previousCodeWord = value; }
    }
    string previousCodeWordString;

    public string PreviousCodeWordString
    {
        get { return previousCodeWordString; }
        set { previousCodeWordString = value; }
    }
    Boolean inDictionary;

    public Boolean InDictionary
    {
        get { return inDictionary; }
        set { inDictionary = value; }
    }
    string currKeptString;

    public string CurrKeptString
    {
        get { return currKeptString; }
        set { currKeptString = value; }
    }
    string prevKeptString;

    public string PrevKeptString
    {
        get { return prevKeptString; }
        set { prevKeptString = value; }
    }
    string output;

    public string Output
    {
        get { return output; }
        set { output = value; }
    }
    string currAndPrevChar;

    public string CurrAndPrevChar
    {
        get { return currAndPrevChar; }
        set { currAndPrevChar = value; }
    }
    string addedToDictionary;

    public string AddedToDictionary
    {
        get { return addedToDictionary; }
        set { addedToDictionary = value; }
    }


}

