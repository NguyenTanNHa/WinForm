using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyPaint
{
    public abstract class ShapeEntity
    {
        protected Point startPoint; // Điểm bắt đầu
        protected Point endPoint; // Điểm kết thúc
        protected Pen pen; // Bút vẽ


        public bool IsSelected { get; set; }
        public Point Position { get; set; }
        public List<Point> Points { get; set; } 
        public ShapeEntity(Point startPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = startPoint;
            pen = new Pen(Color.Black);
        }
        public void Move(int dx, int dy)
        {
        }


        public abstract void Draw(Graphics graphics);
        public abstract void UpdateSize(Point endPoint);
        public virtual bool Contains(Point point)
        {
            return false;
        }
        public virtual void UpdatePosition(Point newPosition)
        {
            int deltaX = newPosition.X - startPoint.X;
            int deltaY = newPosition.Y - startPoint.Y;

            startPoint = new Point(startPoint.X + deltaX, startPoint.Y + deltaY);
            endPoint = new Point(endPoint.X + deltaX, endPoint.Y + deltaY);
        }

    }

    public class RectangleShape : ShapeEntity
    {
        public Color Color { get; private set; }

        public RectangleShape(Point startPoint) : base(startPoint)
        {
        }

        public override void Draw(Graphics graphics)
        {
            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;
            Rectangle rectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);
            graphics.DrawRectangle(pen, rectangle);
            var dashedPen = new Pen(Color.Black, 2);
            dashedPen.DashPattern = new float[] { 5, 5 };

            graphics.DrawRectangle(dashedPen, startPoint.X, startPoint.Y, width, height);
        }

        public bool Contains(Point point)
        {
            Rectangle rectangle = new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            return rectangle.Contains(point);
        }
        public event EventHandler ShapeClicked;

        
        public override void UpdateSize(Point endPoint)
        {
            this.endPoint = endPoint;
        }

       
    }

    public class CircleShape : ShapeEntity
    {
        public CircleShape(Point startPoint) : base(startPoint)
        {

        }


        public override void Draw(Graphics graphics)
        {
            int width = endPoint.X - startPoint.X;
            int height = endPoint.Y - startPoint.Y;
            int radius = Math.Min(width, height);
            Rectangle rectangle = new Rectangle(startPoint.X, startPoint.Y, radius, radius);
            var dashedPen = new Pen(Color.Black, 2);

            graphics.DrawEllipse(dashedPen, rectangle);
        }
       
        public override void UpdateSize(Point endPoint)
        {
            this.endPoint = endPoint;
        }
    }
    public class ChooseShape : ShapeEntity
    {

        public ChooseShape(Point startPoint) : base(startPoint)
        {

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, startPoint, endPoint);
        }
        public override void UpdateSize(Point endPoint)
        {
            this.endPoint = endPoint;
        }
    }
    public class AnyShape : ShapeEntity
    {
        private List<Point> points;

        public AnyShape(Point startPoint) : base(startPoint)
        {
            this.points = new List<Point>();    
            points.Add(startPoint);

        }
        public override void Draw(Graphics graphics)
        {
            if(points.Count > 0)
            {
                graphics.DrawLines(Pens.Black, points.ToArray());

            }
        }
        public override void UpdateSize(Point endPoint)
        {
            points.Add(endPoint);
        }
    }

}

