namespace BridgePattern;

public class IngeniaConsole:BaseMRConsole
{
    public IngeniaConsole(IMRScanner scanner) : base(scanner)
    {
    }

    public override void PerformScan()
    {
        if (_mrScanner.IsScanStarted)
        {
            _mrScanner.StartScan();;
            _mrScanner.StartReconstruction();
            
        }
    }

    public override void PerformPostProcessing()
    {
        if (!_mrScanner.IsScanStarted)
        {
            _mrScanner.StopScan();
            _mrScanner.StartPostProc();
        }
    }

    public override bool CheckScanStatus()
    {
        return _mrScanner.IsScanStarted;
    }
}