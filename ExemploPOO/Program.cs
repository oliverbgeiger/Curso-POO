using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO

{
    class Program
    {

        static void Main(string [] args)
        {

            // Manipulando arquivos
            var caminho = "C:\\Users\\olive\\Downloads";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste3", "SubapastaTeste3");
            var caminhoArquivo = Path.Combine(caminho, "Arquivo teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo teste bkp.txt");
            var listaString = new List<string> {"Linha 1", "LInha 2", "LInha 3"};
            var listaStringCOntinuacao = new List<string> {"Linha 4", "LInha 5", "LInha 6"};
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "Arquivo teste.txt");

            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            //Criando diretorio
            //FOi chamado o System.IO acima para rodar o criar pasta. Criadoo caminho com path commbine
            System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine);
            //Se o diretorio tem arquivos é necessário passar um parametro incluindo os arquivos. Na clasee colocamos o boleano.
            // O aquivo não vai para a lixeira. É apagado completamente
            helper.ApagarDiretorio(caminhoPathCombine, true);
            //Criar arquivo
            helper.CriarArquivoTexto (caminhoArquivo, "Olá, teste de escrita de arquivo");
            //Criar arquivo com stream
            helper.CriarAqruivoTextStream(caminho, listaString);
            //Adicionar novas linhas
            helper.AdicionarTextStream(caminhoArquivo, listaStringCOntinuacao);
            //Ler arquivo
            helper.LerArquivoStream(caminhoArquivo);
            // MOver arquivo
            helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // Copiar arquivo
            helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            //Deletar arquivo (o arquivo não vai para lixeira)
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            

            //Interfaces
            //Criada a interfce ICalculadora e na classe calculadora foi implemmentada a interface (que não pode ser instanciada)
            // Se implementarmos o método na interface não precisamos implementar na classe. Caso contrário precisamos implementar os
            // métodos que não possuem um padrão na interface.
            // É necessário chamar a interface (using ....) no programa e na classe
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));



            //Classe system object. Sem escrever nada na classe ao clicar comp já parecem alguns métodos do sistema.
            //Esses métodos podem ser sobrescritos
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());



            //Classse Selada (ver classe Diretor)


            //Classes Abstratas
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();




            //Poliformismo

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine ("Resultado da primeira soma: " + calc.Somar(1, 3));
            // System.Console.WriteLine ("Resultado da segunda soma: " + calc.Somar(1, 3, 7));

            //Herança

            // Aluno p1 = new Aluno();
            // p1.Idade = 10;
            // p1.Nome = "João";
            // p1.Nota = 10;

            // p1.Apresentar();

            //  Encapsulamento
            // //Valores Validos            
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");
            // //Valores invalidos
            // Retangulo r1 = new Retangulo();
            // r1.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            //Abstração
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }

    }
}
