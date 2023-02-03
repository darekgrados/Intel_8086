using System.Globalization;
using System.Numerics;

namespace Intel_8086
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("INTEL 8086\nUzupełnij swoje rejestry:");
			//Należy pamiętać, że są to wartości w systemie szesnastkowym
			//Przy wpisie błędnej wartości rejestr zostaje ustawiony na "00"

			#region WPIS DO REJESTRU

			Console.WriteLine("Kolejność rejestrów:\n1) AH\n2) BH\n3) CH\n4) DH\n");

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
			} else {
				AH = "00"; 
				Console.WriteLine("Aktualny stan rejestru AH: " + AH);
				Console.WriteLine("Wprowadzono niepoprawną wartość, przypisano domyślną wartość");
			}

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
			} else {
				BH = "00";
				Console.WriteLine("Aktualny stan rejestru BH: " + BH);
				Console.WriteLine("Wprowadzono niepoprawną wartość, przypisano domyślną wartość");
			}
							
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
			} else {
				CH = "00";
				Console.WriteLine("Aktualny stan rejestru CH: " + CH);
				Console.WriteLine("Wprowadzono niepoprawną wartość, przypisano domyślną wartość");
			}

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
			} else {
				DH = "00";
				Console.WriteLine("Aktualny stan rejestru DH: " + DH);
				Console.WriteLine("Wprowadzono niepoprawną wartość, przypisano domyślną wartość");
			}
			#endregion

			
			string option = "1";
			do
			{
				Console.WriteLine("\nINTEL 8086\nWybierz numer aby wykonać odpowiednią akcję:");
				Console.WriteLine("1) Przenieś wartość do innego rejestru - MOV\n2) Zamień wartości w rejestrach - XCHG\n3) AND\n4) NOT\n5) OR\n6) XOR\n" +
					"7) Inkrementacja - In\n8) Dekrementacja - Dec\n9) Add - dodawanie wartości\n11 Pokaż stan rejestrów\n12) Zakończ działanie symulacji\n");
				option = Console.ReadLine();

				Console.Clear();	

				if (option == "1")
				{	
					string AL, BL, CL, DL = null;

					//Console.WriteLine("1 - AH, 2 - BH, 3 - CH, 4 - DH, 5 - AL, 6 - BL, 7 - CL, 8 - DL");
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz pierwszy rejestr: ");
					string firstRecord = Console.ReadLine();
					Console.Write("1 - AL, 2 - BL, 3 - CL, 4 - DL\nWybierz drugi rejestr: ");
					string secondRecord = Console.ReadLine();

					switch (firstRecord, secondRecord) 
					{
						case ("1", "1"):
							AL = AH;
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("1", "2"):
							BL = AH;
							Console.WriteLine("Aktualna wartość BL: " + BL);
								break;
						case ("1", "3"):
							CL = AH;
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("1", "4"):
							DL = AH;
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						case ("2", "1"):
							AL = BH;
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("2", "2"):
							BL = BH;
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("2", "3"):
							CL = BH;
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("2", "4"):
							DL = BH;
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						case ("3", "1"):
							AL = CH;
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("3", "2"):
							BL = CH;
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("3", "3"):
							CL = CH;
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("3", "4"):
							DL = CH;
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						case ("4", "1"):
							AL = DH;
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("4", "2"):
							BL = DH;
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("4", "3"):
							CL = DH;
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("4", "4"):
							DL = DH;
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						default:
							break;
					}
				}

				else if (option == "2")
				{
					string AL = "00", BL = "00", CL = "00", DL = "00";
					string temp = "  ";

					//Console.WriteLine("1 - AH, 2 - BH, 3 - CH, 4 - DH, 5 - AL, 6 - BL, 7 - CL, 8 - DL");
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz pierwszy rejestr: ");
					string firstRecord = Console.ReadLine();
					Console.Write("1 - AL, 2 - BL, 3 - CL, 4 - DL\nWybierz drugi rejestr: ");
					string secondRecord = Console.ReadLine();

					switch (firstRecord, secondRecord)
					{
						case ("1", "1"):
							temp = AL;
							AL = AH;
							AH = temp;
							Console.WriteLine("Aktualna wartość AH: " + AH);
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("1", "2"):
							temp = BL;
							BL = AH;
							AH = temp;
							Console.WriteLine("Aktualna wartość AH: " + AH);
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("1", "3"):
							temp = CL;
							CL = AH;
							AH = temp;
							Console.WriteLine("Aktualna wartość AH: " + AH);
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("1", "4"):
							temp = DL;
							DL = AH;
							AH = temp;
							Console.WriteLine("Aktualna wartość AH: " + AH);
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						case ("2", "1"):
							temp = AL;
							AL = BH;
							BH = temp;
							Console.WriteLine("Aktualna wartość BH: " + BH);
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("2", "2"):
							temp = BL;
							BL = BH;
							BH = temp;
							Console.WriteLine("Aktualna wartość BH: " + BH);
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("2", "3"):
							temp = CL;
							CL = BH;
							BH = temp;
							Console.WriteLine("Aktualna wartość BH: " + BH);
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("2", "4"):
							temp = DL;
							DL = BH;
							BH = temp;
							Console.WriteLine("Aktualna wartość BH: " + BH);
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						case ("3", "1"):
							temp = AL;
							AL = CH;
							CH = temp;
							Console.WriteLine("Aktualna wartość CH: " + CH);
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("3", "2"):
							temp = BL;
							BL = CH;
							CH = temp;
							Console.WriteLine("Aktualna wartość CH: " + CH);
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("3", "3"):
							temp = CL;
							CL = CH;
							CH = temp;
							Console.WriteLine("Aktualna wartość CH: " + CH);
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("3", "4"):
							temp = DL;
							DL = CH;
							CH = temp;
							Console.WriteLine("Aktualna wartość CH: " + CH);
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						case ("4", "1"):
							temp = AL;
							AL = DH;
							DH = temp;
							Console.WriteLine("Aktualna wartość DH: " + DH);
							Console.WriteLine("Aktualna wartość AL: " + AL);
							break;
						case ("4", "2"):
							temp = BL;
							BL = DH;
							DH = temp;
							Console.WriteLine("Aktualna wartość DH: " + DH);
							Console.WriteLine("Aktualna wartość BL: " + BL);
							break;
						case ("4", "3"):
							temp = CL;
							CL = DH;
							DH = temp;
							Console.WriteLine("Aktualna wartość DH: " + DH);
							Console.WriteLine("Aktualna wartość CL: " + CL);
							break;
						case ("4", "4"):
							temp = DL;
							DL = DH;
							DH = temp;
							Console.WriteLine("Aktualna wartość DH: " + DH);
							Console.WriteLine("Aktualna wartość DL: " + DL);
							break;

						default:
							break;
					}

				}

				else if (option == "3" || option == "5")
				{
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz pierwszy rejestr: ");
					string firstRecord = Console.ReadLine();
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz drugi rejestr: ");
					string secondRecord = Console.ReadLine();

					switch (firstRecord, secondRecord)
					{
						case ("1", "1"):
							Console.WriteLine("True");
							break;
						case ("1", "2"):
							if (AH == BH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");							
							break;
						case ("1", "3"):
							if (AH == CH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("1", "4"):
							if (AH == DH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("2", "1"):
							if (BH == AH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");							
							break;
						case ("2", "2"):
							Console.WriteLine("True");							
							break;
						case ("2", "3"):
							if (BH == CH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("2", "4"):
							if (BH == DH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("3", "1"):
							if (CH == AH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("3", "2"):
							if (CH == BH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;							
						case ("3", "3"):
							Console.WriteLine("True");
							break;
						case ("3", "4"):
							if (CH == DH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("4", "1"):
							if (DH == AH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("4", "2"):
							if (DH == BH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
							
						case ("4", "3"):
							if (DH == CH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("4", "4"):
							Console.WriteLine("True");
							break;

						default:
							break;
					}
				}

				else if (option == "4" || option == "6")
				{
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz pierwszy rejestr: ");
					string firstRecord = Console.ReadLine();
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz drugi rejestr: ");
					string secondRecord = Console.ReadLine();

					switch (firstRecord, secondRecord)
					{
						case ("1", "1"):
							Console.WriteLine("False");
							break;
						case ("1", "2"):
							if (AH != BH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("1", "3"):
							if (AH != CH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("1", "4"):
							if (AH != DH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("2", "1"):
							if (BH != AH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("2", "2"):
							Console.WriteLine("False");
							break;
						case ("2", "3"):
							if (BH != CH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("2", "4"):
							if (BH != DH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("3", "1"):
							if (CH != AH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("3", "2"):
							if (CH != BH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("3", "3"):
							Console.WriteLine("False");
							break;
						case ("3", "4"):
							if (CH != DH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("4", "1"):
							if (DH != AH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("4", "2"):
							if (DH != BH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;

						case ("4", "3"):
							if (DH != CH)
								Console.WriteLine("True");
							else
								Console.WriteLine("False");
							break;
						case ("4", "4"):
							Console.WriteLine("False");
							break;

						default:
							break;
					}
				}

				else if (option == "7")
				{
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz rejestr do inkrementacji: ");
					string firstRecord = Console.ReadLine();
					switch (firstRecord)
					{
						case "1":
							{
								//do rozczesania bardziej 
								string digits = new string(AH.Where(char.IsDigit).ToArray());
								string letters = new string(AH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (++number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								AH = newStr;
								Console.WriteLine("AH: " + AH);
							}
							break;

						case "2":
							{
								//do rozczesania bardziej 
								string digits = new string(BH.Where(char.IsDigit).ToArray());
								string letters = new string(BH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (++number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								BH = newStr;
								Console.WriteLine("BH: " + BH);
							}
							break;

						case "3":
							{
								//do rozczesania bardziej 
								string digits = new string(CH.Where(char.IsDigit).ToArray());
								string letters = new string(CH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (++number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								CH = newStr;
								Console.WriteLine("CH: " + CH);
							}
							break;

						case "4":
							{
								//do rozczesania bardziej 
								string digits = new string(DH.Where(char.IsDigit).ToArray());
								string letters = new string(DH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (++number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								DH = newStr;
								Console.WriteLine("DH: " + DH);
							}
							break;

						default:
							break;
					}
				}

				else if (option == "8")
				{
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz rejestr do dekrementacji: ");
					string firstRecord = Console.ReadLine();
					switch (firstRecord)
					{
						case "1":
							{
								string digits = new string(AH.Where(char.IsDigit).ToArray());
								string letters = new string(AH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (--number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								AH = newStr;
								Console.WriteLine("AH: " + AH);
							}
							break;

						case "2":
							{
								string digits = new string(BH.Where(char.IsDigit).ToArray());
								string letters = new string(BH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (--number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								BH = newStr;
								Console.WriteLine("BH: " + BH);
							}
							break;

						case "3":
							{
								string digits = new string(CH.Where(char.IsDigit).ToArray());
								string letters = new string(CH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (--number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								CH = newStr;
								Console.WriteLine("CH: " + CH);
							}
							break;

						case "4":
							{
								string digits = new string(DH.Where(char.IsDigit).ToArray());
								string letters = new string(DH.Where(char.IsLetter).ToArray());
								int number;
								if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
								{
									Console.WriteLine("Something weired happened");
								}

								string newStr = letters + (--number).ToString("D5");
								newStr = newStr.TrimStart('0');
								if (newStr.Length == 1)
								{
									newStr = "0" + newStr;
								}
								DH = newStr;
								Console.WriteLine("DH: " + DH);
							}
							break;

						default:
							break;
					}
				}

				else if (option == "9")
				{
					//Console.WriteLine("Dodawanie rejestru AH i BH");
					//Console.WriteLine("AH: " + AH + " BH: " + BH);
					//AH = "0" + AH;
					//BH = "0" + BH;
					//Console.WriteLine("AH: " + AH + " BH: " + BH);
					//BigInteger number1 = BigInteger.Parse(AH, NumberStyles.HexNumber);
					//BigInteger number2 = BigInteger.Parse(BH, NumberStyles.HexNumber);
					//BigInteger StringVal = number1 + number2;
					//BigInteger bi = StringVal;
					//int i = (int)bi;
					//int y = Int32.Parse(bi.ToString());								
					//Console.WriteLine(y);
					//string hexVal = string.Format("{0:x}", y);
					//Console.WriteLine("To daje po konwersji");
					//Console.WriteLine(hexVal);

					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz pierwszy rejestr: ");
					string firstRecord = Console.ReadLine();
					Console.Write("1 - AH, 2 - BH, 3 - CH, 4 - DH\nWybierz drugi rejestr: ");
					string secondRecord = Console.ReadLine();

					switch (firstRecord, secondRecord)
					{
						case ("1", "1"):
							BigInteger hexAH = BigInteger.Parse(AH, NumberStyles.HexNumber);
							BigInteger StringVal = hexAH + hexAH;
							BigInteger bi = StringVal;
							int i = (int)bi;
							int y = Int32.Parse(bi.ToString());
							string hexVal = string.Format("{0:x}", y);
							Console.WriteLine(hexVal);
							break;
						case ("1", "2"):
							BigInteger hexAH12 = BigInteger.Parse(AH, NumberStyles.HexNumber);
							BigInteger hexBH12 = BigInteger.Parse(BH, NumberStyles.HexNumber);
							BigInteger StringVal12 = hexAH12 + hexBH12;
							BigInteger bi12 = StringVal12;
							int i12 = (int)bi12;
							int y12 = Int32.Parse(bi12.ToString());
							string hexVal12 = string.Format("{0:x}", y12);
							Console.WriteLine(hexVal12);
							break;
						case ("1", "3"):
							BigInteger hexAH13 = BigInteger.Parse(AH, NumberStyles.HexNumber);
							BigInteger hexCH13 = BigInteger.Parse(BH, NumberStyles.HexNumber);
							BigInteger StringVal13 = hexAH13 + hexCH13;
							BigInteger bi13 = StringVal13;
							int i13 = (int)bi13;
							int y13 = Int32.Parse(bi13.ToString());
							string hexVal13 = string.Format("{0:x}", y13);
							Console.WriteLine(hexVal13);
							break;
						case ("1", "4"):
							BigInteger hexAH14 = BigInteger.Parse(AH, NumberStyles.HexNumber);
							BigInteger hexDH14 = BigInteger.Parse(BH, NumberStyles.HexNumber);
							BigInteger StringVal14 = hexAH14 + hexDH14;
							BigInteger bi14 = StringVal14;
							int i14 = (int)bi14;
							int y14 = Int32.Parse(bi14.ToString());
							string hexVal14 = string.Format("{0:x}", y14);
							Console.WriteLine(hexVal14);
							break;

						case ("2", "1"):
							BigInteger hexAH21 = BigInteger.Parse(AH, NumberStyles.HexNumber);
							BigInteger hexBH21 = BigInteger.Parse(BH, NumberStyles.HexNumber);
							BigInteger StringVal21 = hexAH21 + hexBH21;
							BigInteger bi21 = StringVal21;
							int i21 = (int)bi21;
							int y21 = Int32.Parse(bi21.ToString());
							string hexVal21 = string.Format("{0:x}", y21);
							Console.WriteLine(hexVal21);
							break;
						case ("2", "2"):
							BigInteger hexBH22 = BigInteger.Parse(BH, NumberStyles.HexNumber);
							BigInteger StringVal22 = hexBH22 + hexBH22;
							BigInteger bi22 = StringVal22;
							int i22 = (int)bi22;
							int y22 = Int32.Parse(bi22.ToString());
							string hexVal22 = string.Format("{0:x}", y22);
							Console.WriteLine(hexVal22);
							break;
						//case ("2", "3"):
						//	BigInteger hexAH13 = BigInteger.Parse(AH, NumberStyles.HexNumber);
						//	BigInteger hexCH13 = BigInteger.Parse(BH, NumberStyles.HexNumber);
						//	BigInteger StringVal13 = hexAH13 + hexCH13;
						//	BigInteger bi13 = StringVal13;
						//	int i13 = (int)bi13;
						//	int y13 = Int32.Parse(bi13.ToString());
						//	string hexVal13 = string.Format("{0:x}", y13);
						//	Console.WriteLine(hexVal13);
						//	break;
						//case ("2", "4"):
						//	BigInteger hexAH14 = BigInteger.Parse(AH, NumberStyles.HexNumber);
						//	BigInteger hexDH14 = BigInteger.Parse(BH, NumberStyles.HexNumber);
						//	BigInteger StringVal14 = hexAH14 + hexDH14;
						//	BigInteger bi14 = StringVal14;
						//	int i14 = (int)bi14;
						//	int y14 = Int32.Parse(bi14.ToString());
						//	string hexVal14 = string.Format("{0:x}", y14);
						//	Console.WriteLine(hexVal14);
						//	break;




						default:
							break;
					}
				}

				else if (option == "11")
				{
					Console.Clear();
					Console.WriteLine("Stan rejestrów:");
					Console.WriteLine("AH: " + AH + "\nBH: " + BH + "\nCH: " + CH + "\nDH: " + DH);
				}

				else if (option == "12")
					Console.Write("");
				else
					Console.WriteLine("Brak takiej opcji, powrót do wpisania rejestrów");

			} while (option != "10");
			Console.WriteLine("Dziękuję za skorzystanie z symuluacji procesora INTEL 8086");
			
		}

	}
}