using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


interface IFileOperationsDAO
{
    OpenFileDialog selectDirectory();
    string getSelectedDirectoryName(OpenFileDialog _fileDirectory);
    string getSelectedDirectoryPath(OpenFileDialog _fileDirectory);
}

