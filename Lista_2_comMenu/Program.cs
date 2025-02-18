
using System;

namespace Lista_2_com_menu
{
	class Lista2_com_menu
	{
		private static int i;

		public static void Main(string[] args)
		{
			int sair = 1;
			int opcao = 0;

			while (sair == 1)
			{
				//menu

				Console.Clear();
				Console.WriteLine("============MENU DE SELEÇÃO=============");
				Console.Write("Escolha uma opção de 1 à 20: ");
				opcao = int.Parse(Console.ReadLine());
				Console.Clear();

				//seleção

				switch (opcao)
				{
					case 1:
						char nota;

						Console.WriteLine("Você escolheu a atividade 1: \nEscreva um programa em C# para aceitar uma nota e exibir a descrição equivalente:");

						Console.WriteLine("Notas            Descrição");
						Console.WriteLine("A                Excelente");
						Console.WriteLine("C                Muito Bom");
						Console.WriteLine("E                Bom");
						Console.WriteLine("F                Média");
						Console.WriteLine("G                Falhou");
						Console.WriteLine("");
						Console.WriteLine("\nDigite uma nota valida das opções acima.");
						nota = char.Parse(Console.ReadLine());

						switch (nota)
						{
							case 'A':
								Console.WriteLine("Excelente!!!");
								break;
							case 'C':
								Console.WriteLine("Muito Bom.");
								break;
							case 'E':
								Console.WriteLine("Bom.");
								break;
							case 'F':
								Console.WriteLine("Média.");
								break;
							case 'G':
								Console.WriteLine("Falhou!!!");
								break;

							default:
								Console.WriteLine("Digite uma nota valida!!!");
								break;
						}
						Console.ReadKey(true);
						break;
					case 2:

						Console.WriteLine("Você escolheu a atividade 2: \nEscreva um programa em C# para ler qualquer número de dia em inteiro e exibir o nome do dia na palavra.");
						char Dia;
						Console.WriteLine("");
						Console.WriteLine("Digite o numero de um Dia.");
						Dia = char.Parse(Console.ReadLine());
						switch (Dia)
						{
							case '1':
								Console.WriteLine("Domingo");
								break;
							case '2':
								Console.WriteLine("Segunda");
								break;
							case '3':
								Console.WriteLine("Terça");
								break;
							case '4':
								Console.WriteLine("Quarta");
								break;
							case '5':
								Console.WriteLine("Quinta");
								break;
							case '6':
								Console.WriteLine("Sexta");
								break;
							case '7':
								Console.WriteLine("Sabado");
								break;
							default:
								Console.WriteLine("Digite um numero valido!!!");
								break;
						}
						Console.ReadKey(true);
						break;

					case 3:

						Console.WriteLine("Você escolheu a atividade 3: \nEscreva um programa em C# para ler qualquer dígito e exibir em formato palavra.");

						int numero;

						Console.WriteLine("Digite numeros de 0 a 9:");
						numero = int.Parse(Console.ReadLine());

						switch (numero)
						{
							case 0:
								Console.WriteLine("\nZero");
								break;
							case 1:
								Console.WriteLine("\nUm");
								break;
							case 2:
								Console.WriteLine("\nDois");
								break;
							case 3:
								Console.WriteLine("\nTrês");
								break;
							case 4:
								Console.WriteLine("\nQuatro");
								break;
							case 5:
								Console.WriteLine("\nCinco");
								break;
							case 6:
								Console.WriteLine("\nSeis");
								break;
							case 7:
								Console.WriteLine("\nSete");
								break;
							case 8:
								Console.WriteLine("\nOito");
								break;
							case 9:
								Console.WriteLine("\nNove");
								break;
							default:
								Console.WriteLine("\nDigito inválido");
								break;
						}
						Console.ReadKey(true);
						break;


					case 4:


						Console.WriteLine("Você escolheu a atividade 4: \nEscreva um programa em C# para ler qualquer número do mês em inteiro e exibir o nome do mês em palavra.");
						Console.WriteLine("");
						Console.WriteLine("Digite o numero de um mês.");
						int mês;
						mês = int.Parse(Console.ReadLine());

						switch (mês)
						{
							case 1:
								Console.WriteLine("Janeiro");
								break;
							case 2:
								Console.WriteLine("Fevereiro");
								break;
							case 3:
								Console.WriteLine("Março");
								break;
							case 4:
								Console.WriteLine("Abril");
								break;
							case 5:
								Console.WriteLine("Maio");
								break;
							case 6:
								Console.WriteLine("Junho");
								break;
							case 7:
								Console.WriteLine("Julho");
								break;
							case 8:
								Console.WriteLine("Agosto");
								break;
							case 9:
								Console.WriteLine("Setmbro");
								break;
							case 10:
								Console.WriteLine("Outubro");
								break;
							case 11:
								Console.WriteLine("Novembro");
								break;
							case 12:
								Console.WriteLine("Dezembro");
								break;

							default:
								Console.WriteLine("Digite um numero valido!!!");
								break;
						}
						Console.ReadKey(true);
						break;

					case 5:
						int lado;
						float area;
						float B, A;
						do
						{
							Console.Clear();
							Console.WriteLine("Você selecionou a atividade 5:\nEscreva um programa em C# que seja um programa orientado por menus para calcular a área das várias formas geométricas.");
							Console.WriteLine("Escolha a forma geométrica para calcular a área:");
							Console.WriteLine("1 - Quadrado");
							Console.WriteLine("2 - Retângulo");
							Console.WriteLine("3 - Triângulo");
							Console.WriteLine("4 - Losango");
							Console.Write("Digite a opção: ");
							opcao = int.Parse(Console.ReadLine());

							switch (opcao)
							{
								case 1:
									Console.Write("Digite o lado do quadrado: ");
									lado = int.Parse(Console.ReadLine());
									Console.WriteLine("A área do quadrado é: {0} * {1} = {2}", lado, lado, lado * lado);
									break;

								case 2:
									Console.Write("Digite a Base do retângulo: ");
									A = float.Parse(Console.ReadLine());
									Console.Write("Digite a altura do retângulo: ");
									B = float.Parse(Console.ReadLine());
									area = A * B;
									Console.WriteLine("A área do retângulo é: {0} x {1} = {2}", B, A, B * A);
									break;

								case 3:
									Console.Write("Digite a base do triângulo: ");
									A = float.Parse(Console.ReadLine());
									Console.Write("Digite a altura do triângulo: ");
									B = float.Parse(Console.ReadLine());
									area = (A * B) / 2;
									Console.WriteLine("A área do triângulo é: {0} x {1} / 2 = {2}", B, A, (B * A) / (2));
									break;

								case 4:
									Console.Write("Digite a diagonal maior do Losango: ");
									A = float.Parse(Console.ReadLine());
									Console.Write("Digite a diagonal menor do Losango: ");
									B = float.Parse(Console.ReadLine());
									area = (A * B) / 2;
									Console.WriteLine("A área do losango é: {0} x {1} / 2 = {2}", B, A, (B * A) / (2));
									break;
								default:
									Console.WriteLine("Opção inválida! Tente novamente.");
									break;
							}
							Console.ReadKey(true);
						} while (opcao != 5);

						break;

					case 6:
						float num1, num2;
						do
						{
							Console.Clear();
							Console.WriteLine("Selecione uma operação matematica para ser efetuada:/nEscreva um programa em C# que seja um Programa Orientado por Menu para realizar cálculos simples(soma, subtração, multiplicação e divisão).");
							Console.WriteLine("1 - Adição");
							Console.WriteLine("2 - Subtração");
							Console.WriteLine("3 - Divisão");
							Console.WriteLine("4 - multiplicação ");
							Console.Write("Digite a opção: ");
							opcao = int.Parse(Console.ReadLine());

							switch (opcao)
							{
								case 1:
									Console.Write("Insira um numero para iniciar a soma:");
									num1 = int.Parse(Console.ReadLine());
									Console.Write("Insira outro numero para efetuar a soma:");
									num2 = int.Parse(Console.ReadLine());
									Console.WriteLine("O resultado da soma dos dois numeros é: {0} + {1} = {2}", num1, num2, num1 + num2);
									break;


								case 2:
									Console.Write("Insira um numero para iniciar a subitração:");
									num1 = float.Parse(Console.ReadLine());
									Console.Write("Insira outro numero para efetuar a subitração:");
									num2 = float.Parse(Console.ReadLine());
									Console.WriteLine("O resultado da subtração dos dois numeros é: {0} - {1} = {2}", num1, num2, num1 - num2);
									break;

								case 3:
									Console.Write("Insira um numero para iniciar a divisão:");
									num1 = float.Parse(Console.ReadLine());
									Console.Write("Insira outro numero para efetuar a divisão:");
									num2 = float.Parse(Console.ReadLine());
									Console.WriteLine("O resultado da divisão dos dois numeros é: {0} / {1} = {2}", num1, num1, num1 / num2);
									break;

								case 4:
									Console.Write("Insira um numero para iniciar a multiplicação:");
									num1 = float.Parse(Console.ReadLine());
									Console.Write("Insira um numero para iniciar a  multiplicação:");
									num2 = float.Parse(Console.ReadLine());
									Console.WriteLine("O resultado da multiplicação dos dois numeros é: {0} x {1}= {2}", num1, num2, num1 * num2);
									break;
								default:
									Console.WriteLine("Opção inválida! Tente novamente.");
									break;

							}
							Console.ReadKey(true);
						} while (opcao != 5);

						break;

					case 7:
						Console.WriteLine("Os 10 primeiros números naturais são:");
						int i = 1;
						while (i <= 10)
						{
							Console.Write(i + " ");
							i++;
						}
						break;
					case 8:

						Console.WriteLine("Você optou por cancelar");
						break;
					case 9:

						Console.WriteLine("Você optou por cancelar");
						break;

					case 10:
						Console.WriteLine("Você escolheu a atividade 10: \nEscreva um programa em C# para ler 10 números do teclado e encontrar sua soma e média.");
						int nume;
						float num = 0.0f, soma = 0.0f, media = 0.0f;
						for (i = 1; i <= 10; i++)
						{
							Console.WriteLine("\nDigite um numero {0}:", i);
							num = float.Parse(Console.ReadLine());
							soma += num;
						}

						Console.WriteLine("A soma de todos os 10 numeros é {0}", soma);
						media = soma / (i - 1);
						Console.WriteLine("A média de todos os 10 numeros é {0}", media);
						break;


					default:
						Console.WriteLine("Opção inválida. Tente novamente.");
						break;

				}

			}

			Console.ReadKey();
		}
	}
}

