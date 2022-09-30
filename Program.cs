double face1 = 0;
double face2 = 0;
double face3 = 0;
double face4 = 0;
double face5 = 0;
double face6 = 0;


for (int contador = 1; contador < 3000; contador++)
{
    Random rnd = new Random();
    int dice = rnd.Next(1, 100);

    if (dice >= 1 && dice < 13 )
    {
        face1++;
    }
    else if (dice >= 13 && dice < 26)
    {
        face2++;
    }
    else if (dice >= 26 && dice < 39)
    {
        face3++;
    }
    else if (dice >= 39 && dice < 52)
    {
        face4++;
    }
    else if (dice >= 52 && dice < 65)
    {
        face5++;
    }
    else
    {
        face6++;
    }

}
double face1porcentagem = (face1 / 3000) * 100;
double face2porcentagem = (face2 / 3000) * 100;
double face3porcentagem = (face3 / 3000) * 100;
double face4porcentagem = (face4 / 3000) * 100;
double face5porcentagem = (face5 / 3000) * 100;
double face6porcentagem = (face6 / 3000) * 100;

Console.WriteLine($"Quantas vezes cada face caiu? Face 1 = {face1}, Face 2 = {face2}, Face 3 = {face3}, Face 4 = {face4}, Face 5 = {face5} e Face 6 = {face6}");

Console.WriteLine($"Porcentagem de cada face do dado em 30 tentativas \n" +
    $"Face 1 = {face1porcentagem.ToString("F")} % \n" +
    $"Face 2 = {face2porcentagem.ToString("F")} % \n" +
    $"Face 3 = {face3porcentagem.ToString("F")} % \n" +
    $"Face 4 = {face4porcentagem.ToString("F")} % \n" +
    $"Face 5 = {face5porcentagem.ToString("F")} % \n" +
    $"Face 6 = {face6porcentagem.ToString("F")} % \n");
