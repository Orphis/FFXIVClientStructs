using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Network;
using FFXIVClientStructs.FFXIV.Client.System.Configuration;
using FFXIVClientStructs.FFXIV.Client.System.File;
using FFXIVClientStructs.FFXIV.Client.System.Input;
using FFXIVClientStructs.FFXIV.Client.System.Timer;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Common.Component.BGCollision;
using FFXIVClientStructs.FFXIV.Common.Lua;
using FFXIVClientStructs.FFXIV.Component.Excel;
using FFXIVClientStructs.FFXIV.Component.Exd;

namespace FFXIVClientStructs.FFXIV.Client.System.Framework;
// Client::System::Framework::Framework

// size=0x35C8
// ctor E8 ?? ?? ?? ?? 48 8B C8 48 89 05 ?? ?? ?? ?? EB 0A 48 8B CE 
[StructLayout(LayoutKind.Explicit, Size = 0x35C8)]
public unsafe partial struct Framework {
    [FieldOffset(0x0010)] public SystemConfig SystemConfig;
    [FieldOffset(0x0460)] public DevConfig DevConfig;
    [FieldOffset(0x0570)] public SavedAppearanceManager* SavedAppearanceData;
    [FieldOffset(0x0580)] public byte ClientLanguage;
    [FieldOffset(0x0588)] public Cursor* Cursor;

    [FieldOffset(0x0598)] public FileAccessPath ConfigPath;
    [FieldOffset(0x07A8)] public GameWindow* GameWindow;
    //584 byte
    [FieldOffset(0x09F8)] public int CursorPosX;
    [FieldOffset(0x09FC)] public int CursorPosY;

    [FieldOffset(0x1104)] public int CursorPosX2;
    [FieldOffset(0x1108)] public int CursorPosY2;

    [FieldOffset(0x1670)] public NetworkModuleProxy* NetworkModuleProxy;
    [FieldOffset(0x1678)] public bool IsNetworkModuleInitialized;
    [FieldOffset(0x1679)] public bool EnableNetworking;
    [FieldOffset(0x1680)] public long ServerTime;  // TODO: change to uint
    [FieldOffset(0x1688)] public long PerformanceCounterInMilliSeconds;
    [FieldOffset(0x1688)] public long PerformanceCounterInMicroSeconds;
    [FieldOffset(0x1698)] public uint TimerResolutionMillis;
    [FieldOffset(0x16A0)] public long PerformanceCounterFrequency;
    [FieldOffset(0x16A8)] public long PerformanceCounterValue;
    [FieldOffset(0x16F8)] public TaskManager TaskManager;
    [FieldOffset(0x16B8)] public float FrameDeltaTime;
    [FieldOffset(0x16C8)] public uint FrameCounter;
    [FieldOffset(0x1768)] public ClientTime ClientTime;
    [FieldOffset(0x1770), Obsolete("Use ClientTime.EorzeaTime")] public long EorzeaTime;
    [FieldOffset(0x1798), Obsolete("Use ClientTime.EorzeaTimeOverride")] public long EorzeaTimeOverride;
    [FieldOffset(0x17A0), Obsolete("Use ClientTime.IsEorzeaTimeOverridden")] public bool IsEorzeaTimeOverridden;
    [FieldOffset(0x17C4)] public float FrameRate;
    [FieldOffset(0x17D0)] public bool WindowInactive;

    [FieldOffset(0x19EC)] private fixed char gamePath[260];
    [FieldOffset(0x1DFC)] private fixed char sqPackPath[260];
    [FieldOffset(0x220C)] private fixed char savePath[260];

    [FieldOffset(0x2B30)] public ExcelModuleInterface* ExcelModuleInterface;
    [FieldOffset(0x2B38)] public ExdModule* ExdModule;
    [FieldOffset(0x2B50)] public BGCollisionModule* BGCollisionModule;
    [FieldOffset(0x2B60)] public UIModule* UIModule;
    [FieldOffset(0x2B68)] public UIClipboard* UIClipboard;
    [FieldOffset(0x2BC8)] public LuaState LuaState;

    [FieldOffset(0x2BF0)] public GameVersion GameVersion;

    [FieldOffset(0x35C0)] public void* SteamApiLibrary;

    [StaticAddress("44 0F B6 C0 48 8B 0D ?? ?? ?? ??", 7, true)]
    public static partial Framework* Instance();

    [MemberFunction("E8 ?? ?? ?? ?? 80 7B 1D 01")]
    public partial UIModule* GetUiModule();

    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B 44 24 ?? 48 8B C8 48 8B D3")]
    public partial UIClipboard* GetUIClipboard();

    [MemberFunction("80 B9 ?? ?? ?? ?? 00 74 ?? 48 8B 81 ?? ?? ?? ?? C3")]
    public partial NetworkModuleProxy* GetNetworkModuleProxy();

    [MemberFunction("E8 ?? ?? ?? ?? 89 47 2C")]
    public static partial long GetServerTime();

    [Obsolete("Use SavePath")]public string UserPath => SavePath;
    public string GamePath 
        { 
        get{
         fixed (char* p = gamePath)
                    return new string(p);
        }
    }
    public string SqPackPath 
        { 
        get{
         fixed (char* p = sqPackPath)
                    return new string(p);
        }
    }
    public string SavePath 
        { 
        get{
         fixed (char* p = savePath)
                    return new string(p);
        }
    }
}
