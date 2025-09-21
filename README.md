Typing Game - C# Windows Forms

This project is a typing speed game built with C# (Windows Forms).
The player is shown a random word or sentence, and they must type it correctly before the timer runs out.

- Features

Three game modes:

Words Only → Only single words appear.

Sentences Only → Only full sentences appear.

Both → A mix of words and sentences appear.

Score tracking → Each correct input increases the score.

Countdown timer → Player has 10 seconds per word/sentence.

Game over screen → Shows the final score when time runs out.

- Project Structure
Class1.cs

Handles game data and logic.

Loads words and sentences from AllWordsAndSentences.txt.

Provides the next random word/sentence depending on the selected GameMode.

GameMode.cs

Enum that defines the three game modes:

WordsOnly

Sentencesonly

Both

Form1.cs

The main menu form.

Lets the player select a game mode via radio buttons.

Buttons:

Start Game → Opens Form2.

Exit → Closes the application.

Form2.cs

The gameplay form.

Displays the current word/sentence.

Handles:

Timer countdown (10 seconds).

Checking typed input.

Updating score and time reset after each correct answer.

Showing final score when time runs out.

Program.cs

Entry point of the application.

Starts the game with Form1.

- How It Works

The game loads all words and sentences from AllWordsAndSentences.txt.

Player selects a mode (Words / Sentences / Both).

A random word/sentence is displayed.

Player must type it exactly into the input box.

If correct → Score increases by 1, timer resets to 10 seconds, and a new word/sentence appears.

If time runs out → Game over message with final score.

🛠️ Requirements

.NET Framework (or .NET Core for Windows Forms).

Visual Studio (recommended) or any IDE that supports WinForms.
