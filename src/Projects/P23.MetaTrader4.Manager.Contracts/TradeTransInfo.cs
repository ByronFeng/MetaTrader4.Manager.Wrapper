using System;

namespace P23.MetaTrader4.Manager.Contracts
{
    public enum TradeTransactionType : byte
    {
        TT_PRICES_GET,                      // prices requets
        TT_PRICES_REQUOTE,                  // requote
                                            //--- client trade transaction
        TT_ORDER_IE_OPEN = 64,                // open order (Instant Execution)
        TT_ORDER_REQ_OPEN,                  // open order (Request Execution)
        TT_ORDER_MK_OPEN,                   // open order (Market Execution)
        TT_ORDER_PENDING_OPEN,              // open pending order
                                            //---
        TT_ORDER_IE_CLOSE,                  // close order (Instant Execution)
        TT_ORDER_REQ_CLOSE,                 // close order (Request Execution)
        TT_ORDER_MK_CLOSE,                  // close order (Market Execution)
                                            //---
        TT_ORDER_MODIFY,                    // modify pending order
        TT_ORDER_DELETE,                    // delete pending order
        TT_ORDER_CLOSE_BY,                  // close order by order
        TT_ORDER_CLOSE_ALL,                 // close all orders by symbol
                                            //--- broker trade transactions
        TT_BR_ORDER_OPEN,                   // open order
        TT_BR_ORDER_CLOSE,                  // close order
        TT_BR_ORDER_DELETE,                 // delete order (ANY OPEN ORDER!!!)
        TT_BR_ORDER_CLOSE_BY,               // close order by order
        TT_BR_ORDER_CLOSE_ALL,              // close all orders by symbol
        TT_BR_ORDER_MODIFY,                 // modify open price, stoploss, takeprofit etc. of order
        TT_BR_ORDER_ACTIVATE,               // activate pending order
        TT_BR_ORDER_COMMENT,                // modify comment of order
        TT_BR_BALANCE                       // balance/credit
    };

    //--- trade commands
    public enum TradeCommand : short
    {
        OP_BUY = 0,
        OP_SELL,
        OP_BUY_LIMIT,
        OP_SELL_LIMIT,
        OP_BUY_STOP,
        OP_SELL_STOP,
        OP_BALANCE,
        OP_CREDIT
    };

    public class TradeTransInfo
    {
        public TradeTransactionType Type { get; set; } // trade transaction type
        public TradeCommand Cmd { get; set; }   // trade command
        public int Order { get; set; }          // order
        public int OrderBy { get; set; }        // order by
        public string Symbol { get; set; }      // trade symbol
        public int Volume { get; set; }         // trade volume
        public double Price { get; set; }       // trade price
        public double Sl { get; set; }          // stoploss
        public double Tp { get; set; }          // takeprofit
        public int IeDeviation { get; set; }    // deviation on IE
        public string Comment { get; set; }     // comment
        public UInt32 Expiration { get; set; }  // pending order expiration time
        public int Crc { get; set; }            // crc
    }
}
