/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationVersions operation.
    /// </summary>
    public partial class ListApplicationVersionsResponse : AmazonWebServiceResponse
    {
        private List<ApplicationVersionSummary> _applicationVersions = new List<ApplicationVersionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationVersions. 
        /// <para>
        /// The list of application versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ApplicationVersionSummary> ApplicationVersions
        {
            get { return this._applicationVersions; }
            set { this._applicationVersions = value; }
        }

        // Check to see if ApplicationVersions property is set
        internal bool IsSetApplicationVersions()
        {
            return this._applicationVersions != null && this._applicationVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more items to return, this contains a token that is passed to a subsequent
        /// call to this operation to retrieve the next set of items.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}