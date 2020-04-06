namespace BMS.Services.ParserUtility
{
    using System;
    public static class MessageTypeValidation
    {

        public static bool IsArrivalMovementMessageTypeValid(string messageType)
        {
            return messageType == "MVT";
        } 

        public static bool IsLoadDistributionMessageTypeValid(string messageType)
        {
            return messageType == "LDM";
        }

        public static bool IsCPMMessageTypeValid(string messageType)
        {
            return messageType == "CPM";
        }

        public static bool IsUCMMessageTypeValid(string messageType)
        {
            return messageType == "UCM";
        }
    }
}
