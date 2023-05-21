Console.WriteLine("=-= Mes por Extenso =-=");

Console.Write("Digite um número de 1 a 12: ");
int numeroMes = int.Parse(Console.ReadLine()!);

string[] meses = {
    "Janeiro", "Fevereiro", "Março", "Abril",
    "Maio", "Junho", "Julho", "Agosto",
    "Setembro", "Outubro", "Novembro", "Dezembro"
};

string nomeMes = (numeroMes >= 1 && numeroMes <= 12) ? meses[numeroMes - 1] : "Mês inválido";

Console.WriteLine("O número {0} corresponde ao mês de {1}.", numeroMes, nomeMes);

