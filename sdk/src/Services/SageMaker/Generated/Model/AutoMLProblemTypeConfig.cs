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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings specific to the problem type used to configure an AutoML
    /// job V2. There must be one and only one config of the following type.
    /// </summary>
    public partial class AutoMLProblemTypeConfig
    {
        private ImageClassificationJobConfig _imageClassificationJobConfig;
        private TabularJobConfig _tabularJobConfig;
        private TextClassificationJobConfig _textClassificationJobConfig;
        private TimeSeriesForecastingJobConfig _timeSeriesForecastingJobConfig;

        /// <summary>
        /// Gets and sets the property ImageClassificationJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the image classification problem type.
        /// </para>
        /// </summary>
        public ImageClassificationJobConfig ImageClassificationJobConfig
        {
            get { return this._imageClassificationJobConfig; }
            set { this._imageClassificationJobConfig = value; }
        }

        // Check to see if ImageClassificationJobConfig property is set
        internal bool IsSetImageClassificationJobConfig()
        {
            return this._imageClassificationJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TabularJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for a tabular problem type (regression,
        /// classification).
        /// </para>
        /// </summary>
        public TabularJobConfig TabularJobConfig
        {
            get { return this._tabularJobConfig; }
            set { this._tabularJobConfig = value; }
        }

        // Check to see if TabularJobConfig property is set
        internal bool IsSetTabularJobConfig()
        {
            return this._tabularJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TextClassificationJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the text classification problem type.
        /// </para>
        /// </summary>
        public TextClassificationJobConfig TextClassificationJobConfig
        {
            get { return this._textClassificationJobConfig; }
            set { this._textClassificationJobConfig = value; }
        }

        // Check to see if TextClassificationJobConfig property is set
        internal bool IsSetTextClassificationJobConfig()
        {
            return this._textClassificationJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesForecastingJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for a time-series forecasting problem
        /// type.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>TimeSeriesForecastingJobConfig</code> problem type is only available in
        /// private beta. Contact Amazon Web Services Support or your account manager to learn
        /// more about access privileges.
        /// </para>
        ///  </note>
        /// </summary>
        public TimeSeriesForecastingJobConfig TimeSeriesForecastingJobConfig
        {
            get { return this._timeSeriesForecastingJobConfig; }
            set { this._timeSeriesForecastingJobConfig = value; }
        }

        // Check to see if TimeSeriesForecastingJobConfig property is set
        internal bool IsSetTimeSeriesForecastingJobConfig()
        {
            return this._timeSeriesForecastingJobConfig != null;
        }

    }
}