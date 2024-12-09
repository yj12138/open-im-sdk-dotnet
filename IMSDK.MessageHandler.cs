using OpenIM.IMSDK.Util;
using OpenIM.Proto;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenIM.IMSDK
{
    public partial class IMSDK
    {
        static ConcurrentQueue<FfiResult> events = new ConcurrentQueue<FfiResult>();
        private static void EventHandler(IntPtr dataPtr, int len)
        {
            try
            {
                string data = Marshal.PtrToStringUTF8(dataPtr);
                Utils.Log("Recv:" + data);
                var byteArray = Encoding.UTF8.GetBytes(data);
                var result = FfiResult.Parser.ParseFrom(byteArray);
                events.Enqueue(result);
            }
            catch (Exception e)
            {
                Utils.Log(e.ToString());
            }
        }
        public static void DispatorMsg(FfiResult result)
        {
            var handleID = result.HandleID;
            var errCode = result.ErrCode;
            var errMsg = result.ErrMsg;
            var funcName = result.FuncName;
            var data = result.Data;
            switch (funcName)
            {
                case FuncRequestEventName.None:
                    break;

                case FuncRequestEventName.InitSdk:
                    {
                        var resp = InitSDKResp.Parser.ParseFrom(data);
                        
                        break;
                    }

                case FuncRequestEventName.Login:
                    break;

                case FuncRequestEventName.Logout:
                    break;

                case FuncRequestEventName.SetAppBackgroundStatus:
                    break;

                case FuncRequestEventName.NetworkStatusChanged:
                    break;

                case FuncRequestEventName.GetLoginStatus:
                    break;

                case FuncRequestEventName.Version:
                    break;

                case FuncRequestEventName.SendMessage:
                    break;

                case FuncRequestEventName.UploadLogs:
                    break;

                case FuncRequestEventName.UploadFile:
                    break;

                case FuncRequestEventName.Log:
                    break;

                case FuncRequestEventName.UpdateFcmToken:
                    break;

                case FuncRequestEventName.SetAppBadge:
                    break;

                case FuncRequestEventName.EventOnSendMsgProgress:
                    break;

                case FuncRequestEventName.EventOnUploadFileProgress:
                    break;

                case FuncRequestEventName.EventOnUploadLogsProgress:
                    break;

                case FuncRequestEventName.EventOnConnecting:
                    break;

                case FuncRequestEventName.EventOnConnectSuccess:
                    break;

                case FuncRequestEventName.EventOnConnectFailed:
                    break;

                case FuncRequestEventName.EventOnKickedOffline:
                    break;

                case FuncRequestEventName.EventOnUserTokenExpired:
                    break;

                case FuncRequestEventName.EventOnUserTokenInvalid:
                    break;

                case FuncRequestEventName.EventOnSyncServerStart:
                    break;

                case FuncRequestEventName.EventOnSyncServerFinish:
                    break;

                case FuncRequestEventName.EventOnSyncServerFailed:
                    break;

                case FuncRequestEventName.EventOnSyncServerProgress:
                    break;

                case FuncRequestEventName.EventOnNewConversation:
                    break;

                case FuncRequestEventName.EventOnConversationChanged:
                    break;

                case FuncRequestEventName.EventOnTotalUnreadMessageCountChanged:
                    break;

                case FuncRequestEventName.EventOnConversationUserInputStatusChanged:
                    break;

                case FuncRequestEventName.EventOnRecvNewMessage:
                    break;

                case FuncRequestEventName.EventOnRecvC2CreadReceipt:
                    break;

                case FuncRequestEventName.EventOnNewRecvMessageRevoked:
                    break;

                case FuncRequestEventName.EventOnRecvOfflineNewMessage:
                    break;

                case FuncRequestEventName.EventOnMessageDeleted:
                    break;

                case FuncRequestEventName.EventOnRecvOnlineOnlyMessage:
                    break;

                case FuncRequestEventName.EventOnMessageEdited:
                    break;

                case FuncRequestEventName.EventOnFriendApplicationAdded:
                    break;

                case FuncRequestEventName.EventOnFriendApplicationDeleted:
                    break;

                case FuncRequestEventName.EventOnFriendApplicationAccepted:
                    break;

                case FuncRequestEventName.EventOnFriendApplicationRejected:
                    break;

                case FuncRequestEventName.EventOnFriendAdded:
                    break;

                case FuncRequestEventName.EventOnFriendDeleted:
                    break;

                case FuncRequestEventName.EventOnFriendInfoChanged:
                    break;

                case FuncRequestEventName.EventOnBlackAdded:
                    break;

                case FuncRequestEventName.EventOnBlackDeleted:
                    break;

                case FuncRequestEventName.EventOnJoinedGroupAdded:
                    break;

                case FuncRequestEventName.EventOnJoinedGroupDeleted:
                    break;

                case FuncRequestEventName.EventOnGroupMemberAdded:
                    break;

                case FuncRequestEventName.EventOnGroupMemberDeleted:
                    break;

                case FuncRequestEventName.EventOnGroupApplicationAdded:
                    break;

                case FuncRequestEventName.EventOnGroupApplicationDeleted:
                    break;

                case FuncRequestEventName.EventOnGroupInfoChanged:
                    break;

                case FuncRequestEventName.EventOnGroupDismissed:
                    break;

                case FuncRequestEventName.EventOnGroupMemberInfoChanged:
                    break;

                case FuncRequestEventName.EventOnGroupApplicationAccepted:
                    break;

                case FuncRequestEventName.EventOnGroupApplicationRejected:
                    break;

                case FuncRequestEventName.EventOnRecvCustomBusinessMessage:
                    break;

                case FuncRequestEventName.EventOnSelfInfoUpdated:
                    break;

                case FuncRequestEventName.EventOnUserStatusChanged:
                    break;

                case FuncRequestEventName.EventOnUserCommandAdd:
                    break;

                case FuncRequestEventName.EventOnUserCommandDelete:
                    break;

                case FuncRequestEventName.EventOnUserCommandUpdate:
                    break;

                case FuncRequestEventName.CreateGroup:
                    break;

                case FuncRequestEventName.JoinGroup:
                    break;

                case FuncRequestEventName.QuitGroup:
                    break;

                case FuncRequestEventName.DismissGroup:
                    break;

                case FuncRequestEventName.ChangeGroupMute:
                    break;

                case FuncRequestEventName.ChangeGroupMemberMute:
                    break;

                case FuncRequestEventName.TransferGroupOwner:
                    break;

                case FuncRequestEventName.KickGroupMember:
                    break;

                case FuncRequestEventName.SetGroupInfo:
                    break;

                case FuncRequestEventName.SetGroupMemberInfo:
                    break;

                case FuncRequestEventName.GetJoinedGroups:
                    break;

                case FuncRequestEventName.GetJoinedGroupsPage:
                    break;

                case FuncRequestEventName.GetSpecifiedGroupsInfo:
                    break;

                case FuncRequestEventName.SearchGroups:
                    break;

                case FuncRequestEventName.GetGroupMemberOwnerAndAdmin:
                    break;

                case FuncRequestEventName.GetGroupMembersByJoinTimeFilter:
                    break;

                case FuncRequestEventName.GetSpecifiedGroupMembersInfo:
                    break;

                case FuncRequestEventName.GetGroupMembers:
                    break;

                case FuncRequestEventName.GetGroupRequest:
                    break;

                case FuncRequestEventName.SearchGroupMembers:
                    break;

                case FuncRequestEventName.IsJoinGroup:
                    break;

                case FuncRequestEventName.GetUsersInGroup:
                    break;

                case FuncRequestEventName.InviteUserToGroup:
                    break;

                case FuncRequestEventName.HandlerGroupRequest:
                    break;

                case FuncRequestEventName.GetSpecifiedFriends:
                    break;

                case FuncRequestEventName.AddFriend:
                    break;

                case FuncRequestEventName.GetFriendRequests:
                    break;

                case FuncRequestEventName.HandlerFriendRequest:
                    break;

                case FuncRequestEventName.CheckFriend:
                    break;

                case FuncRequestEventName.DeleteFriend:
                    break;

                case FuncRequestEventName.GetFriends:
                    break;

                case FuncRequestEventName.GetFriendsPage:
                    break;

                case FuncRequestEventName.SearchFriends:
                    break;

                case FuncRequestEventName.AddBlack:
                    break;

                case FuncRequestEventName.DeleteBlack:
                    break;

                case FuncRequestEventName.GetBlacks:
                    break;

                case FuncRequestEventName.UpdateFriends:
                    break;

                case FuncRequestEventName.GetAllConversationList:
                    break;

                case FuncRequestEventName.GetConversationListSplit:
                    break;

                case FuncRequestEventName.HideConversation:
                    break;

                case FuncRequestEventName.GetAtAllTag:
                    break;

                case FuncRequestEventName.GetOneConversation:
                    break;

                case FuncRequestEventName.GetMultipleConversation:
                    break;

                case FuncRequestEventName.HideAllConversations:
                    break;

                case FuncRequestEventName.SetConversationDraft:
                    break;

                case FuncRequestEventName.SetConversation:
                    break;

                case FuncRequestEventName.GetTotalUnreadMsgCount:
                    break;

                case FuncRequestEventName.GetConversationIdbySessionType:
                    break;

                case FuncRequestEventName.FindMessageList:
                    break;

                case FuncRequestEventName.GetAdvancedHistoryMessageList:
                    break;

                case FuncRequestEventName.GetAdvancedHistoryMessageListReverse:
                    break;

                case FuncRequestEventName.RevokeMessage:
                    break;

                case FuncRequestEventName.TypingStatusUpdate:
                    break;

                case FuncRequestEventName.MarkConversationMessageAsRead:
                    break;

                case FuncRequestEventName.MarkAllConversationMessageAsRead:
                    break;

                case FuncRequestEventName.DeleteMessageFromLocalStorage:
                    break;

                case FuncRequestEventName.DeleteMessage:
                    break;

                case FuncRequestEventName.DeleteAllMsgFromLocalAndServer:
                    break;

                case FuncRequestEventName.DeleteAllMessageFromLocalStorage:
                    break;

                case FuncRequestEventName.ClearConversationAndDeleteAllMsg:
                    break;

                case FuncRequestEventName.DeleteConversationAndDeleteAllMsg:
                    break;

                case FuncRequestEventName.InsertSingleMessageToLocalStorage:
                    break;

                case FuncRequestEventName.InsertGroupMessageToLocalStorage:
                    break;

                case FuncRequestEventName.SearchLocalMessages:
                    break;

                case FuncRequestEventName.SetMessageLocalEx:
                    break;

                case FuncRequestEventName.SearchConversation:
                    break;

                case FuncRequestEventName.CreateTextMessage:
                    break;

                case FuncRequestEventName.CreateAdvancedTextMessage:
                    break;

                case FuncRequestEventName.CreateTextAtMessage:
                    break;

                case FuncRequestEventName.CreateLocationMessage:
                    break;

                case FuncRequestEventName.CreateCustomMessage:
                    break;

                case FuncRequestEventName.CreateQuoteMessage:
                    break;

                case FuncRequestEventName.CreateAdvancedQuoteMessage:
                    break;

                case FuncRequestEventName.CreateCardMessage:
                    break;

                case FuncRequestEventName.CreateImageMessage:
                    break;

                case FuncRequestEventName.CreateSoundMessage:
                    break;

                case FuncRequestEventName.CreateVideoMessage:
                    break;

                case FuncRequestEventName.CreateFileMessage:
                    break;

                case FuncRequestEventName.CreateMergerMessage:
                    break;

                case FuncRequestEventName.CreateFaceMessage:
                    break;

                case FuncRequestEventName.CreateForwardMessage:
                    break;

                case FuncRequestEventName.ProcessUserCommandGetAll:
                    break;

                case FuncRequestEventName.GetSelfUserInfo:
                    break;

                case FuncRequestEventName.SetSelfInfo:
                    break;

                case FuncRequestEventName.ProcessUserCommandAdd:
                    break;

                case FuncRequestEventName.ProcessUserCommandDelete:
                    break;

                case FuncRequestEventName.ProcessUserCommandUpdate:
                    break;

                case FuncRequestEventName.GetUsersInfo:
                    break;

                case FuncRequestEventName.SubscribeUsersOnlineStatus:
                    break;

                case FuncRequestEventName.UnsubscribeUsersOnlineStatus:
                    break;
            }
        }
    }
}