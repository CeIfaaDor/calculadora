using System;

namespace Programinha
{
    class Program
    {
        //Arrumar a conversão de INT pra String na área da soma :D
        static void Main(string[] args)
        {
            
            string nome,escolha,escolhaOperacao;
            Console.Clear();
            Console.WriteLine("====== Calculadora 1.0 iCraw ======");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Seja bem vindo {nome} :D");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Deseja fazer alguma operação? S=sim N=não ");    
            escolha = Console.ReadLine();
            //Escolhendo se o usuario deseja continuar
            if( (escolha == "S") || (escolha == "s") ){
                Console.Clear();
                Console.WriteLine("Qual operação deseja realizar? + - * /");
                //Escolhendo a operação
                escolhaOperacao = Console.ReadLine();
                //Se a escolha for + então some!
                if(escolhaOperacao == "+"){ 
                    double numero1,numero2;
                    double resultSoma;
                    Console.Clear();
                    Console.WriteLine("==== Soma ====");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Digite os numeros que você quer somar: ");
                    
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"Digite o numero que você quer somar com {numero1}");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    
                    resultSoma = numero1 + numero2;

                    
                    Console.WriteLine($"O resualtado entre {numero1} + {numero2} é {resultSoma}");
                    



                }else if (escolha == "-"){

                    double numero1,numero2;
                    double resultSub;
                    Console.Clear();
                    Console.WriteLine("==== Subtração ====");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Digite os numeros que você quer subtrair: ");
                    
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"Digite o numero que você quer subtrair com {numero1}");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    
                    resultSub = numero1 - numero2;

                    
                    Console.WriteLine($"O resualtado entre {numero1} - {numero2} é {resultSub}");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte entre para sair");
                    Console.ReadLine();
                }else if (escolha == "*"){

                    double numero1,numero2;
                    double resultMult;
                    Console.Clear();
                    Console.WriteLine("==== Multiplicação ====");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Digite os numeros que você quer multiplicar: ");
                    
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"Digite o numero que você quer multiplicar com {numero1}");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    
                    resultMult = numero1 * numero2;

                    
                    Console.WriteLine($"O resualtado entre {numero1} x {numero2} é {resultMult}");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte entre para sair");
                    Console.ReadLine();
                }else if (escolha == "/"){

                    double numero1,numero2;
                    double resultDiv,restoDiv;
                    Console.Clear();
                    Console.WriteLine("==== Divisão ====");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Digite os numeros que você quer dividir: ");
                    
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"Digite o numero que você quer dividir com {numero1}");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    
                    resultDiv = numero1 / numero2;
                    restoDiv = numero1 % numero2;

                    
                    Console.WriteLine($"O resualtado entre {numero1} / {numero2} é {resultDiv} e o resto dela é {restoDiv}");
                    Console.WriteLine("");
                    Console.WriteLine("Aperte entre para sair");
                    Console.ReadLine();
                }
                
            }
            //Saindo do programa
            else if ((escolha == "N") || (escolha == "n")){
                Console.Clear();
                Console.WriteLine("Obrigado por usar nosso programa :D");
                Console.WriteLine("Aperte enter para sair");
                Console.ReadLine();
            }
            //Comando invalido
            else{
                Console.Clear();
                Console.WriteLine("Comando invalid reinicie o programa...");
                Console.WriteLine("Aperte enter para sair");
                Console.ReadLine();
                
            }       
        }
    }
}
