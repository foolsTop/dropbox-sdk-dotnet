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
    /// <para>The sync setting object</para>
    /// </summary>
    public class SyncSetting
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SyncSetting> Encoder = new SyncSettingEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SyncSetting> Decoder = new SyncSettingDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SyncSetting" /> class.</para>
        /// </summary>
        public SyncSetting()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Default</para>
        /// </summary>
        public bool IsDefault
        {
            get
            {
                return this is Default;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Default, or <c>null</c>.</para>
        /// </summary>
        public Default AsDefault
        {
            get
            {
                return this as Default;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotSynced</para>
        /// </summary>
        public bool IsNotSynced
        {
            get
            {
                return this is NotSynced;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotSynced, or <c>null</c>.</para>
        /// </summary>
        public NotSynced AsNotSynced
        {
            get
            {
                return this as NotSynced;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotSyncedInactive</para>
        /// </summary>
        public bool IsNotSyncedInactive
        {
            get
            {
                return this is NotSyncedInactive;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotSyncedInactive, or <c>null</c>.</para>
        /// </summary>
        public NotSyncedInactive AsNotSyncedInactive
        {
            get
            {
                return this as NotSyncedInactive;
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
        /// <para>Encoder for  <see cref="SyncSetting" />.</para>
        /// </summary>
        private class SyncSettingEncoder : enc.StructEncoder<SyncSetting>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SyncSetting value, enc.IJsonWriter writer)
            {
                if (value is Default)
                {
                    WriteProperty(".tag", "default", writer, enc.StringEncoder.Instance);
                    Default.Encoder.EncodeFields((Default)value, writer);
                    return;
                }
                if (value is NotSynced)
                {
                    WriteProperty(".tag", "not_synced", writer, enc.StringEncoder.Instance);
                    NotSynced.Encoder.EncodeFields((NotSynced)value, writer);
                    return;
                }
                if (value is NotSyncedInactive)
                {
                    WriteProperty(".tag", "not_synced_inactive", writer, enc.StringEncoder.Instance);
                    NotSyncedInactive.Encoder.EncodeFields((NotSyncedInactive)value, writer);
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
        /// <para>Decoder for  <see cref="SyncSetting" />.</para>
        /// </summary>
        private class SyncSettingDecoder : enc.UnionDecoder<SyncSetting>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SyncSetting" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SyncSetting Create()
            {
                return new SyncSetting();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SyncSetting Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "default":
                        return Default.Decoder.DecodeFields(reader);
                    case "not_synced":
                        return NotSynced.Decoder.DecodeFields(reader);
                    case "not_synced_inactive":
                        return NotSyncedInactive.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>On first sync to members' computers, the specified folder will follow its
        /// parent folder's setting or otherwise follow default sync behavior.</para>
        /// </summary>
        public sealed class Default : SyncSetting
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Default> Encoder = new DefaultEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Default> Decoder = new DefaultDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Default" /> class.</para>
            /// </summary>
            private Default()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Default</para>
            /// </summary>
            public static readonly Default Instance = new Default();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Default" />.</para>
            /// </summary>
            private class DefaultEncoder : enc.StructEncoder<Default>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Default value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Default" />.</para>
            /// </summary>
            private class DefaultDecoder : enc.StructDecoder<Default>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Default" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Default Create()
                {
                    return Default.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>On first sync to members' computers, the specified folder will be set to not
        /// sync with selective sync.</para>
        /// </summary>
        public sealed class NotSynced : SyncSetting
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotSynced> Encoder = new NotSyncedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotSynced> Decoder = new NotSyncedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotSynced" /> class.</para>
            /// </summary>
            private NotSynced()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotSynced</para>
            /// </summary>
            public static readonly NotSynced Instance = new NotSynced();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotSynced" />.</para>
            /// </summary>
            private class NotSyncedEncoder : enc.StructEncoder<NotSynced>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotSynced value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotSynced" />.</para>
            /// </summary>
            private class NotSyncedDecoder : enc.StructDecoder<NotSynced>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotSynced" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotSynced Create()
                {
                    return NotSynced.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The specified folder's not_synced setting is inactive due to its location or
        /// other configuration changes. It will follow its parent folder's setting.</para>
        /// </summary>
        public sealed class NotSyncedInactive : SyncSetting
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotSyncedInactive> Encoder = new NotSyncedInactiveEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotSyncedInactive> Decoder = new NotSyncedInactiveDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotSyncedInactive" />
            /// class.</para>
            /// </summary>
            private NotSyncedInactive()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotSyncedInactive</para>
            /// </summary>
            public static readonly NotSyncedInactive Instance = new NotSyncedInactive();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotSyncedInactive" />.</para>
            /// </summary>
            private class NotSyncedInactiveEncoder : enc.StructEncoder<NotSyncedInactive>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotSyncedInactive value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotSyncedInactive" />.</para>
            /// </summary>
            private class NotSyncedInactiveDecoder : enc.StructDecoder<NotSyncedInactive>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotSyncedInactive"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotSyncedInactive Create()
                {
                    return NotSyncedInactive.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SyncSetting
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