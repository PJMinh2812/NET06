namespace bai_tap_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI TẬP COLLECTION ===\n");

            // Bài tập 1
            Console.WriteLine("--- Bài tập 1: Tính tổng các số trong mảng ---");
            int[] lstNumber1 = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
            int sum = BaiTap1_TinhTong(lstNumber1);
            Console.WriteLine($"Tổng các số trong mảng: {sum}\n");

            // Bài tập 2
            Console.WriteLine("--- Bài tập 2: Tìm hai số có tổng bằng target ---");
            int[] lst_number2 = { 2, 7, 11, 15 };
            int target = 9;
            int[] result2 = BaiTap2_TwoSum(lst_number2, target);
            if (result2.Length > 0)
            {
                Console.WriteLine($"Target: {target}");
                Console.WriteLine($"Kết quả: [{result2[0]}, {result2[1]}]");
                Console.WriteLine($"Vì nums[{result2[0]}] + nums[{result2[1]}] = {lst_number2[result2[0]]} + {lst_number2[result2[1]]} = {target}\n");
            }
            else
            {
                Console.WriteLine("Không tìm thấy\n");
            }

            // Bài tập 3
            Console.WriteLine("--- Bài tập 3: Loại bỏ phần tử trùng lặp ---");
            int[] lstNumber3 = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
            int newLength = BaiTap3_RemoveDuplicates(lstNumber3);
            Console.WriteLine("Mảng ban đầu: [1, 1, 2, 2, 2, 3, 4, 4, 5]");
            Console.Write($"Độ dài mảng mới: {newLength}");
            Console.Write("\nMảng sau khi loại bỏ: [");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(lstNumber3[i]);
                if (i < newLength - 1) Console.Write(", ");
            }
            Console.WriteLine("]\n");

            // Bài tập 4
            Console.WriteLine("--- Bài tập 4: Tìm k phần tử xuất hiện nhiều nhất ---");
            int[] lstNumber4 = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            int[] result4 = BaiTap4_TopKFrequent(lstNumber4, k);
            Console.Write($"{k} phần tử xuất hiện nhiều nhất: [");
            for (int i = 0; i < result4.Length; i++)
            {
                Console.Write(result4[i]);
                if (i < result4.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]\n");

            // Bài tập 5
            Console.WriteLine("--- Bài tập 5: Lợi nhuận tối đa khi mua bán cổ phiếu ---");
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int maxProfit = BaiTap5_MaxProfit(prices);
            Console.WriteLine($"Lợi nhuận tối đa: {maxProfit}");
        }

        // Bài tập 1: Tính tổng các số trong mảng
        static int BaiTap1_TinhTong(int[] lstNumber)
        {
            int sum = 0;
            foreach (int num in lstNumber)
            {
                sum += num;
            }
            return sum;
        }

        // Bài tập 2: Tìm hai số có tổng bằng target
        static int[] BaiTap2_TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            
            return new int[] { }; 
        }

        // Bài tập 3: Loại bỏ phần tử trùng lặp từ mảng đã sắp xếp
        static int BaiTap3_RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int k = 1; 

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }

        // Bài tập 4: Tìm k phần tử xuất hiện nhiều nhất
        static int[] BaiTap4_TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            
            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            var sortedByFrequency = frequencyMap.OrderByDescending(x => x.Value)
                                                .Take(k)
                                                .Select(x => x.Key)
                                                .ToArray();

            return sortedByFrequency;
        }

        // Bài tập 5: Tìm lợi nhuận tối đa khi mua bán cổ phiếu
        static int BaiTap5_MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int minPrice = prices[0]; 
            int maxProfit = 0;       

            for (int i = 1; i < prices.Length; i++)
            {
                int profit = prices[i] - minPrice;
                
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }

                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
            }

            return maxProfit;
        }
    }
}
