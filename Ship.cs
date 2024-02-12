using spaceshooter.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceshooter
{
    public class Ship : Sprite
    {
        private int bulletSpawnX;

        public Ship(int centerX, int centerY, char displayPixel) : base()
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.displayPixel = displayPixel;
            displayPoints = new List<Point>();
            InitializeShape();
        }

        public override void InitializeShape()
        {
            displayPoints.Clear();
            displayPoints.Add(new Point(centerX, centerY, displayPixel));
            displayPoints.Add(new Point(centerX - 1, centerY, displayPixel));
            displayPoints.Add(new Point(centerX + 1, centerY, displayPixel));
            displayPoints.Add(new Point(centerX, centerY - 1, displayPixel));
        }

        public int BulletSpawnX
        {
            get { return bulletSpawnX; }
            set { bulletSpawnX = value; }
        }

        public override void moveLeft() {
            this.centerX -= 1;
            this.InitializeShape();
        }

        public override void moveRight()
        {
            this.centerX += 1;
            this.InitializeShape();
        }

        public override void moveUp()
        {
            this.centerY -= 1;
            this.InitializeShape();
        }

        public override void moveDown()
        {
            this.centerY += 1;
            this.InitializeShape();
        }

        public override void Fire() { 
            //make bullet and fire
        }
    }
}
