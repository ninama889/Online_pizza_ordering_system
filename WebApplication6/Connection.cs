using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6
{
    class Connection
    {
    }
    public class Utils
    {
        public static bool IsValidExtention (string filename)
        {
            bool isValid = false;
            string[] fileExtention = { ".jpg", ".jpeg", ".png" , ".webp"};
            for (int i = 0; i <= fileExtention.Length -1 ; i++)
            {
                if (filename.Contains(fileExtention[i]))
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;
        }
        public static string GetImageUrl(Object url)
        {
            string url1 = "";
            if (string.IsNullOrEmpty(url.ToString())|| url == DBNull.Value)
            {
                url1 = "../Images/No_Image.png";
            }
            else
            {
                url1 = string.Format("../{0}", url);
            }
            return url1;
        }  
    }
}
