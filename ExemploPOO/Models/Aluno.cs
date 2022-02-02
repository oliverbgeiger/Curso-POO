namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
         Console.WriteLine ($"Olá. Omeu nome é {Nome}, tenho {Idade} anos e a minha nota é {Nota}");
        }
        
        
    }
}