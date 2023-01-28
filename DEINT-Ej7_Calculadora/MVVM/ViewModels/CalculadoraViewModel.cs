using Dangl.Calculator;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DEINT_Ej7_Calculadora.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculadoraViewModel
    {
        public string Operation { get; set; }
        public string Result { get; set; }
        public ICommand CommandReset { get; set; }
        public ICommand CommandBackSpace { get; set; }
        public ICommand CommandOperation { get; set; }
        public ICommand CommandCalculate { get; set; }
        
        public CalculadoraViewModel()
        {
            Operation = "";
            Result = "0";
            CommandReset = new Command(() => { Operation = "0"; });
            CommandBackSpace = new Command(() => {
                if (Operation.Length > 1)
                {
                    Operation = Operation.Substring(0, Operation.Length - 1);
                }
            });
            CommandOperation = new Command((op) => { Operation += op; });
            CommandCalculate = new Command(() => {
                Result = Calculator.Calculate(Operation).Result.ToString();
            });
        }

    }
}
