using System;
using System.Management;
using System.Windows.Forms;

namespace SendMessageBox
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_computerName.Text != "" && tb_userName.Text != "" && rtb_message.Text != "")
                SendMessage(tb_computerName.Text, tb_userName.Text, rtb_message.Text);
            else
                MessageBox.Show(@"Not null", @"Warning!");
        }

        public static void SendMessage(string remoteComputer, string userName, string message)
        {
            var commandLine = @"msg " + userName + @" /time:0 Message from: " + Environment.UserName +
                              Environment.NewLine + Environment.NewLine + message;

            var scope = new ManagementScope($@"\\{remoteComputer}\root\CIMV2");

            try
            {
                scope.Connect();
                var objectGetOptions = new ObjectGetOptions();
                var managementPath = new ManagementPath("Win32_Process");
                var managementClass = new ManagementClass(scope, managementPath, objectGetOptions);

                var inParams = managementClass.GetMethodParameters("Create");
                inParams["CommandLine"] = commandLine;
                var outParams = managementClass.InvokeMethod("Create", inParams, null);

                var isReturnValid = int.TryParse(outParams?["ReturnValue"].ToString(), out var returnValue);
                if (!isReturnValid || returnValue != 0)
                    throw new Exception();
            }

            catch (ManagementException me)
            {
                MessageBox.Show(me.ToString(), @"Error!");
            }
        }
    }
}