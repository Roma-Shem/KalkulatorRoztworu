using KalkulatorRoztworu.Logic;

namespace KalkulatorRoztworu;

public partial class Form1 : Form
{
    // GUI korzysta z logiki, ale sama logika nic nie wie o formularzu
    private readonly SolutionCalculator calculator = new();

    public Form1()
    {
        InitializeComponent();
        buttonCalculate.Click += buttonCalculate_Click;
    }

    private void buttonCalculate_Click(object? sender, EventArgs e)
    {
        // Logika sama czyta tekst z pól, sprawdza go i liczy.
        // Złe dane -> ArgumentException z gotowym komunikatem, GUI tylko go pokazuje
        try
        {
            var result = calculator.Calculate(textBoxCapacity.Text, textBoxPercent.Text, textBoxCount.Text);
            labelTotalVolume.Text = $"Łączna objętość płynu: {result.TotalVolumeMl:0.##} ml";
            labelPureSubstance.Text = $"Objętość czystej substancji: {result.PureSubstanceMl:0.##} ml";
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Błędne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
