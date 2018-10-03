namespace _21._01.ver2
{
    partial class MainWindow
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.carrNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuggAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comfort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrNumber_txt = new System.Windows.Forms.TextBox();
            this.addCarriageHeading = new System.Windows.Forms.Label();
            this.carrNumber_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passNum_lbl = new System.Windows.Forms.Label();
            this.luggAmount_lbl = new System.Windows.Forms.Label();
            this.comfortLvl_lbl = new System.Windows.Forms.Label();
            this.passNum_txt = new System.Windows.Forms.TextBox();
            this.luggAmount_txt = new System.Windows.Forms.TextBox();
            this.comfortLvl_txt = new System.Windows.Forms.TextBox();
            this.addCarriage_btn = new System.Windows.Forms.Button();
            this.maxPass_lbl = new System.Windows.Forms.Label();
            this.minPass_lbl = new System.Windows.Forms.Label();
            this.maxPassDiapason_txt = new System.Windows.Forms.TextBox();
            this.minPassDiapason_txt = new System.Windows.Forms.TextBox();
            this.getAppropiateCarriages_btn = new System.Windows.Forms.Button();
            this.delCarriageHeading_lbl = new System.Windows.Forms.Label();
            this.numCarriage_lbl = new System.Windows.Forms.Label();
            this.numCarriageToDelete_txt = new System.Windows.Forms.TextBox();
            this.deleteCarriage_btn = new System.Windows.Forms.Button();
            this.getPassNumberHeading = new System.Windows.Forms.Label();
            this.getPassNum_btn = new System.Windows.Forms.Button();
            this.getLuggAmountHeading = new System.Windows.Forms.Label();
            this.getLuggAmount_btn = new System.Windows.Forms.Button();
            this.getPassengerNumber_lbl = new System.Windows.Forms.Label();
            this.getLuggAmount_lbl = new System.Windows.Forms.Label();
            this.carriageComfortSortHeading = new System.Windows.Forms.Label();
            this.sortCarriages_btn = new System.Windows.Forms.Button();
            this.printCarriageListHeading = new System.Windows.Forms.Label();
            this.showCarriageList_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carrNumber,
            this.PassNumber,
            this.LuggAmount,
            this.Comfort});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(617, 632);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // carrNumber
            // 
            this.carrNumber.HeaderText = "Номер";
            this.carrNumber.Name = "carrNumber";
            // 
            // PassNumber
            // 
            this.PassNumber.HeaderText = "Кол-во пассажиров";
            this.PassNumber.Name = "PassNumber";
            // 
            // LuggAmount
            // 
            this.LuggAmount.HeaderText = "Кол-во багажа";
            this.LuggAmount.Name = "LuggAmount";
            // 
            // Comfort
            // 
            this.Comfort.HeaderText = "Уровень комфорта(1-4)";
            this.Comfort.Name = "Comfort";
            // 
            // carrNumber_txt
            // 
            this.carrNumber_txt.Location = new System.Drawing.Point(730, 38);
            this.carrNumber_txt.Name = "carrNumber_txt";
            this.carrNumber_txt.Size = new System.Drawing.Size(41, 20);
            this.carrNumber_txt.TabIndex = 1;
            // 
            // addCarriageHeading
            // 
            this.addCarriageHeading.AutoSize = true;
            this.addCarriageHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarriageHeading.Location = new System.Drawing.Point(635, 12);
            this.addCarriageHeading.Name = "addCarriageHeading";
            this.addCarriageHeading.Size = new System.Drawing.Size(125, 19);
            this.addCarriageHeading.TabIndex = 2;
            this.addCarriageHeading.Text = "Добавить вагон:";
            // 
            // carrNumber_lbl
            // 
            this.carrNumber_lbl.AutoSize = true;
            this.carrNumber_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carrNumber_lbl.Location = new System.Drawing.Point(635, 40);
            this.carrNumber_lbl.Name = "carrNumber_lbl";
            this.carrNumber_lbl.Size = new System.Drawing.Size(89, 15);
            this.carrNumber_lbl.TabIndex = 3;
            this.carrNumber_lbl.Text = "Номер вагона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(634, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Найти вагоны в заданном диапазоне по числу пассажиров:";
            // 
            // passNum_lbl
            // 
            this.passNum_lbl.AutoSize = true;
            this.passNum_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passNum_lbl.Location = new System.Drawing.Point(777, 40);
            this.passNum_lbl.Name = "passNum_lbl";
            this.passNum_lbl.Size = new System.Drawing.Size(120, 15);
            this.passNum_lbl.TabIndex = 5;
            this.passNum_lbl.Text = "Кол-во пассажиров:";
            // 
            // luggAmount_lbl
            // 
            this.luggAmount_lbl.AutoSize = true;
            this.luggAmount_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.luggAmount_lbl.Location = new System.Drawing.Point(950, 40);
            this.luggAmount_lbl.Name = "luggAmount_lbl";
            this.luggAmount_lbl.Size = new System.Drawing.Size(93, 15);
            this.luggAmount_lbl.TabIndex = 6;
            this.luggAmount_lbl.Text = "Кол-во багажа:";
            // 
            // comfortLvl_lbl
            // 
            this.comfortLvl_lbl.AutoSize = true;
            this.comfortLvl_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comfortLvl_lbl.Location = new System.Drawing.Point(1096, 40);
            this.comfortLvl_lbl.Name = "comfortLvl_lbl";
            this.comfortLvl_lbl.Size = new System.Drawing.Size(141, 15);
            this.comfortLvl_lbl.TabIndex = 7;
            this.comfortLvl_lbl.Text = "Уровень комфорта(1-4):";
            // 
            // passNum_txt
            // 
            this.passNum_txt.Location = new System.Drawing.Point(903, 38);
            this.passNum_txt.Name = "passNum_txt";
            this.passNum_txt.Size = new System.Drawing.Size(41, 20);
            this.passNum_txt.TabIndex = 8;
            // 
            // luggAmount_txt
            // 
            this.luggAmount_txt.Location = new System.Drawing.Point(1049, 38);
            this.luggAmount_txt.Name = "luggAmount_txt";
            this.luggAmount_txt.Size = new System.Drawing.Size(41, 20);
            this.luggAmount_txt.TabIndex = 9;
            // 
            // comfortLvl_txt
            // 
            this.comfortLvl_txt.Location = new System.Drawing.Point(1243, 38);
            this.comfortLvl_txt.Name = "comfortLvl_txt";
            this.comfortLvl_txt.Size = new System.Drawing.Size(41, 20);
            this.comfortLvl_txt.TabIndex = 10;
            // 
            // addCarriage_btn
            // 
            this.addCarriage_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarriage_btn.Location = new System.Drawing.Point(639, 64);
            this.addCarriage_btn.Name = "addCarriage_btn";
            this.addCarriage_btn.Size = new System.Drawing.Size(682, 23);
            this.addCarriage_btn.TabIndex = 11;
            this.addCarriage_btn.Text = "Добавить вагон";
            this.addCarriage_btn.UseVisualStyleBackColor = true;
            this.addCarriage_btn.Click += new System.EventHandler(this.addCarriage_btn_Click);
            // 
            // maxPass_lbl
            // 
            this.maxPass_lbl.AutoSize = true;
            this.maxPass_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxPass_lbl.Location = new System.Drawing.Point(890, 125);
            this.maxPass_lbl.Name = "maxPass_lbl";
            this.maxPass_lbl.Size = new System.Drawing.Size(201, 15);
            this.maxPass_lbl.TabIndex = 12;
            this.maxPass_lbl.Text = "Максимальное число пассажиров";
            // 
            // minPass_lbl
            // 
            this.minPass_lbl.AutoSize = true;
            this.minPass_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minPass_lbl.Location = new System.Drawing.Point(635, 125);
            this.minPass_lbl.Name = "minPass_lbl";
            this.minPass_lbl.Size = new System.Drawing.Size(202, 15);
            this.minPass_lbl.TabIndex = 13;
            this.minPass_lbl.Text = "Минимальное число пассажиров: ";
            // 
            // maxPassDiapason_txt
            // 
            this.maxPassDiapason_txt.Location = new System.Drawing.Point(1097, 123);
            this.maxPassDiapason_txt.Name = "maxPassDiapason_txt";
            this.maxPassDiapason_txt.Size = new System.Drawing.Size(41, 20);
            this.maxPassDiapason_txt.TabIndex = 14;
            // 
            // minPassDiapason_txt
            // 
            this.minPassDiapason_txt.Location = new System.Drawing.Point(843, 123);
            this.minPassDiapason_txt.Name = "minPassDiapason_txt";
            this.minPassDiapason_txt.Size = new System.Drawing.Size(41, 20);
            this.minPassDiapason_txt.TabIndex = 15;
            // 
            // getAppropiateCarriages_btn
            // 
            this.getAppropiateCarriages_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getAppropiateCarriages_btn.Location = new System.Drawing.Point(635, 152);
            this.getAppropiateCarriages_btn.Name = "getAppropiateCarriages_btn";
            this.getAppropiateCarriages_btn.Size = new System.Drawing.Size(686, 23);
            this.getAppropiateCarriages_btn.TabIndex = 16;
            this.getAppropiateCarriages_btn.Text = "Выделить соответсующие вагоны";
            this.getAppropiateCarriages_btn.UseVisualStyleBackColor = true;
            this.getAppropiateCarriages_btn.Click += new System.EventHandler(this.getAppropiateCarriages_btn_Click);
            // 
            // delCarriageHeading_lbl
            // 
            this.delCarriageHeading_lbl.AutoSize = true;
            this.delCarriageHeading_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delCarriageHeading_lbl.Location = new System.Drawing.Point(635, 187);
            this.delCarriageHeading_lbl.Name = "delCarriageHeading_lbl";
            this.delCarriageHeading_lbl.Size = new System.Drawing.Size(117, 19);
            this.delCarriageHeading_lbl.TabIndex = 17;
            this.delCarriageHeading_lbl.Text = "Удалить вагон: ";
            // 
            // numCarriage_lbl
            // 
            this.numCarriage_lbl.AutoSize = true;
            this.numCarriage_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numCarriage_lbl.Location = new System.Drawing.Point(636, 216);
            this.numCarriage_lbl.Name = "numCarriage_lbl";
            this.numCarriage_lbl.Size = new System.Drawing.Size(92, 15);
            this.numCarriage_lbl.TabIndex = 18;
            this.numCarriage_lbl.Text = "Номер вагона: ";
            // 
            // numCarriageToDelete_txt
            // 
            this.numCarriageToDelete_txt.Location = new System.Drawing.Point(730, 214);
            this.numCarriageToDelete_txt.Name = "numCarriageToDelete_txt";
            this.numCarriageToDelete_txt.Size = new System.Drawing.Size(41, 20);
            this.numCarriageToDelete_txt.TabIndex = 19;
            // 
            // deleteCarriage_btn
            // 
            this.deleteCarriage_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCarriage_btn.Location = new System.Drawing.Point(776, 214);
            this.deleteCarriage_btn.Name = "deleteCarriage_btn";
            this.deleteCarriage_btn.Size = new System.Drawing.Size(545, 23);
            this.deleteCarriage_btn.TabIndex = 20;
            this.deleteCarriage_btn.Text = "Удалить вагон";
            this.deleteCarriage_btn.UseVisualStyleBackColor = true;
            this.deleteCarriage_btn.Click += new System.EventHandler(this.deleteCarriage_btn_Click);
            // 
            // getPassNumberHeading
            // 
            this.getPassNumberHeading.AutoSize = true;
            this.getPassNumberHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPassNumberHeading.Location = new System.Drawing.Point(631, 240);
            this.getPassNumberHeading.Name = "getPassNumberHeading";
            this.getPassNumberHeading.Size = new System.Drawing.Size(212, 19);
            this.getPassNumberHeading.TabIndex = 21;
            this.getPassNumberHeading.Text = "Вывести кол-во пассажиров:";
            // 
            // getPassNum_btn
            // 
            this.getPassNum_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPassNum_btn.Location = new System.Drawing.Point(638, 262);
            this.getPassNum_btn.Name = "getPassNum_btn";
            this.getPassNum_btn.Size = new System.Drawing.Size(686, 23);
            this.getPassNum_btn.TabIndex = 22;
            this.getPassNum_btn.Text = "Вывести количество пассажиров";
            this.getPassNum_btn.UseVisualStyleBackColor = true;
            this.getPassNum_btn.Click += new System.EventHandler(this.getPassNum_btn_Click);
            // 
            // getLuggAmountHeading
            // 
            this.getLuggAmountHeading.AutoSize = true;
            this.getLuggAmountHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getLuggAmountHeading.Location = new System.Drawing.Point(635, 297);
            this.getLuggAmountHeading.Name = "getLuggAmountHeading";
            this.getLuggAmountHeading.Size = new System.Drawing.Size(181, 19);
            this.getLuggAmountHeading.TabIndex = 23;
            this.getLuggAmountHeading.Text = "Вывести кол-во багажа: ";
            // 
            // getLuggAmount_btn
            // 
            this.getLuggAmount_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getLuggAmount_btn.Location = new System.Drawing.Point(639, 319);
            this.getLuggAmount_btn.Name = "getLuggAmount_btn";
            this.getLuggAmount_btn.Size = new System.Drawing.Size(686, 23);
            this.getLuggAmount_btn.TabIndex = 24;
            this.getLuggAmount_btn.Text = "Вывести количество багажа";
            this.getLuggAmount_btn.UseVisualStyleBackColor = true;
            this.getLuggAmount_btn.Click += new System.EventHandler(this.getLuggAmount_btn_Click);
            // 
            // getPassengerNumber_lbl
            // 
            this.getPassengerNumber_lbl.AutoSize = true;
            this.getPassengerNumber_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPassengerNumber_lbl.Location = new System.Drawing.Point(849, 240);
            this.getPassengerNumber_lbl.Name = "getPassengerNumber_lbl";
            this.getPassengerNumber_lbl.Size = new System.Drawing.Size(0, 19);
            this.getPassengerNumber_lbl.TabIndex = 25;
            // 
            // getLuggAmount_lbl
            // 
            this.getLuggAmount_lbl.AutoSize = true;
            this.getLuggAmount_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getLuggAmount_lbl.Location = new System.Drawing.Point(816, 297);
            this.getLuggAmount_lbl.Name = "getLuggAmount_lbl";
            this.getLuggAmount_lbl.Size = new System.Drawing.Size(0, 19);
            this.getLuggAmount_lbl.TabIndex = 26;
            // 
            // carriageComfortSortHeading
            // 
            this.carriageComfortSortHeading.AutoSize = true;
            this.carriageComfortSortHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carriageComfortSortHeading.Location = new System.Drawing.Point(635, 345);
            this.carriageComfortSortHeading.Name = "carriageComfortSortHeading";
            this.carriageComfortSortHeading.Size = new System.Drawing.Size(274, 19);
            this.carriageComfortSortHeading.TabIndex = 27;
            this.carriageComfortSortHeading.Text = "Отсортировать вагоны по комфорту: ";
            // 
            // sortCarriages_btn
            // 
            this.sortCarriages_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortCarriages_btn.Location = new System.Drawing.Point(639, 367);
            this.sortCarriages_btn.Name = "sortCarriages_btn";
            this.sortCarriages_btn.Size = new System.Drawing.Size(686, 23);
            this.sortCarriages_btn.TabIndex = 28;
            this.sortCarriages_btn.Text = "Отсортировать вагоны по комфорту";
            this.sortCarriages_btn.UseVisualStyleBackColor = true;
            this.sortCarriages_btn.Click += new System.EventHandler(this.sortCarriages_btn_Click);
            // 
            // printCarriageListHeading
            // 
            this.printCarriageListHeading.AutoSize = true;
            this.printCarriageListHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printCarriageListHeading.Location = new System.Drawing.Point(635, 393);
            this.printCarriageListHeading.Name = "printCarriageListHeading";
            this.printCarriageListHeading.Size = new System.Drawing.Size(254, 19);
            this.printCarriageListHeading.TabIndex = 29;
            this.printCarriageListHeading.Text = "Отразить полный список вагонов: ";
            // 
            // showCarriageList_btn
            // 
            this.showCarriageList_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showCarriageList_btn.Location = new System.Drawing.Point(638, 424);
            this.showCarriageList_btn.Name = "showCarriageList_btn";
            this.showCarriageList_btn.Size = new System.Drawing.Size(686, 23);
            this.showCarriageList_btn.TabIndex = 30;
            this.showCarriageList_btn.Text = "Вывести полный список вагонов";
            this.showCarriageList_btn.UseVisualStyleBackColor = true;
            this.showCarriageList_btn.Click += new System.EventHandler(this.showCarriageList_btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 656);
            this.Controls.Add(this.showCarriageList_btn);
            this.Controls.Add(this.printCarriageListHeading);
            this.Controls.Add(this.sortCarriages_btn);
            this.Controls.Add(this.carriageComfortSortHeading);
            this.Controls.Add(this.getLuggAmount_lbl);
            this.Controls.Add(this.getPassengerNumber_lbl);
            this.Controls.Add(this.getLuggAmount_btn);
            this.Controls.Add(this.getLuggAmountHeading);
            this.Controls.Add(this.getPassNum_btn);
            this.Controls.Add(this.getPassNumberHeading);
            this.Controls.Add(this.deleteCarriage_btn);
            this.Controls.Add(this.numCarriageToDelete_txt);
            this.Controls.Add(this.numCarriage_lbl);
            this.Controls.Add(this.delCarriageHeading_lbl);
            this.Controls.Add(this.getAppropiateCarriages_btn);
            this.Controls.Add(this.minPassDiapason_txt);
            this.Controls.Add(this.maxPassDiapason_txt);
            this.Controls.Add(this.minPass_lbl);
            this.Controls.Add(this.maxPass_lbl);
            this.Controls.Add(this.addCarriage_btn);
            this.Controls.Add(this.comfortLvl_txt);
            this.Controls.Add(this.luggAmount_txt);
            this.Controls.Add(this.passNum_txt);
            this.Controls.Add(this.comfortLvl_lbl);
            this.Controls.Add(this.luggAmount_lbl);
            this.Controls.Add(this.passNum_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carrNumber_lbl);
            this.Controls.Add(this.addCarriageHeading);
            this.Controls.Add(this.carrNumber_txt);
            this.Controls.Add(this.dataGrid);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox carrNumber_txt;
        private System.Windows.Forms.Label addCarriageHeading;
        private System.Windows.Forms.Label carrNumber_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label passNum_lbl;
        private System.Windows.Forms.Label luggAmount_lbl;
        private System.Windows.Forms.Label comfortLvl_lbl;
        private System.Windows.Forms.TextBox passNum_txt;
        private System.Windows.Forms.TextBox luggAmount_txt;
        private System.Windows.Forms.TextBox comfortLvl_txt;
        private System.Windows.Forms.Button addCarriage_btn;
        private System.Windows.Forms.Label maxPass_lbl;
        private System.Windows.Forms.Label minPass_lbl;
        private System.Windows.Forms.TextBox maxPassDiapason_txt;
        private System.Windows.Forms.TextBox minPassDiapason_txt;
        private System.Windows.Forms.Button getAppropiateCarriages_btn;
        private System.Windows.Forms.Label delCarriageHeading_lbl;
        private System.Windows.Forms.Label numCarriage_lbl;
        private System.Windows.Forms.TextBox numCarriageToDelete_txt;
        private System.Windows.Forms.Button deleteCarriage_btn;
        private System.Windows.Forms.Label getPassNumberHeading;
        private System.Windows.Forms.Button getPassNum_btn;
        private System.Windows.Forms.Label getLuggAmountHeading;
        private System.Windows.Forms.Button getLuggAmount_btn;
        private System.Windows.Forms.Label getPassengerNumber_lbl;
        private System.Windows.Forms.Label getLuggAmount_lbl;
        private System.Windows.Forms.Label carriageComfortSortHeading;
        private System.Windows.Forms.Button sortCarriages_btn;
        private System.Windows.Forms.Label printCarriageListHeading;
        private System.Windows.Forms.Button showCarriageList_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuggAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comfort;
    }
}

