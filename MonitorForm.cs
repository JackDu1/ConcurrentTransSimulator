using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConcurrentTransSimulator
{
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txbServer.Text = string.Empty;
            txbDatabase.Text = string.Empty;
            txbLogin.Text = string.Empty;
            txbDatabase.Text = string.Empty;
            cbPort.Text = string.Empty;
            txbPassword.Text = string.Empty;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txbServer.Text != string.Empty && txbDatabase.Text != string.Empty && txbLogin.Text != string.Empty)
            {
                
            }
            else
            {
                MessageBox.Show("Please make sure your Server name and login are not valid value!","Invalid Connection string",MessageBoxButtons.OK);
            }
        }

        public void addLine(string line, Color? c = null, bool? notime = true)
        {
            string msg;
            Color color = c ?? Color.Black;
            bool noTimestamp = notime ?? true;

            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => addLine(line, color, notime)));
            }
            else
            {
                msg = DateTime.Now.ToLongTimeString() + "-" + DateTime.Now.ToShortDateString() + "->>";
                msg = msg + line + "\n";
                
                Int32 maxsize = 1024000;
                Int32 dropsize = maxsize / 4;

                if (rtbMessage.Text.Length > maxsize)
                {
                    // this method preserves the text colouring
                    // find the first end-of-line past the endmarker

                    Int32 endmarker = rtbMessage.Text.IndexOf('\n', dropsize) + 1;
                    if (endmarker < dropsize)
                        endmarker = dropsize;

                    rtbMessage.Select(0, endmarker);
                    rtbMessage.Cut();
                }

                try
                {
                    // trap exception which occurs when processing
                    // as application shutdown is occurring

                    rtbMessage.SelectionStart = rtbMessage.Text.Length;
                    rtbMessage.SelectionLength = 0;
                    rtbMessage.AppendText(msg);
                    rtbMessage.SelectionColor = color;
                    Application.DoEvents();
                }
                catch (SystemException)
                {

                }
            }
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            rtbMessage.SelectionStart = rtbMessage.TextLength;
            rtbMessage.ScrollToCaret();
        }

        private void Simulator_Load(object sender, EventArgs e)
        {
            cbPort.Items.Add("1433");
            cbPort.SelectedIndex = 0;
        }
    }
}
