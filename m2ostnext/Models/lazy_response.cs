﻿// Decompiled with JetBrains decompiler
// Type: m2ostnext.Models.lazy_response
// Assembly: m2ostnext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7AB5479F-6947-434C-859E-D38C2141B485
// Assembly location: E:\Vidit\Personal\Carl Ambrose\M2OST Code\m2ostproduction_cms\bin\m2ostnext.dll

using System.Collections.Generic;

namespace m2ostnext.Models
{
  public class lazy_response
  {
    public int sEcho { get; set; }

    public int iTotalRecords { get; set; }

    public int iTotalDisplayRecords { get; set; }

    public List<List<string>> aaData { get; set; }
  }
}
