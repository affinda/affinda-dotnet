// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchDetailEducationValueItem. </summary>
    public partial class ResumeSearchDetailEducationValueItem : Education
    {
        /// <summary> Initializes a new instance of ResumeSearchDetailEducationValueItem. </summary>
        internal ResumeSearchDetailEducationValueItem()
        {
        }

        /// <summary> Initializes a new instance of ResumeSearchDetailEducationValueItem. </summary>
        /// <param name="id"></param>
        /// <param name="organization"></param>
        /// <param name="accreditation"></param>
        /// <param name="grade"></param>
        /// <param name="location"></param>
        /// <param name="dates"></param>
        /// <param name="match"></param>
        internal ResumeSearchDetailEducationValueItem(int? id, string organization, Accreditation accreditation, EducationGrade grade, Location location, EducationDates dates, bool? match) : base(id, organization, accreditation, grade, location, dates)
        {
            Match = match;
        }

        /// <summary> Gets the match. </summary>
        public bool? Match { get; }
    }
}
