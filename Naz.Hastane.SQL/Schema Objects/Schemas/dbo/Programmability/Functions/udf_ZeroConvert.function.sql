
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[udf_ZeroConvert]
(
	@In float
)
RETURNS float
AS
BEGIN
	declare @Out float
	if @In is null
		set @Out = 1
	else
	begin
	if @In = 0
		set @Out = 1
	else
	begin
		set @Out = @In;
	end
	end
	return @Out
END

