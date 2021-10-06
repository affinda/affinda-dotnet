// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ReformattedResumeData
    {
        internal static ReformattedResumeData DeserializeReformattedResumeData(JsonElement element)
        {
            Optional<string> reformattedFile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reformattedFile"))
                {
                    reformattedFile = property.Value.GetString();
                    continue;
                }
            }
            return new ReformattedResumeData(reformattedFile.Value);
        }
    }
}
