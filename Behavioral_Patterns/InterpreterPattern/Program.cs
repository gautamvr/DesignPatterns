// See https://aka.ms/new-console-template for more information

using InterpreterPattern;

Console.WriteLine("Hello, World!");

List<IDateFormatEvaluator> objExpressions = new List<IDateFormatEvaluator>();
DateContext dateContext = new DateContext(DateTime.Now);
Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
dateContext.Expression = Console.ReadLine();
string[] strArray = dateContext.Expression.Split(' ');
foreach (var item in strArray)
{
    if (item == "DD")
    {
        objExpressions.Add(new DayEvaluator());
    }
    else if (item == "MM")
    {
        objExpressions.Add(new MonthEvaluator());
    }
    else if (item == "YYYY")
    {
        objExpressions.Add(new YearEvalautor());
    }
}
objExpressions.Add(new SeperatorEvaluator());
foreach (var obj in objExpressions)
{
    obj.Evaluate(dateContext);
}

Console.WriteLine(dateContext.Expression);
