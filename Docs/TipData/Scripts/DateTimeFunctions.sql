create  function DateOnly(@DateTime DateTime)
-- Returns @DateTime at midnight; i.e., it removes the time portion of a DateTime value.
returns datetime
as
    begin
    return dateadd(dd,0, datediff(dd,0,@DateTime))
    end
go

create function Date(@Year int, @Month int, @Day int)
-- returns a datetime value for the specified year, month and day
-- Thank you to Michael Valentine Jones for this formula (see comments).
returns datetime
as
    begin
    return dateadd(month,((@Year-1900)*12)+@Month-1,@Day-1)
    end
go

create function Time(@Hour int, @Minute int, @Second int)
-- Returns a datetime value for the specified time at the "base" date (1/1/1900)
-- Many thanks to MVJ for providing this formula (see comments). 
returns datetime
as
    begin
    return dateadd(ss,(@Hour*3600)+(@Minute*60)+@Second,0)
    end
go

create function TimeOnly(@DateTime DateTime)
-- returns only the time portion of a DateTime, at the "base" date (1/1/1900)
-- Thanks, Peso! 
returns datetime
as
    begin
    return dateadd(day, -datediff(day, 0, @datetime), @datetime)
    end
go

create function DateTime(@Year int, @Month int, @Day int, @Hour int, @Minute int, @Second int)
-- returns a dateTime value for the date and time specified.
returns datetime
as
    begin
    return dbo.Date(@Year,@Month,@Day) + dbo.Time(@Hour, @Minute,@Second)
    end
go

create function TimeSpan(@Days int, @Hours int, @Minutes int, @Seconds int)
-- returns a datetime the specified # of days/hours/minutes/seconds from the "base" date of 1/1/1900 (a "TimeSpan")
returns datetime
as
    begin
    return dbo.Time(@Hours,@Minutes,@Seconds) + @Days
    end
go

create function TimeSpanUnits(@Unit char(1), @TimeSpan datetime)
-- returns the # of units specified in the TimeSpan.
-- The Unit parameter can be: "d" = days, "h" = hours, "m" = minutes, "s" = seconds
returns int
as
    begin
    return case @Unit 
        when 'd' then datediff(day, 0, @TimeSpan)
        when 'h' then datediff(hour, 0, @TimeSpan)
        when 'm' then datediff(minute, 0, @TimeSpan)
        when 's' then datediff(second, 0, @TimeSpan)
        else Null end
    end
go
