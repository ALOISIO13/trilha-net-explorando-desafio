namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // *IMPLEMENADO*
            if (Suite,Capacidade >= hospedes.count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO*
                throw new Exception("O número de hóspedes é maior que a capacidade da Suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            // *IMPLEMENTADO *
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;

                // *IMPLEMENTADO *
            if (DiasReservados >= 10)
            {
                valor -= Decimal.Divide(Decimal.Multiply(valor, 10), 100) ;
            }

            return valor;
        }
    }
}