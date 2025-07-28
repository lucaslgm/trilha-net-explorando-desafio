using System.Data;

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
            if (Suite != null && hospedes.Count > Suite.Capacidade)
                throw new DataException($"A capacidade da suíte ({Suite.Capacidade}) é menor que a quantidade de hóspedes ({hospedes.Count}).");

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
             return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("A suíte ainda não foi definida para calcular o valor.");

            decimal valorTotal = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
                valorTotal *= 0.9m;

            return valorTotal;
        }
    }
}