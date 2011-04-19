







CREATE    PROCEDURE NX_SP_TEDARIKCI_OKU (
  @TEDARIKCI_ID varchar(5)
) AS
	SELECT [KNR] AS [ID], [KNR] AS [KODU], 
        [ADI1] AS [ADI], [FIRMA], [TIPI],
        ([ADRZUS]+' '+[STR]+' '+[PLZ]+' '+[ORT]  ) AS [ADRES]     
    FROM [SATADR]
	WHERE [KNR]=@TEDARIKCI_ID







