using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using HslCommunication.LogNet;
using static WY_App.Utility.Parameters;

namespace WY_App.Utility
{
    /// <summary>
    /// Fatal级别的日志由系统全局抓取
    /// </summary>
    
    public class LogHelper
    {
        public static ILogNet Log = new LogNetSingle(Application.StartupPath + "\\Logs\\"+System.DateTime.Now.ToString("yyyyMMddHH")+".txt");
    }
}