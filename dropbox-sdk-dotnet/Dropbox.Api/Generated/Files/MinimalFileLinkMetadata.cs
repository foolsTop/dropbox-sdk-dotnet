// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The minimal file link metadata object</para>
    /// </summary>
    public class MinimalFileLinkMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MinimalFileLinkMetadata> Encoder = new MinimalFileLinkMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MinimalFileLinkMetadata> Decoder = new MinimalFileLinkMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MinimalFileLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="url">URL of the shared link.</param>
        /// <param name="rev">A unique identifier for the current revision of a file. This
        /// field is the same rev as elsewhere in the API and can be used to detect changes and
        /// avoid conflicts.</param>
        /// <param name="id">Unique identifier for the linked file.</param>
        /// <param name="path">Full path in the user's Dropbox. This always starts with a
        /// slash. This field will only be present only if the linked file is in the
        /// authenticated user's Dropbox.</param>
        public MinimalFileLinkMetadata(string url,
                                       string rev,
                                       string id = null,
                                       string path = null)
        {
            if (url == null)
            {
                throw new sys.ArgumentNullException("url");
            }

            if (rev == null)
            {
                throw new sys.ArgumentNullException("rev");
            }
            if (rev.Length < 9)
            {
                throw new sys.ArgumentOutOfRangeException("rev", "Length should be at least 9");
            }
            if (!re.Regex.IsMatch(rev, @"\A(?:[0-9a-f]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("rev", @"Value should match pattern '\A(?:[0-9a-f]+)\z'");
            }

            if (id != null)
            {
                if (id.Length < 1)
                {
                    throw new sys.ArgumentOutOfRangeException("id", "Length should be at least 1");
                }
            }

            this.Url = url;
            this.Rev = rev;
            this.Id = id;
            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MinimalFileLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MinimalFileLinkMetadata()
        {
        }

        /// <summary>
        /// <para>URL of the shared link.</para>
        /// </summary>
        public string Url { get; protected set; }

        /// <summary>
        /// <para>A unique identifier for the current revision of a file. This field is the
        /// same rev as elsewhere in the API and can be used to detect changes and avoid
        /// conflicts.</para>
        /// </summary>
        public string Rev { get; protected set; }

        /// <summary>
        /// <para>Unique identifier for the linked file.</para>
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// <para>Full path in the user's Dropbox. This always starts with a slash. This field
        /// will only be present only if the linked file is in the authenticated user's
        /// Dropbox.</para>
        /// </summary>
        public string Path { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MinimalFileLinkMetadata" />.</para>
        /// </summary>
        private class MinimalFileLinkMetadataEncoder : enc.StructEncoder<MinimalFileLinkMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MinimalFileLinkMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("url", value.Url, writer, enc.StringEncoder.Instance);
                WriteProperty("rev", value.Rev, writer, enc.StringEncoder.Instance);
                if (value.Id != null)
                {
                    WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                }
                if (value.Path != null)
                {
                    WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MinimalFileLinkMetadata" />.</para>
        /// </summary>
        private class MinimalFileLinkMetadataDecoder : enc.StructDecoder<MinimalFileLinkMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MinimalFileLinkMetadata"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MinimalFileLinkMetadata Create()
            {
                return new MinimalFileLinkMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MinimalFileLinkMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "url":
                        value.Url = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "rev":
                        value.Rev = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}