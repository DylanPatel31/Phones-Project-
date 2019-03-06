
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList;

        public List<clsStock> StockList
        {

            get
            {
                return mStockList;
            }


            set
            {
                //
            }
                
         }
        public int Count { get; set; }
        public clsStock ThisStock { get; set; }
    }
}