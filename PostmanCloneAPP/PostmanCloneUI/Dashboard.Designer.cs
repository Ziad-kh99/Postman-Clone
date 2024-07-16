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
        apiURLText = new TextBox();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        httpVerbSelection = new ComboBox();
        callData = new TabControl();
        bodyTab = new TabPage();
        apiBodyText = new TextBox();
        responseTab = new TabPage();
        apiResponseText = new TextBox();
        statusStrip.SuspendLayout();
        callData.SuspendLayout();
        bodyTab.SuspendLayout();
        responseTab.SuspendLayout();
        SuspendLayout();
        // 
        // apiCallBtn
        // 
        apiCallBtn.Location = new Point(791, 145);
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
        apiURLLabel.Size = new Size(53, 31);
        apiURLLabel.TabIndex = 2;
        apiURLLabel.Text = "API:";
        // 
        // apiURLText
        // 
        apiURLText.BorderStyle = BorderStyle.FixedSingle;
        apiURLText.Location = new Point(190, 144);
        apiURLText.Name = "apiURLText";
        apiURLText.Size = new Size(595, 30);
        apiURLText.TabIndex = 4;
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
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(65, 28);
        systemStatus.Text = "Ready";
        // 
        // httpVerbSelection
        // 
        httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
        httpVerbSelection.FormattingEnabled = true;
        httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
        httpVerbSelection.Location = new Point(79, 143);
        httpVerbSelection.Name = "httpVerbSelection";
        httpVerbSelection.Size = new Size(105, 31);
        httpVerbSelection.TabIndex = 7;
        // 
        // callData
        // 
        callData.Controls.Add(bodyTab);
        callData.Controls.Add(responseTab);
        callData.Location = new Point(30, 195);
        callData.Name = "callData";
        callData.SelectedIndex = 0;
        callData.Size = new Size(836, 285);
        callData.TabIndex = 8;
        // 
        // bodyTab
        // 
        bodyTab.Controls.Add(apiBodyText);
        bodyTab.Location = new Point(4, 32);
        bodyTab.Name = "bodyTab";
        bodyTab.Padding = new Padding(3);
        bodyTab.Size = new Size(828, 249);
        bodyTab.TabIndex = 0;
        bodyTab.Text = "Body";
        bodyTab.UseVisualStyleBackColor = true;
        // 
        // apiBodyText
        // 
        apiBodyText.BorderStyle = BorderStyle.FixedSingle;
        apiBodyText.Dock = DockStyle.Fill;
        apiBodyText.Location = new Point(3, 3);
        apiBodyText.Multiline = true;
        apiBodyText.Name = "apiBodyText";
        apiBodyText.ScrollBars = ScrollBars.Both;
        apiBodyText.Size = new Size(822, 243);
        apiBodyText.TabIndex = 6;
        // 
        // responseTab
        // 
        responseTab.Controls.Add(apiResponseText);
        responseTab.Location = new Point(4, 32);
        responseTab.Name = "responseTab";
        responseTab.Padding = new Padding(3);
        responseTab.Size = new Size(828, 249);
        responseTab.TabIndex = 1;
        responseTab.Text = "Response";
        responseTab.UseVisualStyleBackColor = true;
        // 
        // apiResponseText
        // 
        apiResponseText.BorderStyle = BorderStyle.FixedSingle;
        apiResponseText.Dock = DockStyle.Fill;
        apiResponseText.Location = new Point(3, 3);
        apiResponseText.Multiline = true;
        apiResponseText.Name = "apiResponseText";
        apiResponseText.ReadOnly = true;
        apiResponseText.ScrollBars = ScrollBars.Both;
        apiResponseText.Size = new Size(822, 243);
        apiResponseText.TabIndex = 6;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(900, 517);
        Controls.Add(callData);
        Controls.Add(httpVerbSelection);
        Controls.Add(statusStrip);
        Controls.Add(apiURLText);
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
        callData.ResumeLayout(false);
        bodyTab.ResumeLayout(false);
        bodyTab.PerformLayout();
        responseTab.ResumeLayout(false);
        responseTab.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button apiCallBtn;
    private Label formHeader;
    private Label apiURLLabel;
    private TextBox apiURLText;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
    private ComboBox httpVerbSelection;
    private TabControl callData;
    private TabPage bodyTab;
    private TabPage responseTab;
    private TextBox apiResponseText;
    private TextBox apiBodyText;
}
