// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenIM.Proto {

  /// <summary>Holder for reflection information generated from common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgxjb21tb24ucHJvdG8SEW9wZW5pbS5zZGsuY29tbW9uInsKD09mZmxpbmVQ",
            "dXNoSW5mbxINCgV0aXRsZRgBIAEoCRIMCgRkZXNjGAIgASgJEgoKAmV4GAMg",
            "ASgJEhQKDGlPU1B1c2hTb3VuZBgEIAEoCRIVCg1pT1NCYWRnZUNvdW50GAUg",
            "ASgIEhIKCnNpZ25hbEluZm8YBiABKAkiOwoRUmVxdWVzdFBhZ2luYXRpb24S",
            "EgoKcGFnZU51bWJlchgBIAEoBRISCgpzaG93TnVtYmVyGAIgASgFKlwKC1Nl",
            "c3Npb25UeXBlEhAKDFNlc3Npb25UeXBlXxAAEgoKBlNpbmdsZRABEg4KCldy",
            "aXRlR3JvdXAQAhINCglSZWFkR3JvdXAQAxIQCgxOb3RpZmljYXRpb24QBCou",
            "CgdNc2dGcm9tEgwKCE1zZ0Zyb21fEAASCAoEVXNlchBkEgsKBlN5c3RlbRDI",
            "ASqcAQoIUGxhdGZvcm0SDQoJUGxhdGZvcm1fEAASBwoDaU9TEAESCwoHQW5k",
            "cm9pZBACEgsKB1dpbmRvd3MQAxIJCgVtYWNPUxAEEgcKA1dlYhAFEgsKB01p",
            "bmlXZWIQBhIJCgVMaW51eBAHEg4KCkFuZHJvaWRQYWQQCBIICgRpUGFkEAkS",
            "CQoFQWRtaW4QChINCglIYXJtb255T1MQCyrBAQoMQXBwRnJhbWV3b3JrEhEK",
            "DUFwcEZyYW1ld29ya18QABIKCgZOYXRpdmUQARILCgdGbHV0dGVyEAISDwoL",
            "UmVhY3ROYXRpdmUQAxIMCghFbGVjdHJvbhAEEgkKBVVuaXR5EAUSEAoMVW5y",
            "ZWFsRW5naW5lEAYSBgoCUXQQBxIKCgZEb3ROZXQQCBIOCgpEb3ROZXRNQVVJ",
            "EAkSDAoIQXZhbG9uaWEQChILCgdDb3Jkb3ZhEAsSCgoGVW5pQXBwEAwqZwoJ",
            "TXNnU3RhdHVzEg4KCk1zZ1N0YXR1c18QABILCgdTZW5kaW5nEAESDwoLU2Vu",
            "ZFN1Y2Nlc3MQAhIOCgpTZW5kRmFpbGVkEAMSDgoKSGFzRGVsZXRlZBAEEgwK",
            "CEZpbHRlcmVkEAUq1QYKC0NvbnRlbnRUeXBlEhAKDENvbnRlbnRUeXBlXxAA",
            "EggKBFRleHQQZRILCgdQaWN0dXJlEGYSCQoFU291bmQQZxIJCgVWaWRlbxBo",
            "EggKBEZpbGUQaRIKCgZBdFRleHQQahIJCgVNZXJnZRBrEggKBENhcmQQbBIM",
            "CghMb2NhdGlvbhBtEgoKBkN1c3RvbRBuEgoKBlR5cGluZxBxEgkKBVF1b3Rl",
            "EHISCAoERmFjZRBzEgoKBlN0cmVhbRB0EhAKDEFkdmFuY2VkVGV4dBB1EiMK",
            "H0N1c3RvbU1zZ05vdFRyaWdnZXJDb252ZXJzYXRpb24QdxIXChNDdXN0b21N",
            "c2dPbmxpbmVPbmx5EHgSKgolRnJpZW5kQXBwbGljYXRpb25BcHByb3ZlZE5v",
            "dGlmaWNhdGlvbhCxCRIdChhHcm91cENyZWF0ZWROb3RpZmljYXRpb24Q3QsS",
            "GwoWTWVtYmVyUXVpdE5vdGlmaWNhdGlvbhDgCxImCiFHcm91cE93bmVyVHJh",
            "bnNmZXJyZWROb3RpZmljYXRpb24Q4wsSHQoYTWVtYmVyS2lja2VkTm90aWZp",
            "Y2F0aW9uEOQLEh4KGU1lbWJlckludml0ZWROb3RpZmljYXRpb24Q5QsSHAoX",
            "TWVtYmVyRW50ZXJOb3RpZmljYXRpb24Q5gsSHwoaR3JvdXBEaXNtaXNzZWRO",
            "b3RpZmljYXRpb24Q5wsSIQocR3JvdXBNZW1iZXJNdXRlZE5vdGlmaWNhdGlv",
            "bhDoCxInCiJHcm91cE1lbWJlckNhbmNlbE11dGVkTm90aWZpY2F0aW9uEOkL",
            "EhsKFkdyb3VwTXV0ZWROb3RpZmljYXRpb24Q6gsSIQocR3JvdXBDYW5jZWxN",
            "dXRlZE5vdGlmaWNhdGlvbhDrCxIpCiRHcm91cEluZm9TZXRBbm5vdW5jZW1l",
            "bnROb3RpZmljYXRpb24Q7wsSIQocR3JvdXBJbmZvU2V0TmFtZU5vdGlmaWNh",
            "dGlvbhDwCxIoCiNDb252ZXJzYXRpb25Qcml2YXRlQ2hhdE5vdGlmaWNhdGlv",
            "bhClDRIZChRCdXNpbmVzc05vdGlmaWNhdGlvbhDRDxIYChNSZXZva2VkTm90",
            "aWZpY2F0aW9uELUQKkIKDkFwcHJvdmFsU3RhdHVzEgsKB0RlZmF1bHQQABIM",
            "CghBcHByb3ZlZBABEhUKCFJlamVjdGVkEP///////////wEqWAoOQ29udlJl",
            "Y3ZNc2dPcHQSEgoOUmVjZWl2ZU1lc3NhZ2UQABIVChFOb3RSZWNlaXZlTWVz",
            "c2FnZRABEhsKF1JlY2VpdmVOb3ROb3RpZnlNZXNzYWdlEAIqQwoPQ29udkdy",
            "b3VwQXRUeXBlEgwKCEF0Tm9ybWFsEAASCAoEQXRNZRABEgkKBUF0QWxsEAIS",
            "DQoJQXRBbGxBdE1lEAMqPQoQR2xvYmFsUmVjdk1zZ09wdBIKCgZOb3JtYWwQ",
            "ABIOCgpOb3RSZWNlaXZlEAESDQoJTm90Tm90aWZ5EAIqfwoITG9nTGV2ZWwS",
            "DgoKTGV2ZWxGYXRhbBAAEg4KCkxldmVsUGFuaWMQARIOCgpMZXZlbEVycm9y",
            "EAISDQoJTGV2ZWxXYXJuEAMSDQoJTGV2ZWxJbmZvEAQSDgoKTGV2ZWxEZWJ1",
            "ZxAFEhUKEUxldmVsRGVidWdXaXRoU1FMEAYqXgoRVXBsb2FkU0RLRGF0YU1v",
            "ZGUSFgoSVXBsb2FkU0RLRGF0YU1vZGVfEAASDgoKVXBsb2FkTG9ncxABEgwK",
            "CFVwbG9hZERCEAISEwoPVXBsb2FkTG9nc0FuZERCEAMqaAoLUmV2b2tlclJv",
            "bGUSFgoSUmV2b2tlclJvbGVEZWZhdWx0EAASFAoQUmV2b2tlclJvbGVPd25l",
            "chBkEhQKEFJldm9rZXJSb2xlQWRtaW4QPBIVChFSZXZva2VyUm9sZU1lbWJl",
            "chAUKjkKDEZyaWVuZFNvdXJjZRIRCg1GcmllbmRTb3VyY2VfEAASCgoGU2Vh",
            "cmNoEAMSCgoGUVJDb2RlEAQqTwoMSGFuZGxlUmVzdWx0EhEKDVJlc3VsdERl",
            "ZmF1bHQQABIaCg1SZXN1bHREZWNsaW5lEP///////////wESEAoMUmVzdWx0",
            "QWNjZXB0EAFCS1o3Z2l0aHViLmNvbS9vcGVuaW1zZGsvb3BlbmltLXNkay1j",
            "b3JlL3YzL3Byb3RvL2dvL2NvbW1vbqoCDE9wZW5JTS5Qcm90b7oCAGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OpenIM.Proto.SessionType), typeof(global::OpenIM.Proto.MsgFrom), typeof(global::OpenIM.Proto.Platform), typeof(global::OpenIM.Proto.AppFramework), typeof(global::OpenIM.Proto.MsgStatus), typeof(global::OpenIM.Proto.ContentType), typeof(global::OpenIM.Proto.ApprovalStatus), typeof(global::OpenIM.Proto.ConvRecvMsgOpt), typeof(global::OpenIM.Proto.ConvGroupAtType), typeof(global::OpenIM.Proto.GlobalRecvMsgOpt), typeof(global::OpenIM.Proto.LogLevel), typeof(global::OpenIM.Proto.UploadSDKDataMode), typeof(global::OpenIM.Proto.RevokerRole), typeof(global::OpenIM.Proto.FriendSource), typeof(global::OpenIM.Proto.HandleResult), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenIM.Proto.OfflinePushInfo), global::OpenIM.Proto.OfflinePushInfo.Parser, new[]{ "Title", "Desc", "Ex", "IOSPushSound", "IOSBadgeCount", "SignalInfo" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenIM.Proto.RequestPagination), global::OpenIM.Proto.RequestPagination.Parser, new[]{ "PageNumber", "ShowNumber" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum SessionType {
    [pbr::OriginalName("SessionType_")] SessionType = 0,
    /// <summary>
    /// Single represents a single chat session type.
    /// </summary>
    [pbr::OriginalName("Single")] Single = 1,
    /// <summary>
    /// WriteGroup represents a write-diffusion group chat session type (not
    /// currently enabled, can be ignored).
    /// </summary>
    [pbr::OriginalName("WriteGroup")] WriteGroup = 2,
    /// <summary>
    /// ReadGroup represents a read-diffusion group chat session type, used for all
    /// current group chats in OpenIM.
    /// </summary>
    [pbr::OriginalName("ReadGroup")] ReadGroup = 3,
    /// <summary>
    /// Notification represents a notification session type, generated by the
    /// client when the server sends a notification.
    /// </summary>
    [pbr::OriginalName("Notification")] Notification = 4,
  }

  public enum MsgFrom {
    [pbr::OriginalName("MsgFrom_")] MsgFrom = 0,
    /// <summary>
    /// User represents a message type originating from a user.
    /// </summary>
    [pbr::OriginalName("User")] User = 100,
    /// <summary>
    /// System represents a system message type, typically generated by the system.
    /// </summary>
    [pbr::OriginalName("System")] System = 200,
  }

  public enum Platform {
    [pbr::OriginalName("Platform_")] Platform = 0,
    /// <summary>
    /// iOS represents the Apple iOS platform.
    /// </summary>
    [pbr::OriginalName("iOS")] IOs = 1,
    /// <summary>
    /// Android represents the Android platform.
    /// </summary>
    [pbr::OriginalName("Android")] Android = 2,
    /// <summary>
    /// Windows represents the Microsoft Windows platform.
    /// </summary>
    [pbr::OriginalName("Windows")] Windows = 3,
    /// <summary>
    /// macOS represents the Apple macOS platform.
    /// </summary>
    [pbr::OriginalName("macOS")] MacOs = 4,
    /// <summary>
    /// Web represents the web browser platform.
    /// </summary>
    [pbr::OriginalName("Web")] Web = 5,
    /// <summary>
    /// MiniWeb represents the mini-program or mini-web platform.
    /// </summary>
    [pbr::OriginalName("MiniWeb")] MiniWeb = 6,
    /// <summary>
    /// Linux represents the Linux platform.
    /// </summary>
    [pbr::OriginalName("Linux")] Linux = 7,
    /// <summary>
    /// AndroidPad represents the Android tablet platform.
    /// </summary>
    [pbr::OriginalName("AndroidPad")] AndroidPad = 8,
    /// <summary>
    /// iPad represents the Apple iPad platform.
    /// </summary>
    [pbr::OriginalName("iPad")] IPad = 9,
    /// <summary>
    /// Admin represents the admin panel or management platform, typically used for
    /// backend administrators. This platform is specifically for administrative
    /// filling and can generally be ignored.
    /// </summary>
    [pbr::OriginalName("Admin")] Admin = 10,
    /// <summary>
    /// HarmonyOS represents the Huawei HarmonyOS platform.
    /// </summary>
    [pbr::OriginalName("HarmonyOS")] HarmonyOs = 11,
  }

  public enum AppFramework {
    [pbr::OriginalName("AppFramework_")] AppFramework = 0,
    [pbr::OriginalName("Native")] Native = 1,
    [pbr::OriginalName("Flutter")] Flutter = 2,
    [pbr::OriginalName("ReactNative")] ReactNative = 3,
    [pbr::OriginalName("Electron")] Electron = 4,
    [pbr::OriginalName("Unity")] Unity = 5,
    [pbr::OriginalName("UnrealEngine")] UnrealEngine = 6,
    [pbr::OriginalName("Qt")] Qt = 7,
    [pbr::OriginalName("DotNet")] DotNet = 8,
    [pbr::OriginalName("DotNetMAUI")] DotNetMaui = 9,
    [pbr::OriginalName("Avalonia")] Avalonia = 10,
    [pbr::OriginalName("Cordova")] Cordova = 11,
    [pbr::OriginalName("UniApp")] UniApp = 12,
  }

  public enum MsgStatus {
    [pbr::OriginalName("MsgStatus_")] MsgStatus = 0,
    [pbr::OriginalName("Sending")] Sending = 1,
    [pbr::OriginalName("SendSuccess")] SendSuccess = 2,
    [pbr::OriginalName("SendFailed")] SendFailed = 3,
    [pbr::OriginalName("HasDeleted")] HasDeleted = 4,
    [pbr::OriginalName("Filtered")] Filtered = 5,
  }

  public enum ContentType {
    [pbr::OriginalName("ContentType_")] ContentType = 0,
    [pbr::OriginalName("Text")] Text = 101,
    [pbr::OriginalName("Picture")] Picture = 102,
    [pbr::OriginalName("Sound")] Sound = 103,
    [pbr::OriginalName("Video")] Video = 104,
    [pbr::OriginalName("File")] File = 105,
    [pbr::OriginalName("AtText")] AtText = 106,
    [pbr::OriginalName("Merge")] Merge = 107,
    [pbr::OriginalName("Card")] Card = 108,
    [pbr::OriginalName("Location")] Location = 109,
    [pbr::OriginalName("Custom")] Custom = 110,
    [pbr::OriginalName("Typing")] Typing = 113,
    [pbr::OriginalName("Quote")] Quote = 114,
    [pbr::OriginalName("Face")] Face = 115,
    [pbr::OriginalName("Stream")] Stream = 116,
    [pbr::OriginalName("AdvancedText")] AdvancedText = 117,
    [pbr::OriginalName("CustomMsgNotTriggerConversation")] CustomMsgNotTriggerConversation = 119,
    [pbr::OriginalName("CustomMsgOnlineOnly")] CustomMsgOnlineOnly = 120,
    /// <summary>
    ///  FriendApplicationRejectedNotification = 1202;
    ///  FriendApplicationNotification = 1203;
    ///  FriendAddedNotification = 1204;
    ///  FriendDeletedNotification = 1205;
    ///  FriendRemarkSetNotification = 1206;
    /// </summary>
    [pbr::OriginalName("FriendApplicationApprovedNotification")] FriendApplicationApprovedNotification = 1201,
    /// <summary>
    ///  BlackAddedNotification = 1207;
    ///  BlackDeletedNotification = 1208;
    ///  FriendInfoUpdatedNotification = 1209;
    ///  FriendsInfoUpdateNotification = 1210;
    ///  ConversationChangeNotification = 1300;
    ///  UserInfoUpdatedNotification = 1303;
    ///  UserStatusChangeNotification = 1304;
    ///  UserCommandAddNotification = 1305;
    ///  UserCommandDeleteNotification = 1306;
    ///  UserCommandUpdateNotification = 1307;
    /// </summary>
    [pbr::OriginalName("GroupCreatedNotification")] GroupCreatedNotification = 1501,
    /// <summary>
    ///  GroupInfoSetNotification = 1502;
    ///  JoinGroupApplicationNotification = 1503;
    /// </summary>
    [pbr::OriginalName("MemberQuitNotification")] MemberQuitNotification = 1504,
    /// <summary>
    ///  GroupApplicationAcceptedNotification = 1505;
    ///  GroupApplicationRejectedNotification = 1506;
    /// </summary>
    [pbr::OriginalName("GroupOwnerTransferredNotification")] GroupOwnerTransferredNotification = 1507,
    [pbr::OriginalName("MemberKickedNotification")] MemberKickedNotification = 1508,
    [pbr::OriginalName("MemberInvitedNotification")] MemberInvitedNotification = 1509,
    [pbr::OriginalName("MemberEnterNotification")] MemberEnterNotification = 1510,
    [pbr::OriginalName("GroupDismissedNotification")] GroupDismissedNotification = 1511,
    [pbr::OriginalName("GroupMemberMutedNotification")] GroupMemberMutedNotification = 1512,
    [pbr::OriginalName("GroupMemberCancelMutedNotification")] GroupMemberCancelMutedNotification = 1513,
    [pbr::OriginalName("GroupMutedNotification")] GroupMutedNotification = 1514,
    [pbr::OriginalName("GroupCancelMutedNotification")] GroupCancelMutedNotification = 1515,
    /// <summary>
    ///  GroupMemberInfoSetNotification = 1516;
    ///  GroupMemberSetToAdminNotification = 1517;
    ///  GroupMemberSetToOrdinaryUserNotification = 1518;
    ///  GroupInfoSetAnnouncementNotification = 1519;
    /// </summary>
    [pbr::OriginalName("GroupInfoSetAnnouncementNotification")] GroupInfoSetAnnouncementNotification = 1519,
    /// <summary>
    ///  GroupNotificationEnd                     = 1599;
    /// </summary>
    [pbr::OriginalName("GroupInfoSetNameNotification")] GroupInfoSetNameNotification = 1520,
    /// <summary>
    ///  ClearConversationNotification = 1703;
    /// </summary>
    [pbr::OriginalName("ConversationPrivateChatNotification")] ConversationPrivateChatNotification = 1701,
    [pbr::OriginalName("BusinessNotification")] BusinessNotification = 2001,
    [pbr::OriginalName("RevokedNotification")] RevokedNotification = 2101,
  }

  public enum ApprovalStatus {
    [pbr::OriginalName("Default")] Default = 0,
    [pbr::OriginalName("Approved")] Approved = 1,
    [pbr::OriginalName("Rejected")] Rejected = -1,
  }

  public enum ConvRecvMsgOpt {
    [pbr::OriginalName("ReceiveMessage")] ReceiveMessage = 0,
    [pbr::OriginalName("NotReceiveMessage")] NotReceiveMessage = 1,
    [pbr::OriginalName("ReceiveNotNotifyMessage")] ReceiveNotNotifyMessage = 2,
  }

  public enum ConvGroupAtType {
    [pbr::OriginalName("AtNormal")] AtNormal = 0,
    [pbr::OriginalName("AtMe")] AtMe = 1,
    [pbr::OriginalName("AtAll")] AtAll = 2,
    [pbr::OriginalName("AtAllAtMe")] AtAllAtMe = 3,
  }

  /// <summary>
  /// GlobalRecvMsgOpt represents the global message receive option.
  ///
  /// In the globalRecvMsgOpt of UserInfo, globally control whether to receive
  /// offline push notifications.
  ///
  /// In the recvMsgOpt of a ConversationInfo, in addition to controlling whether
  /// to receive offline push notifications for that session, it also controls
  /// whether the unread count of that session is included in the total unread
  /// count.
  /// </summary>
  public enum GlobalRecvMsgOpt {
    /// <summary>
    /// Normally receive messages
    /// </summary>
    [pbr::OriginalName("Normal")] Normal = 0,
    /// <summary>
    /// Reserved field
    /// </summary>
    [pbr::OriginalName("NotReceive")] NotReceive = 1,
    /// <summary>
    /// Receive messages, but no offline push. When in conversation,
    /// </summary>
    [pbr::OriginalName("NotNotify")] NotNotify = 2,
  }

  /// <summary>
  /// LogLevel represents the log level. debug -> info -> warn -> error -> fatal.
  /// Default log level is LevelWarn or LevelDebug.
  /// </summary>
  public enum LogLevel {
    /// <summary>
    /// only print fatal log
    /// </summary>
    [pbr::OriginalName("LevelFatal")] LevelFatal = 0,
    /// <summary>
    /// print panic and fatal log
    /// </summary>
    [pbr::OriginalName("LevelPanic")] LevelPanic = 1,
    /// <summary>
    /// print error, panic and fatal log
    /// </summary>
    [pbr::OriginalName("LevelError")] LevelError = 2,
    /// <summary>
    /// print warn, error, panic and fatal log
    /// </summary>
    [pbr::OriginalName("LevelWarn")] LevelWarn = 3,
    /// <summary>
    /// print info, warn, error, panic and fatal log
    /// </summary>
    [pbr::OriginalName("LevelInfo")] LevelInfo = 4,
    /// <summary>
    /// print all level log
    /// </summary>
    [pbr::OriginalName("LevelDebug")] LevelDebug = 5,
    /// <summary>
    /// print all level log and sql log
    /// </summary>
    [pbr::OriginalName("LevelDebugWithSQL")] LevelDebugWithSql = 6,
  }

  /// <summary>
  /// UploadSDKDataMode represents the mode of upload sdk data.
  /// If multiple modes are needed, their values should be ModeA | ModeB
  /// e.g. UploadLogsAndDB = UploadLogs | UploadDB
  /// </summary>
  public enum UploadSDKDataMode {
    /// <summary>
    /// invalid mode. Because the first enum value must be
    /// </summary>
    [pbr::OriginalName("UploadSDKDataMode_")] UploadSdkdataMode = 0,
    /// <summary>
    /// 0 in proto3, this field is required.
    /// </summary>
    [pbr::OriginalName("UploadLogs")] UploadLogs = 1,
    /// <summary>
    /// only upload db
    /// </summary>
    [pbr::OriginalName("UploadDB")] UploadDb = 2,
    /// <summary>
    /// upload db and logs
    /// </summary>
    [pbr::OriginalName("UploadLogsAndDB")] UploadLogsAndDb = 3,
  }

  public enum RevokerRole {
    [pbr::OriginalName("RevokerRoleDefault")] Default = 0,
    [pbr::OriginalName("RevokerRoleOwner")] Owner = 100,
    [pbr::OriginalName("RevokerRoleAdmin")] Admin = 60,
    [pbr::OriginalName("RevokerRoleMember")] Member = 20,
  }

  public enum FriendSource {
    [pbr::OriginalName("FriendSource_")] FriendSource = 0,
    [pbr::OriginalName("Search")] Search = 3,
    [pbr::OriginalName("QRCode")] Qrcode = 4,
  }

  public enum HandleResult {
    [pbr::OriginalName("ResultDefault")] ResultDefault = 0,
    [pbr::OriginalName("ResultDecline")] ResultDecline = -1,
    [pbr::OriginalName("ResultAccept")] ResultAccept = 1,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OfflinePushInfo : pb::IMessage<OfflinePushInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflinePushInfo> _parser = new pb::MessageParser<OfflinePushInfo>(() => new OfflinePushInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflinePushInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenIM.Proto.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflinePushInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflinePushInfo(OfflinePushInfo other) : this() {
      title_ = other.title_;
      desc_ = other.desc_;
      ex_ = other.ex_;
      iOSPushSound_ = other.iOSPushSound_;
      iOSBadgeCount_ = other.iOSBadgeCount_;
      signalInfo_ = other.signalInfo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflinePushInfo Clone() {
      return new OfflinePushInfo(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "desc" field.</summary>
    public const int DescFieldNumber = 2;
    private string desc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Desc {
      get { return desc_; }
      set {
        desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ex" field.</summary>
    public const int ExFieldNumber = 3;
    private string ex_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Ex {
      get { return ex_; }
      set {
        ex_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "iOSPushSound" field.</summary>
    public const int IOSPushSoundFieldNumber = 4;
    private string iOSPushSound_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IOSPushSound {
      get { return iOSPushSound_; }
      set {
        iOSPushSound_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "iOSBadgeCount" field.</summary>
    public const int IOSBadgeCountFieldNumber = 5;
    private bool iOSBadgeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IOSBadgeCount {
      get { return iOSBadgeCount_; }
      set {
        iOSBadgeCount_ = value;
      }
    }

    /// <summary>Field number for the "signalInfo" field.</summary>
    public const int SignalInfoFieldNumber = 6;
    private string signalInfo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SignalInfo {
      get { return signalInfo_; }
      set {
        signalInfo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflinePushInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflinePushInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (Desc != other.Desc) return false;
      if (Ex != other.Ex) return false;
      if (IOSPushSound != other.IOSPushSound) return false;
      if (IOSBadgeCount != other.IOSBadgeCount) return false;
      if (SignalInfo != other.SignalInfo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Desc.Length != 0) hash ^= Desc.GetHashCode();
      if (Ex.Length != 0) hash ^= Ex.GetHashCode();
      if (IOSPushSound.Length != 0) hash ^= IOSPushSound.GetHashCode();
      if (IOSBadgeCount != false) hash ^= IOSBadgeCount.GetHashCode();
      if (SignalInfo.Length != 0) hash ^= SignalInfo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Desc);
      }
      if (Ex.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ex);
      }
      if (IOSPushSound.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(IOSPushSound);
      }
      if (IOSBadgeCount != false) {
        output.WriteRawTag(40);
        output.WriteBool(IOSBadgeCount);
      }
      if (SignalInfo.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SignalInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Desc);
      }
      if (Ex.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ex);
      }
      if (IOSPushSound.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(IOSPushSound);
      }
      if (IOSBadgeCount != false) {
        output.WriteRawTag(40);
        output.WriteBool(IOSBadgeCount);
      }
      if (SignalInfo.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SignalInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Desc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Desc);
      }
      if (Ex.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ex);
      }
      if (IOSPushSound.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IOSPushSound);
      }
      if (IOSBadgeCount != false) {
        size += 1 + 1;
      }
      if (SignalInfo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SignalInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OfflinePushInfo other) {
      if (other == null) {
        return;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Desc.Length != 0) {
        Desc = other.Desc;
      }
      if (other.Ex.Length != 0) {
        Ex = other.Ex;
      }
      if (other.IOSPushSound.Length != 0) {
        IOSPushSound = other.IOSPushSound;
      }
      if (other.IOSBadgeCount != false) {
        IOSBadgeCount = other.IOSBadgeCount;
      }
      if (other.SignalInfo.Length != 0) {
        SignalInfo = other.SignalInfo;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Desc = input.ReadString();
            break;
          }
          case 26: {
            Ex = input.ReadString();
            break;
          }
          case 34: {
            IOSPushSound = input.ReadString();
            break;
          }
          case 40: {
            IOSBadgeCount = input.ReadBool();
            break;
          }
          case 50: {
            SignalInfo = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Desc = input.ReadString();
            break;
          }
          case 26: {
            Ex = input.ReadString();
            break;
          }
          case 34: {
            IOSPushSound = input.ReadString();
            break;
          }
          case 40: {
            IOSBadgeCount = input.ReadBool();
            break;
          }
          case 50: {
            SignalInfo = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RequestPagination : pb::IMessage<RequestPagination>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RequestPagination> _parser = new pb::MessageParser<RequestPagination>(() => new RequestPagination());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RequestPagination> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenIM.Proto.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestPagination() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestPagination(RequestPagination other) : this() {
      pageNumber_ = other.pageNumber_;
      showNumber_ = other.showNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestPagination Clone() {
      return new RequestPagination(this);
    }

    /// <summary>Field number for the "pageNumber" field.</summary>
    public const int PageNumberFieldNumber = 1;
    private int pageNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PageNumber {
      get { return pageNumber_; }
      set {
        pageNumber_ = value;
      }
    }

    /// <summary>Field number for the "showNumber" field.</summary>
    public const int ShowNumberFieldNumber = 2;
    private int showNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ShowNumber {
      get { return showNumber_; }
      set {
        showNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RequestPagination);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RequestPagination other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PageNumber != other.PageNumber) return false;
      if (ShowNumber != other.ShowNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PageNumber != 0) hash ^= PageNumber.GetHashCode();
      if (ShowNumber != 0) hash ^= ShowNumber.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (PageNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageNumber);
      }
      if (ShowNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ShowNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PageNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageNumber);
      }
      if (ShowNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ShowNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PageNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageNumber);
      }
      if (ShowNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ShowNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RequestPagination other) {
      if (other == null) {
        return;
      }
      if (other.PageNumber != 0) {
        PageNumber = other.PageNumber;
      }
      if (other.ShowNumber != 0) {
        ShowNumber = other.ShowNumber;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            PageNumber = input.ReadInt32();
            break;
          }
          case 16: {
            ShowNumber = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            PageNumber = input.ReadInt32();
            break;
          }
          case 16: {
            ShowNumber = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
