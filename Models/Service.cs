using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentManagement.Models
{
    public class Service
    {
        public List<string> GetFileTypes()
        {
            List<string> fileTypes = new List<string>();

            fileTypes.Add(".pdf");

            fileTypes.Add(".jpeg");
            fileTypes.Add(".jpg");
            fileTypes.Add(".png");

            fileTypes.Add(".docx");
            fileTypes.Add(".docm");
            fileTypes.Add(".dotm");
            fileTypes.Add(".dotx");

            fileTypes.Add(".xlsx");
            fileTypes.Add(".xlsb");
            fileTypes.Add(".xls");
            fileTypes.Add(".xlsm");

            fileTypes.Add(".pptx");
            fileTypes.Add(".ppsx");
            fileTypes.Add(".ppt");
            fileTypes.Add(".pps");
            fileTypes.Add(".pptm");
            fileTypes.Add(".potm");
            fileTypes.Add(".ppam");
            fileTypes.Add(".potx");
            fileTypes.Add(".ppsm");

            return fileTypes;
        }
    }
}
