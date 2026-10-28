# 🐈 Kitty Go: 2D Retro Platformer Engine (C# / WPF)

📋 *[Читать на русском языке](README_RU.md)*

---

A responsive 2D retro platformer desktop game built natively on top of the Windows Presentation Foundation (WPF) subsystem. The project features custom state-driven physical mechanics, asynchronous keyboard interaction loops, and collision detection built completely from scratch without external game engines.

## 🛠️ Core Technology & Graphics
*   **Language & Runtime:** C# Core Engine + WPF (Windows Presentation Foundation) layout system.
*   **IDE Tooling:** Microsoft Visual Studio.
*   **Visual Assets:** Custom layered assets (main character, terrain tiles, coins, keys, background layers) generated in Adobe Photoshop.

## 🕹️ Architecture & Game Mechanics

The application utilizes a specialized centralized tick event controller (`MainTimerEvent`) driving synchronous gameplay subsystems:

1.  **Custom Physics & Gravity Loop:** Implements manual calculation of upward force vectors and acceleration decays (`jumpSpeed`, `force`) to simulate organic jumping states.
2.  **Asynchronous Input Controller:** Listens directly to keyboard triggers via `KeyIsDown` and `KeyIsUp` actions to achieve low-latency responses.
3.  **Collision Engine:** Coordinates interactive tracking loops checking intersections with multiple functional boundaries:
    *   `Platform` — Snaps player feet arrays down to surface coordinates and resets continuous jumping tokens.
    *   `Coin` — Grants focus tokens, hides items safely from active viewports, and increments scoreboard counters.
    *   `Key & Door` — Evaluates logical requirements; reaching the gate without picking up the key restricts level progression.

## 📸 Application Interface / Screenshots

<details>
<summary><b>Click to expand / Нажмите, чтобы открыть скриншоты</b></summary>

### 🗺️ Game Level Design
<img src="level.png" alt="Game Level" width="750" />

### 🏆 Journey Complete Dialog
<img src="complete.png" alt="Success Screen" width="350" />

### 💀 Game Over Screen
<img src="died.png" alt="Death Screen" width="350" />

</details>

---

## 💻 Local Setup

1. Open Microsoft Visual Studio.
2. Clone this repository directly or open the `KittyGo.sln` project solution file.
3. Hit `Build & Run (F5)` to compile the environment natively on any Windows OS.
