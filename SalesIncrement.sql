select Sales,YEAR(OrderDate) AS YEAR 
from Orders,Products

--Declare @IncrementPercentage Decimal(5,2) = 10.00

--DECLARE @SelectedYear INT = 2023;
--DECLARE @IncrementPercentage DECIMAL(5, 2) = 10.00; -- 10%
Declare @IncrementPercentage Decimal(5,2) = 10.00
   select     State, 
       sales AS ActualSales, 
       sales * @IncrementPercentage /100 AS IncrementSales,
	   sales + (sales * @IncrementPercentage /100) AS SalesAfterIncrement
from Orders,Products

select state, 
      percentageIncrease, 
	  Salesvalue * (1 + PercentageIncrease /100.0) AS ForescastedSalesValue
	  from Forecasted_Data
       