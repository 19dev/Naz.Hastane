-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[udf_ComputeDiff]
(
	@In1 float,
	@In2 float
)
RETURNS float
AS
BEGIN
	declare @Out float
	
	if isnull(@In2,0) = 0
		set @Out = 0
	else
		set @Out = (@In1 - @In2) / @In2;
	
	return @Out	
	
END
