using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace ClassLibrary
{
    public interface ICanAddpallet
    {
        bool CanAddPallet(DimensionsBase pallete, DimensionsBase box);
    }
}
