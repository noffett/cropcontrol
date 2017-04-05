﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace CropRotate
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace CropRotate.CropRotate_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[17];
            _typeNameTable[0] = "CropRotate.SelectionAreaControl";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[2] = "Double";
            _typeNameTable[3] = "CropRotate.CropRotateControl";
            _typeNameTable[4] = "Windows.UI.Xaml.Media.ImageSource";
            _typeNameTable[5] = "Windows.Foundation.Rect";
            _typeNameTable[6] = "Windows.Foundation.Point";
            _typeNameTable[7] = "Boolean";
            _typeNameTable[8] = "CropRotate.MainPage";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[10] = "CropRotate.NineGridResizing";
            _typeNameTable[11] = "CropRotate.ResizeHandle";
            _typeNameTable[12] = "Windows.UI.Xaml.Controls.Control";
            _typeNameTable[13] = "CropRotate.ResizeHandleOrientation";
            _typeNameTable[14] = "System.Enum";
            _typeNameTable[15] = "System.ValueType";
            _typeNameTable[16] = "Object";

            _typeTable = new global::System.Type[17];
            _typeTable[0] = typeof(global::CropRotate.SelectionAreaControl);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[2] = typeof(global::System.Double);
            _typeTable[3] = typeof(global::CropRotate.CropRotateControl);
            _typeTable[4] = typeof(global::Windows.UI.Xaml.Media.ImageSource);
            _typeTable[5] = typeof(global::Windows.Foundation.Rect);
            _typeTable[6] = typeof(global::Windows.Foundation.Point);
            _typeTable[7] = typeof(global::System.Boolean);
            _typeTable[8] = typeof(global::CropRotate.MainPage);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[10] = typeof(global::CropRotate.NineGridResizing);
            _typeTable[11] = typeof(global::CropRotate.ResizeHandle);
            _typeTable[12] = typeof(global::Windows.UI.Xaml.Controls.Control);
            _typeTable[13] = typeof(global::CropRotate.ResizeHandleOrientation);
            _typeTable[14] = typeof(global::System.Enum);
            _typeTable[15] = typeof(global::System.ValueType);
            _typeTable[16] = typeof(global::System.Object);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_SelectionAreaControl() { return new global::CropRotate.SelectionAreaControl(); }
        private object Activate_3_CropRotateControl() { return new global::CropRotate.CropRotateControl(); }
        private object Activate_8_MainPage() { return new global::CropRotate.MainPage(); }
        private object Activate_10_NineGridResizing() { return new global::CropRotate.NineGridResizing(); }
        private object Activate_11_ResizeHandle() { return new global::CropRotate.ResizeHandle(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  CropRotate.SelectionAreaControl
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_0_SelectionAreaControl;
                userType.AddMemberName("RotationAngle");
                userType.AddMemberName("HorizontalOffset");
                userType.AddMemberName("VerticalOffset");
                userType.AddMemberName("VisualWidth");
                userType.AddMemberName("VisualHeight");
                userType.AddMemberName("RotationAnchorPoint");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Double
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  CropRotate.CropRotateControl
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_3_CropRotateControl;
                userType.AddMemberName("Image");
                userType.AddMemberName("CropArea");
                userType.AddMemberName("RotationAngle");
                userType.AddMemberName("RotationCenter");
                userType.AddMemberName("Flipped");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  Windows.UI.Xaml.Media.ImageSource
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  Windows.Foundation.Rect
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.Foundation.Point
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Boolean
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  CropRotate.MainPage
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  CropRotate.NineGridResizing
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_10_NineGridResizing;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  CropRotate.ResizeHandle
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Control"));
                userType.Activator = Activate_11_ResizeHandle;
                userType.AddMemberName("Orientation");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  Windows.UI.Xaml.Controls.Control
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 13:   //  CropRotate.ResizeHandleOrientation
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Enum"));
                userType.AddEnumValue("None", global::CropRotate.ResizeHandleOrientation.None);
                userType.AddEnumValue("Horizontal", global::CropRotate.ResizeHandleOrientation.Horizontal);
                userType.AddEnumValue("Vertical", global::CropRotate.ResizeHandleOrientation.Vertical);
                userType.AddEnumValue("HorizontalAndVertical", global::CropRotate.ResizeHandleOrientation.HorizontalAndVertical);
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  System.Enum
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                xamlType = userType;
                break;

            case 15:   //  System.ValueType
                userType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 16:   //  Object
                xamlType = new global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_SelectionAreaControl_RotationAngle(object instance)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            return that.RotationAngle;
        }
        private void set_0_SelectionAreaControl_RotationAngle(object instance, object Value)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            that.RotationAngle = (global::System.Double)Value;
        }
        private object get_1_SelectionAreaControl_HorizontalOffset(object instance)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            return that.HorizontalOffset;
        }
        private void set_1_SelectionAreaControl_HorizontalOffset(object instance, object Value)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            that.HorizontalOffset = (global::System.Double)Value;
        }
        private object get_2_SelectionAreaControl_VerticalOffset(object instance)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            return that.VerticalOffset;
        }
        private void set_2_SelectionAreaControl_VerticalOffset(object instance, object Value)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            that.VerticalOffset = (global::System.Double)Value;
        }
        private object get_3_SelectionAreaControl_VisualWidth(object instance)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            return that.VisualWidth;
        }
        private void set_3_SelectionAreaControl_VisualWidth(object instance, object Value)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            that.VisualWidth = (global::System.Double)Value;
        }
        private object get_4_SelectionAreaControl_VisualHeight(object instance)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            return that.VisualHeight;
        }
        private void set_4_SelectionAreaControl_VisualHeight(object instance, object Value)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            that.VisualHeight = (global::System.Double)Value;
        }
        private object get_5_SelectionAreaControl_RotationAnchorPoint(object instance)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            return that.RotationAnchorPoint;
        }
        private void set_5_SelectionAreaControl_RotationAnchorPoint(object instance, object Value)
        {
            var that = (global::CropRotate.SelectionAreaControl)instance;
            that.RotationAnchorPoint = (global::System.Double)Value;
        }
        private object get_6_CropRotateControl_Image(object instance)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            return that.Image;
        }
        private void set_6_CropRotateControl_Image(object instance, object Value)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            that.Image = (global::Windows.UI.Xaml.Media.ImageSource)Value;
        }
        private object get_7_CropRotateControl_CropArea(object instance)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            return that.CropArea;
        }
        private void set_7_CropRotateControl_CropArea(object instance, object Value)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            that.CropArea = (global::Windows.Foundation.Rect)Value;
        }
        private object get_8_CropRotateControl_RotationAngle(object instance)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            return that.RotationAngle;
        }
        private void set_8_CropRotateControl_RotationAngle(object instance, object Value)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            that.RotationAngle = (global::System.Double)Value;
        }
        private object get_9_CropRotateControl_RotationCenter(object instance)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            return that.RotationCenter;
        }
        private void set_9_CropRotateControl_RotationCenter(object instance, object Value)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            that.RotationCenter = (global::Windows.Foundation.Point)Value;
        }
        private object get_10_CropRotateControl_Flipped(object instance)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            return that.Flipped;
        }
        private void set_10_CropRotateControl_Flipped(object instance, object Value)
        {
            var that = (global::CropRotate.CropRotateControl)instance;
            that.Flipped = (global::System.Boolean)Value;
        }
        private object get_11_ResizeHandle_Orientation(object instance)
        {
            var that = (global::CropRotate.ResizeHandle)instance;
            return that.Orientation;
        }
        private void set_11_ResizeHandle_Orientation(object instance, object Value)
        {
            var that = (global::CropRotate.ResizeHandle)instance;
            that.Orientation = (global::CropRotate.ResizeHandleOrientation)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::CropRotate.CropRotate_XamlTypeInfo.XamlMember xamlMember = null;
            global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "CropRotate.SelectionAreaControl.RotationAngle":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.SelectionAreaControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "RotationAngle", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_SelectionAreaControl_RotationAngle;
                xamlMember.Setter = set_0_SelectionAreaControl_RotationAngle;
                break;
            case "CropRotate.SelectionAreaControl.HorizontalOffset":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.SelectionAreaControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "HorizontalOffset", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_SelectionAreaControl_HorizontalOffset;
                xamlMember.Setter = set_1_SelectionAreaControl_HorizontalOffset;
                break;
            case "CropRotate.SelectionAreaControl.VerticalOffset":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.SelectionAreaControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "VerticalOffset", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_SelectionAreaControl_VerticalOffset;
                xamlMember.Setter = set_2_SelectionAreaControl_VerticalOffset;
                break;
            case "CropRotate.SelectionAreaControl.VisualWidth":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.SelectionAreaControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "VisualWidth", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_SelectionAreaControl_VisualWidth;
                xamlMember.Setter = set_3_SelectionAreaControl_VisualWidth;
                break;
            case "CropRotate.SelectionAreaControl.VisualHeight":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.SelectionAreaControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "VisualHeight", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_4_SelectionAreaControl_VisualHeight;
                xamlMember.Setter = set_4_SelectionAreaControl_VisualHeight;
                break;
            case "CropRotate.SelectionAreaControl.RotationAnchorPoint":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.SelectionAreaControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "RotationAnchorPoint", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_5_SelectionAreaControl_RotationAnchorPoint;
                xamlMember.Setter = set_5_SelectionAreaControl_RotationAnchorPoint;
                break;
            case "CropRotate.CropRotateControl.Image":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.CropRotateControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "Image", "Windows.UI.Xaml.Media.ImageSource");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_6_CropRotateControl_Image;
                xamlMember.Setter = set_6_CropRotateControl_Image;
                break;
            case "CropRotate.CropRotateControl.CropArea":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.CropRotateControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "CropArea", "Windows.Foundation.Rect");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_7_CropRotateControl_CropArea;
                xamlMember.Setter = set_7_CropRotateControl_CropArea;
                break;
            case "CropRotate.CropRotateControl.RotationAngle":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.CropRotateControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "RotationAngle", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_8_CropRotateControl_RotationAngle;
                xamlMember.Setter = set_8_CropRotateControl_RotationAngle;
                break;
            case "CropRotate.CropRotateControl.RotationCenter":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.CropRotateControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "RotationCenter", "Windows.Foundation.Point");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_9_CropRotateControl_RotationCenter;
                xamlMember.Setter = set_9_CropRotateControl_RotationCenter;
                break;
            case "CropRotate.CropRotateControl.Flipped":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.CropRotateControl");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "Flipped", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_10_CropRotateControl_Flipped;
                xamlMember.Setter = set_10_CropRotateControl_Flipped;
                break;
            case "CropRotate.ResizeHandle.Orientation":
                userType = (global::CropRotate.CropRotate_XamlTypeInfo.XamlUserType)GetXamlTypeByName("CropRotate.ResizeHandle");
                xamlMember = new global::CropRotate.CropRotate_XamlTypeInfo.XamlMember(this, "Orientation", "CropRotate.ResizeHandleOrientation");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_11_ResizeHandle_Orientation;
                xamlMember.Setter = set_11_ResizeHandle_Orientation;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::CropRotate.CropRotate_XamlTypeInfo.XamlSystemBaseType
    {
        global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::CropRotate.CropRotate_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
