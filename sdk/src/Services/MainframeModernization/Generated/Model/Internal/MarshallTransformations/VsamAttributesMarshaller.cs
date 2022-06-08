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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VsamAttributes Marshaller
    /// </summary>
    public class VsamAttributesMarshaller : IRequestMarshaller<VsamAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VsamAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAlternateKeys())
            {
                context.Writer.WritePropertyName("alternateKeys");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAlternateKeysListValue in requestObject.AlternateKeys)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AlternateKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectAlternateKeysListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCompressed())
            {
                context.Writer.WritePropertyName("compressed");
                context.Writer.Write(requestObject.Compressed);
            }

            if(requestObject.IsSetEncoding())
            {
                context.Writer.WritePropertyName("encoding");
                context.Writer.Write(requestObject.Encoding);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("format");
                context.Writer.Write(requestObject.Format);
            }

            if(requestObject.IsSetPrimaryKey())
            {
                context.Writer.WritePropertyName("primaryKey");
                context.Writer.WriteObjectStart();

                var marshaller = PrimaryKeyMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryKey, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VsamAttributesMarshaller Instance = new VsamAttributesMarshaller();

    }
}