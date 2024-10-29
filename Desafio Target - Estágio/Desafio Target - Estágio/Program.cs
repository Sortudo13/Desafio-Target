using Desafio_Target___Estágio;

Console.WriteLine("Escolha o exercício para rodar (1 a 5):");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Exercicio1.Executar();
        break;
    case 2:
        Exercicio2.Executar();
        break;
    case 3:
        Exercicio3.Executar();
        break;
    case 4:
        Exercicio4.Executar();
        break;
    case 5:
        Exercicio5.Executar();
        break;
    default:
        Console.WriteLine("Escolha não permitida!");
        break;
}