using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {   
        public new static void UpdatePosition(string key, out int deltaX, out int deltaY)
        {
            deltaX = 0;
            deltaY = 0;
            switch (key)
            {
                case "UpArrow":
                    deltaY--;
                    break;
                case "DownArrow":
                    deltaY++;
                    break;
                case "RightArrow":
                    deltaX++;
                    break;
                case "LeftArrow":
                    deltaX--;
                    break;
                default:
                    break;

            }
        }
        public new static char UpdateCursor(string key)
        {
            switch (key)
            {
                case "UpArrow":
                    return '^';
                case "DownArrow":
                    return 'v';
                case "LeftArrow":
                    return '<';
                case "RightArrow":
                    return '>';
                default:
                    return '>';
            }
        }
        public new static int KeepInBounds(int coord, int max)
        {
            if(coord<max && coord>=0)
            {
                return coord;
            }
            else if(coord>=max)
            {
                return 0;
            }
            else if(coord<0)
            {
                return max-1;
            }
            else
            {
                return 0;
            }
        }
        public new static bool DidScore(int playerX, int playerY, int fruitX, int fruitY)
        {
            if(fruitX==playerX && fruitY==playerY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

  }
}