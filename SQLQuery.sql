SELECT Products.Name, Categories.Name FROM Products
LEFT JOIN Products_Categories 
ON Products.Id = Products_Categories.ProductId
LEFT JOIN Categories 
ON Products_Categories.CategoryId = Categories.Id