using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrackerChase
{
    class Projectile : Sprite
    {


        private float _ySpeed;

        public Projectile(int inScreenWidth, int inScreenHeight, Texture2D inSpriteTexture, int inDrawWidth, Vector2 pos, float ySpeed) :
            base(inScreenWidth, inScreenHeight, inSpriteTexture, inDrawWidth, pos.X, pos.Y)
        {

            _ySpeed = ySpeed;
            base.Reset();

        }

        public override void Update(float deltaTime)
        {
            
            yPosition = yPosition + (_ySpeed * deltaTime);
            
            base.Update(deltaTime);
        }

        public bool isOffScreen(){

            bool offScreen = false;

            if (yPosition < 0 || yPosition + rectangle.Height > screenHeight)
            {
                offScreen = true;
            }


            return offScreen;
        }
    }
}
