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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTADO*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTADO*
                try
                {
                    bool Validacao = Suite.Capacidade >= Hospedes.Count;
                }catch(Exception ex)
                {
                    Console.WriteLine($"O número de hospedes é maior que a capacidade {ex}");
                }

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int? ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTADO*
            try
            {
                return Hospedes.Count;
            }catch
            {
                Console.WriteLine("Não foi possível informar a quantidade de hospedes");
                return null;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTADO*
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}