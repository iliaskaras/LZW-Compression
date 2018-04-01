using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IOpenTextFileDAO
{

    FileStream openFile(string filePath);
}
