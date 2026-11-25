using System.Globalization;
using KalkulatorRoztworu.Logic;

namespace KalkulatorRoztworu;

public partial class Form1 : Form
{
    // GUI korzysta z logiki, ale sama logika nic nie wie o formularzu
    private readonly SolutionCalculator calculator = new();

    public Form1()
    {
        InitializeComponent();

        // Lista typowych naczyń pochodzi z logiki
        comboBoxVessel.DisplayMember = nameof(VesselPreset.Name);
        comboBoxVessel.Items.AddRange(SolutionCalculator.TypicalVessels.ToArray());
        comboBoxVessel.SelectedIndexChanged += comboBoxVessel_SelectedIndexChanged;

        // Lista typowych roztworów też pochodzi z logiki
        comboBoxSolution.DisplayMember = nameof(SolutionPreset.Name);
        comboBoxSolution.Items.AddRange(SolutionCalculator.TypicalSolutions.ToArray());
        comboBoxSolution.SelectedIndexChanged += comboBoxSolution_SelectedIndexChanged;

        buttonCalculate.Click += buttonCalculate_Click;

        AcceptButton = buttonCalculate;   // Enter = "Oblicz"
        ActiveControl = textBoxCapacity;   // po starcie kursor od razu w pierwszym polu do wpisania
    }

    // Wybór naczynia z listy wpisuje jego pojemność do pola
    private void comboBoxVessel_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (comboBoxVessel.SelectedItem is VesselPreset vessel)
        {
            textBoxCapacity.Text = vessel.CapacityMl.ToString(CultureInfo.CurrentCulture);
        }
    }

    // Wybór roztworu z listy wpisuje jego procent do pola
    private void comboBoxSolution_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (comboBoxSolution.SelectedItem is SolutionPreset solution)
        {
            textBoxPercent.Text = solution.SubstancePercent.ToString(CultureInfo.CurrentCulture);
        }
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
