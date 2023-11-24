using Reign.Physics2D.Collision.Shapes;
using Reign.Physics2D.Common;
using Reign.Physics2D.Dynamics;
using Reign.Physics2D.Dynamics.Contacts;

namespace Reign.Physics2D.Tests
{

    [TestClass]
    public class TestContact
    {
        private class DummyObject
        {
            private World world;
            public Body Body;
            private int rectangleRadius = 25;

            public int OnCollisionCallCount = 0;
            public int OnSeparationCallCount = 0;

            public DummyObject(World world, Vector2 position)
            {
                this.world = world;

                Vector2 center = new Vector2(rectangleRadius, rectangleRadius) / 2;
                Vertices vertices = PolygonTools.CreateRectangle(rectangleRadius, rectangleRadius, center, 0);

                Body = this.world.CreateBody(position);
                Body.BodyType = BodyType.Dynamic;
                Body.IgnoreGravity = true;

                Fixture fixture = new Fixture(new PolygonShape(vertices, 1.0f));
                fixture.OnCollision += onCollision;
                fixture.OnSeparation += OnSeparation;
                Body.Add(fixture);
            }

            private bool onCollision(Fixture fixtureA, Fixture fixtureB, Contact contact)
            {
                OnCollisionCallCount += 1;
                return true;
            }

            private void OnSeparation(Fixture fixtureA, Fixture fixtureB, Contact contact)
            {
                OnSeparationCallCount += 1;
            }
        }

        [TestMethod]
        public void TestOnCollisionAndOnSeparationWithBody()
        {
            World world = new World();

            DummyObject dummy1 = new DummyObject(world, new Vector2(0, 0));

            Assert.AreEqual(0, dummy1.OnCollisionCallCount);
            Assert.AreEqual(0, dummy1.OnSeparationCallCount);

            DummyObject dummy2 = new DummyObject(world, new Vector2(0, 0));
            world.Step(1f);

            Assert.AreEqual(1, dummy1.OnCollisionCallCount);
            Assert.AreEqual(0, dummy1.OnSeparationCallCount);
            Assert.AreEqual(1, dummy2.OnCollisionCallCount);
            Assert.AreEqual(0, dummy2.OnSeparationCallCount);

            dummy2.Body.Position = new Vector2(50, 50);
            world.Step(1f);

            Assert.AreEqual(1, dummy1.OnCollisionCallCount);
            Assert.AreEqual(1, dummy1.OnSeparationCallCount);
            Assert.AreEqual(1, dummy2.OnCollisionCallCount);
            Assert.AreEqual(1, dummy2.OnSeparationCallCount);
        }
    }
}