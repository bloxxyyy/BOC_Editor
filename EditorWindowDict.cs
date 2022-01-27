using System;
using System.Collections.Generic;
using System.Text;

namespace BOC_Editor {
	internal static class EditorWindowDict {

		public enum EWindowType {
			Overview, UnitEditor
		}

		public static IWindowState GetState(EWindowType type) {
			EditorDict.TryGetValue(type, out var state);
			return state;
		}

		private static Dictionary<EWindowType, IWindowState> EditorDict = new Dictionary<EWindowType, IWindowState>() {
			{EWindowType.Overview, new OverviewEditorWindow()},
			{EWindowType.UnitEditor, new UnitEditorWindow()},
		};
	}
}