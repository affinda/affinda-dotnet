// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Affinda.API.Models
{
    /// <summary> The event name to subscribe to. </summary>
    public readonly partial struct ResthookEvent : IEquatable<ResthookEvent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResthookEvent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResthookEvent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ResumeParseSucceededValue = "resume.parse.succeeded";
        private const string ResumeParseFailedValue = "resume.parse.failed";
        private const string ResumeParseCompletedValue = "resume.parse.completed";
        private const string InvoiceParseSucceededValue = "invoice.parse.succeeded";
        private const string InvoiceParseFailedValue = "invoice.parse.failed";
        private const string InvoiceParseCompletedValue = "invoice.parse.completed";
        private const string InvoiceValidateCompletedValue = "invoice.validate.completed";
        private const string DocumentParseSucceededValue = "document.parse.succeeded";
        private const string DocumentParseFailedValue = "document.parse.failed";
        private const string DocumentParseCompletedValue = "document.parse.completed";
        private const string DocumentValidateCompletedValue = "document.validate.completed";
        private const string DocumentClassifySucceededValue = "document.classify.succeeded";
        private const string DocumentClassifyFailedValue = "document.classify.failed";
        private const string DocumentClassifyCompletedValue = "document.classify.completed";
        private const string DocumentRejectedValue = "document.rejected";
        private const string AnnotationValidatedValue = "annotation.validated";

        /// <summary> resume.parse.succeeded. </summary>
        public static ResthookEvent ResumeParseSucceeded { get; } = new ResthookEvent(ResumeParseSucceededValue);
        /// <summary> resume.parse.failed. </summary>
        public static ResthookEvent ResumeParseFailed { get; } = new ResthookEvent(ResumeParseFailedValue);
        /// <summary> resume.parse.completed. </summary>
        public static ResthookEvent ResumeParseCompleted { get; } = new ResthookEvent(ResumeParseCompletedValue);
        /// <summary> invoice.parse.succeeded. </summary>
        public static ResthookEvent InvoiceParseSucceeded { get; } = new ResthookEvent(InvoiceParseSucceededValue);
        /// <summary> invoice.parse.failed. </summary>
        public static ResthookEvent InvoiceParseFailed { get; } = new ResthookEvent(InvoiceParseFailedValue);
        /// <summary> invoice.parse.completed. </summary>
        public static ResthookEvent InvoiceParseCompleted { get; } = new ResthookEvent(InvoiceParseCompletedValue);
        /// <summary> invoice.validate.completed. </summary>
        public static ResthookEvent InvoiceValidateCompleted { get; } = new ResthookEvent(InvoiceValidateCompletedValue);
        /// <summary> document.parse.succeeded. </summary>
        public static ResthookEvent DocumentParseSucceeded { get; } = new ResthookEvent(DocumentParseSucceededValue);
        /// <summary> document.parse.failed. </summary>
        public static ResthookEvent DocumentParseFailed { get; } = new ResthookEvent(DocumentParseFailedValue);
        /// <summary> document.parse.completed. </summary>
        public static ResthookEvent DocumentParseCompleted { get; } = new ResthookEvent(DocumentParseCompletedValue);
        /// <summary> document.validate.completed. </summary>
        public static ResthookEvent DocumentValidateCompleted { get; } = new ResthookEvent(DocumentValidateCompletedValue);
        /// <summary> document.classify.succeeded. </summary>
        public static ResthookEvent DocumentClassifySucceeded { get; } = new ResthookEvent(DocumentClassifySucceededValue);
        /// <summary> document.classify.failed. </summary>
        public static ResthookEvent DocumentClassifyFailed { get; } = new ResthookEvent(DocumentClassifyFailedValue);
        /// <summary> document.classify.completed. </summary>
        public static ResthookEvent DocumentClassifyCompleted { get; } = new ResthookEvent(DocumentClassifyCompletedValue);
        /// <summary> document.rejected. </summary>
        public static ResthookEvent DocumentRejected { get; } = new ResthookEvent(DocumentRejectedValue);
        /// <summary> annotation.validated. </summary>
        public static ResthookEvent AnnotationValidated { get; } = new ResthookEvent(AnnotationValidatedValue);
        /// <summary> Determines if two <see cref="ResthookEvent"/> values are the same. </summary>
        public static bool operator ==(ResthookEvent left, ResthookEvent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResthookEvent"/> values are not the same. </summary>
        public static bool operator !=(ResthookEvent left, ResthookEvent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResthookEvent"/>. </summary>
        public static implicit operator ResthookEvent(string value) => new ResthookEvent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResthookEvent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResthookEvent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
