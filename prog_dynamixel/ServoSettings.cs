using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace prog_dynamixel
{
    public partial class ServoSettings : UserControl
    {
        public ServoSettings()
        {
            InitializeComponent();
        }

        string label = "Servo Info";

        [Description("Label at top")]
        [Category("Custom")]
        [Browsable(true)]
        public override string Text
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
                this.lblTitle.Text = value;
                OnTextChanged(EventArgs.Empty);
            }
        }

        [Description("ID of servo")]
        [Category("Custom")]
        [Browsable(true)]
        public int ID
        {
            get
            {
                return (int)numID.Value;
            }
            set
            {
                if (value == 0)
                {
                    numID.Value = 1;
                }
                else
                {
                    numID.Value = value;
                }
            }
        }

        [Description("Baud rate divider")]
        [Category("Custom")]
        [Browsable(true)]
        public int Baud
        {
            get
            {
                return (int)numBaud.Value;
            }
            set
            {
                numBaud.Value = value;
            }
        }

        [Description("Response delay in 2us units")]
        [Category("Custom")]
        [Browsable(true)]
        public int Delay
        {
            get
            {
                return (int)numDelay.Value;
            }
            set
            {
                numDelay.Value = value;
            }
        }

        [Description("Bit mask of events that shut down the servo")]
        [Category("Custom")]
        [Browsable(true)]
        public int Shutdown
        {
            get
            {
                int ret = -1;
                int.TryParse(txtShutdown.Text, out ret);
                return ret;
            }
            set
            {
                txtShutdown.Text = value.ToString();
            }
        }

        [Description("Response verbosity level")]
        [Category("Custom")]
        [Browsable(true)]
        public int Response
        {
            get
            {
                return (int)numResponse.Value;
            }
            set
            {
                numResponse.Value = value;
            }
        }

        private void txtShutdown_TextChanged(object sender, EventArgs e)
        {
            string s = txtShutdown.Text;
            if (Regex.IsMatch(s, "/[^0-9]/"))
            {
                txtShutdown.Text = Regex.Replace(s, "/[^0-9]/", "", RegexOptions.Multiline);
            }
        }

        private void ServoSettings_Load(object sender, EventArgs e)
        {
            lblTitle.Text = label;
        }
    }
}
