using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONG_SIM
{
    class Pong
    {
        public Size FieldSize { get; set; }
        public Point Ball { get; set; }
        public Point BarrierL { get; set; }
        public Point BarrierR { get; set; }

        public Point BallVelocity { get; set; }

        private int BarrierWidth = 10;

        private int BallSize = 10;
        private int BarrierHeight = 100;

        private int BorderWidth = 10;
        private int FieldPadding = 40;

        private int BorderSpray = 3;

        private Random rnd = new Random();

        public Pong(Size pFieldSize)
        {
            FieldSize = pFieldSize;

            Ball = new Point(FieldSize.Width / 2, FieldSize.Height / 2);
            BarrierL = new Point(FieldPadding, FieldSize.Height / 2);
            BarrierR = new Point(FieldSize.Width - FieldPadding, FieldSize.Height / 2);

            BallVelocity = new Point(rnd.Next(-10,10), rnd.Next(-5,5));
        }

        public void MoveLeftBarrier(int increment)
        {
            BarrierL = new Point(BarrierL.X, BarrierL.Y + increment);
        }

        public void MoveRightBarrier(int increment)
        {
            BarrierR = new Point(BarrierR.X, BarrierR.Y + increment);
        }

        public void Tick()
        {
            // Move Ball
            Ball = new Point(Ball.X + BallVelocity.X, Ball.Y + BallVelocity.Y);

            // Detect Border-Collission
            // Top:
            if (Ball.Y - BallSize/2 < BorderWidth) BallVelocity = new Point(BallVelocity.X, -BallVelocity.Y);
            // Bottom:
            if (Ball.Y + BallSize/2 > FieldSize.Height - BorderWidth) BallVelocity = new Point(BallVelocity.X, -BallVelocity.Y);
            // Left:
            //if (Ball.X - BallSize / 2 < BorderWidth) BallVelocity = new Point(-BallVelocity.X, BallVelocity.Y);
            // Right:
            //if (Ball.X + BallSize / 2 > FieldSize.Width - BorderWidth) BallVelocity = new Point(-BallVelocity.X, BallVelocity.Y);

            // Detect Barrier-Collission
            // Left:
            if (Ball.X - BallSize / 2 < BarrierL.X + BorderWidth / 2 && Enumerable.Range(BarrierL.Y - BarrierHeight/2, BarrierL.Y + BarrierHeight / 2).Contains(Ball.Y)) BallVelocity = new Point(-BallVelocity.X, BallVelocity.Y + rnd.Next(-BorderSpray, BorderSpray));
            // Right:
            if (Ball.X + BallSize / 2 > BarrierR.X - BorderWidth / 2 && Enumerable.Range(BarrierR.Y - BarrierHeight / 2, BarrierR.Y + BarrierHeight / 2).Contains(Ball.Y)) BallVelocity = new Point(-BallVelocity.X, BallVelocity.Y + rnd.Next(-BorderSpray, BorderSpray));
        
            // Detect Scores
            
        }

        public void Render(Graphics g)
        {
            // Game field
            g.FillRectangle(Brushes.Gray, new Rectangle(0, 0, FieldSize.Width, FieldSize.Height));
            g.FillRectangle(Brushes.Black, new Rectangle(BorderWidth, BorderWidth, FieldSize.Width - BorderWidth*2, FieldSize.Height- BorderWidth*2));

            g.FillRectangle(Brushes.Gray, new Rectangle(FieldSize.Width / 2 - BorderWidth / 2, BorderWidth, BorderWidth, FieldSize.Height - BorderWidth * 2));

            // Ball
            g.FillRectangle(Brushes.White, new Rectangle(Ball.X - BallSize / 2, Ball.Y - BallSize / 2, BallSize, BallSize));
            
            // Left Barrier
            g.FillRectangle(Brushes.White, new Rectangle(BarrierL.X - BarrierWidth / 2, BarrierL.Y - BarrierHeight / 2, BarrierWidth, BarrierHeight));
            
            // Right Barrier
            g.FillRectangle(Brushes.White, new Rectangle(BarrierR.X - BarrierWidth / 2, BarrierR.Y - BarrierHeight / 2, BarrierWidth, BarrierHeight));
        }
    }
}
