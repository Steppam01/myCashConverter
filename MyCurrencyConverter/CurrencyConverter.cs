using System;


namespace MyCurrencyConverter
{
    public class CurrencyConverter
    {
        
        string input;  // to hold out input
        public CurrencyConverter(string userInput)
        {
            input = userInput;
        }

        // method to calculate the conversion and return the result
        public string ConvertCurrency()
        {
            var output = "";
            if (input.Length < 1)
                output = "Please enter something";
            else
            {
                try
                {
                    // calculate the conversion
                    var result = Convert.ToDouble(input) * 0.85;
                    output = "$" + input + "=$EU" +
                        result;
                }
                catch(Exception ex)
                {
                    output = "Please enter a number!";
                    Console.WriteLine("Error in conversion " + ex.Message);
                }
            }

            return output;
        }
    }
}
