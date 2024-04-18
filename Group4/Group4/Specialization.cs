using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
    public enum Specialization
    {
        [Description("construction materials")] constructionmaterials,
        [Description("electronic components")] electroniccomponents,
        [Description("it services")] itservices,
        [Description("logistics provider")] logisticsprovider,
        [Description("packaging")] packaging,
        [Description("printing and publishing")] printingandpublishing,
        [Description("raw materials")] rawmaterials
    }
}
