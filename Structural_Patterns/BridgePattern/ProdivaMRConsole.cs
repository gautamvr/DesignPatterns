namespace BridgePattern;

public class ProdivaMRConsole:BaseMRConsole
{
    public ProdivaMRConsole(IMRScanner scanner) : base(scanner)
    {
    }

    public override void PerformScan()
    {
        Console.WriteLine("\nPerforming scan in Prodiva console with different set of order");
        if (!_mrScanner.IsScanStarted)
        {
            _mrScanner.StartReconstruction();
            _mrScanner.StartScan();
        }
    }

    public override bool CheckScanStatus()
    {
        return _mrScanner.IsScanStarted;
    }

    public override void PerformPostProcessing()
    {
         _mrScanner.StartPostProc();
    }
}