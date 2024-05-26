namespace GestaoFinanceira 
{
    public class Agencia
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }

        public Agencia(int numero, string nome = null, string telefone = null)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("Número da agência é obrigatório e deve ser positivo.");
            }

            Numero = numero;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
