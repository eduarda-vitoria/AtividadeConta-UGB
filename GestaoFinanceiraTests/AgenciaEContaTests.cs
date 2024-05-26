using GestaoFinanceira;

namespace GestaoFinanceiraTests
{
    [TestClass]
    public class AgenciaEContaTests
    {
        [TestMethod]
        public void TestAgenciaSemNumero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Agencia(0));
        }

        [TestMethod]
        public void TestCriarAgenciaComNumero()
        {
            var agencia = new Agencia(1234, "Agência Centro", "1234-5678");
            Assert.AreEqual(1234, agencia.Numero);
            Assert.AreEqual("Agência Centro", agencia.Nome);
            Assert.AreEqual("1234-5678", agencia.Telefone);
        }

        [TestMethod]
        public void TestContaSemAgencia()
        {
            Assert.ThrowsException<ArgumentException>(() => new Conta(null, 12345));
        }

        [TestMethod]
        public void TestContaComAgencia()
        {
            var agencia = new Agencia(1234, "Agência Centro", "1234-5678");
            var conta = new Conta(agencia, 12345);
            Assert.AreEqual(agencia, conta.Agencia);
            Assert.AreEqual(12345, conta.NumeroConta);
        }
    }
}
