using System;

class Turismo
{
    static void Main()
    {
        int tempo=0;
        char escolha;

        inicio:
        Console.Clear();

        Console.WriteLine("Destinos de Turismo:\n [1]Ubatuba-SP\n [2]Flóripa-SC\n [3]Foz do iguaçu-PR");
        Console.ReadLine();
        //
        Console.WriteLine("Escolha o transporte:\n [a]Avião\n [b]Ônibus\n [c]Taxi");

        escolha=char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            tempo = 120;
            break;
            case 'b':
            tempo = 400;
            break;
            case 'c':
            tempo = 310;
            break;
        default:
        tempo = -1;
        break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponível");
        }
        else
        {
            Console.WriteLine("\nO tempo de espera para a chegada em seu destino é: {0} minutos",tempo);
        }
        
        Console.WriteLine("\nCalcular outro transporte:\n Sim ou Não");
        escolha= char.Parse(Console.ReadLine());
        if(escolha == 'S' || escolha == 's')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim da sessão.\n Obrigado por entrar em contato.");
        }
    }
}
