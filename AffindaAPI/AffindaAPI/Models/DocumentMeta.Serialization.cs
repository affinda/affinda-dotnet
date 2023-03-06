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
    public partial class DocumentMeta
    {
        internal static DocumentMeta DeserializeDocumentMeta(JsonElement element)
        {
            string identifier = default;
            Optional<string> fileName = default;
            Optional<bool> ready = default;
            Optional<DateTimeOffset?> readyDt = default;
            Optional<bool> failed = default;
            Optional<string> expiryTime = default;
            Optional<string> language = default;
            Optional<string> pdf = default;
            Optional<DocumentMetaParentDocument> parentDocument = default;
            Optional<IReadOnlyList<DocumentMetaChildDocumentsItem>> childDocuments = default;
            IReadOnlyList<PageMeta> pages = default;
            Optional<bool> isOcrd = default;
            Optional<float?> ocrConfidence = default;
            Optional<string> reviewUrl = default;
            Optional<DocumentMetaCollection> collection = default;
            DocumentMetaWorkspace workspace = default;
            Optional<DateTimeOffset?> archivedDt = default;
            Optional<bool> isArchived = default;
            Optional<DateTimeOffset?> confirmedDt = default;
            Optional<bool> isConfirmed = default;
            Optional<DateTimeOffset?> rejectedDt = default;
            Optional<bool> isRejected = default;
            Optional<DateTimeOffset> createdDt = default;
            Optional<string> errorCode = default;
            Optional<string> errorDetail = default;
            Optional<string> file = default;
            Optional<IReadOnlyList<Tag>> tags = default;
            Optional<UserNullable> confirmedBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"))
                {
                    identifier = property.Value.GetString();
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
                    parentDocument = DocumentMetaParentDocument.DeserializeDocumentMetaParentDocument(property.Value);
                    continue;
                }
                if (property.NameEquals("childDocuments"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DocumentMetaChildDocumentsItem> array = new List<DocumentMetaChildDocumentsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentMetaChildDocumentsItem.DeserializeDocumentMetaChildDocumentsItem(item));
                    }
                    childDocuments = array;
                    continue;
                }
                if (property.NameEquals("pages"))
                {
                    List<PageMeta> array = new List<PageMeta>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PageMeta.DeserializePageMeta(item));
                    }
                    pages = array;
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
                if (property.NameEquals("collection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        collection = null;
                        continue;
                    }
                    collection = DocumentMetaCollection.DeserializeDocumentMetaCollection(property.Value);
                    continue;
                }
                if (property.NameEquals("workspace"))
                {
                    workspace = DocumentMetaWorkspace.DeserializeDocumentMetaWorkspace(property.Value);
                    continue;
                }
                if (property.NameEquals("archivedDt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        archivedDt = null;
                        continue;
                    }
                    archivedDt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isArchived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("confirmedDt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        confirmedDt = null;
                        continue;
                    }
                    confirmedDt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isConfirmed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isConfirmed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rejectedDt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rejectedDt = null;
                        continue;
                    }
                    rejectedDt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isRejected"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isRejected = property.Value.GetBoolean();
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
                if (property.NameEquals("errorCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorCode = null;
                        continue;
                    }
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errorDetail = null;
                        continue;
                    }
                    errorDetail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        file = null;
                        continue;
                    }
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Tag> array = new List<Tag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Tag.DeserializeTag(item));
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("confirmedBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        confirmedBy = null;
                        continue;
                    }
                    confirmedBy = UserNullable.DeserializeUserNullable(property.Value);
                    continue;
                }
            }
            return new DocumentMeta(identifier, fileName.Value, Optional.ToNullable(ready), Optional.ToNullable(readyDt), Optional.ToNullable(failed), expiryTime.Value, language.Value, pdf.Value, parentDocument.Value, Optional.ToList(childDocuments), pages, Optional.ToNullable(isOcrd), Optional.ToNullable(ocrConfidence), reviewUrl.Value, collection.Value, workspace, Optional.ToNullable(archivedDt), Optional.ToNullable(isArchived), Optional.ToNullable(confirmedDt), Optional.ToNullable(isConfirmed), Optional.ToNullable(rejectedDt), Optional.ToNullable(isRejected), Optional.ToNullable(createdDt), errorCode.Value, errorDetail.Value, file.Value, Optional.ToList(tags), confirmedBy.Value);
        }
    }
}
