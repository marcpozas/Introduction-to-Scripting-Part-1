# 🐑 Sheep Rescue - Unity Project

An interactive game developed as part of the **Introduction to Unity Scripting** tutorial, expanded with new features and visual improvements.

---

## New Features

- Special blue sheep (ice sheep) that slows down time for 3 seconds when hit.
- Blue screen overlay during the ice effect (UI overlay).
- The player is not slowed during the ice mode (uses `unscaledDeltaTime`).
- Exclusive material for the blue sheep (does not affect other sheep).

---

## Second Part of Introduction to Unity Scripting

- Automatic sheep spawning with `SheepSpawner`.
- Tracking of active sheep (`sheepList`) and their removal when hit or dropped.
- Scoring system: `sheepSaved` and `sheepDropped`.
- Limit of lost sheep to trigger game over.
- Separation between main menu and gameplay scene.
- Interface with basic UI buttons.
- Color selector for the Hay Machine with dynamic model switching.
- Sound system: hay, impact, and drop sounds.
- When a sheep is hit with hay, a floating heart appears, rotates, and animates upward.

---

## First Part of Introduction to Unity Scripting

- Movement of the Hay Machine using arrow or A/D keys.
- Shooting hay bales (`Hay Bale`) with the `Space` key.
- Automatic movement of sheep toward the edge.
- Collision detection between hay and sheep.
- Object destruction on impact (`DestroyOnTrigger`).
- Game logic handled by `Sheep.cs` and `SheepSpawner.cs`.
- Use of coroutines (`SpawnRoutine`) and `WaitForSeconds`.
- Handling of prefabs, colliders, rigidbodies, and triggers.
