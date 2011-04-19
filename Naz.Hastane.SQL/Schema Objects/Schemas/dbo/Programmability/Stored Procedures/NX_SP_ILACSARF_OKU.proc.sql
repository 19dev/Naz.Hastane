


CREATE PROCEDURE NX_SP_ILACSARF_OKU 
( 
  @KOD varchar(15),
  @DEPO_ID varchar(4)
) 
AS
  DECLARE @TANIM varchar(2)
  DECLARE @AKOD  varchar(2)
    
  SELECT @TANIM=CASE(LEFT(@DEPO_ID,2)) WHEN '03' THEN '09' WHEN '04' THEN '16' ELSE '--' END , 
                 @AKOD=RIGHT(@DEPO_ID,2)

	SELECT  [CODE] AS [ID], 
	        [NAME1] AS [ADI], 
	        [GRUP], [TANIM] /*'09' ilaç, '16' SARF*/ ,
		      [CODE] AS [KOD],  
		      [CODE] AS [BARKOD],  
		      [KDV] AS [KDV],		
		      ([TOPGIR]-[TOPCIK]+[DEVIR]) AS [MIKTAR],
		      @DEPO_ID AS [DEPO_ID], 
		      [FIRMA], 
		      [FIRMA] AS [TEDARIKCI],
          [SATISF] AS [SATIS_FIYATI], 
          [ALISF] AS [ALIS_FIYATI]
	FROM [ILACSARF] 
	WHERE [CODE]=@KOD AND 
	      [AKOD]=@AKOD AND 
	      [TANIM]=@TANIM
  ORDER BY [GRUP]


