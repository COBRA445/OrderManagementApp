using OrderManagementApp.Models;

namespace OrderManagementApp
{
    public partial class Form1 :Form
    {
        private List<Order> orders;

        public Form1()
        {
            InitializeComponent();
            LoadOrders(); // �������� �������
            ordersGridView.ReadOnly = true;
            itemsGridView.ReadOnly = true;
        }

        // ��������� ������ ��� �������
        private void LoadOrders()
        {
            // �������� ������ (����� ����� ���������� � ���� ������ ��� ������ ������ ������)
           
            orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Department = "����� 1",
                    Status = "� ��������",
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
                            Unit = "�3",
                            Status = "�����"
                        },
                        new OrderItem
                        {
                            Id = 2,
                            SteelGrade = "Grade B",
                            Diameter = 12,
                            WallThickness = 1.2,
                            Volume = 150,
                            Unit = "�3",
                            Status = "�����"
                        }
                    }
                },
                new Order
                {
                    Id = 2,
                    Department = "����� 2",
                    Status = "���������",
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
                            Unit = "�3",
                            Status = "���������"
                        }
                    }
                },
                new Order
                {
                    Id = 3,
                    Department = "����� 3",
                    Status = "��������",
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
                            Unit = "�3",
                            Status = "��������"
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
                    // ���������� ������� ���������� ������ � DataGridView
                    itemsGridView.DataSource = selectedOrder.Items;

                    // ��������� TextBox � ������� ������
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

        // ���������� ��� ������ �������
        private void itemsGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = itemsGridView.CurrentRow?.DataBoundItem as OrderItem;
                if(selectedItem != null)
                {
                    // ��������� TextBox � ������� �������
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
                var result = MessageBox.Show("�� �������, ��� ������ �������� ���� �����?", "������������� ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                var result = MessageBox.Show("�� �������, ��� ������ �������� ��� �������?", "������������� ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                    MessageBox.Show("��������� ����� ������ ������� - ��������� ����� (��� �������� �������� ����� �����)", "������ ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                 
                    var result = MessageBox.Show("�� �������, ��� ������ ������� ���� �����?", "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                MessageBox.Show("����������, �������� ����� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = itemsGridView.CurrentRow?.DataBoundItem as OrderItem;
            if(selectedItem != null)
            {
                if(itemsGridView.Rows.Count == 1)
                {
                    MessageBox.Show("��������� ������� ������ ������� - ��������� ������� (��� �������� �������� ����� �������)", "������ ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var result = MessageBox.Show("�� �������, ��� ������ ������� ��� �������?", "������������� ��������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                MessageBox.Show("����������, �������� ������� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // ��������� ����� ������� � ����� 
            var newItem = new OrderItem
            {
                Id = 1, // ID ������ ������� 
                SteelGrade = "Grade A", 
                Diameter = 10, 
                WallThickness = 1,
                Volume = 100,
                Unit = "�3",
                Status = "�����"
            };

            newOrder.Items.Add(newItem);
            orders.Add(newOrder);

            ordersGridView.DataSource = null; // ������� �������� ������
            ordersGridView.DataSource = orders; // ����������� ����������� ������ �������

            itemsGridView.DataSource = newOrder.Items;
        }


        private void addOrderItemButton_Click(object sender, EventArgs e)
        {
            // ��������, ������ �� �����
            var selectedOrder = ordersGridView.CurrentRow?.DataBoundItem as Order;
            if(selectedOrder == null)
            {
                MessageBox.Show("����������, �������� ����� ��� ���������� �������.");
                return;
            }

            // �������� ������ �� TextBox-��
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
                Id = id, // ����������� ����� ���������� ID
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
                order.Department.ToLower().Contains(searchQuery) || // ����� �� ����-�������������
                order.Items.Any(item =>
                    item.SteelGrade.ToLower().Contains(searchQuery) || // ����� �� ����� �����
                    item.Diameter.ToString().Contains(searchQuery) || // ����� �� ��������
                    item.WallThickness.ToString().Contains(searchQuery) || // ����� �� ������� ������
                    item.Volume.ToString().Contains(searchQuery) || // ����� �� ������
                    item.Unit.ToLower().Contains(searchQuery) || // ����� �� ������� ���������
                    item.Status.ToLower().Contains(searchQuery) // ����� �� ������� �������
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
