// This file was auto-generated by ML.NET Model Builder. 

using System;
using MvcExampleML.Model;

namespace MvcExampleML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Number = 0F,
                Date = 43878F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Production with predicted Production from sample data...\n\n");
            Console.WriteLine($"Number: {sampleData.Number}");
            Console.WriteLine($"Date: {sampleData.Date}");
            Console.WriteLine($"\n\nPredicted Production: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
