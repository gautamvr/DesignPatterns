namespace VisitorPattern;

internal interface IPlanningTool
{
    void Plan(DIImage image);
    void Plan(DXRImage image);
    void Plan(MRImage image);
    void Plan(CTImage image);

}