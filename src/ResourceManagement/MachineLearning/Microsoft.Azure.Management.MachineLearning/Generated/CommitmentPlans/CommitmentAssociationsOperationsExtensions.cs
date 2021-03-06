// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for CommitmentAssociationsOperations.
    /// </summary>
    public static partial class CommitmentAssociationsOperationsExtensions
    {
            /// <summary>
            /// Gets a commitment association.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            public static CommitmentAssociation Get(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICommitmentAssociationsOperations)s).GetAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a commitment association.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CommitmentAssociation> GetAsync(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token for pagination.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CommitmentAssociation> List(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string skipToken = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICommitmentAssociationsOperations)s).ListAsync(resourceGroupName, commitmentPlanName, skipToken), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CommitmentAssociation>> ListAsync(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string skipToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, commitmentPlanName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Re-parents a commitment association from one commitment plan to another.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            /// <param name='movePayload'>
            /// The move request payload.
            /// </param>
            public static CommitmentAssociation Move(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName, MoveCommitmentAssociationRequest movePayload)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICommitmentAssociationsOperations)s).MoveAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName, movePayload), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Re-parents a commitment association from one commitment plan to another.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            /// <param name='movePayload'>
            /// The move request payload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CommitmentAssociation> MoveAsync(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName, MoveCommitmentAssociationRequest movePayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.MoveWithHttpMessagesAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName, movePayload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CommitmentAssociation> ListNext(this ICommitmentAssociationsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICommitmentAssociationsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CommitmentAssociation>> ListNextAsync(this ICommitmentAssociationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
