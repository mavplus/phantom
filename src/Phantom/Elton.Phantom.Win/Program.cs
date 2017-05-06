﻿// Coded by chuangen http://chuangen.name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elton.Phantom.Win
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PhantomConfiguration config = PhantomConfiguration.Default;
            config.AppId = SecretKeys.Phantom606.AppId;
            config.AppSecret = SecretKeys.Phantom606.AppSecret;
            config.RedirectUri = SecretKeys.Phantom606.RedirectUri;
            config.UserAgent = "chuangen@live.cn/1.0.0 (Windows 8.1)";
            config.RequestInterval = 20 * 1000;

            Application.Run(new MainForm());
        }
    }
}
