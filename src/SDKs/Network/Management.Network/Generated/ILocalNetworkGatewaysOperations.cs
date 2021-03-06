// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LocalNetworkGatewaysOperations operations.
    /// </summary>
    public partial interface ILocalNetworkGatewaysOperations
    {
        /// <summary>
        /// Creates or updates a local network gateway in the specified
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='localNetworkGatewayName'>
        /// The name of the local network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update local network gateway
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LocalNetworkGateway>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified local network gateway in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='localNetworkGatewayName'>
        /// The name of the local network gateway.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LocalNetworkGateway>> GetWithHttpMessagesAsync(string resourceGroupName, string localNetworkGatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified local network gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='localNetworkGatewayName'>
        /// The name of the local network gateway.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string localNetworkGatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the local network gateways in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LocalNetworkGateway>>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a local network gateway in the specified
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='localNetworkGatewayName'>
        /// The name of the local network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update local network gateway
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LocalNetworkGateway>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified local network gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='localNetworkGatewayName'>
        /// The name of the local network gateway.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string localNetworkGatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the local network gateways in a resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LocalNetworkGateway>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
