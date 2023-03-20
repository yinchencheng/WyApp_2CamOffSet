using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Collections.ObjectModel;
using WY_App.Utility;
using OpenCvSharp.XImgProc;
using HalconDotNet;
using static WY_App.Utility.Parameters;
using WY_App.UserControls;

namespace WY_App
{
    public partial class 相机检测设置 : Form
    {
        static HWindow[] hWindows;       
        HWindow hWindow = new HWindow();
        static HRect1[,] BaseReault = new HRect1[3,3];
        public 相机检测设置()
        {
            InitializeComponent();
            hWindow = hWindowControl4.HalconWindow;
            hWindows = new HWindow[3] { hWindowControl1.HalconWindow, hWindowControl2.HalconWindow, hWindowControl3.HalconWindow };
            HOperatorSet.SetPart(hWindows[0], 0, 0, -1, -1);//设置窗体的规格
            HOperatorSet.SetPart(hWindows[1], 0, 0, 1000, 1000);//设置窗体的规格
            HOperatorSet.SetPart(hWindows[2], 0, 0, 1000, 1000);//设置窗体的规格
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[1]);
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[2]);
            HOperatorSet.SetPart(hWindow, 0, 0, -1, -1);//设置窗体的规格
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindow);
        }
        Point downPoint;

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }


        private void btn_Close_System_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_System_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_DrawXbase_Click(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindow);
            Halcon.DetectionDrawLineAOI(0,hWindow, MainForm.hImage[MainForm.CamNum],ref Parameters.detectionSpec[MainForm.CamNum]);
        }

        private void 相机1检测设置_Load(object sender, EventArgs e)
        {
            HOperatorSet.SetPart(hWindows[0], 0, 0, -1, -1);//设置窗体的规格            
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);
            HOperatorSet.SetPart(hWindow, 0, 0, -1, -1);//设置窗体的规格
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindow);
            cmb_Indication.SelectedIndex = 0;
            chk_MeanImageEnabled.Checked = Parameters.specifications.MeanImageEnabled;
            cmb_MeanImageList.DataSource = Enum.GetNames(typeof(Parameters.MeanImageEnum));
            cmb_MeanImageList.SelectedIndex = Parameters.specifications.meanImageEnum;
            cmb_Indication.DataSource = Enum.GetNames(typeof(Parameters.ImageErrorKind));

            chk_SaveOrigalImage.Checked = Parameters.specifications.SaveOrigalImage;
            chk_SaveDefeatImage.Checked = Parameters.specifications.SaveDefeatImage;
            chk_SaveCropImage.Checked = Parameters.specifications.SaveCropImage;

            txt_PixelResolutionRow.Text = Parameters.detectionSpec[MainForm.CamNum].PixelResolutionRow.ToString();
            txt_PixelResolutionColumn.Text = Parameters.detectionSpec[MainForm.CamNum].PixelResolutionColum.ToString();
        }

        private void btn_OpenTestimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK && (openfile.FileName != ""))
            {
                //HOperatorSet.SetPart(hWindows[0], 0, 0, -1, -1);//设置窗体的规格
                //HOperatorSet.SetPart(hWindow, 0, 0, -1, -1);//设置窗体的规格
                Halcon.ImgDisplay(MainForm.CamNum,openfile.FileName, hWindows[0], hWindow); 
            }
            openfile.Dispose();
        }

        private void btn_DrawY1base_Click(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindow);
            Halcon.DetectionDrawLineAOI(1,hWindow, MainForm.hImage[MainForm.CamNum], ref Parameters.detectionSpec[MainForm.CamNum]);
        }

        private void btn_DrawY2base_Click(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindow);
            Halcon.DetectionDrawLineAOI(2, hWindow, MainForm.hImage[MainForm.CamNum], ref Parameters.detectionSpec[MainForm.CamNum]);
        }
        public static void showXBase(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);
            Halcon.DetectionHalconLine(0, 0, hWindows[0], MainForm.hImage[MainForm.CamNum], Parameters.detectionSpec[MainForm.CamNum], 200, ref BaseReault[MainForm.CamNum, 0]);
        }

        public static void showY1Base(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);
            Halcon.DetectionHalconLine(MainForm.CamNum,1, hWindows[0], MainForm.hImage[MainForm.CamNum], Parameters.detectionSpec[MainForm.CamNum], 200, ref BaseReault[MainForm.CamNum,1]);
        }

        public static void showY2Base(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);
            Halcon.DetectionHalconLine(MainForm.CamNum,2, hWindows[0], MainForm.hImage[MainForm.CamNum], Parameters.detectionSpec[MainForm.CamNum], 200, ref BaseReault[MainForm.CamNum,2]);
        }

        private void btn_Detection_Click(object sender, EventArgs e)
        {
            string detectionTime = "" ;
            Detection(MainForm.CamNum, hWindows, MainForm.hImage[MainForm.CamNum],messageShow3,messageShow4, ref detectionTime);
            lab_detectionTime.Text = detectionTime;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Parameters.detectionSpec[MainForm.CamNum].PixelResolutionColum = Convert.ToDouble(txt_PixelResolutionColumn.Text);
                Parameters.detectionSpec[MainForm.CamNum].PixelResolutionRow = Convert.ToDouble(txt_PixelResolutionRow.Text);
                XMLHelper.serialize<Parameters.DetectionSpec>(Parameters.detectionSpec[MainForm.CamNum], Parameters.commministion.productName + "/DetectionSpec" + MainForm.CamNum + ".xml");
                XMLHelper.serialize<Parameters.Specifications>(Parameters.specifications, Parameters.commministion.productName + "/Specifications.xml");
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Detection(int indexCam, HWindow[] hWindows,HObject hImage,MessageShow messageShow0, MessageShow messageShow1, ref string detectionTime)
        {
            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //  开始监视代码运行时间
            

            if( Parameters.specifications.MeanImageEnabled)
            {
                try
                {
                    Halcon.DetectionMeanImageint((MeanImageEnum)Parameters.specifications.meanImageEnum, hImage, ref hImage);
                }
                catch
                {
                    MessageBox.Show("滤波处理异常，请联系软件工程师","严重错误提示");
                    return;
                }               
            }
            HOperatorSet.DispObj(hImage, hWindows[0]);
            HOperatorSet.SetLineWidth(hWindows[0], 1);
            try
            {
                if (indexCam == 1)
                {
                    //Halcon.DetectionHalconLine(index, 0, hWindows[0], hImage, Parameters.detectionSpec[index], 200, ref BaseReault[index, 0]);
                    Halcon.DetectionHalconLine(indexCam, 1, hWindows[0], hImage, Parameters.detectionSpec[indexCam], 200, ref BaseReault[indexCam, 1]);
                    Halcon.DetectionHalconLine(indexCam, 2, hWindows[0], hImage, Parameters.detectionSpec[indexCam], 200, ref BaseReault[indexCam, 2]);
                    BaseReault[indexCam, 0].Row1 = BaseReault[indexCam, 1].Row1;
                    BaseReault[indexCam, 0].Colum1 = 0;
                    BaseReault[indexCam, 0].Row2 = BaseReault[indexCam, 1].Row2;
                    BaseReault[indexCam, 0].Colum2 = 0;
                }
                else
                {
                    Halcon.DetectionHalconLine(indexCam, 0, hWindows[0], hImage, Parameters.detectionSpec[indexCam], 200, ref BaseReault[indexCam, 0]);
                    Halcon.DetectionHalconLine(indexCam, 1, hWindows[0], hImage, Parameters.detectionSpec[indexCam], 200, ref BaseReault[indexCam, 1]);
                    Halcon.DetectionHalconLine(indexCam, 2, hWindows[0], hImage, Parameters.detectionSpec[indexCam], 200, ref BaseReault[indexCam, 2]);
                }
            }
            catch
            {
                MessageBox.Show("基准线查找异常，请联系软件工程师", "严重错误提示");
                return;
            }
            HTuple Row, Column, IsOverlapping;
            try
            {
                HOperatorSet.IntersectionLines(BaseReault[indexCam, 0].Row1, BaseReault[indexCam, 0].Colum1, BaseReault[indexCam, 0].Row2, BaseReault[indexCam, 0].Colum2,
                BaseReault[indexCam, 1].Row1, BaseReault[indexCam, 1].Colum1, BaseReault[indexCam, 1].Row2, BaseReault[indexCam, 1].Colum2, out Row, out Column, out IsOverlapping);
                Parameters.detectionSpec[indexCam].RowBase = Row;
                Parameters.detectionSpec[indexCam].ColumBase = Column;
                HOperatorSet.SetColor(hWindows[0], "red");
                HOperatorSet.DispCross(hWindows[0], Row, Column, 60, 0);

                HOperatorSet.IntersectionLines(BaseReault[indexCam, 0].Row1, BaseReault[indexCam, 0].Colum1, BaseReault[indexCam, 0].Row2, BaseReault[indexCam, 0].Colum2,
                    BaseReault[indexCam, 2].Row1, BaseReault[indexCam, 2].Colum1, BaseReault[indexCam, 2].Row2, BaseReault[indexCam, 2].Colum2, out Row, out Column, out IsOverlapping);
                HOperatorSet.DispCross(hWindows[0], Row, Column, 60, 0);
            }
            catch
            {
                MessageBox.Show("基准点寻找异常，请联系软件工程师", "严重错误提示");
                return;
            }
            HTuple HomMat2DIdentity = new HTuple();
            HTuple HomMat2DRotate = new HTuple();
            HObject ImageAffineTran = new HObject();
            try
            {
                HOperatorSet.HomMat2dIdentity(out HomMat2DIdentity);
                HOperatorSet.HomMat2dRotate(HomMat2DIdentity, 0, Row, Column, out HomMat2DRotate);
                HOperatorSet.AffineTransImage(MainForm.hoRegions[indexCam], out ImageAffineTran, HomMat2DRotate, "constant", "false");
                detectionResults[MainForm.CamNum] = new List<DetectionResult>();
                for (int indexKind = 0; indexKind < 6; indexKind++)
                {

                    Halcon.DetectionHalconRegion(indexCam, indexKind, hWindows, hImage, Parameters.detectionSpec[indexCam], MainForm.hoRegions[indexCam], ref detectionResults[indexCam]);
                }                
            }
            catch
            {
                HomMat2DIdentity.Dispose();
                HomMat2DRotate.Dispose();
                MessageBox.Show("瑕疵检测处理异常，请联系软件工程师", "严重错误提示");
                //return;
            }
            if (detectionResults[indexCam].Count == 1)
            {
                HOperatorSet.SetPart(hWindows[1], 0, 0, 1000, 1000);//设置窗体的规格
                HOperatorSet.SetPart(hWindows[2], 0, 0, 1000, 1000);//设置窗体的规格
                hWindows[1].ClearWindow();
                hWindows[2].ClearWindow();
                hWindows[1].DispObj(detectionResults[indexCam][0].NGAreahObject);
                messageShow0.lab_Timer.Text = detectionResults[indexCam][0].ResultdateTime.ToString();
                messageShow0.lab_Column.Text = detectionResults[indexCam][0].ResultXPosition.ToString();
                messageShow0.lab_Row.Text = detectionResults[indexCam][0].ResultYPosition.ToString();
                messageShow0.lab_Size.Text = detectionResults[indexCam][0].ResultSize.ToString();
                messageShow0.lab_Kind.Text = detectionResults[indexCam][0].ResultKind.ToString();
                messageShow0.lab_Level.Text = detectionResults[indexCam][0].ResultLevel.ToString();
                messageShow0.lab_Gray.Text = detectionResults[indexCam][0].ResultGray.ToString();
            }
            if (detectionResults[indexCam].Count > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    hWindows[i + 1].ClearWindow();
                    HOperatorSet.SetPart(hWindows[1], 0, 0, 1000, 1000);//设置窗体的规格
                    HOperatorSet.SetPart(hWindows[2], 0, 0, 1000, 1000);//设置窗体的规格
                    hWindows[i + 1].DispObj(detectionResults[indexCam][i].NGAreahObject);
                }
                messageShow0.lab_Timer.Text = detectionResults[indexCam][0].ResultdateTime.ToString();
                messageShow0.lab_Column.Text = detectionResults[indexCam][0].ResultXPosition.ToString();
                messageShow0.lab_Row.Text = detectionResults[indexCam][0].ResultYPosition.ToString();
                messageShow0.lab_Size.Text = detectionResults[indexCam][0].ResultSize.ToString();
                messageShow0.lab_Kind.Text = detectionResults[indexCam][0].ResultKind.ToString();
                messageShow0.lab_Level.Text = detectionResults[indexCam][0].ResultLevel.ToString();
                messageShow0.lab_Gray.Text = detectionResults[indexCam][0].ResultGray.ToString();
                messageShow2.lab_Timer.Text = detectionResults[indexCam][1].ResultdateTime.ToString();
                messageShow2.lab_Column.Text = detectionResults[indexCam][1].ResultXPosition.ToString();
                messageShow2.lab_Row.Text = detectionResults[indexCam][1].ResultYPosition.ToString();
                messageShow2.lab_Size.Text = detectionResults[indexCam][1].ResultSize.ToString();
                messageShow2.lab_Kind.Text = detectionResults[indexCam][1].ResultKind.ToString();
                messageShow2.lab_Level.Text = detectionResults[indexCam][1].ResultLevel.ToString();
                messageShow2.lab_Gray.Text = detectionResults[indexCam][1].ResultGray.ToString();
            }
            HomMat2DIdentity.Dispose();
            HomMat2DRotate.Dispose();
            Row.Dispose();
            Column.Dispose();
            IsOverlapping.Dispose();

            if (detectionResults[indexCam].Count == 1)
            {
                hWindows[1].DispObj(detectionResults[indexCam][0].NGAreahObject);
            }
            if (detectionResults[indexCam].Count >= 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    hWindows[i+1].DispObj(detectionResults[indexCam][i].NGAreahObject);
                }
            }
            
            
            stopwatch.Stop(); //  停止监视
            TimeSpan timespan = stopwatch.Elapsed; //  获取当前实例测量得出的总时间
            detectionTime = timespan.TotalMilliseconds.ToString();  //  总毫秒数           
            
        }

        private void btn_DrawAOI_Click(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindow);
            Halcon.DetectionDrawAOI(hWindow,  out MainForm.hoRegions[MainForm.CamNum]);
        }

        private void btn_SaveAOI_Click(object sender, EventArgs e)
        {
            Halcon.DetectionSaveAOI(Parameters.commministion.productName + "/halcon/hoRegion" + MainForm.CamNum + ".tiff", MainForm.hoRegions[MainForm.CamNum]);
        }

        private void chk_SaveDefeatImage_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.specifications.SaveDefeatImage = chk_SaveDefeatImage.Checked;
        }

        private void chk_SaveOrigalImage_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.specifications.SaveOrigalImage = chk_SaveOrigalImage.Checked;

        }
        private void btn_XBaseSetting_Click(object sender, EventArgs e)
        {
            MainForm.baseNum = 0;
            卡尺工具设置 flg = new  卡尺工具设置();
            flg.ShowDialog();
        }
        private void btn_Y1BaseSetting_Click(object sender, EventArgs e)
        {
            MainForm.baseNum = 1;
            卡尺工具设置 flg = new 卡尺工具设置();
            flg.ShowDialog();
        }

        private void btn_Y2BaseSetting_Click(object sender, EventArgs e)
        {
            MainForm.baseNum = 2;
            卡尺工具设置 flg = new 卡尺工具设置();
            flg.ShowDialog();
        }

        

        private void btn_ShowAOI_Click(object sender, EventArgs e)
        {
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);

            Halcon.DetectionShowAOI(MainForm.CamNum, hWindows[0], out MainForm.hoRegions[MainForm.CamNum]);
        }

        static List<DetectionResult>[] detectionResults = new List<DetectionResult>[3];
        private void btnn_IndicationTest_Click(object sender, EventArgs e)
        {
            if (Parameters.specifications.MeanImageEnabled)
            {
                Halcon.DetectionMeanImageint((MeanImageEnum)Parameters.specifications.meanImageEnum, MainForm.hImage[MainForm.CamNum], ref MainForm.hImage[MainForm.CamNum]);
            }
            HOperatorSet.DispObj(MainForm.hImage[MainForm.CamNum], hWindows[0]);
            detectionResults[MainForm.CamNum] = new List<DetectionResult>();
            Halcon.DetectionHalconRegion(MainForm.CamNum, cmb_Indication.SelectedIndex, hWindows, MainForm.hImage[MainForm.CamNum], Parameters.detectionSpec[MainForm.CamNum], MainForm.hoRegions[MainForm.CamNum],ref detectionResults[MainForm.CamNum]);
            if (detectionResults[MainForm.CamNum].Count == 1)
            {
                HOperatorSet.SetPart(hWindows[1], 0, 0, 1000, 1000);//设置窗体的规格
                HOperatorSet.SetPart(hWindows[2], 0, 0, 1000, 1000);//设置窗体的规格
                hWindows[1].ClearWindow();
                hWindows[2].ClearWindow();
                hWindows[1].DispObj(detectionResults[MainForm.CamNum][0].NGAreahObject);
                messageShow3.lab_Timer.Text = detectionResults[MainForm.CamNum][0].ResultdateTime.ToString();
                messageShow3.lab_Column.Text = detectionResults[MainForm.CamNum][0].ResultXPosition.ToString();
                messageShow3.lab_Row.Text = detectionResults[MainForm.CamNum][0].ResultYPosition.ToString();
                messageShow3.lab_Size.Text = detectionResults[MainForm.CamNum][0].ResultSize.ToString();
                messageShow3.lab_Kind.Text = detectionResults[MainForm.CamNum][0].ResultKind.ToString();
                messageShow3.lab_Level.Text = detectionResults[MainForm.CamNum][0].ResultLevel.ToString();
                messageShow3.lab_Gray.Text = detectionResults[MainForm.CamNum][0].ResultGray.ToString();
            }
            if (detectionResults[MainForm.CamNum].Count > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    hWindows[i+1].ClearWindow();
                    HOperatorSet.SetPart(hWindows[1], 0, 0, 1000, 1000);//设置窗体的规格
                    HOperatorSet.SetPart(hWindows[2], 0, 0, 1000, 1000);//设置窗体的规格
                    hWindows[i + 1].DispObj(detectionResults[MainForm.CamNum][i].NGAreahObject);
                }
                messageShow3.lab_Timer.Text = detectionResults[MainForm.CamNum][0].ResultdateTime.ToString();
                messageShow3.lab_Column.Text = detectionResults[MainForm.CamNum][0].ResultXPosition.ToString();
                messageShow3.lab_Row.Text = detectionResults[MainForm.CamNum][0].ResultYPosition.ToString();
                messageShow3.lab_Size.Text = detectionResults[MainForm.CamNum][0].ResultSize.ToString();
                messageShow3.lab_Kind.Text = detectionResults[MainForm.CamNum][0].ResultKind.ToString();
                messageShow3.lab_Level.Text = detectionResults[MainForm.CamNum][0].ResultLevel.ToString();
                messageShow3.lab_Gray.Text = detectionResults[MainForm.CamNum][0].ResultGray.ToString();
                messageShow4.lab_Timer.Text = detectionResults[MainForm.CamNum][1].ResultdateTime.ToString();
                messageShow4.lab_Column.Text = detectionResults[MainForm.CamNum][1].ResultXPosition.ToString();
                messageShow4.lab_Row.Text = detectionResults[MainForm.CamNum][1].ResultYPosition.ToString();
                messageShow4.lab_Size.Text = detectionResults[MainForm.CamNum][1].ResultSize.ToString();
                messageShow4.lab_Kind.Text = detectionResults[MainForm.CamNum][1].ResultKind.ToString();
                messageShow4.lab_Level.Text = detectionResults[MainForm.CamNum][1].ResultLevel.ToString();
                messageShow4.lab_Gray.Text = detectionResults[MainForm.CamNum][1].ResultGray.ToString();
            }
        }

        private void btn_AddKind_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Indication_SelectedIndexChanged(object sender, EventArgs e)
        {
            num_lengthWidthRatio.Value = Parameters.detectionSpec[MainForm.CamNum].lengthWidthRatio[cmb_Indication.SelectedIndex];
            num_ThresholdLow.Value = Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[cmb_Indication.SelectedIndex];
            num_ThresholdHigh.Value = Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[cmb_Indication.SelectedIndex];
            num_AreaLow.Value = Parameters.detectionSpec[MainForm.CamNum].AreaLow[cmb_Indication.SelectedIndex];
            num_AreaHigh.Value = Parameters.detectionSpec[MainForm.CamNum].AreaHigh[cmb_Indication.SelectedIndex];
        }

        private void num_lengthWidthRatio_ValueChanged(object sender, double value)
        {
            Parameters.detectionSpec[MainForm.CamNum].lengthWidthRatio[cmb_Indication.SelectedIndex] = num_lengthWidthRatio.Value;
        }

        private void num_ThresholdLow_ValueChanged(object sender, double value)
        {
            Parameters.detectionSpec[MainForm.CamNum].ThresholdLow[cmb_Indication.SelectedIndex] = num_ThresholdLow.Value;
        }

        private void num_ThresholdHigh_ValueChanged(object sender, double value)
        {
            Parameters.detectionSpec[MainForm.CamNum].ThresholdHigh[cmb_Indication.SelectedIndex] = num_ThresholdHigh.Value;
        }

        private void num_AreaLow_ValueChanged(object sender, double value)
        {
            Parameters.detectionSpec[MainForm.CamNum].AreaLow[cmb_Indication.SelectedIndex] = num_AreaLow.Value ;
        }

        private void num_AreaHigh_ValueChanged(object sender, double value)
        {
            Parameters.detectionSpec[MainForm.CamNum].AreaHigh[cmb_Indication.SelectedIndex] = num_AreaHigh.Value;
        }

        private void btn_MeanImageTest_Click(object sender, EventArgs e)
        {
            HObject hObject = new HObject();
            Halcon.DetectionMeanImageint((MeanImageEnum)cmb_MeanImageList.SelectedIndex, MainForm.hImage[MainForm.CamNum],ref hObject);
            HOperatorSet.DispObj(hObject, hWindow);
            hObject.Dispose();
        }

        private void cmb_MeanImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.specifications.meanImageEnum = cmb_MeanImageList.SelectedIndex;
        }

        private void chk_MeanImageEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.specifications.MeanImageEnabled = chk_MeanImageEnabled.Checked;
        }

        private void btn_Minimizid_System_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_showXBase_Click(object sender, EventArgs e)
        {
            showXBase(sender, e);
        }

        private void btn_showYBase_Click(object sender, EventArgs e)
        {
            相机检测设置.showY1Base(sender, e);
        }

        private void btn_showY2Base_Click(object sender, EventArgs e)
        {
            相机检测设置.showY2Base(sender, e);
        }

        private void chk_SaveCropImage_CheckedChanged(object sender, EventArgs e)
        {
            Parameters.specifications.SaveCropImage = chk_SaveCropImage.Checked;
        }

        private void txt_PixelResolutionColumn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_PixelResolutionRow_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void PixelResolutionRow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
