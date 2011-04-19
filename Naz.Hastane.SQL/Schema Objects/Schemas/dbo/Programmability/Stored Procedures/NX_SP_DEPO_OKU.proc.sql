











CREATE        PROCEDURE NX_SP_DEPO_OKU
	(
		@DEPO_ID varchar(4)
	)
AS
    DECLARE @TANIM varchar(2)
    DECLARE @AKOD  varchar(2)

    SELECT @TANIM=LEFT(@DEPO_ID,2), @AKOD=RIGHT(@DEPO_ID,2)

 	SELECT @DEPO_ID AS [ID], T.[SLT] AS [ADI], '' AS [ADRES] 
    FROM [KEYDAT] T 
	WHERE T.[SLK]=@TANIM AND T.[SLB]=@AKOD









