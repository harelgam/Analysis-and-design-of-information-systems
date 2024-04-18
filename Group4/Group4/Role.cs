using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    public enum Role
    {
        [Description("CEO")] CEO,
        [Description("CIO")] CIO,
        [Description("Data Analyst")] DataAnalyst,
        [Description("Procuement Manager")] ProcuementManager,
        [Description("Whearhouse Manager")] WhearhouseManager,
        [Description("Finance Manager")] FinanceManager,
        [Description("Production Manager")] ProductionManager,
        [Description("StoreKeeper")] StoreKeeper,
        [Description("Production Line")] ProductionLine,
        [Description("Graphic Designer")] GraphicDesigner,
        [Description("IT")] IT

    }

}
