namespace Intel_8086
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
				Console.WriteLine("INTEL 8086\nUzupełnij swoje rejestry:");
				//Należy pamiętać, że są to wartości w systemie szesnastkowym
				//Przy wpisie błędnej wartości rejestr zostaje ustawiony na "00"

				#region WPIS DO REJESTRU{
				Console.WriteLine("Kolejność rejestrów:\n1) AH\n2) BH\n3) CH\n4) DH\n");

				//string choice = Console.ReadLine();
				//choice = choice.ToUpper();

				//if (choice == "1" || choice == "AH")
				//{
					//Console.Clear();
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
					} else
					{
						AH = "00"; 
						Console.WriteLine("Aktualny stan rejestru AH: " + AH);
						Console.WriteLine("Wprowadzono niepoprawąa wartość, przypisano domyślną wartość");
					}
				//}
				//else if (choice == "2" || choice == "BH")
				//{
					//Console.Clear();
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
					} else
					{
						BH = "00";
						Console.WriteLine("Aktualny stan rejestru BH: " + BH);
						Console.WriteLine("Wprowadzono niepoprawąa wartość, przypisano domyślną wartość");
					}

				//}
				//else if (choice == "3" || choice == "CH")
				//{
					//Console.Clear();
					Console.WriteLine("Podaj wartoć rejestru CH");
					string CH = Console.ReadLine();
					CH = CH.ToLower();

					if (CH.Length < 3
						&& (CH[0] == 'a' || CH[0] == 'b' || CH[0] == 'c' || CH[0] == 'd' || CH[0] == 'e' || CH[0] == 'f'
						 || CH[0] == '0' || CH[0] == '1' || CH[0] == '2' || CH[0] == '3' || CH[0] == '4' || CH[0] == '5'
						 || CH[0] == '6' || CH[0] == '7' || CH[0] == '8' || CH[0] == '9')
							
						&& (CH[1] == 'a' || CH[1] == 'b' || CH[1] == 'c' || CH[1] == 'd' || CH[1] == 'e' || CH[1] == 'f'
						 || CH[1] == '0' || CH[1] == '1' || CH[1] == '2' || CH[1] == '3' || CH[1] == '4' || CH[1] == '5'
						 || CH[1] == '6' || CH[1] == '7' || CH[1] == '8' || CH[1] == '9'))
					{
						Console.WriteLine("Aktualny stan rejestru CH: " + CH);
					} else
					{
						CH = "00";
						Console.WriteLine("Aktualny stan rejestru CH: " + CH);
						Console.WriteLine("Wprowadzono niepoprawąa wartość, przypisano domyślną wartość");
					}

				//}
				//else if (choice == "4" || choice == "DH")
				//{
					//Console.Clear();
					Console.WriteLine("Podaj wartoć rejestru DH");
					string DH = Console.ReadLine();
					DH = DH.ToLower();

					if (DH.Length < 3
						&& (DH[0] == 'a' || DH[0] == 'b' || DH[0] == 'c' || DH[0] == 'd' || DH[0] == 'e' || DH[0] == 'f'
						 || DH[0] == '0' || DH[0] == '1' || DH[0] == '2' || DH[0] == '3' || DH[0] == '4' || DH[0] == '5'
						 || DH[0] == '6' || DH[0] == '7' || DH[0] == '8' || DH[0] == '9')
							
						&& (DH[1] == 'a' || DH[1] == 'b' || DH[1] == 'c' || DH[1] == 'd' || DH[1] == 'e' || DH[1] == 'f'
						 || DH[1] == '0' || DH[1] == '1' || DH[1] == '2' || DH[1] == '3' || DH[1] == '4' || DH[1] == '5'
						 || DH[1] == '6' || DH[1] == '7' || DH[1] == '8' || DH[1] == '9'))
					{
						Console.WriteLine("Aktualny stan rejestru DH: " + DH);
					} else
					{
						DH = "00";
						Console.WriteLine("Aktualny stan rejestru DH: " + DH);
						Console.WriteLine("Wprowadzono niepoprawąa wartość, przypisano domyślną wartość");
					}
				//}
				//else
					//Console.WriteLine("Nie ma takiego rejestru na liście");
				#endregion

				Console.WriteLine("\nINTEL 8086\nWybierz numer aby wykonać odpowiednią akcję:");
				Console.WriteLine("1) Przenieś wartość do innego rejestru - MOV\n2) Zamień wartości w rejestrach - XCHG\n3) Pokaż stan rejestrów\n4) MAGIA\n5) Zakończ działanie symulacji");
				option = Console.ReadLine();

				

				if (option == "1")
				{
					Console.WriteLine("1 - AH, 2 - BH, 3 - CH, 4 - DH, 5 - AL, 6 - BL, 7 - CL, 8 - DL");
					Console.WriteLine("Wybierz pierwszy rejestr: ");
					string firstRecord = Console.ReadLine();
					Console.WriteLine("Wybierz drugi rejestr: ");
					string secondRecord = Console.ReadLine();
				}

				else if (option == "2")
				{

				}

				else if (option == "3")
				{
					Console.Clear();
					Console.WriteLine("Stan rejestrów:");
					Console.WriteLine("AH: " + AH + "\nBH: " + BH + "\nCH: " + CH + "\nDH: " + DH);
				}

				else if (option == "4")
				{
					Console.WriteLine();
				}

				else if (option == "5")
					Console.Write("");
				else
					Console.WriteLine("Brak takiej opcji, powrót do wpisania rejestrów");

			} while (option != "5");
			Console.WriteLine("Dziękuję za skorzystanie z syumluacji procesora INTEL 8086");
			
		}

	}
}