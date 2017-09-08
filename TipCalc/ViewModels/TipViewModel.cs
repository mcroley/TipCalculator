using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    class TipViewModel : MvxViewModel
    {

        readonly ICalculation _calculation;

        public TipViewModel(ICalculation calculation)
        {
            calculation = _calculation;
        }

    }
}
