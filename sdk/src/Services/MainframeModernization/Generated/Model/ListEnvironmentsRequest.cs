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
    /// Container for the parameters to the ListEnvironments operation.
    /// Lists the runtime environments.
    /// </summary>
    public partial class ListEnvironmentsRequest : AmazonMainframeModernizationRequest
    {
        private EngineType _engineType;
        private int? _maxResults;
        private List<string> _names = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type for the environment.
        /// </para>
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of environments to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to control the number of environments displayed in the list.
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