namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculateButton = new System.Windows.Forms.Button();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.R0TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MxLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GAMMAxLabel = new System.Windows.Forms.Label();
            this.DxLabel = new System.Windows.Forms.Label();
            this.uniformRadioButton = new System.Windows.Forms.RadioButton();
            this.DistributionsGroup = new System.Windows.Forms.GroupBox();
            this.simphsonRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.gammaRadioButton = new System.Windows.Forms.RadioButton();
            this.exponentialRadioButton = new System.Windows.Forms.RadioButton();
            this.gaussRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.a1TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sigmaTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lambdaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.DistributionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 93);
            this.chart1.Name = "chart1";
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series3.CustomProperties = "PointWidth=1";
            series3.Legend = "Legend1";
            series3.Name = "Ci";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(827, 634);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(1028, 483);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(183, 63);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // aTextBox
            // 
            this.aTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aTextBox.Location = new System.Drawing.Point(347, 18);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(154, 41);
            this.aTextBox.TabIndex = 2;
            this.aTextBox.Text = "217";
            // 
            // mTextBox
            // 
            this.mTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTextBox.Location = new System.Drawing.Point(111, 18);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(154, 41);
            this.mTextBox.TabIndex = 3;
            this.mTextBox.Text = "311";
            // 
            // R0TextBox
            // 
            this.R0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R0TextBox.Location = new System.Drawing.Point(608, 18);
            this.R0TextBox.Name = "R0TextBox";
            this.R0TextBox.Size = new System.Drawing.Size(154, 41);
            this.R0TextBox.TabIndex = 4;
            this.R0TextBox.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(303, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(553, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "R0";
            // 
            // MxLabel
            // 
            this.MxLabel.AutoSize = true;
            this.MxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MxLabel.Location = new System.Drawing.Point(1202, 571);
            this.MxLabel.Name = "MxLabel";
            this.MxLabel.Size = new System.Drawing.Size(29, 31);
            this.MxLabel.TabIndex = 8;
            this.MxLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(1007, 713);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "GAMMAx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(1007, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(1007, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mx";
            // 
            // GAMMAxLabel
            // 
            this.GAMMAxLabel.AutoSize = true;
            this.GAMMAxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GAMMAxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GAMMAxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GAMMAxLabel.Location = new System.Drawing.Point(1202, 713);
            this.GAMMAxLabel.Name = "GAMMAxLabel";
            this.GAMMAxLabel.Size = new System.Drawing.Size(29, 31);
            this.GAMMAxLabel.TabIndex = 16;
            this.GAMMAxLabel.Text = "0";
            // 
            // DxLabel
            // 
            this.DxLabel.AutoSize = true;
            this.DxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DxLabel.Location = new System.Drawing.Point(1202, 640);
            this.DxLabel.Name = "DxLabel";
            this.DxLabel.Size = new System.Drawing.Size(29, 31);
            this.DxLabel.TabIndex = 17;
            this.DxLabel.Text = "0";
            // 
            // uniformRadioButton
            // 
            this.uniformRadioButton.AutoSize = true;
            this.uniformRadioButton.Location = new System.Drawing.Point(37, 31);
            this.uniformRadioButton.Name = "uniformRadioButton";
            this.uniformRadioButton.Size = new System.Drawing.Size(78, 21);
            this.uniformRadioButton.TabIndex = 19;
            this.uniformRadioButton.TabStop = true;
            this.uniformRadioButton.Text = "Uniform";
            this.uniformRadioButton.UseVisualStyleBackColor = true;
            this.uniformRadioButton.CheckedChanged += new System.EventHandler(this.UniformRadioButton_CheckedChanged);
            // 
            // DistributionsGroup
            // 
            this.DistributionsGroup.Controls.Add(this.simphsonRadioButton);
            this.DistributionsGroup.Controls.Add(this.triangleRadioButton);
            this.DistributionsGroup.Controls.Add(this.gammaRadioButton);
            this.DistributionsGroup.Controls.Add(this.exponentialRadioButton);
            this.DistributionsGroup.Controls.Add(this.gaussRadioButton);
            this.DistributionsGroup.Controls.Add(this.uniformRadioButton);
            this.DistributionsGroup.Location = new System.Drawing.Point(934, 17);
            this.DistributionsGroup.Name = "DistributionsGroup";
            this.DistributionsGroup.Size = new System.Drawing.Size(398, 211);
            this.DistributionsGroup.TabIndex = 20;
            this.DistributionsGroup.TabStop = false;
            this.DistributionsGroup.Text = "Distributions";
            // 
            // simphsonRadioButton
            // 
            this.simphsonRadioButton.AutoSize = true;
            this.simphsonRadioButton.Location = new System.Drawing.Point(37, 170);
            this.simphsonRadioButton.Name = "simphsonRadioButton";
            this.simphsonRadioButton.Size = new System.Drawing.Size(83, 21);
            this.simphsonRadioButton.TabIndex = 24;
            this.simphsonRadioButton.TabStop = true;
            this.simphsonRadioButton.Text = "Simpson";
            this.simphsonRadioButton.UseVisualStyleBackColor = true;
            this.simphsonRadioButton.CheckedChanged += new System.EventHandler(this.SimphsonRadioButton_CheckedChanged);
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.Location = new System.Drawing.Point(37, 143);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(81, 21);
            this.triangleRadioButton.TabIndex = 23;
            this.triangleRadioButton.TabStop = true;
            this.triangleRadioButton.Text = "Triangle";
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            this.triangleRadioButton.CheckedChanged += new System.EventHandler(this.TriangleRadioButton_CheckedChanged);
            // 
            // gammaRadioButton
            // 
            this.gammaRadioButton.AutoSize = true;
            this.gammaRadioButton.Location = new System.Drawing.Point(37, 116);
            this.gammaRadioButton.Name = "gammaRadioButton";
            this.gammaRadioButton.Size = new System.Drawing.Size(78, 21);
            this.gammaRadioButton.TabIndex = 22;
            this.gammaRadioButton.TabStop = true;
            this.gammaRadioButton.Text = "Gamma";
            this.gammaRadioButton.UseVisualStyleBackColor = true;
            this.gammaRadioButton.CheckedChanged += new System.EventHandler(this.GammaRadioButton_CheckedChanged);
            // 
            // exponentialRadioButton
            // 
            this.exponentialRadioButton.AutoSize = true;
            this.exponentialRadioButton.Location = new System.Drawing.Point(37, 87);
            this.exponentialRadioButton.Name = "exponentialRadioButton";
            this.exponentialRadioButton.Size = new System.Drawing.Size(102, 21);
            this.exponentialRadioButton.TabIndex = 21;
            this.exponentialRadioButton.TabStop = true;
            this.exponentialRadioButton.Text = "Exponential";
            this.exponentialRadioButton.UseVisualStyleBackColor = true;
            this.exponentialRadioButton.CheckedChanged += new System.EventHandler(this.ExponentialRadioButton_CheckedChanged);
            // 
            // gaussRadioButton
            // 
            this.gaussRadioButton.AutoSize = true;
            this.gaussRadioButton.Location = new System.Drawing.Point(37, 58);
            this.gaussRadioButton.Name = "gaussRadioButton";
            this.gaussRadioButton.Size = new System.Drawing.Size(70, 21);
            this.gaussRadioButton.TabIndex = 20;
            this.gaussRadioButton.TabStop = true;
            this.gaussRadioButton.Text = "Gauss";
            this.gaussRadioButton.UseVisualStyleBackColor = true;
            this.gaussRadioButton.CheckedChanged += new System.EventHandler(this.GaussRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(924, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "a";
            // 
            // a1TextBox
            // 
            this.a1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1TextBox.Location = new System.Drawing.Point(976, 256);
            this.a1TextBox.Name = "a1TextBox";
            this.a1TextBox.Size = new System.Drawing.Size(154, 41);
            this.a1TextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(917, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "m";
            // 
            // m1TextBox
            // 
            this.m1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m1TextBox.Location = new System.Drawing.Point(976, 316);
            this.m1TextBox.Name = "m1TextBox";
            this.m1TextBox.Size = new System.Drawing.Size(154, 41);
            this.m1TextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(1156, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "b";
            // 
            // bTextBox
            // 
            this.bTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTextBox.Location = new System.Drawing.Point(1228, 256);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(154, 41);
            this.bTextBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(1136, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 31);
            this.label10.TabIndex = 28;
            this.label10.Text = "sigma";
            // 
            // sigmaTextBox
            // 
            this.sigmaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sigmaTextBox.Location = new System.Drawing.Point(1228, 316);
            this.sigmaTextBox.Name = "sigmaTextBox";
            this.sigmaTextBox.Size = new System.Drawing.Size(154, 41);
            this.sigmaTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(1159, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 31);
            this.label11.TabIndex = 32;
            this.label11.Text = "n";
            // 
            // nTextBox
            // 
            this.nTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTextBox.Location = new System.Drawing.Point(1228, 378);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(154, 41);
            this.nTextBox.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(868, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 31);
            this.label12.TabIndex = 30;
            this.label12.Text = "lambda";
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lambdaTextBox.Location = new System.Drawing.Point(976, 378);
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.Size = new System.Drawing.Size(154, 41);
            this.lambdaTextBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1394, 765);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lambdaTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sigmaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.a1TextBox);
            this.Controls.Add(this.DistributionsGroup);
            this.Controls.Add(this.DxLabel);
            this.Controls.Add(this.GAMMAxLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R0TextBox);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.DistributionsGroup.ResumeLayout(false);
            this.DistributionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox R0TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MxLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GAMMAxLabel;
        private System.Windows.Forms.Label DxLabel;
        private System.Windows.Forms.RadioButton uniformRadioButton;
        private System.Windows.Forms.GroupBox DistributionsGroup;
        private System.Windows.Forms.RadioButton simphsonRadioButton;
        private System.Windows.Forms.RadioButton triangleRadioButton;
        private System.Windows.Forms.RadioButton gammaRadioButton;
        private System.Windows.Forms.RadioButton exponentialRadioButton;
        private System.Windows.Forms.RadioButton gaussRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a1TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sigmaTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lambdaTextBox;
    }
}

