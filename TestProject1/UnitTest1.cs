using Newtonsoft.Json;
using NumbersApiGenerator;

namespace TestProject1
{
    public class Tests
    {
        private HttpClient client;
        [SetUp]
        public void Setup()
        {
            this.client = new HttpClient();
        }

        [Test]
        [TestCase(22)]
        [TestCase(5)] 
        [TestCase(7)] 
        [TestCase(69)] 
        public async Task Test1Async(int number)
        {
            var response = await client.GetStringAsync($"http://numbersapi.com/{number}");
            var jsonstring = File.ReadAllText($"D:\\repos\\NumbersApiTesting\\NumbersApiTests\\TestProject1\\Messages\\number_{number}.json");
            var model = JsonConvert.DeserializeObject<NumberData>(jsonstring);
            Assert.That(model.Messages.Contains(response));
        }
    }
}