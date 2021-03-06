﻿using System;

namespace FluentScheduler.Model
{
    public sealed class TimeUnit
    {
        private readonly Schedule schedule;

        private readonly int duration;

        public TimeUnit(Schedule schedule, int duration)
        {
            this.schedule = schedule;
            this.duration = duration;
        }

        public SecondUnit Seconds()
        {
            return new SecondUnit(this.schedule, this.duration);
        }
        public MinuteUnit Minutes()
        {
            return new MinuteUnit(this.schedule, this.duration);
        }
        public HourUnit Hours()
        {
            return new HourUnit(this.schedule, this.duration);
        }
        public DayUnit Days()
        {
            return new DayUnit(this.schedule, this.duration);
        }
        public WeekdayUnit Weekdays()
        {
            return new WeekdayUnit(this.schedule, this.duration);
        }
        public WeekUnit Weeks()
        {
            return new WeekUnit(this.schedule, this.duration);
        }
        public MonthUnit Months()
        {
            return new MonthUnit(this.schedule, this.duration);
        }
        public YearUnit Years()
        {
            return new YearUnit(this.schedule, this.duration);
        }
    }
}
