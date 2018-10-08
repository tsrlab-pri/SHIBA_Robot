namespace RoboClawTest01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonGoForward = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelModelTitle = new System.Windows.Forms.Label();
            this.labelRoboClawModel = new System.Windows.Forms.Label();
            this.labelTicks = new System.Windows.Forms.Label();
            this.labelTicksCount = new System.Windows.Forms.Label();
            this.buttonGoReverse = new System.Windows.Forms.Button();
            this.buttonGoToZero = new System.Windows.Forms.Button();
            this.buttonGoRight = new System.Windows.Forms.Button();
            this.buttonGoLeft = new System.Windows.Forms.Button();
            this.con_timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(17, 15);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 27);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(16, 233);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 27);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonGoForward
            // 
            this.buttonGoForward.Enabled = false;
            this.buttonGoForward.Location = new System.Drawing.Point(17, 50);
            this.buttonGoForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGoForward.Name = "buttonGoForward";
            this.buttonGoForward.Size = new System.Drawing.Size(100, 27);
            this.buttonGoForward.TabIndex = 2;
            this.buttonGoForward.Text = "Go Forward";
            this.buttonGoForward.UseVisualStyleBackColor = true;
            this.buttonGoForward.Click += new System.EventHandler(this.buttonGoForward_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(16, 266);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(100, 27);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelModelTitle
            // 
            this.labelModelTitle.AutoSize = true;
            this.labelModelTitle.Location = new System.Drawing.Point(128, 21);
            this.labelModelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelTitle.Name = "labelModelTitle";
            this.labelModelTitle.Size = new System.Drawing.Size(47, 15);
            this.labelModelTitle.TabIndex = 4;
            this.labelModelTitle.Text = "Model:";
            // 
            // labelRoboClawModel
            // 
            this.labelRoboClawModel.AutoSize = true;
            this.labelRoboClawModel.Location = new System.Drawing.Point(188, 21);
            this.labelRoboClawModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoboClawModel.Name = "labelRoboClawModel";
            this.labelRoboClawModel.Size = new System.Drawing.Size(12, 15);
            this.labelRoboClawModel.TabIndex = 5;
            this.labelRoboClawModel.Text = " ";
            // 
            // labelTicks
            // 
            this.labelTicks.AutoSize = true;
            this.labelTicks.Location = new System.Drawing.Point(128, 55);
            this.labelTicks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTicks.Name = "labelTicks";
            this.labelTicks.Size = new System.Drawing.Size(44, 15);
            this.labelTicks.TabIndex = 6;
            this.labelTicks.Text = "Ticks:";
            // 
            // labelTicksCount
            // 
            this.labelTicksCount.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicksCount.Location = new System.Drawing.Point(184, 55);
            this.labelTicksCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTicksCount.Name = "labelTicksCount";
            this.labelTicksCount.Size = new System.Drawing.Size(133, 16);
            this.labelTicksCount.TabIndex = 7;
            this.labelTicksCount.Text = "     0";
            this.labelTicksCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonGoReverse
            // 
            this.buttonGoReverse.Enabled = false;
            this.buttonGoReverse.Location = new System.Drawing.Point(17, 84);
            this.buttonGoReverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGoReverse.Name = "buttonGoReverse";
            this.buttonGoReverse.Size = new System.Drawing.Size(100, 27);
            this.buttonGoReverse.TabIndex = 8;
            this.buttonGoReverse.Text = "Go Reverse";
            this.buttonGoReverse.UseVisualStyleBackColor = true;
            this.buttonGoReverse.Click += new System.EventHandler(this.buttonGoReverse_Click);
            // 
            // buttonGoToZero
            // 
            this.buttonGoToZero.Enabled = false;
            this.buttonGoToZero.Location = new System.Drawing.Point(17, 119);
            this.buttonGoToZero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGoToZero.Name = "buttonGoToZero";
            this.buttonGoToZero.Size = new System.Drawing.Size(100, 27);
            this.buttonGoToZero.TabIndex = 9;
            this.buttonGoToZero.Text = "Go To Zero";
            this.buttonGoToZero.UseVisualStyleBackColor = true;
            this.buttonGoToZero.Click += new System.EventHandler(this.buttonGoToZero_Click);
            // 
            // buttonGoRight
            // 
            this.buttonGoRight.Enabled = false;
            this.buttonGoRight.Location = new System.Drawing.Point(17, 152);
            this.buttonGoRight.Name = "buttonGoRight";
            this.buttonGoRight.Size = new System.Drawing.Size(100, 23);
            this.buttonGoRight.TabIndex = 10;
            this.buttonGoRight.Text = "Go Right";
            this.buttonGoRight.UseVisualStyleBackColor = true;
            this.buttonGoRight.Click += new System.EventHandler(this.buttonGoRight_Click);
            // 
            // buttonGoLeft
            // 
            this.buttonGoLeft.Enabled = false;
            this.buttonGoLeft.Location = new System.Drawing.Point(17, 182);
            this.buttonGoLeft.Name = "buttonGoLeft";
            this.buttonGoLeft.Size = new System.Drawing.Size(100, 23);
            this.buttonGoLeft.TabIndex = 11;
            this.buttonGoLeft.Text = "Go Left";
            this.buttonGoLeft.UseVisualStyleBackColor = true;
            this.buttonGoLeft.Click += new System.EventHandler(this.buttonGoLeft_Click);
            // 
            // con_timer1
            // 
            this.con_timer1.Tick += new System.EventHandler(this.con_timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 307);
            this.Controls.Add(this.buttonGoLeft);
            this.Controls.Add(this.buttonGoRight);
            this.Controls.Add(this.buttonGoToZero);
            this.Controls.Add(this.buttonGoReverse);
            this.Controls.Add(this.labelTicksCount);
            this.Controls.Add(this.labelTicks);
            this.Controls.Add(this.labelRoboClawModel);
            this.Controls.Add(this.labelModelTitle);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonGoForward);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "RoboClawTest01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGoForward;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelModelTitle;
        private System.Windows.Forms.Label labelRoboClawModel;
        private System.Windows.Forms.Label labelTicks;
        private System.Windows.Forms.Label labelTicksCount;
        private System.Windows.Forms.Button buttonGoReverse;
        private System.Windows.Forms.Button buttonGoToZero;
        private System.Windows.Forms.Button buttonGoRight;
        private System.Windows.Forms.Button buttonGoLeft;
        private System.Windows.Forms.Timer con_timer1;
    }
}

