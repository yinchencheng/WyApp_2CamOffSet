using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WY_App.Utility;

namespace WY_App
{
    public partial class 卡尺工具设置 : Form
    {
        public 卡尺工具设置()
        {
            InitializeComponent();
        }

        private void 卡尺工具设置_Load(object sender, EventArgs e)
        {
            num_MeasureLength1.Value = Parameters.detectionSpec[MainForm.CamNum].MeasureLength1[MainForm.baseNum];
            num_MeasureLength2.Value = Parameters.detectionSpec[MainForm.CamNum].MeasureLength2[MainForm.baseNum];
            num_MeasureSigma.Value = (decimal)Parameters.detectionSpec[MainForm.CamNum].MeasureSigma[MainForm.baseNum];
            num_MeasureThreshold.Value = Parameters.detectionSpec[MainForm.CamNum].MeasureThreshold[MainForm.baseNum];
            num_MeasureTransition.Text = Parameters.detectionSpec[MainForm.CamNum].MeasureTransition[MainForm.baseNum];

        }

        private void btn_Close_System_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void 保存_Click(object sender, EventArgs e)
        {
            Parameters.detectionSpec[MainForm.CamNum].MeasureLength1[MainForm.baseNum] = (uint)num_MeasureLength1.Value;
            Parameters.detectionSpec[MainForm.CamNum].MeasureLength2[MainForm.baseNum] = (uint)num_MeasureLength2.Value;
            Parameters.detectionSpec[MainForm.CamNum].MeasureSigma[MainForm.baseNum] = (double) num_MeasureSigma.Value;
            Parameters.detectionSpec[MainForm.CamNum].MeasureThreshold[MainForm.baseNum] = (uint)num_MeasureThreshold.Value;
            Parameters.detectionSpec[MainForm.CamNum].MeasureTransition[MainForm.baseNum]= num_MeasureTransition.SelectedText;
            XMLHelper.serialize<Parameters.DetectionSpec>(Parameters.detectionSpec[MainForm.CamNum], Parameters.commministion.productName + "/DetectionSpec" + MainForm.CamNum + ".xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (MainForm.baseNum)
            {
                case 0:
                    {
                        相机检测设置.showXBase(sender, e);
                        break;
                    }
                case 1:
                    {
                        相机检测设置.showY1Base(sender, e);
                        break;
                    }
                case 2:
                    {
                        相机检测设置.showY2Base(sender, e);
                        break;
                    }
            }
            
        }
    }
}
