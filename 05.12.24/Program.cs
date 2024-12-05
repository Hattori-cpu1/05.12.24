namespace _05._12._24
{
    internal class Program
    {
        public class NumberFunctions
        {
            // 1.
            public static int CountBits(int num)
            {
                int count = 0;
                string binary = Convert.ToString(num, 2);
                foreach (char c in binary)
                {
                    if (c == '1') count++;
                }
                return count;
            }

            // 2. 
            public static int Persistence(int num)
            {
                if (num < 10) return 0;
                int count = 0;
                while (num >= 10)
                {
                    int product = 1;
                    string s = num.ToString();
                    foreach (char c in s)
                    {
                        product *= (c - '0');
                    }
                    num = product;
                    count++;
                }
                return count;
            }

            // 3. 
            public static int DigitalRoot(int num)
            {
                while (num >= 10)
                {
                    int sum = 0;
                    string s = num.ToString();
                    foreach (char c in s)
                    {
                        sum += (c - '0');
                    }
                    num = sum;
                }
                return num;
            }


            static void Main(string[] args)
            {
                Console.WriteLine("CountBits(4): " + CountBits(4));      
                Console.WriteLine("CountBits(10): " + CountBits(10));    
                Console.WriteLine("CountBits(1): " + CountBits(1));      
                Console.WriteLine("CountBits(32): " + CountBits(32));    

                Console.WriteLine("Persistence(39): " + Persistence(39));  
                Console.WriteLine("Persistence(9): " + Persistence(9));    
                Console.WriteLine("Persistence(999): " + Persistence(999));

                Console.WriteLine("DigitalRoot(16): " + DigitalRoot(16));  
                Console.WriteLine("DigitalRoot(942): " + DigitalRoot(942)); 
            }
        }
    }
}
