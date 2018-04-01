using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WriteFileController : IWriteFileController
{

    public void writeToFileText(string filePath,string fileText)
    {
        IWriteFileDAO _writeTextFileDAO = new WriteFileDAO();

        if (filePath.Equals("simpleMethodText.txt"))
        {
            _writeTextFileDAO.writeToFileText("simpleMethodText.txt", fileText);
        }
        else
        {
            _writeTextFileDAO.writeToFileText(filePath, fileText);
        }
    }

    public void writeToFileBytes(string filePath , byte[] bytes)
    {
        IWriteFileDAO _writeTextFileDAO = new WriteFileDAO();
        _writeTextFileDAO.writeToFileBytes(filePath, bytes);
    }

}

