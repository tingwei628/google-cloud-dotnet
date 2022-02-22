// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Workflows.V1.Snippets
{
    // [START workflows_v1_generated_Workflows_CreateWorkflow_async_flattened]
    using Google.Cloud.Workflows.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedWorkflowsClientSnippets
    {
        /// <summary>Snippet for CreateWorkflowAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateWorkflowAsync()
        {
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Workflow workflow = new Workflow();
            string workflowId = "";
            // Make the request
            Operation<Workflow, OperationMetadata> response = await workflowsClient.CreateWorkflowAsync(parent, workflow, workflowId);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceCreateWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END workflows_v1_generated_Workflows_CreateWorkflow_async_flattened]
}