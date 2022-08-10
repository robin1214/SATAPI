using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siemens.Automation.AutomationTool.API;

namespace SATAPIdemo
{
    public partial class Form1 : Form
    {
        public Network Net = new Network();
        public IProfinetDeviceCollection Devices;
        public IProfinetDevice insertedDevice;
        public ICPU CurrentCPU;

        public Form1()
        {
            InitializeComponent();
            //
            List<string> NetworkInterfaces;
            Result res = Net.QueryNetworkInterfaceCards(out NetworkInterfaces);
            foreach (string nic in NetworkInterfaces)
                SelectNetworkInterface.Items.Add(nic);
            ClearCPUStatus();
        }

        //
        private void SelectNetworkInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result res =Net.SetCurrentNetworkInterface((string)SelectNetworkInterface.SelectedItem);
        }

        private void InsertDevice_Click(object sender, EventArgs e)
        {
            CurrentCPU = null;
            ClearCPUStatus();

            uint ipAddress = ParseIP(InsertDeviceIPAddress.Text);
            Devices = Network.GetEmptyCollection();
            /*
            IScanErrorCollection scanResult = Net.ScanNetworkDevices(out Devices);
            if (!scanResult.Succeeded)
            { 
            MessageBox.Show("错误：无法扫描设备", "Scan Device", MessageBoxButtons.OK);
            return;
            }
            */
            Devices.Clear();

            IScanErrorCollection insertErrorCollection = Devices.InsertDeviceByIP(ipAddress, out insertedDevice);
            if (!insertErrorCollection.Succeeded)
            {
                MessageBox.Show("无法插入设备", "Insert Device", MessageBoxButtons.OK);
                return;
            }

            Result res = Devices[0].RefreshStatus();

            if (Devices[0].Family != DeviceFamily.CPU1200 && Devices[0].Family != DeviceFamily.CPU1500)
            {
                MessageBox.Show("错误：插入的设备不是 CPU", "Insert Device",MessageBoxButtons.OK);
                return;
            }
            CurrentCPU = Devices[0] as ICPU;
            UpdateCPUStatus();


        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            CurrentCPU.Selected = true;
            Result res = CurrentCPU.SetOperatingState(OperatingStateREQ.Run);
            UpdateCPUStatus();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CurrentCPU.Selected = true;
            Result res = CurrentCPU.SetOperatingState(OperatingStateREQ.Stop);
            UpdateCPUStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





