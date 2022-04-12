namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public int Salario { get; set; }


        public  override void Apresentar (){
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade}, sou professor e recebo um salario de {Salario}.");

        }
    }
}