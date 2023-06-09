﻿using System.Text.Json.Serialization;

namespace Microsoft.Sbom.Spdx3_0.Core;
public record SpdxDocument(string? name,
                           Uri? spdxId = null,
                           string? summary = null,
                           string? description = null,
                           string? comment = null,
                           CreationInfo? creationInfo = null,
                           IList<IntegrityMethod>? verifiedUsing = null,
                           ExternalReference? externalReference = null,
                           IList<ExternalIdentifier>? externalIdentifiers = null,
                           IList<Element>? elements = null,
                           Element? rootElement = null,
                           List<NamespaceMap>? namespaces = null,
                           ExternalMap? imports = null,
                           string? context = null)
    : Bundle(spdxId, name, summary, description, comment, creationInfo, verifiedUsing, externalReference, externalIdentifiers, elements, rootElement, namespaces, imports, context)
{
    [JsonPropertyOrder(-2)]
    [JsonPropertyName("@type")]
    public new string Type { get; } = nameof(SpdxDocument);
}