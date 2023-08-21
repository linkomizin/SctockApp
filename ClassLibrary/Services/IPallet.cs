using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary.Services
{
    public interface IPallet
    {
        bool AddBox(Box box);
        void RemoveBox(Box box);
        double GetTotalScale();
        double GetTotalVolume();
        DateOnly GetExpirationDatePallet();
       
    }
}
