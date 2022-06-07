namespace BridgePattern;

/// <summary>
/// Implementation interface
/// </summary>
public interface IMRScanner
{
    bool IsScanStarted { get; set; }

    void StartScan();

    void StopScan();

    void StartReconstruction();

    void StartPostProc();

}