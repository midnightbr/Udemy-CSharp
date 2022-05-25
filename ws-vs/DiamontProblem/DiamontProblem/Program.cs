using DiamontProblem.Entities;

Printer printer = new Printer() { SerialNumber = 1080 };
printer.ProcessDoc("My letter");
printer.Print("My letter");

Scanner scanner = new Scanner() { SerialNumber = 2003 };
scanner.ProcessDoc("My Email");
Console.WriteLine(scanner.Scan());

ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3921 };
comboDevice.ProcessDoc("My dissertation");
comboDevice.Print("My dissertation");
Console.WriteLine(comboDevice.Scan());