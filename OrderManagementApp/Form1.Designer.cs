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
            dateTimePickerDeliveryDate = new DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersGridView
            // 
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(12, 12);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.Size = new Size(544, 232);
            ordersGridView.TabIndex = 0;
            ordersGridView.SelectionChanged += ordersGridView_SelectionChanged;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(12, 261);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(140, 23);
            departmentTextBox.TabIndex = 1;
            departmentTextBox.Text = "Отдел";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(181, 261);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(140, 23);
            dateTimePickerOrderDate.TabIndex = 2;
            // 
            // orderIdTextBox
            // 
            orderIdTextBox.Location = new Point(12, 299);
            orderIdTextBox.Name = "orderIdTextBox";
            orderIdTextBox.Size = new Size(140, 23);
            orderIdTextBox.TabIndex = 3;
            orderIdTextBox.Text = "Id заказа";
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(12, 338);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(140, 23);
            statusTextBox.TabIndex = 4;
            statusTextBox.Text = "Статус";
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Location = new Point(181, 299);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(140, 23);
            dateTimePickerDeliveryDate.TabIndex = 5;
            // 
            // itemsGridView
            // 
            itemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsGridView.Location = new Point(562, 12);
            itemsGridView.Name = "itemsGridView";
            itemsGridView.Size = new Size(747, 232);
            itemsGridView.TabIndex = 6;
            itemsGridView.SelectionChanged += itemsGridView_SelectionChanged;
            // 
            // steelGradeTextBox
            // 
            steelGradeTextBox.Location = new Point(579, 261);
            steelGradeTextBox.Name = "steelGradeTextBox";
            steelGradeTextBox.Size = new Size(140, 23);
            steelGradeTextBox.TabIndex = 7;
            steelGradeTextBox.Text = "Марка стали";
            // 
            // diameterTextBox
            // 
            diameterTextBox.Location = new Point(579, 299);
            diameterTextBox.Name = "diameterTextBox";
            diameterTextBox.Size = new Size(140, 23);
            diameterTextBox.TabIndex = 8;
            diameterTextBox.Text = "Диаметр";
            // 
            // wallThicknessTextBox
            // 
            wallThicknessTextBox.Location = new Point(579, 338);
            wallThicknessTextBox.Name = "wallThicknessTextBox";
            wallThicknessTextBox.Size = new Size(140, 23);
            wallThicknessTextBox.TabIndex = 9;
            wallThicknessTextBox.Text = "Стенка";
            // 
            // volumeTextBox
            // 
            volumeTextBox.Location = new Point(750, 261);
            volumeTextBox.Name = "volumeTextBox";
            volumeTextBox.Size = new Size(140, 23);
            volumeTextBox.TabIndex = 10;
            volumeTextBox.Text = "Объем";
            // 
            // unitTextBox
            // 
            unitTextBox.Location = new Point(750, 299);
            unitTextBox.Name = "unitTextBox";
            unitTextBox.Size = new Size(140, 23);
            unitTextBox.TabIndex = 11;
            unitTextBox.Text = "Единица измерения\n";
            // 
            // itemStatusTextBox
            // 
            itemStatusTextBox.Location = new Point(750, 338);
            itemStatusTextBox.Name = "itemStatusTextBox";
            itemStatusTextBox.Size = new Size(140, 23);
            itemStatusTextBox.TabIndex = 12;
            itemStatusTextBox.Text = "Статус позиции";
            // 
            // updateOrderButton
            // 
            updateOrderButton.Location = new Point(341, 261);
            updateOrderButton.Name = "updateOrderButton";
            updateOrderButton.Size = new Size(172, 61);
            updateOrderButton.TabIndex = 13;
            updateOrderButton.Text = "Изменить";
            updateOrderButton.UseVisualStyleBackColor = true;
            updateOrderButton.Click += updateOrderButton_Click;
            // 
            // updateItemButton
            // 
            updateItemButton.Location = new Point(910, 261);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(172, 61);
            updateItemButton.TabIndex = 14;
            updateItemButton.Text = "Изменить";
            updateItemButton.UseVisualStyleBackColor = true;
            updateItemButton.Click += updateItemButton_Click;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Location = new Point(341, 328);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(172, 33);
            deleteOrderButton.TabIndex = 15;
            deleteOrderButton.Text = "Удалить заказ";
            deleteOrderButton.UseVisualStyleBackColor = true;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Location = new Point(910, 328);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(172, 33);
            deleteItemButton.TabIndex = 16;
            deleteItemButton.Text = "Удалить позицию";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // addOrderButton
            // 
            addOrderButton.Location = new Point(341, 367);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(172, 37);
            addOrderButton.TabIndex = 17;
            addOrderButton.Text = "Добавить новый заказ";
            addOrderButton.UseVisualStyleBackColor = true;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // addOrderItemButton
            // 
            addOrderItemButton.Location = new Point(910, 367);
            addOrderItemButton.Name = "addOrderItemButton";
            addOrderItemButton.Size = new Size(172, 37);
            addOrderItemButton.TabIndex = 18;
            addOrderItemButton.Text = "Добавить новую позицию";
            addOrderItemButton.UseVisualStyleBackColor = true;
            addOrderItemButton.Click += addOrderItemButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(1132, 271);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(140, 23);
            searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1132, 301);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(140, 23);
            searchButton.TabIndex = 20;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Location = new Point(1132, 330);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(140, 23);
            clearSearchButton.TabIndex = 21;
            clearSearchButton.Text = "Очистить поиск";
            clearSearchButton.UseVisualStyleBackColor = true;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 503);
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
            Controls.Add(dateTimePickerDeliveryDate);
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
        private DateTimePicker dateTimePickerDeliveryDate;
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
    }
}
