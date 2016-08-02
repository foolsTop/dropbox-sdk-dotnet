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
    /// <para>The file member action error object</para>
    /// </summary>
    public class FileMemberActionError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileMemberActionError> Encoder = new FileMemberActionErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileMemberActionError> Decoder = new FileMemberActionErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileMemberActionError" />
        /// class.</para>
        /// </summary>
        public FileMemberActionError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidMember</para>
        /// </summary>
        public bool IsInvalidMember
        {
            get
            {
                return this is InvalidMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidMember, or <c>null</c>.</para>
        /// </summary>
        public InvalidMember AsInvalidMember
        {
            get
            {
                return this as InvalidMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
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
        /// <para>Encoder for  <see cref="FileMemberActionError" />.</para>
        /// </summary>
        private class FileMemberActionErrorEncoder : enc.StructEncoder<FileMemberActionError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileMemberActionError value, enc.IJsonWriter writer)
            {
                if (value is InvalidMember)
                {
                    WriteProperty(".tag", "invalid_member", writer, enc.StringEncoder.Instance);
                    InvalidMember.Encoder.EncodeFields((InvalidMember)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
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
        /// <para>Decoder for  <see cref="FileMemberActionError" />.</para>
        /// </summary>
        private class FileMemberActionErrorDecoder : enc.UnionDecoder<FileMemberActionError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileMemberActionError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileMemberActionError Create()
            {
                return new FileMemberActionError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override FileMemberActionError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_member":
                        return InvalidMember.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Specified member was not found.</para>
        /// </summary>
        public sealed class InvalidMember : FileMemberActionError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidMember> Encoder = new InvalidMemberEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidMember> Decoder = new InvalidMemberDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidMember" />
            /// class.</para>
            /// </summary>
            private InvalidMember()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidMember</para>
            /// </summary>
            public static readonly InvalidMember Instance = new InvalidMember();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidMember" />.</para>
            /// </summary>
            private class InvalidMemberEncoder : enc.StructEncoder<InvalidMember>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidMember value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidMember" />.</para>
            /// </summary>
            private class InvalidMemberDecoder : enc.StructDecoder<InvalidMember>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidMember" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidMember Create()
                {
                    return new InvalidMember();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InvalidMember DecodeFields(enc.IJsonReader reader)
                {
                    return InvalidMember.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>User does not have permission to perform this action on this member.</para>
        /// </summary>
        public sealed class NoPermission : FileMemberActionError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return new NoPermission();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoPermission DecodeFields(enc.IJsonReader reader)
                {
                    return NoPermission.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : FileMemberActionError
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
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}