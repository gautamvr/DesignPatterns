// See https://aka.ms/new-console-template for more information

using MediatorPattern;

Console.WriteLine("Mediator Pattern");
Console.WriteLine("Client Code");

var examcardComponent = new ExamcardsComponent();
var examdashboardComponent = new ExamDashboardComponent();
var planscanComponent = new PlanScanComponent();

var scanController = new ScanWorkflowController(examdashboardComponent, examcardComponent, planscanComponent);

planscanComponent.StartPlanning();
examcardComponent.ChangeExamcardState("ReadyToRun");
examdashboardComponent.StartScan();




