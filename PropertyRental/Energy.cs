using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public class Energy
    {
        [Flags]
        public enum EnergyType
        {
            Gas,
            Electric,
            Solar
        }
    }
}
