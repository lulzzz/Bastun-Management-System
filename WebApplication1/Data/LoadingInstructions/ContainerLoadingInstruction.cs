namespace BMS.Data.LoadingInstructions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BMS.Data.Models;

    public class ContainerLoadingInstruction : LoadingInstruction
    {
        public int HoldOneLeftContainerCount { get; set; }

        public int HoldOneRightContainerCount { get; set; }

        public int HoldTwoLeftContainerCount { get; set; }

        public int HoldTwoRightContainerCount { get; set; }


        public int HoldThreeLeftContainerCount { get; set; }

        public int HoldThreeRightContainerCount { get; set; }

        public int HoldFourLeftContainerCount { get; set; }

        public int HoldFourRightContainerCount { get; set; }
    }
}
