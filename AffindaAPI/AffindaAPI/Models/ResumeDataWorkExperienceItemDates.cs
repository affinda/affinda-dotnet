// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataWorkExperienceItemDates. </summary>
    public partial class ResumeDataWorkExperienceItemDates
    {
        /// <summary> Initializes a new instance of ResumeDataWorkExperienceItemDates. </summary>
        internal ResumeDataWorkExperienceItemDates()
        {
        }

        /// <summary> Initializes a new instance of ResumeDataWorkExperienceItemDates. </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="monthsInPosition"></param>
        /// <param name="isCurrent"></param>
        internal ResumeDataWorkExperienceItemDates(DateTimeOffset? startDate, DateTimeOffset? endDate, int? monthsInPosition, bool? isCurrent)
        {
            StartDate = startDate;
            EndDate = endDate;
            MonthsInPosition = monthsInPosition;
            IsCurrent = isCurrent;
        }

        /// <summary> Gets the start date. </summary>
        public DateTimeOffset? StartDate { get; }
        /// <summary> Gets the end date. </summary>
        public DateTimeOffset? EndDate { get; }
        /// <summary> Gets the months in position. </summary>
        public int? MonthsInPosition { get; }
        /// <summary> Gets the is current. </summary>
        public bool? IsCurrent { get; }
    }
}
