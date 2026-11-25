namespace KalkulatorRoztworu;

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
        labelVessel = new Label();
        comboBoxVessel = new ComboBox();
        labelSolution = new Label();
        comboBoxSolution = new ComboBox();
        labelCapacity = new Label();
        textBoxCapacity = new TextBox();
        labelPercent = new Label();
        textBoxPercent = new TextBox();
        labelCount = new Label();
        textBoxCount = new TextBox();
        buttonCalculate = new Button();
        labelTotalVolume = new Label();
        labelPureSubstance = new Label();
        SuspendLayout();
        // 
        // labelVessel
        // 
        labelVessel.AutoSize = true;
        labelVessel.Location = new Point(20, 23);
        labelVessel.Name = "labelVessel";
        labelVessel.TabIndex = 0;
        labelVessel.Text = "Typowe naczynie:";
        // 
        // comboBoxVessel
        // 
        comboBoxVessel.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxVessel.Location = new Point(220, 20);
        comboBoxVessel.Name = "comboBoxVessel";
        comboBoxVessel.Size = new Size(160, 23);
        comboBoxVessel.TabIndex = 1;
        // 
        // labelSolution
        // 
        labelSolution.AutoSize = true;
        labelSolution.Location = new Point(20, 58);
        labelSolution.Name = "labelSolution";
        labelSolution.TabIndex = 2;
        labelSolution.Text = "Typowy roztwór:";
        // 
        // comboBoxSolution
        // 
        comboBoxSolution.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxSolution.Location = new Point(220, 55);
        comboBoxSolution.Name = "comboBoxSolution";
        comboBoxSolution.Size = new Size(160, 23);
        comboBoxSolution.TabIndex = 3;
        // 
        // labelCapacity
        // 
        labelCapacity.AutoSize = true;
        labelCapacity.Location = new Point(20, 93);
        labelCapacity.Name = "labelCapacity";
        labelCapacity.TabIndex = 4;
        labelCapacity.Text = "Pojemność naczynia [ml]:";
        // 
        // textBoxCapacity
        // 
        textBoxCapacity.Location = new Point(220, 90);
        textBoxCapacity.Name = "textBoxCapacity";
        textBoxCapacity.Size = new Size(160, 23);
        textBoxCapacity.TabIndex = 5;
        // 
        // labelPercent
        // 
        labelPercent.AutoSize = true;
        labelPercent.Location = new Point(20, 128);
        labelPercent.Name = "labelPercent";
        labelPercent.TabIndex = 6;
        labelPercent.Text = "Zawartość substancji [%]:";
        // 
        // textBoxPercent
        // 
        textBoxPercent.Location = new Point(220, 125);
        textBoxPercent.Name = "textBoxPercent";
        textBoxPercent.Size = new Size(160, 23);
        textBoxPercent.TabIndex = 7;
        // 
        // labelCount
        // 
        labelCount.AutoSize = true;
        labelCount.Location = new Point(20, 163);
        labelCount.Name = "labelCount";
        labelCount.TabIndex = 8;
        labelCount.Text = "Liczba naczyń [szt.]:";
        // 
        // textBoxCount
        // 
        textBoxCount.Location = new Point(220, 160);
        textBoxCount.Name = "textBoxCount";
        textBoxCount.Size = new Size(160, 23);
        textBoxCount.TabIndex = 9;
        // 
        // buttonCalculate
        // 
        buttonCalculate.Location = new Point(220, 198);
        buttonCalculate.Name = "buttonCalculate";
        buttonCalculate.Size = new Size(160, 30);
        buttonCalculate.TabIndex = 10;
        buttonCalculate.Text = "Oblicz";
        buttonCalculate.UseVisualStyleBackColor = true;
        // 
        // labelTotalVolume
        // 
        labelTotalVolume.AutoSize = true;
        labelTotalVolume.Location = new Point(20, 248);
        labelTotalVolume.Name = "labelTotalVolume";
        labelTotalVolume.TabIndex = 11;
        labelTotalVolume.Text = "Łączna objętość płynu: –";
        // 
        // labelPureSubstance
        // 
        labelPureSubstance.AutoSize = true;
        labelPureSubstance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        labelPureSubstance.Location = new Point(20, 278);
        labelPureSubstance.Name = "labelPureSubstance";
        labelPureSubstance.TabIndex = 12;
        labelPureSubstance.Text = "Objętość czystej substancji: –";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 318);
        Controls.Add(labelVessel);
        Controls.Add(comboBoxVessel);
        Controls.Add(labelSolution);
        Controls.Add(comboBoxSolution);
        Controls.Add(labelCapacity);
        Controls.Add(textBoxCapacity);
        Controls.Add(labelPercent);
        Controls.Add(textBoxPercent);
        Controls.Add(labelCount);
        Controls.Add(textBoxCount);
        Controls.Add(buttonCalculate);
        Controls.Add(labelTotalVolume);
        Controls.Add(labelPureSubstance);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Kalkulator roztworu";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelVessel;
    private ComboBox comboBoxVessel;
    private Label labelSolution;
    private ComboBox comboBoxSolution;
    private Label labelCapacity;
    private TextBox textBoxCapacity;
    private Label labelPercent;
    private TextBox textBoxPercent;
    private Label labelCount;
    private TextBox textBoxCount;
    private Button buttonCalculate;
    private Label labelTotalVolume;
    private Label labelPureSubstance;
}
