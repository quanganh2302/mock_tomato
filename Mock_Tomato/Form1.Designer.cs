namespace Mock_Tomato;

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
        components = new System.ComponentModel.Container();
        TreeNode treeNode1 = new TreeNode("Quản lý Master");
        TreeNode treeNode2 = new TreeNode("Kinh Doanh");
        TreeNode treeNode3 = new TreeNode("Danh sách Wono");
        TreeNode treeNode4 = new TreeNode("Nhập kết quả");
        TreeNode treeNode5 = new TreeNode("MRF Summarise");
        TreeNode treeNode6 = new TreeNode("Hoàn thành Wono");
        TreeNode treeNode7 = new TreeNode("Quản lý sản xuất", new TreeNode[] { treeNode3, treeNode4, treeNode5, treeNode6 });
        TreeNode treeNode8 = new TreeNode("Quản lý chất lượng");
        TreeNode treeNode9 = new TreeNode("Phân bổ chi tiết xuất hàng");
        TreeNode treeNode10 = new TreeNode("Nhập thực tế đóng gói");
        TreeNode treeNode11 = new TreeNode("Nhập thức tế xuất hàng");
        TreeNode treeNode12 = new TreeNode("Đóng gói xuất hàng", new TreeNode[] { treeNode9, treeNode10, treeNode11 });
        TreeNode treeNode13 = new TreeNode("Inventory check");
        TreeNode treeNode14 = new TreeNode("Xuất phiếu hàng - nhãn bao bì trong");
        TreeNode treeNode15 = new TreeNode("In lại giấy chỉ thị");
        TreeNode treeNode16 = new TreeNode("Báo cáo", new TreeNode[] { treeNode14, treeNode15 });
        TreeNode treeNode17 = new TreeNode("Menu", new TreeNode[] { treeNode1, treeNode2, treeNode7, treeNode8, treeNode12, treeNode13, treeNode16 });
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        splitContainer1 = new SplitContainer();
        tVMenu = new TreeView();
        panel2 = new Panel();
        tcParent = new TabControl();
        tPRealPack = new TabPage();
        panel3 = new Panel();
        button1 = new Button();
        btnQd = new Button();
        WonoCompleteCheck = new CheckBox();
        label10 = new Label();
        panel1 = new Panel();
        dGvWono = new DataGridView();
        dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
        label20 = new Label();
        dGvDetail1 = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        label19 = new Label();
        flowLayoutPanel1 = new FlowLayoutPanel();
        rbHb = new RadioButton();
        rbK = new RadioButton();
        RbBnl = new RadioButton();
        rbGg = new RadioButton();
        rbOther = new RadioButton();
        mtbDate = new MaskedTextBox();
        button5 = new Button();
        checkBox2 = new CheckBox();
        button4 = new Button();
        label13 = new Label();
        label7 = new Label();
        label6 = new Label();
        label8 = new Label();
        label11 = new Label();
        label17 = new Label();
        label18 = new Label();
        label15 = new Label();
        label12 = new Label();
        label9 = new Label();
        label4 = new Label();
        label2 = new Label();
        textBox17 = new TextBox();
        textBox4 = new TextBox();
        textBox14 = new TextBox();
        textBox11 = new TextBox();
        textBox1 = new TextBox();
        textBox6 = new TextBox();
        textBox9 = new TextBox();
        textBox8 = new TextBox();
        textBox10 = new TextBox();
        textBox16 = new TextBox();
        textBox7 = new TextBox();
        textBox13 = new TextBox();
        textBox5 = new TextBox();
        textBox12 = new TextBox();
        textBox3 = new TextBox();
        label3 = new Label();
        label1 = new Label();
        textBox2 = new TextBox();
        lbWn = new Label();
        tbPacker = new TextBox();
        tbFpi = new TextBox();
        tPExport = new TabPage();
        tcChild = new TabControl();
        tabPage9 = new TabPage();
        tabPage10 = new TabPage();
        tpLabelCustom = new TabPage();
        panel11 = new Panel();
        button2 = new Button();
        button3 = new Button();
        checkBox1 = new CheckBox();
        label5 = new Label();
        panel12 = new Panel();
        label14 = new Label();
        dataGridView4 = new DataGridView();
        dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
        dsM_TextBox3 = new Mock_Tomato.CustomUI.DSM_TextBox();
        label21 = new Label();
        textBox19 = new TextBox();
        label22 = new Label();
        textBox20 = new TextBox();
        label23 = new Label();
        label24 = new Label();
        textBox21 = new TextBox();
        panel9 = new Panel();
        label16 = new Label();
        tbSono = new TextBox();
        tabPage2 = new TabPage();
        tabPage3 = new TabPage();
        tabPage4 = new TabPage();
        cmsToolMenu = new ContextMenuStrip(components);
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        panel2.SuspendLayout();
        tcParent.SuspendLayout();
        tPRealPack.SuspendLayout();
        panel3.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dGvWono).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dGvDetail1).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        tPExport.SuspendLayout();
        tcChild.SuspendLayout();
        tpLabelCustom.SuspendLayout();
        panel11.SuspendLayout();
        panel12.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
        panel9.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Controls.Add(tabPage4);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Margin = new Padding(2);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1307, 680);
        tabControl1.TabIndex = 1;
        tabControl1.Selecting += TabControl1_Selecting;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(splitContainer1);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Margin = new Padding(2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(2);
        tabPage1.Size = new Size(1299, 652);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "File (F)";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(2, 2);
        splitContainer1.Margin = new Padding(2);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(tVMenu);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(panel2);
        splitContainer1.Size = new Size(1295, 648);
        splitContainer1.SplitterDistance = 290;
        splitContainer1.SplitterWidth = 3;
        splitContainer1.TabIndex = 0;
        // 
        // tVMenu
        // 
        tVMenu.Dock = DockStyle.Fill;
        tVMenu.Location = new Point(0, 0);
        tVMenu.Margin = new Padding(2);
        tVMenu.Name = "tVMenu";
        treeNode1.Name = "nC1";
        treeNode1.Text = "Quản lý Master";
        treeNode2.Name = "Node0";
        treeNode2.Text = "Kinh Doanh";
        treeNode3.Name = "nC11";
        treeNode3.Text = "Danh sách Wono";
        treeNode4.Name = "nC12";
        treeNode4.Text = "Nhập kết quả";
        treeNode5.Name = "nC13";
        treeNode5.Text = "MRF Summarise";
        treeNode6.Name = "nC14";
        treeNode6.Text = "Hoàn thành Wono";
        treeNode7.Name = "nC2";
        treeNode7.Text = "Quản lý sản xuất";
        treeNode8.Name = "nC3";
        treeNode8.Text = "Quản lý chất lượng";
        treeNode9.Name = "nC41";
        treeNode9.Text = "Phân bổ chi tiết xuất hàng";
        treeNode10.Name = "nCRealPack";
        treeNode10.Text = "Nhập thực tế đóng gói";
        treeNode11.Name = "nC43";
        treeNode11.Text = "Nhập thức tế xuất hàng";
        treeNode12.Name = "nCPacking";
        treeNode12.Text = "Đóng gói xuất hàng";
        treeNode13.Name = "nC5";
        treeNode13.Text = "Inventory check";
        treeNode14.Name = "nCPrint";
        treeNode14.Text = "Xuất phiếu hàng - nhãn bao bì trong";
        treeNode15.Name = "Node2";
        treeNode15.Text = "In lại giấy chỉ thị";
        treeNode16.Name = "nCReport";
        treeNode16.Text = "Báo cáo";
        treeNode17.Name = "nMain";
        treeNode17.Text = "Menu";
        tVMenu.Nodes.AddRange(new TreeNode[] { treeNode17 });
        tVMenu.Size = new Size(290, 648);
        tVMenu.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(tcParent);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(2);
        panel2.Name = "panel2";
        panel2.Size = new Size(1002, 648);
        panel2.TabIndex = 1;
        // 
        // tcParent
        // 
        tcParent.Controls.Add(tPRealPack);
        tcParent.Controls.Add(tPExport);
        tcParent.Dock = DockStyle.Fill;
        tcParent.Location = new Point(0, 0);
        tcParent.Name = "tcParent";
        tcParent.SelectedIndex = 0;
        tcParent.Size = new Size(1002, 648);
        tcParent.TabIndex = 0;
        // 
        // tPRealPack
        // 
        tPRealPack.Controls.Add(panel3);
        tPRealPack.Controls.Add(panel1);
        tPRealPack.Location = new Point(4, 24);
        tPRealPack.Name = "tPRealPack";
        tPRealPack.Padding = new Padding(3);
        tPRealPack.Size = new Size(994, 620);
        tPRealPack.TabIndex = 0;
        tPRealPack.Text = "Thực tế đóng gói";
        tPRealPack.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Controls.Add(button1);
        panel3.Controls.Add(btnQd);
        panel3.Controls.Add(WonoCompleteCheck);
        panel3.Controls.Add(label10);
        panel3.Dock = DockStyle.Bottom;
        panel3.Location = new Point(3, 569);
        panel3.Name = "panel3";
        panel3.Size = new Size(988, 48);
        panel3.TabIndex = 12;
        // 
        // button1
        // 
        button1.Location = new Point(787, 9);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(144, 26);
        button1.TabIndex = 10;
        button1.Text = "Đóng (ESC)";
        button1.UseVisualStyleBackColor = true;
        // 
        // btnQd
        // 
        btnQd.Location = new Point(161, 9);
        btnQd.Margin = new Padding(2);
        btnQd.Name = "btnQd";
        btnQd.Size = new Size(144, 26);
        btnQd.TabIndex = 11;
        btnQd.Text = "Quyết định (F3)";
        btnQd.UseVisualStyleBackColor = true;
        // 
        // WonoCompleteCheck
        // 
        WonoCompleteCheck.AutoSize = true;
        WonoCompleteCheck.Location = new Point(135, 20);
        WonoCompleteCheck.Margin = new Padding(2);
        WonoCompleteCheck.Name = "WonoCompleteCheck";
        WonoCompleteCheck.Size = new Size(15, 14);
        WonoCompleteCheck.TabIndex = 9;
        WonoCompleteCheck.UseVisualStyleBackColor = true;
        // 
        // label10
        // 
        label10.BackColor = SystemColors.ControlDarkDark;
        label10.ForeColor = Color.Transparent;
        label10.Location = new Point(10, 17);
        label10.Margin = new Padding(2, 0, 2, 0);
        label10.Name = "label10";
        label10.Padding = new Padding(1);
        label10.Size = new Size(120, 17);
        label10.TabIndex = 8;
        label10.Text = "Ngày nhập";
        // 
        // panel1
        // 
        panel1.Controls.Add(dGvWono);
        panel1.Controls.Add(label20);
        panel1.Controls.Add(dGvDetail1);
        panel1.Controls.Add(label19);
        panel1.Controls.Add(flowLayoutPanel1);
        panel1.Controls.Add(mtbDate);
        panel1.Controls.Add(button5);
        panel1.Controls.Add(checkBox2);
        panel1.Controls.Add(button4);
        panel1.Controls.Add(label13);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label8);
        panel1.Controls.Add(label11);
        panel1.Controls.Add(label17);
        panel1.Controls.Add(label18);
        panel1.Controls.Add(label15);
        panel1.Controls.Add(label12);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(textBox17);
        panel1.Controls.Add(textBox4);
        panel1.Controls.Add(textBox14);
        panel1.Controls.Add(textBox11);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(textBox6);
        panel1.Controls.Add(textBox9);
        panel1.Controls.Add(textBox8);
        panel1.Controls.Add(textBox10);
        panel1.Controls.Add(textBox16);
        panel1.Controls.Add(textBox7);
        panel1.Controls.Add(textBox13);
        panel1.Controls.Add(textBox5);
        panel1.Controls.Add(textBox12);
        panel1.Controls.Add(textBox3);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(lbWn);
        panel1.Controls.Add(tbPacker);
        panel1.Controls.Add(tbFpi);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 3);
        panel1.Margin = new Padding(2);
        panel1.Name = "panel1";
        panel1.Size = new Size(988, 614);
        panel1.TabIndex = 10;
        // 
        // dGvWono
        // 
        dGvWono.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dGvWono.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
        dGvWono.Location = new Point(522, 340);
        dGvWono.Margin = new Padding(2);
        dGvWono.Name = "dGvWono";
        dGvWono.RowHeadersVisible = false;
        dGvWono.RowHeadersWidth = 62;
        dGvWono.Size = new Size(324, 221);
        dGvWono.TabIndex = 18;
        // 
        // dataGridViewTextBoxColumn7
        // 
        dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn7.HeaderText = "WO/PONo.";
        dataGridViewTextBoxColumn7.MinimumWidth = 8;
        dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        dataGridViewTextBoxColumn7.Width = 92;
        // 
        // dataGridViewTextBoxColumn8
        // 
        dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn8.HeaderText = "SL phân bổ";
        dataGridViewTextBoxColumn8.MinimumWidth = 8;
        dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        dataGridViewTextBoxColumn8.Width = 91;
        // 
        // dataGridViewTextBoxColumn9
        // 
        dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn9.HeaderText = "DEL";
        dataGridViewTextBoxColumn9.MinimumWidth = 8;
        dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
        dataGridViewTextBoxColumn9.Width = 52;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(530, 323);
        label20.Name = "label20";
        label20.Size = new Size(92, 15);
        label20.TabIndex = 17;
        label20.Text = "Chi tiết phân bổ";
        // 
        // dGvDetail1
        // 
        dGvDetail1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dGvDetail1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        dGvDetail1.Location = new Point(2, 340);
        dGvDetail1.Margin = new Padding(2);
        dGvDetail1.Name = "dGvDetail1";
        dGvDetail1.RowHeadersVisible = false;
        dGvDetail1.RowHeadersWidth = 62;
        dGvDetail1.Size = new Size(324, 221);
        dGvDetail1.TabIndex = 16;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn1.HeaderText = "SL đóng vào";
        dataGridViewTextBoxColumn1.MinimumWidth = 8;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.Width = 97;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn2.HeaderText = "Số lô";
        dataGridViewTextBoxColumn2.MinimumWidth = 8;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.Width = 58;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn3.HeaderText = "DEL";
        dataGridViewTextBoxColumn3.MinimumWidth = 8;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.Width = 52;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(10, 323);
        label19.Name = "label19";
        label19.Size = new Size(96, 15);
        label19.TabIndex = 14;
        label19.Text = "Chi tiết đóng gói";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
        flowLayoutPanel1.Controls.Add(rbHb);
        flowLayoutPanel1.Controls.Add(rbK);
        flowLayoutPanel1.Controls.Add(RbBnl);
        flowLayoutPanel1.Controls.Add(rbGg);
        flowLayoutPanel1.Controls.Add(rbOther);
        flowLayoutPanel1.Location = new Point(147, 286);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(473, 29);
        flowLayoutPanel1.TabIndex = 13;
        // 
        // rbHb
        // 
        rbHb.AutoSize = true;
        rbHb.Location = new Point(3, 3);
        rbHb.Name = "rbHb";
        rbHb.RightToLeft = RightToLeft.No;
        rbHb.Size = new Size(67, 19);
        rbHb.TabIndex = 0;
        rbHb.TabStop = true;
        rbHb.Text = "Hộp bìa";
        rbHb.UseVisualStyleBackColor = true;
        // 
        // rbK
        // 
        rbK.AutoSize = true;
        rbK.Location = new Point(76, 3);
        rbK.Name = "rbK";
        rbK.RightToLeft = RightToLeft.No;
        rbK.Size = new Size(48, 19);
        rbK.TabIndex = 0;
        rbK.TabStop = true;
        rbK.Text = "Kiện";
        rbK.UseVisualStyleBackColor = true;
        // 
        // RbBnl
        // 
        RbBnl.AutoSize = true;
        RbBnl.Location = new Point(130, 3);
        RbBnl.Name = "RbBnl";
        RbBnl.RightToLeft = RightToLeft.No;
        RbBnl.Size = new Size(80, 19);
        RbBnl.TabIndex = 0;
        RbBnl.TabStop = true;
        RbBnl.Text = "Bao ni-lon";
        RbBnl.UseVisualStyleBackColor = true;
        // 
        // rbGg
        // 
        rbGg.AutoSize = true;
        rbGg.Location = new Point(216, 3);
        rbGg.Name = "rbGg";
        rbGg.RightToLeft = RightToLeft.No;
        rbGg.Size = new Size(68, 19);
        rbGg.TabIndex = 0;
        rbGg.TabStop = true;
        rbGg.Text = "Gói giấy";
        rbGg.UseVisualStyleBackColor = true;
        // 
        // rbOther
        // 
        rbOther.AutoSize = true;
        rbOther.Location = new Point(290, 3);
        rbOther.Name = "rbOther";
        rbOther.RightToLeft = RightToLeft.No;
        rbOther.Size = new Size(51, 19);
        rbOther.TabIndex = 0;
        rbOther.TabStop = true;
        rbOther.Text = "Khác";
        rbOther.UseVisualStyleBackColor = true;
        // 
        // mtbDate
        // 
        mtbDate.Location = new Point(147, 185);
        mtbDate.Mask = "00/00/0000";
        mtbDate.Name = "mtbDate";
        mtbDate.Size = new Size(106, 23);
        mtbDate.TabIndex = 12;
        mtbDate.ValidatingType = typeof(DateTime);
        // 
        // button5
        // 
        button5.Location = new Point(405, 7);
        button5.Margin = new Padding(2);
        button5.Name = "button5";
        button5.Size = new Size(144, 23);
        button5.TabIndex = 10;
        button5.Text = "Tìm (F2)";
        button5.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.AutoSize = true;
        checkBox2.Location = new Point(382, 189);
        checkBox2.Margin = new Padding(2);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new Size(15, 14);
        checkBox2.TabIndex = 9;
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(257, 7);
        button4.Margin = new Padding(2);
        button4.Name = "button4";
        button4.Size = new Size(144, 23);
        button4.TabIndex = 11;
        button4.Text = "Xóa";
        button4.UseVisualStyleBackColor = true;
        // 
        // label13
        // 
        label13.BackColor = SystemColors.ControlDarkDark;
        label13.ForeColor = Color.Transparent;
        label13.Location = new Point(625, 286);
        label13.Margin = new Padding(2, 0, 2, 0);
        label13.Name = "label13";
        label13.Padding = new Padding(1);
        label13.Size = new Size(120, 23);
        label13.TabIndex = 1;
        label13.Text = "Packer";
        // 
        // label7
        // 
        label7.BackColor = SystemColors.ControlDarkDark;
        label7.ForeColor = Color.Transparent;
        label7.Location = new Point(500, 119);
        label7.Margin = new Padding(2, 0, 2, 0);
        label7.Name = "label7";
        label7.Padding = new Padding(1);
        label7.Size = new Size(120, 23);
        label7.TabIndex = 1;
        label7.Text = "Ngày hẹn";
        // 
        // label6
        // 
        label6.BackColor = SystemColors.ControlDarkDark;
        label6.ForeColor = Color.Transparent;
        label6.Location = new Point(257, 119);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Padding = new Padding(1);
        label6.Size = new Size(120, 23);
        label6.TabIndex = 1;
        label6.Text = "Ngày chỉ thị xuất";
        // 
        // label8
        // 
        label8.BackColor = SystemColors.ControlDarkDark;
        label8.ForeColor = Color.Transparent;
        label8.Location = new Point(10, 153);
        label8.Margin = new Padding(2, 0, 2, 0);
        label8.Name = "label8";
        label8.Padding = new Padding(1);
        label8.Size = new Size(120, 23);
        label8.TabIndex = 1;
        label8.Text = "SL chỉ thị đóng gói";
        // 
        // label11
        // 
        label11.BackColor = SystemColors.ControlDarkDark;
        label11.ForeColor = Color.Transparent;
        label11.Location = new Point(258, 185);
        label11.Margin = new Padding(2, 0, 2, 0);
        label11.Name = "label11";
        label11.Padding = new Padding(1);
        label11.Size = new Size(120, 23);
        label11.TabIndex = 1;
        label11.Text = "Gửi trực tiếp";
        // 
        // label17
        // 
        label17.BackColor = SystemColors.ControlDarkDark;
        label17.ForeColor = Color.Transparent;
        label17.Location = new Point(281, 251);
        label17.Margin = new Padding(2, 0, 2, 0);
        label17.Name = "label17";
        label17.Padding = new Padding(1);
        label17.Size = new Size(120, 23);
        label17.TabIndex = 1;
        label17.Text = "Số bao bì ngoài";
        // 
        // label18
        // 
        label18.BackColor = SystemColors.ControlDarkDark;
        label18.ForeColor = Color.Transparent;
        label18.Location = new Point(10, 286);
        label18.Margin = new Padding(2, 0, 2, 0);
        label18.Name = "label18";
        label18.Padding = new Padding(1);
        label18.Size = new Size(120, 23);
        label18.TabIndex = 1;
        label18.Text = "Kiểu đóng gói";
        // 
        // label15
        // 
        label15.BackColor = SystemColors.ControlDarkDark;
        label15.ForeColor = Color.Transparent;
        label15.Location = new Point(10, 253);
        label15.Margin = new Padding(2, 0, 2, 0);
        label15.Name = "label15";
        label15.Padding = new Padding(1);
        label15.Size = new Size(120, 23);
        label15.TabIndex = 1;
        label15.Text = "Số bao bì trong";
        // 
        // label12
        // 
        label12.BackColor = SystemColors.ControlDarkDark;
        label12.ForeColor = Color.Transparent;
        label12.Location = new Point(10, 220);
        label12.Margin = new Padding(2, 0, 2, 0);
        label12.Name = "label12";
        label12.Padding = new Padding(1);
        label12.Size = new Size(120, 23);
        label12.TabIndex = 1;
        label12.Text = "Chỉ thị hình thức";
        // 
        // label9
        // 
        label9.BackColor = SystemColors.ControlDarkDark;
        label9.ForeColor = Color.Transparent;
        label9.Location = new Point(10, 185);
        label9.Margin = new Padding(2, 0, 2, 0);
        label9.Name = "label9";
        label9.Padding = new Padding(1);
        label9.Size = new Size(120, 23);
        label9.TabIndex = 1;
        label9.Text = "Ngày đóng gói";
        // 
        // label4
        // 
        label4.BackColor = SystemColors.ControlDarkDark;
        label4.ForeColor = Color.Transparent;
        label4.Location = new Point(10, 119);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Padding = new Padding(1);
        label4.Size = new Size(120, 23);
        label4.TabIndex = 1;
        label4.Text = "Ngày chỉ thị đóng gói";
        // 
        // label2
        // 
        label2.BackColor = SystemColors.ControlDarkDark;
        label2.ForeColor = Color.Transparent;
        label2.Location = new Point(10, 91);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Padding = new Padding(1);
        label2.Size = new Size(120, 23);
        label2.TabIndex = 1;
        label2.Text = "Mã khách hàng";
        // 
        // textBox17
        // 
        textBox17.BorderStyle = BorderStyle.FixedSingle;
        textBox17.Location = new Point(529, 249);
        textBox17.Margin = new Padding(2);
        textBox17.Name = "textBox17";
        textBox17.ReadOnly = true;
        textBox17.Size = new Size(16, 23);
        textBox17.TabIndex = 0;
        textBox17.Text = "P";
        // 
        // textBox4
        // 
        textBox4.BorderStyle = BorderStyle.FixedSingle;
        textBox4.Location = new Point(441, 61);
        textBox4.Margin = new Padding(2);
        textBox4.Name = "textBox4";
        textBox4.ReadOnly = true;
        textBox4.Size = new Size(405, 23);
        textBox4.TabIndex = 0;
        textBox4.Text = "BASE_DF_SPONGE_1";
        // 
        // textBox14
        // 
        textBox14.BorderStyle = BorderStyle.FixedSingle;
        textBox14.Location = new Point(258, 251);
        textBox14.Margin = new Padding(2);
        textBox14.Name = "textBox14";
        textBox14.ReadOnly = true;
        textBox14.Size = new Size(16, 23);
        textBox14.TabIndex = 0;
        textBox14.Text = "P";
        // 
        // textBox11
        // 
        textBox11.BorderStyle = BorderStyle.FixedSingle;
        textBox11.Location = new Point(257, 151);
        textBox11.Margin = new Padding(2);
        textBox11.Name = "textBox11";
        textBox11.ReadOnly = true;
        textBox11.Size = new Size(16, 23);
        textBox11.TabIndex = 0;
        textBox11.Text = "P";
        // 
        // textBox1
        // 
        textBox1.BorderStyle = BorderStyle.FixedSingle;
        textBox1.Location = new Point(405, 61);
        textBox1.Margin = new Padding(2);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(32, 23);
        textBox1.TabIndex = 0;
        textBox1.Text = "R06";
        // 
        // textBox6
        // 
        textBox6.BorderStyle = BorderStyle.FixedSingle;
        textBox6.Location = new Point(257, 91);
        textBox6.Margin = new Padding(2);
        textBox6.Name = "textBox6";
        textBox6.ReadOnly = true;
        textBox6.Size = new Size(433, 23);
        textBox6.TabIndex = 0;
        textBox6.Text = "CANON ELECTRONICS VIETNAM CO... LTD.";
        // 
        // textBox9
        // 
        textBox9.BorderStyle = BorderStyle.FixedSingle;
        textBox9.Location = new Point(635, 119);
        textBox9.Margin = new Padding(2);
        textBox9.Name = "textBox9";
        textBox9.ReadOnly = true;
        textBox9.Size = new Size(106, 23);
        textBox9.TabIndex = 0;
        textBox9.Text = "02/04/2026";
        // 
        // textBox8
        // 
        textBox8.BorderStyle = BorderStyle.FixedSingle;
        textBox8.Location = new Point(390, 119);
        textBox8.Margin = new Padding(2);
        textBox8.Name = "textBox8";
        textBox8.ReadOnly = true;
        textBox8.Size = new Size(106, 23);
        textBox8.TabIndex = 0;
        textBox8.Text = "02/04/2026";
        // 
        // textBox10
        // 
        textBox10.BorderStyle = BorderStyle.FixedSingle;
        textBox10.Location = new Point(147, 151);
        textBox10.Margin = new Padding(2);
        textBox10.Name = "textBox10";
        textBox10.ReadOnly = true;
        textBox10.Size = new Size(106, 23);
        textBox10.TabIndex = 0;
        textBox10.Text = "18.200";
        // 
        // textBox16
        // 
        textBox16.BorderStyle = BorderStyle.FixedSingle;
        textBox16.Location = new Point(418, 249);
        textBox16.Margin = new Padding(2);
        textBox16.Name = "textBox16";
        textBox16.ReadOnly = true;
        textBox16.Size = new Size(106, 23);
        textBox16.TabIndex = 0;
        textBox16.Text = "700";
        // 
        // textBox7
        // 
        textBox7.BorderStyle = BorderStyle.FixedSingle;
        textBox7.Location = new Point(147, 119);
        textBox7.Margin = new Padding(2);
        textBox7.Name = "textBox7";
        textBox7.ReadOnly = true;
        textBox7.Size = new Size(106, 23);
        textBox7.TabIndex = 0;
        textBox7.Text = "27/03/2026";
        // 
        // textBox13
        // 
        textBox13.BorderStyle = BorderStyle.FixedSingle;
        textBox13.Location = new Point(147, 251);
        textBox13.Margin = new Padding(2);
        textBox13.Name = "textBox13";
        textBox13.ReadOnly = true;
        textBox13.Size = new Size(106, 23);
        textBox13.TabIndex = 0;
        textBox13.Text = "700";
        // 
        // textBox5
        // 
        textBox5.BorderStyle = BorderStyle.FixedSingle;
        textBox5.Location = new Point(147, 91);
        textBox5.Margin = new Padding(2);
        textBox5.Name = "textBox5";
        textBox5.ReadOnly = true;
        textBox5.Size = new Size(106, 23);
        textBox5.TabIndex = 0;
        textBox5.Text = "CAE001";
        // 
        // textBox12
        // 
        textBox12.BorderStyle = BorderStyle.FixedSingle;
        textBox12.Location = new Point(147, 218);
        textBox12.Margin = new Padding(2);
        textBox12.Name = "textBox12";
        textBox12.ReadOnly = true;
        textBox12.Size = new Size(543, 23);
        textBox12.TabIndex = 0;
        textBox12.Text = "004228";
        // 
        // textBox3
        // 
        textBox3.BorderStyle = BorderStyle.FixedSingle;
        textBox3.Location = new Point(147, 61);
        textBox3.Margin = new Padding(2);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new Size(254, 23);
        textBox3.TabIndex = 0;
        textBox3.Text = "FL1-1372-00";
        // 
        // label3
        // 
        label3.BackColor = SystemColors.ControlDarkDark;
        label3.ForeColor = Color.Transparent;
        label3.Location = new Point(10, 35);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Padding = new Padding(1, 1, 25, 1);
        label3.Size = new Size(120, 23);
        label3.TabIndex = 1;
        label3.Text = "Tình trạng";
        // 
        // label1
        // 
        label1.BackColor = SystemColors.ControlDarkDark;
        label1.ForeColor = Color.Transparent;
        label1.Location = new Point(10, 61);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Padding = new Padding(1, 1, 25, 1);
        label1.Size = new Size(120, 23);
        label1.TabIndex = 1;
        label1.Text = "Mã mục hàng";
        // 
        // textBox2
        // 
        textBox2.BorderStyle = BorderStyle.FixedSingle;
        textBox2.Location = new Point(147, 35);
        textBox2.Margin = new Padding(2);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(106, 23);
        textBox2.TabIndex = 0;
        textBox2.Text = "KT Xong";
        // 
        // lbWn
        // 
        lbWn.BackColor = SystemColors.ControlDarkDark;
        lbWn.ForeColor = Color.Transparent;
        lbWn.Location = new Point(10, 7);
        lbWn.Margin = new Padding(2, 0, 2, 0);
        lbWn.Name = "lbWn";
        lbWn.Padding = new Padding(1);
        lbWn.Size = new Size(120, 23);
        lbWn.TabIndex = 1;
        lbWn.Text = "WOno";
        // 
        // tbPacker
        // 
        tbPacker.Location = new Point(749, 286);
        tbPacker.Margin = new Padding(2);
        tbPacker.Name = "tbPacker";
        tbPacker.Size = new Size(97, 23);
        tbPacker.TabIndex = 0;
        // 
        // tbFpi
        // 
        tbFpi.Location = new Point(147, 7);
        tbFpi.Margin = new Padding(2);
        tbFpi.Name = "tbFpi";
        tbFpi.Size = new Size(106, 23);
        tbFpi.TabIndex = 0;
        // 
        // tPExport
        // 
        tPExport.Controls.Add(tcChild);
        tPExport.Location = new Point(4, 24);
        tPExport.Name = "tPExport";
        tPExport.Padding = new Padding(3);
        tPExport.Size = new Size(994, 620);
        tPExport.TabIndex = 1;
        tPExport.Text = "Xuất phiếu hàng";
        tPExport.UseVisualStyleBackColor = true;
        // 
        // tcChild
        // 
        tcChild.Controls.Add(tabPage9);
        tcChild.Controls.Add(tabPage10);
        tcChild.Controls.Add(tpLabelCustom);
        tcChild.Dock = DockStyle.Fill;
        tcChild.Location = new Point(3, 3);
        tcChild.Name = "tcChild";
        tcChild.SelectedIndex = 0;
        tcChild.Size = new Size(988, 614);
        tcChild.TabIndex = 0;
        // 
        // tabPage9
        // 
        tabPage9.Location = new Point(4, 24);
        tabPage9.Name = "tabPage9";
        tabPage9.Padding = new Padding(3);
        tabPage9.Size = new Size(980, 586);
        tabPage9.TabIndex = 0;
        tabPage9.Text = "Nhãn bao trong";
        tabPage9.UseVisualStyleBackColor = true;
        // 
        // tabPage10
        // 
        tabPage10.Location = new Point(4, 24);
        tabPage10.Name = "tabPage10";
        tabPage10.Padding = new Padding(3);
        tabPage10.Size = new Size(980, 586);
        tabPage10.TabIndex = 1;
        tabPage10.Text = "Phiếu hàng nội bộ";
        tabPage10.UseVisualStyleBackColor = true;
        // 
        // tpLabelCustom
        // 
        tpLabelCustom.Controls.Add(panel11);
        tpLabelCustom.Controls.Add(panel12);
        tpLabelCustom.Controls.Add(panel9);
        tpLabelCustom.Location = new Point(4, 24);
        tpLabelCustom.Name = "tpLabelCustom";
        tpLabelCustom.Size = new Size(980, 586);
        tpLabelCustom.TabIndex = 2;
        tpLabelCustom.Text = "Phiếu hàng của khách hàng";
        tpLabelCustom.UseVisualStyleBackColor = true;
        // 
        // panel11
        // 
        panel11.Controls.Add(button2);
        panel11.Controls.Add(button3);
        panel11.Controls.Add(checkBox1);
        panel11.Controls.Add(label5);
        panel11.Dock = DockStyle.Bottom;
        panel11.Location = new Point(0, 538);
        panel11.Name = "panel11";
        panel11.Size = new Size(980, 48);
        panel11.TabIndex = 17;
        // 
        // button2
        // 
        button2.Location = new Point(787, 17);
        button2.Margin = new Padding(2);
        button2.Name = "button2";
        button2.Size = new Size(144, 20);
        button2.TabIndex = 10;
        button2.Text = "Đóng (ESC)";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(161, 17);
        button3.Margin = new Padding(2);
        button3.Name = "button3";
        button3.Size = new Size(144, 20);
        button3.TabIndex = 11;
        button3.Text = "Quyết định (F3)";
        button3.UseVisualStyleBackColor = true;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(129, 23);
        checkBox1.Margin = new Padding(2);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(15, 14);
        checkBox1.TabIndex = 9;
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.BackColor = SystemColors.ControlDarkDark;
        label5.ForeColor = Color.Transparent;
        label5.Location = new Point(4, 17);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Padding = new Padding(1);
        label5.Size = new Size(120, 20);
        label5.TabIndex = 8;
        label5.Text = "Ngày nhập";
        // 
        // panel12
        // 
        panel12.Controls.Add(label14);
        panel12.Controls.Add(dataGridView4);
        panel12.Controls.Add(dsM_TextBox3);
        panel12.Controls.Add(label21);
        panel12.Controls.Add(textBox19);
        panel12.Controls.Add(label22);
        panel12.Controls.Add(textBox20);
        panel12.Controls.Add(label23);
        panel12.Controls.Add(label24);
        panel12.Controls.Add(textBox21);
        panel12.Dock = DockStyle.Top;
        panel12.Location = new Point(0, 43);
        panel12.Margin = new Padding(2);
        panel12.Name = "panel12";
        panel12.Size = new Size(980, 364);
        panel12.TabIndex = 16;
        // 
        // label14
        // 
        label14.BackColor = SystemColors.ControlDarkDark;
        label14.ForeColor = Color.Transparent;
        label14.Location = new Point(10, 93);
        label14.Margin = new Padding(2, 0, 2, 0);
        label14.Name = "label14";
        label14.Padding = new Padding(1);
        label14.Size = new Size(120, 17);
        label14.TabIndex = 16;
        label14.Text = "Chi tiết đóng gói";
        // 
        // dataGridView4
        // 
        dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
        dataGridView4.Dock = DockStyle.Bottom;
        dataGridView4.Location = new Point(0, 121);
        dataGridView4.Margin = new Padding(2);
        dataGridView4.Name = "dataGridView4";
        dataGridView4.RowHeadersVisible = false;
        dataGridView4.RowHeadersWidth = 62;
        dataGridView4.Size = new Size(980, 243);
        dataGridView4.TabIndex = 15;
        // 
        // dataGridViewTextBoxColumn4
        // 
        dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn4.HeaderText = "Số lượng đóng";
        dataGridViewTextBoxColumn4.MinimumWidth = 8;
        dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        dataGridViewTextBoxColumn4.Width = 110;
        // 
        // dataGridViewTextBoxColumn5
        // 
        dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn5.HeaderText = "Số lô";
        dataGridViewTextBoxColumn5.MinimumWidth = 8;
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        dataGridViewTextBoxColumn5.Width = 58;
        // 
        // dataGridViewTextBoxColumn6
        // 
        dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn6.HeaderText = "DEL";
        dataGridViewTextBoxColumn6.MinimumWidth = 8;
        dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        dataGridViewTextBoxColumn6.Width = 52;
        // 
        // dsM_TextBox3
        // 
        dsM_TextBox3.BackColor = SystemColors.Window;
        dsM_TextBox3.BorderColor = Color.LightGray;
        dsM_TextBox3.ForeColor = Color.Black;
        dsM_TextBox3.Location = new Point(569, 46);
        dsM_TextBox3.Margin = new Padding(4, 4, 4, 4);
        dsM_TextBox3.Name = "dsM_TextBox3";
        dsM_TextBox3.Padding = new Padding(6, 5, 6, 5);
        dsM_TextBox3.Size = new Size(104, 26);
        dsM_TextBox3.TabIndex = 2;
        // 
        // label21
        // 
        label21.BackColor = SystemColors.ControlDarkDark;
        label21.ForeColor = Color.Transparent;
        label21.Location = new Point(10, 54);
        label21.Margin = new Padding(2, 0, 2, 0);
        label21.Name = "label21";
        label21.Padding = new Padding(1);
        label21.Size = new Size(120, 17);
        label21.TabIndex = 1;
        label21.Text = "Số đặt hàng";
        // 
        // textBox19
        // 
        textBox19.BorderStyle = BorderStyle.FixedSingle;
        textBox19.Location = new Point(147, 54);
        textBox19.Margin = new Padding(2);
        textBox19.Name = "textBox19";
        textBox19.ReadOnly = true;
        textBox19.Size = new Size(106, 23);
        textBox19.TabIndex = 0;
        textBox19.Text = "1,256.00";
        textBox19.TextAlign = HorizontalAlignment.Right;
        // 
        // label22
        // 
        label22.BackColor = SystemColors.ControlDarkDark;
        label22.ForeColor = Color.Transparent;
        label22.Location = new Point(10, 31);
        label22.Margin = new Padding(2, 0, 2, 0);
        label22.Name = "label22";
        label22.Padding = new Padding(1, 1, 25, 1);
        label22.Size = new Size(120, 17);
        label22.TabIndex = 1;
        label22.Text = "Mã mục hàng";
        // 
        // textBox20
        // 
        textBox20.BorderStyle = BorderStyle.FixedSingle;
        textBox20.Location = new Point(147, 31);
        textBox20.Margin = new Padding(2);
        textBox20.Name = "textBox20";
        textBox20.ReadOnly = true;
        textBox20.Size = new Size(283, 23);
        textBox20.TabIndex = 0;
        textBox20.Text = "SBA0020000/00.188.0125.0/0000000";
        // 
        // label23
        // 
        label23.BackColor = SystemColors.ControlDarkDark;
        label23.ForeColor = Color.Transparent;
        label23.Location = new Point(440, 54);
        label23.Margin = new Padding(2, 0, 2, 0);
        label23.Name = "label23";
        label23.Padding = new Padding(1);
        label23.Size = new Size(120, 17);
        label23.TabIndex = 1;
        label23.Text = "Custom input";
        // 
        // label24
        // 
        label24.BackColor = SystemColors.ControlDarkDark;
        label24.ForeColor = Color.Transparent;
        label24.Location = new Point(10, 7);
        label24.Margin = new Padding(2, 0, 2, 0);
        label24.Name = "label24";
        label24.Padding = new Padding(1);
        label24.Size = new Size(120, 17);
        label24.TabIndex = 1;
        label24.Text = "WOno";
        // 
        // textBox21
        // 
        textBox21.Location = new Point(147, 7);
        textBox21.Margin = new Padding(2);
        textBox21.Name = "textBox21";
        textBox21.Size = new Size(106, 23);
        textBox21.TabIndex = 0;
        // 
        // panel9
        // 
        panel9.Controls.Add(label16);
        panel9.Controls.Add(tbSono);
        panel9.Dock = DockStyle.Top;
        panel9.Location = new Point(0, 0);
        panel9.Margin = new Padding(2);
        panel9.Name = "panel9";
        panel9.Size = new Size(980, 43);
        panel9.TabIndex = 15;
        // 
        // label16
        // 
        label16.BackColor = SystemColors.ControlDarkDark;
        label16.ForeColor = Color.Transparent;
        label16.Location = new Point(10, 7);
        label16.Margin = new Padding(2, 0, 2, 0);
        label16.Name = "label16";
        label16.Padding = new Padding(1);
        label16.Size = new Size(120, 17);
        label16.TabIndex = 1;
        label16.Text = "SOno.";
        // 
        // tbSono
        // 
        tbSono.Location = new Point(147, 7);
        tbSono.Margin = new Padding(2);
        tbSono.Name = "tbSono";
        tbSono.Size = new Size(106, 23);
        tbSono.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 24);
        tabPage2.Margin = new Padding(2);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(2);
        tabPage2.Size = new Size(1299, 652);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Cửa sổ (W)";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Location = new Point(4, 24);
        tabPage3.Margin = new Padding(2);
        tabPage3.Name = "tabPage3";
        tabPage3.Size = new Size(1299, 652);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Công cụ (T)";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // tabPage4
        // 
        tabPage4.Location = new Point(4, 24);
        tabPage4.Margin = new Padding(2);
        tabPage4.Name = "tabPage4";
        tabPage4.Size = new Size(1299, 652);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Thông tin (I)";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // cmsToolMenu
        // 
        cmsToolMenu.Font = new Font("Segoe UI", 10F);
        cmsToolMenu.Name = "cmsToolMenu";
        cmsToolMenu.Size = new Size(61, 4);
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1307, 680);
        Controls.Add(tabControl1);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Form1";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        tcParent.ResumeLayout(false);
        tPRealPack.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dGvWono).EndInit();
        ((System.ComponentModel.ISupportInitialize)dGvDetail1).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        tPExport.ResumeLayout(false);
        tcChild.ResumeLayout(false);
        tpLabelCustom.ResumeLayout(false);
        panel11.ResumeLayout(false);
        panel11.PerformLayout();
        panel12.ResumeLayout(false);
        panel12.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
        panel9.ResumeLayout(false);
        panel9.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private ContextMenuStrip cmsToolMenu;
    private SplitContainer splitContainer1;
    private TreeView tVMenu;
    private Panel panel2;
    private TabControl tcParent;
    private TabPage tPRealPack;
    private Panel panel3;
    private Button button1;
    private Button btnQd;
    private CheckBox WonoCompleteCheck;
    private Label label10;
    private Panel panel1;
    private Label label2;
    private TextBox textBox3;
    private Label label1;
    private TextBox textBox2;
    private Label lbWn;
    private TextBox tbFpi;
    private TabPage tPExport;
    private TabControl tcChild;
    private TabPage tabPage9;
    private TabPage tabPage10;
    private TabPage tpLabelCustom;
    private Panel panel11;
    private Button button2;
    private Button button3;
    private CheckBox checkBox1;
    private Label label5;
    private Panel panel12;
    private Label label14;
    private DataGridView dataGridView4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private CustomUI.DSM_TextBox dsM_TextBox3;
    private Label label21;
    private TextBox textBox19;
    private Label label22;
    private TextBox textBox20;
    private Label label23;
    private Label label24;
    private TextBox textBox21;
    private Panel panel9;
    private Label label16;
    private TextBox tbSono;
    private Button button5;
    private Button button4;
    private Label label3;
    private TextBox textBox4;
    private TextBox textBox1;
    private Label label6;
    private Label label4;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox5;
    private Label label7;
    private TextBox textBox9;
    private TextBox textBox8;
    private MaskedTextBox mtbDate;
    private CheckBox checkBox2;
    private Label label8;
    private Label label11;
    private Label label9;
    private TextBox textBox11;
    private TextBox textBox10;
    private Label label12;
    private Label label15;
    private TextBox textBox13;
    private TextBox textBox12;
    private Label label17;
    private TextBox textBox17;
    private TextBox textBox14;
    private TextBox textBox16;
    private Label label18;
    private FlowLayoutPanel flowLayoutPanel1;
    private RadioButton rbHb;
    private RadioButton rbK;
    private RadioButton RbBnl;
    private RadioButton rbGg;
    private RadioButton rbOther;
    private DataGridView dGvWono;
    private Label label20;
    private DataGridView dGvDetail1;
    private Label label19;
    private Label label13;
    private TextBox tbPacker;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
}
