// Decompiled with JetBrains decompiler
// Type: AMS.Properties.Resources
// Assembly: AMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 99EBC956-E2B8-4955-9E76-E3E000435543
// Assembly location: C:\Users\Administrator\Desktop\birchridge\AMS 2017\AMS.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace AMS.Properties
{
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) AMS.Properties.Resources.resourceMan, (object) null))
          AMS.Properties.Resources.resourceMan = new ResourceManager("AMS.Properties.Resources", typeof (AMS.Properties.Resources).Assembly);
        return AMS.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => AMS.Properties.Resources.resourceCulture;
      set => AMS.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap Bitmap_Green
    {
      get
      {
        return (Bitmap) AMS.Properties.Resources.ResourceManager.GetObject(nameof (Bitmap_Green), AMS.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap COM_Green
    {
      get
      {
        return (Bitmap) AMS.Properties.Resources.ResourceManager.GetObject(nameof (COM_Green), AMS.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap COM_RED
    {
      get
      {
        return (Bitmap) AMS.Properties.Resources.ResourceManager.GetObject(nameof (COM_RED), AMS.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap COM_YELLOW
    {
      get
      {
        return (Bitmap) AMS.Properties.Resources.ResourceManager.GetObject(nameof (COM_YELLOW), AMS.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap pdf_picture
    {
      get
      {
        return (Bitmap) AMS.Properties.Resources.ResourceManager.GetObject(nameof (pdf_picture), AMS.Properties.Resources.resourceCulture);
      }
    }
  }
}
