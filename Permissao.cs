using System;


namespace Aula15trycath
{
    public class Permissao
    {
         public bool Permitir { get; set; }
        
        public void Autorizar (){

            Console.WriteLine (" Deseja permitir acesso ? Digite true ou False ? ");
            
            try{

                 Permitir = Boolean.Parse(Console.ReadLine());
           
            }catch(Exception){

                Console.WriteLine(" Erro na aplicação: Dados inválidos");
            }
             
            
        }

    }

}        