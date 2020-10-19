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
    /// <para>Properties of the shared folder.</para>
    /// </summary>
    /// <seealso cref="SharedFolderMetadata" />
    public class SharedFolderMetadataBase
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMetadataBase> Encoder = new SharedFolderMetadataBaseEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMetadataBase> Decoder = new SharedFolderMetadataBaseDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadataBase" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The current user's access level for this shared
        /// folder.</param>
        /// <param name="isInsideTeamFolder">Whether this folder is inside of a team
        /// folder.</param>
        /// <param name="isTeamFolder">Whether this folder is a <a
        /// href="https://www.dropbox.com/en/help/986">team folder</a>.</param>
        /// <param name="ownerDisplayNames">The display names of the users that own the folder.
        /// If the folder is part of a team folder, the display names of the team admins are
        /// also included. Absent if the owner display names cannot be fetched.</param>
        /// <param name="ownerTeam">The team that owns the folder. This field is not present if
        /// the folder is not owned by a team.</param>
        /// <param name="parentSharedFolderId">The ID of the parent shared folder. This field
        /// is present only if the folder is contained within another shared folder.</param>
        /// <param name="pathLower">The lower-cased full path of this shared folder. Absent for
        /// unmounted folders.</param>
        /// <param name="parentFolderName">Display name for the parent folder.</param>
        public SharedFolderMetadataBase(AccessLevel accessType,
                                        bool isInsideTeamFolder,
                                        bool isTeamFolder,
                                        col.IEnumerable<string> ownerDisplayNames = null,
                                        global::Dropbox.Api.Users.Team ownerTeam = null,
                                        string parentSharedFolderId = null,
                                        string pathLower = null,
                                        string parentFolderName = null)
        {
            if (accessType == null)
            {
                throw new sys.ArgumentNullException("accessType");
            }

            var ownerDisplayNamesList = enc.Util.ToList(ownerDisplayNames);

            if (parentSharedFolderId != null)
            {
                if (!re.Regex.IsMatch(parentSharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("parentSharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            this.AccessType = accessType;
            this.IsInsideTeamFolder = isInsideTeamFolder;
            this.IsTeamFolder = isTeamFolder;
            this.OwnerDisplayNames = ownerDisplayNamesList;
            this.OwnerTeam = ownerTeam;
            this.ParentSharedFolderId = parentSharedFolderId;
            this.PathLower = pathLower;
            this.ParentFolderName = parentFolderName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadataBase" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderMetadataBase()
        {
        }

        /// <summary>
        /// <para>The current user's access level for this shared folder.</para>
        /// </summary>
        public AccessLevel AccessType { get; protected set; }

        /// <summary>
        /// <para>Whether this folder is inside of a team folder.</para>
        /// </summary>
        public bool IsInsideTeamFolder { get; protected set; }

        /// <summary>
        /// <para>Whether this folder is a <a href="https://www.dropbox.com/en/help/986">team
        /// folder</a>.</para>
        /// </summary>
        public bool IsTeamFolder { get; protected set; }

        /// <summary>
        /// <para>The display names of the users that own the folder. If the folder is part of
        /// a team folder, the display names of the team admins are also included. Absent if
        /// the owner display names cannot be fetched.</para>
        /// </summary>
        public col.IList<string> OwnerDisplayNames { get; protected set; }

        /// <summary>
        /// <para>The team that owns the folder. This field is not present if the folder is not
        /// owned by a team.</para>
        /// </summary>
        public global::Dropbox.Api.Users.Team OwnerTeam { get; protected set; }

        /// <summary>
        /// <para>The ID of the parent shared folder. This field is present only if the folder
        /// is contained within another shared folder.</para>
        /// </summary>
        public string ParentSharedFolderId { get; protected set; }

        /// <summary>
        /// <para>The lower-cased full path of this shared folder. Absent for unmounted
        /// folders.</para>
        /// </summary>
        public string PathLower { get; protected set; }

        /// <summary>
        /// <para>Display name for the parent folder.</para>
        /// </summary>
        public string ParentFolderName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderMetadataBase" />.</para>
        /// </summary>
        private class SharedFolderMetadataBaseEncoder : enc.StructEncoder<SharedFolderMetadataBase>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMetadataBase value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, global::Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("is_inside_team_folder", value.IsInsideTeamFolder, writer, enc.BooleanEncoder.Instance);
                WriteProperty("is_team_folder", value.IsTeamFolder, writer, enc.BooleanEncoder.Instance);
                if (value.OwnerDisplayNames.Count > 0)
                {
                    WriteListProperty("owner_display_names", value.OwnerDisplayNames, writer, enc.StringEncoder.Instance);
                }
                if (value.OwnerTeam != null)
                {
                    WriteProperty("owner_team", value.OwnerTeam, writer, global::Dropbox.Api.Users.Team.Encoder);
                }
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.ParentFolderName != null)
                {
                    WriteProperty("parent_folder_name", value.ParentFolderName, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderMetadataBase" />.</para>
        /// </summary>
        private class SharedFolderMetadataBaseDecoder : enc.StructDecoder<SharedFolderMetadataBase>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMetadataBase"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMetadataBase Create()
            {
                return new SharedFolderMetadataBase();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderMetadataBase value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = global::Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "is_inside_team_folder":
                        value.IsInsideTeamFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "is_team_folder":
                        value.IsTeamFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "owner_display_names":
                        value.OwnerDisplayNames = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "owner_team":
                        value.OwnerTeam = global::Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "parent_folder_name":
                        value.ParentFolderName = enc.StringDecoder.Instance.Decode(reader);
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