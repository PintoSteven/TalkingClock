using TalkingClock;

int Hour;
int Minute;
ConvertTimeToWords convertTime = new ConvertTimeToWords();
if (args.Length > 1)
{
    if (args[0].ToLower() != "print")
    {
        Console.WriteLine("Wrong Command");
    }
    var time = args[1].Split(":").Select(x => x.TrimStart('0')).ToList();
    if (!int.TryParse(time[0], out Hour) & !int.TryParse(time[1], out Minute))
    {
        Console.WriteLine("Wrong Time Input");
    }
}
else
{
    Hour = System.DateTime.Now.Hour;
    Minute = System.DateTime.Now.Minute;
}
Console.WriteLine(convertTime.ConvertToWords(Hour, Minute));
Console.ReadLine();
