Console.Clear();

 Console.WriteLine("Soletrando\n");
 Console.Write("Digite o texto a ser soletrado: ");

 string texto = Console.ReadLine()!;

 Console.WriteLine("\nsoletrando ficaria...\n");

 Console.WriteLine(String.Join("-", texto.ToUpper().ToCharArray()));
 
 Console.WriteLine();
