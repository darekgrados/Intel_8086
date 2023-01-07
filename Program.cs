namespace Intel_8086
{
	internal class Program
	{
		public void Main(string[] args)
		{
			//string AH, BH, CH, DH, AL, BL, CL, DL;

			Console.WriteLine("INTEL 8086");
			Console.WriteLine("Wybierz rejestr:\n1) AH\n2) BH\n3) CH\n4) DH");



			#region wybór pola
			string choice = Console.ReadLine();
			choice = choice.ToUpper();

			if (choice == "AH")
			{

			}
			else if (choice == "BH")
			{
				Checker();
				//AH = BH;
			}
			else if (choice == "CH")
			{

			}
			else if (choice == "DH")
			{

			}
			else
				Console.WriteLine("Nie ma takiego rejestru na liście");
			#endregion

			//Console.WriteLine("Rejestr check");
			//Console.WriteLine("0 = " + AH[0]); 
			//Console.WriteLine("1 = " + AH[1]);	

			Console.WriteLine("Podaj wartoć rejestru AH");
			string AH = Console.ReadLine();
			AH = AH.ToLower();

			if (AH.Length < 3 
				&& (AH[0] == 'a' || AH[0] == 'b' || AH[0] == 'c' || AH[0] == 'd' || AH[0] == 'e' || AH[0] == 'f' 
				 || AH[0] == '0' || AH[0] == '1' || AH[0] == '2' || AH[0] == '3' || AH[0] == '4' || AH[0] == '5'
				 || AH[0] == '6' || AH[0] == '7' || AH[0] == '8' || AH[0] == '9')

				&& (AH[1] == 'a' || AH[1] == 'b' || AH[1] == 'c' || AH[1] == 'd' || AH[1] == 'e' || AH[1] == 'f'
				 || AH[1] == '0' || AH[1] == '1' || AH[1] == '2' || AH[1] == '3' || AH[1] == '4' || AH[1] == '5'
				 || AH[1] == '6' || AH[1] == '7' || AH[1] == '8' || AH[1] == '9'))
			{
				Console.WriteLine("Aktualny stan rejestru AH: " + AH);
			}
			else
			{
				AH = "00";
				Console.WriteLine("Aktualny stan rejestru");
				Console.WriteLine("AH: " + AH + " - niepoprawna wartość, przypisanie wartości 0");
			}


			
			Console.WriteLine("Wybierz rozkaz do wykonania\n1) MOV\n2) XCHG");
			string order = Console.ReadLine();
			order = order.ToLower();
			//ADD SUB IN DEC NOT AND OR

			if (order == "mov")
			{

			}






		}

		// wywwołanie funkcji żeby nasetępnie przypisać to i oszczędzić miejsce w kodzie - do sprawdzenia czy działa
		private void Checker()
		{
			Console.WriteLine("Podaj wartoć rejestru AH");
			string AH = Console.ReadLine();
			AH = AH.ToLower();

			if (AH.Length < 3
				&& (AH[0] == 'a' || AH[0] == 'b' || AH[0] == 'c' || AH[0] == 'd' || AH[0] == 'e' || AH[0] == 'f'
				 || AH[0] == '0' || AH[0] == '1' || AH[0] == '2' || AH[0] == '3' || AH[0] == '4' || AH[0] == '5'
				 || AH[0] == '6' || AH[0] == '7' || AH[0] == '8' || AH[0] == '9')

				&& (AH[1] == 'a' || AH[1] == 'b' || AH[1] == 'c' || AH[1] == 'd' || AH[1] == 'e' || AH[1] == 'f'
				 || AH[1] == '0' || AH[1] == '1' || AH[1] == '2' || AH[1] == '3' || AH[1] == '4' || AH[1] == '5'
				 || AH[1] == '6' || AH[1] == '7' || AH[1] == '8' || AH[1] == '9'))
			{
				Console.WriteLine("Aktualny stan rejestru AH: " + AH);
			}
			else
			{
				AH = "00";
				Console.WriteLine("Aktualny stan rejestru");
				Console.WriteLine("AH: " + AH + " - niepoprawna wartość, przypisanie wartości 0");
			}
		}

		



		static void Values()
		{
			//Console.WriteLine("AH: " + AH);

		}

		
	}
}