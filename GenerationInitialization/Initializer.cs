using Koko.RunTimeGui.Gui.Initable_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BOC_Editor.GenerationInitialization {
	public class Initializer {

		/// <summary>
		///  The file location where your generated files are stored.
		/// </summary>
		public static string generatedFilesLocation = Environment.CurrentDirectory + "\\..\\..\\..\\Generated";

		public void ButtonData() {

			var list = new Dictionary<string, Func<string>> {
				{ "funButton1", () => { var i = "test"; return i; } },
				{ "ButtonName2", () => { return "2"; } }
			};

			// TODO IMPLEMENT
			// Tag moment
		}

		public static void Init() {
			Assembly.GetExecutingAssembly().GetTypes()
				.Where(t => t.Namespace == "Koko.Generated").ToList()
				.ForEach(a => (Activator.CreateInstance(a) as IInitable).Init());
		}
	}
}
