namespace OSManagementSystem
{
    partial class MainForm
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
            mainTabControl = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            button11 = new Button();
            button10 = new Button();
            textBox2 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            btnRefresh = new Button();
            richTextBox2 = new RichTextBox();
            listViewDevices = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1 = new Panel();
            btnRefreshDevices = new Button();
            tabPage4 = new TabPage();
            button18 = new Button();
            button17 = new Button();
            btnClose = new Button();
            listBoxResults = new ListBox();
            folderCreationPath = new TextBox();
            fileCreationPath = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            btnListDirectories = new Button();
            btnListFiles = new Button();
            btnCreateDirectory = new Button();
            btnCreateFile = new Button();
            tabPage5 = new TabPage();
            listBox2 = new ListBox();
            button16 = new Button();
            button15 = new Button();
            panel3 = new Panel();
            tabPage6 = new TabPage();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            listBox3 = new ListBox();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            listBox4 = new ListBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            mainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Controls.Add(tabPage2);
            mainTabControl.Controls.Add(tabPage3);
            mainTabControl.Controls.Add(tabPage4);
            mainTabControl.Controls.Add(tabPage5);
            mainTabControl.Controls.Add(tabPage6);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1002, 712);
            mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Lavender;
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(button14);
            tabPage1.Controls.Add(button13);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(994, 674);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Memory Management";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(527, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(461, 254);
            listBox1.TabIndex = 7;
            // 
            // button14
            // 
            button14.BackColor = Color.DodgerBlue;
            button14.Location = new Point(469, 534);
            button14.Name = "button14";
            button14.Size = new Size(112, 34);
            button14.TabIndex = 6;
            button14.Text = "Close";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.DodgerBlue;
            button13.Location = new Point(156, 450);
            button13.Name = "button13";
            button13.Size = new Size(180, 34);
            button13.TabIndex = 5;
            button13.Text = "Show Detailed Info";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DodgerBlue;
            button12.Location = new Point(721, 450);
            button12.Name = "button12";
            button12.Size = new Size(150, 34);
            button12.TabIndex = 4;
            button12.Text = "Refresh Drives";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 127);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 3;
            label2.Text = "Availble Drives";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 127);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 2;
            label1.Text = "Drive Details";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 158);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(408, 254);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Lavender;
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(994, 674);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Process Management";
            // 
            // button11
            // 
            button11.Location = new Point(644, 549);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 12;
            button11.Text = "Close";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(265, 549);
            button10.Name = "button10";
            button10.Size = new Size(152, 34);
            button10.TabIndex = 11;
            button10.Text = "Kill Process";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(540, 31);
            textBox2.TabIndex = 10;
            textBox2.Text = "Which Process Would you like to start today?\U0001fae0\U0001fae0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button9
            // 
            button9.Location = new Point(265, 390);
            button9.Name = "button9";
            button9.Size = new Size(144, 34);
            button9.TabIndex = 9;
            button9.Text = "Notepad";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(265, 260);
            button8.Name = "button8";
            button8.Size = new Size(144, 34);
            button8.TabIndex = 8;
            button8.Text = "Calculator";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(730, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(265, 147);
            button7.Name = "button7";
            button7.Size = new Size(152, 34);
            button7.TabIndex = 6;
            button7.Text = "Publisher";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(50, 390);
            button6.Name = "button6";
            button6.Size = new Size(144, 34);
            button6.TabIndex = 5;
            button6.Text = "Power Point";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(50, 260);
            button4.Name = "button4";
            button4.Size = new Size(144, 34);
            button4.TabIndex = 4;
            button4.Text = "Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(50, 146);
            button3.Name = "button3";
            button3.Size = new Size(144, 34);
            button3.TabIndex = 3;
            button3.Text = " Word";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(354, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "PROCESS MANAGEMENT";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Lavender;
            tabPage3.Controls.Add(btnRefresh);
            tabPage3.Controls.Add(richTextBox2);
            tabPage3.Controls.Add(listViewDevices);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(994, 674);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Device Management";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(97, 461);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(455, 31);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(150, 144);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // listViewDevices
            // 
            listViewDevices.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewDevices.FullRowSelect = true;
            listViewDevices.GridLines = true;
            listViewDevices.Location = new Point(6, 6);
            listViewDevices.Name = "listViewDevices";
            listViewDevices.Size = new Size(333, 381);
            listViewDevices.TabIndex = 2;
            listViewDevices.UseCompatibleStateImageBehavior = false;
            listViewDevices.View = View.Details;
            listViewDevices.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Device Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Manufacturer";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefreshDevices);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 631);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 40);
            panel1.TabIndex = 1;
            // 
            // btnRefreshDevices
            // 
            btnRefreshDevices.Location = new Point(3, 3);
            btnRefreshDevices.Name = "btnRefreshDevices";
            btnRefreshDevices.Size = new Size(110, 35);
            btnRefreshDevices.TabIndex = 0;
            btnRefreshDevices.Text = "Refresh";
            btnRefreshDevices.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Lavender;
            tabPage4.Controls.Add(button18);
            tabPage4.Controls.Add(button17);
            tabPage4.Controls.Add(btnClose);
            tabPage4.Controls.Add(listBoxResults);
            tabPage4.Controls.Add(folderCreationPath);
            tabPage4.Controls.Add(fileCreationPath);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(btnListDirectories);
            tabPage4.Controls.Add(btnListFiles);
            tabPage4.Controls.Add(btnCreateDirectory);
            tabPage4.Controls.Add(btnCreateFile);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(994, 674);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "File Management";
            // 
            // button18
            // 
            button18.BackColor = Color.DodgerBlue;
            button18.Location = new Point(348, 482);
            button18.Name = "button18";
            button18.Size = new Size(232, 34);
            button18.TabIndex = 12;
            button18.Text = "Write To File";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.DodgerBlue;
            button17.ForeColor = SystemColors.ControlText;
            button17.Location = new Point(348, 203);
            button17.Name = "button17";
            button17.Size = new Size(232, 34);
            button17.TabIndex = 11;
            button17.Text = "Delete file";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Location = new Point(268, 522);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 58);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close😊";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = SystemColors.InactiveBorder;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 25;
            listBoxResults.Location = new Point(610, 47);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(357, 479);
            listBoxResults.TabIndex = 9;
            listBoxResults.SelectedIndexChanged += listBoxResults_SelectedIndexChanged;
            // 
            // folderCreationPath
            // 
            folderCreationPath.Location = new Point(348, 140);
            folderCreationPath.Name = "folderCreationPath";
            folderCreationPath.Size = new Size(220, 31);
            folderCreationPath.TabIndex = 8;
            // 
            // fileCreationPath
            // 
            fileCreationPath.Location = new Point(348, 49);
            fileCreationPath.Name = "fileCreationPath";
            fileCreationPath.Size = new Size(220, 31);
            fileCreationPath.TabIndex = 7;
            fileCreationPath.TextChanged += fileCreationPath_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Location = new Point(348, 404);
            button2.Name = "button2";
            button2.Size = new Size(232, 34);
            button2.TabIndex = 6;
            button2.Text = "Delete Folder";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(348, 300);
            button1.Name = "button1";
            button1.Size = new Size(220, 34);
            button1.TabIndex = 5;
            button1.Text = "Read  File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.Location = new Point(45, 404);
            button5.Name = "button5";
            button5.Size = new Size(220, 34);
            button5.TabIndex = 4;
            button5.Text = "view File Information";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnListDirectories
            // 
            btnListDirectories.BackColor = Color.DodgerBlue;
            btnListDirectories.Location = new Point(45, 300);
            btnListDirectories.Name = "btnListDirectories";
            btnListDirectories.Size = new Size(220, 34);
            btnListDirectories.TabIndex = 3;
            btnListDirectories.Text = "List Folders";
            btnListDirectories.UseVisualStyleBackColor = false;
            btnListDirectories.Click += btnListDirectories_Click;
            // 
            // btnListFiles
            // 
            btnListFiles.BackColor = Color.DodgerBlue;
            btnListFiles.Location = new Point(45, 203);
            btnListFiles.Name = "btnListFiles";
            btnListFiles.Size = new Size(220, 34);
            btnListFiles.TabIndex = 2;
            btnListFiles.Text = "List Files";
            btnListFiles.UseVisualStyleBackColor = false;
            btnListFiles.Click += button3_Click;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.BackColor = Color.DodgerBlue;
            btnCreateDirectory.Location = new Point(45, 140);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(220, 34);
            btnCreateDirectory.TabIndex = 1;
            btnCreateDirectory.Text = "Create Folder";
            btnCreateDirectory.UseVisualStyleBackColor = false;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // btnCreateFile
            // 
            btnCreateFile.BackColor = Color.DodgerBlue;
            btnCreateFile.Location = new Point(45, 47);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(220, 34);
            btnCreateFile.TabIndex = 0;
            btnCreateFile.Text = "Create File";
            btnCreateFile.UseVisualStyleBackColor = false;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Lavender;
            tabPage5.Controls.Add(listBox2);
            tabPage5.Controls.Add(button16);
            tabPage5.Controls.Add(button15);
            tabPage5.Controls.Add(panel3);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(994, 674);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Information Management";
            tabPage5.Click += tabPage5_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(202, 60);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(605, 229);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button16
            // 
            button16.BackColor = Color.Red;
            button16.Location = new Point(453, 437);
            button16.Name = "button16";
            button16.Size = new Size(112, 34);
            button16.TabIndex = 4;
            button16.Text = "Close";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DodgerBlue;
            button15.ForeColor = SystemColors.MenuText;
            button15.Location = new Point(453, 326);
            button15.Name = "button15";
            button15.Size = new Size(112, 34);
            button15.TabIndex = 3;
            button15.Text = "Refresh";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 521);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 150);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.Lavender;
            tabPage6.Controls.Add(textBox8);
            tabPage6.Controls.Add(textBox7);
            tabPage6.Controls.Add(listBox4);
            tabPage6.Controls.Add(button21);
            tabPage6.Controls.Add(button20);
            tabPage6.Controls.Add(listBox3);
            tabPage6.Controls.Add(groupBox2);
            tabPage6.Controls.Add(groupBox1);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(994, 674);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Communication";
            // 
            // panel2
            // 
            panel2.Location = new Point(877, 718);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.ForestGreen;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(74, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "sender";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGoldenrod;
            groupBox2.Controls.Add(button19);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(563, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 221);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receiver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 0;
            label3.Text = "IP ADDRESS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 1;
            label4.Text = "PORT";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 31);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 33);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 0;
            label5.Text = "IP ADDRESS";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(184, 30);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 31);
            textBox5.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 93);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 2;
            label6.Text = "PORT";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(184, 87);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 31);
            textBox6.TabIndex = 3;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(563, 297);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(404, 129);
            listBox3.TabIndex = 2;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // button19
            // 
            button19.BackColor = Color.DodgerBlue;
            button19.Location = new Point(277, 170);
            button19.Name = "button19";
            button19.Size = new Size(112, 34);
            button19.TabIndex = 4;
            button19.Text = "CONNECT";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.DodgerBlue;
            button20.Location = new Point(219, 509);
            button20.Name = "button20";
            button20.Size = new Size(112, 34);
            button20.TabIndex = 3;
            button20.Text = "SEND";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.DodgerBlue;
            button21.Location = new Point(731, 509);
            button21.Name = "button21";
            button21.Size = new Size(112, 34);
            button21.TabIndex = 4;
            button21.Text = "SEND";
            button21.UseVisualStyleBackColor = false;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(74, 297);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(422, 129);
            listBox4.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(74, 445);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(422, 31);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(563, 445);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(404, 31);
            textBox8.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 712);
            Controls.Add(panel2);
            Controls.Add(mainTabControl);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OS Management System";
            Load += Form1_Load;
            mainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private Button btnRefreshDevices;
        private Panel panel2;
        private Panel panel3;
        private Button button5;
        private Button btnListDirectories;
        private Button btnListFiles;
        private Button btnCreateDirectory;
        private Button btnCreateFile;
        private Button button1;
        private Button button2;
        private TextBox folderCreationPath;
        private TextBox fileCreationPath;
        private ListBox listBoxResults;
        private Button btnClose;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private Button button9;
        private Button button8;
        private Button button11;
        private Button button10;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button14;
        private Button button13;
        private Button button12;
        private RichTextBox richTextBox2;
        private ListView listViewDevices;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnRefresh;
        private Button button16;
        private Button button15;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button button17;
        private Button button18;
        private TabPage tabPage6;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private ListBox listBox3;
        private Button button19;
        private Button button21;
        private Button button20;
        private TextBox textBox8;
        private TextBox textBox7;
        private ListBox listBox4;
    }
}
