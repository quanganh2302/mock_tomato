using System.Drawing.Printing;
using System.Text.Json;

namespace Mock_Tomato;

public class PrinterInformationForm : Form
{
    private static readonly string SettingsFilePath = Path.Combine(
        AppContext.BaseDirectory, "printer_settings.json");

    private readonly string[] _printerLabels =
    [
        "NORMAL PRINTER",
        "WO PRINTER",
        "PO PRINTER",
        "PO PRINTER (TS)",
        "FP1 PRINTER",
        "FP1 PRINTER (2)",
        "INVOICE PRINTER",
        "INVOICE PRINTER (HS)",
        "PACKING LIST (CN)",
        "LMI/FP PRINTER",
        "LABEL PRINTER L",
        "LABEL PRINTER S",
        "LABEL_PRINTER (CS)",
        "ADDITIONAL PRINTER",
        "E-INVOICE PRINTER"
    ];

    private readonly ComboBox[] _printerCombos;
    private readonly Button btnChange;
    private readonly Button btnCancel;

    public PrinterInformationForm()
    {
        Text = "Printer Information";
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        Font = new Font("Segoe UI", 9);

        int labelWidth = 180;
        int comboWidth = 220;
        int rowHeight = 30;
        int paddingLeft = 12;
        int paddingTop = 12;
        int gap = 8;

        _printerCombos = new ComboBox[_printerLabels.Length];

        // Get installed printers
        var printers = new List<string> { "<Not Selected>" };
        foreach (string printer in PrinterSettings.InstalledPrinters)
        {
            printers.Add(printer);
        }

        for (int i = 0; i < _printerLabels.Length; i++)
        {
            string automationId = _printerLabels[i].Replace(" ", "_").Replace("(", "").Replace(")", "");

            var label = new Label
            {
                Text = _printerLabels[i],
                Name = $"lbl_{automationId}",
                AccessibleName = _printerLabels[i],
                Location = new Point(paddingLeft, paddingTop + i * rowHeight + 4),
                Size = new Size(labelWidth, 22),
                TextAlign = ContentAlignment.MiddleLeft
            };
            Controls.Add(label);

            var combo = new ComboBox
            {
                Name = $"cmb_{automationId}",
                AccessibleName = _printerLabels[i],
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(paddingLeft + labelWidth + gap, paddingTop + i * rowHeight),
                Size = new Size(comboWidth, 25)
            };
            combo.Items.AddRange(printers.ToArray());
            combo.SelectedIndex = 0;
            Controls.Add(combo);
            _printerCombos[i] = combo;
        }

        LoadSettings();

        int buttonsY = paddingTop + _printerLabels.Length * rowHeight + 16;

        btnChange = new Button
        {
            Text = "Change",
            Name = "btnChange",
            AccessibleName = "Change",
            Size = new Size(100, 32),
            Location = new Point(paddingLeft + labelWidth + gap - 100 - 8, buttonsY)
        };
        btnChange.Click += BtnChange_Click;
        Controls.Add(btnChange);

        btnCancel = new Button
        {
            Text = "Cancel",
            Name = "btnCancel",
            AccessibleName = "Cancel",
            Size = new Size(100, 32),
            Location = new Point(paddingLeft + labelWidth + gap + comboWidth - 100, buttonsY)
        };
        btnCancel.Click += BtnCancel_Click;
        Controls.Add(btnCancel);

        CancelButton = btnCancel;

        ClientSize = new Size(
            paddingLeft + labelWidth + gap + comboWidth + paddingLeft,
            buttonsY + 32 + paddingTop
        );
    }

    private void LoadSettings()
    {
        if (!File.Exists(SettingsFilePath))
            return;

        try
        {
            var json = File.ReadAllText(SettingsFilePath);
            var saved = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            if (saved is null)
                return;

            for (int i = 0; i < _printerLabels.Length; i++)
            {
                if (saved.TryGetValue(_printerLabels[i], out var printerName))
                {
                    int idx = _printerCombos[i].Items.IndexOf(printerName);
                    if (idx >= 0)
                        _printerCombos[i].SelectedIndex = idx;
                }
            }
        }
        catch
        {
            // Ignore corrupted settings file
        }
    }

    private void SaveSettings()
    {
        var settings = new Dictionary<string, string>();
        for (int i = 0; i < _printerLabels.Length; i++)
        {
            settings[_printerLabels[i]] = _printerCombos[i].SelectedItem?.ToString() ?? "<Not Selected>";
        }

        var json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(SettingsFilePath, json);
    }

    private void BtnChange_Click(object? sender, EventArgs e)
    {
        SaveSettings();
        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    public string GetSelectedPrinter(int index)
    {
        if (index < 0 || index >= _printerCombos.Length)
            return "<Not Selected>";
        return _printerCombos[index].SelectedItem?.ToString() ?? "<Not Selected>";
    }
}
