using AutoRunExe.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutoRunExe
{
    /// <summary>
    /// AutoRun线程处理类；
    /// </summary>
    public class AutoRunObj
    {
        /// <summary>
        /// 扫描路径；
        /// </summary>
        public string exeDir;

        /// <summary>
        /// 扫描间隔；
        /// </summary>
        public int intervalTime;

        public AutoRunObj() { }

        /// <summary>
        /// 带参构造；
        /// </summary>
        /// <param name="exeDir">扫描路径</param>
        /// <param name="intervalTime">扫描间隔</param>
        public AutoRunObj(string exeDir, int intervalTime)
        {
            this.exeDir = exeDir;
            this.intervalTime = intervalTime;
        }

        /// <summary>
        /// 线程主体函数；
        /// </summary>
        public void AutoRun(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                //1、扫描文件列表；2、检测出新文件；3、拼接命令；4、执行命令；
                DirectoryInfo TheFolder = new DirectoryInfo(exeDir);
                string finalCmd = string.Empty;
                DateTime now = DateTime.Now;
                //1、扫描文件列表；
                foreach (FileInfo thisFile in TheFolder.GetFiles())
                {
                    DateTime creatTime = thisFile.CreationTime;
                    string fileType = thisFile.Extension;
                    //2、检测出新exe文件；
                    if (fileType == ".exe" && DateTimeUtils.ExecDateDiff(creatTime, now) <= (intervalTime + 2))
                    {
                        string fullPath = thisFile.FullName;
                        //3、拼接命令；
                        string thisCmd = "start /wait " + fullPath + " /S ";
                        finalCmd = finalCmd + thisCmd;
                    }
                }
                //4、执行命令；
                string execuResult = string.Empty;
                if (!string.IsNullOrEmpty(finalCmd))
                {
                    CmdUtils.RunCmd(finalCmd+" exit", out execuResult);
                }
                //Console.WriteLine(exeDir);
                return;
            }
            catch (Exception exp)
            {
                return;
            }
        }
    }
}
