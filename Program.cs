﻿namespace Intel_8086
{
	internal class Program
	{
		

		static void Main(string[] args)
		{
			string AL, BL, CL, DL = "00";

			//Console.Clear();
			//Menu();
			string option = "0";
			do
			{
				Console.WriteLine("INTEL 8086\nWybierz numer aby wykonać odpowiednią akcję:");
				Console.WriteLine("1) Wpisz wartość do rejestru\n2) Przenieś wartość z rejestru\n3) Zamień wartości w rejestrach\n4) Zakończ działanie symulacji");
				option = Console.ReadLine();
				
				if (option == "1")
				{
					Console.WriteLine("Wybierz rejestr:\n1) AH\n2) BH\n3) CH\n4) DH");

					string choice = Console.ReadLine();
					choice = choice.ToUpper();

					if (choice == "1" || choice == "AH")
					{
						Console.Clear();
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
					else if (choice == "2" || choice == "BH")
					{
						Console.Clear();
						Console.WriteLine("Podaj wartoć rejestru BH");
						string BH = Console.ReadLine();
						BH = BH.ToLower();

						if (BH.Length < 3														
							&& (BH[0] == 'a' || BH[0] == 'b' || BH[0] == 'c' || BH[0] == 'd' || BH[0] == 'e' || BH[0] == 'f'
							 || BH[0] == '0' || BH[0] == '1' || BH[0] == '2' || BH[0] == '3' || BH[0] == '4' || BH[0] == '5'
							 || BH[0] == '6' || BH[0] == '7' || BH[0] == '8' || BH[0] == '9')					
																												
							&& (BH[1] == 'a' || BH[1] == 'b' || BH[1] == 'c' || BH[1] == 'd' || BH[1] == 'e' || BH[1] == 'f'
							 || BH[1] == '0' || BH[1] == '1' || BH[1] == '2' || BH[1] == '3' || BH[1] == '4' || BH[1] == '5'
							 || BH[1] == '6' || BH[1] == '7' || BH[1] == '8' || BH[1] == '9'))
						{
							Console.WriteLine("Aktualny stan rejestru BH: " + BH);
						}
						else
						{
							BH = "00";
							Console.WriteLine("Aktualny stan rejestru");
							Console.WriteLine("BH: " + BH + " - niepoprawna wartość, przypisanie wartości 0");
						}

					}
					else if (choice == "3" || choice == "CH")
					{

					}
					else if (choice == "DH")
					{

					}
					else
						Console.WriteLine("Nie ma takiego rejestru na liście");

				} else if (option == "2")
				{

				}

				


			} while (option != "4");
			Console.WriteLine("Dziękuję za skorzystanie z syumluacji procesora INTEL 8086");

			//Console.WriteLine("Rejestr check");
			//Console.WriteLine("0 = " + AH[0]); 
			//Console.WriteLine("1 = " + AH[1]);				
			
			Console.WriteLine("Wybierz rozkaz do wykonania\n1) MOV\n2) XCHG");
			string order = Console.ReadLine();
			order = order.ToLower();
			//ADD SUB IN DEC NOT AND OR

			if (order == "mov")
			{

			}

		}

		// wywwołanie funkcji żeby nasetępnie przypisać to i oszczędzić miejsce w kodzie - do sprawdzenia czy działa
		public void Checker()
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
		
		//static void Menu()
		//{
		//	string option = "0";
		//	do
		//	{
		//		Console.WriteLine("Wybierz numer aby wykonać odpowiednią akcję:");
		//		Console.WriteLine("1) Wpisz wartość do rejestru\n2) Przenieś wartość z rejestru\n3) Zamień wartości w rejestrach\n4) Zakończ działanie symulacji");
		//		option = Console.ReadLine();
				

		//	} while (option != "4");			
		//}

	}
}