namespace WY_App.Forms
{
	partial class 复检1
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
			this.messageShow3 = new WY_App.UserControls.MessageShow();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.hWindowControl4 = new HalconDotNet.HWindowControl();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.messageShow4 = new WY_App.UserControls.MessageShow();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.hWindowControl3 = new HalconDotNet.HWindowControl();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.hWindowControl2 = new HalconDotNet.HWindowControl();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.hWindowControl1 = new HalconDotNet.HWindowControl();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Close_System = new Sunny.UI.UIButton();
			this.btn_Minimizid_System = new Sunny.UI.UIButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.text_SheetNums = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Detection = new Sunny.UI.UIButton();
			this.text_SheetNum = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.text_TestDate = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_PathConfirm = new Sunny.UI.UIButton();
			this.label4 = new System.Windows.Forms.Label();
			this.com_SheetNum = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// messageShow3
			// 
			this.messageShow3.BackColor = System.Drawing.Color.Black;
			this.messageShow3.Location = new System.Drawing.Point(85, 21);
			this.messageShow3.Name = "messageShow3";
			this.messageShow3.Size = new System.Drawing.Size(210, 96);
			this.messageShow3.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.hWindowControl4);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(594, 1055);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "工位一显示图";
			// 
			// hWindowControl4
			// 
			this.hWindowControl4.BackColor = System.Drawing.Color.Black;
			this.hWindowControl4.BorderColor = System.Drawing.Color.Black;
			this.hWindowControl4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hWindowControl4.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
			this.hWindowControl4.Location = new System.Drawing.Point(3, 17);
			this.hWindowControl4.Name = "hWindowControl4";
			this.hWindowControl4.Size = new System.Drawing.Size(588, 1035);
			this.hWindowControl4.TabIndex = 0;
			this.hWindowControl4.WindowSize = new System.Drawing.Size(588, 1035);
			this.hWindowControl4.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl4_HMouseDown);
			this.hWindowControl4.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hWindowControl4_HMouseUp);
			this.hWindowControl4.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.hWindowControl4_HMouseWheel);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// messageShow4
			// 
			this.messageShow4.BackColor = System.Drawing.Color.Black;
			this.messageShow4.Location = new System.Drawing.Point(85, 20);
			this.messageShow4.Name = "messageShow4";
			this.messageShow4.Size = new System.Drawing.Size(232, 108);
			this.messageShow4.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.groupBox5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 390);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(390, 134);
			this.panel3.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.messageShow3);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox5.ForeColor = System.Drawing.Color.White;
			this.groupBox5.Location = new System.Drawing.Point(0, 0);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(390, 134);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "瑕疵信息显示1";
			// 
			// hWindowControl3
			// 
			this.hWindowControl3.BackColor = System.Drawing.Color.Black;
			this.hWindowControl3.BorderColor = System.Drawing.Color.Black;
			this.hWindowControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hWindowControl3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
			this.hWindowControl3.Location = new System.Drawing.Point(3, 17);
			this.hWindowControl3.Margin = new System.Windows.Forms.Padding(0);
			this.hWindowControl3.Name = "hWindowControl3";
			this.hWindowControl3.Size = new System.Drawing.Size(384, 361);
			this.hWindowControl3.TabIndex = 3;
			this.hWindowControl3.WindowSize = new System.Drawing.Size(384, 361);
			this.hWindowControl3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hWindowControl3_MouseDown);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.hWindowControl3);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(3, 530);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(390, 381);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "局部瑕疵结果显示2";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.panel5, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(1203, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(396, 1055);
			this.tableLayoutPanel4.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.groupBox6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(3, 917);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(390, 135);
			this.panel5.TabIndex = 1;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.messageShow4);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox6.ForeColor = System.Drawing.Color.White;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(390, 135);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "瑕疵信息显示1";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.hWindowControl2);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(390, 381);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "局部瑕疵结果显示1";
			// 
			// hWindowControl2
			// 
			this.hWindowControl2.BackColor = System.Drawing.Color.Black;
			this.hWindowControl2.BorderColor = System.Drawing.Color.Black;
			this.hWindowControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hWindowControl2.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
			this.hWindowControl2.Location = new System.Drawing.Point(3, 17);
			this.hWindowControl2.Margin = new System.Windows.Forms.Padding(0);
			this.hWindowControl2.Name = "hWindowControl2";
			this.hWindowControl2.Size = new System.Drawing.Size(384, 361);
			this.hWindowControl2.TabIndex = 3;
			this.hWindowControl2.WindowSize = new System.Drawing.Size(384, 361);
			this.hWindowControl2.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl2_HMouseDown);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 322F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1924, 1061);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(603, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(594, 1055);
			this.panel1.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.hWindowControl1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(594, 1055);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "工位二显示图";
			// 
			// hWindowControl1
			// 
			this.hWindowControl1.BackColor = System.Drawing.Color.Black;
			this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
			this.hWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
			this.hWindowControl1.Location = new System.Drawing.Point(3, 17);
			this.hWindowControl1.Name = "hWindowControl1";
			this.hWindowControl1.Size = new System.Drawing.Size(588, 1035);
			this.hWindowControl1.TabIndex = 0;
			this.hWindowControl1.WindowSize = new System.Drawing.Size(588, 1035);
			this.hWindowControl1.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseDown_1);
			this.hWindowControl1.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseUp);
			this.hWindowControl1.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseWheel_1);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(1605, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(316, 1055);
			this.tableLayoutPanel5.TabIndex = 5;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.5F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
			this.tableLayoutPanel2.Controls.Add(this.btn_Close_System, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_Minimizid_System, 2, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 52);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// btn_Close_System
			// 
			this.btn_Close_System.BackColor = System.Drawing.Color.White;
			this.btn_Close_System.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Close_System.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Close_System.FillColor = System.Drawing.Color.Red;
			this.btn_Close_System.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Close_System.FillDisableColor = System.Drawing.Color.Black;
			this.btn_Close_System.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Close_System.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Close_System.FillSelectedColor = System.Drawing.Color.Red;
			this.btn_Close_System.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Close_System.ForeDisableColor = System.Drawing.Color.Silver;
			this.btn_Close_System.Location = new System.Drawing.Point(258, 3);
			this.btn_Close_System.MinimumSize = new System.Drawing.Size(1, 1);
			this.btn_Close_System.Name = "btn_Close_System";
			this.btn_Close_System.RectColor = System.Drawing.Color.Red;
			this.btn_Close_System.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn_Close_System.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Close_System.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Close_System.RectSelectedColor = System.Drawing.Color.Red;
			this.btn_Close_System.Size = new System.Drawing.Size(48, 46);
			this.btn_Close_System.Style = Sunny.UI.UIStyle.Custom;
			this.btn_Close_System.TabIndex = 2;
			this.btn_Close_System.Text = "×";
			this.btn_Close_System.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Close_System.Click += new System.EventHandler(this.btn_Close_System_Click);
			// 
			// btn_Minimizid_System
			// 
			this.btn_Minimizid_System.BackColor = System.Drawing.Color.White;
			this.btn_Minimizid_System.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Minimizid_System.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Minimizid_System.FillColor = System.Drawing.Color.Black;
			this.btn_Minimizid_System.FillColor2 = System.Drawing.Color.Gray;
			this.btn_Minimizid_System.FillDisableColor = System.Drawing.Color.Black;
			this.btn_Minimizid_System.FillHoverColor = System.Drawing.SystemColors.AppWorkspace;
			this.btn_Minimizid_System.FillPressColor = System.Drawing.Color.LightGray;
			this.btn_Minimizid_System.FillSelectedColor = System.Drawing.SystemColors.WindowFrame;
			this.btn_Minimizid_System.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Minimizid_System.ForeDisableColor = System.Drawing.Color.Silver;
			this.btn_Minimizid_System.Location = new System.Drawing.Point(203, 3);
			this.btn_Minimizid_System.MinimumSize = new System.Drawing.Size(1, 1);
			this.btn_Minimizid_System.Name = "btn_Minimizid_System";
			this.btn_Minimizid_System.Size = new System.Drawing.Size(49, 46);
			this.btn_Minimizid_System.Style = Sunny.UI.UIStyle.Custom;
			this.btn_Minimizid_System.TabIndex = 3;
			this.btn_Minimizid_System.Text = "-";
			this.btn_Minimizid_System.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Minimizid_System.Visible = false;
			this.btn_Minimizid_System.Click += new System.EventHandler(this.btn_Minimizid_System_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_PathConfirm);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.com_SheetNum);
			this.panel2.Controls.Add(this.text_SheetNums);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.btn_Detection);
			this.panel2.Controls.Add(this.text_SheetNum);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.text_TestDate);
			this.panel2.Location = new System.Drawing.Point(3, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(310, 225);
			this.panel2.TabIndex = 8;
			// 
			// text_SheetNums
			// 
			this.text_SheetNums.Location = new System.Drawing.Point(76, 51);
			this.text_SheetNums.Name = "text_SheetNums";
			this.text_SheetNums.Size = new System.Drawing.Size(228, 21);
			this.text_SheetNums.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(5, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 18;
			this.label3.Text = "片材批号：";
			// 
			// btn_Detection
			// 
			this.btn_Detection.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Detection.FillColor = System.Drawing.Color.Black;
			this.btn_Detection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Detection.Location = new System.Drawing.Point(208, 160);
			this.btn_Detection.MinimumSize = new System.Drawing.Size(1, 1);
			this.btn_Detection.Name = "btn_Detection";
			this.btn_Detection.Radius = 20;
			this.btn_Detection.Size = new System.Drawing.Size(98, 29);
			this.btn_Detection.Style = Sunny.UI.UIStyle.Custom;
			this.btn_Detection.TabIndex = 17;
			this.btn_Detection.Text = "查找显示";
			this.btn_Detection.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Detection.Click += new System.EventHandler(this.btn_Detection_Click);
			// 
			// text_SheetNum
			// 
			this.text_SheetNum.Location = new System.Drawing.Point(76, 90);
			this.text_SheetNum.Name = "text_SheetNum";
			this.text_SheetNum.Size = new System.Drawing.Size(228, 21);
			this.text_SheetNum.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(5, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "片材编号：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(5, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "检测日期：";
			// 
			// text_TestDate
			// 
			this.text_TestDate.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.text_TestDate.Location = new System.Drawing.Point(76, 14);
			this.text_TestDate.Name = "text_TestDate";
			this.text_TestDate.Size = new System.Drawing.Size(228, 21);
			this.text_TestDate.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1061F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1061);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btn_PathConfirm
			// 
			this.btn_PathConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_PathConfirm.FillColor = System.Drawing.Color.Black;
			this.btn_PathConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_PathConfirm.Location = new System.Drawing.Point(76, 160);
			this.btn_PathConfirm.MinimumSize = new System.Drawing.Size(1, 1);
			this.btn_PathConfirm.Name = "btn_PathConfirm";
			this.btn_PathConfirm.Radius = 20;
			this.btn_PathConfirm.Size = new System.Drawing.Size(98, 29);
			this.btn_PathConfirm.Style = Sunny.UI.UIStyle.Custom;
			this.btn_PathConfirm.TabIndex = 25;
			this.btn_PathConfirm.Text = "路劲确认";
			this.btn_PathConfirm.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_PathConfirm.Click += new System.EventHandler(this.btn_PathConfirm_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(5, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 24;
			this.label4.Text = "批存在ID：";
			// 
			// com_SheetNum
			// 
			this.com_SheetNum.FormattingEnabled = true;
			this.com_SheetNum.Location = new System.Drawing.Point(76, 126);
			this.com_SheetNum.Name = "com_SheetNum";
			this.com_SheetNum.Size = new System.Drawing.Size(228, 20);
			this.com_SheetNum.TabIndex = 23;
			this.com_SheetNum.SelectedIndexChanged += new System.EventHandler(this.com_SheetNum_SelectedIndexChanged);
			// 
			// 复检1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 1061);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "复检1";
			this.Text = "复检1";
			this.Load += new System.EventHandler(this.复检1_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private UserControls.MessageShow messageShow3;
		private System.Windows.Forms.GroupBox groupBox1;
		private HalconDotNet.HWindowControl hWindowControl4;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.GroupBox groupBox4;
		private HalconDotNet.HWindowControl hWindowControl3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.GroupBox groupBox6;
		private UserControls.MessageShow messageShow4;
		private System.Windows.Forms.GroupBox groupBox3;
		private HalconDotNet.HWindowControl hWindowControl2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private HalconDotNet.HWindowControl hWindowControl1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private Sunny.UI.UIButton btn_Close_System;
		private Sunny.UI.UIButton btn_Minimizid_System;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox text_SheetNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox text_TestDate;
		private Sunny.UI.UIButton btn_Detection;
		private System.Windows.Forms.TextBox text_SheetNums;
		private System.Windows.Forms.Label label3;
		private Sunny.UI.UIButton btn_PathConfirm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox com_SheetNum;
	}
}