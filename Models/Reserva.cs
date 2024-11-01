using System.Linq.Expressions;

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
            
            try
            { 
                if (hospedes.Count<= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
           
             else
             {
                throw new Exception("o numero de hospedes excede a capacidade da suite");
             }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            Console.WriteLine($"a quantidade de hospedes é {Hospedes.Count}");
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor =  DiasReservados*Suite.ValorDiaria;
           

            if (DiasReservados>=10)
            {
               valor=valor-(valor * 10/100);
               Console.WriteLine($"seu desconto é 10%");
                
            }

            return valor;
        }
    }
}