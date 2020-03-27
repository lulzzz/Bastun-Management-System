namespace BMS.GlobalData.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class MessagesValidation
    {
        public const string ArrMVTMessageValidation = @"(?<msgType>[A-Z]{3})[\r\n]?(?<fltNmb>[A-Z]{1,3}[0-9]{1,4})\/(?<date>[0-9]{2})\.(?<reg>[A-Z]{1,5})\.(?<dest>[A-Z]{3})[\r\n]?(?<arrData>[AA]{2}(?<TD>[0-9]{4})\/(?<ONBLCK>[0-9]{4}))[\r\n]?(?<si>[SI]{2}(?<SICNTNT>[\w\s]+))";

        public const string DepMVTMessageValidation = @"^(?<msg>[^\s]+)[\r\n]?(?<fltNm>[A-Z]{1,3}[0-9]{1,4})\/(?<date>[0-9]{2})\.(?<reg>[A-Z]{5})\.(?<dest>[A-Z]{3})[\r\n]?(?<departure>[AD]{2}[0-9]{4}\/[0-9]{4})(?<eta>\s[ETA]{3}\s[0-9]{4}\s[A-Z]{3})[\r\n]?(?<paxOb>[PAX]{3}[\d]{3})[\r\n]?(?<si>[SI]{2}\:[\w\s]+)$";

        public const string LDMMessageValidation = @"(?<msgType>[LDM]{3})[\r\n]?(?<arln>[A-Z]{1,3}[0-9]{1,4})\/(?<date>[0-9]{2})\.(?<acReg>[A-Z]{1,5})\.(?<version>[YJ]{1}[0-9]{3})\.(?<acCrew>[0-9]\/[0-9])[\r\n]?(?<station>\-[A-Z]{3})\.(?<M>[0-9]{1,3})\/(?<F>[0-9]{1,3})\/(?<C>[0-9]{1,3})\/(?<i>[0-9]{1,3})\.(?<totalWeightInCPT>[T]\.[0-9]{1,5}\.[0-9\/\.]+)[\r\n]?(?<pax>[PAX]{3}\/[0-9]{1,3})\.(?<bgs>[B]{1}\/[0-9]{1,3}\/)\.(?<cargo>[C]{1}\/[\w\s]+)";

        public const string CPMFlightInfoValidation = @"?<msg>[CPM]{3})[\r\n]?(?<arln>[A-Z]{1,4})(?<fltNmb>[0-9]{1,5})\/(?<date>[0-9]{2})\.(?<reg>[A-Z]{1,5})\.(?<version>[YJ]{1}[0-9]{3})[\r\n]?";

        public const string CPMContainerInfoValidation = @"(?<containers>[\-][0-9]{2}[LR]{1}\/[A-Z]{3}[0-9]{4}[\r\n]?)";

        public const string CPMSupplementaryInformationValidation = @"(?<SI>[SI]{2}[A-Z\s]+)";
    }
}
    