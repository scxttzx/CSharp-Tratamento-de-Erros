
using System.Security.Cryptography;

try
{
	Console.WriteLine("\nInforme o dividendo");
	int dividendo = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("\nInforme o divisor");
	int divisor = Convert.ToInt32(Console.ReadLine());

	int resultado = (dividendo / divisor);
	Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
}
//catch (Exception e)
//{

//    Console.WriteLine($"\n{e.GetType()} informa: {e.Message}");
 
//}
catch(FormatException)
{
    Console.WriteLine("\nInforme um valor ineiro");
}
catch (OverflowException)
{
    Console.WriteLine("Informe um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
	Console.WriteLine("\nNão é possível dividir por zero\n");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
	Console.WriteLine("\nFim do programa\n");
}



Console.ReadKey();