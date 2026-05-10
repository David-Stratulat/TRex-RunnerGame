# 🦖 T-Rex Runner Game (WinForms)

A desktop game inspired by the Chrome offline dinosaur runner, developed using C# and Windows Forms.

The player controls a dinosaur that must jump over incoming obstacles while the game speed continuously increases. The project includes sprite animation, collision detection, score tracking, restart functionality, and a persistent high score system stored locally through a simple database/file handling implementation.

---

# Features

- Dinosaur jump mechanic with gravity simulation
- Animated running and death sprites
- Random obstacle spawning
- Continuous obstacle movement
- Collision detection system
- Dynamic score tracking
- Increasing game difficulty over time
- Restart functionality after game over
- Persistent high score saving
- Local database/file handling for score storage
- Real-time UI updates

---

# Controls

| Key | Action |
|-----|--------|
| `SPACE` | Jump |
| `R` | Restart the game after game over |

---

# High Score System

The game includes a local high score system implemented using a custom database/file management solution.

When the player achieves a new record:
- the score is automatically saved locally
- the high score persists even after closing the application
- the saved value is loaded again when reopening the game

This functionality is managed through the `DatabaseManager.cs` component located inside the `database/` folder.

---

# Technologies Used

- C#
- Windows Forms (.NET Framework)
- WinForms Timers
- Event-driven programming
- Local file/database handling
- Object-oriented programming principles

---

# Project Structure

```txt
TRex-RunnerGame/
│
├── assets/
│   ├── dead.png
│   ├── obstacle-1.gif
│   ├── obstacle-2.gif
│   └── running.gif
│
├── database/
│   └── DatabaseManager.cs
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── App.config
├── packages.config
└── README.md
```

---

# Gameplay Overview

The player controls a dinosaur character positioned near the bottom of the screen.

Obstacles continuously move toward the player from the right side of the window. The player must avoid collisions by jumping at the correct time.

As the score increases:
- obstacle speed gradually increases
- reaction timing becomes more difficult
- gameplay becomes progressively faster

When a collision occurs:
- the dinosaur switches to the death sprite
- the game loop stops
- the final score is displayed
- the player can restart the game using the `R` key

---

# Game Assets

The project uses animated GIF and PNG assets for:
- running animation
- death animation
- cactus obstacles

All assets are stored inside the `assets/` folder.

---

# Project Purpose

This project was created to practice and improve knowledge of:

- C# application development
- Windows Forms programming
- Game loop implementation
- Collision detection systems
- Working with timers and events
- Sprite animation handling
- Persistent local data storage
- Object-oriented programming
- Structuring medium-sized C# projects

---
