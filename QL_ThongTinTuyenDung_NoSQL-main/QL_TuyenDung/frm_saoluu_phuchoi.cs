using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Library;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QL_TuyenDung
{
    public partial class frm_saoluu_phuchoi : Form
    {
        string tenDatabase = "QL_Tuyendung";

        public frm_saoluu_phuchoi()
        {
            InitializeComponent();
        }

        private void frm_saoluu_phuchoi_Load(object sender, EventArgs e)
        {

        }

        private void BackupDatabase()
        {
            try
            {
                string cmdCommand = "mongodump --db " + tenDatabase + " --out D:/testMongo/";

                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = "cmd.exe";
                processInfo.Arguments = "/c " + cmdCommand;
                processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;
                processInfo.RedirectStandardOutput = true;
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardInput = true;

                Process process = new Process();
                process.StartInfo = processInfo;
                process.EnableRaisingEvents = true;

                process.OutputDataReceived += (sender, e) =>
                {
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        rtb_saoluu.Invoke((MethodInvoker)delegate
                        {
                            rtb_saoluu.AppendText(e.Data + Environment.NewLine);
                        });
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        rtb_saoluu.Invoke((MethodInvoker)delegate
                        {
                            rtb_saoluu.AppendText(e.Data + Environment.NewLine);
                        });
                    }
                };

                process.Exited += (sender, e) =>
                {
                    rtb_saoluu.Invoke((MethodInvoker)delegate
                    {
                        rtb_saoluu.AppendText("Backup process completed!" + Environment.NewLine);
                    });
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void RestoreDatabase()
        {
            try
            {
                string cmdCommand = "mongorestore --db " + tenDatabase + " D:/testMongo/" + tenDatabase + "/";

                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = "cmd.exe";
                processInfo.Arguments = "/c " + cmdCommand;
                processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;
                processInfo.RedirectStandardOutput = true;
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardInput = true;

                Process process = new Process();
                process.StartInfo = processInfo;
                process.EnableRaisingEvents = true;

                process.OutputDataReceived += (sender, e) =>
                {
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        rtb_phuchoi.Invoke((MethodInvoker)delegate
                        {
                            rtb_phuchoi.AppendText(e.Data + Environment.NewLine);
                        });
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        rtb_phuchoi.Invoke((MethodInvoker)delegate
                        {
                            rtb_phuchoi.AppendText(e.Data + Environment.NewLine);
                        });
                    }
                };

                process.Exited += (sender, e) =>
                {
                    rtb_phuchoi.Invoke((MethodInvoker)delegate
                    {
                        rtb_phuchoi.AppendText("Restore process completed!" + Environment.NewLine);
                    });
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_saoluu_Click(object sender, EventArgs e)
        {
            BackupDatabase();
        }

        private void btn_phuchoi_Click(object sender, EventArgs e)
        {
            RestoreDatabase();
        }
    }
}
