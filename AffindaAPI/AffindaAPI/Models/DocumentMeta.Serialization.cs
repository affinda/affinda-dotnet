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
    public partial class DocumentMeta : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identifier");
            writer.WriteStringValue(Identifier);
            if (Optional.IsDefined(CustomIdentifier))
            {
                if (CustomIdentifier != null)
                {
                    writer.WritePropertyName("customIdentifier");
                    writer.WriteStringValue(CustomIdentifier);
                }
                else
                {
                    writer.WriteNull("customIdentifier");
                }
            }
            if (Optional.IsDefined(FileName))
            {
                if (FileName != null)
                {
                    writer.WritePropertyName("fileName");
                    writer.WriteStringValue(FileName);
                }
                else
                {
                    writer.WriteNull("fileName");
                }
            }
            if (Optional.IsDefined(Ready))
            {
                writer.WritePropertyName("ready");
                writer.WriteBooleanValue(Ready.Value);
            }
            if (Optional.IsDefined(ReadyDt))
            {
                if (ReadyDt != null)
                {
                    writer.WritePropertyName("readyDt");
                    writer.WriteStringValue(ReadyDt.Value, "O");
                }
                else
                {
                    writer.WriteNull("readyDt");
                }
            }
            if (Optional.IsDefined(Failed))
            {
                writer.WritePropertyName("failed");
                writer.WriteBooleanValue(Failed.Value);
            }
            if (Optional.IsDefined(ExpiryTime))
            {
                if (ExpiryTime != null)
                {
                    writer.WritePropertyName("expiryTime");
                    writer.WriteStringValue(ExpiryTime);
                }
                else
                {
                    writer.WriteNull("expiryTime");
                }
            }
            if (Optional.IsDefined(Language))
            {
                if (Language != null)
                {
                    writer.WritePropertyName("language");
                    writer.WriteStringValue(Language);
                }
                else
                {
                    writer.WriteNull("language");
                }
            }
            if (Optional.IsDefined(Pdf))
            {
                if (Pdf != null)
                {
                    writer.WritePropertyName("pdf");
                    writer.WriteStringValue(Pdf);
                }
                else
                {
                    writer.WriteNull("pdf");
                }
            }
            if (Optional.IsDefined(ParentDocument))
            {
                if (ParentDocument != null)
                {
                    writer.WritePropertyName("parentDocument");
                    writer.WriteObjectValue(ParentDocument);
                }
                else
                {
                    writer.WriteNull("parentDocument");
                }
            }
            if (Optional.IsCollectionDefined(ChildDocuments))
            {
                writer.WritePropertyName("childDocuments");
                writer.WriteStartArray();
                foreach (var item in ChildDocuments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("pages");
            writer.WriteStartArray();
            foreach (var item in Pages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(IsOcrd))
            {
                writer.WritePropertyName("isOcrd");
                writer.WriteBooleanValue(IsOcrd.Value);
            }
            if (Optional.IsDefined(OcrConfidence))
            {
                if (OcrConfidence != null)
                {
                    writer.WritePropertyName("ocrConfidence");
                    writer.WriteNumberValue(OcrConfidence.Value);
                }
                else
                {
                    writer.WriteNull("ocrConfidence");
                }
            }
            if (Optional.IsDefined(ReviewUrl))
            {
                if (ReviewUrl != null)
                {
                    writer.WritePropertyName("reviewUrl");
                    writer.WriteStringValue(ReviewUrl);
                }
                else
                {
                    writer.WriteNull("reviewUrl");
                }
            }
            if (Optional.IsDefined(Collection))
            {
                if (Collection != null)
                {
                    writer.WritePropertyName("collection");
                    writer.WriteObjectValue(Collection);
                }
                else
                {
                    writer.WriteNull("collection");
                }
            }
            writer.WritePropertyName("workspace");
            writer.WriteObjectValue(Workspace);
            if (Optional.IsDefined(ArchivedDt))
            {
                if (ArchivedDt != null)
                {
                    writer.WritePropertyName("archivedDt");
                    writer.WriteStringValue(ArchivedDt.Value, "O");
                }
                else
                {
                    writer.WriteNull("archivedDt");
                }
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived");
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Optional.IsDefined(SkipParse))
            {
                writer.WritePropertyName("skipParse");
                writer.WriteBooleanValue(SkipParse.Value);
            }
            if (Optional.IsDefined(ConfirmedDt))
            {
                if (ConfirmedDt != null)
                {
                    writer.WritePropertyName("confirmedDt");
                    writer.WriteStringValue(ConfirmedDt.Value, "O");
                }
                else
                {
                    writer.WriteNull("confirmedDt");
                }
            }
            if (Optional.IsDefined(ConfirmedBy))
            {
                if (ConfirmedBy != null)
                {
                    writer.WritePropertyName("confirmedBy");
                    writer.WriteObjectValue(ConfirmedBy);
                }
                else
                {
                    writer.WriteNull("confirmedBy");
                }
            }
            if (Optional.IsDefined(IsConfirmed))
            {
                writer.WritePropertyName("isConfirmed");
                writer.WriteBooleanValue(IsConfirmed.Value);
            }
            if (Optional.IsDefined(RejectedDt))
            {
                if (RejectedDt != null)
                {
                    writer.WritePropertyName("rejectedDt");
                    writer.WriteStringValue(RejectedDt.Value, "O");
                }
                else
                {
                    writer.WriteNull("rejectedDt");
                }
            }
            if (Optional.IsDefined(RejectedBy))
            {
                if (RejectedBy != null)
                {
                    writer.WritePropertyName("rejectedBy");
                    writer.WriteObjectValue(RejectedBy);
                }
                else
                {
                    writer.WriteNull("rejectedBy");
                }
            }
            if (Optional.IsDefined(IsRejected))
            {
                writer.WritePropertyName("isRejected");
                writer.WriteBooleanValue(IsRejected.Value);
            }
            if (Optional.IsDefined(CreatedDt))
            {
                writer.WritePropertyName("createdDt");
                writer.WriteStringValue(CreatedDt.Value, "O");
            }
            if (Optional.IsDefined(ErrorCode))
            {
                if (ErrorCode != null)
                {
                    writer.WritePropertyName("errorCode");
                    writer.WriteStringValue(ErrorCode);
                }
                else
                {
                    writer.WriteNull("errorCode");
                }
            }
            if (Optional.IsDefined(ErrorDetail))
            {
                if (ErrorDetail != null)
                {
                    writer.WritePropertyName("errorDetail");
                    writer.WriteStringValue(ErrorDetail);
                }
                else
                {
                    writer.WriteNull("errorDetail");
                }
            }
            if (Optional.IsDefined(File))
            {
                if (File != null)
                {
                    writer.WritePropertyName("file");
                    writer.WriteStringValue(File);
                }
                else
                {
                    writer.WriteNull("file");
                }
            }
            if (Optional.IsDefined(Html))
            {
                if (Html != null)
                {
                    writer.WritePropertyName("html");
                    writer.WriteStringValue(Html);
                }
                else
                {
                    writer.WriteNull("html");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteObjectValue(CreatedBy);
            }
            if (Optional.IsDefined(SourceEmail))
            {
                if (SourceEmail != null)
                {
                    writer.WritePropertyName("sourceEmail");
                    writer.WriteStringValue(SourceEmail);
                }
                else
                {
                    writer.WriteNull("sourceEmail");
                }
            }
            if (Optional.IsDefined(SourceEmailAddress))
            {
                if (SourceEmailAddress != null)
                {
                    writer.WritePropertyName("sourceEmailAddress");
                    writer.WriteStringValue(SourceEmailAddress);
                }
                else
                {
                    writer.WriteNull("sourceEmailAddress");
                }
            }
            if (Optional.IsDefined(RegionBias))
            {
                if (RegionBias != null)
                {
                    writer.WritePropertyName("regionBias");
                    writer.WriteObjectValue(RegionBias);
                }
                else
                {
                    writer.WriteNull("regionBias");
                }
            }
            writer.WriteEndObject();
        }

        internal static DocumentMeta DeserializeDocumentMeta(JsonElement element)
        {
            string identifier = default;
            Optional<string> customIdentifier = default;
            Optional<string> fileName = default;
            Optional<bool> ready = default;
            Optional<DateTimeOffset?> readyDt = default;
            Optional<bool> failed = default;
            Optional<string> expiryTime = default;
            Optional<string> language = default;
            Optional<string> pdf = default;
            Optional<DocumentMetaParentDocument> parentDocument = default;
            Optional<IList<DocumentMetaChildDocumentsItem>> childDocuments = default;
            IList<PageMeta> pages = default;
            Optional<bool> isOcrd = default;
            Optional<float?> ocrConfidence = default;
            Optional<string> reviewUrl = default;
            Optional<DocumentMetaCollection> collection = default;
            DocumentMetaWorkspace workspace = default;
            Optional<DateTimeOffset?> archivedDt = default;
            Optional<bool> isArchived = default;
            Optional<bool> skipParse = default;
            Optional<DateTimeOffset?> confirmedDt = default;
            Optional<UserNullable> confirmedBy = default;
            Optional<bool> isConfirmed = default;
            Optional<DateTimeOffset?> rejectedDt = default;
            Optional<UserNullable> rejectedBy = default;
            Optional<bool> isRejected = default;
            Optional<DateTimeOffset> createdDt = default;
            Optional<string> errorCode = default;
            Optional<string> errorDetail = default;
            Optional<string> file = default;
            Optional<string> html = default;
            Optional<IList<Tag>> tags = default;
            Optional<User> createdBy = default;
            Optional<string> sourceEmail = default;
            Optional<string> sourceEmailAddress = default;
            Optional<RegionBias> regionBias = default;
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
                if (property.NameEquals("skipParse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skipParse = property.Value.GetBoolean();
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
                if (property.NameEquals("rejectedBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rejectedBy = null;
                        continue;
                    }
                    rejectedBy = UserNullable.DeserializeUserNullable(property.Value);
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
                if (property.NameEquals("html"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        html = null;
                        continue;
                    }
                    html = property.Value.GetString();
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
                if (property.NameEquals("createdBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdBy = User.DeserializeUser(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceEmail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sourceEmail = null;
                        continue;
                    }
                    sourceEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceEmailAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sourceEmailAddress = null;
                        continue;
                    }
                    sourceEmailAddress = property.Value.GetString();
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
            }
            return new DocumentMeta(identifier, customIdentifier.Value, fileName.Value, Optional.ToNullable(ready), Optional.ToNullable(readyDt), Optional.ToNullable(failed), expiryTime.Value, language.Value, pdf.Value, parentDocument.Value, Optional.ToList(childDocuments), pages, Optional.ToNullable(isOcrd), Optional.ToNullable(ocrConfidence), reviewUrl.Value, collection.Value, workspace, Optional.ToNullable(archivedDt), Optional.ToNullable(isArchived), Optional.ToNullable(skipParse), Optional.ToNullable(confirmedDt), confirmedBy.Value, Optional.ToNullable(isConfirmed), Optional.ToNullable(rejectedDt), rejectedBy.Value, Optional.ToNullable(isRejected), Optional.ToNullable(createdDt), errorCode.Value, errorDetail.Value, file.Value, html.Value, Optional.ToList(tags), createdBy.Value, sourceEmail.Value, sourceEmailAddress.Value, regionBias.Value);
        }
    }
}
