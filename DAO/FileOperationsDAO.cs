using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


class FileOperationsDAO : IFileOperationsDAO
{

    public OpenFileDialog selectDirectory()
    {
        OpenFileDialog _openFileDialog = new OpenFileDialog();

        try
        {
            _openFileDialog.ShowDialog();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to select Directory with exception : {0}" ,ex);
            _openFileDialog = null;
            return _openFileDialog;
        }

        return _openFileDialog;
    }

    public string getSelectedDirectoryName(OpenFileDialog _fileDirectory)
    {
        string selectedDirectoryName = null;

        try
        {
            selectedDirectoryName = _fileDirectory.SafeFileName;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to get the file's name with exception : {0}", ex);
            return null;
        }
      

        return selectedDirectoryName;
    }

    public string getSelectedDirectoryPath(OpenFileDialog _fileDirectory)
    {
        string selectedDirectoryPath = null;

        try
        {
            selectedDirectoryPath = _fileDirectory.FileName;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to get the file's path with exception : {0}", ex);
            return null;
        }

        return selectedDirectoryPath;
    }

    


}

