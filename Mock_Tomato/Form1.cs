using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mock_Tomato;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitGrid();
        InitGridValue();

        tVMenu.ExpandAll();
    }

    private void InitGrid()
    {
        var grid = dataGridView1;

        // --- Cấu hình hành vi chung ---
        grid.AutoGenerateColumns = false;
        grid.AllowUserToAddRows = false;
        grid.ReadOnly = true;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.MultiSelect = false;
        grid.RowHeadersVisible = false; // Ẩn cột đầu dòng để tiết kiệm diện tích
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;

        // --- Cấu hình Header (Tiêu đề) ---
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersHeight = 40; // Tăng độ cao cho dễ nhìn
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // --- Cấu hình Rows (Dòng dữ liệu) ---
        grid.DefaultCellStyle.Font = new Font("Segoe UI", 9);
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255); // Màu xanh nhẹ khi chọn
        grid.DefaultCellStyle.SelectionForeColor = Color.Black;
        grid.RowTemplate.Height = 35; // Dòng cao hơn nhìn sẽ thoáng hơn
        grid.GridColor = Color.FromArgb(224, 224, 224);

        // --- Xen kẽ màu dòng (Zebra Effect) ---
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

        // --- Thêm cột (Giữ nguyên logic của bạn nhưng tối ưu hóa Alignment) ---
        grid.Columns.Clear();

        // Tạo mảng cấu hình để thêm nhanh và dễ quản lý
        grid.Columns.Add(CreateTextCol("colStt", "STT", 50, DataGridViewContentAlignment.MiddleCenter));
        grid.Columns.Add(CreateTextCol("colInfo", "Thông tin chung", 260, DataGridViewContentAlignment.MiddleLeft));
        grid.Columns.Add(CreateTextCol("colType", "Loại công", 260, DataGridViewContentAlignment.MiddleLeft));
        grid.Columns.Add(CreateTextCol("colMachine", "Máy", 160, DataGridViewContentAlignment.MiddleLeft));
        grid.Columns.Add(CreateTextCol("colLT", "L/T", 80, DataGridViewContentAlignment.MiddleCenter));
        grid.Columns.Add(CreateTextCol("colDuration", "Thời gian", 100, DataGridViewContentAlignment.MiddleCenter));
        grid.Columns.Add(CreateTextCol("colOperator", "Vận hành kế", 130, DataGridViewContentAlignment.MiddleLeft));
        grid.Columns.Add(CreateTextCol("colPlanStart", "Dự định bắt đầu", 180, DataGridViewContentAlignment.MiddleCenter));
        grid.Columns.Add(CreateTextCol("colPlanEnd", "Dự định hoàn thành", 180, DataGridViewContentAlignment.MiddleCenter));
        grid.Columns.Add(CreateTextCol("colPO", "Số đặt hàng", 130, DataGridViewContentAlignment.MiddleRight));
        grid.Columns.Add(CreateTextCol("colQty", "Số lượng", 130, DataGridViewContentAlignment.MiddleRight));

        grid.Columns.Add(new DataGridViewCheckBoxColumn
        {
            Name = "colDone",
            HeaderText = "HT",
            Width = 50,
            FlatStyle = FlatStyle.Flat // Nhìn hiện đại hơn
        });
    }

    // Hàm bổ trợ để tạo cột nhanh hơn, tránh lặp code
    private DataGridViewTextBoxColumn CreateTextCol(string name, string header, int width, DataGridViewContentAlignment align)
    {
        return new DataGridViewTextBoxColumn
        {
            Name = name,
            HeaderText = header,
            Width = width,
            DefaultCellStyle = { Alignment = align }
        };
    }

    private void AddRow(
    int stt,
    string info,
    string type,
    string machine,
    string lt,
    string duration,
    string operatorName,
    string planStart,
    string planEnd,
    int soDatHang,
    int soLuong
)
    {
        bool isDone = soDatHang == soLuong;

        dataGridView1.Rows.Add(
            stt,
            info,
            type,
            machine,
            lt,
            duration,
            operatorName,
            planStart,
            planEnd,
            soDatHang,   // colPO
            soLuong,     // colQty
            isDone       // colDone
        );
    }
    private void InitGridValue()
    {
        dataGridView1.Rows.Clear();

        AddRow(1, "WO-2026-001", "M-SLT", "SLITTER", "2", "5", "14",
            "28/02/2026", "03/03/2026", 1256, 1256); // HT = true

        AddRow(2, "WO-2026-002", "M-CUT", "CUTTER", "1.5", "4", "12",
            "01/03/2026", "04/03/2026", 1000, 980); // false

        AddRow(3, "WO-2026-003", "M-PRS", "PRESS", "3", "6", "18",
            "02/03/2026", "05/03/2026", 1500, 1500); // true

        AddRow(4, "WO-2026-004", "M-LAM", "LAMINATE", "2.5", "5", "16",
            "03/03/2026", "06/03/2026", 1200, 1100); // false

        AddRow(5, "WO-2026-005", "M-INS", "INSPECT", "1", "3", "8",
            "04/03/2026", "07/03/2026", 760, 760); // true
    }

}
