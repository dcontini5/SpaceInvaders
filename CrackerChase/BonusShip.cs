using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackerChase
{
    class BonusShip
    {
        private float speed;
        private float position;
        private float radius;

        private static bool isRight;

        // Initialize the Ship //
        private void Initialize()
        {
            isRight = true;
            // Load Content //

        }

        // Load the Ship Sprite //
        private void LoadContent()
        {

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

            }

        }


    }
}
