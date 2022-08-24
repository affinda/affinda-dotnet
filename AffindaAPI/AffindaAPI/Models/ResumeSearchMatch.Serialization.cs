// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchMatch
    {
        internal static ResumeSearchMatch DeserializeResumeSearchMatch(JsonElement element)
        {
            Optional<float> score = default;
            Optional<ResumeSearchMatchDetails> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("score"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    score = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    details = ResumeSearchMatchDetails.DeserializeResumeSearchMatchDetails(property.Value);
                    continue;
                }
            }
            return new ResumeSearchMatch(Optional.ToNullable(score), details.Value);
        }
    }
}