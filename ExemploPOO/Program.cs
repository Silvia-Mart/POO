using System.IO;
using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    public class Program
    {
        static void Main(string [] args)
        { 
            var caminho = "C:/Programando com Orientação a objetos com C sharp DIO/Trabalhando com Arquivos";
            var caminhoPathCombine = Path.Combine(caminho,"pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho,"arquivo-teste--stream.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "pasta teste 2", "arquivo-teste--stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho,"arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-teste-bkp.txt");


            var listaStream = new List<string>{  " linha 1", " linha2", " linha 3" };
            var listaStreamContinuaçao = new List<string>{  " linha 4", " linha 5", " linha 6" };

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            // helper.CriarDiretorios(Path.Combine(caminho, "pasta teste 3", "subpasta teste 3"));
            //helper.ApagarDiretorios(caminhoPathCombine, true);
            //helper.CriarArquivoDeTexto(caminhoArquivo,"olá! teste de escrita de arquivo");
            //helper.CriarArquivoDeTextoStream(caminhoArquivo, listaStream);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStreamContinuaçao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            
            // //INTERFACES
            // ICalculadora calc = new Calculadora();   
            // System.Console.WriteLine(calc.Somar(10, 20));



        // //CLASSE OBJECT
        // Computador comp = new Computador();
        // System.Console.WriteLine(comp.ToString());
           
        //CONTA ABSTRATA
        // Corrente c = new Corrente();
        // c.Creditar(100);

        // c.ExibirSaldo();
        
        //POLIMORFISMO POR TEMPO DE COMPILAÇÃO
        //     Calculadora Calc = new Calculadora ();
        //    System.Console.WriteLine("Resultado sa primeira soma : " + Calc.Somar(20, 20));
        //     System.Console.WriteLine("Resultado sa segunda soma : " + Calc.Somar(40, 40, 40));

        //POLIMORFISMO POR TEMPO DE EXECUÇÃO
        //      Professor p2 = new Professor ();
        //       p2.Nome = "Fred";
        //       p2.Idade = 42;
        //       p2.Salario = 9000;
        //       p2.Documento = "987654321";
        //       p2.Apresentar();

        //     Aluno p1 = new Aluno ();
        //       p1.Nome = "Bob";
        //       p1.Idade = 12;
        //       p1.Nota = 9;
        //       p1.Documento = "123456789";
        //       p1.Apresentar();

        //HERANÇA
        //      Professor p1 = new Professor ();
        //      p1.Nome = "Bob";
        //      p1.Idade = 41;
        //      p1.Salario = 9000;
        //      p1.Documento = "123456789";
        //      p1.Apresentar();
 
        //    //ENCAPSULAMENTO
        //    //valores validos
        //     Retangulo r = new Retangulo ();
        //     r.DefinirMedidas( 25, 25 );
           
        //     System.Console.WriteLine($"Area : { r.ObterArea()}"); 

        //     //valores invalidos
        //     Retangulo r1 = new Retangulo ();
        //     r1.DefinirMedidas( 0, 0 );
           
        //     System.Console.WriteLine($"Area : { r1.ObterArea()}");

        //ABSTRAÇAO
        // 
        //     Pessoa p1 = new Pessoa();
        //     p1.Nome = "Bob";
        //     p1.Idade = 21;

        //     p1.Apresentar();
        
        }
    }
}