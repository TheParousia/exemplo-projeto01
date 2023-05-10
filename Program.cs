using System;

class Program{

    static void Main(){
        int opt = 0;
        bool repetir = true;
        //Insira as variáveis do seu algoritmo aqui

        do{
            //Apaga o que tem na tela
            Console.Clear();

            Console.WriteLine("\tMENU");
            Console.WriteLine("1- Opção 1");
            Console.WriteLine("2- Opção 2");
            Console.WriteLine("3- Opção 3");
            Console.WriteLine("4- Opção 4");
            Console.WriteLine("5- Opção 5");
            Console.WriteLine("6- Opção 6");
            Console.WriteLine("4- Sair\n");

            opt = int.Parse(Console.ReadLine());

            
            switch (opt){
                case 1:
                    Console.WriteLine("Opt1");
                    break;
                case 2:
                    Console.WriteLine("Opt3");
                    break;
                case 3:
                    Console.WriteLine("Opt3");
                    break;
                case 4:
                    Console.WriteLine("Opt4");
                    repetir = false;
                    break;
                case 5:
                    Console.WriteLine("Opt5");
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }

            // Pausa a execução do programa até uma tecla ser apertada
            Console.ReadKey();

        }while(repetir);
    }
    
}

