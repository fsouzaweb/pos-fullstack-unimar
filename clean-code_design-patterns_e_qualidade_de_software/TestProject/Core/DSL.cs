namespace TestProject.Core
{
    public class DSL : GlobalVariables
    {
        public void EscreveTexto(string xpath, string text)
        {
            try
            {
                driver.FindElement(By.XPath(xpath)).SendKeys(text);
            }
            catch
            {
                Assert.Fail();
            }
        }
        public void ClicaElemento(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value));
        }
    }
}
