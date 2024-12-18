using OrderManagementApp.Models;

namespace OrderManagementApp
{
    public partial class Form1 :Form
    {
        private List<Order> orders;

        public Form1()
        {
            InitializeComponent();
            LoadOrders(); // Загрузка заказов
            ordersGridView.ReadOnly = true;
            itemsGridView.ReadOnly = true;
        }

        // Загружаем данные для заказов
        private void LoadOrders()
        {
            // Загрузка данных (здесь можно подключить к базе данных или просто задать список)
           
            orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Department = "Отдел 1",
                    Status = "В процессе",
                    OrderDate = DateTime.Now,
                    DeliveryDate = DateTime.Now.AddDays(5),
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            Id = 1,
                            SteelGrade = "Grade A",
                            Diameter = 10,
                            WallThickness = 1,
                            Volume = 100,
                            Unit = "м3",
                            Status = "Новая"
                        },
                        new OrderItem
                        {
                            Id = 2,
                            SteelGrade = "Grade B",
                            Diameter = 12,
                            WallThickness = 1.2,
                            Volume = 150,
                            Unit = "м3",
                            Status = "Новая"
                        }
                    }
                },
                new Order
                {
                    Id = 2,
                    Department = "Отдел 2",
                    Status = "Завершено",
                    OrderDate = DateTime.Now.AddDays(-10),
                    DeliveryDate = DateTime.Now.AddDays(-5),
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            Id = 3,
                            SteelGrade = "Grade C",
                            Diameter = 14,
                            WallThickness = 1.5,
                            Volume = 200,
                            Unit = "м3",
                            Status = "Выполнена"
                        }
                    }
                },
                new Order
                {
                    Id = 3,
                    Department = "Отдел 3",
                    Status = "Отменено",
                    OrderDate = DateTime.Now.AddDays(-20),
                    DeliveryDate = DateTime.Now.AddDays(-15),
                    Items = new List<OrderItem>
                    {
                        new OrderItem
                        {
                            Id = 4,
                            SteelGrade = "Grade D",
                            Diameter = 16,
                            WallThickness = 1.8,
                            Volume = 250,
                            Unit = "м3",
                            Status = "Отменена"
                        }
                    }
                }
            };

            ordersGridView.DataSource = orders;
        }
  
        private void ordersGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedOrder = ordersGridView.CurrentRow?.DataBoundItem as Order;
                if(selectedOrder != null)
                {
                    // Отображаем позиции выбранного заказа в DataGridView
                    itemsGridView.DataSource = selectedOrder.Items;

                    // Заполняем TextBox с данными заказа
                    departmentTextBox.Text = selectedOrder.Department;
                    orderIdTextBox.Text = selectedOrder.Id.ToString();
                    statusTextBox.Text = selectedOrder.Status;
                    dateTimePickerOrderDate.Value = selectedOrder.OrderDate;
                    dateTimePickerDeliveryDate.Value = selectedOrder.DeliveryDate;
                }
            }
            catch(System.IndexOutOfRangeException)
            {

            }
        }

        // Обработчик для выбора позиции
        private void itemsGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = itemsGridView.CurrentRow?.DataBoundItem as OrderItem;
                if(selectedItem != null)
                {
                    // Заполняем TextBox с данными позиции
                    steelGradeTextBox.Text = selectedItem.SteelGrade;
                    diameterTextBox.Text = selectedItem.Diameter.ToString();
                    wallThicknessTextBox.Text = selectedItem.WallThickness.ToString();
                    volumeTextBox.Text = selectedItem.Volume.ToString();
                    unitTextBox.Text = selectedItem.Unit;
                    itemStatusTextBox.Text = selectedItem.Status;
                }
            }
            catch(System.IndexOutOfRangeException)
            {

            }
        }

        private void updateOrderButton_Click(object sender, EventArgs e)
        {
            var selectedOrder = ordersGridView.CurrentRow?.DataBoundItem as Order;
            if(selectedOrder != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите изменить этот заказ?", "Подтверждение изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    selectedOrder.Department = departmentTextBox.Text;
                    selectedOrder.Status = statusTextBox.Text;
                    selectedOrder.OrderDate = dateTimePickerOrderDate.Value;
                    selectedOrder.DeliveryDate = dateTimePickerDeliveryDate.Value;

                    ordersGridView.Refresh();
                }
            }
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = itemsGridView.CurrentRow?.DataBoundItem as OrderItem;
            if(selectedItem != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите изменить эту позицию?", "Подтверждение изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    selectedItem.SteelGrade = steelGradeTextBox.Text;
                    selectedItem.Diameter = Convert.ToDouble(diameterTextBox.Text);
                    selectedItem.WallThickness = Convert.ToDouble(wallThicknessTextBox.Text);
                    selectedItem.Volume = Convert.ToDouble(volumeTextBox.Text);
                    selectedItem.Unit = unitTextBox.Text;
                    selectedItem.Status = itemStatusTextBox.Text;

                    itemsGridView.Refresh();
                }
            }
        }
        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            var selectedOrder = ordersGridView.CurrentRow?.DataBoundItem as Order;
            if(selectedOrder != null)
            {
                if(ordersGridView.Rows.Count == 1)
                {
                    MessageBox.Show("Выбранный заказ нельзя удалить - последний заказ (для удаления добавьте новый заказ)", "Запрет удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                 
                    var result = MessageBox.Show("Вы уверены, что хотите удалить этот заказ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(result == DialogResult.Yes)
                    {
                        orders.Remove(selectedOrder);

                        ordersGridView.DataSource = null;
                        ordersGridView.DataSource = orders;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = itemsGridView.CurrentRow?.DataBoundItem as OrderItem;
            if(selectedItem != null)
            {
                if(itemsGridView.Rows.Count == 1)
                {
                    MessageBox.Show("Выбранную позицию нельзя удалить - последняя позиция (для удаления добавьте новую позицию)", "Запрет удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var result = MessageBox.Show("Вы уверены, что хотите удалить эту позицию?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(result == DialogResult.Yes)
                    {
                        var selectedOrder = ordersGridView.CurrentRow?.DataBoundItem as Order;
                        if(selectedOrder != null)
                        {
                            selectedOrder.Items.Remove(selectedItem);
                        }

                        itemsGridView.DataSource = null;
                        itemsGridView.DataSource = selectedOrder?.Items;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите позицию для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            var department = departmentTextBox.Text;
            var status = statusTextBox.Text;
            var orderDate = dateTimePickerOrderDate.Value;
            var deliveryDate = dateTimePickerDeliveryDate.Value;

            var newOrder = new Order
            {
                Id = orders.Count + 1, 
                Department = department,
                Status = status,
                OrderDate = orderDate,
                DeliveryDate = deliveryDate,
                Items = new List<OrderItem>() 
            };

            // Добавляем новую позицию в заказ 
            var newItem = new OrderItem
            {
                Id = 1, // ID первой позиции 
                SteelGrade = "Grade A", 
                Diameter = 10, 
                WallThickness = 1,
                Volume = 100,
                Unit = "м3",
                Status = "Новая"
            };

            newOrder.Items.Add(newItem);
            orders.Add(newOrder);

            ordersGridView.DataSource = null; // Очищаем источник данных
            ordersGridView.DataSource = orders; // Присваиваем обновленный список заказов

            itemsGridView.DataSource = newOrder.Items;
        }


        private void addOrderItemButton_Click(object sender, EventArgs e)
        {
            // Проверим, выбран ли заказ
            var selectedOrder = ordersGridView.CurrentRow?.DataBoundItem as Order;
            if(selectedOrder == null)
            {
                MessageBox.Show("Пожалуйста, выберите заказ для добавления позиции.");
                return;
            }

            // Собираем данные из TextBox-ов
            var steelGrade = steelGradeTextBox.Text;
            var diameter = double.TryParse(diameterTextBox.Text, out double d) ? d : 0;
            var wallThickness = double.TryParse(wallThicknessTextBox.Text, out double w) ? w : 0;
            var volume = double.TryParse(volumeTextBox.Text, out double v) ? v : 0;
            var unit = unitTextBox.Text;
            var status = itemStatusTextBox.Text;

            int id = 0;
            if(selectedOrder.Items.Count > 0)
            {
                id = selectedOrder.Items.Last().Id + 1;
            }
            else
            {
                id = 1;
            }
    
            var newItem = new OrderItem
            {
                Id = id, // Присваиваем новый уникальный ID
                SteelGrade = steelGrade,
                Diameter = diameter,
                WallThickness = wallThickness,
                Volume = volume,
                Unit = unit,
                Status = status
            };
                      
            selectedOrder.Items.Add(newItem);

         
            itemsGridView.DataSource = null; 
            itemsGridView.DataSource = selectedOrder.Items;           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.ToLower();
          
            var filteredOrders = orders.Where(order =>
                order.Department.ToLower().Contains(searchQuery) || // Поиск по цеху-производителю
                order.Items.Any(item =>
                    item.SteelGrade.ToLower().Contains(searchQuery) || // Поиск по марке стали
                    item.Diameter.ToString().Contains(searchQuery) || // Поиск по диаметру
                    item.WallThickness.ToString().Contains(searchQuery) || // Поиск по толщине стенки
                    item.Volume.ToString().Contains(searchQuery) || // Поиск по объему
                    item.Unit.ToLower().Contains(searchQuery) || // Поиск по единице измерения
                    item.Status.ToLower().Contains(searchQuery) // Поиск по статусу позиции
                )
            ).ToList();

            ordersGridView.DataSource = null; 
            ordersGridView.DataSource = filteredOrders; 
             
            if(ordersGridView.SelectedRows.Count > 0)
            {
                var selectedOrder = ordersGridView.SelectedRows[0].DataBoundItem as Order;
                if(selectedOrder != null)
                {
                    itemsGridView.DataSource = selectedOrder.Items; 
                }
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {           
            searchTextBox.Clear();
                       
            ordersGridView.DataSource = null;
            ordersGridView.DataSource = orders; 
         
            if(ordersGridView.SelectedRows.Count > 0)
            {
                var selectedOrder = ordersGridView.SelectedRows[0].DataBoundItem as Order;
                if(selectedOrder != null)
                {
                    itemsGridView.DataSource = selectedOrder.Items; 
                }
            }
        }
    }
}
