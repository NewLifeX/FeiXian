using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using NewLife;
using NewLife.Log;
using NewLife.Reflection;
using NewLife.Serialization;
using NewLife.Web;
using XCode.Common;
using XCode.DataAccessLayer;
using XCode.Demo;

namespace FeiXian.Client
{
    public partial class FrmMain : Form
    {
        DAL Dal;
        DataSimulation _DS;

        #region 窗体
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(Object sender, EventArgs e)
        {
            txtReceive.UseWinFormControl();

            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            var asmx = AssemblyX.Entry;
            Text += " " + asmx.Compile.ToFullString();

            txtReceive.SetDefaultStyle(12);
            //numCount.SetDefaultStyle(12);

            gbReceive.Tag = gbReceive.Text;

            var cfg = Setting.Current;

            if (cfg.IsNew) "代码之巅，天外飞仙！".SpeechTip();

            // 加载保存的颜色
            UIConfig.Apply(txtReceive);

            LoadConfig();
        }
        #endregion

        #region 加载/保存 配置
        void LoadConfig()
        {
            var cfg = Setting.Current;
            mi显示应用日志.Checked = cfg.UseSql;
            mi显示编码日志.Checked = cfg.ShowEncoderLog;
            mi显示接收字符串.Checked = cfg.ShowReceiveString;
            mi显示发送数据.Checked = cfg.ShowSend;
            mi显示接收数据.Checked = cfg.ShowReceive;
            mi显示统计信息.Checked = cfg.ShowStat;
            miHexSend.Checked = cfg.HexSend;
            mi日志着色.Checked = cfg.ColorLog;

            numCount.Value = cfg.Times;
            numBatchSize.Value = cfg.BatchSize;
            numThreads.Value = cfg.Threads;
            chkUseSql.Checked = cfg.UseSql;

            cbConn.DataSource = DAL.ConnStrs.Keys.ToList();
        }

        void SaveConfig()
        {
            var cfg = Setting.Current;
            cfg.UseSql = mi显示应用日志.Checked;
            cfg.ShowEncoderLog = mi显示编码日志.Checked;
            cfg.ShowReceiveString = mi显示接收字符串.Checked;
            cfg.ShowSend = mi显示发送数据.Checked;
            cfg.ShowReceive = mi显示接收数据.Checked;
            cfg.ShowStat = mi显示统计信息.Checked;
            cfg.HexSend = miHexSend.Checked;

            cfg.Times = (Int32)numCount.Value;
            cfg.BatchSize = (Int32)numBatchSize.Value;
            cfg.Threads = (Int32)numThreads.Value;
            cfg.ColorLog = mi日志着色.Checked;
            cfg.UseSql = chkUseSql.Checked;

            cfg.Save();
        }
        #endregion

        #region 收发数据
        private void btnConnect_Click(Object sender, EventArgs e)
        {
            SaveConfig();

            if (btnConnect.Text == "打开")
            {
                var name = cbConn.Text;
                if (name.IsNullOrEmpty()) return;

                Dal = DAL.Create(name);
                XTrace.WriteLine("[{0}] [{1}] {2}", Dal.ConnName, Dal.DbType, Dal.ConnStr);

                _DS = new DataSimulation<DemoEntity>();

                pnlSetting.Enabled = false;
                pnlAction.Enabled = true;
                btnConnect.Text = "关闭";
            }
            else
            {
                _DS = null;

                pnlSetting.Enabled = true;
                pnlAction.Enabled = false;
                btnConnect.Text = "打开";
            }
        }

        Int32 _pColor = 0;
        private void timer1_Tick(Object sender, EventArgs e)
        {

            var cfg = Setting.Current;
            if (cfg.ColorLog) txtReceive.ColourDefault(_pColor);
            _pColor = txtReceive.TextLength;
        }
        #endregion

        #region 右键菜单
        private void mi清空_Click(Object sender, EventArgs e)
        {
            txtReceive.Clear();
        }

        private void mi清空2_Click(Object sender, EventArgs e)
        {
        }

        private void Menu_Click(Object sender, EventArgs e)
        {
            var mi = sender as ToolStripMenuItem;
            mi.Checked = !mi.Checked;

            SaveConfig();
        }
        #endregion

        #region 业务动作
        private void btnDbWrite_Click(Object sender, EventArgs e)
        {
            SaveConfig();

            var cfg = Setting.Current;
            XTrace.WriteLine("");

            DemoEntity.Meta.Table.ConnName = Dal.ConnName;
            DemoEntity.Meta.ConnName = Dal.ConnName;
            var ds = _DS;

            ds.Log = XTrace.Log;
            ds.BatchSize = cfg.BatchSize;
            ds.Threads = cfg.Threads;
            ds.UseSql = cfg.UseSql;

            btnDbWrite.Enabled = false;

            Task.Run(() =>
            {
                ds.Run(cfg.Times);

                this.Invoke(() => btnDbWrite.Enabled = true);

                SendScore(Dal.DbType + "_Insert", cfg.Times);
            });
        }

        private void SendScore(String type, Int32 count)
        {
            var ds = _DS;

            var nvs = new Dictionary<String, Object>();
            nvs[nameof(type)] = type;
            nvs["score"] = ds.Score;
            nvs["name"] = "{0}/{1}".F(Environment.UserName, Environment.MachineName);

            nvs["OS"] = Runtime.OSName;

            using (var reg = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0"))
            {
                nvs["Processor"] = (reg.GetValue("ProcessorNameString") + "").Trim();
                nvs["Frequency"] = reg.GetValue("~MHz").ToInt() + "";
            }
            nvs["Memory"] = Runtime.PhysicalMemory;

            nvs["Config"] = new { count, ds.Threads, ds.BatchSize, ds.UseSql }.ToJson();

            XTrace.WriteLine(nvs.ToJson(true));

            var client = new WebClientX(true, true);
            client.Log = XTrace.Log;
            client.UploadJsonAsync(Setting.Current.Address, nvs);
        }

        private void btnDelete_Click(Object sender, EventArgs e)
        {
            foreach (var item in ".".AsDirectory().GetAllFiles("*.db;*.db-shm;*.wal"))
            {
                item.Delete();
            }
        }
        #endregion

        private void btnTest_Click(Object sender, EventArgs e)
        {
            //var rs = await _Client.InvokeAsync<String[]>("Api/All");
            //XTrace.WriteLine(rs.Join(Environment.NewLine));
        }

        private void btnAdv_Click(Object sender, EventArgs e)
        {
            //var cfg = Setting.Current;
            //switch (cfg.Mode?.ToLower())
            //{
            //    case "user":
            //        new FrmUser { Client = _Client }.Show();
            //        break;
            //    case "device":
            //        new FrmDevice { Client = _Client }.Show();
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}