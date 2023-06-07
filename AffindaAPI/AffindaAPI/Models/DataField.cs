// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The DataField. </summary>
    public partial class DataField
    {
        /// <summary> Initializes a new instance of DataField. </summary>
        /// <param name="field"> The field to be created. </param>
        /// <param name="dataPoint"> The data point to be created for this field. If a data point with the same slug and collection already exists, it will be reused. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="field"/> or <paramref name="dataPoint"/> is null. </exception>
        internal DataField(DataFieldField field, DataFieldDataPoint dataPoint)
        {
            if (field == null)
            {
                throw new ArgumentNullException(nameof(field));
            }
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }

            Field = field;
            DataPoint = dataPoint;
        }

        /// <summary> Initializes a new instance of DataField. </summary>
        /// <param name="categoryLabel"> The label of the category that this field will be put into. If not provided, the field will be put into the default category. If no category exists with the specified label, a new category will be created. </param>
        /// <param name="field"> The field to be created. </param>
        /// <param name="dataPoint"> The data point to be created for this field. If a data point with the same slug and collection already exists, it will be reused. </param>
        internal DataField(string categoryLabel, DataFieldField field, DataFieldDataPoint dataPoint)
        {
            CategoryLabel = categoryLabel;
            Field = field;
            DataPoint = dataPoint;
        }

        /// <summary> The label of the category that this field will be put into. If not provided, the field will be put into the default category. If no category exists with the specified label, a new category will be created. </summary>
        public string CategoryLabel { get; }
        /// <summary> The field to be created. </summary>
        public DataFieldField Field { get; }
        /// <summary> The data point to be created for this field. If a data point with the same slug and collection already exists, it will be reused. </summary>
        public DataFieldDataPoint DataPoint { get; }
    }
}
