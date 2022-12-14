///////////////////////////////////////////////////////////////////////////////
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

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f7a12867-e15b-4354-8a73-4ecb0a88fa03")]
    public partial class MyTest1Repository : RepoGenBaseFolder
    {
        static MyTest1Repository instance = new MyTest1Repository();
        MyTest1RepositoryFolders.ComSodexoFlexogiftAppFolder _comsodexoflexogift;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest1Repository element repository.
        /// </summary>
        [RepositoryFolder("f7a12867-e15b-4354-8a73-4ecb0a88fa03")]
        public static MyTest1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest1Repository() 
            : base("MyTest1Repository", "/", null, 0, false, "f7a12867-e15b-4354-8a73-4ecb0a88fa03", ".\\RepositoryImages\\MyTest1Repositoryf7a12867.rximgres")
        {
            _comsodexoflexogift = new MyTest1RepositoryFolders.ComSodexoFlexogiftAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f7a12867-e15b-4354-8a73-4ecb0a88fa03")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ComSodexoFlexogift folder.
        /// </summary>
        [RepositoryFolder("339d820a-f130-4577-8a5c-519acc3b4ba4")]
        public virtual MyTest1RepositoryFolders.ComSodexoFlexogiftAppFolder ComSodexoFlexogift
        {
            get { return _comsodexoflexogift; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest1RepositoryFolders
    {
        /// <summary>
        /// The ComSodexoFlexogiftAppFolder folder.
        /// </summary>
        [RepositoryFolder("339d820a-f130-4577-8a5c-519acc3b4ba4")]
        public partial class ComSodexoFlexogiftAppFolder : RepoGenBaseFolder
        {
            MyTest1RepositoryFolders.FrameFolder _frame;

            /// <summary>
            /// Creates a new ComSodexoFlexogift  folder.
            /// </summary>
            public ComSodexoFlexogiftAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ComSodexoFlexogift", "/mobileapp[@title='com.sodexo.flexogift']", parentFolder, 30000, null, false, "339d820a-f130-4577-8a5c-519acc3b4ba4", "")
            {
                _frame = new MyTest1RepositoryFolders.FrameFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("339d820a-f130-4577-8a5c-519acc3b4ba4")]
            public virtual Ranorex.MobileApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MobileApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("339d820a-f130-4577-8a5c-519acc3b4ba4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Frame folder.
            /// </summary>
            [RepositoryFolder("7621a353-f7ec-4098-8278-cfc1040e8981")]
            public virtual MyTest1RepositoryFolders.FrameFolder Frame
            {
                get { return _frame; }
            }
        }

        /// <summary>
        /// The FrameFolder folder.
        /// </summary>
        [RepositoryFolder("7621a353-f7ec-4098-8278-cfc1040e8981")]
        public partial class FrameFolder : RepoGenBaseFolder
        {
            RepoItemInfo _comfacebookreactviewstextinputreactInfo;
            RepoItemInfo _girişyapkayıtolInfo;
            GirişYapInfoClass _girişyapInfo;

            /// <summary>
            /// Creates a new Frame  folder.
            /// </summary>
            public FrameFolder(RepoGenBaseFolder parentFolder) :
                    base("Frame", "form[@title='MainActivity']/container[@containertype='Linear']/container[@containertype='Frame']", parentFolder, 30000, null, false, "7621a353-f7ec-4098-8278-cfc1040e8981", "")
            {
                _comfacebookreactviewstextinputreactInfo = new RepoItemInfo(this, "ComFacebookReactViewsTextinputReact", "?/?/androidelement[@rid='content']/androidelement/androidelement/androidelement/androidelement/androidelement[2]/androidelement/androidelement/androidelement/androidelement/androidelement[2]/androidelement/androidelement[4]/text[3]", "", 30000, null, "877336db-0ddc-415a-ab60-7b5dc4311d27");
                _girişyapkayıtolInfo = new RepoItemInfo(this, "GirişYapKayıtOl", "androidelement/androidelement[@rid='content']/androidelement/androidelement/androidelement/androidelement/androidelement[2]/androidelement/androidelement/androidelement/androidelement/androidelement[3]/?/?/text", "", 30000, null, "639c32b4-9453-4be3-b693-9d4087371545");
                _girişyapInfo = new GirişYapInfoClass(this);
            }

            /// <summary>
            /// The GirişYapInfoClass folder.
            /// </summary>
            [RepositoryItemInfo("cfaf18a3-5edc-4c67-91fe-b33abf818e01")]
            public class GirişYapInfoClass : RepoItemInfo
            {
                /// <summary>
                /// GirişYapInfoClass class constructor.
                /// </summary>
                public GirişYapInfoClass(RepoGenBaseFolder parentFolder)
                    : base(parentFolder, "GirişYap", "androidelement/androidelement[@rid='content']/androidelement/androidelement/androidelement/androidelement/androidelement[4]/androidelement/androidelement/androidelement/androidelement/androidelement[1]/text", 30000, null, "cfaf18a3-5edc-4c67-91fe-b33abf818e01")
                { }

                /// <summary>
                /// Gets the Screenshot1 item image.
                /// </summary>
                /// <returns>The Screenshot1 image.</returns>
                [RepositoryImage("5f223cda-7d47-4f0d-b1c1-6f0d72351c69")]
                public CompressedImage GetScreenshot1()
                {
                    return GetImage("5f223cda-7d47-4f0d-b1c1-6f0d72351c69");
                }

                /// <summary>
                /// Gets the Screenshot1 item image.
                /// </summary>
                /// <param name="cropRect">The bounds of the sub-image to return.</param>
                /// <returns>The cropped image.</returns>
                [RepositoryImage("5f223cda-7d47-4f0d-b1c1-6f0d72351c69")]
                public CompressedImage GetScreenshot1(System.Drawing.Rectangle cropRect)
                {
                    return GetImage("5f223cda-7d47-4f0d-b1c1-6f0d72351c69", cropRect);
                }
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7621a353-f7ec-4098-8278-cfc1040e8981")]
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
            [RepositoryItemInfo("7621a353-f7ec-4098-8278-cfc1040e8981")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ComFacebookReactViewsTextinputReact item.
            /// </summary>
            [RepositoryItem("877336db-0ddc-415a-ab60-7b5dc4311d27")]
            public virtual Ranorex.Text ComFacebookReactViewsTextinputReact
            {
                get
                {
                    return _comfacebookreactviewstextinputreactInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The ComFacebookReactViewsTextinputReact item info.
            /// </summary>
            [RepositoryItemInfo("877336db-0ddc-415a-ab60-7b5dc4311d27")]
            public virtual RepoItemInfo ComFacebookReactViewsTextinputReactInfo
            {
                get
                {
                    return _comfacebookreactviewstextinputreactInfo;
                }
            }

            /// <summary>
            /// The GirişYapKayıtOl item.
            /// </summary>
            [RepositoryItem("639c32b4-9453-4be3-b693-9d4087371545")]
            public virtual Ranorex.Text GirişYapKayıtOl
            {
                get
                {
                    return _girişyapkayıtolInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GirişYapKayıtOl item info.
            /// </summary>
            [RepositoryItemInfo("639c32b4-9453-4be3-b693-9d4087371545")]
            public virtual RepoItemInfo GirişYapKayıtOlInfo
            {
                get
                {
                    return _girişyapkayıtolInfo;
                }
            }

            /// <summary>
            /// The GirişYap item.
            /// </summary>
            [RepositoryItem("cfaf18a3-5edc-4c67-91fe-b33abf818e01")]
            public virtual Ranorex.Text GirişYap
            {
                get
                {
                    return _girişyapInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The GirişYap item info.
            /// </summary>
            [RepositoryItemInfo("cfaf18a3-5edc-4c67-91fe-b33abf818e01")]
            public virtual GirişYapInfoClass GirişYapInfo
            {
                get
                {
                    return _girişyapInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
