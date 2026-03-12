using System.Collections.Generic;

namespace Technie.PhysicsCreator.QHull
{
    public class QuickHull3D
    {
        public const int CLOCKWISE = 1;

        public const int INDEXED_FROM_ONE = 2;

        public const int INDEXED_FROM_ZERO = 4;

        public const int POINT_RELATIVE = 8;

        public const double AUTOMATIC_TOLERANCE = -1.0;

        private const double DOUBLE_PREC = 2.220446049250313E-16;

        private const int NONCONVEX_WRT_LARGER_FACE = 1;

        private const int NONCONVEX = 2;

        protected double charLength;

        private VertexList claimed;

        protected bool debug;

        private Face[] discardedFaces;

        protected double explicitTolerance;

        protected List<Face> faces;

        protected int findIndex;

        protected List<HalfEdge> horizon;

        private Vertex[] maxVtxs;

        private Vertex[] minVtxs;

        private FaceList newFaces;

        protected int numFaces;

        protected int numPoints;

        protected int numVertices;

        protected Vertex[] pointBuffer;

        protected double tolerance;

        private VertexList unclaimed;

        protected int[] vertexPointIndices;

        public QuickHull3D()
        {
        }

        public QuickHull3D(double[] coords)
        {
        }

        public QuickHull3D(Point3d[] points)
        {
        }

        public bool getDebug()
        {
            return false;
        }

        public void setDebug(bool enable)
        {
        }

        public double getDistanceTolerance()
        {
            return 0.0;
        }

        public void setExplicitDistanceTolerance(double tol)
        {
        }

        public double getExplicitDistanceTolerance()
        {
            return 0.0;
        }

        private void addPointToFace(Vertex vtx, Face face)
        {
        }

        private void removePointFromFace(Vertex vtx, Face face)
        {
        }

        private Vertex removeAllPointsFromFace(Face face)
        {
            return null;
        }

        private HalfEdge findHalfEdge(Vertex tail, Vertex head)
        {
            return null;
        }

        protected void setHull(double[] coords, int nump, int[][] faceIndices, int numf)
        {
        }

        public void build(double[] coords)
        {
        }

        public void build(double[] coords, int nump)
        {
        }

        public void build(Point3d[] points)
        {
        }

        public void build(Point3d[] points, int nump)
        {
        }

        public void triangulate()
        {
        }

        protected void initBuffers(int nump)
        {
        }

        protected void setPoints(double[] coords, int nump)
        {
        }

        protected void setPoints(Point3d[] pnts, int nump)
        {
        }

        protected void computeMaxAndMin()
        {
        }

        protected void createInitialSimplex()
        {
        }

        public int getNumVertices()
        {
            return 0;
        }

        public Point3d[] getVertices()
        {
            return null;
        }

        public int getVertices(double[] coords)
        {
            return 0;
        }

        public int[] getVertexPointIndices()
        {
            return null;
        }

        public int getNumFaces()
        {
            return 0;
        }

        public int[][] getFaces()
        {
            return null;
        }

        public int[][] getFaces(int indexFlags)
        {
            return null;
        }

        private void getFaceIndices(int[] indices, Face face, int flags)
        {
        }

        protected void resolveUnclaimedPoints(FaceList newFaces)
        {
        }

        protected void deleteFacePoints(Face face, Face absorbingFace)
        {
        }

        protected double oppFaceDistance(HalfEdge he)
        {
            return 0.0;
        }

        private bool doAdjacentMerge(Face face, int mergeType)
        {
            return false;
        }

        protected void calculateHorizon(Point3d eyePnt, HalfEdge edge0, Face face, List<HalfEdge> horizon)
        {
        }

        private HalfEdge addAdjoiningFace(Vertex eyeVtx, HalfEdge he)
        {
            return null;
        }

        protected void addNewFaces(FaceList newFaces, Vertex eyeVtx, List<HalfEdge> horizon)
        {
        }

        protected Vertex nextPointToAdd()
        {
            return null;
        }

        protected void addPointToHull(Vertex eyeVtx)
        {
        }

        protected void buildHull()
        {
        }

        private void markFaceVertices(Face face, int mark)
        {
        }

        protected void reindexFacesAndVertices()
        {
        }

        protected bool checkFaceConvexity(Face face, double tol)
        {
            return false;
        }

        protected bool checkFaces(double tol)
        {
            return false;
        }

        public bool check()
        {
            return false;
        }

        public bool check(double tol)
        {
            return false;
        }
    }
}