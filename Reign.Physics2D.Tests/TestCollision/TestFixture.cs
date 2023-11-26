using Reign.Physics2D.Collision.Shapes;
using Reign.Physics2D.Common;
using Reign.Physics2D.Dynamics;
using Reign.Physics2D.Dynamics.Contacts;

namespace Reign.Physics2D.Tests
{
    [TestClass]
    public class TestFixture
    {
        [TestMethod]
        public void TestAddFixture()
        {
            var body = new Body();

            Assert.AreEqual(0, body.FixtureList.Count);

            Vertices vertices = PolygonTools.CreateRectangle(5, 5, new Vector2(5, 5), 0);
            var fixture = new Fixture(new PolygonShape(vertices, 1.0f));
            body.Add(fixture);

            Assert.AreEqual(1, body.FixtureList.Count);
        }
    }
}