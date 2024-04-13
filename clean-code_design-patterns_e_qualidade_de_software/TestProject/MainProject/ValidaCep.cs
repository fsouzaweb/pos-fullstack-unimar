namespace TestProject.MainProject
{
    public class ValidaCep : Begin
    {
        [Test]
        public void ValidaCepTest()
        {
            EscreveTexto("//*[@id='endereco']", "17526430");
            ClicaElemento("//*[text()='Buscar']");
            ValidaDados("//*[@id=\"resultado-DNEC\"]/tbody/tr/td[1]", "Rua Maria Giraldi Cavallari");
        }
    }
}
