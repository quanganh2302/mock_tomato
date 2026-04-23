using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mock_Tomato;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        objTreeMenu.ExpandAll();
    }

    private void TabControl1_Selecting(object? sender, TabControlCancelEventArgs e)
    {
        // If user is trying to select the "Công cụ (T)" tab (tabPage3) we previously
        // always cancelled the selection and showed a context menu. That made the tab
        // unclickable when the context menu had no items.
        //
        // Change: only cancel the tab selection and show the context menu when the
        if (e.TabPage == tabPage3)
        {
            e.Cancel = true;
            try
            {
                using var printerForm = new PrinterInformationForm();
                printerForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Unable to open printer settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void TsmiPrinter_Click(object? sender, EventArgs e)
    {
        using var printerForm = new PrinterInformationForm();
        printerForm.ShowDialog(this);
    }

    private void ObjTreeMenu_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
    {
        switch (e.Node.Name)
        {
            case "nCRealPack":
                tcParent.SelectedIndex = 0;
                break;
            case "nCPrint":
                tcParent.SelectedIndex = 1;
                break;
        }
    }

}
