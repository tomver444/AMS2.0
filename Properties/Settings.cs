// Decompiled with JetBrains decompiler
// Type: AMS.Properties.Settings
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace AMS.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BuildingDB1.mdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [ApplicationScopedSetting]
    public string BuildingDB1ConnectionString
    {
      get => (string) this[nameof (BuildingDB1ConnectionString)];
      set => this[nameof (BuildingDB1ConnectionString)] = (object) value;
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Temp.mdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    public string TempConnectionString
    {
      get => (string) this[nameof (TempConnectionString)];
      set => this[nameof (TempConnectionString)] = (object) value;
    }

    [DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Staff_2007.accdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    public string Staff_2007ConnectionString
    {
      get => (string) this[nameof (Staff_2007ConnectionString)];
      set => this[nameof (Staff_2007ConnectionString)] = (object) value;
    }

    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\System_2007.accdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    public string System_2007ConnectionString
    {
      get => (string) this[nameof (System_2007ConnectionString)];
      set => this[nameof (System_2007ConnectionString)] = (object) value;
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BankingDB.accdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    public string BankingDBConnectionString
    {
      get => (string) this[nameof (BankingDBConnectionString)];
      set => this[nameof (BankingDBConnectionString)] = (object) value;
    }

    [ApplicationScopedSetting]
    [DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ErradjustDB.accdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    public string ErradjustDBConnectionString
    {
      get => (string) this[nameof (ErradjustDBConnectionString)];
      set => this[nameof (ErradjustDBConnectionString)] = (object) value;
    }

    [SpecialSetting(SpecialSetting.ConnectionString)]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ReplacementDB1.mdb;Persist Security Info=True;Jet OLEDB:Database Password=securitylock")]
    public string ReplacementDB1ConnectionString
    {
      get => (string) this[nameof (ReplacementDB1ConnectionString)];
      set => this[nameof (ReplacementDB1ConnectionString)] = (object) value;
    }
  }
}
