using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroseForlder
{
    public class BroseForlderService
    {
        public static Dictionary<string,string> dirlist = new Dictionary<string,string>();

        public static Dictionary<string,string> Dirlist(DirectoryInfo dir)
        {
            try
            {
                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    dirlist.Add(item.Name,item.FullName);
                }
                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    Dirlist(item);
                }
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            return dirlist;
        }
    }
}
