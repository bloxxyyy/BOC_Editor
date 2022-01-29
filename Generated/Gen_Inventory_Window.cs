using Koko.RunTimeGui;

namespace Koko.Generated {
	public class Gen_Inventory_Window {
		public static void Init() {
			IParent parent = GUI.Gui;
			IParent previousParent = null;
			previousParent = parent;
			parent = new Panel();
			parent.ChildComponents.Add(new Label());
			parent.ChildComponents.Add(new Button());
			previousParent.ChildComponents.Add((IComponent)parent);
			parent = previousParent;
		}
	}
}
