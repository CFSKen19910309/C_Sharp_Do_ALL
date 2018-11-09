-----取得所有Process-----
Process[] pp = Process.GetProcesses();
-----不開啟第二個相同的軟體Process-----
Process process = Process.GetCurrentProcess();
foreach (Process p in Process.GetProcessesByName(process.ProcessName))
{
    if (p.Id != process.Id)
    {
        Application.Current.Shutdown();
        return;
    }
}
----------
