
namespace Proga4
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.launchSort = new System.Windows.Forms.ToolStripMenuItem();
            this.excelReadData = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSheetsReadData = new System.Windows.Forms.ToolStripMenuItem();
            this.generateData = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortCheck = new System.Windows.Forms.CheckBox();
            this.insertSortCheck = new System.Windows.Forms.CheckBox();
            this.shakerSortCheck = new System.Windows.Forms.CheckBox();
            this.quickSortCheck = new System.Windows.Forms.CheckBox();
            this.bogoSortCheck = new System.Windows.Forms.CheckBox();
            this.linkGoogleTable = new System.Windows.Forms.TextBox();
            this.nameSheet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bubbleSortSchedule = new ZedGraph.ZedGraphControl();
            this.bubbleSortInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descendingSort = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertSortInfo = new System.Windows.Forms.RichTextBox();
            this.insertSortSchedule = new ZedGraph.ZedGraphControl();
            this.label5 = new System.Windows.Forms.Label();
            this.bogoSortInfo = new System.Windows.Forms.RichTextBox();
            this.bogoSortShedule = new ZedGraph.ZedGraphControl();
            this.label6 = new System.Windows.Forms.Label();
            this.quickSortInfo = new System.Windows.Forms.RichTextBox();
            this.quickSortShedule = new ZedGraph.ZedGraphControl();
            this.label7 = new System.Windows.Forms.Label();
            this.shakerSortInfo = new System.Windows.Forms.RichTextBox();
            this.shakerSortSchedule = new ZedGraph.ZedGraphControl();
            this.label8 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.rowGenerateData = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchSort,
            this.excelReadData,
            this.googleSheetsReadData,
            this.generateData,
            this.exitApplication});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1863, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // launchSort
            // 
            this.launchSort.Name = "launchSort";
            this.launchSort.Size = new System.Drawing.Size(91, 24);
            this.launchSort.Text = "Запустить";
            this.launchSort.Click += new System.EventHandler(this.launchSort_Click);
            // 
            // excelReadData
            // 
            this.excelReadData.Name = "excelReadData";
            this.excelReadData.Size = new System.Drawing.Size(57, 24);
            this.excelReadData.Text = "Excel";
            this.excelReadData.Click += new System.EventHandler(this.excelReadData_Click);
            // 
            // googleSheetsReadData
            // 
            this.googleSheetsReadData.Name = "googleSheetsReadData";
            this.googleSheetsReadData.Size = new System.Drawing.Size(119, 24);
            this.googleSheetsReadData.Text = "Google Sheets";
            this.googleSheetsReadData.Click += new System.EventHandler(this.googleSheetsReadData_Click);
            // 
            // generateData
            // 
            this.generateData.Name = "generateData";
            this.generateData.Size = new System.Drawing.Size(265, 24);
            this.generateData.Text = "Сгенерировать случайные данные";
            this.generateData.Click += new System.EventHandler(this.generateData_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(67, 24);
            this.exitApplication.Text = "Выход";
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // bubbleSortCheck
            // 
            this.bubbleSortCheck.AutoSize = true;
            this.bubbleSortCheck.Location = new System.Drawing.Point(15, 190);
            this.bubbleSortCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bubbleSortCheck.Name = "bubbleSortCheck";
            this.bubbleSortCheck.Size = new System.Drawing.Size(197, 21);
            this.bubbleSortCheck.TabIndex = 1;
            this.bubbleSortCheck.Text = "Пузырьковая сортировка";
            this.bubbleSortCheck.UseVisualStyleBackColor = true;
            this.bubbleSortCheck.CheckedChanged += new System.EventHandler(this.bubbleSortCheck_CheckedChanged);
            // 
            // insertSortCheck
            // 
            this.insertSortCheck.AutoSize = true;
            this.insertSortCheck.Location = new System.Drawing.Point(15, 228);
            this.insertSortCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertSortCheck.Name = "insertSortCheck";
            this.insertSortCheck.Size = new System.Drawing.Size(180, 21);
            this.insertSortCheck.TabIndex = 2;
            this.insertSortCheck.Text = "Сортировка вставками";
            this.insertSortCheck.UseVisualStyleBackColor = true;
            this.insertSortCheck.CheckedChanged += new System.EventHandler(this.insertSortCheck_CheckedChanged);
            // 
            // shakerSortCheck
            // 
            this.shakerSortCheck.AutoSize = true;
            this.shakerSortCheck.Location = new System.Drawing.Point(14, 267);
            this.shakerSortCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shakerSortCheck.Name = "shakerSortCheck";
            this.shakerSortCheck.Size = new System.Drawing.Size(184, 21);
            this.shakerSortCheck.TabIndex = 3;
            this.shakerSortCheck.Text = "Шейкерная сортировка";
            this.shakerSortCheck.UseVisualStyleBackColor = true;
            this.shakerSortCheck.CheckedChanged += new System.EventHandler(this.shakerSortCheck_CheckedChanged);
            // 
            // quickSortCheck
            // 
            this.quickSortCheck.AutoSize = true;
            this.quickSortCheck.Location = new System.Drawing.Point(14, 303);
            this.quickSortCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickSortCheck.Name = "quickSortCheck";
            this.quickSortCheck.Size = new System.Drawing.Size(167, 21);
            this.quickSortCheck.TabIndex = 4;
            this.quickSortCheck.Text = "Быстрая сортировка";
            this.quickSortCheck.UseVisualStyleBackColor = true;
            this.quickSortCheck.CheckedChanged += new System.EventHandler(this.quickSortCheck_CheckedChanged);
            // 
            // bogoSortCheck
            // 
            this.bogoSortCheck.AutoSize = true;
            this.bogoSortCheck.Location = new System.Drawing.Point(14, 339);
            this.bogoSortCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bogoSortCheck.Name = "bogoSortCheck";
            this.bogoSortCheck.Size = new System.Drawing.Size(72, 21);
            this.bogoSortCheck.TabIndex = 5;
            this.bogoSortCheck.Text = "BOGO";
            this.bogoSortCheck.UseVisualStyleBackColor = true;
            this.bogoSortCheck.CheckedChanged += new System.EventHandler(this.bogoSortCheck_CheckedChanged);
            // 
            // linkGoogleTable
            // 
            this.linkGoogleTable.Location = new System.Drawing.Point(15, 62);
            this.linkGoogleTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkGoogleTable.Name = "linkGoogleTable";
            this.linkGoogleTable.Size = new System.Drawing.Size(241, 22);
            this.linkGoogleTable.TabIndex = 6;
            // 
            // nameSheet
            // 
            this.nameSheet.Location = new System.Drawing.Point(283, 62);
            this.nameSheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameSheet.Name = "nameSheet";
            this.nameSheet.Size = new System.Drawing.Size(177, 22);
            this.nameSheet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ссылка на таблицу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название листа";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number});
            this.dataGridView1.Location = new System.Drawing.Point(272, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(213, 345);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "Column1";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bubbleSortSchedule
            // 
            this.bubbleSortSchedule.Location = new System.Drawing.Point(691, 62);
            this.bubbleSortSchedule.Margin = new System.Windows.Forms.Padding(5);
            this.bubbleSortSchedule.Name = "bubbleSortSchedule";
            this.bubbleSortSchedule.ScrollGrace = 0D;
            this.bubbleSortSchedule.ScrollMaxX = 0D;
            this.bubbleSortSchedule.ScrollMaxY = 0D;
            this.bubbleSortSchedule.ScrollMaxY2 = 0D;
            this.bubbleSortSchedule.ScrollMinX = 0D;
            this.bubbleSortSchedule.ScrollMinY = 0D;
            this.bubbleSortSchedule.ScrollMinY2 = 0D;
            this.bubbleSortSchedule.Size = new System.Drawing.Size(548, 327);
            this.bubbleSortSchedule.TabIndex = 12;
            this.bubbleSortSchedule.UseExtendedPrintDialog = true;
            // 
            // bubbleSortInfo
            // 
            this.bubbleSortInfo.Location = new System.Drawing.Point(691, 396);
            this.bubbleSortInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bubbleSortInfo.Name = "bubbleSortInfo";
            this.bubbleSortInfo.Size = new System.Drawing.Size(548, 96);
            this.bubbleSortInfo.TabIndex = 13;
            this.bubbleSortInfo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пузырьковая сортировка";
            // 
            // descendingSort
            // 
            this.descendingSort.AutoSize = true;
            this.descendingSort.Location = new System.Drawing.Point(283, 103);
            this.descendingSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descendingSort.Name = "descendingSort";
            this.descendingSort.Size = new System.Drawing.Size(198, 21);
            this.descendingSort.TabIndex = 15;
            this.descendingSort.Text = "Сортировка по убыванию";
            this.descendingSort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1505, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Сортировка вставками";
            // 
            // insertSortInfo
            // 
            this.insertSortInfo.Location = new System.Drawing.Point(1320, 396);
            this.insertSortInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertSortInfo.Name = "insertSortInfo";
            this.insertSortInfo.Size = new System.Drawing.Size(548, 96);
            this.insertSortInfo.TabIndex = 17;
            this.insertSortInfo.Text = "";
            // 
            // insertSortSchedule
            // 
            this.insertSortSchedule.Location = new System.Drawing.Point(1320, 62);
            this.insertSortSchedule.Margin = new System.Windows.Forms.Padding(5);
            this.insertSortSchedule.Name = "insertSortSchedule";
            this.insertSortSchedule.ScrollGrace = 0D;
            this.insertSortSchedule.ScrollMaxX = 0D;
            this.insertSortSchedule.ScrollMaxY = 0D;
            this.insertSortSchedule.ScrollMaxY2 = 0D;
            this.insertSortSchedule.ScrollMinX = 0D;
            this.insertSortSchedule.ScrollMinY = 0D;
            this.insertSortSchedule.ScrollMinY2 = 0D;
            this.insertSortSchedule.Size = new System.Drawing.Size(548, 327);
            this.insertSortSchedule.TabIndex = 16;
            this.insertSortSchedule.UseExtendedPrintDialog = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1599, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "BOGO";
            // 
            // bogoSortInfo
            // 
            this.bogoSortInfo.Location = new System.Drawing.Point(1320, 880);
            this.bogoSortInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bogoSortInfo.Name = "bogoSortInfo";
            this.bogoSortInfo.Size = new System.Drawing.Size(548, 96);
            this.bogoSortInfo.TabIndex = 23;
            this.bogoSortInfo.Text = "";
            // 
            // bogoSortShedule
            // 
            this.bogoSortShedule.Location = new System.Drawing.Point(1320, 537);
            this.bogoSortShedule.Margin = new System.Windows.Forms.Padding(5);
            this.bogoSortShedule.Name = "bogoSortShedule";
            this.bogoSortShedule.ScrollGrace = 0D;
            this.bogoSortShedule.ScrollMaxX = 0D;
            this.bogoSortShedule.ScrollMaxY = 0D;
            this.bogoSortShedule.ScrollMaxY2 = 0D;
            this.bogoSortShedule.ScrollMinX = 0D;
            this.bogoSortShedule.ScrollMinY = 0D;
            this.bogoSortShedule.ScrollMinY2 = 0D;
            this.bogoSortShedule.Size = new System.Drawing.Size(548, 327);
            this.bogoSortShedule.TabIndex = 22;
            this.bogoSortShedule.UseExtendedPrintDialog = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(887, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Быстрая сортировка";
            // 
            // quickSortInfo
            // 
            this.quickSortInfo.Location = new System.Drawing.Point(691, 880);
            this.quickSortInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickSortInfo.Name = "quickSortInfo";
            this.quickSortInfo.Size = new System.Drawing.Size(548, 96);
            this.quickSortInfo.TabIndex = 20;
            this.quickSortInfo.Text = "";
            // 
            // quickSortShedule
            // 
            this.quickSortShedule.Location = new System.Drawing.Point(691, 537);
            this.quickSortShedule.Margin = new System.Windows.Forms.Padding(5);
            this.quickSortShedule.Name = "quickSortShedule";
            this.quickSortShedule.ScrollGrace = 0D;
            this.quickSortShedule.ScrollMaxX = 0D;
            this.quickSortShedule.ScrollMaxY = 0D;
            this.quickSortShedule.ScrollMaxY2 = 0D;
            this.quickSortShedule.ScrollMinX = 0D;
            this.quickSortShedule.ScrollMinY = 0D;
            this.quickSortShedule.ScrollMinY2 = 0D;
            this.quickSortShedule.Size = new System.Drawing.Size(548, 327);
            this.quickSortShedule.TabIndex = 19;
            this.quickSortShedule.UseExtendedPrintDialog = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Шейкерная сортировка";
            // 
            // shakerSortInfo
            // 
            this.shakerSortInfo.Location = new System.Drawing.Point(24, 871);
            this.shakerSortInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shakerSortInfo.Name = "shakerSortInfo";
            this.shakerSortInfo.Size = new System.Drawing.Size(548, 96);
            this.shakerSortInfo.TabIndex = 26;
            this.shakerSortInfo.Text = "";
            // 
            // shakerSortSchedule
            // 
            this.shakerSortSchedule.Location = new System.Drawing.Point(24, 537);
            this.shakerSortSchedule.Margin = new System.Windows.Forms.Padding(5);
            this.shakerSortSchedule.Name = "shakerSortSchedule";
            this.shakerSortSchedule.ScrollGrace = 0D;
            this.shakerSortSchedule.ScrollMaxX = 0D;
            this.shakerSortSchedule.ScrollMaxY = 0D;
            this.shakerSortSchedule.ScrollMaxY2 = 0D;
            this.shakerSortSchedule.ScrollMinX = 0D;
            this.shakerSortSchedule.ScrollMinY = 0D;
            this.shakerSortSchedule.ScrollMinY2 = 0D;
            this.shakerSortSchedule.Size = new System.Drawing.Size(548, 327);
            this.shakerSortSchedule.TabIndex = 25;
            this.shakerSortSchedule.UseExtendedPrintDialog = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Время (мс)";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(496, 62);
            this.time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 22);
            this.time.TabIndex = 29;
            // 
            // rowGenerateData
            // 
            this.rowGenerateData.Location = new System.Drawing.Point(15, 130);
            this.rowGenerateData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rowGenerateData.Name = "rowGenerateData";
            this.rowGenerateData.Size = new System.Drawing.Size(207, 22);
            this.rowGenerateData.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Количество строк  для  генерации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 982);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rowGenerateData);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.shakerSortInfo);
            this.Controls.Add(this.shakerSortSchedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bogoSortInfo);
            this.Controls.Add(this.bogoSortShedule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quickSortInfo);
            this.Controls.Add(this.quickSortShedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertSortInfo);
            this.Controls.Add(this.insertSortSchedule);
            this.Controls.Add(this.descendingSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bubbleSortInfo);
            this.Controls.Add(this.bubbleSortSchedule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameSheet);
            this.Controls.Add(this.linkGoogleTable);
            this.Controls.Add(this.bogoSortCheck);
            this.Controls.Add(this.quickSortCheck);
            this.Controls.Add(this.shakerSortCheck);
            this.Controls.Add(this.insertSortCheck);
            this.Controls.Add(this.bubbleSortCheck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem launchSort;
        private System.Windows.Forms.CheckBox bubbleSortCheck;
        private System.Windows.Forms.CheckBox insertSortCheck;
        private System.Windows.Forms.CheckBox shakerSortCheck;
        private System.Windows.Forms.CheckBox quickSortCheck;
        private System.Windows.Forms.CheckBox bogoSortCheck;
        private System.Windows.Forms.ToolStripMenuItem excelReadData;
        private System.Windows.Forms.ToolStripMenuItem googleSheetsReadData;
        private System.Windows.Forms.ToolStripMenuItem exitApplication;
        private System.Windows.Forms.TextBox linkGoogleTable;
        private System.Windows.Forms.TextBox nameSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private ZedGraph.ZedGraphControl bubbleSortSchedule;
        private System.Windows.Forms.RichTextBox bubbleSortInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox descendingSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox insertSortInfo;
        private ZedGraph.ZedGraphControl insertSortSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox bogoSortInfo;
        private ZedGraph.ZedGraphControl bogoSortShedule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox quickSortInfo;
        private ZedGraph.ZedGraphControl quickSortShedule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox shakerSortInfo;
        private ZedGraph.ZedGraphControl shakerSortSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox rowGenerateData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem generateData;
    }
}

