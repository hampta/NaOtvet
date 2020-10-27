// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.OnNewDocumentArgs
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using System;

namespace NaurokAnswers
{
  public class OnNewDocumentArgs : EventArgs
  {
    public int DocumentId { get; set; }

    public OnNewDocumentArgs(int documentId) => this.DocumentId = documentId;
  }
}
