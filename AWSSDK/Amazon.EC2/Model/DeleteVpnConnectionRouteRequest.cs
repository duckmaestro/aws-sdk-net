﻿/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// DeleteVpnConnectionRoute Request
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteVpnConnectionRouteRequest
    {
        private string vpnConnectionIdField;
        private string destinationCidrBlockField;

        /// <summary>
        /// Gets and sets the ID of the VPN connection.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionId")]
        public string VpnConnectionId
        {
            get { return this.vpnConnectionIdField; }
            set { this.vpnConnectionIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN connection.
        /// </summary>
        /// <param name="vpnConnectionId">ID of the VPN connection</param>
        /// <returns>This instance</returns>
        public DeleteVpnConnectionRouteRequest WithVpnConnectionId(string vpnConnectionId)
        {
            this.vpnConnectionIdField = vpnConnectionId;
            return this;
        }

        /// <summary>
        /// Checks if the VpnConnectionId property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetVpnConnectionId()
        {
            return !string.IsNullOrEmpty(this.vpnConnectionIdField);
        }

        /// <summary>
        /// Gets and sets the CIDR block associated with local subnet of the customer data center. 
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationCidrBlock")]
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR block associated with local subnet of the customer data center. 
        /// </summary>
        /// <param name="destinationCidrBlock">CIDR</param>
        /// <returns>This instance</returns>
        public DeleteVpnConnectionRouteRequest WithDestinationCidrBlock(string destinationCidrBlock)
        {
            this.destinationCidrBlockField = destinationCidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if the DestinationCidrBlock property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetDestinationCidrBlock()
        {
            return !string.IsNullOrEmpty(this.destinationCidrBlockField);
        }
    }
}
