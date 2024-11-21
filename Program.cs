using System.Security.Authentication.ExtendedProtection;

public class NumbersFact
{
    static async Task Main()
    {
        Console.WriteLine(">> This program gives you a random fact about any day of the year. ");

        Console.Write("Enter the number of month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of day: ");
        int day = int.Parse(Console.ReadLine());

        // Write code below this line
        try
        {
            string url = $"http://numbersapi.com/{month}/{day}/date";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Fact: " + responseContent);
            }
            else
            {
                Console.WriteLine($"API request failed: {response.StatusCode}");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
        // Write code above this line
    }
} 