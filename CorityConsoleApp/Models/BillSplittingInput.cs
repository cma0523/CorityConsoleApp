using System;
using System.Collections.Generic;
using System.Text;

namespace CorityConsoleApp.Models
{
    public class BillSplittingInput
    {
        public BillSplittingInput(int numbers)
        {
            NumberOfParticipants = numbers;
            BillDetails = new decimal[numbers];
        }

        public int NumberOfParticipants { get; set; }
        public decimal[] BillDetails { get; set; }

    }
}
