namespace ConverterUI
{
    partial class Converter
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlConverter = new System.Windows.Forms.TabControl();
            this.tabPageCurrencies = new System.Windows.Forms.TabPage();
            this.buttonCurrencies = new System.Windows.Forms.Button();
            this.dataGridViewCurrencies = new System.Windows.Forms.DataGridView();
            this.tabPageRates = new System.Windows.Forms.TabPage();
            this.groupBoxConverter = new System.Windows.Forms.GroupBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonConvCancel = new System.Windows.Forms.Button();
            this.comboBoxCurrencyTo = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonRates = new System.Windows.Forms.Button();
            this.dataGridViewRates = new System.Windows.Forms.DataGridView();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.groupBoxGraph = new System.Windows.Forms.GroupBox();
            this.buttonDrawGraph = new System.Windows.Forms.Button();
            this.buttonGraphCancel = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.chartCurRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rateShortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlConverter.SuspendLayout();
            this.tabPageCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrencies)).BeginInit();
            this.tabPageRates.SuspendLayout();
            this.groupBoxConverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).BeginInit();
            this.tabPageGraph.SuspendLayout();
            this.groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateShortBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlConverter
            // 
            this.tabControlConverter.Controls.Add(this.tabPageCurrencies);
            this.tabControlConverter.Controls.Add(this.tabPageRates);
            this.tabControlConverter.Controls.Add(this.tabPageGraph);
            this.tabControlConverter.Location = new System.Drawing.Point(12, 0);
            this.tabControlConverter.Name = "tabControlConverter";
            this.tabControlConverter.SelectedIndex = 0;
            this.tabControlConverter.Size = new System.Drawing.Size(1015, 581);
            this.tabControlConverter.TabIndex = 0;
            // 
            // tabPageCurrencies
            // 
            this.tabPageCurrencies.Controls.Add(this.buttonCurrencies);
            this.tabPageCurrencies.Controls.Add(this.dataGridViewCurrencies);
            this.tabPageCurrencies.Location = new System.Drawing.Point(4, 33);
            this.tabPageCurrencies.Name = "tabPageCurrencies";
            this.tabPageCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrencies.Size = new System.Drawing.Size(1007, 544);
            this.tabPageCurrencies.TabIndex = 0;
            this.tabPageCurrencies.Text = "Currencies";
            this.tabPageCurrencies.UseVisualStyleBackColor = true;
            // 
            // buttonCurrencies
            // 
            this.buttonCurrencies.Location = new System.Drawing.Point(798, 502);
            this.buttonCurrencies.Name = "buttonCurrencies";
            this.buttonCurrencies.Size = new System.Drawing.Size(203, 36);
            this.buttonCurrencies.TabIndex = 1;
            this.buttonCurrencies.Text = "Show currencies";
            this.buttonCurrencies.UseVisualStyleBackColor = true;
            this.buttonCurrencies.Click += new System.EventHandler(this.buttonCurrencies_Click);
            // 
            // dataGridViewCurrencies
            // 
            this.dataGridViewCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCurrencies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCurrencies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrencies.Location = new System.Drawing.Point(6, 8);
            this.dataGridViewCurrencies.Name = "dataGridViewCurrencies";
            this.dataGridViewCurrencies.Size = new System.Drawing.Size(995, 488);
            this.dataGridViewCurrencies.TabIndex = 0;
            // 
            // tabPageRates
            // 
            this.tabPageRates.Controls.Add(this.groupBoxConverter);
            this.tabPageRates.Controls.Add(this.buttonRates);
            this.tabPageRates.Controls.Add(this.dataGridViewRates);
            this.tabPageRates.Location = new System.Drawing.Point(4, 33);
            this.tabPageRates.Name = "tabPageRates";
            this.tabPageRates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRates.Size = new System.Drawing.Size(1007, 544);
            this.tabPageRates.TabIndex = 1;
            this.tabPageRates.Text = "Rates";
            this.tabPageRates.UseVisualStyleBackColor = true;
            // 
            // groupBoxConverter
            // 
            this.groupBoxConverter.Controls.Add(this.buttonConvert);
            this.groupBoxConverter.Controls.Add(this.buttonConvCancel);
            this.groupBoxConverter.Controls.Add(this.comboBoxCurrencyTo);
            this.groupBoxConverter.Controls.Add(this.comboBoxCurrencyFrom);
            this.groupBoxConverter.Controls.Add(this.textBoxResult);
            this.groupBoxConverter.Controls.Add(this.textBoxValue);
            this.groupBoxConverter.Location = new System.Drawing.Point(688, 6);
            this.groupBoxConverter.Name = "groupBoxConverter";
            this.groupBoxConverter.Size = new System.Drawing.Size(313, 532);
            this.groupBoxConverter.TabIndex = 2;
            this.groupBoxConverter.TabStop = false;
            this.groupBoxConverter.Text = "Converter";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(6, 438);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(301, 41);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonConvCancel
            // 
            this.buttonConvCancel.Location = new System.Drawing.Point(6, 485);
            this.buttonConvCancel.Name = "buttonConvCancel";
            this.buttonConvCancel.Size = new System.Drawing.Size(301, 41);
            this.buttonConvCancel.TabIndex = 2;
            this.buttonConvCancel.Text = "Cancel";
            this.buttonConvCancel.UseVisualStyleBackColor = true;
            this.buttonConvCancel.Click += new System.EventHandler(this.buttonConvCancel_Click);
            // 
            // comboBoxCurrencyTo
            // 
            this.comboBoxCurrencyTo.DropDownHeight = 150;
            this.comboBoxCurrencyTo.FormattingEnabled = true;
            this.comboBoxCurrencyTo.IntegralHeight = false;
            this.comboBoxCurrencyTo.Location = new System.Drawing.Point(6, 209);
            this.comboBoxCurrencyTo.Name = "comboBoxCurrencyTo";
            this.comboBoxCurrencyTo.Size = new System.Drawing.Size(301, 32);
            this.comboBoxCurrencyTo.TabIndex = 1;
            this.comboBoxCurrencyTo.Text = "BYN(Белорусский рубль)";
            // 
            // comboBoxCurrencyFrom
            // 
            this.comboBoxCurrencyFrom.DropDownHeight = 150;
            this.comboBoxCurrencyFrom.FormattingEnabled = true;
            this.comboBoxCurrencyFrom.IntegralHeight = false;
            this.comboBoxCurrencyFrom.Location = new System.Drawing.Point(6, 133);
            this.comboBoxCurrencyFrom.Name = "comboBoxCurrencyFrom";
            this.comboBoxCurrencyFrom.Size = new System.Drawing.Size(301, 32);
            this.comboBoxCurrencyFrom.TabIndex = 1;
            this.comboBoxCurrencyFrom.Text = "BYN(Белорусский рубль)";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 284);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(301, 29);
            this.textBoxResult.TabIndex = 0;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(6, 57);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(301, 29);
            this.textBoxValue.TabIndex = 0;
            // 
            // buttonRates
            // 
            this.buttonRates.Location = new System.Drawing.Point(520, 491);
            this.buttonRates.Name = "buttonRates";
            this.buttonRates.Size = new System.Drawing.Size(162, 47);
            this.buttonRates.TabIndex = 1;
            this.buttonRates.Text = "Show Rates";
            this.buttonRates.UseVisualStyleBackColor = true;
            this.buttonRates.Click += new System.EventHandler(this.buttonRates_Click);
            // 
            // dataGridViewRates
            // 
            this.dataGridViewRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewRates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewRates.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRates.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewRates.Name = "dataGridViewRates";
            this.dataGridViewRates.Size = new System.Drawing.Size(676, 479);
            this.dataGridViewRates.TabIndex = 0;
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.groupBoxGraph);
            this.tabPageGraph.Controls.Add(this.chartCurRate);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 33);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(1007, 544);
            this.tabPageGraph.TabIndex = 2;
            this.tabPageGraph.Text = "Graph";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // groupBoxGraph
            // 
            this.groupBoxGraph.Controls.Add(this.buttonDrawGraph);
            this.groupBoxGraph.Controls.Add(this.buttonGraphCancel);
            this.groupBoxGraph.Controls.Add(this.dateTimePickerTo);
            this.groupBoxGraph.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxGraph.Controls.Add(this.comboBoxCurrency);
            this.groupBoxGraph.Location = new System.Drawing.Point(691, 8);
            this.groupBoxGraph.Name = "groupBoxGraph";
            this.groupBoxGraph.Size = new System.Drawing.Size(310, 530);
            this.groupBoxGraph.TabIndex = 1;
            this.groupBoxGraph.TabStop = false;
            this.groupBoxGraph.Text = "Graph";
            // 
            // buttonDrawGraph
            // 
            this.buttonDrawGraph.Location = new System.Drawing.Point(6, 438);
            this.buttonDrawGraph.Name = "buttonDrawGraph";
            this.buttonDrawGraph.Size = new System.Drawing.Size(298, 40);
            this.buttonDrawGraph.TabIndex = 2;
            this.buttonDrawGraph.Text = "Draw";
            this.buttonDrawGraph.UseVisualStyleBackColor = true;
            this.buttonDrawGraph.Click += new System.EventHandler(this.buttonDrawGraph_Click);
            // 
            // buttonGraphCancel
            // 
            this.buttonGraphCancel.Location = new System.Drawing.Point(6, 484);
            this.buttonGraphCancel.Name = "buttonGraphCancel";
            this.buttonGraphCancel.Size = new System.Drawing.Size(298, 40);
            this.buttonGraphCancel.TabIndex = 2;
            this.buttonGraphCancel.Text = "Cancel";
            this.buttonGraphCancel.UseVisualStyleBackColor = true;
            this.buttonGraphCancel.Click += new System.EventHandler(this.buttonGraphCancel_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(6, 205);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(298, 29);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(6, 138);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(298, 29);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownHeight = 150;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.IntegralHeight = false;
            this.comboBoxCurrency.Location = new System.Drawing.Point(6, 67);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(298, 32);
            this.comboBoxCurrency.TabIndex = 0;
            // 
            // chartCurRate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCurRate.ChartAreas.Add(chartArea1);
            legend1.Name = "Currency Rate";
            legend1.Title = "Currency Rate";
            this.chartCurRate.Legends.Add(legend1);
            this.chartCurRate.Location = new System.Drawing.Point(6, 8);
            this.chartCurRate.Name = "chartCurRate";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Currency Rate";
            series1.Name = "Rate";
            series1.XValueMember = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "Cur_OfficialRate";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartCurRate.Series.Add(series1);
            this.chartCurRate.Size = new System.Drawing.Size(679, 530);
            this.chartCurRate.TabIndex = 0;
            this.chartCurRate.Text = "ChartCurRate";
            // 
            // rateShortBindingSource
            // 
            this.rateShortBindingSource.DataSource = typeof(core_lab2.entity.RateShort);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 592);
            this.Controls.Add(this.tabControlConverter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.tabControlConverter.ResumeLayout(false);
            this.tabPageCurrencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrencies)).EndInit();
            this.tabPageRates.ResumeLayout(false);
            this.groupBoxConverter.ResumeLayout(false);
            this.groupBoxConverter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).EndInit();
            this.tabPageGraph.ResumeLayout(false);
            this.groupBoxGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCurRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateShortBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConverter;
        private System.Windows.Forms.TabPage tabPageCurrencies;
        private System.Windows.Forms.TabPage tabPageRates;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.Button buttonCurrencies;
        private System.Windows.Forms.DataGridView dataGridViewCurrencies;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBoxConverter;
        private System.Windows.Forms.Button buttonRates;
        private System.Windows.Forms.DataGridView dataGridViewRates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurRate;
        private System.Windows.Forms.GroupBox groupBoxGraph;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonDrawGraph;
        private System.Windows.Forms.Button buttonGraphCancel;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonConvCancel;
        private System.Windows.Forms.ComboBox comboBoxCurrencyTo;
        private System.Windows.Forms.ComboBox comboBoxCurrencyFrom;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.BindingSource rateShortBindingSource;
    }
}

