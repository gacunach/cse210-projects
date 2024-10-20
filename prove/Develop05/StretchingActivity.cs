public class StretchingActivity : Activity
{
    private List<string> _stretches = new List<string>
    {
        "Touch your toes.",
        "Stretch your arms overhead.",
        "Stretch your neck to the left and right.",
        "Do a quadriceps stretch by holding your foot behind you.",
        "Do a hamstring stretch by reaching for your toes while seated."
    };

    public StretchingActivity() : base("Stretching Activity", "This activity will guide you through different stretches. Hold each stretch for a few seconds and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int rounds = _duration / 10;
        for (int i = 0; i < rounds; i++)
        {
            string stretch = GetRandomStretch();
            Console.WriteLine(stretch);
            ShowCountdown(5); 
            Console.WriteLine("Switch to the next stretch...");
            ShowSpinner(3);
        }
        DisplayEndingMessage();
    }

    private string GetRandomStretch()
    {
        Random random = new Random();
        int index = random.Next(_stretches.Count);
        return _stretches[index];
    }
}