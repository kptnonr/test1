﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace test_uygulamasi
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the test_uygulamasiRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("30033c29-b9a4-49eb-ac65-41b772e80d7b")]
    public partial class test_uygulamasiRepository : RepoGenBaseFolder
    {
        static test_uygulamasiRepository instance = new test_uygulamasiRepository();
        test_uygulamasiRepositoryFolders.GoogleGoogleChromeAppFolder _googlegooglechrome;
        test_uygulamasiRepositoryFolders.OPTiiMWebApplicationGoogleChromeAppFolder _optiimwebapplicationgooglechrome;
        test_uygulamasiRepositoryFolders.InternetExplorer11AppFolder _internetexplorer11;
        test_uygulamasiRepositoryFolders.OPTiiMWebApplicationAppFolder _optiimwebapplication;
        test_uygulamasiRepositoryFolders.OturumAcınGoogleHesaplarıAppFolder _oturumacıngooglehesapları;
        test_uygulamasiRepositoryFolders.DoYouWantGoogleSmartLockToSaveYoAppFolder _doyouwantgooglesmartlocktosaveyo;
        test_uygulamasiRepositoryFolders.DropdownAppFolder _dropdown;
        RepoItemInfo _signingoogleaccountsgooglechromInfo;
        RepoItemInfo _insurancewebhomegooglechromeInfo;
        RepoItemInfo _insurancewebautomobileinstantquoteInfo;

        /// <summary>
        /// Gets the singleton class instance representing the test_uygulamasiRepository element repository.
        /// </summary>
        [RepositoryFolder("30033c29-b9a4-49eb-ac65-41b772e80d7b")]
        public static test_uygulamasiRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public test_uygulamasiRepository() 
            : base("test_uygulamasiRepository", "/", null, 0, false, "30033c29-b9a4-49eb-ac65-41b772e80d7b", ".\\RepositoryImages\\test_uygulamasiRepository30033c29.rximgres")
        {
            _googlegooglechrome = new test_uygulamasiRepositoryFolders.GoogleGoogleChromeAppFolder(this);
            _optiimwebapplicationgooglechrome = new test_uygulamasiRepositoryFolders.OPTiiMWebApplicationGoogleChromeAppFolder(this);
            _internetexplorer11 = new test_uygulamasiRepositoryFolders.InternetExplorer11AppFolder(this);
            _optiimwebapplication = new test_uygulamasiRepositoryFolders.OPTiiMWebApplicationAppFolder(this);
            _oturumacıngooglehesapları = new test_uygulamasiRepositoryFolders.OturumAcınGoogleHesaplarıAppFolder(this);
            _doyouwantgooglesmartlocktosaveyo = new test_uygulamasiRepositoryFolders.DoYouWantGoogleSmartLockToSaveYoAppFolder(this);
            _dropdown = new test_uygulamasiRepositoryFolders.DropdownAppFolder(this);
            _signingoogleaccountsgooglechromInfo = new RepoItemInfo(this, "SignInGoogleAccountsGoogleChrom", "/form[@title~'^Sign\\ in\\ -\\ Google\\ Accounts']", 30000, null, "0c584453-307a-4459-ad5a-e2037ad2e20f");
            _insurancewebhomegooglechromeInfo = new RepoItemInfo(this, "InsuranceWebHomeGoogleChrome", "/form[@title~'^InsuranceWeb:\\ Home\\ -\\ Goog']", 30000, null, "c4133ba1-dbbb-43ee-858e-bdbc0ef64898");
            _insurancewebautomobileinstantquoteInfo = new RepoItemInfo(this, "InsuranceWebAutomobileInstantQuote", "/form[@title~'^InsuranceWeb:\\ Automobile\\ ']", 30000, null, "b1d6a9d5-b815-4174-8b1e-d0bba111be33");
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("30033c29-b9a4-49eb-ac65-41b772e80d7b")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SignInGoogleAccountsGoogleChrom item.
        /// </summary>
        [RepositoryItem("0c584453-307a-4459-ad5a-e2037ad2e20f")]
        public virtual Ranorex.Form SignInGoogleAccountsGoogleChrom
        {
            get
            {
                 return _signingoogleaccountsgooglechromInfo.CreateAdapter<Ranorex.Form>(true);
            }
        }

        /// <summary>
        /// The SignInGoogleAccountsGoogleChrom item info.
        /// </summary>
        [RepositoryItemInfo("0c584453-307a-4459-ad5a-e2037ad2e20f")]
        public virtual RepoItemInfo SignInGoogleAccountsGoogleChromInfo
        {
            get
            {
                return _signingoogleaccountsgooglechromInfo;
            }
        }

        /// <summary>
        /// The InsuranceWebHomeGoogleChrome item.
        /// </summary>
        [RepositoryItem("c4133ba1-dbbb-43ee-858e-bdbc0ef64898")]
        public virtual Ranorex.Form InsuranceWebHomeGoogleChrome
        {
            get
            {
                 return _insurancewebhomegooglechromeInfo.CreateAdapter<Ranorex.Form>(true);
            }
        }

        /// <summary>
        /// The InsuranceWebHomeGoogleChrome item info.
        /// </summary>
        [RepositoryItemInfo("c4133ba1-dbbb-43ee-858e-bdbc0ef64898")]
        public virtual RepoItemInfo InsuranceWebHomeGoogleChromeInfo
        {
            get
            {
                return _insurancewebhomegooglechromeInfo;
            }
        }

        /// <summary>
        /// The InsuranceWebAutomobileInstantQuote item.
        /// </summary>
        [RepositoryItem("b1d6a9d5-b815-4174-8b1e-d0bba111be33")]
        public virtual Ranorex.Form InsuranceWebAutomobileInstantQuote
        {
            get
            {
                 return _insurancewebautomobileinstantquoteInfo.CreateAdapter<Ranorex.Form>(true);
            }
        }

        /// <summary>
        /// The InsuranceWebAutomobileInstantQuote item info.
        /// </summary>
        [RepositoryItemInfo("b1d6a9d5-b815-4174-8b1e-d0bba111be33")]
        public virtual RepoItemInfo InsuranceWebAutomobileInstantQuoteInfo
        {
            get
            {
                return _insurancewebautomobileinstantquoteInfo;
            }
        }

        /// <summary>
        /// The GoogleGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("6dc50128-def1-48cc-916b-f7cb1047796e")]
        public virtual test_uygulamasiRepositoryFolders.GoogleGoogleChromeAppFolder GoogleGoogleChrome
        {
            get { return _googlegooglechrome; }
        }

        /// <summary>
        /// The OPTiiMWebApplicationGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("cac1134e-9696-4742-bc48-9e758b12b11e")]
        public virtual test_uygulamasiRepositoryFolders.OPTiiMWebApplicationGoogleChromeAppFolder OPTiiMWebApplicationGoogleChrome
        {
            get { return _optiimwebapplicationgooglechrome; }
        }

        /// <summary>
        /// The InternetExplorer11 folder.
        /// </summary>
        [RepositoryFolder("d4e4ab3f-4c68-44bd-be26-fb1609b75174")]
        public virtual test_uygulamasiRepositoryFolders.InternetExplorer11AppFolder InternetExplorer11
        {
            get { return _internetexplorer11; }
        }

        /// <summary>
        /// The OPTiiMWebApplication folder.
        /// </summary>
        [RepositoryFolder("562a4495-f75d-4ac3-8d6e-be176d98c1cf")]
        public virtual test_uygulamasiRepositoryFolders.OPTiiMWebApplicationAppFolder OPTiiMWebApplication
        {
            get { return _optiimwebapplication; }
        }

        /// <summary>
        /// The OturumAcınGoogleHesapları folder.
        /// </summary>
        [RepositoryFolder("5af16a35-9361-4db1-8410-0984e1154c9b")]
        public virtual test_uygulamasiRepositoryFolders.OturumAcınGoogleHesaplarıAppFolder OturumAcınGoogleHesapları
        {
            get { return _oturumacıngooglehesapları; }
        }

        /// <summary>
        /// The DoYouWantGoogleSmartLockToSaveYo folder.
        /// </summary>
        [RepositoryFolder("e277a907-a6e4-4b81-9e27-cc97e2090d91")]
        public virtual test_uygulamasiRepositoryFolders.DoYouWantGoogleSmartLockToSaveYoAppFolder DoYouWantGoogleSmartLockToSaveYo
        {
            get { return _doyouwantgooglesmartlocktosaveyo; }
        }

        /// <summary>
        /// The Dropdown folder.
        /// </summary>
        [RepositoryFolder("56b692ce-a8ce-4db4-a365-9ba2e7e9a243")]
        public virtual test_uygulamasiRepositoryFolders.DropdownAppFolder Dropdown
        {
            get { return _dropdown; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class test_uygulamasiRepositoryFolders
    {
        /// <summary>
        /// The GoogleGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("6dc50128-def1-48cc-916b-f7cb1047796e")]
        public partial class GoogleGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _element1246513264Info;
            RepoItemInfo _addressandsearchbarInfo;

            /// <summary>
            /// Creates a new GoogleGoogleChrome  folder.
            /// </summary>
            public GoogleGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("GoogleGoogleChrome", "/form[@title='Google - Google Chrome']", parentFolder, 30000, null, true, "6dc50128-def1-48cc-916b-f7cb1047796e", "")
            {
                _element1246513264Info = new RepoItemInfo(this, "Element1246513264", "element[@controlid='-1246513264']", 30000, null, "8e5d8de2-78fd-4b89-b1d0-8e543a431d1c");
                _addressandsearchbarInfo = new RepoItemInfo(this, "AddressAndSearchBar", "container[@accessiblename='Google - Google Chrome']/container[@accessiblename='Google Chrome']/container[2]/container[2]/container[@accessiblerole='Client']/container[1]/text[@accessiblename='Address and search bar']", 30000, null, "f5972d28-f86f-4902-a2d0-11af88956957");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6dc50128-def1-48cc-916b-f7cb1047796e")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6dc50128-def1-48cc-916b-f7cb1047796e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Element1246513264 item.
            /// </summary>
            [RepositoryItem("8e5d8de2-78fd-4b89-b1d0-8e543a431d1c")]
            public virtual Ranorex.Unknown Element1246513264
            {
                get
                {
                    return _element1246513264Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element1246513264 item info.
            /// </summary>
            [RepositoryItemInfo("8e5d8de2-78fd-4b89-b1d0-8e543a431d1c")]
            public virtual RepoItemInfo Element1246513264Info
            {
                get
                {
                    return _element1246513264Info;
                }
            }

            /// <summary>
            /// The AddressAndSearchBar item.
            /// </summary>
            [RepositoryItem("f5972d28-f86f-4902-a2d0-11af88956957")]
            public virtual Ranorex.Text AddressAndSearchBar
            {
                get
                {
                    return _addressandsearchbarInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AddressAndSearchBar item info.
            /// </summary>
            [RepositoryItemInfo("f5972d28-f86f-4902-a2d0-11af88956957")]
            public virtual RepoItemInfo AddressAndSearchBarInfo
            {
                get
                {
                    return _addressandsearchbarInfo;
                }
            }
        }

        /// <summary>
        /// The OPTiiMWebApplicationGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("cac1134e-9696-4742-bc48-9e758b12b11e")]
        public partial class OPTiiMWebApplicationGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _element723846224Info;
            RepoItemInfo _element640029952Info;
            RepoItemInfo _closeInfo;
            RepoItemInfo _element730569856Info;

            /// <summary>
            /// Creates a new OPTiiMWebApplicationGoogleChrome  folder.
            /// </summary>
            public OPTiiMWebApplicationGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OPTiiMWebApplicationGoogleChrome", "/form[@title~'^OPTiiM\\ \\|\\ Web\\ Application\\ ']", parentFolder, 30000, null, true, "cac1134e-9696-4742-bc48-9e758b12b11e", "")
            {
                _element723846224Info = new RepoItemInfo(this, "Element723846224", "element[@controlid='723846224']", 30000, null, "fff3288d-cd86-48e0-939e-e3a952bcd2fe");
                _element640029952Info = new RepoItemInfo(this, "Element640029952", "element[@controlid='640029952']", 30000, null, "2a6f7a83-0264-41d3-be00-9f6a0d2f86c1");
                _closeInfo = new RepoItemInfo(this, "Close", "container[@accessiblename~'^General\\ Troubleshooting\\ -']/container[@accessiblename='Google Chrome']//tabpage[@accessiblename~'^General\\ Troubleshooting\\ -']/button[@accessiblename='Close']", 30000, null, "302a948e-86b9-4ad8-b971-502c379830d0");
                _element730569856Info = new RepoItemInfo(this, "Element730569856", "element[@controlid='730569856']", 30000, null, "077e3e81-5ae8-48b1-a3d2-a58d8a251ec7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cac1134e-9696-4742-bc48-9e758b12b11e")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cac1134e-9696-4742-bc48-9e758b12b11e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Element723846224 item.
            /// </summary>
            [RepositoryItem("fff3288d-cd86-48e0-939e-e3a952bcd2fe")]
            public virtual Ranorex.Unknown Element723846224
            {
                get
                {
                    return _element723846224Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element723846224 item info.
            /// </summary>
            [RepositoryItemInfo("fff3288d-cd86-48e0-939e-e3a952bcd2fe")]
            public virtual RepoItemInfo Element723846224Info
            {
                get
                {
                    return _element723846224Info;
                }
            }

            /// <summary>
            /// The Element640029952 item.
            /// </summary>
            [RepositoryItem("2a6f7a83-0264-41d3-be00-9f6a0d2f86c1")]
            public virtual Ranorex.Unknown Element640029952
            {
                get
                {
                    return _element640029952Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element640029952 item info.
            /// </summary>
            [RepositoryItemInfo("2a6f7a83-0264-41d3-be00-9f6a0d2f86c1")]
            public virtual RepoItemInfo Element640029952Info
            {
                get
                {
                    return _element640029952Info;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("302a948e-86b9-4ad8-b971-502c379830d0")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("302a948e-86b9-4ad8-b971-502c379830d0")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }

            /// <summary>
            /// The Element730569856 item.
            /// </summary>
            [RepositoryItem("077e3e81-5ae8-48b1-a3d2-a58d8a251ec7")]
            public virtual Ranorex.Unknown Element730569856
            {
                get
                {
                    return _element730569856Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Element730569856 item info.
            /// </summary>
            [RepositoryItemInfo("077e3e81-5ae8-48b1-a3d2-a58d8a251ec7")]
            public virtual RepoItemInfo Element730569856Info
            {
                get
                {
                    return _element730569856Info;
                }
            }
        }

        /// <summary>
        /// The InternetExplorer11AppFolder folder.
        /// </summary>
        [RepositoryFolder("d4e4ab3f-4c68-44bd-be26-fb1609b75174")]
        public partial class InternetExplorer11AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _radiobuttondontuserecommendedsettingsInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new InternetExplorer11  folder.
            /// </summary>
            public InternetExplorer11AppFolder(RepoGenBaseFolder parentFolder) :
                    base("InternetExplorer11", "/form[@title='Internet Explorer 11']", parentFolder, 30000, null, true, "d4e4ab3f-4c68-44bd-be26-fb1609b75174", "")
            {
                _radiobuttondontuserecommendedsettingsInfo = new RepoItemInfo(this, "RadioButtonDontUseRecommendedSettings", "radiobutton[@text~'^&Don’t\\ use\\ recommended\\ se']", 30000, null, "e98565d4-d3b1-4e02-a3ca-e2535abe8ba8");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@text='&OK']", 30000, null, "cc4e37a9-d5ae-45b9-b451-9f02e9b89cf6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d4e4ab3f-4c68-44bd-be26-fb1609b75174")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d4e4ab3f-4c68-44bd-be26-fb1609b75174")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RadioButtonDontUseRecommendedSettings item.
            /// </summary>
            [RepositoryItem("e98565d4-d3b1-4e02-a3ca-e2535abe8ba8")]
            public virtual Ranorex.RadioButton RadioButtonDontUseRecommendedSettings
            {
                get
                {
                    return _radiobuttondontuserecommendedsettingsInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RadioButtonDontUseRecommendedSettings item info.
            /// </summary>
            [RepositoryItemInfo("e98565d4-d3b1-4e02-a3ca-e2535abe8ba8")]
            public virtual RepoItemInfo RadioButtonDontUseRecommendedSettingsInfo
            {
                get
                {
                    return _radiobuttondontuserecommendedsettingsInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("cc4e37a9-d5ae-45b9-b451-9f02e9b89cf6")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("cc4e37a9-d5ae-45b9-b451-9f02e9b89cf6")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The OPTiiMWebApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("562a4495-f75d-4ac3-8d6e-be176d98c1cf")]
        public partial class OPTiiMWebApplicationAppFolder : RepoGenBaseFolder
        {
            test_uygulamasiRepositoryFolders.Form1Folder _form1;

            /// <summary>
            /// Creates a new OPTiiMWebApplication  folder.
            /// </summary>
            public OPTiiMWebApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OPTiiMWebApplication", "/dom[@domain='izin.optiim.com']", parentFolder, 30000, null, false, "562a4495-f75d-4ac3-8d6e-be176d98c1cf", "")
            {
                _form1 = new test_uygulamasiRepositoryFolders.Form1Folder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("562a4495-f75d-4ac3-8d6e-be176d98c1cf")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("562a4495-f75d-4ac3-8d6e-be176d98c1cf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Form1 folder.
            /// </summary>
            [RepositoryFolder("5b18a0ca-febf-4670-a0c6-33ab27da62cd")]
            public virtual test_uygulamasiRepositoryFolders.Form1Folder Form1
            {
                get { return _form1; }
            }
        }

        /// <summary>
        /// The Form1Folder folder.
        /// </summary>
        [RepositoryFolder("5b18a0ca-febf-4670-a0c6-33ab27da62cd")]
        public partial class Form1Folder : RepoGenBaseFolder
        {
            RepoItemInfo _tuemİzinlerInfo;
            RepoItemInfo _httpizinoptiimcomdashboardhashInfo;
            RepoItemInfo _atagsigninwithgoogleInfo;

            /// <summary>
            /// Creates a new Form1  folder.
            /// </summary>
            public Form1Folder(RepoGenBaseFolder parentFolder) :
                    base("Form1", ".//form[#'form1']", parentFolder, 30000, null, false, "5b18a0ca-febf-4670-a0c6-33ab27da62cd", "")
            {
                _tuemİzinlerInfo = new RepoItemInfo(this, "Tuemİzinler", ".//section/ul/?/?/ul//span[@innertext='Tüm İzinler']", 30000, null, "b1e80be0-1875-4532-bb69-00d7601f4411");
                _httpizinoptiimcomdashboardhashInfo = new RepoItemInfo(this, "HttpIzinOptiimComDashboardHash", ".//section/ul/li[3]/a[@href~'^http://izin\\.optiim\\.com/Da']", 30000, null, "b0cd0345-9559-415d-a113-47364836e609");
                _atagsigninwithgoogleInfo = new RepoItemInfo(this, "ATagSignInWithGoogle", "div[3]//a[@innertext=' Sign in with Google']", 30000, null, "ee332e19-e719-478c-9a8e-8473be6372a4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5b18a0ca-febf-4670-a0c6-33ab27da62cd")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5b18a0ca-febf-4670-a0c6-33ab27da62cd")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Tuemİzinler item.
            /// </summary>
            [RepositoryItem("b1e80be0-1875-4532-bb69-00d7601f4411")]
            public virtual Ranorex.SpanTag Tuemİzinler
            {
                get
                {
                    return _tuemİzinlerInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Tuemİzinler item info.
            /// </summary>
            [RepositoryItemInfo("b1e80be0-1875-4532-bb69-00d7601f4411")]
            public virtual RepoItemInfo TuemİzinlerInfo
            {
                get
                {
                    return _tuemİzinlerInfo;
                }
            }

            /// <summary>
            /// The HttpIzinOptiimComDashboardHash item.
            /// </summary>
            [RepositoryItem("b0cd0345-9559-415d-a113-47364836e609")]
            public virtual Ranorex.ATag HttpIzinOptiimComDashboardHash
            {
                get
                {
                    return _httpizinoptiimcomdashboardhashInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The HttpIzinOptiimComDashboardHash item info.
            /// </summary>
            [RepositoryItemInfo("b0cd0345-9559-415d-a113-47364836e609")]
            public virtual RepoItemInfo HttpIzinOptiimComDashboardHashInfo
            {
                get
                {
                    return _httpizinoptiimcomdashboardhashInfo;
                }
            }

            /// <summary>
            /// The ATagSignInWithGoogle item.
            /// </summary>
            [RepositoryItem("ee332e19-e719-478c-9a8e-8473be6372a4")]
            public virtual Ranorex.ATag ATagSignInWithGoogle
            {
                get
                {
                    return _atagsigninwithgoogleInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATagSignInWithGoogle item info.
            /// </summary>
            [RepositoryItemInfo("ee332e19-e719-478c-9a8e-8473be6372a4")]
            public virtual RepoItemInfo ATagSignInWithGoogleInfo
            {
                get
                {
                    return _atagsigninwithgoogleInfo;
                }
            }
        }

        /// <summary>
        /// The OturumAcınGoogleHesaplarıAppFolder folder.
        /// </summary>
        [RepositoryFolder("5af16a35-9361-4db1-8410-0984e1154c9b")]
        public partial class OturumAcınGoogleHesaplarıAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _identifieridInfo;
            RepoItemInfo _zfr60dceorycInfo;
            RepoItemInfo _İleriInfo;

            /// <summary>
            /// Creates a new OturumAcınGoogleHesapları  folder.
            /// </summary>
            public OturumAcınGoogleHesaplarıAppFolder(RepoGenBaseFolder parentFolder) :
                    base("OturumAcınGoogleHesapları", "/dom[@domain='accounts.google.com']", parentFolder, 30000, null, false, "5af16a35-9361-4db1-8410-0984e1154c9b", "")
            {
                _identifieridInfo = new RepoItemInfo(this, "IdentifierId", ".//input[#'identifierId']", 30000, null, "7bd6c4e7-98c9-4839-895a-637771c2a381");
                _zfr60dceorycInfo = new RepoItemInfo(this, "ZFr60dCeoRYc", ".//div[#'identifierNext']/div[2]", 30000, null, "da10a179-0404-4013-8fb9-d17ac410f794");
                _İleriInfo = new RepoItemInfo(this, "İleri", ".//div[#'passwordNext']/?/?/span[@innertext='İleri']", 30000, null, "30c30002-5a59-41f0-adee-d4a2e23b817a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5af16a35-9361-4db1-8410-0984e1154c9b")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5af16a35-9361-4db1-8410-0984e1154c9b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The IdentifierId item.
            /// </summary>
            [RepositoryItem("7bd6c4e7-98c9-4839-895a-637771c2a381")]
            public virtual Ranorex.InputTag IdentifierId
            {
                get
                {
                    return _identifieridInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The IdentifierId item info.
            /// </summary>
            [RepositoryItemInfo("7bd6c4e7-98c9-4839-895a-637771c2a381")]
            public virtual RepoItemInfo IdentifierIdInfo
            {
                get
                {
                    return _identifieridInfo;
                }
            }

            /// <summary>
            /// The ZFr60dCeoRYc item.
            /// </summary>
            [RepositoryItem("da10a179-0404-4013-8fb9-d17ac410f794")]
            public virtual Ranorex.DivTag ZFr60dCeoRYc
            {
                get
                {
                    return _zfr60dceorycInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The ZFr60dCeoRYc item info.
            /// </summary>
            [RepositoryItemInfo("da10a179-0404-4013-8fb9-d17ac410f794")]
            public virtual RepoItemInfo ZFr60dCeoRYcInfo
            {
                get
                {
                    return _zfr60dceorycInfo;
                }
            }

            /// <summary>
            /// The İleri item.
            /// </summary>
            [RepositoryItem("30c30002-5a59-41f0-adee-d4a2e23b817a")]
            public virtual Ranorex.SpanTag İleri
            {
                get
                {
                    return _İleriInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The İleri item info.
            /// </summary>
            [RepositoryItemInfo("30c30002-5a59-41f0-adee-d4a2e23b817a")]
            public virtual RepoItemInfo İleriInfo
            {
                get
                {
                    return _İleriInfo;
                }
            }
        }

        /// <summary>
        /// The DoYouWantGoogleSmartLockToSaveYoAppFolder folder.
        /// </summary>
        [RepositoryFolder("e277a907-a6e4-4b81-9e27-cc97e2090d91")]
        public partial class DoYouWantGoogleSmartLockToSaveYoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _neverInfo;

            /// <summary>
            /// Creates a new DoYouWantGoogleSmartLockToSaveYo  folder.
            /// </summary>
            public DoYouWantGoogleSmartLockToSaveYoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DoYouWantGoogleSmartLockToSaveYo", "/form[@title~'^Do\\ you\\ want\\ Google\\ Smart\\ ']", parentFolder, 30000, null, true, "e277a907-a6e4-4b81-9e27-cc97e2090d91", "")
            {
                _neverInfo = new RepoItemInfo(this, "Never", "element[@accessiblename~'^Do\\ you\\ want\\ Google\\ Smart\\ ']/container/container[2]/?/?/button[@accessiblename='Never']", 30000, null, "04d8a19c-0ebe-4400-a34e-b6338d5609ec");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e277a907-a6e4-4b81-9e27-cc97e2090d91")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e277a907-a6e4-4b81-9e27-cc97e2090d91")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Never item.
            /// </summary>
            [RepositoryItem("04d8a19c-0ebe-4400-a34e-b6338d5609ec")]
            public virtual Ranorex.Button Never
            {
                get
                {
                    return _neverInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Never item info.
            /// </summary>
            [RepositoryItemInfo("04d8a19c-0ebe-4400-a34e-b6338d5609ec")]
            public virtual RepoItemInfo NeverInfo
            {
                get
                {
                    return _neverInfo;
                }
            }
        }

        /// <summary>
        /// The DropdownAppFolder folder.
        /// </summary>
        [RepositoryFolder("56b692ce-a8ce-4db4-a365-9ba2e7e9a243")]
        public partial class DropdownAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Dropdown  folder.
            /// </summary>
            public DropdownAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Dropdown", "/container[@caption='dropdown']", parentFolder, 30000, null, true, "56b692ce-a8ce-4db4-a365-9ba2e7e9a243", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("56b692ce-a8ce-4db4-a365-9ba2e7e9a243")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("56b692ce-a8ce-4db4-a365-9ba2e7e9a243")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}