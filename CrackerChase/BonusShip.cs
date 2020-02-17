using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrackerChase
{
    class BonusShip : Game1
    {
        private float speed = 0.0f;
        private float position = 0.0f;
        private float radius = 0.0f; // For Collision //

        private static bool isRight;

        private Texture2D Bonus_Ship_Sprite;
        private SpriteBatch sb;

        // Initialize the Ship //
        private void Initialize(SpriteBatch spriteBatch)
        {
            isRight = true;

            // Initialize Sprite Batch //
            sb = spriteBatch;

            // Load Content //
            LoadContent();
        }

        // Load the Ship Sprite //
        private void LoadContent()
        {
            Bonus_Ship_Sprite = Content.Load<Texture2D>("bonus_ship.jpg");
        }

        private void Move()
        {
            if (isRight)
            {
                // Move the Ship in the right direction //


                isRight = false;
            }
            else
            {
                // Move the Ship in the left dire
            }

        }

        private void DisplayShip()
        {
            sb.Begin();

            sb.Draw(Bonus_Ship_Sprite, new Vector2(0.0f, 0.0f), Color.White);

            sb.End();
        }

        // Check if anything is colliding with the ship //
        private void CheckCollision(Vector2 pos_two) // Replace Vector with Projectile //
        {
            // pos_two = the position of the other object //



        }


    }
}
