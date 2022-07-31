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
        /// RGB: 179–210–239
        /// RGB: 129–176–218
        /// RGB: 89–145–194
        /// RGB: 58–116–168
        /// RGB: 33–95–151
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.bracketBtn = new MetroFramework.Controls.MetroButton();
            this.percentBtn = new MetroFramework.Controls.MetroButton();
            this.divBtn = new MetroFramework.Controls.MetroButton();
            this.mulBtn = new MetroFramework.Controls.MetroButton();
            this.minusBtn = new MetroFramework.Controls.MetroButton();
            this.plusBtn = new MetroFramework.Controls.MetroButton();
            this.equalBtn = new MetroFramework.Controls.MetroButton();
            this.numBtn3 = new MetroFramework.Controls.MetroButton();
            this.numBtn6 = new MetroFramework.Controls.MetroButton();
            this.numBtn9 = new MetroFramework.Controls.MetroButton();
            this.numBtn8 = new MetroFramework.Controls.MetroButton();
            this.numBtn5 = new MetroFramework.Controls.MetroButton();
            this.numBtn2 = new MetroFramework.Controls.MetroButton();
            this.numBtn0 = new MetroFramework.Controls.MetroButton();
            this.numBtn1 = new MetroFramework.Controls.MetroButton();
            this.numBtn4 = new MetroFramework.Controls.MetroButton();
            this.numBtn7 = new MetroFramework.Controls.MetroButton();
            this.numBtn00 = new MetroFramework.Controls.MetroButton();
            this.dotBtn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            this.resultScreen = new MetroFramework.Controls.MetroTile();
            this.recentScreen = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.resultScreen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.recentScreen, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.clearBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bracketBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.percentBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.divBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mulBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.minusBtn, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.plusBtn, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.equalBtn, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.numBtn3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.numBtn9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.numBtn8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numBtn5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numBtn2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numBtn1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.numBtn4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numBtn7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numBtn00, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dotBtn, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 181);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 207);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(3, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(69, 35);
            this.clearBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "C";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.UseStyleColors = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // bracketBtn
            // 
            this.bracketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bracketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.bracketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bracketBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bracketBtn.ForeColor = System.Drawing.Color.Black;
            this.bracketBtn.Location = new System.Drawing.Point(78, 3);
            this.bracketBtn.Name = "bracketBtn";
            this.bracketBtn.Size = new System.Drawing.Size(69, 35);
            this.bracketBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.bracketBtn.TabIndex = 0;
            this.bracketBtn.Text = "( )";
            this.bracketBtn.UseSelectable = true;
            this.bracketBtn.UseStyleColors = true;
            this.bracketBtn.Click += new System.EventHandler(this.bracketBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.percentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percentBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.percentBtn.ForeColor = System.Drawing.Color.Black;
            this.percentBtn.Location = new System.Drawing.Point(153, 3);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(69, 35);
            this.percentBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.percentBtn.TabIndex = 0;
            this.percentBtn.Text = "%";
            this.percentBtn.UseSelectable = true;
            this.percentBtn.UseStyleColors = true;
            this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.divBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.divBtn.ForeColor = System.Drawing.Color.Black;
            this.divBtn.Location = new System.Drawing.Point(228, 3);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(69, 35);
            this.divBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.divBtn.TabIndex = 0;
            this.divBtn.Text = "÷";
            this.divBtn.UseSelectable = true;
            this.divBtn.UseStyleColors = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mulBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.mulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mulBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mulBtn.ForeColor = System.Drawing.Color.Black;
            this.mulBtn.Location = new System.Drawing.Point(228, 44);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(69, 35);
            this.mulBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.mulBtn.TabIndex = 0;
            this.mulBtn.Text = "×";
            this.mulBtn.UseSelectable = true;
            this.mulBtn.UseStyleColors = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.minusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.minusBtn.ForeColor = System.Drawing.Color.Black;
            this.minusBtn.Location = new System.Drawing.Point(228, 85);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(69, 35);
            this.minusBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.minusBtn.TabIndex = 0;
            this.minusBtn.Text = "－";
            this.minusBtn.UseSelectable = true;
            this.minusBtn.UseStyleColors = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.plusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusBtn.Location = new System.Drawing.Point(228, 126);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(69, 35);
            this.plusBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.plusBtn.TabIndex = 0;
            this.plusBtn.Text = "＋";
            this.plusBtn.UseSelectable = true;
            this.plusBtn.UseStyleColors = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equalBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.equalBtn.ForeColor = System.Drawing.Color.Black;
            this.equalBtn.Location = new System.Drawing.Point(228, 167);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(69, 37);
            this.equalBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.equalBtn.TabIndex = 0;
            this.equalBtn.Text = "＝";
            this.equalBtn.UseCustomBackColor = true;
            this.equalBtn.UseSelectable = true;
            this.equalBtn.UseStyleColors = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // numBtn3
            // 
            this.numBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn3.ForeColor = System.Drawing.Color.Black;
            this.numBtn3.Location = new System.Drawing.Point(153, 126);
            this.numBtn3.Name = "numBtn3";
            this.numBtn3.Size = new System.Drawing.Size(69, 35);
            this.numBtn3.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn3.TabIndex = 0;
            this.numBtn3.Text = "3";
            this.numBtn3.UseSelectable = true;
            this.numBtn3.UseStyleColors = true;
            this.numBtn3.Click += new System.EventHandler(this.numBtn3_Click);
            // 
            // numBtn6
            // 
            this.numBtn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn6.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn6.ForeColor = System.Drawing.Color.Black;
            this.numBtn6.Location = new System.Drawing.Point(153, 85);
            this.numBtn6.Name = "numBtn6";
            this.numBtn6.Size = new System.Drawing.Size(69, 35);
            this.numBtn6.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn6.TabIndex = 0;
            this.numBtn6.Text = "6";
            this.numBtn6.UseSelectable = true;
            this.numBtn6.UseStyleColors = true;
            this.numBtn6.Click += new System.EventHandler(this.numBtn6_Click);
            // 
            // numBtn9
            // 
            this.numBtn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn9.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn9.ForeColor = System.Drawing.Color.Black;
            this.numBtn9.Location = new System.Drawing.Point(153, 44);
            this.numBtn9.Name = "numBtn9";
            this.numBtn9.Size = new System.Drawing.Size(69, 35);
            this.numBtn9.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn9.TabIndex = 0;
            this.numBtn9.Text = "9";
            this.numBtn9.UseSelectable = true;
            this.numBtn9.UseStyleColors = true;
            this.numBtn9.Click += new System.EventHandler(this.numBtn9_Click);
            // 
            // numBtn8
            // 
            this.numBtn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn8.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn8.ForeColor = System.Drawing.Color.Black;
            this.numBtn8.Location = new System.Drawing.Point(78, 44);
            this.numBtn8.Name = "numBtn8";
            this.numBtn8.Size = new System.Drawing.Size(69, 35);
            this.numBtn8.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn8.TabIndex = 0;
            this.numBtn8.Text = "8";
            this.numBtn8.UseSelectable = true;
            this.numBtn8.UseStyleColors = true;
            this.numBtn8.Click += new System.EventHandler(this.numBtn8_Click);
            // 
            // numBtn5
            // 
            this.numBtn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn5.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn5.ForeColor = System.Drawing.Color.Black;
            this.numBtn5.Location = new System.Drawing.Point(78, 85);
            this.numBtn5.Name = "numBtn5";
            this.numBtn5.Size = new System.Drawing.Size(69, 35);
            this.numBtn5.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn5.TabIndex = 0;
            this.numBtn5.Text = "5";
            this.numBtn5.UseSelectable = true;
            this.numBtn5.UseStyleColors = true;
            this.numBtn5.Click += new System.EventHandler(this.numBtn5_Click);
            // 
            // numBtn2
            // 
            this.numBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn2.ForeColor = System.Drawing.Color.Black;
            this.numBtn2.Location = new System.Drawing.Point(78, 126);
            this.numBtn2.Name = "numBtn2";
            this.numBtn2.Size = new System.Drawing.Size(69, 35);
            this.numBtn2.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn2.TabIndex = 0;
            this.numBtn2.Text = "2";
            this.numBtn2.UseSelectable = true;
            this.numBtn2.UseStyleColors = true;
            this.numBtn2.Click += new System.EventHandler(this.numBtn2_Click);
            // 
            // numBtn0
            // 
            this.numBtn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn0.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn0.ForeColor = System.Drawing.Color.Black;
            this.numBtn0.Location = new System.Drawing.Point(78, 167);
            this.numBtn0.Name = "numBtn0";
            this.numBtn0.Size = new System.Drawing.Size(69, 37);
            this.numBtn0.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn0.TabIndex = 0;
            this.numBtn0.Text = "0";
            this.numBtn0.UseSelectable = true;
            this.numBtn0.UseStyleColors = true;
            this.numBtn0.Click += new System.EventHandler(this.numBtn0_Click);
            // 
            // numBtn1
            // 
            this.numBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn1.ForeColor = System.Drawing.Color.Black;
            this.numBtn1.Location = new System.Drawing.Point(3, 126);
            this.numBtn1.Name = "numBtn1";
            this.numBtn1.Size = new System.Drawing.Size(69, 35);
            this.numBtn1.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn1.TabIndex = 0;
            this.numBtn1.Text = "1";
            this.numBtn1.UseSelectable = true;
            this.numBtn1.UseStyleColors = true;
            this.numBtn1.Click += new System.EventHandler(this.numBtn1_Click);
            // 
            // numBtn4
            // 
            this.numBtn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn4.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn4.ForeColor = System.Drawing.Color.Black;
            this.numBtn4.Location = new System.Drawing.Point(3, 85);
            this.numBtn4.Name = "numBtn4";
            this.numBtn4.Size = new System.Drawing.Size(69, 35);
            this.numBtn4.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn4.TabIndex = 0;
            this.numBtn4.Text = "4";
            this.numBtn4.UseSelectable = true;
            this.numBtn4.UseStyleColors = true;
            this.numBtn4.Click += new System.EventHandler(this.numBtn4_Click);
            // 
            // numBtn7
            // 
            this.numBtn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn7.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn7.ForeColor = System.Drawing.Color.Black;
            this.numBtn7.Location = new System.Drawing.Point(3, 44);
            this.numBtn7.Name = "numBtn7";
            this.numBtn7.Size = new System.Drawing.Size(69, 35);
            this.numBtn7.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn7.TabIndex = 0;
            this.numBtn7.Text = "7";
            this.numBtn7.UseSelectable = true;
            this.numBtn7.UseStyleColors = true;
            this.numBtn7.Click += new System.EventHandler(this.numBtn7_Click);
            // 
            // numBtn00
            // 
            this.numBtn00.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numBtn00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.numBtn00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBtn00.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.numBtn00.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.numBtn00.ForeColor = System.Drawing.Color.Black;
            this.numBtn00.Location = new System.Drawing.Point(3, 167);
            this.numBtn00.Name = "numBtn00";
            this.numBtn00.Size = new System.Drawing.Size(69, 37);
            this.numBtn00.Style = MetroFramework.MetroColorStyle.Black;
            this.numBtn00.TabIndex = 0;
            this.numBtn00.Text = "00";
            this.numBtn00.UseSelectable = true;
            this.numBtn00.UseStyleColors = true;
            this.numBtn00.Click += new System.EventHandler(this.numBtn00_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(210)))), ((int)(((byte)(239)))));
            this.dotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.dotBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.dotBtn.ForeColor = System.Drawing.Color.Black;
            this.dotBtn.Location = new System.Drawing.Point(153, 167);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(69, 37);
            this.dotBtn.Style = MetroFramework.MetroColorStyle.Black;
            this.dotBtn.TabIndex = 0;
            this.dotBtn.Text = ".";
            this.dotBtn.UseSelectable = true;
            this.dotBtn.UseStyleColors = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.delBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 31);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.Location = new System.Drawing.Point(228, 3);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(69, 25);
            this.delBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "←";
            this.delBtn.UseCustomBackColor = true;
            this.delBtn.UseSelectable = true;
            this.delBtn.UseStyleColors = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // resultScreen
            // 
            this.resultScreen.ActiveControl = null;
            this.resultScreen.BackColor = System.Drawing.Color.White;
            this.resultScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultScreen.Enabled = false;
            this.resultScreen.Location = new System.Drawing.Point(3, 3);
            this.resultScreen.Name = "resultScreen";
            this.resultScreen.PaintTileCount = false;
            this.resultScreen.Size = new System.Drawing.Size(300, 82);
            this.resultScreen.TabIndex = 3;
            this.resultScreen.Text = "resultScreen";
            this.resultScreen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.resultScreen.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.resultScreen.UseCustomBackColor = true;
            this.resultScreen.UseCustomForeColor = true;
            this.resultScreen.UseSelectable = true;
            // 
            // recentScreen
            // 
            this.recentScreen.ActiveControl = null;
            this.recentScreen.BackColor = System.Drawing.Color.White;
            this.recentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentScreen.Enabled = false;
            this.recentScreen.Location = new System.Drawing.Point(3, 91);
            this.recentScreen.Name = "recentScreen";
            this.recentScreen.PaintTileCount = false;
            this.recentScreen.Size = new System.Drawing.Size(300, 47);
            this.recentScreen.TabIndex = 2;
            this.recentScreen.Text = "recentScreen";
            this.recentScreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.recentScreen.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.recentScreen.UseCustomBackColor = true;
            this.recentScreen.UseCustomForeColor = true;
            this.recentScreen.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 9);
            this.Text = "Calculator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MetroFramework.Controls.MetroButton numBtn00;
        private MetroFramework.Controls.MetroButton dotBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton delBtn;
        private MetroFramework.Controls.MetroTile recentScreen;
        private MetroFramework.Controls.MetroTile resultScreen;
    }
}

