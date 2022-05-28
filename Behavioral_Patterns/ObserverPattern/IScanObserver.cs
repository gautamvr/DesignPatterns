namespace ObserverPattern;

public interface IScanObserver
{
    void OnScanCompleted(MRScanner mrScanner);
}