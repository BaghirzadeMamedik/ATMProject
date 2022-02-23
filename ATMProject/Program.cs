using ATMProject.Methods;
using ATMProject.Models;

Calculate start = new Calculate();


Money money = new Money()
{
    Id = 1,
    Balans = 100M,
    Sifre = 0101
};

Evvele:
Console.WriteLine("1.Adinizi ve sifrenizi yazin:");
Console.WriteLine("2.Balansa baxin:");
Console.WriteLine("3.Menuya qayit:");
Console.WriteLine("4.Pul gonder:");


string daxilEdilenReqem = Console.ReadLine();

switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        Console.Clear();
        start.HereketeBasla(money);
        goto Evvele;
        break;
    case 2:

        Console.Clear();
        start.BalansiGoster(money);
        goto Evvele;
        break;
    case 3:
        Console.Clear();

        start.HesabDeyis(money);
        goto Evvele;
        break;
    case 4:

        Console.Clear();
        start.PulKocurme(money);
        goto Evvele;
        break;
}
