select YEAR(OrderDate) AS Year, state
from Orders,Products
order by 1

Declare  @OrderDate Date = 2018;
select YEAR(OrderDate) AS Year, State, sum(sales) AS TotalSales
from Orders,Products 
where YEAR(OrderDate)= @OrderDate
Group By State

select state, sum(sales) AS Sales, YEAR(OrderDate) AS YEAR
from Orders,Products
Group BY YEAR(OrderDate) Order By 1

select State,Sales,YEAR(OrderDate) AS YEAR 
from Orders,Products

select *from Products