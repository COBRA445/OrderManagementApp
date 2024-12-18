namespace OrderManagementApp
{
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
            ordersGridView = new DataGridView();
            departmentTextBox = new TextBox();
            dateTimePickerOrderDate = new DateTimePicker();
            orderIdTextBox = new TextBox();
            statusTextBox = new TextBox();
            dateTimeGivingTheEnd = new DateTimePicker();
            itemsGridView = new DataGridView();
            steelGradeTextBox = new TextBox();
            diameterTextBox = new TextBox();
            wallThicknessTextBox = new TextBox();
            volumeTextBox = new TextBox();
            unitTextBox = new TextBox();
            itemStatusTextBox = new TextBox();
            updateOrderButton = new Button();
            updateItemButton = new Button();
            deleteOrderButton = new Button();
            deleteItemButton = new Button();
            addOrderButton = new Button();
            addOrderItemButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            clearSearchButton = new Button();
            labelOrders = new Label();
            labelOrderItems = new Label();
            labelDepartment = new Label();
            labelOrderId = new Label();
            labelStatus = new Label();
            labelPickerOrderDate = new Label();
            labelGivingTheEnd = new Label();
            labelSteelGrade = new Label();
            labelDiameter = new Label();
            labelWallThickness = new Label();
            labelVolume = new Label();
            labelUnit = new Label();
            labelItemStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersGridView
            // 
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(12, 21);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.Size = new Size(544, 232);
            ordersGridView.TabIndex = 0;
            ordersGridView.SelectionChanged += ordersGridView_SelectionChanged;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(11, 276);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(140, 23);
            departmentTextBox.TabIndex = 1;
            departmentTextBox.Text = "Отдел";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(180, 276);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(140, 23);
            dateTimePickerOrderDate.TabIndex = 2;
            // 
            // orderIdTextBox
            // 
            orderIdTextBox.Location = new Point(11, 314);
            orderIdTextBox.Name = "orderIdTextBox";
            orderIdTextBox.Size = new Size(140, 23);
            orderIdTextBox.TabIndex = 3;
            orderIdTextBox.Text = "Id заказа";
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(11, 353);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(140, 23);
            statusTextBox.TabIndex = 4;
            statusTextBox.Text = "Статус";
            // 
            // dateTimeGivingTheEnd
            // 
            dateTimeGivingTheEnd.Location = new Point(180, 314);
            dateTimeGivingTheEnd.Name = "dateTimeGivingTheEnd";
            dateTimeGivingTheEnd.Size = new Size(140, 23);
            dateTimeGivingTheEnd.TabIndex = 5;
            // 
            // itemsGridView
            // 
            itemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsGridView.Location = new Point(562, 21);
            itemsGridView.Name = "itemsGridView";
            itemsGridView.Size = new Size(747, 232);
            itemsGridView.TabIndex = 6;
            itemsGridView.SelectionChanged += itemsGridView_SelectionChanged;
            // 
            // steelGradeTextBox
            // 
            steelGradeTextBox.Location = new Point(578, 276);
            steelGradeTextBox.Name = "steelGradeTextBox";
            steelGradeTextBox.Size = new Size(140, 23);
            steelGradeTextBox.TabIndex = 7;
            steelGradeTextBox.Text = "Марка стали";
            // 
            // diameterTextBox
            // 
            diameterTextBox.Location = new Point(578, 314);
            diameterTextBox.Name = "diameterTextBox";
            diameterTextBox.Size = new Size(140, 23);
            diameterTextBox.TabIndex = 8;
            diameterTextBox.Text = "Диаметр";
            // 
            // wallThicknessTextBox
            // 
            wallThicknessTextBox.Location = new Point(578, 353);
            wallThicknessTextBox.Name = "wallThicknessTextBox";
            wallThicknessTextBox.Size = new Size(140, 23);
            wallThicknessTextBox.TabIndex = 9;
            wallThicknessTextBox.Text = "Стенка";
            // 
            // volumeTextBox
            // 
            volumeTextBox.Location = new Point(749, 276);
            volumeTextBox.Name = "volumeTextBox";
            volumeTextBox.Size = new Size(140, 23);
            volumeTextBox.TabIndex = 10;
            volumeTextBox.Text = "Объем";
            // 
            // unitTextBox
            // 
            unitTextBox.Location = new Point(749, 314);
            unitTextBox.Name = "unitTextBox";
            unitTextBox.Size = new Size(140, 23);
            unitTextBox.TabIndex = 11;
            unitTextBox.Text = "Единица измерения\n";
            // 
            // itemStatusTextBox
            // 
            itemStatusTextBox.Location = new Point(749, 353);
            itemStatusTextBox.Name = "itemStatusTextBox";
            itemStatusTextBox.Size = new Size(140, 23);
            itemStatusTextBox.TabIndex = 12;
            itemStatusTextBox.Text = "Статус позиции";
            // 
            // updateOrderButton
            // 
            updateOrderButton.Location = new Point(340, 276);
            updateOrderButton.Name = "updateOrderButton";
            updateOrderButton.Size = new Size(172, 61);
            updateOrderButton.TabIndex = 13;
            updateOrderButton.Text = "Изменить";
            updateOrderButton.UseVisualStyleBackColor = true;
            updateOrderButton.Click += updateOrderButton_Click;
            // 
            // updateItemButton
            // 
            updateItemButton.Location = new Point(909, 276);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(172, 61);
            updateItemButton.TabIndex = 14;
            updateItemButton.Text = "Изменить";
            updateItemButton.UseVisualStyleBackColor = true;
            updateItemButton.Click += updateItemButton_Click;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Location = new Point(340, 343);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(172, 33);
            deleteOrderButton.TabIndex = 15;
            deleteOrderButton.Text = "Удалить заказ";
            deleteOrderButton.UseVisualStyleBackColor = true;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Location = new Point(909, 343);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(172, 33);
            deleteItemButton.TabIndex = 16;
            deleteItemButton.Text = "Удалить позицию";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // addOrderButton
            // 
            addOrderButton.Location = new Point(340, 382);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(172, 37);
            addOrderButton.TabIndex = 17;
            addOrderButton.Text = "Добавить новый заказ";
            addOrderButton.UseVisualStyleBackColor = true;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // addOrderItemButton
            // 
            addOrderItemButton.Location = new Point(909, 382);
            addOrderItemButton.Name = "addOrderItemButton";
            addOrderItemButton.Size = new Size(172, 37);
            addOrderItemButton.TabIndex = 18;
            addOrderItemButton.Text = "Добавить новую позицию";
            addOrderItemButton.UseVisualStyleBackColor = true;
            addOrderItemButton.Click += addOrderItemButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(1131, 286);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(140, 23);
            searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1131, 316);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(140, 23);
            searchButton.TabIndex = 20;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Location = new Point(1131, 345);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(140, 23);
            clearSearchButton.TabIndex = 21;
            clearSearchButton.Text = "Очистить поиск";
            clearSearchButton.UseVisualStyleBackColor = true;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Location = new Point(12, 3);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(46, 15);
            labelOrders.TabIndex = 22;
            labelOrders.Text = "Заказы";
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Location = new Point(562, 3);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(93, 15);
            labelOrderItems.TabIndex = 23;
            labelOrderItems.Text = "Позиции заказа";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(12, 258);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(40, 15);
            labelDepartment.TabIndex = 24;
            labelDepartment.Text = "Отдел";
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Location = new Point(11, 299);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(54, 15);
            labelOrderId.TabIndex = 25;
            labelOrderId.Text = "Id заказа";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(10, 338);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(43, 15);
            labelStatus.TabIndex = 26;
            labelStatus.Text = "Статус";
            // 
            // labelPickerOrderDate
            // 
            labelPickerOrderDate.AutoSize = true;
            labelPickerOrderDate.Location = new Point(180, 258);
            labelPickerOrderDate.Name = "labelPickerOrderDate";
            labelPickerOrderDate.Size = new Size(122, 15);
            labelPickerOrderDate.TabIndex = 27;
            labelPickerOrderDate.Text = "Дата создания заказа";
            // 
            // labelGivingTheEnd
            // 
            labelGivingTheEnd.AutoSize = true;
            labelGivingTheEnd.Location = new Point(180, 299);
            labelGivingTheEnd.Name = "labelGivingTheEnd";
            labelGivingTheEnd.Size = new Size(97, 15);
            labelGivingTheEnd.TabIndex = 28;
            labelGivingTheEnd.Text = "Дача окончания";
            // 
            // labelSteelGrade
            // 
            labelSteelGrade.AutoSize = true;
            labelSteelGrade.Location = new Point(578, 258);
            labelSteelGrade.Name = "labelSteelGrade";
            labelSteelGrade.Size = new Size(77, 15);
            labelSteelGrade.TabIndex = 29;
            labelSteelGrade.Text = "Марка стали";
            // 
            // labelDiameter
            // 
            labelDiameter.AutoSize = true;
            labelDiameter.Location = new Point(578, 299);
            labelDiameter.Name = "labelDiameter";
            labelDiameter.Size = new Size(55, 15);
            labelDiameter.TabIndex = 30;
            labelDiameter.Text = "Диаметр";
            // 
            // labelWallThickness
            // 
            labelWallThickness.AutoSize = true;
            labelWallThickness.Location = new Point(578, 338);
            labelWallThickness.Name = "labelWallThickness";
            labelWallThickness.Size = new Size(45, 15);
            labelWallThickness.TabIndex = 31;
            labelWallThickness.Text = "Стенка";
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new Point(749, 258);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(45, 15);
            labelVolume.TabIndex = 32;
            labelVolume.Text = "Объем";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(749, 299);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(116, 15);
            labelUnit.TabIndex = 33;
            labelUnit.Text = "Единица измерения\n";
            // 
            // labelItemStatus
            // 
            labelItemStatus.AutoSize = true;
            labelItemStatus.Location = new Point(749, 338);
            labelItemStatus.Name = "labelItemStatus";
            labelItemStatus.Size = new Size(93, 15);
            labelItemStatus.TabIndex = 34;
            labelItemStatus.Text = "Статус позиции";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 503);
            Controls.Add(labelItemStatus);
            Controls.Add(labelUnit);
            Controls.Add(labelVolume);
            Controls.Add(labelWallThickness);
            Controls.Add(labelDiameter);
            Controls.Add(labelSteelGrade);
            Controls.Add(labelGivingTheEnd);
            Controls.Add(labelPickerOrderDate);
            Controls.Add(labelStatus);
            Controls.Add(labelOrderId);
            Controls.Add(labelDepartment);
            Controls.Add(labelOrderItems);
            Controls.Add(labelOrders);
            Controls.Add(clearSearchButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(addOrderItemButton);
            Controls.Add(addOrderButton);
            Controls.Add(deleteItemButton);
            Controls.Add(deleteOrderButton);
            Controls.Add(updateItemButton);
            Controls.Add(updateOrderButton);
            Controls.Add(itemStatusTextBox);
            Controls.Add(unitTextBox);
            Controls.Add(volumeTextBox);
            Controls.Add(wallThicknessTextBox);
            Controls.Add(diameterTextBox);
            Controls.Add(steelGradeTextBox);
            Controls.Add(itemsGridView);
            Controls.Add(dateTimeGivingTheEnd);
            Controls.Add(statusTextBox);
            Controls.Add(orderIdTextBox);
            Controls.Add(dateTimePickerOrderDate);
            Controls.Add(departmentTextBox);
            Controls.Add(ordersGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ordersGridView;
        private TextBox departmentTextBox;
        private DateTimePicker dateTimePickerOrderDate;
        private TextBox orderIdTextBox;
        private TextBox statusTextBox;
        private DateTimePicker dateTimeGivingTheEnd;
        private DataGridView itemsGridView;
        private TextBox steelGradeTextBox;
        private TextBox diameterTextBox;
        private TextBox wallThicknessTextBox;
        private TextBox volumeTextBox;
        private TextBox unitTextBox;
        private TextBox itemStatusTextBox;
        private Button updateOrderButton;
        private Button updateItemButton;
        private Button deleteOrderButton;
        private Button deleteItemButton;
        private Button addOrderButton;
        private Button addOrderItemButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button clearSearchButton;
        private Label labelOrders;
        private Label labelOrderItems;
        private Label labelDepartment;
        private Label labelOrderId;
        private Label labelStatus;
        private Label labelPickerOrderDate;
        private Label labelGivingTheEnd;
        private Label labelSteelGrade;
        private Label labelDiameter;
        private Label labelWallThickness;
        private Label labelVolume;
        private Label labelUnit;
        private Label labelItemStatus;
    }
}
