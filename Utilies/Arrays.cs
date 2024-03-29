﻿// Decompiled with JetBrains decompiler
// Type: Anubis.Arrays
// Assembly: Anubis Stealer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4CC1199D-65A9-4D34-AA4B-98216B1632A3
// Assembly location: C:\Users\Administrator\Downloads\Build.exe

using System;
using System.Text;

namespace Anubis
{
  public sealed class Arrays
  {
    private Arrays()
    {
    }

    public static bool AreEqual(bool[] a, bool[] b)
    {
      if (a == b)
        return true;
      return a != null && b != null && Arrays.HaveSameContents(a, b);
    }

    public static bool AreEqual(char[] a, char[] b)
    {
      if (a == b)
        return true;
      return a != null && b != null && Arrays.HaveSameContents(a, b);
    }

    public static bool AreEqual(byte[] a, byte[] b)
    {
      if (a == b)
        return true;
      return a != null && b != null && Arrays.HaveSameContents(a, b);
    }

    [Obsolete("Use 'AreEqual' method instead")]
    public static bool AreSame(byte[] a, byte[] b) => Arrays.AreEqual(a, b);

    public static bool ConstantTimeAreEqual(byte[] a, byte[] b)
    {
      int length = a.Length;
      if (length != b.Length)
        return false;
      int num = 0;
      while (length != 0)
      {
        --length;
        num |= (int) a[length] ^ (int) b[length];
      }
      return num == 0;
    }

    public static bool AreEqual(int[] a, int[] b)
    {
      if (a == b)
        return true;
      return a != null && b != null && Arrays.HaveSameContents(a, b);
    }

    private static bool HaveSameContents(bool[] a, bool[] b)
    {
      int length = a.Length;
      if (length != b.Length)
        return false;
      while (length != 0)
      {
        --length;
        if (a[length] != b[length])
          return false;
      }
      return true;
    }

    private static bool HaveSameContents(char[] a, char[] b)
    {
      int length = a.Length;
      if (length != b.Length)
        return false;
      while (length != 0)
      {
        --length;
        if ((int) a[length] != (int) b[length])
          return false;
      }
      return true;
    }

    private static bool HaveSameContents(byte[] a, byte[] b)
    {
      int length = a.Length;
      if (length != b.Length)
        return false;
      while (length != 0)
      {
        --length;
        if ((int) a[length] != (int) b[length])
          return false;
      }
      return true;
    }

    private static bool HaveSameContents(int[] a, int[] b)
    {
      int length = a.Length;
      if (length != b.Length)
        return false;
      while (length != 0)
      {
        --length;
        if (a[length] != b[length])
          return false;
      }
      return true;
    }

    public static string ToString(object[] a)
    {
      StringBuilder stringBuilder = new StringBuilder(91);
      if (a.Length != 0)
      {
        stringBuilder.Append(a[0]);
        for (int index = 1; index < a.Length; ++index)
          stringBuilder.Append(", ").Append(a[index]);
      }
      stringBuilder.Append(']');
      return stringBuilder.ToString();
    }

    public static int GetHashCode(byte[] data)
    {
      if (data == null)
        return 0;
      int length = data.Length;
      int num = length + 1;
      while (--length >= 0)
        num = num * 257 ^ (int) data[length];
      return num;
    }

    public static byte[] Clone(byte[] data) => data != null ? (byte[]) data.Clone() : (byte[]) null;

    public static int[] Clone(int[] data) => data != null ? (int[]) data.Clone() : (int[]) null;
  }
}
