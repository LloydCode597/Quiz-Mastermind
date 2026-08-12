# Quiz Master – Unity 2D Quiz Game

A clean, multiple-choice quiz game developed as part of the **Complete C# Unity Game Developer 2D** course (GameDev.tv / Udemy).  
The project demonstrates core Unity UI workflows, data-driven design with ScriptableObjects, basic game flow management, and responsive user interaction.

## Project Overview

Quiz Master is a single-player 2D quiz application where players answer a series of multiple-choice questions within a time limit.  
Correct answers increase the score; the game ends when all questions are answered or time runs out, displaying final results with an option to replay.

### Key Learning Objectives Demonstrated

- Unity UI system (Canvas, TextMeshProUGUI, Buttons, Sliders, Images)
- ScriptableObjects for storing reusable question data (question text, answers, correct index)
- C# fundamentals: Lists, Arrays, for-loops, getter methods, events
- Scene management and reloading
- Simple state machines / game manager pattern
- UI feedback (button states, timer visualization, score tracking)

## Features

- Multiple-choice questions with four answer options
- Randomized or sequential question order
- Per-question countdown timer with visual fill bar
- Real-time score tracking
- End-screen summary (final score, replay button)
- Data-driven design: questions stored as ScriptableObject assets (easy to expand or modify without code changes)
- Clean separation of concerns (UI, GameManager, Question data)

## Technologies & Versions

- **Engine**: Unity 2021.1+ (course originally built here; compatible with Unity 6 as of 2025/2026 updates)
- **Language**: C# (modern syntax used in course)
- **UI**: TextMeshPro, uGUI (Canvas Scaler + Layout Groups)
- **Assets**: Minimal – sprites for button states, background, timer fill

No external packages are required beyond Unity's built-in features and TextMeshPro (imported via Package Manager).

## Project Structure (Typical Course Layout)

   git clone https://github.com/yourusername/mastermind-unity.git
