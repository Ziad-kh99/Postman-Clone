namespace PostmanCloneUI;

partial class Dashboard
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
        apiCallBtn = new Button();
        formHeader = new Label();
        apiURLLabel = new Label();
        apiResponseLabel = new Label();
        apiURLText = new TextBox();
        apiResponseText = new TextBox();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // apiCallBtn
        // 
        apiCallBtn.Location = new Point(774, 144);
        apiCallBtn.Name = "apiCallBtn";
        apiCallBtn.Size = new Size(75, 31);
        apiCallBtn.TabIndex = 0;
        apiCallBtn.Text = "Go";
        apiCallBtn.UseVisualStyleBackColor = true;
        apiCallBtn.Click += apiCallBtn_Click;
        // 
        // formHeader
        // 
        formHeader.AutoSize = true;
        formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        formHeader.Location = new Point(297, 36);
        formHeader.Name = "formHeader";
        formHeader.Size = new Size(335, 60);
        formHeader.TabIndex = 1;
        formHeader.Text = "Postman Clone";
        // 
        // apiURLLabel
        // 
        apiURLLabel.AutoSize = true;
        apiURLLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        apiURLLabel.Location = new Point(30, 145);
        apiURLLabel.Name = "apiURLLabel";
        apiURLLabel.Size = new Size(100, 31);
        apiURLLabel.TabIndex = 2;
        apiURLLabel.Text = "API URL:";
        // 
        // apiResponseLabel
        // 
        apiResponseLabel.AutoSize = true;
        apiResponseLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        apiResponseLabel.Location = new Point(30, 219);
        apiResponseLabel.Name = "apiResponseLabel";
        apiResponseLabel.Size = new Size(111, 31);
        apiResponseLabel.TabIndex = 3;
        apiResponseLabel.Text = "Response";
        // 
        // apiURLText
        // 
        apiURLText.BorderStyle = BorderStyle.FixedSingle;
        apiURLText.Location = new Point(136, 146);
        apiURLText.Name = "apiURLText";
        apiURLText.Size = new Size(617, 30);
        apiURLText.TabIndex = 4;
        // 
        // apiResponseText
        // 
        apiResponseText.BorderStyle = BorderStyle.FixedSingle;
        apiResponseText.Location = new Point(30, 263);
        apiResponseText.Multiline = true;
        apiResponseText.Name = "apiResponseText";
        apiResponseText.ReadOnly = true;
        apiResponseText.ScrollBars = ScrollBars.Both;
        apiResponseText.Size = new Size(819, 194);
        apiResponseText.TabIndex = 5;
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new Size(20, 20);
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 483);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(900, 34);
        statusStrip.TabIndex = 6;
        statusStrip.Text = " ";
        //statusStrip.ForeColor = Color.White;
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(65, 28);
        systemStatus.Text = "Ready";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(900, 517);
        Controls.Add(statusStrip);
        Controls.Add(apiResponseText);
        Controls.Add(apiURLText);
        Controls.Add(apiResponseLabel);
        Controls.Add(apiURLLabel);
        Controls.Add(formHeader);
        Controls.Add(apiCallBtn);
        Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Dashboard";
        Text = "Postman Dashboard";
        Load += Dashboard_Load;
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button apiCallBtn;
    private Label formHeader;
    private Label apiURLLabel;
    private Label apiResponseLabel;
    private TextBox apiURLText;
    private TextBox apiResponseText;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
}
