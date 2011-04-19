



CREATE FUNCTION NX_F_CDATE (@dt datetime)  
RETURNS datetime AS  
BEGIN 
	return cast(floor(cast(@dt as float)) as datetime)
END




