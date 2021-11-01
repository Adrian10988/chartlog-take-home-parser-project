using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeParserProject.Models
{
    public class ChartlogTradeExecution
    {
        /// <summary>
        /// Price of the trade/execution
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Quantity of shares or quantity of contracts
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// The symbol or ticker of the trade
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// If the report includes this data, it should be populated here
        /// </summary>
        public string OrderId { get; set; }

        public DateTime ExecutionDateAndTime { get; set; }

        /// <summary>
        /// The native account number for the user's brokerage or trading platform
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// The direction or "side" of the execution. EG. did the person buy (long) or sell (short)
        /// </summary>

        public TradeDirection Direction { get; set; }

        /// <summary>
        /// The commission the user was charged for the execution
        /// </summary>
        public decimal Commission { get; set; }
    }
}
