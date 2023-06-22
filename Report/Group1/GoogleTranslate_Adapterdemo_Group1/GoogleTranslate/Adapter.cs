using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslate
{
    internal class Adapter
    {
        Core core = new Core();
        public List<string> DichNgonNgu(List<string> danhSach)
        {
            List<string> newList = new List<string>();
            foreach (string item in danhSach)
            {
                newList.Add(core.TranslateText(item));
            }
            return newList;
        }
    }
}
