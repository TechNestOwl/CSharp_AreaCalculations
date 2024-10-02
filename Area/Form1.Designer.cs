namespace Area
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            areaTitle = new Label();
            witdthLbl = new Label();
            areaLbl = new Label();
            calcBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            circleRadio = new RadioButton();
            squareRadio = new RadioButton();
            rectRadio = new RadioButton();
            widthTxtBox = new TextBox();
            areaTxtBox = new TextBox();
            topTxtBox = new TextBox();
            topLabel = new Label();
            fileMenu = new MenuStrip();
            choiceToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            fileMenu.SuspendLayout();
            SuspendLayout();
            // 
            // areaTitle
            // 
            areaTitle.AutoSize = true;
            areaTitle.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            areaTitle.Location = new Point(391, 47);
            areaTitle.Name = "areaTitle";
            areaTitle.Size = new Size(61, 30);
            areaTitle.TabIndex = 0;
            areaTitle.Text = "Area";
            areaTitle.TextAlign = ContentAlignment.TopCenter;
            areaTitle.Click += areaTitle_Click;
            // 
            // witdthLbl
            // 
            witdthLbl.AutoSize = true;
            witdthLbl.Location = new Point(520, 193);
            witdthLbl.Name = "witdthLbl";
            witdthLbl.Size = new Size(49, 20);
            witdthLbl.TabIndex = 2;
            witdthLbl.Text = "Width";
            // 
            // areaLbl
            // 
            areaLbl.AutoSize = true;
            areaLbl.Location = new Point(279, 325);
            areaLbl.Name = "areaLbl";
            areaLbl.Size = new Size(40, 20);
            areaLbl.TabIndex = 3;
            areaLbl.Text = "Area";
            // 
            // calcBtn
            // 
            calcBtn.BackColor = Color.LightSkyBlue;
            calcBtn.Location = new Point(154, 414);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(95, 28);
            calcBtn.TabIndex = 4;
            calcBtn.Text = "Calc Area";
            calcBtn.UseVisualStyleBackColor = false;
            calcBtn.Click += calcBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.GradientInactiveCaption;
            clearBtn.Location = new Point(363, 414);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(95, 28);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.LightSalmon;
            exitBtn.Location = new Point(590, 414);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(95, 28);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // circleRadio
            // 
            circleRadio.AutoSize = true;
            circleRadio.Location = new Point(258, 191);
            circleRadio.Name = "circleRadio";
            circleRadio.Size = new Size(64, 24);
            circleRadio.TabIndex = 7;
            circleRadio.TabStop = true;
            circleRadio.Text = "Circle";
            circleRadio.UseVisualStyleBackColor = true;
            circleRadio.CheckedChanged += circleRadio_CheckedChanged;
            // 
            // squareRadio
            // 
            squareRadio.AutoSize = true;
            squareRadio.Location = new Point(258, 157);
            squareRadio.Name = "squareRadio";
            squareRadio.Size = new Size(73, 24);
            squareRadio.TabIndex = 8;
            squareRadio.TabStop = true;
            squareRadio.Text = "Square";
            squareRadio.UseVisualStyleBackColor = true;
            squareRadio.CheckedChanged += squareRadio_CheckedChanged;
            // 
            // rectRadio
            // 
            rectRadio.AutoSize = true;
            rectRadio.Location = new Point(258, 116);
            rectRadio.Name = "rectRadio";
            rectRadio.Size = new Size(93, 24);
            rectRadio.TabIndex = 9;
            rectRadio.TabStop = true;
            rectRadio.Text = "Rectangle";
            rectRadio.UseVisualStyleBackColor = true;
            rectRadio.CheckedChanged += rectRadio_CheckedChanged;
            // 
            // widthTxtBox
            // 
            widthTxtBox.Location = new Point(590, 187);
            widthTxtBox.Name = "widthTxtBox";
            widthTxtBox.Size = new Size(125, 26);
            widthTxtBox.TabIndex = 11;
            widthTxtBox.TextChanged += widthTxtBox_TextChanged;
            // 
            // areaTxtBox
            // 
            areaTxtBox.Location = new Point(363, 322);
            areaTxtBox.Name = "areaTxtBox";
            areaTxtBox.Size = new Size(125, 26);
            areaTxtBox.TabIndex = 12;
            areaTxtBox.TextChanged += areaTxtBox_TextChanged;
            // 
            // topTxtBox
            // 
            topTxtBox.Location = new Point(590, 116);
            topTxtBox.Name = "topTxtBox";
            topTxtBox.Size = new Size(120, 26);
            topTxtBox.TabIndex = 15;
            topTxtBox.TextChanged += topTxtBox_TextChanged;
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Location = new Point(515, 116);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(54, 20);
            topLabel.TabIndex = 16;
            topLabel.Text = "Height";
            topLabel.Click += topLabel_Click;
            // 
            // fileMenu
            // 
            fileMenu.ImageScalingSize = new Size(19, 19);
            fileMenu.Items.AddRange(new ToolStripItem[] { choiceToolStripMenuItem, clearToolStripMenuItem, exitToolStripMenuItem });
            fileMenu.Location = new Point(0, 0);
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(914, 28);
            fileMenu.TabIndex = 17;
            fileMenu.Text = "File Menu";
            // 
            // choiceToolStripMenuItem
            // 
            choiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleToolStripMenuItem, circleToolStripMenuItem, squareToolStripMenuItem });
            choiceToolStripMenuItem.Name = "choiceToolStripMenuItem";
            choiceToolStripMenuItem.Size = new Size(68, 24);
            choiceToolStripMenuItem.Text = "Choice";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(157, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(157, 26);
            circleToolStripMenuItem.Text = "Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(157, 26);
            squareToolStripMenuItem.Text = "Square";
            squareToolStripMenuItem.Click += squareToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(57, 24);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Rectangle", "Circle", "Square" });
            comboBox1.Location = new Point(48, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 27);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Rectangle ", "Circle", "Square" });
            listBox1.Location = new Point(49, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(144, 99);
            listBox1.TabIndex = 19;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 503);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(topLabel);
            Controls.Add(topTxtBox);
            Controls.Add(areaTxtBox);
            Controls.Add(widthTxtBox);
            Controls.Add(rectRadio);
            Controls.Add(squareRadio);
            Controls.Add(circleRadio);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calcBtn);
            Controls.Add(areaLbl);
            Controls.Add(witdthLbl);
            Controls.Add(areaTitle);
            Controls.Add(fileMenu);
            MainMenuStrip = fileMenu;
            Name = "Form1";
            Text = "C# Area Form";
            Load += Form1_Load;
            fileMenu.ResumeLayout(false);
            fileMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void RectRadio_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private Label areaTitle;
        private Label radiusLbl;
        private Label witdthLbl;
        private Label areaLbl;
        private Button calcBtn;
        private Button clearBtn;
        private Button exitBtn;
        private RadioButton circleRadio;
        private RadioButton squareRadio;
        private RadioButton rectRadio;
        private TextBox radiusTxtBox;
        private TextBox widthTxtBox;
        private TextBox areaTxtBox;
        private TextBox heightTxtBox;
        private TextBox topTxtBox;
        private Label topLabel;
        private MenuStrip fileMenu;
        private ToolStripMenuItem choiceToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}
