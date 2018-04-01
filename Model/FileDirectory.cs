using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


class FileDirectory
{
    private OpenFileDialog fileDialogInstance = null;

    public FileDirectory(OpenFileDialog fileDialogInstance)
    {
        this.fileDialogInstance = fileDialogInstance;
    }

    public OpenFileDialog getFileDialogInstance()
    {
        return fileDialogInstance;
    }

    public void setFileDialogInstance(OpenFileDialog fileDialogInstance)
    {
        this.fileDialogInstance = fileDialogInstance;
    }

   
    public FileDirectory()
    {

    }
}

