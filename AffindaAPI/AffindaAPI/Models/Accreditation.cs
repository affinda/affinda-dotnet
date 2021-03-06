// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The Accreditation. </summary>
    public partial class Accreditation
    {
        /// <summary> Initializes a new instance of Accreditation. </summary>
        internal Accreditation()
        {
        }

        /// <summary> Initializes a new instance of Accreditation. </summary>
        /// <param name="education"></param>
        /// <param name="educationLevel"></param>
        /// <param name="inputStr"></param>
        /// <param name="matchStr"></param>
        internal Accreditation(string education, string educationLevel, string inputStr, string matchStr)
        {
            Education = education;
            EducationLevel = educationLevel;
            InputStr = inputStr;
            MatchStr = matchStr;
        }

        /// <summary> Gets the education. </summary>
        public string Education { get; }
        /// <summary> Gets the education level. </summary>
        public string EducationLevel { get; }
        /// <summary> Gets the input str. </summary>
        public string InputStr { get; }
        /// <summary> Gets the match str. </summary>
        public string MatchStr { get; }
    }
}
