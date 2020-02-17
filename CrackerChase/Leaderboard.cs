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
        private SpriteFont leaderboard_header;
        private SpriteBatch sb;

        private List<int> scores;

        // Load the SpriteFont Graphics ready for rendering //
        public void LoadContent(GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
        {
            //sb = spriteBatch;
            //graphics = new GraphicsDeviceManager(this);
            //Content.RootDirectory = "Content";
            leaderboard_header = Content.Load<SpriteFont>("MessageFont"); //Leaderboard_Title
        }

        // Load the scores into the leaderboard //
        public void LoadScores(List<int> score_in)
        {
            // Transfer the scores from the game to the leaderboard //
            for (int i = 0; i < score_in.Count; i++)
            {
                scores.Add(score_in[i]);
            }
        }

        // Draw the SpriteFont to the screen //
        public void DrawContent()
        {
            sb.Begin();

            sb.DrawString(leaderboard_header, "Leaderboard", new Vector2(0, 200), Color.White);

            sb.End();
        }

    }
}
