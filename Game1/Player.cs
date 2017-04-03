using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace Game1
{
    class Player
    {
        Sprite sprite = new Sprite();
        public Player()
        {
        }
        public void Load(ContentManager content)
        {
            sprite.Load(content, "ChuckNorrisStand");
        }
        public void Update(float deltaTime)
        {
            Vector2 position = sprite.position;
            if (Keyboard.GetState().IsKeyDown(Keys.D) == true)
            {
                position.X += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A) == true)
            {
                position.X -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W) == true)
            {
                position.Y -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S) == true)
            {
                position.Y += 1;
            }
            sprite.position = position;
            sprite.Update(deltaTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }

    }
}
