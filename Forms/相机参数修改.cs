using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WY_App.Utility;

namespace WY_App.Forms
{
	public partial class 相机参数修改 : Form
	{
		UIDoubleUpDown[] ThresholdLow = new UIDoubleUpDown[28];
		UIDoubleUpDown[] ThresholdHigh = new UIDoubleUpDown[28];
		UIDoubleUpDown[] AreaLow = new UIDoubleUpDown[28];
		UIDoubleUpDown[] AreaHigh = new UIDoubleUpDown[28];
		CheckBox[] DefectDetection = new CheckBox[28];
		public 相机参数修改()
		{
			InitializeComponent();
			for (int i = 0; i < ThresholdLow.Length; i++)
			{
				// 根据名字查找已经创建的示例框控件
				ThresholdLow[i] = (UIDoubleUpDown)Controls.Find("num_ThresholdLow" + (i + 1), true)[0];
				ThresholdHigh[i] = (UIDoubleUpDown)Controls.Find("num_ThresholdHigh" + (i + 1), true)[0];
				AreaLow[i] = (UIDoubleUpDown)Controls.Find("num_AreaLow" + (i + 1), true)[0];
				AreaHigh[i] = (UIDoubleUpDown)Controls.Find("num_AreaHigh" + (i + 1), true)[0];
				DefectDetection[i] = (CheckBox)Controls.Find("check_DefectDetection" + (i + 1), true)[0];
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			ChangeParaLog();
			for (int i = 0; i < 28; i++)
			{
				Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[i] = ThresholdLow[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[i] = ThresholdHigh[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].AreaLow[i] = AreaLow[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].AreaHigh[i] = AreaHigh[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].DefectDetection[i] = DefectDetection[i].Checked;
			}
			try
			{
				XMLHelper.serialize<Parameters.DetectionSpec>(Parameters.detectionSpec[MainForm.CamNum], Parameters.commministion.productName + "/DetectionSpec" + MainForm.CamNum + ".xml");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void 相机参数修改_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 28; i++)
			{
				ThresholdLow[i].Value = Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[i];
				ThresholdHigh[i].Value = Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[i];
				AreaLow[i].Value = Parameters.detectionSpec[MainForm.CamNum].AreaLow[i];
				AreaHigh[i].Value = Parameters.detectionSpec[MainForm.CamNum].AreaHigh[i];
				DefectDetection[i].Checked = Parameters.detectionSpec[MainForm.CamNum].DefectDetection[i];

				if (DefectDetection[i].Checked)
				{
					ThresholdLow[i].Enabled = true;
					ThresholdHigh[i].Enabled = true;
					AreaLow[i].Enabled = true;
					AreaHigh[i].Enabled = true;
				}
				else
				{
					ThresholdLow[i].Enabled = false;
					ThresholdHigh[i].Enabled = false;
					AreaLow[i].Enabled = false;
					AreaHigh[i].Enabled = false;
				}

			}
		}

		private void uiButton1_Click(object sender, EventArgs e)
		{
			ChangeParaLog();
			for (int i = 0; i < 28; i++)
			{
				Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[i] = ThresholdLow[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[i] = ThresholdHigh[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].AreaLow[i] = AreaLow[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].AreaHigh[i] = AreaHigh[i].Value;
				Parameters.detectionSpec[MainForm.CamNum].DefectDetection[i] = DefectDetection[i].Checked;
			}
			try
			{
				XMLHelper.serialize<Parameters.DetectionSpec>(Parameters.detectionSpec[MainForm.CamNum], Parameters.commministion.productName + "/DetectionSpec" + MainForm.CamNum + ".xml");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			MainForm.RefreshPara();
			this.Close();
		}

		private void ChangeParaLog()
		{
			for (int i = 0; i < 28; i++)
			{
				if (Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[i] != ThresholdLow[i].Value)
				{
					LogHelper.WriteWarn(" " + MainForm.UserName + "ThresholdLow:" + Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[i] + "  第" + i.ToString() + "号缺陷" + "=>" + ThresholdLow[i].Value);
				}
				if (Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[i] != ThresholdHigh[i].Value)
				{
					LogHelper.WriteWarn(" " + MainForm.UserName + "ThresholdHigh:" + Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[i] + "  第" + i.ToString() + "号缺陷" + "=>" + ThresholdHigh[i].Value);
				}
				if (Parameters.detectionSpec[MainForm.CamNum].AreaLow[i] != AreaLow[i].Value)
				{
					LogHelper.WriteWarn(" " + MainForm.UserName + "AreaLow:" + Parameters.detectionSpec[MainForm.CamNum].AreaLow[i] + "  第" + i.ToString() + "号缺陷" + "=>" + AreaLow[i].Value);
				}
				if (Parameters.detectionSpec[MainForm.CamNum].AreaHigh[i] != AreaHigh[i].Value)
				{
					LogHelper.WriteWarn(" " + MainForm.UserName + "AreaHigh:" + Parameters.detectionSpec[MainForm.CamNum].AreaHigh[i] + "  第" + i.ToString() + "号缺陷" + "=>" + AreaHigh[i].Value);
				}
				if (Parameters.detectionSpec[MainForm.CamNum].DefectDetection[i] != DefectDetection[i].Checked)
				{
					LogHelper.WriteWarn(" " + MainForm.UserName + "DefectDetection:" + Parameters.detectionSpec[MainForm.CamNum].DefectDetection[i] + "  第" + i.ToString() + "号缺陷" + "=>" + DefectDetection[i].Checked);
				}

			}
		}

		private void RefreshButton(int i)
		{
			if (DefectDetection[i].Checked)
			{
				ThresholdLow[i].Enabled = true;
				ThresholdHigh[i].Enabled = true;
				AreaLow[i].Enabled = true;
				AreaHigh[i].Enabled = true;
			}
			else
			{
				ThresholdLow[i].Enabled = false;
				ThresholdHigh[i].Enabled = false;
				AreaLow[i].Enabled = false;
				AreaHigh[i].Enabled = false;
			}
		}

		private void check_DefectDetection1_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(0);
		}

		private void check_DefectDetection2_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(1);
		}

		private void check_DefectDetection3_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(2);
		}

		private void check_DefectDetection4_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(3);
		}

		private void check_DefectDetection5_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(4);
		}

		private void check_DefectDetection6_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(5);
		}

		private void check_DefectDetection7_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(6);
		}

		private void check_DefectDetection8_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(7);
		}

		private void check_DefectDetection9_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(8);
		}

		private void check_DefectDetection10_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(9);
		}

		private void check_DefectDetection11_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(10);
		}

		private void check_DefectDetection12_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(11);
		}

		private void check_DefectDetection13_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(12);
		}

		private void check_DefectDetection14_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(13);
		}

		private void check_DefectDetection15_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(14);
		}

		private void check_DefectDetection16_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(15);
		}

		private void check_DefectDetection17_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(16);
		}

		private void check_DefectDetection18_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(17);
		}

		private void check_DefectDetection19_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(18);
		}

		private void check_DefectDetection20_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(19);
		}

		private void check_DefectDetection21_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(20);
		}

		private void check_DefectDetection22_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(21);
		}

		private void check_DefectDetection23_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(22);
		}

		private void check_DefectDetection24_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(23);
		}

		private void check_DefectDetection25_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(24);
		}

		private void check_DefectDetection26_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(25);
		}

		private void check_DefectDetection27_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(26);
		}

		private void check_DefectDetection28_CheckedChanged(object sender, EventArgs e)
		{
			RefreshButton(27);
		}
	}
}
