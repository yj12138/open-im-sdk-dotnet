using OpenIM.IMSDK.Native;
using OpenIM.IMSDK.Listener;
using OpenIM.Proto;
using OpenIM.IMSDK.Util;

namespace OpenIM.IMSDK
{
    public interface IMsgSendCallBack
    {
        public void OnError(int code, string errMsg);
        public void OnSuccess(IMMessage msg);
        public void OnProgress(long progress);
    }

    public partial class IMSDK
    {
        public delegate void OnBase<T>(T data, int errCode, string errMsg);

        private static Dictionary<ulong, Delegate> callBackDic = new Dictionary<ulong, Delegate>();
        private static Dictionary<ulong, IMsgSendCallBack> msgSendCallBackDic = new Dictionary<ulong, IMsgSendCallBack>();
        private static IConnListener connListener;
        private static IConversationListener conversationListener;
        private static IFriendShipListener friendShipListener;
        private static IGroupListener groupListener;
        private static IMessageListener messageListener;
        private static IUserListener userListener;
        private static ICustomBusinessListener customBusinessListener;


        #region  set listener
        public static void SetConnListener(IConnListener l)
        {
            connListener = l;
        }
        public static void SetConversationListener(IConversationListener l)
        {
            conversationListener = l;
        }
        public static void SetFriendShipListener(IFriendShipListener l)
        {
            friendShipListener = l;
        }
        public static void SetGroupListener(IGroupListener l)
        {
            groupListener = l;
        }
        public static void SetMessageListener(IMessageListener l)
        {
            messageListener = l;
        }
        public static void SetUserListener(IUserListener l)
        {
            userListener = l;
        }
        public static void SetCustomBusinessListener(ICustomBusinessListener l)
        {
            customBusinessListener = l;
        }
        #endregion


        static void Interal_Init()
        {
            NativeSDK.Init(EventHandler);
        }

        public static void Polling()
        {
            if (events.Count > 0)
            {
                FfiResult result;
                while (events.TryDequeue(out result))
                {
                    try
                    {
                        DispatorMsg(result);
                    }
                    catch (Exception e)
                    {
                        Utils.Log(e.ToString());
                    }
                }
            }
        }


        static ulong handleId = 0;
        static ulong GetHandleId()
        {
            handleId++;
            return handleId;
        }

        #region init_login
        public static void Versation(OnBase<string> cb)
        {
            var handleId = GetHandleId();
            NativeSDK.CallAPI(handleId, FuncRequestEventName.Version, new VersionReq { });
        }
        public static void InitSDK(IMConfig config, OnBase<bool> cb)
        {
            Interal_Init();

            var handleId = GetHandleId();
            NativeSDK.CallAPI(handleId, FuncRequestEventName.InitSdk, new InitSDKReq
            {
                Config = config
            });
        }
        public static void Login(string uid, string token, OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.Login, new LoginReq
            {
                UserID = uid,
                Token = token,
            });
        }
        public static void Logout(OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.Logout, new LogoutReq
            {

            });
        }
        public static void SetAppBackGroundStatus(OnBase<bool> cb, bool isBackground)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetAppBackgroundStatus, new SetAppBackgroundStatusReq
            {
                IsBackground = isBackground
            });
        }
        public static void NetworkStatusChanged(OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.NetworkStatusChanged, new NetworkStatusChangedReq { });
        }
        public static void GetLoginStatus(OnBase<LoginStatus> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetLoginStatus, new GetLoginStatusReq { });
        }
        #endregion

        #region conversation_msg
        public static void CreateTextMessage(OnBase<IMMessage> cb, string text)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateTextMessage, new CreateTextMessageReq
            {
                Text = text
            });
        }
        public static void CreateAdvancedTextMessage(OnBase<IMMessage> cb, string text, MessageEntity[] messageEntityList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new CreateAdvancedTextMessageReq
            {
                Text = text,
            };
            req.MessageEntities.Add(messageEntityList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateAdvancedTextMessage, req);
        }
        public static void CreateTextAtMessage(OnBase<IMMessage> cb, string text, string[] atUserList, AtInfo[] atUsersInfo, IMMessage message)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new CreateTextAtMessageReq
            {
                Text = text,
                QuoteMessage = message
            };
            req.UserIDList.Add(atUserList);
            req.UsersInfo.Add(atUsersInfo);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateTextAtMessage, req);
        }
        public static void CreateLocationMessage(OnBase<IMMessage> cb, string description, double longitude, double latitude)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateLocationMessage, new CreateLocationMessageReq
            {
                Description = description,
                Longitude = longitude,
                Latitude = latitude
            });
        }
        public static void CreateCustomMessage(OnBase<IMMessage> cb, string data, string extension, string description)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateCustomMessage, new CreateCustomMessageReq
            {
                Data = data,
                Extension = extension,
                Description = description
            });
        }
        public static void CreateQuoteMessage(OnBase<IMMessage> cb, string text, IMMessage message)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateQuoteMessage, new CreateQuoteMessageReq
            {
                Text = text,
                QuoteMessage = message
            });
        }
        public static void CreateAdvancedQuoteMessage(OnBase<IMMessage> cb, string text, IMMessage message, MessageEntity[] messageEntityList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new CreateAdvancedQuoteMessageReq
            {
                Text = text,
                QuoteMessage = message,
            };
            req.MessageEntities.Add(messageEntityList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateAdvancedQuoteMessage, req);
        }
        public static void CreateCardMessage(OnBase<IMMessage> cb, CardElem card)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateCardMessage, new CreateCardMessageReq
            {
                Card = card
            });
        }
        public static void CreateImageMessage(OnBase<IMMessage> cb, string imagePath)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateImageMessage, new CreateImageMessageReq
            {
                ImageSourcePath = imagePath
            });
        }
        public static void CreateSoundMessage(OnBase<IMMessage> cb, string soundPath, long duration)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateSoundMessage, new CreateSoundMessageReq
            {
                SoundPath = soundPath,
                Duration = duration
            });
        }
        public static void CreateVideoMessage(OnBase<IMMessage> cb, string videoPath, string videoType, long duration, string snapshotPath)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateVideoMessage, new CreateVideoMessageReq
            {
                VideoSourcePath = videoPath,
                VideoType = videoType,
                Duration = duration,
                SnapshotSourcePath = snapshotPath
            });
        }
        public static void CreateFileMessage(OnBase<IMMessage> cb, string filePath, string fileName)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateFileMessage, new CreateFileMessageReq
            {
                FileSourcePath = filePath,
                FileName = fileName
            });
        }
        public static void CreateMergerMessage(OnBase<IMMessage> cb, IMMessage[] messageList, string title, string[] summaryList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new CreateMergerMessageReq
            {
                Title = title,
            };
            req.Messages.Add(messageList);
            req.Summaries.Add(summaryList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateMergerMessage, req);
        }
        public static void CreateFaceMessage(OnBase<IMMessage> cb, int index, string data)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateFaceMessage, new CreateFaceMessageReq
            {
                Index = index,
                Data = data,
            });
        }
        public static void CreateForwardMessage(OnBase<IMMessage> cb, IMMessage message)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateForwardMessage, new CreateForwardMessageReq
            {
                Message = message
            });
        }
        public static void GetAllConversationList(OnBase<List<IMConversation>> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetAllConversationList, new GetAllConversationListReq
            {

            });
        }
        public static void GetConversationListSplit(OnBase<List<IMConversation>> cb, int offset, int count)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetConversationListSplit, new GetConversationListSplitReq
            {
                Offset = offset,
                Count = count,
            });
        }
        public static void GetOneConversation(OnBase<IMConversation> cb, SessionType sessionType, string sourceId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetOneConversation, new GetOneConversationReq
            {
                SessionType = (int)sessionType,
                SourceID = sourceId,
            });
        }
        public static void GetMultipleConversation(OnBase<List<IMConversation>> cb, string[] conversationIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetMultipleConversationReq();
            req.ConversationIDList.Add(conversationIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetMultipleConversation, req);
        }
        public static void HideConversation(OnBase<bool> cb, string conversationId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.HideConversation, new HideConversationReq
            {
                ConversationID = conversationId,
            });
        }
        public static void HideAllConversations(OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.HideAllConversations, new HideAllConversationsReq { });
        }
        public static void SetConversation(OnBase<bool> cb, SetConversationReq req)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetConversation, req);
        }
        public static void SetConversationDraft(OnBase<bool> cb, string conversationId, string draftText)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetConversationDraft, new SetConversationDraftReq
            {
                ConversationID = conversationId,
                DraftText = draftText,
            });
        }
        public static void GetTotalUnreadMsgCount(OnBase<int> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetTotalUnreadMsgCount, new GetTotalUnreadMsgCountReq { });
        }
        public static void GetAtAllTag(OnBase<string> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetAtAllTag, new GetAtAllTagReq { });
        }
        public static void GetConversationIdBySessionType(OnBase<string> cb, string sourceId, SessionType sessionType)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetConversationIdbySessionType, new GetConversationIDBySessionTypeReq
            {
                SourceID = sourceId,
                SessionType = (int)sessionType,
            });
        }
        public static void SendMessage(IMsgSendCallBack cb, IMMessage message, string recvId, string groupId, bool isOnlineOnly)
        {
            var handleId = GetHandleId();
            msgSendCallBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SendMessage, new SendMessageReq
            {
                Message = message,
                RecvID = recvId,
                GroupID = groupId,
                IsOnlineOnly = isOnlineOnly,
            });
        }
        public static void FindMessageList(OnBase<FindMessageListResp> cb, ConversationArgs[] findMessageOptions)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new FindMessageListReq();
            req.ConversationsArgs.Add(findMessageOptions);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.FindMessageList, req);
        }
        public static void GetAdvancedHistoryMessageList(OnBase<GetAdvancedHistoryMessageListCallback> cb, GetAdvancedHistoryMessageListParams getMessageOptions)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetAdvancedHistoryMessageList, new GetAdvancedHistoryMessageListReq
            {
                ConversationID = getMessageOptions.ConversationID,
                GetAdvancedHistoryMessageListParams = getMessageOptions
            });
        }
        public static void GetAdvancedHistoryMessageListReverse(OnBase<GetAdvancedHistoryMessageListReverseResp> cb, GetAdvancedHistoryMessageListParams getMessageOptions)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetAdvancedHistoryMessageListReverse, new GetAdvancedHistoryMessageListReverseReq
            {
                ConversationID = getMessageOptions.ConversationID,
                GetAdvancedHistoryMessageListParams = getMessageOptions
            });
        }
        public static void RevokeMessage(OnBase<bool> cb, string conversationId, string clientMsgId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.RevokeMessage, new RevokeMessageReq
            {
                ConversationID = conversationId,
                ClientMsgID = clientMsgId
            });
        }
        public static void TypingStatusUpdate(OnBase<bool> cb, string recvId, string msgTip)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.TypingStatusUpdate, new TypingStatusUpdateReq
            {
                RecvID = recvId,
                MsgTip = msgTip
            });
        }
        public static void MarkConversationMessageAsRead(OnBase<bool> cb, string conversationId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.MarkConversationMessageAsRead, new MarkConversationMessageAsReadReq
            {
                ConversationID = conversationId
            });
        }
        public static void MarkAllConversationMessageAsRead(OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.MarkAllConversationMessageAsRead, new MarkConversationMessageAsReadReq { });
        }
        public static void DeleteMessageFromLocalStorage(OnBase<bool> cb, string conversationId, string clientMsgId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteMessageFromLocalStorage, new DeleteMessageFromLocalStorageReq
            {
                ConversationID = conversationId,
                ClientMsgID = clientMsgId
            });
        }
        public static void DeleteMessage(OnBase<bool> cb, string conversationId, string clientMsgId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteMessage, new DeleteMessageReq
            {
                ConversationID = conversationId,
                ClientMsgID = clientMsgId
            });
        }

        public static void DeleteAllMsgFromLocalAndServer(OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteAllMsgFromLocalAndServer, new DeleteAllMsgFromLocalAndServerReq { });
        }
        public static void DeleteAllMessageFromLocalStorage(OnBase<bool> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteAllMessageFromLocalStorage, new DeleteAllMessageFromLocalStorageReq { });
        }
        public static void ClearConversationAndDeleteAllMsg(OnBase<bool> cb, string conversationId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.ClearConversationAndDeleteAllMsg, new ClearConversationAndDeleteAllMsgReq
            {
                ConversationID = conversationId
            });
        }
        public static void DeleteConversationAndDeleteAllMsg(OnBase<bool> cb, string conversationId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteConversationAndDeleteAllMsg, new DeleteConversationAndDeleteAllMsgReq
            {
                ConversationID = conversationId
            });
        }
        public static void InsertSingleMessageToLocalStorage(OnBase<IMMessage> cb, IMMessage message, string recvId, string sendId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.InsertSingleMessageToLocalStorage, new InsertSingleMessageToLocalStorageReq
            {
                Msg = message,
                RecvID = recvId,
                SendID = sendId
            });
        }
        public static void InsertGroupMessageToLocalStorage(OnBase<IMMessage> cb, IMMessage message, string groupId, string sendId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.InsertGroupMessageToLocalStorage, new InsertGroupMessageToLocalStorageReq
            {
                Msg = message,
                GroupID = groupId,
                SendID = sendId
            });
        }
        public static void SearchLocalMessages(OnBase<SearchLocalMessagesCallback> cb, SearchLocalMessagesParams searchParam)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SearchLocalMessages, new SearchLocalMessagesReq
            {
                SearchParam = searchParam
            });
        }
        public static void SetMessageLocalEx(OnBase<bool> cb, string conversationId, string clientMsgId, string localEx)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetMessageLocalEx, new SetMessageLocalExReq
            {
                ConversationID = conversationId,
                ClientMsgID = clientMsgId,
                LocalEx = localEx
            });
        }
        #endregion

        #region user
        public static void GetUsersInfo(OnBase<List<IMUser>> cb, string[] userIds)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetUsersInfoReq();
            req.UserIDs.Add(userIds);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetUsersInfo, req);
        }
        public static void SetSelfInfo(OnBase<bool> cb, SetSelfInfoReq req)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetSelfInfo, req);
        }
        public static void GetSelfUserInfo(OnBase<IMUser> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetSelfUserInfo, new GetSelfUserInfoReq());
        }
        public static void SubscribeUsersOnlineStatus(OnBase<List<UserOnlinePlatform>> cb, string[] userIds)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new SubscribeUsersOnlineStatusReq();
            req.UserIDs.Add(userIds);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SubscribeUsersOnlineStatus, req);
        }
        public static void UnsubscribeUsersOnlineStatus(OnBase<bool> cb, string[] userIds)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new UnsubscribeUsersOnlineStatusReq();
            req.UserIDs.Add(userIds);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.UnsubscribeUsersOnlineStatus, req);
        }
        // public static void GetSubscribeUsersStatus(OnBase<List<UserOnlinePlatform>> cb)
        // {
        // }
        // public static void GetUserStatus(OnBase<List<OnlineStatus>> cb, string[] userIds)
        // {
        // }
        #endregion

        #region friend
        public static void GetSpecifiedFriends(OnBase<List<IMFriend>> cb, string[] userIdList, bool filterBlack)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetSpecifiedFriendsReq
            {
                FilterBlack = filterBlack
            };
            req.FriendUserIDs.Add(userIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetSpecifiedFriends, req);
        }
        public static void GetFriends(OnBase<List<IMFriend>> cb, bool filterBlack)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetFriends, new GetFriendsReq
            {
                FilterBlack = filterBlack
            });
        }
        public static void GetFriendsPage(OnBase<List<IMFriend>> cb, int pageNumber, int showNumber, bool filterBlack)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetFriendsPage, new GetFriendsPageReq
            {
                FilterBlack = filterBlack,
                Pagination = new RequestPagination
                {
                    PageNumber = pageNumber,
                    ShowNumber = showNumber,
                }
            });
        }

        public static void SearchFriends(OnBase<List<SearchFriendsInfo>> cb, string keyWord, bool searchUserId, bool searchNickName, bool searchRemark)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SearchFriends, new SearchFriendsReq
            {
                Keyword = keyWord,
                SearchUserID = searchUserId,
                SearchNickname = searchNickName,
                SearchRemark = searchRemark
            });
        }
        public static void UpdateFriends(OnBase<bool> cb, string userId, bool pinned, string remark, string ex)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.UpdateFriends, new UpdatesFriendsReq
            {
                UserID = userId,
                Pinned = pinned,
                Remark = remark,
                Ex = ex,
            });
        }
        public static void CheckFriend(OnBase<List<CheckFriendInfo>> cb, string[] userIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new CheckFriendReq { };
            req.FriendUserIDs.Add(userIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CheckFriend, req);
        }
        public static void AddFriend(OnBase<bool> cb, string userId, string reqMsg, string ex)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.AddFriend, new AddFriendReq
            {
                UserID = userId,
                ReqMsg = reqMsg,
                Ex = ex,
            });
        }
        public static void DeleteFriend(OnBase<bool> cb, string friendUserId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteFriend, new DeleteFriendReq
            {
                UserID = friendUserId
            });
        }
        public static void GetFriendsRequest(OnBase<List<IMFriendApplication>> cb, bool send)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetFriendRequests, new GetFriendRequestsReq
            {
                Send = send
            });
        }

        public static void HandleFriendRequest(OnBase<bool> cb, string userId, string handleMsg, ApprovalStatus status)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.HandlerFriendRequest, new HandleFriendRequestReq
            {
                UserID = userId,
                HandleMsg = handleMsg,
                Status = status,
            });
        }
        public static void AddBlack(OnBase<bool> cb, string userId, string ex)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.AddBlack, new AddBlackReq
            {
                UserID = userId,
                Ex = ex
            });
        }
        public static void GetBlacks(OnBase<List<IMBlack>> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetBlacks, new GetBlacksReq { });
        }
        public static void DeleteBlack(OnBase<bool> cb, string removeUserId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DeleteBlack, new DeleteBlackReq
            {
                UserID = removeUserId
            });
        }
        #endregion

        #region group
        public static void CreateGroup(OnBase<IMGroup> cb, IMGroup group, string[] memeberUserIds, string[] adminUserIds)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new CreateGroupReq();
            req.GroupInfo = group;
            req.MemberUserIDs.Add(adminUserIds);
            req.AdminUserIDs.Add(memeberUserIds);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.CreateGroup, req);
        }
        public static void JoinGroup(OnBase<bool> cb, string groupId, string reqMsg, GroupJoinSource joinSource, string ex)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.JoinGroup, new JoinGroupReq
            {
                GroupID = groupId,
                ReqMessage = reqMsg,
                JoinSource = joinSource,
                Ex = ex
            });
        }
        public static void QuitGroup(OnBase<bool> cb, string groupId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.QuitGroup, new QuitGroupReq
            {
                GroupID = groupId
            });
        }

        public static void DismissGroup(OnBase<bool> cb, string groupId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.DismissGroup, new DismissGroupReq
            {
                GroupID = groupId
            });
        }
        public static void ChangeGroupMute(OnBase<bool> cb, string groupId, bool isMute)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.ChangeGroupMute, new ChangeGroupMuteReq
            {
                GroupID = groupId,
                Mute = isMute,
            });
        }
        public static void ChangeGroupMemberMute(OnBase<bool> cb, string groupId, string userId, uint mutedSeconds)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.ChangeGroupMemberMute, new ChangeGroupMemberMuteReq
            {
                GroupID = userId,
                UserID = userId,
                MutedSeconds = mutedSeconds
            });
        }
        public static void SetGroupMemberInfo(OnBase<bool> cb, string groupId, string userId, string nickName, string faceUrl, int roleLevel, string ex)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetGroupMemberInfo, new SetGroupMemberInfoReq
            {
                GroupID = groupId,
                UserID = userId,
                Nickname = nickName,
                RoleLevel = roleLevel,
                Ex = ex
            });
        }
        public static void GetJoinedGroups(OnBase<List<IMGroup>> cb)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetJoinedGroups, new GetJoinedGroupsReq { });
        }
        public static void GetJoinedGroupsPage(OnBase<List<IMGroup>> cb, int pageNumber, int showNumber)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetJoinedGroupsPage, new GetJoinedGroupsPageReq
            {
                Pagination = new RequestPagination
                {
                    PageNumber = pageNumber,
                    ShowNumber = showNumber
                }
            });
        }
        public static void GetSpecifiedGroupsInfo(OnBase<List<IMGroup>> cb, string[] groupIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetSpecifiedGroupsInfoReq();
            req.GroupIDs.Add(groupIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetSpecifiedGroupsInfo, req);
        }
        public static void SearchGroups(OnBase<List<IMGroup>> cb, string keyWord, bool searchGroupId, bool searchGroupName)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SearchGroups, new SearchGroupsReq
            {
                Keyword = keyWord,
                SearchGroupID = searchGroupId,
                SearchGroupName = searchGroupName
            });
        }
        public static void SetGroupInfo(OnBase<bool> cb, SetGroupInfoReq req)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SetGroupInfo, req);
        }
        public static void GetGroupMembers(OnBase<List<IMGroupMember>> cb, string groupId, GroupFilter filter, int pageNumber, int showNumber)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetGroupMembers, new GetGroupMembersReq
            {
                GroupID = groupId,
                Filter = filter,
                Pagination = new RequestPagination
                {
                    PageNumber = pageNumber,
                    ShowNumber = showNumber
                }
            });
        }
        public static void GetGroupMemberOwnerAndAdmin(OnBase<List<IMGroupMember>> cb, string groupId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetGroupMemberOwnerAndAdmin, new GetGroupMemberOwnerAndAdminReq
            {
                GroupID = groupId
            });
        }
        public static void GetGroupMembersByJoinTimeFilter(OnBase<List<IMGroupMember>> cb, string groupId, long joinTimeBegin, long joinTimeEnd, int pageNumber, int showNumber)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetGroupMembersByJoinTimeFilterReq
            {
                GroupID = groupId,
                JoinTimeBegin = joinTimeBegin,
                JoinTimeEnd = joinTimeEnd,
                Pagination = new RequestPagination
                {
                    PageNumber = pageNumber,
                    ShowNumber = showNumber
                }
            };
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetGroupMembersByJoinTimeFilter, req);
        }
        public static void GetSpecifiedGroupMembersInfo(OnBase<List<IMGroupMember>> cb, string groupId, string[] userIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetSpecifiedGroupMembersInfoReq
            {
                GroupID = groupId
            };
            req.UserIDs.Add(userIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetSpecifiedGroupMembersInfo, req);
        }
        public static void KickGroupMember(OnBase<bool> cb, string groupId, string reason, string[] userIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new KickGroupMemberReq
            {
                GroupID = groupId,
                Reason = reason
            };
            req.KickedUserIDs.Add(userIdList);
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.KickGroupMember, req);
        }
        public static void TransferGroupOwner(OnBase<bool> cb, string groupId, string ownerUserId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.TransferGroupOwner, new TransferGroupOwnerReq
            {
                GroupID = groupId,
                OwnerUserID = ownerUserId
            });
        }
        public static void InviteUserToGroup(OnBase<bool> cb, string groupId, string reason, string[] userIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new InviteUserToGroupReq
            {
                GroupID = groupId,
                Reason = reason,
            };
            req.UserIDs.Add(userIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.InviteUserToGroup, req);
        }
        public static void GetGroupRequest(OnBase<List<IMGroupApplication>> cb, bool send)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetGroupRequest, new GetGroupRequestReq
            {
                Send = send
            });
        }
        public static void HandlerGroupRequest(OnBase<bool> cb, string groupId, string fromUserId, string handleMsg, ApprovalStatus status)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.HandlerGroupRequest, new HandlerGroupRequestReq
            {
                GroupID = groupId,
                FromUserID = fromUserId,
                HandledMsg = handleMsg,
                Status = status,
            });
        }
        public static void AcceptGroupApplication(OnBase<bool> cb, string groupId, string fromUserId, string handleMsg)
        {
        }

        public static void RefuseGroupApplication(OnBase<bool> cb, string groupId, string fromUserId, string handleMsg)
        {
        }
        public static void SearchGroupMembers(OnBase<List<IMGroupMember>> cb, string groupId, string keyWord, bool searchUserId, bool searchNickName, int pageNumber, int showNumber)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.SearchGroupMembers, new SearchGroupMembersReq
            {
                GroupID = groupId,
                Keyword = keyWord,
                SearchUserID = searchUserId,
                SearchMemberNickname = searchNickName,
                Pagination = new RequestPagination
                {
                    PageNumber = pageNumber,
                    ShowNumber = showNumber
                }
            });
        }
        public static void IsJoinGroup(OnBase<bool> cb, string groupId)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            NativeSDK.CallAPI(handleId, FuncRequestEventName.IsJoinGroup, new IsJoinGroupReq
            {
                GroupID = groupId
            });
        }
        public static void GetUsersInGroup(OnBase<string[]> cb, string groupId, string[] userIdList)
        {
            var handleId = GetHandleId();
            callBackDic[handleId] = cb;
            var req = new GetUsersInGroupReq
            {
                GroupID = groupId,
            };
            req.UserIDs.Add(userIdList);
            NativeSDK.CallAPI(handleId, FuncRequestEventName.GetUsersInGroup, req);
        }
        #endregion
    }
}