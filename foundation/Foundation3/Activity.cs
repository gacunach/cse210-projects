using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min): " +
               $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
    }


    protected int Duration => _duration;
}