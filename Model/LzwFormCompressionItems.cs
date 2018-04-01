using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LzwFormCompressionItems
{
    public LzwFormCompressionItems(int loopCounter, string currentChar, string previousChar, string currAndPrevChar, Boolean inDictionary, string addedToDictionary, string newPreviousChar, string output)
    {
        this.loopCounter = loopCounter;
        this.currentChar = currentChar;
        this.previousChar = previousChar;
        this.currAndPrevChar = currAndPrevChar;
        this.inDictionary = inDictionary;
        this.addedToDictionary = addedToDictionary;
        this.newPreviousChar = newPreviousChar;
        this.output = output;
    }

    int loopCounter;

    public int LoopCounter
    {
        get { return loopCounter; }
        set { loopCounter = value; }
    }

    string currentChar = null;

    public string CurrentChar
    {
        get { return currentChar; }
        set { currentChar = value; }
    }
    string previousChar = null;

    public string PreviousChar
    {
        get { return previousChar; }
        set { previousChar = value; }
    }
    string currAndPrevChar = null;

    public string CurrAndPrevChar
    {
        get { return currAndPrevChar; }
        set { currAndPrevChar = value; }
    }
    Boolean inDictionary = false;

    public Boolean InDictionary
    {
        get { return inDictionary; }
        set { inDictionary = value; }
    }
    string addedToDictionary = null;

    public string AddedToDictionary
    {
        get { return addedToDictionary; }
        set { addedToDictionary = value; }
    }
    string newPreviousChar = null;

    public string NewPreviousChar
    {
        get { return newPreviousChar; }
        set { newPreviousChar = value; }
    }
    string output = null;

    public string Output
    {
        get { return output; }
        set { output = value; }
    }


  
}

