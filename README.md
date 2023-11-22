# Reign.Physics2D

Just another fork of [Aether.Physics2D](https://github.com/tainicom/Aether.Physics2D), which was also forked from [Farseer Physics](https://github.com/Genbox/VelcroPhysics). This modified physics engine would be used in [Reign](https://reigngame.net) and will be modified to fit its usecase. We are currently in the progress of writing testcases to keep the functionality robust and consistent throughout its releases. This package will probably not be available on nuget, only on [GitHub Packages](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry). This will be one of the few projects that will be open-sourced that is directly related to [Reign](https://reigngame.net).

## Features

 - Continuous collision detection (with time of impact solver)
 - Contact callbacks: begin, end, pre-solve, post-solve
 - Convex and concave polyons and circles.
 - Multiple shapes per body
 - Dynamic tree and quad tree broadphase
 - Fast broadphase AABB queries and raycasts
 - Collision groups and categories
 - Sleep management
 - Friction and restitution
 - Stable stacking with a linear-time solver
 - Revolute, prismatic, distance, pulley, gear, mouse joint, and other joint types
 - Joint limits and joint motors
 - Controllers (gravity, force generators)
 - Tools to decompose concave polygons, find convex hulls and boolean operations
 - Factories to simplify the creation of bodies

## Credit

 - [Ian Qvis](https://github.com/Genbox), creating [Farseer Physics](https://github.com/Genbox/VelcroPhysics)
 - [Kastellanos Nikolaos](https://github.com/nkast), contributions to [Aether.Physics2D](https://github.com/tainicom/Aether.Physics2D)
