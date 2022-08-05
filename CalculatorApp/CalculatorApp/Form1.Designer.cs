namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.recentScreen = new MetroFramework.Controls.MetroTextBox();
            this.resultScreen = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            this.equalBtn = new MetroFramework.Controls.MetroButton();
            this.dotBtn = new MetroFramework.Controls.MetroButton();
            this.numBtn0 = new MetroFramework.Controls.MetroButton();
            this.plusMinusBtn = new MetroFramework.Controls.MetroButton();
            this.numBtn1 = new MetroFramework.Controls.MetroButton();
            this.numBtn2 = new MetroFramework.Controls.MetroButton();
            this.numBtn3 = new MetroFramework.Controls.MetroButton();
            this.plusBtn = new MetroFramework.Controls.MetroButton();
            this.minusBtn = new MetroFramework.Controls.MetroButton();
            this.numBtn6 = new MetroFramework.Controls.MetroButton();
            this.numBtn5 = new MetroFramework.Controls.MetroButton();
            this.numBtn4 = new MetroFramework.Controls.MetroButton();
            this.numBtn7 = new MetroFramework.Controls.MetroButton();
            this.numBtn8 = new MetroFramework.Controls.MetroButton();
            this.numBtn9 = new MetroFramework.Controls.MetroButton();
            this.mulBtn = new MetroFramework.Controls.MetroButton();
            this.divBtn = new MetroFramework.Controls.MetroButton();
            this.bracketBtn = new MetroFramework.Controls.MetroButton();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.percentBtn = new MetroFramework.Controls.MetroButton();
            this.rootBtn = new MetroFramework.Controls.MetroButton();
            this.inverseBtn = new MetroFramework.Controls.MetroButton();
            this.squaredBtn = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.logList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClearBtn = new MetroFramework.Controls.MetroButton();
            this.userToggleButton1 = new CalculatorApp.UserControls.UserToggleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.recentScreen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.resultScreen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userToggleButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // recentScreen
            // 
            // 
            // 
            // 
            this.recentScreen.CustomButton.Image = null;
            this.recentScreen.CustomButton.Location = new System.Drawing.Point(255, 2);
            this.recentScreen.CustomButton.Name = "";
            this.recentScreen.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.recentScreen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.recentScreen.CustomButton.TabIndex = 1;
            this.recentScreen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recentScreen.CustomButton.UseSelectable = true;
            this.recentScreen.CustomButton.Visible = false;
            this.recentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentScreen.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.recentScreen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recentScreen.Lines = new string[] {
        "RecentScreen"};
            this.recentScreen.Location = new System.Drawing.Point(3, 100);
            this.recentScreen.MaxLength = 32767;
            this.recentScreen.Multiline = true;
            this.recentScreen.Name = "recentScreen";
            this.recentScreen.PasswordChar = '\0';
            this.recentScreen.ReadOnly = true;
            this.recentScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recentScreen.SelectedText = "";
            this.recentScreen.SelectionLength = 0;
            this.recentScreen.SelectionStart = 0;
            this.recentScreen.ShortcutsEnabled = true;
            this.recentScreen.Size = new System.Drawing.Size(305, 52);
            this.recentScreen.TabIndex = 3;
            this.recentScreen.Text = "RecentScreen";
            this.recentScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.recentScreen.UseCustomForeColor = true;
            this.recentScreen.UseSelectable = true;
            this.recentScreen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recentScreen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // resultScreen
            // 
            this.resultScreen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.resultScreen.CustomButton.Image = null;
            this.resultScreen.CustomButton.Location = new System.Drawing.Point(235, 2);
            this.resultScreen.CustomButton.Name = "";
            this.resultScreen.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.resultScreen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resultScreen.CustomButton.TabIndex = 1;
            this.resultScreen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resultScreen.CustomButton.UseSelectable = true;
            this.resultScreen.CustomButton.Visible = false;
            this.resultScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultScreen.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.resultScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultScreen.Lines = new string[] {
        "ResultScreen"};
            this.resultScreen.Location = new System.Drawing.Point(3, 22);
            this.resultScreen.MaxLength = 32767;
            this.resultScreen.Multiline = true;
            this.resultScreen.Name = "resultScreen";
            this.resultScreen.PasswordChar = '\0';
            this.resultScreen.ReadOnly = true;
            this.resultScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultScreen.SelectedText = "";
            this.resultScreen.SelectionLength = 0;
            this.resultScreen.SelectionStart = 0;
            this.resultScreen.ShortcutsEnabled = true;
            this.resultScreen.Size = new System.Drawing.Size(305, 72);
            this.resultScreen.TabIndex = 2;
            this.resultScreen.Text = "ResultScreen";
            this.resultScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultScreen.UseCustomBackColor = true;
            this.resultScreen.UseCustomForeColor = true;
            this.resultScreen.UseSelectable = true;
            this.resultScreen.WaterMarkColor = System.Drawing.SystemColors.ControlText;
            this.resultScreen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resultScreen.TextChanged += new System.EventHandler(this.ResultScreen_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AllowDrop = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.delBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.equalBtn, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.dotBtn, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.numBtn0, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.plusMinusBtn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.numBtn1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numBtn2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numBtn3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.plusBtn, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.minusBtn, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numBtn8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numBtn9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.mulBtn, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.divBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bracketBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.percentBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rootBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.inverseBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.squaredBtn, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 158);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(305, 230);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // delBtn
            // 
            this.delBtn.AutoSize = true;
            this.delBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.Location = new System.Drawing.Point(231, 3);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(71, 32);
            this.delBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "←";
            this.delBtn.UseCustomBackColor = true;
            this.delBtn.UseSelectable = true;
            this.delBtn.UseStyleColors = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.equalBtn.ForeColor = System.Drawing.Color.Black;
            this.equalBtn.Location = new System.Drawing.Point(231, 193);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(71, 34);
            this.equalBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.equalBtn.TabIndex = 0;
            this.equalBtn.Text = "＝";
            this.equalBtn.UseCustomBackColor = true;
            this.equalBtn.UseSelectable = true;
            this.equalBtn.UseStyleColors = true;
            this.equalBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            this.equalBtn.Leave += new System.EventHandler(this.EqualBtn_Leave);
            // 
            // dotBtn
            // 
            this.dotBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.dotBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.dotBtn.ForeColor = System.Drawing.Color.Black;
            this.dotBtn.Location = new System.Drawing.Point(155, 193);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(70, 34);
            this.dotBtn.TabIndex = 0;
            this.dotBtn.Text = ".";
            this.dotBtn.UseCustomBackColor = true;
            this.dotBtn.UseCustomForeColor = true;
            this.dotBtn.UseSelectable = true;
            this.dotBtn.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn0
            // 
            this.numBtn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn0.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn0.ForeColor = System.Drawing.Color.Black;
            this.numBtn0.Location = new System.Drawing.Point(79, 193);
            this.numBtn0.Name = "numBtn0";
            this.numBtn0.Size = new System.Drawing.Size(70, 34);
            this.numBtn0.TabIndex = 0;
            this.numBtn0.Text = "0";
            this.numBtn0.UseCustomBackColor = true;
            this.numBtn0.UseCustomForeColor = true;
            this.numBtn0.UseSelectable = true;
            this.numBtn0.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // plusMinusBtn
            // 
            this.plusMinusBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plusMinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusMinusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusMinusBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.plusMinusBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.plusMinusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusMinusBtn.Location = new System.Drawing.Point(3, 193);
            this.plusMinusBtn.Name = "plusMinusBtn";
            this.plusMinusBtn.Size = new System.Drawing.Size(70, 34);
            this.plusMinusBtn.TabIndex = 0;
            this.plusMinusBtn.Text = "±";
            this.plusMinusBtn.UseCustomBackColor = true;
            this.plusMinusBtn.UseCustomForeColor = true;
            this.plusMinusBtn.UseSelectable = true;
            this.plusMinusBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // numBtn1
            // 
            this.numBtn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn1.ForeColor = System.Drawing.Color.Black;
            this.numBtn1.Location = new System.Drawing.Point(3, 155);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(70, 32);
            this.numBtn1.TabIndex = 0;
            this.numBtn1.Text = "1";
            this.numBtn1.UseCustomBackColor = true;
            this.numBtn1.UseCustomForeColor = true;
            this.numBtn1.UseSelectable = true;
            this.numBtn1.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn2
            // 
            this.numBtn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn2.ForeColor = System.Drawing.Color.Black;
            this.numBtn2.Location = new System.Drawing.Point(79, 155);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(70, 32);
            this.numBtn2.TabIndex = 0;
            this.numBtn2.Text = "2";
            this.numBtn2.UseCustomBackColor = true;
            this.numBtn2.UseCustomForeColor = true;
            this.numBtn2.UseSelectable = true;
            this.numBtn2.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn3
            // 
            this.numBtn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn3.ForeColor = System.Drawing.Color.Black;
            this.numBtn3.Location = new System.Drawing.Point(155, 155);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(70, 32);
            this.numBtn3.TabIndex = 0;
            this.numBtn3.Text = "3";
            this.numBtn3.UseCustomBackColor = true;
            this.numBtn3.UseCustomForeColor = true;
            this.numBtn3.UseSelectable = true;
            this.numBtn3.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.plusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusBtn.Location = new System.Drawing.Point(231, 155);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(71, 32);
            this.plusBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.plusBtn.TabIndex = 0;
            this.plusBtn.Text = "+";
            this.plusBtn.UseSelectable = true;
            this.plusBtn.UseStyleColors = true;
            this.plusBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.minusBtn.ForeColor = System.Drawing.Color.Black;
            this.minusBtn.Location = new System.Drawing.Point(231, 117);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(71, 32);
            this.minusBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.minusBtn.TabIndex = 0;
            this.minusBtn.Text = "-";
            this.minusBtn.UseSelectable = true;
            this.minusBtn.UseStyleColors = true;
            this.minusBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // numBtn6
            // 
            this.numBtn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn6.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn6.ForeColor = System.Drawing.Color.Black;
            this.numBtn6.Location = new System.Drawing.Point(155, 117);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(70, 32);
            this.numBtn6.TabIndex = 0;
            this.numBtn6.Text = "6";
            this.numBtn6.UseCustomBackColor = true;
            this.numBtn6.UseCustomForeColor = true;
            this.numBtn6.UseSelectable = true;
            this.numBtn6.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn5
            // 
            this.numBtn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn5.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn5.ForeColor = System.Drawing.Color.Black;
            this.numBtn5.Location = new System.Drawing.Point(79, 117);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(70, 32);
            this.numBtn5.TabIndex = 0;
            this.numBtn5.Text = "5";
            this.numBtn5.UseCustomBackColor = true;
            this.numBtn5.UseCustomForeColor = true;
            this.numBtn5.UseSelectable = true;
            this.numBtn5.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn4
            // 
            this.numBtn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn4.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn4.ForeColor = System.Drawing.Color.Black;
            this.numBtn4.Location = new System.Drawing.Point(3, 117);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(70, 32);
            this.numBtn4.TabIndex = 0;
            this.numBtn4.Text = "4";
            this.numBtn4.UseCustomBackColor = true;
            this.numBtn4.UseCustomForeColor = true;
            this.numBtn4.UseSelectable = true;
            this.numBtn4.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn7
            // 
            this.numBtn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn7.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn7.ForeColor = System.Drawing.Color.Black;
            this.numBtn7.Location = new System.Drawing.Point(3, 79);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(70, 32);
            this.numBtn7.TabIndex = 0;
            this.numBtn7.Text = "7";
            this.numBtn7.UseCustomBackColor = true;
            this.numBtn7.UseCustomForeColor = true;
            this.numBtn7.UseSelectable = true;
            this.numBtn7.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn8
            // 
            this.numBtn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn8.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn8.ForeColor = System.Drawing.Color.Black;
            this.numBtn8.Location = new System.Drawing.Point(79, 79);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(70, 32);
            this.numBtn8.TabIndex = 0;
            this.numBtn8.Text = "8";
            this.numBtn8.UseCustomBackColor = true;
            this.numBtn8.UseCustomForeColor = true;
            this.numBtn8.UseSelectable = true;
            this.numBtn8.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // numBtn9
            // 
            this.numBtn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBtn9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn9.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn9.ForeColor = System.Drawing.Color.Black;
            this.numBtn9.Location = new System.Drawing.Point(155, 79);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(70, 32);
            this.numBtn9.TabIndex = 0;
            this.numBtn9.Text = "9";
            this.numBtn9.UseCustomBackColor = true;
            this.numBtn9.UseCustomForeColor = true;
            this.numBtn9.UseSelectable = true;
            this.numBtn9.Click += new System.EventHandler(this.NumBtnClickEvent);
            // 
            // mulBtn
            // 
            this.mulBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.mulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mulBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mulBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mulBtn.ForeColor = System.Drawing.Color.Black;
            this.mulBtn.Location = new System.Drawing.Point(231, 79);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(71, 32);
            this.mulBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.mulBtn.TabIndex = 0;
            this.mulBtn.Text = "*";
            this.mulBtn.UseSelectable = true;
            this.mulBtn.UseStyleColors = true;
            this.mulBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.divBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.divBtn.ForeColor = System.Drawing.Color.Black;
            this.divBtn.Location = new System.Drawing.Point(231, 41);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(71, 32);
            this.divBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.divBtn.TabIndex = 0;
            this.divBtn.Text = "/";
            this.divBtn.UseSelectable = true;
            this.divBtn.UseStyleColors = true;
            this.divBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // bracketBtn
            // 
            this.bracketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.bracketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bracketBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bracketBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bracketBtn.ForeColor = System.Drawing.Color.Black;
            this.bracketBtn.Location = new System.Drawing.Point(79, 3);
            this.bracketBtn.Name = "bracketBtn";
            this.bracketBtn.Size = new System.Drawing.Size(70, 32);
            this.bracketBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.bracketBtn.TabIndex = 0;
            this.bracketBtn.Text = "( )";
            this.bracketBtn.UseSelectable = true;
            this.bracketBtn.UseStyleColors = true;
            this.bracketBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(155, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(70, 32);
            this.clearBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "C";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.UseStyleColors = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.percentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.percentBtn.ForeColor = System.Drawing.Color.Black;
            this.percentBtn.Location = new System.Drawing.Point(3, 3);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(70, 32);
            this.percentBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.percentBtn.TabIndex = 0;
            this.percentBtn.Text = "%";
            this.percentBtn.UseSelectable = true;
            this.percentBtn.UseStyleColors = true;
            this.percentBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // rootBtn
            // 
            this.rootBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.rootBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rootBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.rootBtn.ForeColor = System.Drawing.Color.Black;
            this.rootBtn.Location = new System.Drawing.Point(155, 41);
            this.rootBtn.Name = "rootBtn";
            this.rootBtn.Size = new System.Drawing.Size(70, 32);
            this.rootBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.rootBtn.TabIndex = 0;
            this.rootBtn.Text = "√";
            this.rootBtn.UseSelectable = true;
            this.rootBtn.UseStyleColors = true;
            this.rootBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // inverseBtn
            // 
            this.inverseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.inverseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inverseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inverseBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.inverseBtn.ForeColor = System.Drawing.Color.Black;
            this.inverseBtn.Location = new System.Drawing.Point(3, 41);
            this.inverseBtn.Name = "inverseBtn";
            this.inverseBtn.Size = new System.Drawing.Size(70, 32);
            this.inverseBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.inverseBtn.TabIndex = 0;
            this.inverseBtn.Text = "1/x";
            this.inverseBtn.UseSelectable = true;
            this.inverseBtn.UseStyleColors = true;
            this.inverseBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // squaredBtn
            // 
            this.squaredBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.squaredBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squaredBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squaredBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.squaredBtn.ForeColor = System.Drawing.Color.Black;
            this.squaredBtn.Location = new System.Drawing.Point(79, 41);
            this.squaredBtn.Name = "squaredBtn";
            this.squaredBtn.Size = new System.Drawing.Size(70, 32);
            this.squaredBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.squaredBtn.TabIndex = 0;
            this.squaredBtn.Text = "^";
            this.squaredBtn.UseSelectable = true;
            this.squaredBtn.UseStyleColors = true;
            this.squaredBtn.Click += new System.EventHandler(this.OpBtnClickEvent);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroTabControl1);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(632, 391);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(317, 391);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel4);
            this.metroTabPage1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage1.HorizontalScrollbarBarColor = false;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(309, 343);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "기록";
            this.metroTabPage1.UseCustomForeColor = true;
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = false;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.logList, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.listClearBtn, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(309, 343);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // logList
            // 
            this.logList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.logList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logList.FullRowSelect = true;
            this.logList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.logList.Location = new System.Drawing.Point(3, 23);
            this.logList.Name = "logList";
            this.logList.OwnerDraw = true;
            this.logList.Size = new System.Drawing.Size(303, 317);
            this.logList.TabIndex = 2;
            this.logList.UseCompatibleStateImageBehavior = false;
            this.logList.UseSelectable = true;
            this.logList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "계산기록";
            this.columnHeader1.Width = 300;
            // 
            // listClearBtn
            // 
            this.listClearBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.listClearBtn.Location = new System.Drawing.Point(231, 3);
            this.listClearBtn.Name = "listClearBtn";
            this.listClearBtn.Size = new System.Drawing.Size(75, 14);
            this.listClearBtn.TabIndex = 3;
            this.listClearBtn.Text = "기록 지우기";
            this.listClearBtn.UseSelectable = true;
            this.listClearBtn.Click += new System.EventHandler(this.ListClearBtn_Click);
            // 
            // userToggleButton1
            // 
            this.userToggleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userToggleButton1.Checked = true;
            this.userToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userToggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userToggleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.userToggleButton1.Location = new System.Drawing.Point(277, 2);
            this.userToggleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.userToggleButton1.MaximumSize = new System.Drawing.Size(40, 20);
            this.userToggleButton1.MinimumSize = new System.Drawing.Size(32, 16);
            this.userToggleButton1.Name = "userToggleButton1";
            this.userToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.userToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.userToggleButton1.OnBackColor = System.Drawing.Color.DarkTurquoise;
            this.userToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.userToggleButton1.Size = new System.Drawing.Size(32, 16);
            this.userToggleButton1.TabIndex = 2;
            this.userToggleButton1.UseVisualStyleBackColor = true;
            this.userToggleButton1.CheckedChanged += new System.EventHandler(this.UserToggleButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 460);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(326, 460);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 9);
            this.Text = "Calculator ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton clearBtn;
        private MetroFramework.Controls.MetroButton bracketBtn;
        private MetroFramework.Controls.MetroButton percentBtn;
        private MetroFramework.Controls.MetroButton divBtn;
        private MetroFramework.Controls.MetroButton mulBtn;
        private MetroFramework.Controls.MetroButton minusBtn;
        private MetroFramework.Controls.MetroButton plusBtn;
        private MetroFramework.Controls.MetroButton equalBtn;
        private MetroFramework.Controls.MetroButton numBtn3;
        private MetroFramework.Controls.MetroButton numBtn6;
        private MetroFramework.Controls.MetroButton numBtn9;
        private MetroFramework.Controls.MetroButton numBtn8;
        private MetroFramework.Controls.MetroButton numBtn5;
        private MetroFramework.Controls.MetroButton numBtn2;
        private MetroFramework.Controls.MetroButton numBtn0;
        private MetroFramework.Controls.MetroButton numBtn1;
        private MetroFramework.Controls.MetroButton numBtn4;
        private MetroFramework.Controls.MetroButton numBtn7;
        private MetroFramework.Controls.MetroButton plusMinusBtn;
        private MetroFramework.Controls.MetroButton dotBtn;
        private MetroFramework.Controls.MetroButton delBtn;
        private UserControls.UserToggleButton userToggleButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroListView logList;
        private MetroFramework.Controls.MetroButton inverseBtn;
        private MetroFramework.Controls.MetroButton rootBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton listClearBtn;
        private MetroFramework.Controls.MetroButton squaredBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroTextBox resultScreen;
        private MetroFramework.Controls.MetroTextBox recentScreen;
    }
}

