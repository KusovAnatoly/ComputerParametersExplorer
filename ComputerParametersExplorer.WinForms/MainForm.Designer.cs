namespace ComputerParametersExplorer.WinForms;

partial class MainForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonClose = new System.Windows.Forms.Button();
        buttonCopy = new System.Windows.Forms.Button();
        buttonRefresh = new System.Windows.Forms.Button();
        labelInfo = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // buttonClose
        // 
        buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        buttonClose.Location = new System.Drawing.Point(693, 420);
        buttonClose.Name = "buttonClose";
        buttonClose.Size = new System.Drawing.Size(100, 23);
        buttonClose.TabIndex = 0;
        buttonClose.Text = "Закрыть";
        buttonClose.UseVisualStyleBackColor = true;
        buttonClose.Click += buttonClose_Click;
        // 
        // buttonCopy
        // 
        buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        buttonCopy.Location = new System.Drawing.Point(604, 420);
        buttonCopy.Name = "buttonCopy";
        buttonCopy.Size = new System.Drawing.Size(83, 23);
        buttonCopy.TabIndex = 1;
        buttonCopy.Text = "Копировать";
        buttonCopy.UseVisualStyleBackColor = true;
        buttonCopy.Click += buttonCopy_Click;
        // 
        // buttonRefresh
        // 
        buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        buttonRefresh.Location = new System.Drawing.Point(498, 420);
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Size = new System.Drawing.Size(100, 23);
        buttonRefresh.TabIndex = 2;
        buttonRefresh.Text = "Обновить";
        buttonRefresh.UseVisualStyleBackColor = true;
        buttonRefresh.Click += buttonRefresh_Click;
        // 
        // labelInfo
        // 
        labelInfo.AutoSize = true;
        labelInfo.Location = new System.Drawing.Point(12, 9);
        labelInfo.Name = "labelInfo";
        labelInfo.Size = new System.Drawing.Size(0, 15);
        labelInfo.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(labelInfo);
        Controls.Add(buttonRefresh);
        Controls.Add(buttonCopy);
        Controls.Add(buttonClose);
        MinimumSize = new System.Drawing.Size(720, 480);
        Text = "Инспектор параметров компьютера";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Button buttonCopy;
    private System.Windows.Forms.Button buttonRefresh;

    #endregion

    private Label labelInfo;
}