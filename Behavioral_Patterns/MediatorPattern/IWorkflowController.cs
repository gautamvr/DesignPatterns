namespace MediatorPattern;

public interface IWorkflowController
{
    void UpdateScanState(string state);
    void StartScan(bool scanStarted);
    void StopScan(bool scanStopped);
}