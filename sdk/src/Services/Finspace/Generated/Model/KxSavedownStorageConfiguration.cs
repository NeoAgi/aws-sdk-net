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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The size and type of temporary storage that is used to hold data during the savedown
    /// process. All the data written to this storage space is lost when the cluster node
    /// is restarted.
    /// </summary>
    public partial class KxSavedownStorageConfiguration
    {
        private int? _size;
        private KxSavedownStorageType _type;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of temporary storage in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16000)]
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of writeable storage space for temporarily storing your savedown data. The
        /// valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SDS01 – This type represents 3000 IOPS and io2 ebs volume type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxSavedownStorageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}