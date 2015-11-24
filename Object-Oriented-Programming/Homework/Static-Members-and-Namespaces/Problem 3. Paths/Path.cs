using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.Point3D;

namespace Problem_3.Paths
{
    public class Path
    {
        private List<Point3D> points;

        public Path(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public override string ToString()
        {
            string result = string.Format(string.Join("\n", Points));
            return result;
        }
    }
}
