using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmTestWinfoms
{
   
    public class TempList
    {
        public void AddSe()
        {
            SE tempse = new SE();
            tempse.ID = "Y32";
            tempse.Name = "Y";
            tempse.Age = 22;
            tempse.Gerder = "女";
            FrmMain main = new FrmMain();
            main.selist.Add(tempse);
            main.BindGird(main.selist);
        }

    }
}
