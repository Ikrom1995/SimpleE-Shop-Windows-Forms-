using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.DAL
{
    public class OrderingRepository
    {

        private static OrderingRepository Instance { get; set; }

        //method to access OrderingRespository
        //Implements Singleton
        public static OrderingRepository getInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new OrderingRepository();
                return Instance;
            }
        }

        //Get all products from database
        public List<OrderManagement.DAL.ProductsTable> GetProducts()
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.ProductsTable> products = new List<OrderManagement.DAL.ProductsTable>();
                foreach (var c in ct.ProductsTable)
                {
                    OrderManagement.DAL.ProductsTable product = new OrderManagement.DAL.ProductsTable()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Category = c.Category,
                        SubCategory = c.SubCategory,
                        Brand = c.Brand,
                        Description = c.Description,
                        Price = c.Price
                    };
                    products.Add(product);
                }
                return products;
            }
        }

        //Get products from database by product category
        public List<OrderManagement.DAL.ProductsTable> GetProductsByCategory(String category)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.ProductsTable> products = new List<OrderManagement.DAL.ProductsTable>();
                foreach (var c in ct.ProductsTable.Where(c => c.Category == category))
                {
                    OrderManagement.DAL.ProductsTable product = new OrderManagement.DAL.ProductsTable()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Category = c.Category,
                        SubCategory = c.SubCategory,
                        Brand = c.Brand,
                        Description = c.Description,
                        Price = c.Price
                    };
                    products.Add(product);
                }
                return products;
            }
        }

        //Get products from database by subcategory
        public List<OrderManagement.DAL.ProductsTable> GetProductsBySubCategory(String subCategory)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.ProductsTable> products = new List<OrderManagement.DAL.ProductsTable>();
                foreach (var c in ct.ProductsTable.Where(c => c.SubCategory == subCategory))
                {
                    OrderManagement.DAL.ProductsTable product = new OrderManagement.DAL.ProductsTable()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Category = c.Category,
                        SubCategory = c.SubCategory,
                        Brand = c.Brand,
                        Description = c.Description,
                        Price = c.Price
                    };
                    products.Add(product);
                }
                return products;
            }
        }

        //adds product to the database
        public void AddProduct(OrderManagement.DAL.ProductsTable product)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                ct.ProductsTable.Add(product);
                ct.SaveChanges();
            }
        }

        //edit product in database
        public void EditProduct(OrderManagement.DAL.ProductsTable product)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                ct.Entry(product).State = System.Data.EntityState.Modified;
                ct.SaveChanges();
            }
        }

        //get all orders from database
        public List<OrderManagement.DAL.OrdersTable> GetOrders()
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrdersTable> orders = new List<OrderManagement.DAL.OrdersTable>();
                foreach (var c in ct.OrdersTable)
                {
                    OrderManagement.DAL.OrdersTable order = new OrderManagement.DAL.OrdersTable()
                    {
                        OrderNumber = c.OrderNumber,
                        OrderDate = c.OrderDate,
                        DeliveryAddress = c.DeliveryAddress,
                        OrderStatus = c.OrderStatus,
                        Total = c.Total
                    };
                    orders.Add(order);
                }
                return orders;
            }
        }

        //get orders from database by order status
        public List<OrderManagement.DAL.OrdersTable> GetOrders(String s)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrdersTable> orders = new List<OrderManagement.DAL.OrdersTable>();
                foreach (var c in ct.OrdersTable.Where(c => c.OrderStatus == s))
                {
                    OrderManagement.DAL.OrdersTable order = new OrderManagement.DAL.OrdersTable()
                    {
                        OrderNumber = c.OrderNumber,
                        OrderDate = c.OrderDate,
                        DeliveryAddress = c.DeliveryAddress,
                        OrderStatus = c.OrderStatus,
                        Total = c.Total
                    };
                    orders.Add(order);
                }
                return orders;
            }
        }

        //gets all processed orders from database
        public List<OrderManagement.DAL.OrdersTable> GetProcessedOrders()
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrdersTable> orders = new List<OrderManagement.DAL.OrdersTable>();
                foreach (var c in ct.OrdersTable.Where(c => c.OrderStatus == "Processed"))
                {
                    OrderManagement.DAL.OrdersTable order = new OrderManagement.DAL.OrdersTable()
                    {
                        OrderNumber = c.OrderNumber,
                        OrderDate = c.OrderDate,
                        DeliveryAddress = c.DeliveryAddress,
                        OrderStatus = c.OrderStatus,
                        Total = c.Total
                    };
                    orders.Add(order);
                }
                return orders;
            }
        }

        //gets processed orders between indicated dates min and max
        public List<OrderManagement.DAL.OrdersTable> GetProcessedOrders(DateTime min, DateTime max)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrdersTable> orders = new List<OrderManagement.DAL.OrdersTable>();
                foreach (var c in ct.OrdersTable.Where(c => c.OrderDate >= min && c.OrderDate <= max && c.OrderStatus == "Processed"))
                {
                    OrderManagement.DAL.OrdersTable order = new OrderManagement.DAL.OrdersTable()
                    {
                        OrderNumber = c.OrderNumber,
                        OrderDate = c.OrderDate,
                        DeliveryAddress = c.DeliveryAddress,
                        OrderStatus = c.OrderStatus,
                        Total = c.Total
                    };
                    orders.Add(order);
                }
                return orders;
            }
        }

        //sort orders by date
        public List<OrderManagement.DAL.OrdersTable> GetOrdersByDate(String date)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrdersTable> orders = new List<OrderManagement.DAL.OrdersTable>();
                foreach (var c in ct.OrdersTable)
                {
                    OrderManagement.DAL.OrdersTable order = new OrderManagement.DAL.OrdersTable()
                    {
                        OrderNumber = c.OrderNumber,
                        OrderDate = c.OrderDate,
                        DeliveryAddress = c.DeliveryAddress,
                        OrderStatus = c.OrderStatus,
                        Total = c.Total
                    };
                    orders.Add(order);
                }
                if (date == "Ascending")
                {
                    orders.Sort((x, y) => DateTime.Compare(x.OrderDate, y.OrderDate));
                }
                else if (date == "Descending")
                {
                    orders.Sort((x, y) => DateTime.Compare(y.OrderDate, x.OrderDate));
                }                
                return orders;
            }
        }

        //adds order to teh database
        public void AddOrder(OrderManagement.DAL.OrdersTable order)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                ct.OrdersTable.Add(order);
                ct.SaveChanges();
            }
        }

        //edits order in database
        public void EditOrder(OrderManagement.DAL.OrdersTable order)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                ct.Entry(order).State = System.Data.EntityState.Modified;
                ct.SaveChanges();
            }
        }

        //deletes order from database
        public void DeleteOrder(OrderManagement.DAL.OrdersTable order)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                OrdersTable or = ct.OrdersTable.First(t => t.OrderNumber == order.OrderNumber);

                //OrdersTable ord = new OrdersTable() { OrderNumber = order.OrderNumber };
                ct.Entry(or).State = System.Data.EntityState.Deleted;
                ct.SaveChanges();

            }
        }
        //method for getting all order lines
        //does not used as there is no need to get all order lists
        public List<OrderManagement.DAL.OrderLinesTable> GetOrderLines()
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrderLinesTable> orderLines = new List<OrderManagement.DAL.OrderLinesTable>();
                foreach (var c in ct.OrderLinesTable)
                {
                    //LibraryClasses.UserType userType = new LibraryClasses.UserType()
                    OrderManagement.DAL.OrderLinesTable orderLine = new OrderManagement.DAL.OrderLinesTable()
                    {
                        Id = c.Id,
                        ProductID = c.ProductID,
                        QuantityOrdered = c.QuantityOrdered,
                        SellingPrice = c.SellingPrice,
                        OrderNumber = c.OrderNumber,
                        TotalForItem = c.TotalForItem
                    };
                    orderLines.Add(orderLine);
                }
                return orderLines;
            }
        }

        //gets order lines of current order
        public List<OrderManagement.DAL.OrderLinesTable> GetOrderLines(OrdersTable order)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                List<OrderManagement.DAL.OrderLinesTable> orderLines = new List<OrderManagement.DAL.OrderLinesTable>();

                //return orderLines.Where(c => c.OrdersTable == order).ToList();

                foreach (var c in ct.OrderLinesTable.Where(c => c.OrdersTable.OrderNumber == order.OrderNumber))
                {
                    //LibraryClasses.UserType userType = new LibraryClasses.UserType()
                    OrderManagement.DAL.OrderLinesTable orderLine = new OrderManagement.DAL.OrderLinesTable()
                    {
                        Id = c.Id,
                        ProductID = c.ProductID,
                        QuantityOrdered = c.QuantityOrdered,
                        SellingPrice = c.SellingPrice,
                        OrderNumber = c.OrderNumber,
                        TotalForItem = c.TotalForItem
                    };
                    orderLines.Add(orderLine);
                }
                return orderLines;
            }
        }

        //adds order line
        public void AddOrderLine(OrderManagement.DAL.OrderLinesTable orderLine)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                ct.ProductsTable.Attach(orderLine.ProductsTable);
                ct.OrdersTable.Attach(orderLine.OrdersTable);

                ct.OrderLinesTable.Add(orderLine);
                ct.SaveChanges();
            }
        }

        //method for editing order line
        //not used as order lines never edited
        //instead they are deleted and added
        public void EditOrderLine(OrderLinesTable editOrderLine)
        {
            using (OrderManagementDBEntities editLine = new OrderManagementDBEntities())
            {
                OrderLinesTable el = editLine.OrderLinesTable.First(t => t.Id == editOrderLine.Id);
                el.QuantityOrdered = editOrderLine.QuantityOrdered;
                el.TotalForItem = editOrderLine.QuantityOrdered * el.SellingPrice;

                editLine.Entry(el).State = System.Data.EntityState.Modified;
                editLine.SaveChanges();
            }
        }

        //deletes orderline from database
        public void DeleteOrderLine(OrderManagement.DAL.OrderLinesTable orderLine)
        {
            using (OrderManagementDBEntities ct = new OrderManagementDBEntities())
            {
                OrderLinesTable or = ct.OrderLinesTable.First(t => t.Id == orderLine.Id);

                ct.Entry(or).State = System.Data.EntityState.Deleted;
                ct.SaveChanges();

            }
        }
    }

    public enum Category
    {
        Computers = 0,
        Accessory = 1,
        Software = 2
    }

    public enum ComputersSubCategory
    {
        Desktops = 1,
        Notebooks = 2,
        Netbooks = 3,
        Tablets = 4
    }

    public enum AccessorySubCategory
    {
        Printers = 5,
        Scanners = 6,
        Web_Cameras = 7
    }

    public enum SoftwareSubCategory
    {
        Operation_Systems = 8,
        Antiviruses = 9,
        Office_Packages = 10
    }

    public enum OrderStatus
    {
        Open = 1,
        Processed = 2,
        Canceled = 3
    }
}
