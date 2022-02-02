namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}


//Classe Professor foi selada com "sealed". O mesmo pode ser feito para o método apresentar. Ver que professor fica com risco vermelho