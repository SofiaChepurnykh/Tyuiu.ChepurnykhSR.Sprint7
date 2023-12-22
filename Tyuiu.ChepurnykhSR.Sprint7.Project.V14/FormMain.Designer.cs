
namespace Tyuiu.ChepurnykhSR.Sprint7.Project.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_CSR = new System.Windows.Forms.Panel();
            this.Name_CSR = new System.Windows.Forms.Label();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.buttonDelete_CSR = new System.Windows.Forms.Button();
            this.buttonAdd_CSR = new System.Windows.Forms.Button();
            this.buttonSave_CSR = new System.Windows.Forms.Button();
            this.buttonOpen_CSR = new System.Windows.Forms.Button();
            this.panelFill_CSR = new System.Windows.Forms.Panel();
            this.dataGridView_CSR = new System.Windows.Forms.DataGridView();
            this.Number_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stsrt_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Km_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stop_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_CSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_CSR = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_CSR = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxBus_CSR = new System.Windows.Forms.GroupBox();
            this.comboBoxBus_CSR = new System.Windows.Forms.ComboBox();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.panelTop_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.panelFill_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CSR)).BeginInit();
            this.groupBoxBus_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTop_CSR.Controls.Add(this.buttonHelp_CSR);
            this.panelTop_CSR.Controls.Add(this.Name_CSR);
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(800, 111);
            this.panelTop_CSR.TabIndex = 0;
            // 
            // Name_CSR
            // 
            this.Name_CSR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Name_CSR.AutoSize = true;
            this.Name_CSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_CSR.Location = new System.Drawing.Point(149, 36);
            this.Name_CSR.Name = "Name_CSR";
            this.Name_CSR.Size = new System.Drawing.Size(501, 39);
            this.Name_CSR.TabIndex = 0;
            this.Name_CSR.Text = "Городской транспорт Тюмени";
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Controls.Add(this.groupBoxBus_CSR);
            this.panelLeft_CSR.Controls.Add(this.buttonDelete_CSR);
            this.panelLeft_CSR.Controls.Add(this.buttonAdd_CSR);
            this.panelLeft_CSR.Controls.Add(this.buttonSave_CSR);
            this.panelLeft_CSR.Controls.Add(this.buttonOpen_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 111);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Size = new System.Drawing.Size(343, 339);
            this.panelLeft_CSR.TabIndex = 1;
            // 
            // buttonDelete_CSR
            // 
            this.buttonDelete_CSR.Enabled = false;
            this.buttonDelete_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_CSR.Image")));
            this.buttonDelete_CSR.Location = new System.Drawing.Point(255, 6);
            this.buttonDelete_CSR.Name = "buttonDelete_CSR";
            this.buttonDelete_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonDelete_CSR.TabIndex = 3;
            this.buttonDelete_CSR.UseVisualStyleBackColor = true;
            this.buttonDelete_CSR.Click += new System.EventHandler(this.buttonDelete_CSR_Click);
            // 
            // buttonAdd_CSR
            // 
            this.buttonAdd_CSR.Enabled = false;
            this.buttonAdd_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_CSR.Image")));
            this.buttonAdd_CSR.Location = new System.Drawing.Point(174, 6);
            this.buttonAdd_CSR.Name = "buttonAdd_CSR";
            this.buttonAdd_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonAdd_CSR.TabIndex = 2;
            this.buttonAdd_CSR.UseVisualStyleBackColor = true;
            this.buttonAdd_CSR.Click += new System.EventHandler(this.buttonAdd_CSR_Click);
            // 
            // buttonSave_CSR
            // 
            this.buttonSave_CSR.Enabled = false;
            this.buttonSave_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_CSR.Image")));
            this.buttonSave_CSR.Location = new System.Drawing.Point(93, 6);
            this.buttonSave_CSR.Name = "buttonSave_CSR";
            this.buttonSave_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonSave_CSR.TabIndex = 1;
            this.buttonSave_CSR.UseVisualStyleBackColor = true;
            this.buttonSave_CSR.Click += new System.EventHandler(this.buttonSave_CSR_Click);
            // 
            // buttonOpen_CSR
            // 
            this.buttonOpen_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_CSR.Image")));
            this.buttonOpen_CSR.Location = new System.Drawing.Point(12, 6);
            this.buttonOpen_CSR.Name = "buttonOpen_CSR";
            this.buttonOpen_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonOpen_CSR.TabIndex = 0;
            this.buttonOpen_CSR.UseVisualStyleBackColor = true;
            this.buttonOpen_CSR.Click += new System.EventHandler(this.buttonOpen_CSR_Click);
            // 
            // panelFill_CSR
            // 
            this.panelFill_CSR.Controls.Add(this.dataGridView_CSR);
            this.panelFill_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_CSR.Location = new System.Drawing.Point(343, 111);
            this.panelFill_CSR.Name = "panelFill_CSR";
            this.panelFill_CSR.Size = new System.Drawing.Size(457, 339);
            this.panelFill_CSR.TabIndex = 2;
            // 
            // dataGridView_CSR
            // 
            this.dataGridView_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CSR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number_CSR,
            this.Stsrt_CSR,
            this.End_CSR,
            this.Km_CSR,
            this.Pay_CSR,
            this.Stop_CSR,
            this.Bus_CSR,
            this.Date_CSR,
            this.Time_CSR});
            this.dataGridView_CSR.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_CSR.Name = "dataGridView_CSR";
            this.dataGridView_CSR.RowHeadersVisible = false;
            this.dataGridView_CSR.Size = new System.Drawing.Size(457, 339);
            this.dataGridView_CSR.TabIndex = 0;
            // 
            // Number_CSR
            // 
            this.Number_CSR.HeaderText = "Номер маршрута";
            this.Number_CSR.Name = "Number_CSR";
            // 
            // Stsrt_CSR
            // 
            this.Stsrt_CSR.HeaderText = "Начало маршрута";
            this.Stsrt_CSR.Name = "Stsrt_CSR";
            // 
            // End_CSR
            // 
            this.End_CSR.HeaderText = "Конец маршрута";
            this.End_CSR.Name = "End_CSR";
            // 
            // Km_CSR
            // 
            this.Km_CSR.HeaderText = "Протяженность маршрута, км";
            this.Km_CSR.Name = "Km_CSR";
            // 
            // Pay_CSR
            // 
            this.Pay_CSR.HeaderText = "Наличие системы безналичной оплаты проезда";
            this.Pay_CSR.Name = "Pay_CSR";
            // 
            // Stop_CSR
            // 
            this.Stop_CSR.HeaderText = "Наличие автоматического объявления остановки";
            this.Stop_CSR.Name = "Stop_CSR";
            // 
            // Bus_CSR
            // 
            this.Bus_CSR.HeaderText = "Вид транспорта";
            this.Bus_CSR.Name = "Bus_CSR";
            // 
            // Date_CSR
            // 
            this.Date_CSR.HeaderText = "Дата введения маршрута";
            this.Date_CSR.Name = "Date_CSR";
            // 
            // Time_CSR
            // 
            this.Time_CSR.HeaderText = "Время в пути, мин";
            this.Time_CSR.Name = "Time_CSR";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(343, 111);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 339);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog_CSR
            // 
            this.openFileDialog_CSR.FileName = "openFileDialog1";
            // 
            // groupBoxBus_CSR
            // 
            this.groupBoxBus_CSR.Controls.Add(this.comboBoxBus_CSR);
            this.groupBoxBus_CSR.Location = new System.Drawing.Point(12, 69);
            this.groupBoxBus_CSR.Name = "groupBoxBus_CSR";
            this.groupBoxBus_CSR.Size = new System.Drawing.Size(156, 49);
            this.groupBoxBus_CSR.TabIndex = 4;
            this.groupBoxBus_CSR.TabStop = false;
            this.groupBoxBus_CSR.Text = "Выбор маршрута:";
            // 
            // comboBoxBus_CSR
            // 
            this.comboBoxBus_CSR.FormattingEnabled = true;
            this.comboBoxBus_CSR.Items.AddRange(new object[] {
            "1",
            "1д",
            "2",
            "3",
            "4",
            "4д",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "11д",
            "13",
            "14",
            "15",
            "16",
            "17",
            "17к",
            "18",
            "20",
            "22",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "29д",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "36к",
            "37",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "47д",
            "48",
            "49",
            "50",
            "51",
            "51д",
            "52",
            "53",
            "54",
            "54д",
            "55",
            "57",
            "60",
            "62",
            "63",
            "64",
            "65",
            "68",
            "70",
            "73",
            "76",
            "79",
            "83",
            "84",
            "85",
            "86",
            "88",
            "89",
            "91",
            "96",
            "98",
            "99",
            "100",
            "100к",
            "120",
            "120к",
            "121",
            "128",
            "128к",
            "135",
            "140",
            "144",
            "145",
            "145к",
            "146",
            "147",
            "151",
            "151к",
            "156"});
            this.comboBoxBus_CSR.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBus_CSR.Name = "comboBoxBus_CSR";
            this.comboBoxBus_CSR.Size = new System.Drawing.Size(119, 21);
            this.comboBoxBus_CSR.TabIndex = 0;
            this.comboBoxBus_CSR.SelectedIndexChanged += new System.EventHandler(this.comboBoxBus_CSR_SelectedIndexChanged);
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonHelp_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_CSR.Image")));
            this.buttonHelp_CSR.Location = new System.Drawing.Point(713, 12);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonHelp_CSR.TabIndex = 1;
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFill_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop_CSR.ResumeLayout(false);
            this.panelTop_CSR.PerformLayout();
            this.panelLeft_CSR.ResumeLayout(false);
            this.panelFill_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CSR)).EndInit();
            this.groupBoxBus_CSR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelFill_CSR;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView_CSR;
        private System.Windows.Forms.Label Name_CSR;
        private System.Windows.Forms.Button buttonOpen_CSR;
        private System.Windows.Forms.Button buttonSave_CSR;
        private System.Windows.Forms.ToolTip toolTip_CSR;
        private System.Windows.Forms.OpenFileDialog openFileDialog_CSR;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_CSR;
        private System.Windows.Forms.Button buttonDelete_CSR;
        private System.Windows.Forms.Button buttonAdd_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stsrt_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Km_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stop_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_CSR;
        private System.Windows.Forms.GroupBox groupBoxBus_CSR;
        private System.Windows.Forms.ComboBox comboBoxBus_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
    }
}

