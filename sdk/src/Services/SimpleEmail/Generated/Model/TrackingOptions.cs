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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// A domain that is used to redirect email recipients to an Amazon SES-operated domain.
    /// This domain captures open and click events generated by Amazon SES emails.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/configure-custom-open-click-domains.html">Configuring
    /// Custom Domains to Handle Open and Click Tracking</a> in the <i> <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/Welcome.html">Amazon
    /// SES Developer Guide</a>.</i> 
    /// </para>
    /// </summary>
    public partial class TrackingOptions
    {
        private string _customRedirectDomain;

        /// <summary>
        /// Gets and sets the property CustomRedirectDomain. 
        /// <para>
        /// The custom subdomain that will be used to redirect email recipients to the Amazon
        /// SES event tracking domain.
        /// </para>
        /// </summary>
        public string CustomRedirectDomain
        {
            get { return this._customRedirectDomain; }
            set { this._customRedirectDomain = value; }
        }

        // Check to see if CustomRedirectDomain property is set
        internal bool IsSetCustomRedirectDomain()
        {
            return this._customRedirectDomain != null;
        }

    }
}