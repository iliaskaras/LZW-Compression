using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IFileOperationsController
{

    Boolean selectFileDirectory();
    string getSelectedFileDirectorySize();
    string getSelectedFileDirectoryPath();
    string getSelectedFileDirectoryName();
    string getFileByteSize(string filePath);
    Boolean checkDirectoryExistance();
}

