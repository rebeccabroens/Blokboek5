﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Owl_learn_Blokboek5
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider();
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
                _provider = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider();
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

namespace Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo
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
            _typeNameTable = new string[25];
            _typeNameTable[0] = "Owl_learn_Blokboek5.BewerkAccount";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "Owl_learn_Blokboek5.BewerkLes";
            _typeNameTable[4] = "Owl_learn_Blokboek5.BewerkVak";
            _typeNameTable[5] = "Owl_learn_Blokboek5.DashboardAdmin";
            _typeNameTable[6] = "Owl_learn_Blokboek5.DashboardConsulent";
            _typeNameTable[7] = "Owl_learn_Blokboek5.DashboardLeerling";
            _typeNameTable[8] = "Owl_learn_Blokboek5.LesPage";
            _typeNameTable[9] = "Owl_learn_Blokboek5.MainPage";
            _typeNameTable[10] = "Owl_learn_Blokboek5.PlanningLes";
            _typeNameTable[11] = "Owl_learn_Blokboek5.PlanningToets";
            _typeNameTable[12] = "Owl_learn_Blokboek5.Toetskiezen";
            _typeNameTable[13] = "Owl_learn_Blokboek5.ToetsPage";
            _typeNameTable[14] = "Owl_learn_Blokboek5.ToevoegAccount";
            _typeNameTable[15] = "Owl_learn_Blokboek5.ToevoegLes";
            _typeNameTable[16] = "Owl_learn_Blokboek5.ToevoegLesonderwerp";
            _typeNameTable[17] = "Owl_learn_Blokboek5.ToevoegPlanningLes";
            _typeNameTable[18] = "Owl_learn_Blokboek5.ToevoegPlanningToets";
            _typeNameTable[19] = "Owl_learn_Blokboek5.ToevoegVak";
            _typeNameTable[20] = "Owl_learn_Blokboek5.ToevoegVraag";
            _typeNameTable[21] = "Owl_learn_Blokboek5.VerwijderAccount";
            _typeNameTable[22] = "Owl_learn_Blokboek5.VerwijderLes";
            _typeNameTable[23] = "Owl_learn_Blokboek5.VerwijderLesonderwerp";
            _typeNameTable[24] = "Owl_learn_Blokboek5.VerwijderVak";

            _typeTable = new global::System.Type[25];
            _typeTable[0] = typeof(global::Owl_learn_Blokboek5.BewerkAccount);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::Owl_learn_Blokboek5.BewerkLes);
            _typeTable[4] = typeof(global::Owl_learn_Blokboek5.BewerkVak);
            _typeTable[5] = typeof(global::Owl_learn_Blokboek5.DashboardAdmin);
            _typeTable[6] = typeof(global::Owl_learn_Blokboek5.DashboardConsulent);
            _typeTable[7] = typeof(global::Owl_learn_Blokboek5.DashboardLeerling);
            _typeTable[8] = typeof(global::Owl_learn_Blokboek5.LesPage);
            _typeTable[9] = typeof(global::Owl_learn_Blokboek5.MainPage);
            _typeTable[10] = typeof(global::Owl_learn_Blokboek5.PlanningLes);
            _typeTable[11] = typeof(global::Owl_learn_Blokboek5.PlanningToets);
            _typeTable[12] = typeof(global::Owl_learn_Blokboek5.Toetskiezen);
            _typeTable[13] = typeof(global::Owl_learn_Blokboek5.ToetsPage);
            _typeTable[14] = typeof(global::Owl_learn_Blokboek5.ToevoegAccount);
            _typeTable[15] = typeof(global::Owl_learn_Blokboek5.ToevoegLes);
            _typeTable[16] = typeof(global::Owl_learn_Blokboek5.ToevoegLesonderwerp);
            _typeTable[17] = typeof(global::Owl_learn_Blokboek5.ToevoegPlanningLes);
            _typeTable[18] = typeof(global::Owl_learn_Blokboek5.ToevoegPlanningToets);
            _typeTable[19] = typeof(global::Owl_learn_Blokboek5.ToevoegVak);
            _typeTable[20] = typeof(global::Owl_learn_Blokboek5.ToevoegVraag);
            _typeTable[21] = typeof(global::Owl_learn_Blokboek5.VerwijderAccount);
            _typeTable[22] = typeof(global::Owl_learn_Blokboek5.VerwijderLes);
            _typeTable[23] = typeof(global::Owl_learn_Blokboek5.VerwijderLesonderwerp);
            _typeTable[24] = typeof(global::Owl_learn_Blokboek5.VerwijderVak);
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

        private object Activate_0_BewerkAccount() { return new global::Owl_learn_Blokboek5.BewerkAccount(); }
        private object Activate_3_BewerkLes() { return new global::Owl_learn_Blokboek5.BewerkLes(); }
        private object Activate_4_BewerkVak() { return new global::Owl_learn_Blokboek5.BewerkVak(); }
        private object Activate_5_DashboardAdmin() { return new global::Owl_learn_Blokboek5.DashboardAdmin(); }
        private object Activate_6_DashboardConsulent() { return new global::Owl_learn_Blokboek5.DashboardConsulent(); }
        private object Activate_7_DashboardLeerling() { return new global::Owl_learn_Blokboek5.DashboardLeerling(); }
        private object Activate_8_LesPage() { return new global::Owl_learn_Blokboek5.LesPage(); }
        private object Activate_9_MainPage() { return new global::Owl_learn_Blokboek5.MainPage(); }
        private object Activate_10_PlanningLes() { return new global::Owl_learn_Blokboek5.PlanningLes(); }
        private object Activate_11_PlanningToets() { return new global::Owl_learn_Blokboek5.PlanningToets(); }
        private object Activate_12_Toetskiezen() { return new global::Owl_learn_Blokboek5.Toetskiezen(); }
        private object Activate_13_ToetsPage() { return new global::Owl_learn_Blokboek5.ToetsPage(); }
        private object Activate_14_ToevoegAccount() { return new global::Owl_learn_Blokboek5.ToevoegAccount(); }
        private object Activate_15_ToevoegLes() { return new global::Owl_learn_Blokboek5.ToevoegLes(); }
        private object Activate_16_ToevoegLesonderwerp() { return new global::Owl_learn_Blokboek5.ToevoegLesonderwerp(); }
        private object Activate_17_ToevoegPlanningLes() { return new global::Owl_learn_Blokboek5.ToevoegPlanningLes(); }
        private object Activate_18_ToevoegPlanningToets() { return new global::Owl_learn_Blokboek5.ToevoegPlanningToets(); }
        private object Activate_19_ToevoegVak() { return new global::Owl_learn_Blokboek5.ToevoegVak(); }
        private object Activate_20_ToevoegVraag() { return new global::Owl_learn_Blokboek5.ToevoegVraag(); }
        private object Activate_21_VerwijderAccount() { return new global::Owl_learn_Blokboek5.VerwijderAccount(); }
        private object Activate_22_VerwijderLes() { return new global::Owl_learn_Blokboek5.VerwijderLes(); }
        private object Activate_23_VerwijderLesonderwerp() { return new global::Owl_learn_Blokboek5.VerwijderLesonderwerp(); }
        private object Activate_24_VerwijderVak() { return new global::Owl_learn_Blokboek5.VerwijderVak(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Owl_learn_Blokboek5.BewerkAccount
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_BewerkAccount;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Owl_learn_Blokboek5.BewerkLes
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_BewerkLes;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  Owl_learn_Blokboek5.BewerkVak
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_BewerkVak;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Owl_learn_Blokboek5.DashboardAdmin
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_DashboardAdmin;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  Owl_learn_Blokboek5.DashboardConsulent
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_DashboardConsulent;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  Owl_learn_Blokboek5.DashboardLeerling
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_DashboardLeerling;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  Owl_learn_Blokboek5.LesPage
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_LesPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Owl_learn_Blokboek5.MainPage
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Owl_learn_Blokboek5.PlanningLes
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_PlanningLes;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  Owl_learn_Blokboek5.PlanningToets
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_PlanningToets;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  Owl_learn_Blokboek5.Toetskiezen
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Toetskiezen;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  Owl_learn_Blokboek5.ToetsPage
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_ToetsPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  Owl_learn_Blokboek5.ToevoegAccount
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_ToevoegAccount;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  Owl_learn_Blokboek5.ToevoegLes
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_ToevoegLes;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  Owl_learn_Blokboek5.ToevoegLesonderwerp
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_ToevoegLesonderwerp;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  Owl_learn_Blokboek5.ToevoegPlanningLes
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_ToevoegPlanningLes;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  Owl_learn_Blokboek5.ToevoegPlanningToets
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_ToevoegPlanningToets;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  Owl_learn_Blokboek5.ToevoegVak
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_19_ToevoegVak;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  Owl_learn_Blokboek5.ToevoegVraag
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_20_ToevoegVraag;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 21:   //  Owl_learn_Blokboek5.VerwijderAccount
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_21_VerwijderAccount;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  Owl_learn_Blokboek5.VerwijderLes
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_22_VerwijderLes;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 23:   //  Owl_learn_Blokboek5.VerwijderLesonderwerp
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_23_VerwijderLesonderwerp;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 24:   //  Owl_learn_Blokboek5.VerwijderVak
                userType = new global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_24_VerwijderVak;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }



        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlMember xamlMember = null;
            // No Local Properties
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
    internal class XamlUserType : global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlSystemBaseType
    {
        global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider _provider;
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

        public XamlUserType(global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
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
        global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Owl_learn_Blokboek5.Owl_learn_Blokboek5_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
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

