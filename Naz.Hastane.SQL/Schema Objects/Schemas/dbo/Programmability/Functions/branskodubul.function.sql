



CREATE FUNCTION branskodubul (@Butkod int)  
RETURNS varchar(4)
AS
BEGIN 
declare @durum varchar(4)

set @durum = 
case 
        when @butkod >= 700000 and @butkod <= 800000  then '3800'
        when @butkod >= 801560 and @butkod <= 804510  then '3300'
        when @butkod >= 900010 and @butkod <= 904230  then '3700'
        when @butkod >= 904240 and @butkod <= 905580  then '3700'
        when @butkod >= 905590 and @butkod <= 906300  then '3800'
        when @butkod >= 906310 and @butkod <= 908110  then '3800'
        when @butkod >= 908120 and @butkod <= 908430  then '3800'
        when @butkod >= 908440 and @butkod <= 908690  then '3600'
        when @butkod >= 908700 and @butkod <= 909200  then '3600'
        when @butkod >= 909210 and @butkod <= 909310  then '3500'
        when @butkod >= 909400 and @butkod <= 911260  then '3500'       
        else '0'      
end


return(@durum)

end






