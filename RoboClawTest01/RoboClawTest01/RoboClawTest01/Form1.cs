using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboclawClassLib;
using System.Diagnostics;

namespace RoboClawTest01
{
    public partial class Form1 : Form
    {
        private Roboclaw roboClaw;
        private string roboClawModel;
        int m1_count, m2_count;
        bool encoderWatch = false;
                
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        //Import SlimDX
        SlimDX.XInput.Controller m_con = new SlimDX.XInput.Controller(SlimDX.XInput.UserIndex.One);
        byte accel_value;
        
        public Form1()
        {
            InitializeComponent();
            roboClaw = new Roboclaw();

            myTimer.Tick += new EventHandler(TimerEventProcessor);  // Timer event and handler
            myTimer.Interval = 25; // Timer interval is 25 milliseconds
        
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!roboClaw.IsOpen())
            {
                roboClaw.Open("AUTO", ref roboClawModel, 128, 38400); // Open the interface to the RoboClaw
                labelRoboClawModel.Text = roboClawModel; // Display the RoboClaw device model number
                roboClaw.ResetEncoders();
                buttonConnect.Enabled = false;
                buttonGoForward.Enabled = true;
                buttonGoReverse.Enabled = true;
                buttonDisconnect.Enabled = true;
                buttonGoRight.Enabled = true;
                buttonGoLeft.Enabled = true;
                con_timer1.Start();
            }
        }

        private void buttonGoForward_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                roboClaw.ST_M1Forward(50); // Start the motor going forward at power 100
                roboClaw.ST_M2Forward(50);

                myTimer.Start(); // Start timer to show encoder ticks

                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonGoRight.Enabled = false;
                buttonGoLeft.Enabled = false;
            }
        }

        private void buttonGoReverse_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                roboClaw.ST_M1Backward(50); // Start the motor going forward at power 100
                roboClaw.ST_M2Backward(50);

                myTimer.Start(); // Start timer to show encoder ticks

                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonGoRight.Enabled = false;
                buttonGoLeft.Enabled = false;
            }
        }

        private void buttonGoRight_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                roboClaw.ST_M1Backward(50); // Start the motor going forward at power 100
                roboClaw.ST_M2Forward(50);

                myTimer.Start(); // Start timer to show encoder ticks

                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonGoRight.Enabled = false;
                buttonGoLeft.Enabled = false;
            }
        }

        private void buttonGoLeft_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                roboClaw.ST_M1Forward(50); // Start the motor going forward at power 100
                roboClaw.ST_M2Backward(50);

                myTimer.Start(); // Start timer to show encoder ticks

                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonGoRight.Enabled = false;
                buttonGoLeft.Enabled = false;
            }
        }

        private void buttonGoToZero_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                encoderWatch = true;
                myTimer.Start(); // Start timer to show encoder ticks
                if (m1_count > 0)
                {
                    roboClaw.ST_M1Backward(50);
                    roboClaw.ST_M2Backward(50);// Start the motor going forward at power 100
                }
                else if (m1_count < 0)
                {
                    roboClaw.ST_M1Forward(50);
                    roboClaw.ST_M2Forward(50);// Start the motor going forward at power 100
                }

                buttonStop.Enabled = true;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonGoRight.Enabled = false;
                buttonGoLeft.Enabled = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                roboClaw.ST_M1Forward(0); // Stop the motor
                roboClaw.ST_M2Forward(0);
                myTimer.Stop(); // Stop timer to stop encoder updates
                buttonStop.Enabled = false;
                buttonGoForward.Enabled = true;
                buttonGoReverse.Enabled = true;
                buttonDisconnect.Enabled = true;
                buttonGoRight.Enabled = true;
                buttonGoLeft.Enabled = true;
                if (Math.Abs(m1_count) > 10)
                {
                    buttonGoToZero.Enabled = true;
                }
                encoderWatch = false;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                myTimer.Stop(); // Stop the timer to stop the encoder display updates
                roboClaw.Close(); // Close the RoboClaw interface
                labelRoboClawModel.Text = " "; // Clear the RoboClaw device model number display
                buttonStop.Enabled = false;
                buttonGoForward.Enabled = false;
                buttonGoReverse.Enabled = false;
                buttonGoToZero.Enabled = false;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                buttonGoRight.Enabled = false;
                buttonGoLeft.Enabled = false;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (roboClaw.IsOpen())
            {
                roboClaw.ST_M1Forward(0); // Stop the motor
                roboClaw.ST_M2Forward(0);
                roboClaw.Close(); // Close the interface
                myTimer.Stop(); // Stop the timer to stop the encoder display updates
                con_timer1.Stop();
            }
        }

        private void con_timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var state = m_con.GetState();
                if (m_con.IsConnected)
                {
                    myTimer.Stop();
                    //Stop timer to stop encoder updates
                    buttonStop.Enabled = true;
                    buttonGoForward.Enabled = false;
                    buttonGoReverse.Enabled = false;
                    buttonGoToZero.Enabled = false;
                    buttonDisconnect.Enabled = false;
                    buttonGoRight.Enabled = false;
                    buttonGoLeft.Enabled = false;

                    encoderWatch = false;

                    if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.Y))
                    {
                        accel_value += 10;
                        if (accel_value > 100) { accel_value = 100; }
                    }
                    else if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.A))
                    {
                        accel_value -= 10;
                        if (accel_value < 0) { accel_value = 0; }
                    }
                    else if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.DPadDown))
                    {
                        roboClaw.ST_M1Backward(accel_value); // Start the motor going forward at power 100
                        roboClaw.ST_M2Backward(accel_value);
                    }
                    else if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.DPadUp))
                    {
                        roboClaw.ST_M1Forward(accel_value); // Start the motor going forward at power 100
                        roboClaw.ST_M2Forward(accel_value);
                    }
                    else if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.DPadLeft))
                    {
                        roboClaw.ST_M1Forward(accel_value); // Start the motor going forward at power 100
                        roboClaw.ST_M2Backward(accel_value);
                    }
                    else if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.DPadRight))
                    {
                        roboClaw.ST_M1Backward(accel_value); // Start the motor going forward at power 100
                        roboClaw.ST_M2Forward(accel_value);
                    }
                    else if (state.Gamepad.Buttons.HasFlag(SlimDX.XInput.GamepadButtonFlags.X))
                    {
                        roboClaw.ST_M1Forward(0); // Start the motor going forward at power 100
                        roboClaw.ST_M2Forward(0);
                    }
                    else
                    {
                        if ( 0 < state.Gamepad.LeftThumbY  )
                        {
                            Int32 val =(int)(((float)(state.Gamepad.LeftThumbY) / (float)32768) * 100);
                            roboClaw.ST_M1Forward((byte)val);
                        }
                        else if(0 > state.Gamepad.LeftThumbY)
                        {
                            Int32 val = (int)((-(float)(state.Gamepad.LeftThumbY) / (float)32768) * 100);
                            roboClaw.ST_M1Backward((byte)val);
                        }
                        if ( 0 < state.Gamepad.RightThumbY)
                        {
                            Int32 val = (int)(((float)(state.Gamepad.RightThumbY) / (float)32768) * 100);
                            roboClaw.ST_M2Forward((byte)val);
                        }
                        else if (0 > state.Gamepad.RightThumbY)
                        {
                            Int32 val = (int)((-(float)(state.Gamepad.RightThumbY) / (float)32768) * 100);
                            roboClaw.ST_M2Backward((byte)val);
                        }
                    }
                  
                }
            }
            catch { }

        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            roboClaw.GetEncoders(out m1_count, out m2_count);
            labelTicksCount.Text = m1_count.ToString();
            if (encoderWatch)
            {
                if (Math.Abs(m1_count) < 10)
                {
                    roboClaw.ST_M1Forward(0);
                    roboClaw.ST_M1Forward(0);
                    myTimer.Stop(); // Stop timer to stop encoder updates
                    buttonStop.Enabled = false;
                    buttonGoForward.Enabled = true;
                    buttonGoReverse.Enabled = true;
                    buttonGoToZero.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    buttonGoRight.Enabled = true;
                    buttonGoLeft.Enabled = true;
                    if (Math.Abs(m1_count) > 10)
                    {
                        buttonGoToZero.Enabled = true;
                    }
                    encoderWatch = false;
                }
                else if (Math.Abs(m1_count) < 100)
                {
                    if (m1_count < 0)
                    {
                        roboClaw.ST_M1Forward(14);
                        roboClaw.ST_M2Forward(14);
                    }
                    else
                    {
                        roboClaw.ST_M1Backward(14);
                        roboClaw.ST_M2Forward(14);
                    }
                }
                else if (Math.Abs(m1_count) < 250)
                {
                    if (m1_count < 0)
                    {
                        roboClaw.ST_M1Forward(20);
                        roboClaw.ST_M2Forward(20);
                    }
                    else
                    {
                        roboClaw.ST_M1Backward(20);
                        roboClaw.ST_M2Backward(20);
                    }
                }
                else if (Math.Abs(m1_count) < 1000)
                {
                    if (m1_count < 0)
                    {
                        roboClaw.ST_M1Forward(30);
                        roboClaw.ST_M2Forward(30);
                    }
                    else
                    {
                        roboClaw.ST_M1Backward(30);
                        roboClaw.ST_M2Backward(30);
                    }
                }
            }
        }
                
    }
}
