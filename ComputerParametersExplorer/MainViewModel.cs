using System.Management;
using System.Text;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ComputerParametersExplorer;

/// <summary>
/// View Model for the Main Window
/// </summary>
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string _info;

    public MainViewModel()
    {
        LoadDeviceInfo();
    }
    
    /// <summary>
    /// Loads info about the device
    /// </summary>
    [RelayCommand]
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

        Info = sb.ToString();
    }

    [RelayCommand]
    private void Copy()
    {
        Clipboard.SetText(Info);
    }
    
    [RelayCommand]
    private void Close()
    {
        Application.Current.Shutdown();
    }
}