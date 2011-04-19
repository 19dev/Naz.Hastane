

CREATE PROCEDURE [dbo].[sp_FaturaKapat] @FaturaID varchar(2000),@A_K varchar(1)
AS
if @A_K = 'K'
begin
update Fatura
set ISODENDI = 1
where Fatura_ID in (select datavalue from strtotable(@FaturaID,','))
end

if @A_K = 'A'
begin
update Fatura
set ISODENDI =  null
where Fatura_ID in (select datavalue from strtotable(@FaturaID,','))
end

