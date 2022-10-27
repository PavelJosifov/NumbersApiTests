

using Newtonsoft.Json;
using NumbersApiGenerator;

var client = new HttpClient();
Console.Write("Enter a number: ");
var number = int.Parse(Console.ReadLine());
var model = new NumberData(number);
for (int i = 0; i < 30; i++) 
{
    var response = await client.GetStringAsync($"http://numbersapi.com/{number}");
    model.Messages.Add(response);
    Console.WriteLine("+");
}
model.Messages = model.Messages.Distinct().ToList();
var json = JsonConvert.SerializeObject(model,Formatting.Indented);
File.WriteAllText($"D:\\repos\\NumbersApiTesting\\NumbersApiTests\\TestProject1\\Messages\\number_{number}.json",json);
