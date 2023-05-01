namespace SistemaHotel.Models
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
            //verifica se capacidade é maior ou igual ao numero de hospedes recebidos
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {               
            //Retorna Exception caso capacidade seja menor que o numero de hospedes recebidos
            System.Console.WriteLine($"Não foi possível realizar a reserva pois a capacidade é menor que a quantidade de hóspedes!");
            }
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
            decimal valor = 0;
            decimal valorFinal = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10)
            {
                decimal valorDesconto = 0.9M;
                valorFinal = valor * valorDesconto;
            }
            return valorFinal;
        }
    }
}