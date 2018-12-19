/******************************************************************************
**
** <auto-generated>
**     This code was generated by a tool: UaModeler
**     Runtime Version: 1.6.2, using .NET Server 2.6.0 template (version 1)
**
**     Changes to this file may cause incorrect behavior and will be lost if
**     the code is regenerated.
** </auto-generated>
**
** Copyright (c) 2006-2018 Unified Automation GmbH All rights reserved.
**
** Software License Agreement ("SLA") Version 2.7
**
** Unless explicitly acquired and licensed from Licensor under another
** license, the contents of this file are subject to the Software License
** Agreement ("SLA") Version 2.7, or subsequent versions
** as allowed by the SLA, and You may not copy or use this file in either
** source code or executable form, except in compliance with the terms and
** conditions of the SLA.
**
** All software distributed under the SLA is provided strictly on an
** "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED,
** AND LICENSOR HEREBY DISCLAIMS ALL SUCH WARRANTIES, INCLUDING WITHOUT
** LIMITATION, ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
** PURPOSE, QUIET ENJOYMENT, OR NON-INFRINGEMENT. See the SLA for specific
** language governing rights and limitations under the SLA.
**
** Project: .NET OPC UA SDK information model for namespace http://yourorganisation.org/MethodModel/
**
** Description: OPC Unified Architecture Software Development Kit.
**
** The complete license agreement can be found here:
** http://unifiedautomation.com/License/SLA/2.7/
**
** Created: 19.12.2018
**
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using UnifiedAutomation.UaBase;

namespace THI.MM
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class DataTypes
    {
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class Objects
    {
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ControllerEventType ObjectType.
        /// </summary>
        public const uint ControllerEventType = 1004;

        /// <summary>
        /// The identifier for the EasyControllerType ObjectType.
        /// </summary>
        public const uint EasyControllerType = 1002;

        /// <summary>
        /// The identifier for the PLCControllerType ObjectType.
        /// </summary>
        public const uint PLCControllerType = 1003;

    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the Click Method.
        /// </summary>
        public const uint EasyControllerType_Click = 7001;

    }
    #endregion

    #region ReferenceType Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTyped in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class ReferenceTypes
    {
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the State Variable.
        /// </summary>
        public const uint ControllerEventType_State = 6001;

    }
    #endregion

    #region VariableTypes Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class VariableTypes
    {
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class DataTypeIds
    {
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the EasyControllerType_Click Method.
        /// </summary>
        public static readonly ExpandedNodeId EasyControllerType_Click = new ExpandedNodeId(Methods.EasyControllerType_Click, Namespaces.MM);

    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class ObjectIds
    {
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ControllerEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ControllerEventType = new ExpandedNodeId(ObjectTypes.ControllerEventType, Namespaces.MM);

        /// <summary>
        /// The identifier for the EasyControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId EasyControllerType = new ExpandedNodeId(ObjectTypes.EasyControllerType, Namespaces.MM);

        /// <summary>
        /// The identifier for the PLCControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PLCControllerType = new ExpandedNodeId(ObjectTypes.PLCControllerType, Namespaces.MM);

    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class ReferenceTypeIds
    {
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ControllerEventType_State Variable.
        /// </summary>
        public static readonly ExpandedNodeId ControllerEventType_State = new ExpandedNodeId(Variables.ControllerEventType_State, Namespaces.MM);

    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableType in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.6.2")]
    public static partial class VariableTypeIds
    {
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Click component.
        /// </summary>
        public const string Click = "Click";
        /// <summary>
        /// The BrowseName for the ControllerEventType component.
        /// </summary>
        public const string ControllerEventType = "ControllerEventType";
        /// <summary>
        /// The BrowseName for the EasyControllerType component.
        /// </summary>
        public const string EasyControllerType = "EasyControllerType";
        /// <summary>
        /// The BrowseName for the PLCControllerType component.
        /// </summary>
        public const string PLCControllerType = "PLCControllerType";
        /// <summary>
        /// The BrowseName for the State component.
        /// </summary>
        public const string State = "State";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the Model.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the MM namespace.
        /// </summary>
        public const string MM = "http://yourorganisation.org/MethodModel/";

        /// <summary>
        /// The URI for the MMXsd namespace.
        /// </summary>
        public const string MMXsd = "http://yourorganisation.org/MethodModel/Types.xsd";
    }
    #endregion
}

