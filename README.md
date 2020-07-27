# A Test Game 

---

A test platformer game for me to test out different aspects of Unity and learn how to develop games in Unity.

[TOC]



----

## Devlog

---

### Day 1 (25/07/2020)

**Learned/Did This:**

* Made a simple "level-like scene" using some free assets from itch.io (learning about tilemaps and sorting layers)
* Made a coin fall down on to the ground and roll about (learning about rigidbodies and colliders)

**Problems:**

* None?

**Notes:**

* None?

### Day 2 (26/07/2020)

**Learned/Did This:**

* Put in a player character and created their animations (learning about animations)
* Made a player controller that lets the player character move left to right and jump, all with corresponding animations. (learning about scripting, taking inputs, some Physics2D stuff, and making rigidbodies move)

**Problems:**

* Player keeps tripping over random parts of the floor. This makes them tumble onto their side and stops them from moving correctly or being able to jump (since the ground check at their feet fails)

**Notes:**

* Remember to put both a Tilemap Collider 2D and a Composite Collider 2D onto your tilemaps. In addition, do the following:
  * Set "Used by Composite" in Tilemap Collider to true.
  * Set "Body Type" in Rigidbody 2D to "Kinematic".
  * Freeze the Position and Rotation of the Rigidbody 2D.

### Day 3 (27/07/2020)

**Learned/Did This:**

* Created a camera controller that allows the camera (and the background) to follow the player around (learning about Lerping)
* Added a crouch function to the camera that allows the player to pan the camera down a little bit. 
* Fixed the problem from Day 2 where the player keeps tripping on the floor.

**Problems:** 

* The player goes into their running animation if they're on the edge of a platform.

**Notes:**

* Freeze the player's Rigidbody's rotation to stop them from tripping.

****

## Resources Used

----

### Graphics

* [Free Swamp 2D Tileset Pixel Art (by Free Game Assets)](https://free-game-assets.itch.io/free-swamp-2d-tileset-pixel-art)
* [Demon Woods Parallax Background (by Aethrall)](https://aethrall.itch.io/demon-woods-parallax-background)
* [Generic PLATFORMER Pack (by Bakudas)](https://bakudas.itch.io/generic-platformer-pack)