using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReadFileController : IReadFileController
{

    public string getSelectedFileDirectoryText(string filePath)
    {
        IReadFileDAO _readTextFileDAO = new ReadFileDAO();
        string getSelectedFileDirectoryText = null;

        getSelectedFileDirectoryText = _readTextFileDAO.readFileText(filePath);

        if (getSelectedFileDirectoryText.Equals(null))
            return null;
        else
            return getSelectedFileDirectoryText;

    }

    public byte[] getSelectedFileDirectoryBytes(string filePath)
    {
        IReadFileDAO _readTextFileDAO = new ReadFileDAO();
        byte[] getSelectedFileDirectoryBytes = null;

        getSelectedFileDirectoryBytes = _readTextFileDAO.readFileBytes(filePath);

        if (getSelectedFileDirectoryBytes.Equals(null))
            return null;
        else
            return getSelectedFileDirectoryBytes;

    }
}

