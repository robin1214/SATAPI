using System;
using Siemens.Automation.AutomationTool.API;

namespace SATAPIdemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SelectNetworkInterface = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertDeviceIPAddress = new System.Windows.Forms.TextBox();
            this.InsertDevice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.ArticleNumber = new System.Windows.Forms.Label();
            this.OperatingMode = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangeIpSuite = new System.Windows.Forms.Button();
            this.SuiteGw = new System.Windows.Forms.TextBox();
            this.SuiteSn = new System.Windows.Forms.TextBox();
            this.SuiteIp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SetProfinetName = new System.Windows.Forms.Button();
            this.ProfinetName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(589, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectNetworkInterface
            // 
            this.SelectNetworkInterface.FormattingEnabled = true;
            this.SelectNetworkInterface.Location = new System.Drawing.Point(25, 29);
            this.SelectNetworkInterface.Name = "SelectNetworkInterface";
            this.SelectNetworkInterface.Size = new System.Drawing.Size(612, 20);
            this.SelectNetworkInterface.TabIndex = 1;
            this.SelectNetworkInterface.SelectedIndexChanged += new System.EventHandler(this.SelectNetworkInterface_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network Interface:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address:";
            // 
            // InsertDeviceIPAddress
            // 
            this.InsertDeviceIPAddress.Location = new System.Drawing.Point(140, 60);
            this.InsertDeviceIPAddress.Name = "InsertDeviceIPAddress";
            this.InsertDeviceIPAddress.Size = new System.Drawing.Size(120, 21);
            this.InsertDeviceIPAddress.TabIndex = 4;
            // 
            // InsertDevice
            // 
            this.InsertDevice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InsertDevice.Location = new System.Drawing.Point(317, 60);
            this.InsertDevice.Name = "InsertDevice";
            this.InsertDevice.Size = new System.Drawing.Size(69, 21);
            this.InsertDevice.TabIndex = 5;
            this.InsertDevice.Text = "InsertDevice";
            this.InsertDevice.UseVisualStyleBackColor = true;
            this.InsertDevice.Click += new System.EventHandler(this.InsertDevice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Device:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Article Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Operating Mode:";
            // 
            // DeviceName
            // 
            this.DeviceName.Location = new System.Drawing.Point(140, 98);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(171, 23);
            this.DeviceName.TabIndex = 9;
            this.DeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArticleNumber
            // 
            this.ArticleNumber.Location = new System.Drawing.Point(140, 119);
            this.ArticleNumber.Name = "ArticleNumber";
            this.ArticleNumber.Size = new System.Drawing.Size(153, 23);
            this.ArticleNumber.TabIndex = 10;
            this.ArticleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OperatingMode
            // 
            this.OperatingMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OperatingMode.Location = new System.Drawing.Point(140, 142);
            this.OperatingMode.Name = "OperatingMode";
            this.OperatingMode.Size = new System.Drawing.Size(86, 23);
            this.OperatingMode.TabIndex = 11;
            this.OperatingMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RunButton.Location = new System.Drawing.Point(305, 32);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(51, 23);
            this.RunButton.TabIndex = 12;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StopButton.Location = new System.Drawing.Point(305, 56);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(51, 23);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.RunButton);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gateway:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Subnet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangeIpSuite);
            this.groupBox2.Controls.Add(this.SuiteGw);
            this.groupBox2.Controls.Add(this.SuiteSn);
            this.groupBox2.Controls.Add(this.SuiteIp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 99);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change IP";
            // 
            // ChangeIpSuite
            // 
            this.ChangeIpSuite.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChangeIpSuite.Location = new System.Drawing.Point(231, 67);
            this.ChangeIpSuite.Name = "ChangeIpSuite";
            this.ChangeIpSuite.Size = new System.Drawing.Size(62, 21);
            this.ChangeIpSuite.TabIndex = 21;
            this.ChangeIpSuite.Text = "Change";
            this.ChangeIpSuite.UseVisualStyleBackColor = true;
            this.ChangeIpSuite.Click += new System.EventHandler(this.ChangeIpSuite_Click);
            // 
            // SuiteGw
            // 
            this.SuiteGw.Location = new System.Drawing.Point(90, 63);
            this.SuiteGw.Name = "SuiteGw";
            this.SuiteGw.Size = new System.Drawing.Size(120, 21);
            this.SuiteGw.TabIndex = 20;
            // 
            // SuiteSn
            // 
            this.SuiteSn.Location = new System.Drawing.Point(90, 41);
            this.SuiteSn.Name = "SuiteSn";
            this.SuiteSn.Size = new System.Drawing.Size(120, 21);
            this.SuiteSn.TabIndex = 20;
            // 
            // SuiteIp
            // 
            this.SuiteIp.Location = new System.Drawing.Point(90, 19);
            this.SuiteIp.Name = "SuiteIp";
            this.SuiteIp.Size = new System.Drawing.Size(120, 21);
            this.SuiteIp.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetProfinetName);
            this.groupBox3.Controls.Add(this.ProfinetName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(317, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 99);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Name";
            // 
            // SetProfinetName
            // 
            this.SetProfinetName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetProfinetName.Location = new System.Drawing.Point(258, 67);
            this.SetProfinetName.Name = "SetProfinetName";
            this.SetProfinetName.Size = new System.Drawing.Size(62, 21);
            this.SetProfinetName.TabIndex = 21;
            this.SetProfinetName.Text = "Change";
            this.SetProfinetName.UseVisualStyleBackColor = true;
            this.SetProfinetName.Click += new System.EventHandler(this.SetProfinetName_Click);
            // 
            // ProfinetName
            // 
            this.ProfinetName.Location = new System.Drawing.Point(126, 19);
            this.ProfinetName.Name = "ProfinetName";
            this.ProfinetName.Size = new System.Drawing.Size(152, 21);
            this.ProfinetName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Profinet Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 327);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OperatingMode);
            this.Controls.Add(this.ArticleNumber);
            this.Controls.Add(this.DeviceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertDevice);
            this.Controls.Add(this.InsertDeviceIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectNetworkInterface);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SAT API APP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //
        #region 辅助方法
        private void ClearCPUStatus()
        {
            DeviceName.Text = string.Empty;
            ArticleNumber.Text = string.Empty;
            OperatingMode.Text = string.Empty;
            SuiteIp.Text = string.Empty;
            SuiteSn.Text = string.Empty;
            SuiteGw.Text = string.Empty;
            ProfinetName.Text = string.Empty;
        }
        private uint ParseIP(string StrNetParm)
        {
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(StrNetParm);
                byte[] bytes = ip.GetAddressBytes();
                Array.Reverse(bytes);
                return BitConverter.ToUInt32(bytes, 0);
            }
            catch (Exception e)
            {
                return 0xffffffff;
                //return e;
            }
        }
        private void UpdateCPUStatus()
        {
            DeviceName.Text = CurrentCPU.Name;
            ArticleNumber.Text = CurrentCPU.ArticleNumber;
            OperatingMode.Text = CurrentCPU.OperatingMode == OperatingState.Run ? "RUN" : "STOP";
            OperatingMode.ForeColor = OperatingMode.Text == "RUN" ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            
            if (CurrentCPU.IPString.StartsWith("X"))
                SuiteIp.Text = CurrentCPU.IPString.Substring(4);
            else
                SuiteIp.Text = CurrentCPU.IPString;
            SuiteSn.Text = CurrentCPU.SubnetMaskString;
            SuiteGw.Text = CurrentCPU.DefaultGatewayString;
            ProfinetName.Text = CurrentCPU.ProfinetConvertedName;
        }
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SelectNetworkInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsertDeviceIPAddress;
        private System.Windows.Forms.Button InsertDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.Label ArticleNumber;
        private System.Windows.Forms.Label OperatingMode;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SuiteGw;
        private System.Windows.Forms.TextBox SuiteSn;
        private System.Windows.Forms.TextBox SuiteIp;
        private System.Windows.Forms.Button ChangeIpSuite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SetProfinetName;
        private System.Windows.Forms.TextBox ProfinetName;
        private System.Windows.Forms.Label label9;
    }
}

