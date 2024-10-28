//using System;


////public class InstrumentoMusical()
////{
////	protected string Som { get; set; };
////	protected string Nome { get; set; };

////	public void Tocar()
////	{	
////    Console.WriteLine($"{Nome} está emitindo som: {Som}");
////	}
////}

////	public class Violão : InstrumentoMusical
////{
////	Nome = Violão;
////	Som = "Dó";
////}

////public class Tambor : InstrumentoMusical { 
////	Nome = Tambor;
////	Som = "Pum"
////}

//namespace BD
//{
//    public abstract class RegistroDB
//    {

//        protected abstract string NomeTabela { get; }

//        //public abstract void Metodo();
//        public void Select()
//        {
//            var select = $"SELECT * FROM {NomeTabela}";
//            Console.WriteLine("Executando select no banco de dados: ");
//        }
//    }

//    public class PessoaDB : RegistroDB
//    {
//        protected override string NomeTabela { get => "PESSOAS"; }
//    }

//    public class ProdutoDB : RegistroDB
//    {
//        protected override string NomeTabela { get => "PRODUTOS"; }
//    }

//    public class Executor ()    
//        {

//            public static void Executar()
//    {
//        //      var instrumentos = new InstrumentoMusical[3];

//        //      instrumentos[0] = new InstrumentoMusical();
//        //      instrumentos[1] = new InstrumentoMusical();
//        //      instrumentos[2] = new InstrumentoMusical();

//        //foreach (var instrumento in instrumentos)
//        //{
//        //	Console.WriteLine(instrumento);
//        //}

//        var registro = new PessoaDB();
//        var registro = new ProdutoDB();
//        registro.Select();

//    }
//}
//}

namespace poo
{
    //public abstract class Forma
    //{
    //    public int Base { get; }
    //    public int Altura { get; }

    //    public Forma(int baseForma, int alturaForma);
    //    public abstract void CalcularPerimetro();

    //}

    //public class Retangulo : Forma
    //{
    //    public override void CalcularPerimetro()
    //    {
    //        float area = (lado1 * 2) + (lado2 * 2);
    //        Console.WriteLine(area) ;
    //    }
    //}

    //public class Triangulo : Forma 
    //{

    //    public override void CalcularPerimetro()
    //    {
    //        float area = Base * Altura
    //        Console.WriteLine(area);
    //    }
    //}

    public interface IAutenticavel
    {
        void Autenticar();
        void Deslogar();
    }

    public  class UsuarioSistema : IAutenticavel
    {
        public void Autenticar()
        {
            Console.WriteLine("Usuário autenticado!");
           
        }

        public void Deslogar()
        {
            Console.WriteLine("Usuário autenticado!");
           
        }

       
    }

    public class Executor
    {

        public static void Executar()
        {
            

        }
    }

}
