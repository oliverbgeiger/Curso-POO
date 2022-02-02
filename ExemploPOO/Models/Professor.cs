namespace ExemploPOO.Models
{
    //public sealed class Professor : Pessoa

    public class Professor : Pessoa
    {
        public double Salario { get; set; }
                //public sealed override void Apresentar()
                public override void Apresentar()
        {
         Console.WriteLine ($"Olá. Omeu nome é {Nome}, tenho {Idade} anos e o meu salário e {Salario}");
        }
        
    }
}