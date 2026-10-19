namespace WinFormsApp;

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
        btn = new Button();
        checkBox1 = new CheckBox();
        comboBox1 = new ComboBox();
        listView1 = new ListView();
        panel1 = new Panel();
        SuspendLayout();
        // 
        // btn
        // 
        btn.Location = new Point(204, 166);
        btn.Name = "btn";
        btn.Size = new Size(337, 117);
        btn.TabIndex = 0;
        btn.Text = "Click Me!";
        btn.UseVisualStyleBackColor = true;
        btn.Click += button1_Click;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(102, 57);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(82, 19);
        checkBox1.TabIndex = 1;
        checkBox1.Text = "checkBox1";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(347, 43);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 2;
        // 
        // listView1
        // 
        listView1.Location = new Point(589, 152);
        listView1.Name = "listView1";
        listView1.Size = new Size(121, 97);
        listView1.TabIndex = 3;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // panel1
        // 
        panel1.Location = new Point(34, 308);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 100);
        panel1.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Controls.Add(listView1);
        Controls.Add(comboBox1);
        Controls.Add(checkBox1);
        Controls.Add(btn);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private ListView listView1;
    private Panel panel1;
}
