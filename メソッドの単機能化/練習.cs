using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace メソッドの単機能化
{
    class 練習
    {
        private Circle c1;      //円1
        private Circle c2;      //円2
        private double r1;      //円1の半径
        private double r2;      //円2の半径
        private double s1;      //円1の面積
        private double s2;      //円2の面積
        private double l1;      //円1の円周
        private double l2;      //円2の円周
           
        public double GetArea()
        {
            
        }
    }

    class Circle
    {
        /**
         * 
         * 円の半径
         * 
         */
        private double r;
        
        /**
         * 
         * コンストラクタ
         * 半径(r)をパラメーターとして初期化
         * 
         */
        public Circle(double r)
        {
            this.r = r;
        }
        
        /** 
         * 
         * 円周を求めるメソッド
         * 
         */
        public double GetCircumference()
        {
            double circumference;
            circumference = 2d * Math.PI * this.r;
            return circumference;
        }
        /**
         * 
         * 面積を求めるメソッド
         * 
         */
        public double GetArea()
        {
            double area;
            area = Math.PI * Math.Pow(this.r, 2) ;
            return area;
        
        }

        /**
         * 
         * 円弧の長さを求めるメソッド
         * 
         */ 
        public double GetArc(double rad)
        {
            double arc;
            arc = this.r * rad;
            return rad;
        }

        /**
         * 
         * ラジアンを角度に変換するメソッド
         * 
         */
        public static double ConvertRadToDeg(double rad)
        {
            double deg;
            deg = rad * 180 / Math.PI;
            return deg;
        }


        /**
         * 
         * 角度からラジアンに変換するメソッド 
         * 
         */
        public static double ConvertDegToRad(double deg)
        {
            double rad;
            rad = deg * Math.PI / 180;
            return rad;
        }
    }
}
