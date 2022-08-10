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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 24);
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
            this.SelectNetworkInterface.Size = new System.Drawing.Size(474, 20);
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
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address:";
            // 
            // InsertDeviceIPAddress
            // 
            this.InsertDeviceIPAddress.Location = new System.Drawing.Point(100, 60);
            this.InsertDeviceIPAddress.Name = "InsertDeviceIPAddress";
            this.InsertDeviceIPAddress.Size = new System.Drawing.Size(120, 21);
            this.InsertDeviceIPAddress.TabIndex = 4;
            // 
            // InsertDevice
            // 
            this.InsertDevice.Location = new System.Drawing.Point(238, 59);
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
            this.label3.Location = new System.Drawing.Point(71, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Device:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Article Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Operating Mode:";
            // 
            // DeviceName
            // 
            this.DeviceName.Location = new System.Drawing.Point(124, 94);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(171, 23);
            this.DeviceName.TabIndex = 9;
            this.DeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArticleNumber
            // 
            this.ArticleNumber.Location = new System.Drawing.Point(124, 115);
            this.ArticleNumber.Name = "ArticleNumber";
            this.ArticleNumber.Size = new System.Drawing.Size(153, 23);
            this.ArticleNumber.TabIndex = 10;
            this.ArticleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OperatingMode
            // 
            this.OperatingMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OperatingMode.Location = new System.Drawing.Point(124, 138);
            this.OperatingMode.Name = "OperatingMode";
            this.OperatingMode.Size = new System.Drawing.Size(86, 23);
            this.OperatingMode.TabIndex = 11;
            this.OperatingMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(216, 138);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(51, 23);
            this.RunButton.TabIndex = 12;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(279, 138);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(51, 23);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 196);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RunButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SAT API APP";
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
    }
}

