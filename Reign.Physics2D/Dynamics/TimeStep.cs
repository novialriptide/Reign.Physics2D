using Reign.Physics2D.Common;
#if XNAAPI
using Vector2 = Microsoft.Xna.Framework.Vector2;
#endif

namespace Reign.Physics2D.Dynamics
{
    /// <summary>
    /// This is an internal structure.
    /// </summary>
    internal struct TimeStep
    {
        /// <summary>
        /// Time step (Delta time)
        /// </summary>
        public float dt;

        /// <summary>
        /// dt * inv_dt0
        /// </summary>
        public float dtRatio;

        /// <summary>
        /// Inverse time step (0 if dt == 0).
        /// </summary>
        public float inv_dt;

        public int positionIterations;
        public int velocityIterations;

        public bool warmStarting;
    }

    /// This is an internal structure.
    internal struct SolverPosition
    {
        public Vector2 c;
        public float a;
    }

    /// This is an internal structure.
    internal struct SolverVelocity
    {
        public Vector2 v;
        public float w;
    }

    /// Solver Data
    internal struct SolverData
    {
        internal TimeStep step;
        internal SolverPosition[] positions;
        internal SolverVelocity[] velocities;
        internal int[] locks;
    }
}