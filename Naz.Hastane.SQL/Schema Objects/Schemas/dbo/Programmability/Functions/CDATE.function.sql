


CREATE FUNCTION CDATE(@dt datetime)
RETURNS datetime AS  
BEGIN 
RETURN cast(floor(cast(@dt AS float)) AS datetime)
END


