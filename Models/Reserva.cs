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
            // Complete: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            bool capacidadeDeHospedesPorSuite = Suite.Capacidade >= hospedes.Count() ? true : false;

            if (true)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Complete: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Capacidade menor menor que o número de hóspedes permitidos");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Completed: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // Complete: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valorTotal = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            valorTotal = DiasReservados >= 10 ? DiasReservados * Suite.ValorDiaria * 1 - (10/100) : DiasReservados * Suite.ValorDiaria;

            return valorTotal;
        }
    }
}