// Sprite Font used for displaying text //

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackerChase
{
    class Leaderboard : Game1
    {
        SpriteFont leaderboard_header;
        SpriteBatch sb;

        public void LoadContent(GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
        {
            sb = spriteBatch;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            leaderboard_header = Content.Load<SpriteFont>("MessageFont"); //Leaderboard_Title
        }

        public void DrawContent()
        {
            sb.Begin();

            sb.DrawString(leaderboard_header, "Leaderboard", new Vector2(0, 200), Color.White);

            sb.End();
        }

    }
}
