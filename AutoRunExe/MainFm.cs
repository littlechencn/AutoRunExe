using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoRunExe
{
    public partial class MainFm : Form
    {
        System.Timers.Timer myTimer;//定时器；

        public MainFm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 浏览目录按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_open_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择安装文件所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "扫描路径不能为空！", "提示");
                    return;
                }
                this.txtDir.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 开始扫描按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ok_Click(object sender, EventArgs e)
        {
            string exeDir = this.txtDir.Text;
            int intervalTime = (int)this.txtNum.Value;
            if (string.IsNullOrEmpty(exeDir))
            {
                MessageBox.Show(this, "扫描路径不能为空！", "提示");
                return;
            }
            if (intervalTime < 5 || intervalTime > 12000)
            {
                MessageBox.Show(this, "扫描间隔（s）不合法！（介于5s ~ 12000s）", "提示");
                return;
            }
            AutoRunObj myAutoRunObj = new AutoRunObj(exeDir, intervalTime);
            //myAutoRunObj.AutoRun();
            myTimer = new System.Timers.Timer(intervalTime * 1000);//实例化Timer类，设置间隔时间为intervalTime毫秒；
            myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myAutoRunObj.AutoRun);//间隔执行事件（委托）；
            myTimer.AutoReset = true;//执行一次（false）；一直执行(true)；
            myTimer.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            myTimer.Start();//开始执行；
        }

        /// <summary>
        /// 停止扫描按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (myTimer != null)
                {
                    myTimer.Stop();//停止执行；
                    myTimer.Dispose();//释放资源；
                    myTimer = null;
                }
                else
                {
                    MessageBox.Show(this, "扫描未开始！", "提示");
                    return;
                }
            }
            catch (Exception exp) { return; }
            MessageBox.Show(this, "已停止扫描！", "提示");
        }
    }
}
