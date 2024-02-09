namespace multiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza, digite o número para calculo da tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contador = 1;
        
        while(contador <= 10){
            int resultado = contador * numero;
            Console.WriteLine(contador+ "x"+numero+" = "+ resultado);
            contador++;
            }
    }
}
