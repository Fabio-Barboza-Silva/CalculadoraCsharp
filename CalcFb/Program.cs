namespace CalcFb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  
             *  
             *  VERSÃO 1

            string operador;
            double num1, num2, valor = 0;
                        
                          
            do 
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Bem vindo a Calculadora");
                Console.WriteLine("---------------------------");
                Console.WriteLine("digite uma entrada valida ou 'sair' para encerrar");

                Console.WriteLine("Digite o primeiro numero");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "sair")
                {
                    Console.WriteLine("Saindo do programa...");
                    break;
                }

                while (!double.TryParse(input1, out num1))
                {

                    Console.WriteLine("Entrada invalida por favor insira um numero valido!");
                    input1 = Console.ReadLine();

                    if (input1.ToLower() == "sair")
                    {
                        Console.WriteLine("Saindo do programa...");
                        return;
                    }
                }

                Console.WriteLine("Por favor digite a operação matemática (+,-,*,/) ou 'sair' para encerrar");                
                operador = Console.ReadLine();

                if (operador.ToLower() == "sair")
                {
                    Console.WriteLine("Saindo do programa...");
                    break;
                }

                Console.WriteLine("Digite o segundo numero");

                string input2 = Console.ReadLine();

                if (input2.ToLower() == "sair")
                {
                    Console.WriteLine("Saindo do programa...");
                    break;
                }

                while (!double.TryParse(input2, out num2))
                {

                    Console.WriteLine("Entrada invalida por favor insira um numero valido!");
                    input2 = Console.ReadLine();

                    if (input2.ToLower() == "sair")
                    {
                        Console.WriteLine("Saindo do programa...");
                        return;
                    }
                }

                switch (operador)
                {
                    case "+":
                        valor = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {valor}");
                        break;

                    case "-":
                        valor = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {valor}");
                        break;

                    case "*":
                        valor = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {valor}");
                        break;

                    case "/":

                        if (num2 != 0)
                        {
                            valor = num1 / num2;
                            Console.WriteLine($"{num1} / {num2} = {valor}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: divisao por 0 não é permitida");
                        }
                        break;
                        
                    default:
                        Console.WriteLine("Operador invalido! tente novamente");
                        break;
                }
               
            } while (true);

            */

            /*VERSÃO 2*/

            string operador;
            double num1, num2, valor = 0;


            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Bem vindo a Calculadora");
                Console.WriteLine("---------------------------");
                Console.WriteLine("digite uma entrada valida ou 'sair' para encerrar");

                num1 = ObterNumero("Digite o primeiro numero");

                if (num1 == -1) break;

                operador = ObterOperador();

                if (operador == "sair") break;

                num2 = ObterNumero("Digite o segundo numero");

                if (num2 == -1) break;


                switch (operador)
                {
                    case "+":
                        valor = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {valor}");
                        break;

                    case "-":
                        valor = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {valor}");
                        break;

                    case "*":
                        valor = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {valor}");
                        break;

                    case "/":

                        if (num2 != 0)
                        {
                            valor = num1 / num2;
                            Console.WriteLine($"{num1} / {num2} = {valor}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: divisao por 0 não é permitida");
                        }
                        break;
                }

            } while (true);

        }


        // Funcao para obter um numero
        static double ObterNumero(string mensagem)
        {
            Console.WriteLine(mensagem);
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                ExibirMensagemDeSaida();
                return -1; // retorna -1 para informar que o usuario quer sair.
            }

            while (!double.TryParse(input, out double numero))
            {

                Console.WriteLine("Entrada invalida por favor insira um numero valido!");
                input = Console.ReadLine();

                if (input.ToLower() == "sair")
                {
                    ExibirMensagemDeSaida();
                    return -1; // retorna -1 para informar que o usuario quer sair.
                }
            }

            return double.Parse(input);

        }

        static string ObterOperador() {

            Console.WriteLine("Por favor digite a operação matemática (+,-,*,/) ou 'sair' para encerrar");
            string operador = Console.ReadLine().ToLower();

            while (operador != "sair" && operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                Console.WriteLine("Operador inválido! Por favor, digite uma operação válida (+, -, *, /) ou 'sair'.");
                operador = Console.ReadLine().ToLower();
            }

            if (operador == "sair")
            {
                ExibirMensagemDeSaida();
            }

            return operador;
        }

        static void ExibirMensagemDeSaida()
        {
            Console.WriteLine("Saindo do programa...");
        }    
    }
}