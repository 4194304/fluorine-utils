using System;
using System.Diagnostics;
static void RunTask(string file) {
  ProcessStartInfo startInfo = new ProcessStartInfo() {
    FileName = $"{file}",
  };
  Process proc = new Process() { StartInfo = startInfo, };
  proc.Start();
}
Console.WriteLine();
Console.WriteLine("1. Shutdown");
Console.WriteLine("2. Reboot");
Console.WriteLine("3. Logoff");
Console.WriteLine("4. Hibernate");
Console.WriteLine("5. Exit");
Console.Write("Select the action would you like to perform: ");
int input = Convert.ToInt32(Console.ReadLine());
switch(input) {
  case 1:
    RunTask("doas poweroff");
    break;
  case 2:
    RunTask("doas reboot");
    break;
  case 3:
    RunTask("killall openbox");
    break;
  case 4:
    RunTask("doas halt");
    break;
  case 5:
    break;
}
