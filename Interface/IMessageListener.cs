using OpenIM.Proto;

namespace OpenIM.IMSDK.Listener
{
    public interface IMessageListener
    {
        void OnRecvNewMessage(IMMessage message);
        void OnRecvC2CReadReceipt(List<MessageReceipt> msgReceiptList);
        void OnNewRecvMessageRevoked(RevokedTips tips);
        void OnRecvOfflineNewMessage(IMMessage message);
        void OnMessageDeleted(IMMessage message);
        void OnRecvOnlineOnlyMessage(IMMessage message);
        void OnMessageEdited(IMMessage message);
    }
}