select *from Products

select *from Products where sales = 3.928

select Sum(Sales) AS TotalSales from Products where YEAR(SalesDate) = @Year

--As a user I should be able to query for the sales of a specific year and display the value of the sales of the selected year in the screen.

select YEAR(OrderDate) AS Year, Sum(Sales) AS Sales 
from Orders, Products
Group BY YEAR(OrderDate) Order By 1

select YEAR(OrderDate) AS Year, Sum(Sales) AS Sales, Count(Sales) AS TotalSales
from Orders, Products
Group BY YEAR(OrderDate) Order By 1

select state from Orders

select YEAR(OrderDate) AS Year, state
from Orders,Products
order by 1