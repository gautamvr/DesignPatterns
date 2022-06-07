namespace BridgePattern;

/// <summary>
/// Implementation interface
/// </summary>
public interface IMRScanner
{
    bool IsScanStarted { get; }

    void StartScan();

    void StopScan();

    void StartReconstruction();

    void StartPostProc();

}