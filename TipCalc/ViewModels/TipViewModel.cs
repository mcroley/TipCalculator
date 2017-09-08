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

        public override void Start()
        {
            base.Start();
        }             

        int _generosity;
        public int Generosity
        {
            get
            {
                return _generosity;
            }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }

        double _tip;
        public double Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        double _subtotal;
        public double SubTotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                _subtotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();                
            }
        }

        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }


    }


 }

