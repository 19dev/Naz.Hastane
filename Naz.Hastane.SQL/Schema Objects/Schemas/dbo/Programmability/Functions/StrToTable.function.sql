﻿



CREATE FUNCTION StrToTable
(	@StrToSplit 	VARCHAR(8000),
	@Delimiter 	CHAR(1)
)
RETURNS @SplitTable Table 
(	DataValue	int,
	ValueAt		Numeric(9,0) IDENTITY(1,1)
)
AS  
BEGIN 
DECLARE @value varchar(2000), @end integer, @start integer
  IF LEN(@StrToSplit) = 0 
     RETURN
	SET @Delimiter = LTRIM(RTRIM(@Delimiter))
	SET @start = 1
	SET @end = 
           CHARINDEX(@Delimiter, @StrToSplit, @start )
  IF @end = 0 
  BEGIN
     SET @value = SUBSTRING(@StrToSplit, @start, LEN(@StrToSplit))
     INSERT INTO @SplitTable SELECT @value
  END
  ELSE BEGIN
  	 WHILE @end >= 0
  	 BEGIN	
    		SET @value = SUBSTRING(@StrToSplit, @start, ABS(@end - @start) )
    		INSERT INTO @SplitTable SELECT @value 
    		IF @end = 0 BREAK

    		SET @start = @end + 1
    		SET @end = CHARINDEX(@Delimiter, @StrToSplit, @start)
  	 END
 END
 RETURN 
END






