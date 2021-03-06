using System.Collections.Generic;
using System.IO;
namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            //POr padrao só busca pastas raiz. Então adicionamos " , "*", SearchOption.AllDirectories"

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)

        {
                var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
                    // Pode escccolher só arquivo txt colocando *.txt logo acima
                foreach (var retorno in retornoArquivos)
                {
                    System.Console.WriteLine(retorno);
                }

        }

        public void CriarDiretorio(string caminho)
        { 
           var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);

        }
        public void ApagarDiretorio(string caminho, Boolean apagarArquivos)
        {

            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho)) //PAra impedir de criar um arquivo já existente
            {
            File.WriteAllText(caminho, conteudo);
            //Trabalahr com stream para não sobrecarregar a memoria do sistema
            }

        }

        public void CriarAqruivoTextStream(string caminho, List<string> conteudo)
        {
            
            using (var stream = File.CreateText(caminho))
            foreach (var linha in conteudo)
            {
                stream.WriteLine(linha);
            }

        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText (caminho, conteudo);
        }

    public void AdicionarTextStream(string caminho, List<string> conteudo)
        {
            
            using (var stream = File.AppendText(caminho))
            foreach (var linha in conteudo)
            {
                stream.WriteLine(linha);
            }

        }

        public void LerArquivo(string caminho)
        {
        var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
        string linha = string.Empty;

        using (var stream = File.OpenText(caminho))
        {
            while ((linha = stream.ReadLine()) != null)
            {
                System.Console.WriteLine(linha);
            }
        }
        }
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

         public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}