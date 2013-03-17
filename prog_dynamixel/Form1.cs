using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using D = ROBOTIS.dynamixel;

namespace prog_dynamixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; ++i)
            {
                if (D.dxl_initialize(i, 0) != 0)
                {
                    dxl_port = i;
                    D.dxl_terminate();
                    break;
                }
            }
            if (dxl_port == -1)
            {
                USBFailure();
                label1.Text = "USB2Dynbamixel not found";
            }
            else
            {
                label1.Text = "USB2Dynamixel found on port " + dxl_port.ToString();
                scanServo();
            }
        }

        int dxl_port = -1;
        int servoid = -1;
        int baud = -1;
        int timerbaud = -1;
        int timerid = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            scanServo();
        }

        private void scanServo()
        {
            servoid = -1;
            baud = -1;
            if (!timer1.Enabled)
            {
                if (!ping_range(34, 1, 1)
                    && !ping_range(0, 1, 1)
                    && !ping_range(1, 1, 1))
                {
                    timerbaud = 0;
                    timerid = 0;
                    timer1.Enabled = true;
                }
                else
                {
                    found();
                }
            }
        }

        private bool ping_range(int pingbaud, int lo, int hi)
        {
            if (pingbaud != baud)
            {
                if (baud != -1)
                {
                    D.dxl_terminate();
                }
                if (0 == D.dxl_initialize(dxl_port, pingbaud))
                {
                    USBFailure();
                    timer1.Enabled = false;
                    return false;
                }
                baud = pingbaud;
            }
            for (int i = lo; i <= hi; ++i)
            {
                D.dxl_ping(i);
                if (D.dxl_get_result() == D.COMM_RXSUCCESS)
                {
                    servoid = i;
                    baud = pingbaud;
                    return true;
                }
            }
            return false;
        }

        private void USBFailure()
        {
            label1.Text = "Failure communicating with USB2Dynamixel on port " + dxl_port.ToString();
            foreach (Control c in Controls)
            {
                if (c != label1)
                {
                    c.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (timerbaud < 0 || timerid < 0)
                {
                    throw new System.Exception("Invalid timer state");
                }
                if (timerid >= 32)
                {
                    timerid = 0;
                    switch (timerbaud)
                    {
                        case 0:
                            timerbaud = 1;
                            break;
                        case 1:
                            timerbaud = 34;
                            break;
                        default:
                            label2.Text = "no servo found";
                            timer1.Enabled = false;
                            timerbaud = -1;
                            timerid = -1;
                            return;
                    }
                }
                ++timerid;
                label2.Text = "Scanning ID " + timerid.ToString() + " baud " + timerbaud.ToString();
                if (ping_range(timerbaud, timerid, timerid))
                {
                    timerbaud = -1;
                    timerid = -1;
                    found();
                }
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void found()
        {
            label2.Text = "Servo ID " + servoid.ToString() + " baud " + baud.ToString();
            timer1.Enabled = false;
            servoActual.ID = servoid;
            servoActual.Baud = baud;
            servoActual.Shutdown = D.dxl_read_byte(servoid, 18);
            servoActual.Response = D.dxl_read_byte(servoid, 16);
            servoActual.Delay = D.dxl_read_byte(servoid, 5);
            if (servoDesired.ID == 1)
            {
                servoDesired.ID = servoActual.ID;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (servoid == -1)
            {
                MessageBox.Show("There is no servo to apply settings to. Try 'Scan' to find one.");
                return;
            }
            if (servoDesired.ID < 1 || servoDesired.ID > 254)
            {
                MessageBox.Show("The ID must be in the range [1..254]. Got " + servoDesired.ID.ToString());
                return;
            }
            if (servoDesired.Baud < 0 || servoDesired.Baud > 127)
            {
                MessageBox.Show("The baud rate must be in the range [0..127]. Got " + servoDesired.Baud.ToString());
                return;
            }
            if ((servoDesired.Shutdown & 4) == 0 || servoDesired.Shutdown < 0 || servoDesired.Shutdown > 255)
            {
                MessageBox.Show("The shutdown value must be in the range [0..255] and have the thermal (4) bit set. Got "
                    + servoDesired.Shutdown.ToString());
                return;
            }
            if (servoDesired.Delay < 0 || servoDesired.Delay > 254)
            {
                MessageBox.Show("The return delay must be in the range [0..254]. Got " + servoDesired.Delay.ToString());
                return;
            }
            if (servoActual.Response != servoDesired.Response)
            {
                D.dxl_write_byte(servoid, 16, servoDesired.Response);
                if (D.dxl_get_result() != D.COMM_TXSUCCESS && D.dxl_get_result() != D.COMM_RXTIMEOUT && D.dxl_get_result() != D.COMM_RXSUCCESS)
                {
                    MessageBox.Show("Error communicating with servo.");
                    return;
                }
                Thread.Sleep(250);
            }
            if (servoActual.Delay != servoDesired.Delay)
            {
                D.dxl_write_byte(servoid, 5, servoDesired.Delay);
                if (D.dxl_get_result() != D.COMM_TXSUCCESS && D.dxl_get_result() != D.COMM_RXTIMEOUT)
                {
                    MessageBox.Show("Error communicating with servo.");
                    return;
                }
                Thread.Sleep(250);
            }
            D.dxl_write_byte(servoid, 25, 1);
            if (servoActual.Shutdown != servoDesired.Shutdown)
            {
                D.dxl_write_byte(servoid, 18, servoDesired.Shutdown);
                if (D.dxl_get_result() != D.COMM_TXSUCCESS && D.dxl_get_result() != D.COMM_RXTIMEOUT)
                {
                    MessageBox.Show("Error communicating with servo.");
                    D.dxl_write_byte(servoid, 25, 0);
                    return;
                }
                Thread.Sleep(250);
            }
            if (servoid != servoDesired.ID)
            {
                D.dxl_write_byte(servoid, 3, servoDesired.ID);
                if (D.dxl_get_result() == D.COMM_TXSUCCESS || D.dxl_get_result() == D.COMM_RXTIMEOUT)
                {
                    servoid = servoDesired.ID;
                }
                else
                {
                    MessageBox.Show("Error communicating with servo.");
                    D.dxl_write_byte(servoid, 25, 0);
                    return;
                }
                Thread.Sleep(250);
            }
            if (baud != servoDesired.Baud)
            {
                D.dxl_write_byte(servoid, 4, servoDesired.Baud);
                D.dxl_terminate();
                baud = -1;
                Thread.Sleep(250);
                if (!ping_range(servoDesired.Baud, servoid, servoid))
                {
                    MessageBox.Show("Error communicating with servo.");
                    scanServo();
                    D.dxl_write_byte(servoid, 25, 0);
                    return;
                }
            }
            found();
            D.dxl_write_byte(servoid, 25, 0);
        }

        bool blinking = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (servoid != -1 && baud != -1)
            {
                blinking = !blinking;
                D.dxl_write_byte(servoid, 25, blinking ? 1 : 0);
                if (D.dxl_get_result() != D.COMM_TXSUCCESS && D.dxl_get_result() != D.COMM_RXTIMEOUT)
                {
                    scanServo();
                }
                D.dxl_ping(servoid);
                if (D.dxl_get_result() != D.COMM_RXSUCCESS)
                {
                    scanServo();
                }
            }
            else
            {
                scanServo();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servoid != -1 && baud != -1)
            {
                //  turn off LED if on
                D.dxl_write_byte(servoid, 25, 0);
            }
        }
    }
}
