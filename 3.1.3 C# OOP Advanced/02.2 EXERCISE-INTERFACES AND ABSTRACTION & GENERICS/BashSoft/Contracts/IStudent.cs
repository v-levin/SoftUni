﻿using System.Collections.Generic;

namespace BashSoft.Contracts
{
    public interface IStudent
    {
        string Username { get; }

        IReadOnlyDictionary<string, ICourse> EnrolledCourses { get; }

        IReadOnlyDictionary<string, double> MarksByCourseName { get; }

        void EnrollInCourse(ICourse course);

        void SetMarksInCourse(string courseName, params int[] scores);

        double CalculateMark(int[] scores);
    }
}
