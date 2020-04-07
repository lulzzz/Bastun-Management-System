namespace BMS.Services.ParserUtility
{
    using System;
    public static class MessageValidation
    {

        public static bool IsMovementMessageTypeValid(string messageType)
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

        public static bool IsFlightInfoNotNullOrEmpty(string flightNumber, string registration, string date, string station)
        {
            return string.IsNullOrWhiteSpace(flightNumber) || string.IsNullOrWhiteSpace(registration) || string.IsNullOrWhiteSpace(date)
                || string.IsNullOrWhiteSpace(station);
        }
    }
}
