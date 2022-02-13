using Apos.Gui;
using Microsoft.Xna.Framework;

namespace BOC_Editor
{
    internal class OverviewEditorWindow : IWindowState
    {
        public void Draw(GameTime gameTime)
        {

        }

        public void Update(GameTime gameTime)
        {
            //MarginalPanel.Push(5, 5, 0, 5);
            //MarginalPanel.Push(5, 5, 5, 5, Color.Black);
            //MarginalPanel.Push(5, 5, 5, 5, Color.White);
            //Screen();
            //MarginalPanel.Pop();
            //MarginalPanel.Pop();
            //MarginalPanel.Pop();
        }

        private Color black = Color.Black;
        private int font = 22;
        private void Screen()
        {
            //GridPanel.Push(2, null, 1);
            //Label.Put("Last Update: ", black, font);
            //Label.Put("19/09/1999 10:10:10", black, font);

            //Label.Put("Last Item Updated: ", black, font);
            //Label.Put("ShieldHero", black, font);

            //Label.Put("Updated In editor: ", black, font);
            //Label.Put("UnitEditor", black, font);
            //GridPanel.Pop();
        }
    }
}