﻿//Copyright(c) XFP Group and Contributors. All rights reserved.
//Licensed under the MIT License.

using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using HandyControl.Controls;

namespace XFP.Impact_Ultimate.Controls
{
    /// <summary>
    /// AboutUs.xaml 的交互逻辑
    /// </summary>
    public partial class AboutUs : UserControl
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void GetICora_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gitee.com/XFP-Group/Impact_Ultimate/");
        }

        private void GetICora_Github_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/GashByte/ICora");
        }

        private void ContentUs_Click(object sender, RoutedEventArgs e)
        {
            Growl.Info("通过QQ联系作者 作者QQ以及被复制到粘贴板上咯");
            Clipboard.SetDataObject("542129425");
        }

        private void PrivacyPolicy_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gitee.com/MasterGashByte/impact_ultimate_issues/blob/master/PrivacyPolicy.md");
        }

        private void UserUseAgreement_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gitee.com/MasterGashByte/impact_ultimate_issues/blob/master/UserUseAgreement.md");
        }

        private void FeedBackQ_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gitee.com/MasterGashByte/impact_ultimate_issues/issues");
        }

        private void ICoraIndex_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://gashbyte.github.io/ICoraIndex/");
        }

        private void afadian_Click(object sender, RoutedEventArgs e)
        {
            Growl.Clear();
            Growl.Info("感谢支持 但不支持 UwU");
            //Process.Start("explorer.exe", "https://afdian.net/a/XFP-Group");
        }
    }
}
