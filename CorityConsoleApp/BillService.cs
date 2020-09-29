using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CorityConsoleApp.Models;

namespace CorityConsoleApp
{
    public class BillService
    {
        public IEnumerable<decimal[]> SplitBills(List<decimal> inputs)
        {
            int index = 0;
            var totalResult = new List<decimal[]>();

            while (index < inputs.Count - 1)
            {
                var participantsNumber = (int)inputs[index];
                var result = new decimal[participantsNumber];
                
                var model = new BillSplittingInput(participantsNumber);
                index += 2;
                for (int i = 0; i < participantsNumber; i++)
                {
                    model.BillDetails[i] = inputs.Skip(index).Take((int)   inputs[index - 1]).Sum();
                    index += (int) inputs[index - 1] + 1;
                }
                //reset index
                index -= 1;
                var averageExpense = model.BillDetails.Sum() / participantsNumber;

                for (int i = 0; i < participantsNumber; i++)
                {
                    result[i] = averageExpense - model.BillDetails[i];
                }
                totalResult.Add(result);
            }

            return totalResult;
        }
    }
}
