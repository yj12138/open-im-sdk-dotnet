using OpenIM.Proto;

namespace OpenIM.IMSDK.Listener
{
    public interface IConversationListener
    {
        void OnSyncServerStart(bool reinstalled);
        void OnSyncServerFinish(bool reinstalled);
        void OnSyncServerProgress(int progress);
        void OnSyncServerFailed(bool reinstalled);
        void OnNewConversation(List<IMConversation> conversationList);
        void OnConversationChanged(List<IMConversation> conversationList);
        void OnTotalUnreadMessageCountChanged(int totalUnreadCount);
        void OnConversationUserInputStatusChanged(string conversationId, string userId, Platform[] platforms);
    }
}