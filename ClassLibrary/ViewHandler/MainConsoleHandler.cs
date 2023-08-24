using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassLibrary.ViewHandler
{
    public class MainConsoleHandler: IViewHandler
    {
        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }

        public void DisplayPallet(IEnumerable<Pallet>pallets)
        {
             pallets.ToList().ForEach(pallet =>  
             {
                 Console.WriteLine(pallet);
                 Console.WriteLine();
             });
        }
    }
}
