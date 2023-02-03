using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonitorControl
{
    enum VCPCode
    {
        InputSelect = 0x60,
        PowerMode = 0xD6,
    }

    enum InputSelect
    {
        DisplayPort_1 = 15,
        DisplayPort_2,
        HDMI_1,
        HDMI_2,
    }

    enum PowerMode
    {
        On = 1,
        Off = 4,
        BtnOff,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct PHYSICAL_MONITOR
    {
        public IntPtr hPhysicalMonitor;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szPhysicalMonitorDescription;
    }

    public class NativeAPI
    {
        public const int MONITORINFOF_PRIMARY = 1;

        [DllImport("DXVA2.dll")]
        extern public static bool DestroyPhysicalMonitors(int dwPhysicalMonitorArraySize, PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("DXVA2.dll")]
        extern public static bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, out int pdwNumberOfPhysicalMonitors);

        [DllImport("DXVA2.dll")]
        extern public static bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, int dwPhysicalMonitorArraySize, [Out] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("DXVA2.dll")]
        extern public static bool GetVCPFeatureAndVCPFeatureReply(IntPtr hMonitor, byte bVCPCode, out int pvct, out int pdwCurrentValue, out int pdwMaximumValue);

        [DllImport("DXVA2.dll")]
        extern public static bool SetVCPFeature(IntPtr hMonitor, byte bVCPCode, int dwNewValue);

        [DllImport("USER32.dll")]
        extern public static IntPtr MonitorFromWindow(IntPtr hwnd, int dwFlags);
    }
}
