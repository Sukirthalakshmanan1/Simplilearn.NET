use Northwind
Select CustomerID from Customers;
go

Select Count(*) from Employees;

go

Select max(productID) from Products;
--1
go
Select count(ContactName) from Customers;
--2
go
Select count(ContactName) as count1 from Customers where ContactName like 'b%';
--3
go
Select count(ContactName) as count2 from Customers where ContactName like '%s%';
--4
go
Select City,count(ContactName) as count1 from Customers group by City;
--5
go
Select top 3 City,count(ContactName) as count1 from Customers group by City order by count1 desc;
--6
go
Select * from Customers where CustomerID in (Select top 1 CustomerId from Orders group by CustomerID order by count(OrderID) desc);
--7
go
Select * from Customers where CustomerID in (Select top 1 CustomerId from Orders where year(ShippedDate)=1997  group by CustomerID order by count(OrderID) desc);
--8
go
Select top 3 ShipCountry,count(OrderId) as count1 from Orders group by ShipCountry order by count1 desc;
--9 
go
Select top 1 ShipName,count(OrderId) as count1 from Orders group by ShipName order by count1 desc; 
--10
go
Select i.EmployeeID,i.FirstName,i.LastName,i.Reportsto,j.FirstName,j.LastName from Employees i inner join Employees j on i.ReportsTo=j.EmployeeID
--11
go
Select LastName from Employees where DATENAME(Month,BirthDate)='November'
--12
go
Select LastName,FirstName,Region from Employees  order by 3,1
--13
go
Select * from Products where UnitPrice*UnitsOnOrder in (Select max(UnitPrice*UnitsOnOrder) from Products)
--14
go
Select * from Products where UnitPrice*UnitsOnOrder in (Select min(UnitPrice*UnitsOnOrder) from Products where UnitsOnOrder<>0)
--15
go
Select top 1 DATENAME(Month,OrderDate),count(Month(OrderDate)) as count1 from Orders group by DATENAME(Month,OrderDate) order by count1 desc
--16
go
Select * from Employees where EmployeeID in (Select top 1 EmployeeID from Orders group by EmployeeID order by count(OrderId) desc);
--17
go
Select ProductID,ProductName,SupplierID,CategoryID from Products order by CategoryID desc
--18
go
Select region,count(EmployeeID) from employees group by Region
--19
go

Select ShipRegion,sum(freight) as dollars from Orders group by ShipRegion
--20
go
Select avg(freight) as average from orders
--21
go
Select * from orders where freight > any(Select avg(freight) as average from orders)
--22
go
Select k.CustomerID,k.ContactName,sum(l.freight) as totalsale from customers k inner join orders l on k.CustomerID=l.CustomerID group by k.CustomerID,k.ContactName order by totalsale desc
--23
go
Select ProductName,ReorderLevel from Products where ReorderLevel<>0 and Discontinued=0 order by ReorderLevel desc
--24
go
Select CustomerID,ContactName from Customers where CustomerID in (Select distinct(CustomerID) from Orders where Year(ShippedDate)=1996)
--25
go
Select CustomerID,ContactName from Customers where CustomerID in (Select distinct(CustomerID) from Orders where Year(ShippedDate)<>1996)
