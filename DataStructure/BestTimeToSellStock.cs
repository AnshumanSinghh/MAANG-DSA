using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BestTimeToSellStock
    {
        public int FindMaxProfit(List<int> prices)
        {
            var min = prices[0];
            int max = 0;
            foreach (var num in prices)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num - min > max)
                {
                    max = num - min;
                }
            }
            return max;
        }


        public string FindBestDayToBuyAndSellStockForMaxProfit(List<int> prices)
        {
            var min = prices[0];
            int max = 0;
            int buyDay = 0;
            int sellDay = 0;
            for(int i = 0; i < prices.Count; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    buyDay = i + 1;  // since Day will index + 1.
                }
                if (prices[i] - min > max)
                {
                    max = prices[i] - min;
                    sellDay = i + 1;  // since Day will index + 1.
                }
            }
            return $"Buying on Day {buyDay} and Selling it on Day {sellDay} will have max profit of {max}";
        }
    }
}
