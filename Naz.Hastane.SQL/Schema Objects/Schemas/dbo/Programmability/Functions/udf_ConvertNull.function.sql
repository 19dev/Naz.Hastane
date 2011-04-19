
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[udf_ConvertNull]
(
	@In float
)
RETURNS float
AS
BEGIN
	return ISNULL(@In, 0)
END

