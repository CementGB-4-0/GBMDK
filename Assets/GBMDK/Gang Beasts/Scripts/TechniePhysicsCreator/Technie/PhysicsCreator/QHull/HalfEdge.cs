namespace Technie.PhysicsCreator.QHull
{
    public class HalfEdge
    {
        public Face face;

        public HalfEdge next;

        public HalfEdge opposite;

        public HalfEdge prev;
        public Vertex vertex;

        public HalfEdge(Vertex v, Face f)
        {
        }

        public HalfEdge()
        {
        }

        public void setNext(HalfEdge edge)
        {
        }

        public HalfEdge getNext()
        {
            return null;
        }

        public void setPrev(HalfEdge edge)
        {
        }

        public HalfEdge getPrev()
        {
            return null;
        }

        public Face getFace()
        {
            return null;
        }

        public HalfEdge getOpposite()
        {
            return null;
        }

        public void setOpposite(HalfEdge edge)
        {
        }

        public Vertex head()
        {
            return null;
        }

        public Vertex tail()
        {
            return null;
        }

        public Face oppositeFace()
        {
            return null;
        }

        public string getVertexString()
        {
            return null;
        }

        public double length()
        {
            return 0.0;
        }

        public double lengthSquared()
        {
            return 0.0;
        }
    }
}