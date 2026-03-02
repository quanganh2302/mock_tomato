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
        TreeNode treeNode1 = new TreeNode("Cấp vật liệu");
        TreeNode treeNode2 = new TreeNode("Danh sách Wono");
        TreeNode treeNode3 = new TreeNode("Nhập kết quả");
        TreeNode treeNode4 = new TreeNode("MRF Summarise");
        TreeNode treeNode5 = new TreeNode("Hoàn thành Wono");
        TreeNode treeNode6 = new TreeNode("Quản lý sản xuất", new TreeNode[] { treeNode2, treeNode3, treeNode4, treeNode5 });
        TreeNode treeNode7 = new TreeNode("Mes");
        TreeNode treeNode8 = new TreeNode("Đối chiếu tồn kho");
        TreeNode treeNode9 = new TreeNode("Chi tiết xuất hàng");
        TreeNode treeNode10 = new TreeNode("Tồn kho tự động");
        TreeNode treeNode11 = new TreeNode("Quản lý kho", new TreeNode[] { treeNode8, treeNode9, treeNode10 });
        TreeNode treeNode12 = new TreeNode("Inventory check");
        TreeNode treeNode13 = new TreeNode("Báo cáo");
        TreeNode treeNode14 = new TreeNode("Menu", new TreeNode[] { treeNode1, treeNode6, treeNode7, treeNode11, treeNode12, treeNode13 });
        splitContainer1 = new SplitContainer();
        tVMenu = new TreeView();
        tabControl2 = new TabControl();
        tabPage5 = new TabPage();
        panel10 = new Panel();
        gB2 = new GroupBox();
        panel8 = new Panel();
        dataGridView3 = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
        PackingTypeGroup = new Panel();
        rBNi = new RadioButton();
        rBOther = new RadioButton();
        rBK = new RadioButton();
        rBPa = new RadioButton();
        rBBox = new RadioButton();
        panel7 = new Panel();
        btnAdd = new Button();
        label11 = new Label();
        panel6 = new Panel();
        textBox13 = new TextBox();
        textBox14 = new TextBox();
        label12 = new Label();
        gB1 = new GroupBox();
        dataGridView2 = new DataGridView();
        Column1 = new DataGridViewTextBoxColumn();
        Column2 = new DataGridViewTextBoxColumn();
        Column3 = new DataGridViewTextBoxColumn();
        Column4 = new DataGridViewTextBoxColumn();
        Column5 = new DataGridViewTextBoxColumn();
        Column6 = new DataGridViewTextBoxColumn();
        panel5 = new Panel();
        label9 = new Label();
        textBox10 = new TextBox();
        textBox12 = new TextBox();
        label8 = new Label();
        textBox11 = new TextBox();
        panel4 = new Panel();
        textBox6 = new TextBox();
        label7 = new Label();
        label6 = new Label();
        label3 = new Label();
        textBox9 = new TextBox();
        textBox7 = new TextBox();
        textBox8 = new TextBox();
        textBox4 = new TextBox();
        label5 = new Label();
        label4 = new Label();
        CompletedCountField = new TextBox();
        tabPage6 = new TabPage();
        panel3 = new Panel();
        button1 = new Button();
        btnQd = new Button();
        WonoCompleteCheck = new CheckBox();
        label10 = new Label();
        panel2 = new Panel();
        dataGridView1 = new DataGridView();
        panel1 = new Panel();
        tbCS = new Mock_Tomato.CustomUI.DSM_TextBox();
        label2 = new Label();
        textBox3 = new TextBox();
        label1 = new Label();
        textBox2 = new TextBox();
        label13 = new Label();
        lbWn = new Label();
        WonoField = new TextBox();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        tabPage3 = new TabPage();
        tabPage4 = new TabPage();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        tabControl2.SuspendLayout();
        tabPage5.SuspendLayout();
        gB2.SuspendLayout();
        panel8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
        PackingTypeGroup.SuspendLayout();
        panel7.SuspendLayout();
        panel6.SuspendLayout();
        gB1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(3, 3);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(tVMenu);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(tabControl2);
        splitContainer1.Panel2.Controls.Add(panel3);
        splitContainer1.Panel2.Controls.Add(panel2);
        splitContainer1.Panel2.Controls.Add(panel1);
        splitContainer1.Size = new Size(1853, 1089);
        splitContainer1.SplitterDistance = 415;
        splitContainer1.TabIndex = 0;
        // 
        // tVMenu
        // 
        tVMenu.Dock = DockStyle.Fill;
        tVMenu.Location = new Point(0, 0);
        tVMenu.Name = "tVMenu";
        treeNode1.Name = "nC1";
        treeNode1.Text = "Cấp vật liệu";
        treeNode2.Name = "nC11";
        treeNode2.Text = "Danh sách Wono";
        treeNode3.Name = "nC12";
        treeNode3.Text = "Nhập kết quả";
        treeNode4.Name = "nC13";
        treeNode4.Text = "MRF Summarise";
        treeNode5.Name = "nC14";
        treeNode5.Text = "Hoàn thành Wono";
        treeNode6.Name = "nC2";
        treeNode6.Text = "Quản lý sản xuất";
        treeNode7.Name = "nC3";
        treeNode7.Text = "Mes";
        treeNode8.Name = "nC41";
        treeNode8.Text = "Đối chiếu tồn kho";
        treeNode9.Name = "nC42";
        treeNode9.Text = "Chi tiết xuất hàng";
        treeNode10.Name = "nC43";
        treeNode10.Text = "Tồn kho tự động";
        treeNode11.Name = "nC4";
        treeNode11.Text = "Quản lý kho";
        treeNode12.Name = "nC5";
        treeNode12.Text = "Inventory check";
        treeNode13.Name = "nC6";
        treeNode13.Text = "Báo cáo";
        treeNode14.Name = "nMain";
        treeNode14.Text = "Menu";
        tVMenu.Nodes.AddRange(new TreeNode[] { treeNode14 });
        tVMenu.Size = new Size(415, 1089);
        tVMenu.TabIndex = 0;
        // 
        // tabControl2
        // 
        tabControl2.Controls.Add(tabPage5);
        tabControl2.Controls.Add(tabPage6);
        tabControl2.Dock = DockStyle.Top;
        tabControl2.Location = new Point(0, 545);
        tabControl2.Name = "tabControl2";
        tabControl2.SelectedIndex = 0;
        tabControl2.Size = new Size(1434, 456);
        tabControl2.TabIndex = 3;
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(panel10);
        tabPage5.Controls.Add(gB2);
        tabPage5.Controls.Add(gB1);
        tabPage5.Controls.Add(panel4);
        tabPage5.Location = new Point(4, 34);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(1426, 418);
        tabPage5.TabIndex = 0;
        tabPage5.Text = "Hoàn Thành";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // panel10
        // 
        panel10.Dock = DockStyle.Left;
        panel10.Location = new Point(678, 103);
        panel10.Name = "panel10";
        panel10.Size = new Size(8, 312);
        panel10.TabIndex = 4;
        // 
        // gB2
        // 
        gB2.Controls.Add(panel8);
        gB2.Controls.Add(panel7);
        gB2.Controls.Add(panel6);
        gB2.Dock = DockStyle.Fill;
        gB2.Location = new Point(678, 103);
        gB2.Name = "gB2";
        gB2.Size = new Size(745, 312);
        gB2.TabIndex = 3;
        gB2.TabStop = false;
        gB2.Text = "Cộng gộp tồn kho tự do (xuất phiếu hàng nội bộ)";
        // 
        // panel8
        // 
        panel8.Controls.Add(dataGridView3);
        panel8.Controls.Add(PackingTypeGroup);
        panel8.Dock = DockStyle.Fill;
        panel8.Location = new Point(202, 79);
        panel8.Name = "panel8";
        panel8.Size = new Size(540, 230);
        panel8.TabIndex = 15;
        // 
        // dataGridView3
        // 
        dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
        dataGridView3.Dock = DockStyle.Bottom;
        dataGridView3.Location = new Point(0, 85);
        dataGridView3.Name = "dataGridView3";
        dataGridView3.RowHeadersVisible = false;
        dataGridView3.RowHeadersWidth = 62;
        dataGridView3.Size = new Size(540, 145);
        dataGridView3.TabIndex = 14;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn1.HeaderText = "Số lượng đóng";
        dataGridViewTextBoxColumn1.MinimumWidth = 8;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.Width = 169;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn2.HeaderText = "Số lô";
        dataGridViewTextBoxColumn2.MinimumWidth = 8;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.Width = 89;
        // 
        // dataGridViewTextBoxColumn3
        // 
        dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        dataGridViewTextBoxColumn3.HeaderText = "DEL";
        dataGridViewTextBoxColumn3.MinimumWidth = 8;
        dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        dataGridViewTextBoxColumn3.Width = 78;
        // 
        // PackingTypeGroup
        // 
        PackingTypeGroup.BorderStyle = BorderStyle.FixedSingle;
        PackingTypeGroup.Controls.Add(rBNi);
        PackingTypeGroup.Controls.Add(rBOther);
        PackingTypeGroup.Controls.Add(rBK);
        PackingTypeGroup.Controls.Add(rBPa);
        PackingTypeGroup.Controls.Add(rBBox);
        PackingTypeGroup.Dock = DockStyle.Top;
        PackingTypeGroup.Location = new Point(0, 0);
        PackingTypeGroup.Name = "PackingTypeGroup";
        PackingTypeGroup.Size = new Size(540, 79);
        PackingTypeGroup.TabIndex = 0;
        // 
        // rBNi
        // 
        rBNi.AutoSize = true;
        rBNi.Location = new Point(189, 6);
        rBNi.Name = "rBNi";
        rBNi.Size = new Size(121, 29);
        rBNi.TabIndex = 0;
        rBNi.TabStop = true;
        rBNi.Text = "Bao Ni-lon";
        rBNi.UseVisualStyleBackColor = true;
        // 
        // rBOther
        // 
        rBOther.AutoSize = true;
        rBOther.Location = new Point(109, 41);
        rBOther.Name = "rBOther";
        rBOther.Size = new Size(74, 29);
        rBOther.TabIndex = 0;
        rBOther.TabStop = true;
        rBOther.Text = "Khác";
        rBOther.UseVisualStyleBackColor = true;
        // 
        // rBK
        // 
        rBK.AutoSize = true;
        rBK.Location = new Point(113, 6);
        rBK.Name = "rBK";
        rBK.Size = new Size(70, 29);
        rBK.TabIndex = 0;
        rBK.TabStop = true;
        rBK.Text = "Kiện";
        rBK.UseVisualStyleBackColor = true;
        // 
        // rBPa
        // 
        rBPa.AutoSize = true;
        rBPa.Location = new Point(6, 41);
        rBPa.Name = "rBPa";
        rBPa.Size = new Size(102, 29);
        rBPa.TabIndex = 0;
        rBPa.TabStop = true;
        rBPa.Text = "Gói giấy";
        rBPa.UseVisualStyleBackColor = true;
        // 
        // rBBox
        // 
        rBBox.AutoSize = true;
        rBBox.Location = new Point(6, 6);
        rBBox.Name = "rBBox";
        rBBox.Size = new Size(101, 29);
        rBBox.TabIndex = 0;
        rBBox.TabStop = true;
        rBBox.Text = "Hộp bìa";
        rBBox.UseVisualStyleBackColor = true;
        // 
        // panel7
        // 
        panel7.Controls.Add(btnAdd);
        panel7.Controls.Add(label11);
        panel7.Dock = DockStyle.Left;
        panel7.Location = new Point(3, 79);
        panel7.Name = "panel7";
        panel7.Size = new Size(199, 230);
        panel7.TabIndex = 14;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(43, 193);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 11;
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // label11
        // 
        label11.BackColor = SystemColors.ControlDarkDark;
        label11.ForeColor = Color.Transparent;
        label11.Location = new Point(3, 3);
        label11.Name = "label11";
        label11.Padding = new Padding(2, 2, 36, 2);
        label11.Size = new Size(172, 29);
        label11.TabIndex = 10;
        label11.Text = "Kiểu đóng gói";
        // 
        // panel6
        // 
        panel6.Controls.Add(textBox13);
        panel6.Controls.Add(textBox14);
        panel6.Controls.Add(label12);
        panel6.Dock = DockStyle.Top;
        panel6.Location = new Point(3, 27);
        panel6.Name = "panel6";
        panel6.Size = new Size(739, 52);
        panel6.TabIndex = 13;
        // 
        // textBox13
        // 
        textBox13.BorderStyle = BorderStyle.FixedSingle;
        textBox13.Location = new Point(347, 11);
        textBox13.Name = "textBox13";
        textBox13.ReadOnly = true;
        textBox13.Size = new Size(43, 31);
        textBox13.TabIndex = 11;
        textBox13.Text = "M";
        // 
        // textBox14
        // 
        textBox14.BorderStyle = BorderStyle.FixedSingle;
        textBox14.Location = new Point(198, 10);
        textBox14.Name = "textBox14";
        textBox14.ReadOnly = true;
        textBox14.Size = new Size(143, 31);
        textBox14.TabIndex = 8;
        // 
        // label12
        // 
        label12.BackColor = SystemColors.ControlDarkDark;
        label12.ForeColor = Color.Transparent;
        label12.Location = new Point(3, 10);
        label12.Name = "label12";
        label12.Padding = new Padding(2, 2, 36, 2);
        label12.Size = new Size(172, 29);
        label12.TabIndex = 9;
        label12.Text = "Số hoàn thành";
        // 
        // gB1
        // 
        gB1.Controls.Add(dataGridView2);
        gB1.Controls.Add(panel5);
        gB1.Dock = DockStyle.Left;
        gB1.Location = new Point(3, 103);
        gB1.Margin = new Padding(3, 3, 12, 3);
        gB1.Name = "gB1";
        gB1.Size = new Size(675, 312);
        gB1.TabIndex = 2;
        gB1.TabStop = false;
        gB1.Text = "Cộng gộp hàng liên kết";
        // 
        // dataGridView2
        // 
        dataGridView2.AllowUserToAddRows = false;
        dataGridView2.AllowUserToDeleteRows = false;
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
        dataGridView2.Dock = DockStyle.Fill;
        dataGridView2.Location = new Point(3, 123);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.ReadOnly = true;
        dataGridView2.RowHeadersVisible = false;
        dataGridView2.RowHeadersWidth = 62;
        dataGridView2.Size = new Size(669, 186);
        dataGridView2.TabIndex = 13;
        // 
        // Column1
        // 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        Column1.HeaderText = "Giao";
        Column1.MinimumWidth = 8;
        Column1.Name = "Column1";
        Column1.ReadOnly = true;
        Column1.Width = 84;
        // 
        // Column2
        // 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        Column2.HeaderText = "Ngày hẹn";
        Column2.MinimumWidth = 8;
        Column2.Name = "Column2";
        Column2.ReadOnly = true;
        Column2.Width = 124;
        // 
        // Column3
        // 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        Column3.HeaderText = "Số lượng";
        Column3.MinimumWidth = 8;
        Column3.Name = "Column3";
        Column3.ReadOnly = true;
        Column3.Width = 121;
        // 
        // Column4
        // 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        Column4.HeaderText = "Số phân bổ";
        Column4.MinimumWidth = 8;
        Column4.Name = "Column4";
        Column4.ReadOnly = true;
        Column4.Width = 141;
        // 
        // Column5
        // 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        Column5.HeaderText = "Số chưa";
        Column5.MinimumWidth = 8;
        Column5.Name = "Column5";
        Column5.ReadOnly = true;
        Column5.Width = 112;
        // 
        // Column6
        // 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        Column6.HeaderText = "Số hoàn";
        Column6.MinimumWidth = 8;
        Column6.Name = "Column6";
        Column6.ReadOnly = true;
        Column6.Width = 114;
        // 
        // panel5
        // 
        panel5.Controls.Add(label9);
        panel5.Controls.Add(textBox10);
        panel5.Controls.Add(textBox12);
        panel5.Controls.Add(label8);
        panel5.Controls.Add(textBox11);
        panel5.Dock = DockStyle.Top;
        panel5.Location = new Point(3, 27);
        panel5.Name = "panel5";
        panel5.Size = new Size(669, 96);
        panel5.TabIndex = 12;
        // 
        // label9
        // 
        label9.BackColor = SystemColors.ControlDarkDark;
        label9.ForeColor = Color.Transparent;
        label9.Location = new Point(3, 10);
        label9.Name = "label9";
        label9.Padding = new Padding(2);
        label9.Size = new Size(172, 29);
        label9.TabIndex = 10;
        label9.Text = "Ngày nhập";
        // 
        // textBox10
        // 
        textBox10.BorderStyle = BorderStyle.FixedSingle;
        textBox10.Location = new Point(347, 50);
        textBox10.Name = "textBox10";
        textBox10.ReadOnly = true;
        textBox10.Size = new Size(43, 31);
        textBox10.TabIndex = 11;
        textBox10.Text = "M";
        // 
        // textBox12
        // 
        textBox12.BorderStyle = BorderStyle.FixedSingle;
        textBox12.Location = new Point(198, 49);
        textBox12.Name = "textBox12";
        textBox12.ReadOnly = true;
        textBox12.Size = new Size(143, 31);
        textBox12.TabIndex = 8;
        // 
        // label8
        // 
        label8.BackColor = SystemColors.ControlDarkDark;
        label8.ForeColor = Color.Transparent;
        label8.Location = new Point(3, 49);
        label8.Name = "label8";
        label8.Padding = new Padding(2, 2, 36, 2);
        label8.Size = new Size(172, 29);
        label8.TabIndex = 9;
        label8.Text = "Số hoàn thành";
        // 
        // textBox11
        // 
        textBox11.BorderStyle = BorderStyle.FixedSingle;
        textBox11.Location = new Point(198, 10);
        textBox11.Name = "textBox11";
        textBox11.ReadOnly = true;
        textBox11.Size = new Size(192, 31);
        textBox11.TabIndex = 7;
        textBox11.Text = "02/03/2026";
        // 
        // panel4
        // 
        panel4.Controls.Add(textBox6);
        panel4.Controls.Add(label7);
        panel4.Controls.Add(label6);
        panel4.Controls.Add(label3);
        panel4.Controls.Add(textBox9);
        panel4.Controls.Add(textBox7);
        panel4.Controls.Add(textBox8);
        panel4.Controls.Add(textBox4);
        panel4.Controls.Add(label5);
        panel4.Controls.Add(label4);
        panel4.Controls.Add(CompletedCountField);
        panel4.Dock = DockStyle.Top;
        panel4.Location = new Point(3, 3);
        panel4.Name = "panel4";
        panel4.Size = new Size(1420, 100);
        panel4.TabIndex = 1;
        panel4.TabStop = true;
        // 
        // textBox6
        // 
        textBox6.BorderStyle = BorderStyle.FixedSingle;
        textBox6.Location = new Point(352, 52);
        textBox6.Name = "textBox6";
        textBox6.ReadOnly = true;
        textBox6.Size = new Size(43, 31);
        textBox6.TabIndex = 6;
        textBox6.Text = "M";
        // 
        // label7
        // 
        label7.BackColor = SystemColors.ControlDarkDark;
        label7.ForeColor = Color.Transparent;
        label7.Location = new Point(843, 53);
        label7.Name = "label7";
        label7.Padding = new Padding(2, 2, 36, 2);
        label7.Size = new Size(111, 29);
        label7.TabIndex = 4;
        label7.Text = "Remark";
        // 
        // label6
        // 
        label6.BackColor = SystemColors.ControlDarkDark;
        label6.ForeColor = Color.Transparent;
        label6.Location = new Point(426, 53);
        label6.Name = "label6";
        label6.Padding = new Padding(2, 2, 36, 2);
        label6.Size = new Size(172, 29);
        label6.TabIndex = 4;
        label6.Text = "Lô chế tạo";
        // 
        // label3
        // 
        label3.BackColor = SystemColors.ControlDarkDark;
        label3.ForeColor = Color.Transparent;
        label3.Location = new Point(8, 51);
        label3.Name = "label3";
        label3.Padding = new Padding(2, 2, 36, 2);
        label3.Size = new Size(172, 29);
        label3.TabIndex = 4;
        label3.Text = "Số hoàn thành";
        // 
        // textBox9
        // 
        textBox9.BorderStyle = BorderStyle.FixedSingle;
        textBox9.Location = new Point(978, 53);
        textBox9.Name = "textBox9";
        textBox9.ReadOnly = true;
        textBox9.Size = new Size(192, 31);
        textBox9.TabIndex = 2;
        // 
        // textBox7
        // 
        textBox7.BorderStyle = BorderStyle.FixedSingle;
        textBox7.Location = new Point(621, 53);
        textBox7.Name = "textBox7";
        textBox7.ReadOnly = true;
        textBox7.Size = new Size(192, 31);
        textBox7.TabIndex = 2;
        // 
        // textBox8
        // 
        textBox8.BorderStyle = BorderStyle.FixedSingle;
        textBox8.Location = new Point(621, 13);
        textBox8.Name = "textBox8";
        textBox8.ReadOnly = true;
        textBox8.Size = new Size(192, 31);
        textBox8.TabIndex = 2;
        textBox8.Text = "02/03/2026";
        // 
        // textBox4
        // 
        textBox4.BorderStyle = BorderStyle.FixedSingle;
        textBox4.Location = new Point(203, 11);
        textBox4.Name = "textBox4";
        textBox4.ReadOnly = true;
        textBox4.Size = new Size(192, 31);
        textBox4.TabIndex = 2;
        textBox4.Text = "02/03/2026";
        // 
        // label5
        // 
        label5.BackColor = SystemColors.ControlDarkDark;
        label5.ForeColor = Color.Transparent;
        label5.Location = new Point(426, 13);
        label5.Name = "label5";
        label5.Padding = new Padding(2);
        label5.Size = new Size(172, 29);
        label5.TabIndex = 5;
        label5.Text = "Ngày vào số ";
        // 
        // label4
        // 
        label4.BackColor = SystemColors.ControlDarkDark;
        label4.ForeColor = Color.Transparent;
        label4.Location = new Point(8, 11);
        label4.Name = "label4";
        label4.Padding = new Padding(2);
        label4.Size = new Size(172, 29);
        label4.TabIndex = 5;
        label4.Text = "Ngày nhập";
        // 
        // CompletedCountField
        // 
        CompletedCountField.Location = new Point(203, 51);
        CompletedCountField.Name = "CompletedCountField";
        CompletedCountField.Size = new Size(143, 31);
        CompletedCountField.TabIndex = 3;
        // 
        // tabPage6
        // 
        tabPage6.Location = new Point(4, 34);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3);
        tabPage6.Size = new Size(1426, 418);
        tabPage6.TabIndex = 1;
        tabPage6.Text = "Dữ liệu quá khứ";
        tabPage6.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Controls.Add(button1);
        panel3.Controls.Add(btnQd);
        panel3.Controls.Add(WonoCompleteCheck);
        panel3.Controls.Add(label10);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 545);
        panel3.Name = "panel3";
        panel3.Size = new Size(1434, 544);
        panel3.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new Point(1218, 462);
        button1.Name = "button1";
        button1.Size = new Size(206, 34);
        button1.TabIndex = 7;
        button1.Text = "Đóng (ESC)";
        button1.UseVisualStyleBackColor = true;
        // 
        // btnQd
        // 
        btnQd.Location = new Point(239, 459);
        btnQd.Name = "btnQd";
        btnQd.Size = new Size(206, 34);
        btnQd.TabIndex = 7;
        btnQd.Text = "Quyết định (F3)";
        btnQd.UseVisualStyleBackColor = true;
        // 
        // WonoCompleteCheck
        // 
        WonoCompleteCheck.AutoSize = true;
        WonoCompleteCheck.Location = new Point(193, 462);
        WonoCompleteCheck.Name = "WonoCompleteCheck";
        WonoCompleteCheck.Size = new Size(22, 21);
        WonoCompleteCheck.TabIndex = 6;
        WonoCompleteCheck.UseVisualStyleBackColor = true;
        // 
        // label10
        // 
        label10.BackColor = SystemColors.ControlDarkDark;
        label10.ForeColor = Color.Transparent;
        label10.Location = new Point(15, 459);
        label10.Name = "label10";
        label10.Padding = new Padding(2);
        label10.Size = new Size(172, 29);
        label10.TabIndex = 5;
        label10.Text = "Ngày nhập";
        // 
        // panel2
        // 
        panel2.Controls.Add(dataGridView1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 130);
        panel2.Name = "panel2";
        panel2.Size = new Size(1434, 415);
        panel2.TabIndex = 1;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(1434, 415);
        dataGridView1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(tbCS);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(textBox3);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(label13);
        panel1.Controls.Add(lbWn);
        panel1.Controls.Add(WonoField);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1434, 130);
        panel1.TabIndex = 0;
        // 
        // tbCS
        // 
        tbCS.BackColor = SystemColors.Window;
        tbCS.BorderColor = Color.LightGray;
        tbCS.ForeColor = Color.Black;
        tbCS.Location = new Point(813, 77);
        tbCS.Margin = new Padding(6, 7, 6, 7);
        tbCS.Name = "tbCS";
        tbCS.Padding = new Padding(8);
        tbCS.Size = new Size(148, 42);
        tbCS.TabIndex = 2;
        // 
        // label2
        // 
        label2.BackColor = SystemColors.ControlDarkDark;
        label2.ForeColor = Color.Transparent;
        label2.Location = new Point(15, 90);
        label2.Name = "label2";
        label2.Padding = new Padding(2);
        label2.Size = new Size(172, 29);
        label2.TabIndex = 1;
        label2.Text = "Số đặt hàng";
        // 
        // textBox3
        // 
        textBox3.BorderStyle = BorderStyle.FixedSingle;
        textBox3.Location = new Point(210, 90);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new Size(150, 31);
        textBox3.TabIndex = 0;
        textBox3.Text = "1,256.00";
        textBox3.TextAlign = HorizontalAlignment.Right;
        // 
        // label1
        // 
        label1.BackColor = SystemColors.ControlDarkDark;
        label1.ForeColor = Color.Transparent;
        label1.Location = new Point(15, 51);
        label1.Name = "label1";
        label1.Padding = new Padding(2, 2, 36, 2);
        label1.Size = new Size(172, 29);
        label1.TabIndex = 1;
        label1.Text = "Mã mục hàng";
        // 
        // textBox2
        // 
        textBox2.BorderStyle = BorderStyle.FixedSingle;
        textBox2.Location = new Point(210, 51);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(404, 31);
        textBox2.TabIndex = 0;
        textBox2.Text = "SBA0020000/00.188.0125.0/0000000";
        // 
        // label13
        // 
        label13.BackColor = SystemColors.ControlDarkDark;
        label13.ForeColor = Color.Transparent;
        label13.Location = new Point(628, 90);
        label13.Name = "label13";
        label13.Padding = new Padding(2);
        label13.Size = new Size(172, 29);
        label13.TabIndex = 1;
        label13.Text = "Custom input";
        // 
        // lbWn
        // 
        lbWn.BackColor = SystemColors.ControlDarkDark;
        lbWn.ForeColor = Color.Transparent;
        lbWn.Location = new Point(15, 12);
        lbWn.Name = "lbWn";
        lbWn.Padding = new Padding(2);
        lbWn.Size = new Size(172, 29);
        lbWn.TabIndex = 1;
        lbWn.Text = "WOno";
        // 
        // WonoField
        // 
        WonoField.Location = new Point(210, 12);
        WonoField.Name = "WonoField";
        WonoField.Size = new Size(150, 31);
        WonoField.TabIndex = 0;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Controls.Add(tabPage4);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1867, 1133);
        tabControl1.TabIndex = 1;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(splitContainer1);
        tabPage1.Location = new Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1859, 1095);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "File (F)";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 34);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1859, 1095);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Cửa sổ (W)";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Location = new Point(4, 34);
        tabPage3.Name = "tabPage3";
        tabPage3.Size = new Size(1859, 1095);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Công cụ (T)";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // tabPage4
        // 
        tabPage4.Location = new Point(4, 34);
        tabPage4.Name = "tabPage4";
        tabPage4.Size = new Size(1859, 1095);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Thông tin (I)";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1867, 1133);
        Controls.Add(tabControl1);
        Name = "Form1";
        Text = "Form1";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        tabControl2.ResumeLayout(false);
        tabPage5.ResumeLayout(false);
        gB2.ResumeLayout(false);
        panel8.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
        PackingTypeGroup.ResumeLayout(false);
        PackingTypeGroup.PerformLayout();
        panel7.ResumeLayout(false);
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        gB1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private TreeView tVMenu;
    private Panel panel1;
    private Label label2;
    private TextBox textBox3;
    private Label label1;
    private TextBox textBox2;
    private Label lbWn;
    private TextBox WonoField;
    private Panel panel2;
    private DataGridView dataGridView1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Panel panel3;
    private TabControl tabControl2;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private GroupBox gB2;
    private GroupBox gB1;
    private Panel panel4;
    private Label label3;
    private TextBox textBox4;
    private Label label4;
    private TextBox CompletedCountField;
    private TextBox textBox6;
    private Label label7;
    private Label label6;
    private TextBox textBox9;
    private TextBox textBox7;
    private TextBox textBox8;
    private Label label5;
    private TextBox textBox10;
    private Label label8;
    private TextBox textBox11;
    private Label label9;
    private TextBox textBox12;
    private DataGridView dataGridView2;
    private Panel panel5;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private Panel panel8;
    private Panel panel7;
    private Button btnAdd;
    private Label label11;
    private Panel panel6;
    private TextBox textBox13;
    private TextBox textBox14;
    private Label label12;
    private Button btnQd;
    private CheckBox WonoCompleteCheck;
    private Label label10;
    private DataGridView dataGridView3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private Panel PackingTypeGroup;
    private RadioButton rBNi;
    private RadioButton rBOther;
    private RadioButton rBK;
    private RadioButton rBPa;
    private RadioButton rBBox;
    private Button button1;
    private Panel panel10;
    private Label label13;
    private CustomUI.DSM_TextBox tbCS;
}
