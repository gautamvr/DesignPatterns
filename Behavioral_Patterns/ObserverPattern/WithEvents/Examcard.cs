namespace ObserverPattern_withEvent;

public class Examcard
{
    private string _examcardIcon;

    public Examcard()
    {
        _examcardIcon = "NotCompletedIcon";
        var mrScanner = MRScanner.Instance;
        mrScanner.ScanCompleted += OnScanCompleted;
    }
    public void OnScanCompleted(object sender,EventArgs e)
    {
        Console.WriteLine($"Received in {this.GetType().Name}");

        ChangeExamcardIcon();
        Console.WriteLine($"The icon ID changed to {_examcardIcon}");
    }

    public void ChangeExamcardIcon()
    {
        _examcardIcon = "CompletedIcon";

    }
}