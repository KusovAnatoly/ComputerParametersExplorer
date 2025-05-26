using System.Management;
using System.Text;

namespace ComputerParametersExplorer.WinForms;

public partial class MainForm : Form
{
    private string _info = string.Empty;
    
    public MainForm()
    {
        InitializeComponent();
    }
    
    /// <summary>
    /// Loads info about the device
    /// </summary>
    private void LoadDeviceInfo()
    {
        StringBuilder sb = new StringBuilder();

        // CPU
        var cpuSearcher = new ManagementObjectSearcher("select * from Win32_Processor");
        var cpuList = cpuSearcher.Get();
        sb.AppendLine($"Количество процессоров: {cpuList.Count}");
        foreach (var o in cpuList)
        {
            var cpu = (ManagementObject)o;
            sb.AppendLine($"Модель: {cpu["Name"]}");
        }

        sb.AppendLine();

        // RAM
        var ramSearcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
        var ramList = ramSearcher.Get();
        sb.AppendLine($"Количество планок ОЗУ: {ramList.Count}");
        int index = 1;
        foreach (var ram in ramList)
        {
            var name = ram["Manufacturer"]?.ToString()?.Trim() ?? "Неизвестно";
            var capacityBytes = (ulong)ram["Capacity"];
            var capacityGb = capacityBytes / 1024.0 / 1024 / 1024;
            sb.AppendLine($"Планка {index++}: {name}, Объем: {capacityGb:F2} ГБ");
        }

        _info = sb.ToString();
        labelInfo.Text = _info;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void buttonCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(_info);
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        LoadDeviceInfo();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadDeviceInfo();
    }
}