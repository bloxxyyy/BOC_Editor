using System;

namespace BOC_Editor
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
			using var editor = new Editor();
            editor.Run();
		}
    }
}
