namespace BridgePattern;

//Abstraction interfaces
public interface IMRConsole
{
    void PerformScan();

    bool CheckScanStatus ();

    void PerformPostProcessing();

}