using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem_using_OOPS_Concept
{
    internal class LineOOPConcepts
    {
        static void Main(string[] args)
        {

                Point p1 = new Point(1, 2);
                Point p2 = new Point(3, 4);

                 Line line = new Line(p1, p2);

                 double length = line.length();

            Console.WriteLine("The Length of Line is " + length);

                 if (line.equals(line))
                {
                Console.WriteLine("The Lines are Same");
                }
                else
                {
                Console.WriteLine("The Lines are Different");
                }
            }
        }
        class Point
        {

            float x;
            float y;

            Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
        class Line
        {
            Point p1;
            Point p2;

            Line(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }
            public boolean equals(Line l1)
            {
                if (this.p1 == l1.p1 && this.p2 == l1.p2)
                {
                    return true;
                }
                return false;
            }

            public double length()
            {
                return Math.sqrt(Math.pow((p2.x - p1.x), 2) + Math.pow((p2.y - p1.y), 2));
            }

        } }