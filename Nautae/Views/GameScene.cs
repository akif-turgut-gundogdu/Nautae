using CocosSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nautae.Views
{
    public class GameScene : CCScene
    {
        //CCDrawNode circle;
        CCDrawNode leftWing;
        CCDrawNode rightWing;
        CCDrawNode botWing;
        CCDrawNode redaltdalgatuycuk;

        public GameScene(CCGameView gameView) : base(gameView)
        {
            var layer = new CCLayer();
            this.AddLayer(layer);
            //circle = new CCDrawNode();
            leftWing = new CCDrawNode();
            rightWing = new CCDrawNode();
            botWing = new CCDrawNode();
            redaltdalgatuycuk = new CCDrawNode();
            layer.AddChild(leftWing);
            layer.AddChild(rightWing);
            layer.AddChild(botWing);
            layer.AddChild(redaltdalgatuycuk);
            //circle.DrawCircle(
            //    // The center to use when drawing the circle,
            //    // relative to the CCDrawNode:
            //    new CCPoint(0, 0),
            //    radius: 15,
            //    color: CCColor4B.White);

            //circle.PositionX = 20;
            //circle.PositionY = 50;

            rightWing.DrawCubicBezier(
            origin: new CCPoint(20, 20),
            control1: new CCPoint(50, 10),
            control2: new CCPoint(60, 10),
            destination: new CCPoint(70, 20),
            segments: 20,
            lineWidth: 0.1F,
            color: CCColor4B.Green);

            //        leftWing.DrawSolidArc(
            //pos: new CCPoint(20, 20),
            //radius: 20,
            //startAngle: 0,
            //sweepAngle: CCMathHelper.Pi / 2, // this is in radians, clockwise
            //color: CCColor4B.White);

            CCV3F_C4B[] verts = new CCV3F_C4B[] {
    // First line:
    new CCV3F_C4B( new CCPoint(20,20), CCColor4B.White),
    new CCV3F_C4B( new CCPoint(70,70), CCColor4B.White),
    // second line, will blend from white to red:
    new CCV3F_C4B( new CCPoint(70,70), CCColor4B.White),
    new CCV3F_C4B( new CCPoint(70,20), CCColor4B.White)



};


            CCV3F_C4B[] verts2 = new CCV3F_C4B[] {
    // First line:
    new CCV3F_C4B( new CCPoint(70,20), CCColor4B.White),
    new CCV3F_C4B( new CCPoint(80,10), CCColor4B.White),
    // second line, will blend from white to red:
    new CCV3F_C4B( new CCPoint(80,10), CCColor4B.White),
    new CCV3F_C4B( new CCPoint(100,13), CCColor4B.White)


};

            leftWing.DrawLineList(verts);
            botWing.DrawLineList(verts2);




            var splinePoints = new List<CCPoint>();
            splinePoints.Add(new CCPoint(51, 40));
            splinePoints.Add(new CCPoint(54, 42));
            splinePoints.Add(new CCPoint(57, 40));
            splinePoints.Add(new CCPoint(60, 42));

            redaltdalgatuycuk.DrawCardinalSpline(
                config: splinePoints,
                tension: 0,
                segments: 64,
                
                color: CCColor4B.Red);

        }
        //public void MoveCircleLeft()
        //{
        //    circle.PositionX -= 10;
        //}

        //public void MoveCircleRight()
        //{
        //    circle.PositionX += 10;
        //}
    }
}
