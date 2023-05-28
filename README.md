# Maori Quiz Software

## Overview
This is a console-based quiz application in C# which quizzes the user on Maori culture, a significant indigenous culture of New Zealand. The quiz covers various aspects such as language, history, and customs. It has three difficulty levels - easy, medium, and hard. Each level consists of five multiple choice questions, with four possible answers (A-D) for each question.

## How It Works
1. Upon starting the application, the user is greeted and asked to enter their name.
2. After entering their name, the user is presented with three difficulty options: easy, medium, and hard.
3. After selecting a difficulty, the user is shown instructions for the quiz and asked to press any key to proceed.
4. The user is then asked a series of five multiple-choice questions. After each question, the user's score is updated. For each correct answer, the user receives two points.
5. The user's total score is displayed at the end of the quiz. To pass the quiz, the user must score at least eight points out of ten.
6. After the quiz ends, the user is asked if they want to take the quiz again.

## Key Requirements
- **.NET Environment**: This application requires a .NET environment (ideally .NET Core 3.1 or later) to run.
- **Console/Terminal**: As a console application, this program requires a terminal to interact with the user.

## How to Run the Software
1. Clone or download the source code to your local machine.
2. Open a terminal/console window.
3. Navigate to the directory where the source code is located.
4. If you're using the .NET Core CLI, type `dotnet run` to start the application.

## Features
- User input validation: The application checks for valid inputs at each stage, ensuring the user only enters appropriate responses.
- Replayability: After finishing the quiz, users are given the option to retake the quiz.
- Score tracking: The application keeps track of the user's score throughout the quiz.
