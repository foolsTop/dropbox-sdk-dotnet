// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The link access level object</para>
    /// </summary>
    public class LinkAccessLevel
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LinkAccessLevel> Encoder = new LinkAccessLevelEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LinkAccessLevel> Decoder = new LinkAccessLevelDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LinkAccessLevel" />
        /// class.</para>
        /// </summary>
        public LinkAccessLevel()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Viewer</para>
        /// </summary>
        public bool IsViewer
        {
            get
            {
                return this is Viewer;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Viewer, or <c>null</c>.</para>
        /// </summary>
        public Viewer AsViewer
        {
            get
            {
                return this as Viewer;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Editor</para>
        /// </summary>
        public bool IsEditor
        {
            get
            {
                return this is Editor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Editor, or <c>null</c>.</para>
        /// </summary>
        public Editor AsEditor
        {
            get
            {
                return this as Editor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LinkAccessLevel" />.</para>
        /// </summary>
        private class LinkAccessLevelEncoder : enc.StructEncoder<LinkAccessLevel>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LinkAccessLevel value, enc.IJsonWriter writer)
            {
                if (value is Viewer)
                {
                    WriteProperty(".tag", "viewer", writer, enc.StringEncoder.Instance);
                    Viewer.Encoder.EncodeFields((Viewer)value, writer);
                    return;
                }
                if (value is Editor)
                {
                    WriteProperty(".tag", "editor", writer, enc.StringEncoder.Instance);
                    Editor.Encoder.EncodeFields((Editor)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LinkAccessLevel" />.</para>
        /// </summary>
        private class LinkAccessLevelDecoder : enc.UnionDecoder<LinkAccessLevel>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LinkAccessLevel" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LinkAccessLevel Create()
            {
                return new LinkAccessLevel();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override LinkAccessLevel Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "viewer":
                        return Viewer.Decoder.DecodeFields(reader);
                    case "editor":
                        return Editor.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Users who use the link can view and comment on the content.</para>
        /// </summary>
        public sealed class Viewer : LinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Viewer> Encoder = new ViewerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Viewer> Decoder = new ViewerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Viewer" /> class.</para>
            /// </summary>
            private Viewer()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Viewer</para>
            /// </summary>
            public static readonly Viewer Instance = new Viewer();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Viewer" />.</para>
            /// </summary>
            private class ViewerEncoder : enc.StructEncoder<Viewer>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Viewer value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Viewer" />.</para>
            /// </summary>
            private class ViewerDecoder : enc.StructDecoder<Viewer>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Viewer" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Viewer Create()
                {
                    return Viewer.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Users who use the link can edit, view and comment on the content.</para>
        /// </summary>
        public sealed class Editor : LinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Editor> Encoder = new EditorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Editor> Decoder = new EditorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Editor" /> class.</para>
            /// </summary>
            private Editor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Editor</para>
            /// </summary>
            public static readonly Editor Instance = new Editor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Editor" />.</para>
            /// </summary>
            private class EditorEncoder : enc.StructEncoder<Editor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Editor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Editor" />.</para>
            /// </summary>
            private class EditorDecoder : enc.StructDecoder<Editor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Editor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Editor Create()
                {
                    return Editor.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : LinkAccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}