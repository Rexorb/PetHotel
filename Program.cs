/*
Faça um programa que receba dados de um pet ao dar entrada em um pet hotel. Exiba os dados ao final do cadastro, seguindo o exemplo.

+=========================================================+
|                 Pet Hotel "Nem um pio"                  |
+=========================================================+
| Espécie: ............CÃO | Raça: ............INDEFINIDA |
+=========================================================+
| Atende pela alcunha de: ...........................ZECA |
| Idade: 03 ano(s) | Pelagem/cor: ...............CARAMELO |
+=========================================================+


Use cores destacadas para o título e para os dados do pet, e cores neutras para as bordas.

*/

//Entrada de dados
Console.WriteLine("Olá bem vindo ao Pet Hotel");
Console.WriteLine("Digite a espécie do animal:");
String especieAnimal = Console.ReadLine();
Console.WriteLine("Digite a raça do animal:");
String racaAnimal = Console.ReadLine();
Console.WriteLine("Digite o nome do animal:");
String nomeAnimal = Console.ReadLine();
Console.WriteLine("Digite a idade do animal:");
String idadeAnimal = Console.ReadLine();
Console.WriteLine("Digite a cor do animal:");
String corAnimal = Console.ReadLine();




int larguraUtil = 10;
int larguraMetade = 10;
int larguraIdade = 10;
int larguraPelagem = 10 ;


Console.WriteLine("+===========================================================+");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|                 Pet Hotel: Nem um pio                    |");
Console.ResetColor();
Console.WriteLine("+===========================================================+");
        
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"| Espécie: {especieAnimal.PadRight(larguraMetade, '.')} | Raça: {racaAnimal.PadRight(larguraMetade, '.')} |");
Console.ResetColor();
Console.WriteLine("+===========================================================+");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"| Atende pela alcunha de: {nomeAnimal.PadRight(larguraUtil, '.')} |");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"| Idade: {idadeAnimal} anos".PadRight(larguraIdade, '.') + " | Pelagem/cor: " + corAnimal + " |");
Console.ResetColor();
Console.WriteLine("+===========================================================+");



