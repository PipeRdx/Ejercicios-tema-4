using System;

internal class NewBaseType
{
    static void Main()
    {
      //condicional if

Console.WriteLine("Condicional If");
Console.WriteLine(" ");
     int numeroIf = -225;
     if(numeroIf > 0){
      Console.WriteLine("El numero es positivo "+numeroIf);
     } 
     else if(numeroIf < 0){
      Console.WriteLine("El numero es Negativo "+numeroIf);
     }
     else{
      Console.WriteLine("El numero es "+numeroIf);
     }
     Console.WriteLine(" ");

//bucle while

Console.WriteLine("Bucle While ");
Console.WriteLine(" ");
     int numeroWhile = 1;
     while(numeroWhile < 4){
      Console.WriteLine(numeroWhile);
      numeroWhile++;
     }
     Console.WriteLine(" ");
     //bucle do while

     Console.WriteLine("Bucle Do/While");
     Console.WriteLine(" ");
int numeroWhile1 = 1;
     do{
       Console.WriteLine(numeroWhile1);
      numeroWhile1 = numeroWhile1 + 1;
     }
     while(numeroWhile1 < 4);

     Console.WriteLine(" ");

     //bucle for
     Console.WriteLine("Bucle For ");

     for(int numeroFor = 0; numeroFor <= 3;numeroFor++){
      Console.WriteLine(numeroFor);
     }
    Console.WriteLine(" ");

    //Switch
    
    Console.WriteLine("Switch ");
    Console.WriteLine(" ");
    Console.WriteLine("¿En que estacion estas? elige del 1 al 4");
    Console.WriteLine(" ");

    int estacion = 4;

    switch(estacion){
      case 1:
      Console.WriteLine("primavera ");
      break;
      case 2:
      Console.WriteLine("verano ");
      break;
      case 3:
      Console.WriteLine("otoño ");
      break;
      case 4:
      Console.WriteLine("invierno ");
      break;
      default:
      Console.WriteLine("¿En que planeta estas?");
      break;

    }
    Console.WriteLine(" ");
      }



    }


