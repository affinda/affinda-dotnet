// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Meta
    {
        internal static Meta DeserializeMeta(JsonElement element)
        {
            Optional<string> identifier = default;
            Optional<string> customIdentifier = default;
            Optional<string> fileName = default;
            Optional<bool> ready = default;
            Optional<DateTimeOffset?> readyDt = default;
            Optional<bool> failed = default;
            Optional<string> expiryTime = default;
            Optional<string> language = default;
            Optional<string> pdf = default;
            Optional<MetaParentDocument> parentDocument = default;
            Optional<IReadOnlyList<MetaChildDocumentsItem>> childDocuments = default;
            Optional<IReadOnlyList<PageMeta>> pages = default;
            Optional<bool> isVerified = default;
            Optional<string> reviewUrl = default;
            Optional<float?> ocrConfidence = default;
            Optional<DateTimeOffset> createdDt = default;
            Optional<string> documentType = default;
            Optional<RegionBias> regionBias = default;
            Optional<bool> isOcrd = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        customIdentifier = null;
                        continue;
                    }
                    customIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileName = null;
                        continue;
                    }
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ready"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ready = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readyDt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readyDt = null;
                        continue;
                    }
                    readyDt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("expiryTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiryTime = null;
                        continue;
                    }
                    expiryTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        language = null;
                        continue;
                    }
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pdf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pdf = null;
                        continue;
                    }
                    pdf = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentDocument"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parentDocument = null;
                        continue;
                    }
                    parentDocument = MetaParentDocument.DeserializeMetaParentDocument(property.Value);
                    continue;
                }
                if (property.NameEquals("childDocuments"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetaChildDocumentsItem> array = new List<MetaChildDocumentsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetaChildDocumentsItem.DeserializeMetaChildDocumentsItem(item));
                    }
                    childDocuments = array;
                    continue;
                }
                if (property.NameEquals("pages"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PageMeta> array = new List<PageMeta>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PageMeta.DeserializePageMeta(item));
                    }
                    pages = array;
                    continue;
                }
                if (property.NameEquals("isVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reviewUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        reviewUrl = null;
                        continue;
                    }
                    reviewUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ocrConfidence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ocrConfidence = null;
                        continue;
                    }
                    ocrConfidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("createdDt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("documentType"))
                {
                    documentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionBias"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        regionBias = null;
                        continue;
                    }
                    regionBias = RegionBias.DeserializeRegionBias(property.Value);
                    continue;
                }
                if (property.NameEquals("isOcrd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOcrd = property.Value.GetBoolean();
                    continue;
                }
            }
            return new Meta(identifier.Value, customIdentifier.Value, fileName.Value, Optional.ToNullable(ready), Optional.ToNullable(readyDt), Optional.ToNullable(failed), expiryTime.Value, language.Value, pdf.Value, parentDocument.Value, Optional.ToList(childDocuments), Optional.ToList(pages), Optional.ToNullable(isVerified), reviewUrl.Value, Optional.ToNullable(ocrConfidence), Optional.ToNullable(createdDt), documentType.Value, regionBias.Value, Optional.ToNullable(isOcrd));
        }
    }
}
