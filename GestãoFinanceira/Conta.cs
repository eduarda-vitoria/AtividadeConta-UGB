namespace GestaoFinanceira
{
    public class Conta
    {
        public Agencia Agencia { get; private set; }
        public int NumeroConta { get; private set; }

        public Conta(Agencia agencia, int numeroConta)
        {
            if (agencia == null)
            {
                throw new ArgumentException("A conta deve pertencer a uma agência válida.");
            }

            Agencia = agencia;
            NumeroConta = numeroConta;
        }
    }
}
