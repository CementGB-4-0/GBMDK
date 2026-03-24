namespace Technie.PhysicsCreator.QHull
{
    public class Vertex
    {
        public Face face;

        public int index;

        public Vertex next;
        public Point3d pnt;

        public Vertex prev;

        public Vertex()
        {
        }

        public Vertex(double x, double y, double z, int idx)
        {
        }
    }
}