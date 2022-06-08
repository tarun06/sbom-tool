﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using ManifestInterface.Entities;

namespace ManifestInterface
{
    /// <summary>
    /// Provides internally generated metadata that can be used to create 
    /// the metadata dictionary for the current SBOM format.
    /// </summary>
    public interface IInternalMetadataProvider
    {
        /// <summary>
        /// Get the metadata object for the given item.
        /// 
        /// Throws an <see cref="System.Exception"/> if the item is not found.
        /// </summary>
        /// <param name="key">The <see cref="MetadataKey"/> for the item.</param>
        /// <returns></returns>
        object GetMetadata(MetadataKey key);

        /// <summary>
        /// Get the metadata object for the given item and set it to the value parameter.
        /// </summary>
        /// <param name="key">The <see cref="MetadataKey"/> for the item.</param>
        /// <param name="value">The out parameter to set the value.</param>
        /// <returns>true if value found, false otherwise.</returns>
        bool TryGetMetadata(MetadataKey key, out object value);

        /// <summary>
        /// Get all the data that was generated by our tool during this SBOM run.
        /// </summary>
        /// <returns>A <see cref="GenerationData"/> object.</returns>
        GenerationData GetGenerationData(ManifestInfo manifestInfo);

        /// <summary>
        /// Gets the namespace URI for the SBOM document that is unique within this build environment. 
        /// </summary>
        /// <returns></returns>
        string GetSBOMNamespaceUri();
    }
}