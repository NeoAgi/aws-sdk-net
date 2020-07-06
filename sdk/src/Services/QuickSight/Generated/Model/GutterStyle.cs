/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The display options for gutter spacing between tiles on a sheet.
    /// </summary>
    public partial class GutterStyle
    {
        private bool? _show;

        /// <summary>
        /// Gets and sets the property Show. 
        /// <para>
        /// This Boolean value controls whether to display a gutter space between sheet tiles.
        /// 
        /// </para>
        /// </summary>
        public bool Show
        {
            get { return this._show.GetValueOrDefault(); }
            set { this._show = value; }
        }

        // Check to see if Show property is set
        internal bool IsSetShow()
        {
            return this._show.HasValue; 
        }

    }
}