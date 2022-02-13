using Koko.Generated;
using Koko.RunTimeGui.Gui.Initable_Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
			if (Directory.Exists(generatedFilesLocation)) {
				ProcessDirectory(generatedFilesLocation);
			}
		}

		/// <summary>
		/// To check for all xml files in directory plus sub directories.
		/// </summary>
		/// <param name="targetDirectory"></param>
		private static void ProcessDirectory(string targetDirectory) {
			foreach (string file in Directory.EnumerateFiles(targetDirectory, "*.cs", SearchOption.AllDirectories)) {
				var name = Path.GetFileNameWithoutExtension(file);
				name = name.Replace(" ", "_");
				var type = Type.GetType("Koko.Generated."+name);
				var instance = Activator.CreateInstance(type) as IInitable;
				instance.Init();
			}
		}
	}
}
