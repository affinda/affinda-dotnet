// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    internal partial class RequestErrorErrorsItem
    {
        internal static RequestErrorErrorsItem DeserializeRequestErrorErrorsItem(JsonElement element)
        {
            string attr = default;
            string code = default;
            string detail = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attr"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        attr = null;
                        continue;
                    }
                    attr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detail"))
                {
                    detail = property.Value.GetString();
                    continue;
                }
            }
            return new RequestErrorErrorsItem(attr, code, detail);
        }
    }
}
