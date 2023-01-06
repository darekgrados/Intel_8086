namespace Intel_8086
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj wartoć rejestru AH");
			string Ah = Console.ReadLine();
			string AH = Ah.ToLower();

			Console.WriteLine("Rejestr check");
			Console.WriteLine("0 = " + AH[0]);
			Console.WriteLine("1 = " + AH[1]);			

			if (AH.Length < 3 
				&& (AH[0] == 'a' || AH[0] == 'b' || AH[0] == 'c' || AH[0] == 'd' || AH[0] == 'e' || AH[0] == 'f' 
				|| AH[0] == '0' ||	AH[0] == '1' || AH[0] == '2' || AH[0] == '3' || AH[0] == '4' || AH[0] == '5'
				|| AH[0] == '0' || AH[0] == '6' || AH[0] == '7' || AH[0] == '8' || AH[0] == '9')

				&& (AH[1] == 'a' || AH[1] == 'b' || AH[1] == 'c' || AH[1] == 'd' || AH[1] == 'e' || AH[1] == 'f'
				 || AH[1] == '0' || AH[1] == '1' || AH[1] == '2' || AH[1] == '3' || AH[1] == '4' || AH[1] == '5'
				 || AH[1] == '0' || AH[1] == '6' || AH[1] == '7' || AH[1] == '8' || AH[1] == '9'))
			{
				Console.WriteLine("AH: " + AH);
			}
			else
			{
				AH = null;
				Console.WriteLine("AH: " + AH + " - null ");
			}
				
			
		}
	}
}