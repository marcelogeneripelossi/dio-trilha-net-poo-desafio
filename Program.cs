using DesafioPOO.Models;
using System;
using System.Reflection;

byte opcao = 0;
bool exibe = true;

Console.WriteLine("Escolha o SmartPhone para Cadastrar:\n");

while (exibe)
{
    Console.WriteLine("1 - Iphone");
    Console.WriteLine("2 - Nokia");
    Console.WriteLine("3 - Sair");
    byte.TryParse(Console.ReadLine(), out opcao);

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Smartphone iphone = new Iphone { IMEI = "123456", Memoria = 128, Modelo = "12", Numero = "1234-5678" };
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
            goto default;

        case 2:
            Smartphone nokia = new Nokia { IMEI = "987654", Memoria = 64, Modelo = "A21S", Numero = "9876-5432" };
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            goto default;


        case 3:
            Console.WriteLine("Obrigado por utilizar o sistema.");
            exibe = false;
            goto default;

        default:
            Console.WriteLine("---------------------");
            break;
    };

}




