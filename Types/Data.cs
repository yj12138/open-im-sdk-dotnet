using System;
using Newtonsoft.Json;
using openim_sdk_unity.util;
namespace openim_sdk_unity
{
    public class MessageReceipt
    {
        [JsonProperty("groupID")]
        public string GroupID;
        [JsonProperty("userID")]
        public string UserID;
        [JsonProperty("userID")]
        public string[] MsgIDList;
        [JsonProperty("userID")]
        public long ReadTime;
        [JsonProperty("userID")]
        public int MsgFrom;
        [JsonProperty("userID")]
        public int ContentType;
        [JsonProperty("userID")]
        public int SessionType;
    }

    public class MessageRevoked
    {
        [JsonProperty("revokerID")]
        public string RevokerID;
        [JsonProperty("revokerRole")]
        public int RevokerRole;
        [JsonProperty("clientMsgID")]
        public string ClientMsgID;
        [JsonProperty("revokerNickname")]
        public string RevokerNickname;
        [JsonProperty("revokeTime")]
        public long RevokeTime;
        [JsonProperty("sourceMessageSendTime")]
        public long SourceMessageSendTime;
        [JsonProperty("sourceMessageSendID")]
        public string SourceMessageSendID;
        [JsonProperty("sourceMessageSenderNickname")]
        public string SourceMessageSenderNickname;
        [JsonProperty("sessionType")]
        public int SessionType;
        [JsonProperty("seq")]
        public long Seq;
        [JsonProperty("ex")]
        public string Ex;
        [JsonProperty("isAdminRevoke")]
        public bool IsAdminRevoke;
    }

    public class MessageReaction
    {
        [JsonProperty("clientMsgID")]
        public string ClientMsgID;
        [JsonProperty("reactionType")]
        public int ReactionType;
        [JsonProperty("counter")]
        public int Counter;
        [JsonProperty("userID")]
        public string UserID;
        [JsonProperty("groupID")]
        public string GroupID;
        [JsonProperty("sessionType")]
        public int SessionType;
        [JsonProperty("info")]
        public string Info;
    }

    public class ImageInfo
    {
        [JsonProperty("x")]
        public int Width;
        [JsonProperty("y")]
        public int Height;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("size")]
        public long Size;
    }

    public class PictureBaseInfo
    {
        [JsonProperty("uuid")]
        public string UUID;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("size")]
        public long Size;
        [JsonProperty("width")]
        public int Width;
        [JsonProperty("height")]
        public int Height;
        [JsonProperty("url")]
        public string Url;
    }

    public class SoundBaseInfo
    {
        public string UUID;
        public string SoundPath;
        public string SourceURL;
        public long DataSize;
        public long Duration;
        public string SoundType;
    }

    public class VideoBaseInfo
    {
        public string VideoPath;
        public string VideoUUID;
        public string VideoURL;
        public string VideoType;
        public long VideoSize;
        public long Duration;
        public string SnapshotPath;
        public string SnapshotUUID;
        public long SnapshotSize;
        public string SnapshotURL;
        public int SnapshotWidth;
        public int SnapshotHeight;
        public string SnapshotType;
    }

    public class FileBaseInfo
    {
        public string FilePath;
        public string UUID;
        public string SourceURL;
        public string FileName;
        public long FileSize;
        public string FileType;
    }

    public class TextElem
    {
        [JsonProperty("content")]
        public string Content;
    }

    public class CardElem
    {
        [JsonProperty("userID")]
        public string UserID;
        [JsonProperty("nickname")]
        public string Nickname;
        [JsonProperty("faceURL")]
        public string FaceURL;
        [JsonProperty("ex")]
        public string Ex;
    }

    public class PictureElem
    {
        [JsonProperty("sourcePath")]
        public string SourcePath;
        [JsonProperty("sourcePicture")]
        public PictureBaseInfo SourcePicture;
        [JsonProperty("bigPicture")]
        public PictureBaseInfo BigPicture;
        [JsonProperty("snapshotPicture")]
        public PictureBaseInfo SnapshotPicture;
    }

    public class SoundElem
    {
        [JsonProperty("uuid")]
        public string UUID;
        [JsonProperty("soundPath")]
        public string SoundPath;
        [JsonProperty("sourceUrl")]
        public string SourceURL;
        [JsonProperty("dataSize")]
        public long DataSize;
        [JsonProperty("duration")]
        public long Duration;
        [JsonProperty("soundType")]
        public string SoundType;
    }

    public class VideoElem
    {
        public string VideoPath;
        public string VideoUUID;
        public string VideoURL;
        public string VideoType;
        public long VideoSize;
        public long Duration;
        public string SnapshotPath;
        public string SnapshotUUID;
        public long SnapshotSize;
        public string SnapshotURL;
        public int SnapshotWidth;
        public int SnapshotHeight;
        public string SnapshotType;
    }

    public class FileElem
    {
        [JsonProperty("filePath")]
        public string FilePath;
        [JsonProperty("uuid")]
        public string UUID;
        [JsonProperty("sourceUrl")]
        public string SourceURL;
        [JsonProperty("fileName")]
        public string FileName;
        [JsonProperty("fileSize")]
        public long FileSize;
        [JsonProperty("fileType")]
        public string FileType;
    }

    public class MergeElem
    {
        public string Title;
        public string[] AbstractList;
        public MsgStruct[] MultiMessage;
        public MessageEntity[] MessageEntityList;
    }

    public class AtTextElem
    {
        public string Text;
        public string[] AtUserList;
        public AtInfo[] AtUsersInfo;
        public MsgStruct QuoteMessage;
        public bool IsAtSelf;
    }

    public class FaceElem
    {
        public int Index;
        public string Data;
    }

    public class LocationElem
    {
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("longitude")]
        public double Longitude;
        [JsonProperty("latitude")]
        public double Latitude;
    }

    public class CustomElem
    {
        public string Data;
        public string Description;
        public string Extension;
    }

    public class QuoteElem
    {
        public string Text;
        public MsgStruct QuoteMessage;
        public MessageEntity[] MessageEntityList;
    }

    public class NotificationElem
    {
        public string Detail;
    }

    public class AdvancedTextElem
    {
        public string Text;
        public MessageEntity[] MessageEntityList;
    }

    public class TypingElem
    {
        public string MsgTips;
    }

    public class MsgStruct
    {
        [JsonProperty("clientMsgID")]
        public string ClientMsgID;
        [JsonProperty("serverMsgID")]
        public string ServerMsgID;
        [JsonProperty("createTime")]
        public long CreateTime;
        [JsonProperty("sendTime")]
        public long SendTime;
        [JsonProperty("sessionType")]
        public int SessionType;
        [JsonProperty("sendID")]
        public string SendID;
        [JsonProperty("recvID")]
        public string RecvID;
        [JsonProperty("msgFrom")]
        public int MsgFrom;
        [JsonProperty("contentType")]
        public int ContentType;
        [JsonProperty("senderPlatformID")]
        public int SenderPlatformID;
        [JsonProperty("senderNickname")]
        public string SenderNickname;
        [JsonProperty("senderFaceUrl")]
        public string SenderFaceURL;
        [JsonProperty("groupID")]
        public string GroupID;
        [JsonProperty("content")]
        public string Content;
        [JsonProperty("seq")]
        public long Seq;
        [JsonProperty("isRead")]
        public bool IsRead;
        [JsonProperty("status")]
        public int Status;
        [JsonProperty("isReact")]
        public bool IsReact;
        [JsonProperty("isExternalExtensions")]
        public bool IsExternalExtensions;
        public OfflinePushInfo OfflinePush;
        [JsonProperty("attachedInfo")]
        public string AttachedInfo;
        [JsonProperty("ex")]
        public string Ex;
        [JsonProperty("localEx")]
        public string LocalEx;
        [JsonProperty("textElem")]
        public TextElem TextElem;
        [JsonProperty("cardElem")]
        public CardElem CardElem;
        [JsonProperty("pictureElem")]
        public PictureElem PictureElem;
        [JsonProperty("sourdElem")]
        public SoundElem SoundElem;
        [JsonProperty("textElem")]
        public VideoElem VideoElem;
        [JsonProperty("fileElem")]
        public FileElem FileElem;
        [JsonProperty("mergeElem")]
        public MergeElem MergeElem;
        [JsonProperty("atTextElem")]
        public AtTextElem AtTextElem;
        [JsonProperty("faceElem")]
        public FaceElem FaceElem;
        [JsonProperty("locationElem")]
        public LocationElem LocationElem;
        [JsonProperty("customElem")]
        public CustomElem CustomElem;
        [JsonProperty("quoteElem")]
        public QuoteElem QuoteElem;
        [JsonProperty("notificationElem")]
        public NotificationElem NotificationElem;
        [JsonProperty("advancedTextElem")]
        public AdvancedTextElem AdvancedTextElem;
        [JsonProperty("typingElem")]
        public TypingElem TypingElem;
        [JsonProperty("attachedInfoElem")]
        public AttachedInfoElem AttachedInfoElem;
    }

    public class AtInfo
    {
        [JsonProperty("atUserID")]
        public string AtUserID;
        [JsonProperty("groupNickname")]
        public string GroupNickname;
    }

    public class AttachedInfoElem
    {
        public GroupHasReadInfo GroupHasReadInfo;
        public bool IsPrivateChat;
        public int BurnDuration;
        public long HasReadTime;
        public bool NotSenderNotificationPush;
        public MessageEntity[] MessageEntityList;
        public bool IsEncryption;
        public bool InEncryptStatus;
        public ReactionElem[] MessageReactionElem;
        public UploadProgress Progress;
    }

    public class UploadProgress
    {
        public long Total;
        public long Save;
        public long Current;
        public string UploadID;
    }

    public class ReactionElem
    {
        public int Counter;
        public int Type;
        public UserReactionElem[] UserReactionList;
        public bool CanRepeat;
        public string Info;
    }

    public class UserReactionElem
    {
        public string UserID;
        public int Counter;
        public string Info;
    }

    public class MessageEntity
    {
        public string Type;
        public int Offset;
        public int Length;
        public string Url;
        public string Ex;
    }

    public class GroupHasReadInfo
    {
        public string[] HasReadUserIDList;
        public int HasReadCount;
        public int GroupMemberCount;
    }

    public class CmdJoinedSuperGroup
    {
        public string OperationID;
    }

    public class OANotificationElem
    {
        public string NotificationName;
        public string NotificationFaceURL;
        public int NotificationType;
        public string Text;
        public string Url;
        public int MixType;
        // public struct Image;
        public string SourceUrl;
        public string SnapshotUrl;
        // public string SourceUrl;
        // public string SnapshotUrl;
        public long Duration;
        // public string SourceUrl;
        public string FileName;
        public long FileSize;
    }

    public class MsgDeleteNotificationElem
    {
        public string GroupID;
        public bool IsAllDelete;
        public string[] SeqList;
    }
    public class LocalFriend
    {
        public string OwnerUserID;
        public string FriendUserID;
        public string Remark;
        public long CreateTime;
        public int AddSource;
        public string OperatorUserID;
        public string Nickname;
        public string FaceURL;
        // public int //Gender; 
        // public string //PhoneNumber; 
        // public uint //Birth; 
        // public string //Email; 
        // public string Ex;
        public string AttachedInfo;
    }

    public class LocalFriendRequest
    {
        public string FromUserID;
        public string FromNickname;
        public string FromFaceURL;
        // public int //FromGender; 
        public string ToUserID;
        public string ToNickname;
        public string ToFaceURL;
        // public int //ToGender; 
        public int HandleResult;
        public string ReqMsg;
        public long CreateTime;
        public string HandlerUserID;
        public string HandleMsg;
        public long HandleTime;
        public string Ex;
        public string AttachedInfo;
    }

    public class LocalGroup
    {
        public string GroupID;
        public string GroupName;
        public string Notification;
        public string Introduction;
        public string FaceURL;
        public long CreateTime;
        public int Status;
        public string CreatorUserID;
        public int GroupType;
        public string OwnerUserID;
        public int MemberCount;
        public string Ex;
        public string AttachedInfo;
        public int NeedVerification;
        public int LookMemberInfo;
        public int ApplyMemberFriend;
        public long NotificationUpdateTime;
        public string NotificationUserID;
    }

    public class LocalGroupMember
    {
        public string GroupID;
        public string UserID;
        public string Nickname;
        public string FaceURL;
        public int RoleLevel;
        public long JoinTime;
        public int JoinSource;
        public string InviterUserID;
        public long MuteEndTime;
        public string OperatorUserID;
        public string Ex;
        public string AttachedInfo;
    }

    public class LocalGroupRequest
    {
        public string GroupID;
        public string GroupName;
        public string Notification;
        public string Introduction;
        public string GroupFaceURL;
        public long CreateTime;
        public int Status;
        public string CreatorUserID;
        public int GroupType;
        public string OwnerUserID;
        public int MemberCount;
        public string UserID;
        public string Nickname;
        public string UserFaceURL;
        // public int //Gender; 
        public int HandleResult;
        public string ReqMsg;
        public string HandledMsg;
        public long ReqTime;
        public string HandleUserID;
        public long HandledTime;
        public string Ex;
        public string AttachedInfo;
        public int JoinSource;
        public string InviterUserID;
    }

    public class LocalUser
    {
        public string UserID;
        public string Nickname;
        public string FaceURL;
        public long CreateTime;
        public int AppMangerLevel;
        public string Ex;
        public string AttachedInfo;
        public int GlobalRecvMsgOpt;
    }

    public class LocalBlack
    {
        public string OwnerUserID;
        public string BlockUserID;
        public string Nickname;
        public string FaceURL;
        // public int //Gender; 
        public long CreateTime;
        public int AddSource;
        public string OperatorUserID;
        public string Ex;
        public string AttachedInfo;
    }

    public class LocalSeqData
    {
        public string UserID;
        public uint Seq;
    }

    public class LocalSeq
    {
        public string ID;
        public uint MinSeq;
    }

    public class LocalChatLog
    {
        public string ClientMsgID;
        public string ServerMsgID;
        public string SendID;
        public string RecvID;
        public int SenderPlatformID;
        public string SenderNickname;
        public string SenderFaceURL;
        public int SessionType;
        public int MsgFrom;
        public int ContentType;
        public string Content;
        public bool IsRead;
        public int Status;
        public long Seq;
        public long SendTime;
        public long CreateTime;
        public string AttachedInfo;
        public string Ex;
        public string LocalEx;
        public bool IsReact;
        public bool IsExternalExtensions;
        public long MsgFirstModifyTime;
    }

    public class LocalErrChatLog
    {
        public long Seq;
        public string ClientMsgID;
        public string ServerMsgID;
        public string SendID;
        public string RecvID;
        public int SenderPlatformID;
        public string SenderNickname;
        public string SenderFaceURL;
        public int SessionType;
        public int MsgFrom;
        public int ContentType;
        public string Content;
        public bool IsRead;
        public int Status;
        public long SendTime;
        public long CreateTime;
        public string AttachedInfo;
        public string Ex;
    }

    public class TempCacheLocalChatLog
    {
        public string ClientMsgID;
        public string ServerMsgID;
        public string SendID;
        public string RecvID;
        public int SenderPlatformID;
        public string SenderNickname;
        public string SenderFaceURL;
        public int SessionType;
        public int MsgFrom;
        public int ContentType;
        public string Content;
        public bool IsRead;
        public int Status;
        public long Seq;
        public long SendTime;
        public long CreateTime;
        public string AttachedInfo;
        public string Ex;
    }

    public class LocalConversation
    {
        public string ConversationID;
        public int ConversationType;
        public string UserID;
        public string GroupID;
        public string ShowName;
        public string FaceURL;
        public int RecvMsgOpt;
        public int UnreadCount;
        public int GroupAtType;
        public string LatestMsg;
        public long LatestMsgSendTime;
        public string DraftText;
        public long DraftTextTime;
        public bool IsPinned;
        public bool IsPrivateChat;
        public int BurnDuration;
        public bool IsNotInGroup;
        public long UpdateUnreadCountTime;
        public string AttachedInfo;
        public string Ex;
        public long MaxSeq;
        public long MinSeq;
        public long HasReadSeq;
        public long MsgDestructTime;
        public bool IsMsgDestruct;
        MsgStruct LatestMsgStruct;
        public MsgStruct GetLatestMsg()
        {
            if (LatestMsgStruct == null)
            {
                LatestMsgStruct = Utils.FromJson<MsgStruct>(LatestMsg);
            }
            return LatestMsgStruct;
        }
    }

    public class LocalConversationUnreadMessage
    {
        public string ConversationID;
        public string ClientMsgID;
        public long SendTime;
        public string Ex;
    }

    public class LocalAdminGroupRequest
    {
    }

    public class LocalChatLogReactionExtensions
    {
        public string ClientMsgID;
        public byte[] LocalReactionExtensions;
    }

    public class LocalWorkMomentsNotification
    {
        public string JsonDetail;
        public long CreateTime;
    }

    public class WorkMomentNotificationMsg
    {
        public int NotificationMsgType;
        public string ReplyUserName;
        public string ReplyUserID;
        public string Content;
        public string ContentID;
        public string WorkMomentID;
        public string UserID;
        public string UserName;
        public string FaceURL;
        public string WorkMomentContent;
        public int CreateTime;
    }

    public class LocalWorkMomentsNotificationUnreadCount
    {
        public int UnreadCount;
    }

    public class NotificationSeqs
    {
        public string ConversationID;
        public long Seq;
    }

    public class LocalUpload
    {
        public string PartHash;
        public string UploadID;
        public string UploadInfo;
        public long ExpireTime;
        public long CreateTime;
    }

    public class ConversationArgs
    {
        public string ConversationID;
        public string[] ClientMsgIDList;
    }

    public class FindMessageListCallback
    {
        public int TotalCount;
        public SearchByConversationResult[] FindResultItems;
    }

    public class AdvancedHistoryMessageData
    {
        public MsgStruct[] MessageList;
        public long LastMinSeq;
        public bool IsEnd;
        public int ErrCode;
        public string ErrMsg;
    }

    public class SearchLocalMessagesCallback
    {
        public int TotalCount;
        public SearchByConversationResult[] SearchResultItems;
    }

    public class SearchByConversationResult
    {
        public string ConversationID;
        public int ConversationType;
        public string ShowName;
        public string FaceURL;
        public int MessageCount;
        public MsgStruct[] MessageList;
    }

    public class SetMessageReactionExtensionsCallback
    {
        public string Key;
        public string Value;
        public int ErrCode;
        public string ErrMsg;
    }

    public class AddMessageReactionExtensionsCallback
    {
        public string Key;
        public string Value;
        public int ErrCode;
        public string ErrMsg;
    }

    public class GetTypekeyListResp
    {
        public SingleTypeKeyInfoSum[] TypeKeyInfoList;
    }

    public class SingleTypeKeyInfoSum
    {
        public string TypeKey;
        public long Counter;
        public Info[] InfoList;
        public bool IsContainSelf;
    }

    public class SingleTypeKeyInfo
    {
        public string TypeKey;
        public long Counter;
        public bool IsCanRepeat;
        public int Index;
        // public map[string] Info InfoList; 
    }

    public class Info
    {
        public string UserID;
        public string Ex;
    }

    public class AddFriendParams
    {
        public string ToUserID;
        public string ReqMsg;
    }

    public class ProcessFriendApplicationParams
    {
        public string ToUserID;
        public string HandleMsg;
    }

    public class SearchFriendsParam
    {
        public string[] KeywordList;
        public bool IsSearchUserID;
        public bool IsSearchNickname;
        public bool IsSearchRemark;
    }

    public class GetFriendListPage
    {
    }

    public class SearchFriendItem
    {
        public int Relationship;
    }

    public class SetFriendRemarkParams
    {
        public string ToUserID;
        public string Remark;
    }

    public class CreateGroupBaseInfoParam
    {
        public int GroupType;
    }

    public class SearchGroupsParam
    {
        public string[] KeywordList;
        public bool IsSearchGroupID;
        public bool IsSearchGroupName;
    }

    public class SearchGroupMembersParam
    {
        public string GroupID;
        public string[] KeywordList;
        public bool IsSearchUserID;
        public bool IsSearchMemberNickname;
        // public count //offset,; 
        public int Offset;
        public int Count;
    }

    public class SetGroupInfoParam
    {
        public string GroupName;
        public string Notification;
        public string Introduction;
        public string FaceURL;
        public string Ex;
        public int NeedVerification;
    }

    public class SetGroupMemberInfoParam
    {
        public string GroupID;
        public string UserID;
        public string Ex;
    }
    public class OnlineStatus
    {
        public string UserID;
        public int Status;
        public int[] PlatformIDs;
    }
    public class PublicUser
    {
        public string UserID;
        public string Nickname;
        public string FaceURL;
        public string Ex;
        public long CreateTime;
    }
    public class FullUserInfo
    {
        public PublicUser PublicInfo;
        public LocalFriend FriendInfo;
        public LocalBlack BlackInfo;
    }

    public class GetAdvancedHistoryMessageList
    {
        public MsgStruct MessageList;
        public long LastMinSeq;
        public bool IsEnd;
        public int ErrCode;
        public string ErrMsg;
    }
    public class GetConversationRecvMessageOptResp
    {
        public string ConversationID;
        public int Result;
    }
    public class FindMessageList
    {
        public int TotalCount;
        public SearchByConversationResult[] FindResultItems;
    }
    public class FullUserInfoWithCache
    {
        public PublicUser PublicInfo;
        public LocalFriend FriendInfo;
        public LocalBlack BlackInfo;
        public LocalGroupMember GroupMemberInfo;
    }
    public class UserIDResult
    {
        public string UserID;
        public int Result;
    }

    public class GroupInfo
    {
        public string GroupID;
        public string stringGroupName;
        public string Notification;
        public string Introduction;
        public string stringFaceURL;
        public string stringOwnerUserID;
        public long CreateTime;
        public uint MemberCount;
        public string Ex;
        public int Status;
        public string CreatorUserID;
        public int GroupType;
        public int NeedVerification;
        public int LookMemberInfo;
        public int ApplyMemberFriend;
        public long NotificationUpdateTime;
        public string NotificationUserID;
    }
    public class OfflinePushInfo
    {
        [JsonProperty("title")]
        public string Title;
        [JsonProperty("desc")]
        public string Desc;
        [JsonProperty("ex")]
        public string Ex;
        [JsonProperty("iOSPushSound")]
        public string IOSPushSound;
        [JsonProperty("iOSBadgeCount")]
        public bool IOSBadgeCount;
        [JsonProperty("signalInfo")]
        public string SignalInfo;
    }
    public class UserInfo
    {
        public string UserID;
        public string Nickname;
        public string FaceURL;
        public string Ex;
        public long CreateTime;
        public int AppMangerLevel;
        public int GlobalRecvMsgOpt;
    }
    public class ApplyToAddFriendReq
    {
        public string FromUserID;
        public string ToUserID;
        public string ReqMsg;
        public string Ex;
    }
    public class CreateGroupReq
    {
        public string[] MemberUserIDs;
        public GroupInfo GroupInfo;
        public string[] AdminUserIDs;
        public string OwnerUserID;
    }
    public class StringValue
    {
        public string Value;
    }
    public class Int32Value
    {
        public int Value;
    }

    public class SetGroupMemberInfo
    {
        public string GroupID;
        public string UserID;
        public StringValue Nickname;
        public StringValue FaceURL;
        public Int32Value RoleLevel;
        public StringValue Ex;
    }
    public class GroupInfoForSet
    {
        public string GroupID;
        public string GroupName;
        public string Notification;
        public string Introduction;
        public string FaceURL;
        public StringValue Ex;
        public Int32Value NeedVerification;
        public Int32Value LookMemberInfo;
        public Int32Value ApplyMemberFriend;
    }
}