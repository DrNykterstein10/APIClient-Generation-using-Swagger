using System;

namespace EMICalculatorAPIClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new EMICalculatorClient();
            var emiDetails = await client.GetEMIDetailsAsync(10000, 24, 14);

            
                    
        }
    }
}
