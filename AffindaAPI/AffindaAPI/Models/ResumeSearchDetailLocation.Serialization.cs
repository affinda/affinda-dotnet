// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchDetailLocation
    {
        internal static ResumeSearchDetailLocation DeserializeResumeSearchDetailLocation(JsonElement element)
        {
            Optional<IReadOnlyList<ResumeSearchParametersLocation>> missing = default;
            Optional<ResumeSearchDetailLocationValue> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("missing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResumeSearchParametersLocation> array = new List<ResumeSearchParametersLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResumeSearchParametersLocation.DeserializeResumeSearchParametersLocation(item));
                    }
                    missing = array;
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = ResumeSearchDetailLocationValue.DeserializeResumeSearchDetailLocationValue(property.Value);
                    continue;
                }
            }
            return new ResumeSearchDetailLocation(Optional.ToList(missing), value.Value);
        }
    }
}
