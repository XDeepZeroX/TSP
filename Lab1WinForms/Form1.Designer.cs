namespace Lab1WinForms
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
            this.openFile = new System.Windows.Forms.Button();
            this.pathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateData = new System.Windows.Forms.Button();
            this.pictureCity = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureRoads = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openInEditor = new System.Windows.Forms.Button();
            this.numTest = new System.Windows.Forms.NumericUpDown();
            this.BtnTest = new System.Windows.Forms.Button();
            this.numTestDone = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableFroms = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.BtnStop = new System.Windows.Forms.Button();
            this.timeResult = new System.Windows.Forms.TabPage();
            this.LbTime = new System.Windows.Forms.Label();
            this.labelForTime = new System.Windows.Forms.Label();
            this.lbMeanTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTest)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableFroms.SuspendLayout();
            this.main.SuspendLayout();
            this.timeResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.openFile.Enabled = false;
            this.openFile.Location = new System.Drawing.Point(515, 43);
            this.openFile.MaximumSize = new System.Drawing.Size(75, 23);
            this.openFile.MinimumSize = new System.Drawing.Size(75, 23);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Открыть";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // pathFile
            // 
            this.pathFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pathFile.Enabled = false;
            this.pathFile.Location = new System.Drawing.Point(158, 45);
            this.pathFile.Name = "pathFile";
            this.pathFile.Size = new System.Drawing.Size(340, 20);
            this.pathFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(368, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Открыть файл с координатами городов";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Генерация координат городов";
            // 
            // generateData
            // 
            this.generateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.generateData.Location = new System.Drawing.Point(465, 102);
            this.generateData.MaximumSize = new System.Drawing.Size(95, 22);
            this.generateData.MinimumSize = new System.Drawing.Size(95, 22);
            this.generateData.Name = "generateData";
            this.generateData.Size = new System.Drawing.Size(95, 22);
            this.generateData.TabIndex = 0;
            this.generateData.Text = "Сгенерировать";
            this.generateData.UseVisualStyleBackColor = true;
            this.generateData.Click += new System.EventHandler(this.generateData_Click);
            // 
            // pictureCity
            // 
            this.pictureCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCity.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCity.Location = new System.Drawing.Point(3, 3);
            this.pictureCity.Name = "pictureCity";
            this.pictureCity.Size = new System.Drawing.Size(440, 165);
            this.pictureCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCity.TabIndex = 3;
            this.pictureCity.TabStop = false;
            this.pictureCity.Click += new System.EventHandler(this.pictureCity_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во городов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDown1.Location = new System.Drawing.Point(328, 105);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Расположение городов";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Результат алгоритма";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(294, 331);
            this.btnSearch.MaximumSize = new System.Drawing.Size(191, 23);
            this.btnSearch.MinimumSize = new System.Drawing.Size(191, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Найти кратчайший путь";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureRoads
            // 
            this.pictureRoads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureRoads.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureRoads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureRoads.Location = new System.Drawing.Point(449, 3);
            this.pictureRoads.Name = "pictureRoads";
            this.pictureRoads.Size = new System.Drawing.Size(441, 165);
            this.pictureRoads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRoads.TabIndex = 3;
            this.pictureRoads.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "data.txt";
            this.openFileDialog.Tag = global::Lab1WinForms.Properties.Settings.Default.test;
            // 
            // openInEditor
            // 
            this.openInEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.openInEditor.Enabled = false;
            this.openInEditor.Location = new System.Drawing.Point(610, 43);
            this.openInEditor.MaximumSize = new System.Drawing.Size(134, 23);
            this.openInEditor.MinimumSize = new System.Drawing.Size(134, 23);
            this.openInEditor.Name = "openInEditor";
            this.openInEditor.Size = new System.Drawing.Size(134, 23);
            this.openInEditor.TabIndex = 0;
            this.openInEditor.Text = "Открыть в редакторе";
            this.openInEditor.UseVisualStyleBackColor = true;
            this.openInEditor.Click += new System.EventHandler(this.openInEditor_Click);
            // 
            // numTest
            // 
            this.numTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numTest.Location = new System.Drawing.Point(457, 365);
            this.numTest.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numTest.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numTest.MinimumSize = new System.Drawing.Size(66, 0);
            this.numTest.Name = "numTest";
            this.numTest.Size = new System.Drawing.Size(66, 20);
            this.numTest.TabIndex = 7;
            this.numTest.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnTest.Location = new System.Drawing.Point(246, 362);
            this.BtnTest.MaximumSize = new System.Drawing.Size(191, 23);
            this.BtnTest.MinimumSize = new System.Drawing.Size(191, 23);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(191, 23);
            this.BtnTest.TabIndex = 6;
            this.BtnTest.Text = "Тестирование времени";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // numTestDone
            // 
            this.numTestDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numTestDone.AutoSize = true;
            this.numTestDone.Location = new System.Drawing.Point(340, 388);
            this.numTestDone.Name = "numTestDone";
            this.numTestDone.Size = new System.Drawing.Size(97, 13);
            this.numTestDone.TabIndex = 8;
            this.numTestDone.Text = "Выполнен № тест";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureRoads, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureCity, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 171);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(8, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 173);
            this.panel1.TabIndex = 10;
            // 
            // tableFroms
            // 
            this.tableFroms.Controls.Add(this.main);
            this.tableFroms.Controls.Add(this.timeResult);
            this.tableFroms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFroms.Location = new System.Drawing.Point(0, 0);
            this.tableFroms.Name = "tableFroms";
            this.tableFroms.SelectedIndex = 0;
            this.tableFroms.Size = new System.Drawing.Size(914, 447);
            this.tableFroms.TabIndex = 11;
            // 
            // main
            // 
            this.main.Controls.Add(this.BtnStop);
            this.main.Controls.Add(this.panel1);
            this.main.Controls.Add(this.openFile);
            this.main.Controls.Add(this.openInEditor);
            this.main.Controls.Add(this.numTestDone);
            this.main.Controls.Add(this.generateData);
            this.main.Controls.Add(this.pathFile);
            this.main.Controls.Add(this.numTest);
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.BtnTest);
            this.main.Controls.Add(this.label2);
            this.main.Controls.Add(this.btnSearch);
            this.main.Controls.Add(this.label3);
            this.main.Controls.Add(this.numericUpDown1);
            this.main.Controls.Add(this.label4);
            this.main.Controls.Add(this.label5);
            this.main.Location = new System.Drawing.Point(4, 22);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(906, 421);
            this.main.TabIndex = 1;
            this.main.Text = "Ввод данных";
            this.main.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(582, 362);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 11;
            this.BtnStop.Text = "Остановить";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // timeResult
            // 
            this.timeResult.Controls.Add(this.LbTime);
            this.timeResult.Controls.Add(this.labelForTime);
            this.timeResult.Controls.Add(this.lbMeanTime);
            this.timeResult.Location = new System.Drawing.Point(4, 22);
            this.timeResult.Name = "timeResult";
            this.timeResult.Padding = new System.Windows.Forms.Padding(3);
            this.timeResult.Size = new System.Drawing.Size(906, 421);
            this.timeResult.TabIndex = 0;
            this.timeResult.Text = "Вывод времени выполнения";
            this.timeResult.UseVisualStyleBackColor = true;
            // 
            // LbTime
            // 
            this.LbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTime.AutoSize = true;
            this.LbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTime.Location = new System.Drawing.Point(469, 202);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(26, 29);
            this.LbTime.TabIndex = 9;
            this.LbTime.Text = "0";
            this.LbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelForTime
            // 
            this.labelForTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForTime.Location = new System.Drawing.Point(218, 202);
            this.labelForTime.Name = "labelForTime";
            this.labelForTime.Size = new System.Drawing.Size(373, 29);
            this.labelForTime.TabIndex = 10;
            this.labelForTime.Text = "Время выполнения: ";
            this.labelForTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMeanTime
            // 
            this.lbMeanTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMeanTime.AutoSize = true;
            this.lbMeanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMeanTime.Location = new System.Drawing.Point(218, 146);
            this.lbMeanTime.Name = "lbMeanTime";
            this.lbMeanTime.Size = new System.Drawing.Size(360, 29);
            this.lbMeanTime.TabIndex = 11;
            this.lbMeanTime.Text = "Среднее время по 0 тестам: 0";
            this.lbMeanTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 447);
            this.Controls.Add(this.tableFroms);
            this.MinimumSize = new System.Drawing.Size(930, 486);
            this.Name = "Form1";
            this.Text = "Задача коммивояжера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTest)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableFroms.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.timeResult.ResumeLayout(false);
            this.timeResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox pathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateData;
        private System.Windows.Forms.PictureBox pictureCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureRoads;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openInEditor;
        private System.Windows.Forms.NumericUpDown numTest;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label numTestDone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tableFroms;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage timeResult;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label labelForTime;
        private System.Windows.Forms.Label lbMeanTime;
        private System.Windows.Forms.Button BtnStop;
    }
}

