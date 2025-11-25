using System.Collections.ObjectModel;

Collection<int> timePerKm = new Collection<int>();


GetData();

Console.Write("Podaj jakiej wielkości najlepszego odcinka szukasz (w km): ");
int segmentLength = int.Parse(Console.ReadLine());

int best = BestSegmentTime(timePerKm, segmentLength);

Console.WriteLine($"Najlepszy czas na {segmentLength}km odcinku wynosi: {best}");


void GetData()
{
    Console.Write("Ile km przebiegłeś: ");
    int distance = int.Parse(Console.ReadLine());

    Console.WriteLine("Podaj czasy na każdym kilometrze:");

    for (int i = 0; i < distance; i++)
        timePerKm.Add(int.Parse(Console.ReadLine()));
}

int BestSegmentTime(Collection<int> times, int segment)
{
    int best = int.MaxValue;

    for (int i = 0; i <= times.Count - segment; i++)
    {
        int sum = 0;

        for (int j = 0; j < segment; j++)
            sum += times[i + j];

        if (sum < best)
            best = sum;
    }

    return best;
}