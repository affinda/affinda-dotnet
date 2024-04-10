// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The MappingCreate. </summary>
    public partial class MappingCreate
    {
        /// <summary> Initializes a new instance of MappingCreate. </summary>
        /// <param name="dataSource"> The mapping data source this mapping applies to. </param>
        public MappingCreate(string dataSource)
        {
            DataSource = dataSource;
        }

        /// <summary> The mapping data source this mapping applies to. </summary>
        public string DataSource { get; }
        /// <summary> Higher values will result in more strict matching. </summary>
        public float? ScoreCutoff { get; set; }
        /// <summary> The organization that this mapping belongs to. </summary>
        public string Organization { get; set; }
    }
}