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
        // labelCapacity
        // 
        labelCapacity.AutoSize = true;
        labelCapacity.Location = new Point(20, 23);
        labelCapacity.Name = "labelCapacity";
        labelCapacity.TabIndex = 0;
        labelCapacity.Text = "Pojemność naczynia [ml]:";
        // 
        // textBoxCapacity
        // 
        textBoxCapacity.Location = new Point(220, 20);
        textBoxCapacity.Name = "textBoxCapacity";
        textBoxCapacity.Size = new Size(160, 23);
        textBoxCapacity.TabIndex = 1;
        // 
        // labelPercent
        // 
        labelPercent.AutoSize = true;
        labelPercent.Location = new Point(20, 58);
        labelPercent.Name = "labelPercent";
        labelPercent.TabIndex = 2;
        labelPercent.Text = "Zawartość substancji [%]:";
        // 
        // textBoxPercent
        // 
        textBoxPercent.Location = new Point(220, 55);
        textBoxPercent.Name = "textBoxPercent";
        textBoxPercent.Size = new Size(160, 23);
        textBoxPercent.TabIndex = 3;
        // 
        // labelCount
        // 
        labelCount.AutoSize = true;
        labelCount.Location = new Point(20, 93);
        labelCount.Name = "labelCount";
        labelCount.TabIndex = 4;
        labelCount.Text = "Liczba naczyń [szt.]:";
        // 
        // textBoxCount
        // 
        textBoxCount.Location = new Point(220, 90);
        textBoxCount.Name = "textBoxCount";
        textBoxCount.Size = new Size(160, 23);
        textBoxCount.TabIndex = 5;
        // 
        // buttonCalculate
        // 
        buttonCalculate.Location = new Point(220, 128);
        buttonCalculate.Name = "buttonCalculate";
        buttonCalculate.Size = new Size(160, 30);
        buttonCalculate.TabIndex = 6;
        buttonCalculate.Text = "Oblicz";
        buttonCalculate.UseVisualStyleBackColor = true;
        // 
        // labelTotalVolume
        // 
        labelTotalVolume.AutoSize = true;
        labelTotalVolume.Location = new Point(20, 178);
        labelTotalVolume.Name = "labelTotalVolume";
        labelTotalVolume.TabIndex = 7;
        labelTotalVolume.Text = "Łączna objętość płynu: –";
        // 
        // labelPureSubstance
        // 
        labelPureSubstance.AutoSize = true;
        labelPureSubstance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        labelPureSubstance.Location = new Point(20, 208);
        labelPureSubstance.Name = "labelPureSubstance";
        labelPureSubstance.TabIndex = 8;
        labelPureSubstance.Text = "Objętość czystej substancji: –";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 248);
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
