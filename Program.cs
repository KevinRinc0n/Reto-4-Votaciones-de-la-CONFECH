Console.Write("Ingresa la cantidad de universidades: ");
int universidades = Convert.ToInt32(Console.ReadLine());

int uniAceptan = 0;
int uniRechazan = 0;
int uniEmpatan = 0;

for (int i = 0; i < universidades; i++)
{
    Console.Clear();

    Console.Write("Ingresa el nombre de la universidad: ");
    string nombre = Console.ReadLine();

    int a = 0;
    int r = 0;
    int n = 0;
    int b = 0;

    string valor = "";

    while (valor != "x")
    {
        Console.Clear();
        Console.WriteLine("Estas son las opciones de votos");
        Console.WriteLine("aceptar (A), rechazar (R), nulo (N) o blanco (B).");
        Console.Write("Ingresa tu voto: ");
        valor = Console.ReadLine().ToLower();

        switch (valor)
        {
            case "a":
                a += 1;
                break;
            case "b":
                b += 1;
                break;
            case "r":
                r += 1;
                break;
            case "n":
                n += 1;
                break;
            case "x":
                Console.WriteLine("DEJASTE DE VOTAR");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("#########################");
                Console.WriteLine("Votaste de manera incorrecta. Inténtalo de nuevo");
                Console.ReadKey();
                break;
        }
    }

    Console.WriteLine($"La universidad {nombre} tuvo estos votos: ");
    Console.WriteLine($"{a} aceptan, {r} rechazan, {b} blancos, {n} nulos");

    if (a > r && a > b)
    {
        Console.WriteLine($"La universidad {nombre} acepta la votación.");
        uniAceptan++;
    }
    else if (r > a && r > b)
    {
        Console.WriteLine($"La universidad {nombre} rechaza la votación.");
        uniRechazan++;
    }
    else if (b > r || b > a || n > r || n > a || n > b)
    {
        Console.WriteLine($"La universidad {nombre} no le interesa la votación.");
        uniRechazan++;
    }
    else
    {
        Console.WriteLine($"La universidad {nombre} tiene un empate en la votación.");
        uniEmpatan++;
    }

    Console.ReadKey(); 
}

Console.WriteLine($"Total de universidades que aceptan: {uniAceptan}");
Console.WriteLine($"Total de universidades que rechazan: {uniRechazan}");
Console.WriteLine($"Total de universidades con empate: {uniEmpatan}");