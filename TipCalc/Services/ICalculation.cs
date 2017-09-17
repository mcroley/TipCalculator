using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalc.Core.Services
{
    public interface ICalculation  // ioc interface 
    {
        double TipAmount(double subTotal, int generosity); 
    }
}
