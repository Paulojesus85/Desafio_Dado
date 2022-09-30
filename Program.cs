double face1 = 0;
double face2 = 0;
double face3 = 0;
double face4 = 0;
double face5 = 0;
double face6 = 0;


for (int contador = 1; contador < 301; contador++)
{
    Random rnd = new Random();
    int dice = rnd.Next(1, 7);

    if (dice == 1)
    {
        face1++;
    }
    else if (dice == 2)
    {
        face2++;
    }
    else if (dice == 3)
    {
        face3++;
    }
    else if (dice == 4)
    {
        face4++;
    }
    else if (dice == 5)
    {
        face5++;
    }
    else
    {
        face6++;
    }

}
double face1porcentagem = (face1 / 30) * 10;
double face2porcentagem = (face2 / 30) * 10;
double face3porcentagem = (face3 / 30) * 10;
double face4porcentagem = (face4 / 30) * 10;
double face5porcentagem = (face5 / 30) * 10;
double face6porcentagem = (face6 / 30) * 10;

Console.WriteLine($"Quantas vezes cada face caiu? Face 1 = {face1}, Face 2 = {face2}, Face 3 = {face3}, Face 4 = {face4}, Face 5 = {face5} e Face 6 = {face6}");

Console.WriteLine($"Porcentagem de cada face do dado em 30 tentativas \n" +
    $"Face 1 = {face1porcentagem.ToString("F")} % \n" +
    $"Face 2 = {face2porcentagem.ToString("F")} % \n" +
    $"Face 3 = {face3porcentagem.ToString("F")} % \n" +
    $"Face 4 = {face4porcentagem.ToString("F")} % \n" +
    $"Face 5 = {face5porcentagem.ToString("F")} % \n" +
    $"Face 6 = {face6porcentagem.ToString("F")} % \n");
