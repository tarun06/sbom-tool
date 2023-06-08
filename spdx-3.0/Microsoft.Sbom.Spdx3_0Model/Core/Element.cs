﻿namespace Microsoft.Sbom.Spdx3_0.Core;

public abstract record Element(List<NamespaceMap>? namespaces,
                               ExternalMap? imports,
                               Uri? spdxId,
                               string? name,
                               string? summary,
                               string? description,
                               string? comment,
                               CreationInfo? creationInfo,
                               IList<IntegrityMethod>? VerifiedUsing,
                               ExternalReference? externalReference,
                               ExternalIdentifier? externalIdentifier)
    : Payload(creationInfo, namespaces, imports);