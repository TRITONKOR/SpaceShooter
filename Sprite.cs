using spaceshooter.UI;


namespace spaceshooter
{
    public abstract class Sprite
    {
        protected int centerX;
        protected int centerY;
        protected List<Point> displayPoints;
        protected char displayPixel;

        public abstract void InitializeShape();

        public List<Point> DisplayPoints
        {
            get { return displayPoints; }
        }

        public int CenterX
        {
            get { return centerX; }
            set
            {
                centerX = value;
                InitializeShape();
            }
        }

        public int CenterY
        {
            get { return centerY; }
            set
            {
                centerY = value;
                InitializeShape();
            }
        }

        public abstract void moveLeft();
        public abstract void moveRight();
        public abstract void moveUp();
        public abstract void moveDown();
        public abstract void Fire();
    }
}
