using System;
using System.Windows.Forms;

public partial class InputBoxForm : Form
{
    public string InputValue { get; private set; }

    public InputBoxForm(string prompt)
    {
        InitializeComponent();
        lblPrompt.Text = prompt;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        InputValue = txtInput.Text;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void exit_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
