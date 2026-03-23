# Mastermind – Unity 2D

A digital implementation of the classic code-breaking board game **Mastermind** built in **Unity** using **C#**.

The player attempts to guess a secret sequence of colored pegs within a limited number of turns. After each guess, the game provides feedback in the form of black and white key pegs:
- **Black peg** → correct color in the correct position
- **White peg** → correct color in the wrong position

## Project Overview

This project was created as part of learning objectives in 2D game development, UI systems, scripting logic, and state management in Unity. It demonstrates:

- Grid-based UI layout using Unity UI (Canvas, Grid Layout Group, Buttons/Images)
- Drag-and-drop or click-to-place interaction for code pegs
- Procedural generation of secret codes
- Scoring logic for black/white peg feedback
- Win/lose conditions and turn limiting
- Clean separation of concerns (Game Manager, Board Manager, Code Peg logic)

## Features

- Classic 4-peg secret code with 6 possible colors (extendable)
- 10–12 guess attempts (configurable)
- Real-time feedback display using black and white peg indicators
- Visual distinction between peg colors (red, green, blue, yellow, orange, purple, etc.)
- Simple win/lose screens with restart option
- Optional sound effects and animations (if implemented)

## Technologies Used

- **Unity**     2021.3 LTS – 2023.x / Unity 6 (project-dependent version)
- **C#**        scripting language
- **Unity UI**  (uGUI) for board, pegs, and feedback display
- **ScriptableObjects** (optional) for color definitions or game settings
- No external asset store packages required (pure Unity features)

## How to Play

1. Observe the empty board with guess rows.
2. Select colors from the palette (bottom or side).
3. Fill one complete row with 4 colored pegs.
4. Submit the guess (button or auto-submit when full).
5. View feedback:
   - Black peg = right color + right position
   - White peg = right color + wrong position
6. Continue until you guess the code or run out of turns.

Goal: Deduce the secret code in as few attempts as possible.

## Installation & Running

1. Clone or download the repository:
   ```bash
   git clone https://github.com/yourusername/mastermind-unity.git
