using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2
{
    public class Tests
    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}