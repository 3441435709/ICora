﻿//Copyright(c) XFP Group and Contributors. All rights reserved.
//Licensed under the MIT License.   

using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace XFP.Impact_Ultimate.Utlis
{
    [Serializable]
    public class YSAccount
    {
        public string Name { get; set; }

        public string MIHOYOSDK_ADL_PROD_CN_h3123967166 { get; set; }

        public string GENERAL_DATA_h2389025596 { get; set; }

        public static YSAccount ReadFromDisk(string name)
        {
            string p = Path.Combine(Environment.CurrentDirectory, "UserData", name);
            string json = File.ReadAllText(p);
            YSAccount acct = JsonConvert.DeserializeObject<YSAccount>(json);
            return acct;
        }

        public void WriteToDisk()
        {
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "UserData", Name), JsonConvert.SerializeObject(this));
        }

        public static void DeleteFromDisk(string name)
        {
            File.Delete(Path.Combine(Environment.CurrentDirectory, "UserData", name));
        }

        public static YSAccount ReadFromRegedit(bool needSettings)
        {
            YSAccount acct = new YSAccount();
            acct.MIHOYOSDK_ADL_PROD_CN_h3123967166 = GetStringFromRegedit("MIHOYOSDK_ADL_PROD_CN_h3123967166");
            if (needSettings)
            {
                acct.GENERAL_DATA_h2389025596 = GetStringFromRegedit("GENERAL_DATA_h2389025596");
            }
            return acct;
        }

        public void WriteToRegedit()
        {
            if (string.IsNullOrWhiteSpace(MIHOYOSDK_ADL_PROD_CN_h3123967166))
            {
                //保存账户内容为空
            }
            else
            {
                SetStringToRegedit("MIHOYOSDK_ADL_PROD_CN_h3123967166", MIHOYOSDK_ADL_PROD_CN_h3123967166);
                if (!string.IsNullOrWhiteSpace(GENERAL_DATA_h2389025596))
                {
                    SetStringToRegedit("GENERAL_DATA_h2389025596", GENERAL_DATA_h2389025596);
                }

            }
        }

        private static string GetStringFromRegedit(string key)
        {
            object value = Registry.GetValue(@"HKEY_CURRENT_USER\Software\miHoYo\原神", key, "");
            return Encoding.UTF8.GetString((byte[])value);
        }

        private static void SetStringToRegedit(string key, string value)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\miHoYo\原神", key, Encoding.UTF8.GetBytes(value));
        }
    }
}
