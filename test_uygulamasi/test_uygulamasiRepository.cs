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
        /// The GoogleGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("6dc50128-def1-48cc-916b-f7cb1047796e")]
        public virtual test_uygulamasiRepositoryFolders.GoogleGoogleChromeAppFolder GoogleGoogleChrome
        {
            get { return _googlegooglechrome; }
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

    }
#pragma warning restore 0436
}