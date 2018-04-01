using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class FileOperationsController : IFileOperationsController

{
    FileDirectory fileDirectory = new FileDirectory();
    IMessageHandler messageHandler = new MessageHandler();
    IReadFileDAO readTextFileDAO = new ReadFileDAO();

    public Boolean selectFileDirectory()
    {
        
        IFileOperationsDAO _selectFileOperationsDAO = new FileOperationsDAO();
        OpenFileDialog selectFileDirectory = new OpenFileDialog();
        Boolean selectFileDirectoryResult = false;

        selectFileDirectory = _selectFileOperationsDAO.selectDirectory();
        this.fileDirectory = new FileDirectory(selectFileDirectory);

        if (checkDirectoryExistance().Equals(false))
        {
            this.messageHandler.youHaventChoosedFileMessage();
            return false;
        }
           
        
        if (fileDirectory.getFileDialogInstance().Equals(null))
        {
            selectFileDirectoryResult = false;
        }
        else
        {
            selectFileDirectoryResult = true;
        }

        return selectFileDirectoryResult;
    }

    public string getSelectedFileDirectoryName()
    {
        IFileOperationsDAO _selectFileOperationsDAO = new FileOperationsDAO();
        string getSelectedFileDirectoryName = null;

        getSelectedFileDirectoryName = _selectFileOperationsDAO.getSelectedDirectoryName(this.fileDirectory.getFileDialogInstance());

        if (getSelectedFileDirectoryName.Equals(null))
            return null;
        else
            return getSelectedFileDirectoryName;

    }

    public string getSelectedFileDirectoryPath()
    {
        IFileOperationsDAO _selectFileOperationsDAO = new FileOperationsDAO();
        string getSelectedFileDirectoryPath = null;

        getSelectedFileDirectoryPath = _selectFileOperationsDAO.getSelectedDirectoryPath(this.fileDirectory.getFileDialogInstance());

        if (getSelectedFileDirectoryPath.Equals(null))
            return null;
        else
            return getSelectedFileDirectoryPath;
    }

    public string getSelectedFileDirectorySize()
    {
        IFileOperationsDAO _selectFileOperationsDAO = new FileOperationsDAO();
        IReadFileDAO _readTextFileDAO = new ReadFileDAO();
        string selectedDirectorySize = null;
        string selectedDirectoryText = null;

        try
        {
            selectedDirectoryText = _readTextFileDAO.readFileText(_selectFileOperationsDAO.getSelectedDirectoryPath(this.fileDirectory.getFileDialogInstance()));
            selectedDirectorySize = selectedDirectoryText.Length.ToString();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to get the file's path with exception : {0}", ex);
            return null;
        }

        return selectedDirectorySize;
    
    }

    public int getStringLength(string givenString)
    {

        int stringLengthToInt;
        stringLengthToInt = givenString.Length;

        return stringLengthToInt;
    }

    public Boolean checkDirectoryExistance()
    {
        string checkDirectoryExistanceResult = "";

        checkDirectoryExistanceResult = getSelectedFileDirectoryName();

        if (checkDirectoryExistanceResult.Equals(""))
            return false;
        else
            return true;
    }

    public string getFileByteSize(string filePath)
    {
        string fileByteSize = null;
        try
        {
            fileByteSize = readTextFileDAO.readFileText(filePath).Length.ToString();
        }
        catch (Exception ex)
        {
            Console.WriteLine("getFileByteSize exception : {0}",ex);
        }

        return fileByteSize;
    }
}

