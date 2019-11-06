using System;
using System.Collections.Generic;
using System.Text;

namespace ReadTime.Library
{
    public interface IReadFile
    {
        string ProcessFilePath(string path);
        string ReadPdfFile(string path);
        string ReadTxtFile(string path);
    }
}
