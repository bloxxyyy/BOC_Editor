using Koko.RunTimeGui;
using Koko.RunTimeGui.Gui.Initable_Components;

namespace Koko.Generated { 
public class Gen_Menu : IInitable { 
public void Init() {
IParent parent = GUI.Gui;
 IParent previousParent = null;
previousParent = parent;
parent = new Panel();
parent.ChildComponents.Add(new Label());
parent.ChildComponents.Add(new Button());
parent.ChildComponents.Add(new Button());
previousParent.ChildComponents.Add((IComponent)parent);
parent = previousParent;}
}
}
