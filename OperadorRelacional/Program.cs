// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var (valor1, valor2, valor3) = (10, 1, 2);

//Console.WriteLine("Los valor son: " + valor1+ valor2 + valor3);


//bool resulta1 = valor1 == valor2;

//Console.WriteLine("El resultado de la comparacion valor1 == valor2 es: " + resulta1);

//bool resulta2 = valor1 != valor2;

//Console.WriteLine("El resultado de la comparacion valor1 != valor2 es: " + resulta2);

//bool resulta3 = valor1 > valor2;

//Console.WriteLine("El resultado de la comparacion valor1 > valor2 es: " + resulta3);

//bool resulta4 = valor1 < valor2;

//Console.WriteLine("El resultado de la comparacion valor1 < valor2 es: " + resulta4);


//int altura = 172;
//int edad = 26;
//string nombre = "Harold Contreras";
//string info = "nacio en bogota, estudia ingeneria de sistemas";
//var hobby = "Deportista";

//string tarjetaDeInformacio = $"La informacion de {nombre} es la siguiente \n su edad es {edad}\n" +
//    $"su altura es de {altura} cms\n informacion relevante {info} \n ademas, su hobby es: {hobby} ";

//Console.WriteLine(tarjetaDeInformacio);

//int totalJugador = 25;
//int totalDealer = 15;
//string message = "";

//if(totalJugador > totalDealer && totalJugador < 22 )
//{
//    message = "Venciste al dealer, felicidades.";
//}
//else if(totalJugador >= 22)
//{
//    message = "Te pasaste de 21";
//}
//else if(totalJugador <= totalDealer)
//{
//    message = "Perdistes vs el dealer, lo siento";
//}
//else
//{
//    message = "Condicion no valida";
//}

//Console.WriteLine(message);


System.Random random = new System.Random();

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string switchControl = "menu";
string controlOtraCarta = "";
int platziCoins = 0;


while (true)
{
    //Console.Clear();
    Console.WriteLine("Bienvenido al P L A T Z I N O");
    Console.WriteLine("Cuantos PlatziCoins deseas ? \n" +
        " Recuerda que necesitas 1 por ronda");
    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {
        totalDealer = 0;
        totalJugador = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba 21 para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":
                do
                {

                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta jugador.");
                    Console.WriteLine($"Te salio el numero: {num}");
                    Console.WriteLine("Deseas otra carta ?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "yes");

                totalDealer = random.Next(12, 23);
                Console.WriteLine($"El dealer tiene: {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades.";
                    platziCoins = platziCoins + 1;
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "Te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdistes vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condicion no valida";
                }

                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("valor ingresado no valido en el c a s i n o ");
                break;

        }
         
    }
}

