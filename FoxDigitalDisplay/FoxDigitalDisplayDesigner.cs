using System.Windows.Forms.Design;

namespace com.FoxCouncil.FoxDigitalDisplay
{
    class FoxDigitalDisplayDesigner : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                return SelectionRules.Visible | SelectionRules.Moveable | SelectionRules.LeftSizeable | SelectionRules.RightSizeable | SelectionRules.TopSizeable | SelectionRules.BottomSizeable;
            }
        }
    }
}
