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

namespace Google.Cloud.AutoML.V1.Snippets
{
    // [START automl_v1_generated_AutoMl_GetModelEvaluation_async_flattened]
    using Google.Cloud.AutoML.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAutoMlClientSnippets
    {
        /// <summary>Snippet for GetModelEvaluationAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetModelEvaluationAsync()
        {
            // Create client
            AutoMlClient autoMlClient = await AutoMlClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]/modelEvaluations/[MODEL_EVALUATION]";
            // Make the request
            ModelEvaluation response = await autoMlClient.GetModelEvaluationAsync(name);
        }
    }
    // [END automl_v1_generated_AutoMl_GetModelEvaluation_async_flattened]
}