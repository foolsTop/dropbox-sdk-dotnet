// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Created team folder in active status.</para>
    /// </summary>
    public class TeamFolderCreateDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderCreateDetails> Encoder = new TeamFolderCreateDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderCreateDetails> Decoder = new TeamFolderCreateDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderCreateDetails" />
        /// class.</para>
        /// </summary>
        public TeamFolderCreateDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderCreateDetails" />.</para>
        /// </summary>
        private class TeamFolderCreateDetailsEncoder : enc.StructEncoder<TeamFolderCreateDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderCreateDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderCreateDetails" />.</para>
        /// </summary>
        private class TeamFolderCreateDetailsDecoder : enc.StructDecoder<TeamFolderCreateDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderCreateDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderCreateDetails Create()
            {
                return new TeamFolderCreateDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamFolderCreateDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}