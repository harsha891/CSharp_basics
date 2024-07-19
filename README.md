# Multiplex Cinema and Exam Scores Applications

## Project Structure

- **Q1**: Contains the cinema selection application.
  - **Program.cs**: Main program file for cinema selection.
- **Q2**: Contains the exam scores and degree classifications application.
  - **Program.cs**: Main program file for exam scores.
- **Q3**: Contains the cinema selection with validation application.
  - **Program.cs**: Main program file for cinema selection with validation.
- **Q4**: Contains the sales bar chart application.
  - **Program.cs**: Main program file for sales bar chart.
- **Q5**: Contains the Rock-Paper-Scissors game application.
  - **Program.cs**: Main program file for Rock-Paper-Scissors game.
- **Q6**: Contains the vowel counting application.
  - **Program.cs**: Main program file for vowel counting.
- **Q7**: Contains the cinema entry application.
  - **Program.cs**: Main program file for cinema entry.

## Prerequisites

- .NET Framework 4.7.2

## Running the Applications

1. Build the projects using Visual Studio.
2. Execute the respective `.exe` files from the `bin/Debug` directory.

## Overview

This repository contains console-based applications that simulate a cinema ticketing system, determine degree classifications based on exam scores, play a Rock-Paper-Scissors game, and count vowels in words from a file.

### Q1: Cinema Selection Application

This application allows users to select from a predefined list of movies and validates their age to ensure they are eligible to watch the selected film.

#### Features

- Display a list of currently showing movies with their ratings.
- Prompt the user to select a movie and enter their age.
- Validate user age against the movie rating to determine access.
- Provide appropriate messages based on age validation.

#### Concepts Used

- **Console Input/Output**: Uses `Console.ReadLine` to read user input and `Console.WriteLine` to display messages.
- **Conditional Statements**: Utilizes `switch` and `if-else` statements to handle movie selection and age validation.
- **Data Validation**: Ensures that user inputs for movie selection and age are valid.

#### Example Usage

Welcome to our Multiplex
We are presently showing:
1. Rush (15)
2. How I Live Now (15)
3. Thor: The Dark World (12A)
4. Filth (18)
5. Planes (U)
Enter the number of the film you wish to see: 3
Enter your age: 14
Enjoy the film


### Q2: Exam Scores and Degree Classifications Application

This application takes a candidate's exam score as input and determines their degree classification based on the score.

#### Features

- Prompt the user to enter exam scores.
- Validate the score to ensure it is within the range of 0 to 100.
- Display appropriate messages based on the score, indicating if the candidate failed, can be compensated, or achieved a certain degree classification.

#### Concepts Used

- **Console Input/Output**: Uses `Console.ReadLine` to read input from the user and `Console.WriteLine` to display messages.
- **Conditional Statements**: Employs `if-else` statements to evaluate the input score and determine the corresponding degree classification.
- **Data Validation**: Checks if the input score is within the valid range (0 to 100) and handles invalid inputs gracefully.
- **Parsing Input**: Uses `int.Parse` to convert the input string to an integer for score evaluation.

#### Example Usage

Enter candidate marks: 65
Candidate passed in upper second class degree - II(i)


### Q3: Cinema Selection with Validation Application

This application allows users to select from a predefined list of movies, validates their age, and checks the validity of the movie number and age entered. 

#### Features

- Display a list of currently showing movies with their ratings.
- Prompt the user to select a movie and enter their age.
- Validate user age against the movie rating to determine access.
- Validate the movie number and age to ensure valid inputs.
- Provide appropriate messages based on age validation.
- Support for processing multiple customers.

#### Concepts Used

- **Console Input/Output**: Uses `Console.ReadLine` to read user input and `Console.WriteLine` to display messages.
- **Loops**: Uses `do-while` loops to handle multiple customers and validate inputs.
- **Conditional Statements**: Utilizes `switch` and `if-else` statements to handle movie selection and age validation.
- **Data Validation**: Ensures that user inputs for movie selection and age are valid.

#### Example Usage

Welcome to our Multiplex
We are presently showing:
1. Rush (15)
2. How I Live Now (15)
3. Thor: The Dark World (12A)
4. Filth (18)
5. Planes (U)
Enter the number of the film you wish to see: 3
Enter your age: 14
Enjoy the film

Another Customer? Y or N : Y

We are presently showing:
1. Rush (15)
2. How I Live Now (15)
3. Thor: The Dark World (12A)
4. Filth (18)
5. Planes (U)
Enter the number of the film you wish to see: 1
Enter your age: 14
Access denied – you are too young

Another Customer? Y or N : N


### Q4: Sales Bar Chart Application

This application allows users to input the sales for five stores and displays a bar chart representation of the sales.

#### Features

- Prompt the user to enter the sales for five stores.
- Validate the sales to ensure they are non-negative.
- Display a bar chart representation of the sales where each '*' represents $100 in sales.

#### Concepts Used

- **Console Input/Output**: Uses `Console.ReadLine` to read user input and `Console.WriteLine` to display messages and the bar chart.
- **Arrays**: Utilizes an array to store the sales data for the stores.
- **Loops**: Uses `for` and `while` loops to input sales, validate them, and display the bar chart.
- **Data Validation**: Ensures that sales values are non-negative.

#### Example Usage

Enter today’s sales for store 1: 500
Enter today’s sales for store 2: 600
Enter today’s sales for store 3: 700
Enter today’s sales for store 4: 800
Enter today’s sales for store 5: 900

SALES BAR CHART
Store 1: *****
Store 2: ******
Store 3: *******
Store 4: ********
Store 5: *********


### Q5: Rock-Paper-Scissors Game Application

This application allows the user to play the classic Rock-Paper-Scissors game against the computer.

#### Features

- The computer randomly selects rock, paper, or scissors.
- The user inputs their choice.
- The application validates the user's input to ensure it is one of the three valid choices.
- The game determines the winner based on standard Rock-Paper-Scissors rules and displays the result.

#### Concepts Used

- **Console Input/Output**: Uses `Console.ReadLine` to read user input and `Console.WriteLine` to display messages.
- **Random Number Generation**: Uses `Random` to generate the computer's choice.
- **Conditional Statements**: Utilizes `if-else` statements to determine the game result.
- **Data Validation**: Ensures that the user's choice is valid.

#### Example Usage

Welcome to Rock-Paper-Scissors Game

Copy code
rock
paper
scissors
Enter your Choice: rock
Computer Choice: scissors
Player Choice: rock

Player Wins


### Q6: Vowels Counting Application

This application reads words from a file named `words.txt` and counts the number of vowels in each word, determining the word with the highest number of vowels.

#### Features

- Read words from `words.txt`.
- Display the words read from the file.
- Count the vowels in each word and determine the word with the highest number of vowels.
- Display the word with the highest number of vowels.

#### Concepts Used

- **File I/O**: Uses `StreamReader` to read words from a file.
- **Console Input/Output**: Uses `Console.WriteLine` to display messages.
- **Loops**: Uses `while` loop to read through the file and `for` loop to count vowels.
- **Conditional Statements**: Utilizes `if` statements to count vowels.
- **String Manipulation**: Processes each word to count vowels.

#### Example Usage

Words in words.txt file :
example
programming
vowels

The largest number of vowels in any one word is: 3


### Q7: Cinema Entry Application

This application allows users to input movie names with ratings and validates customer age for movie access.

#### Features

- Input and validate movie names with ratings (U, 12, 12A, 15, 18).
- Display the list of currently showing movies.
- Validate user age against the movie rating to determine access.
- Support for processing multiple customers.

#### Concepts Used

- **Console Input/Output**: Uses `Console.ReadLine` to read user input and `Console.WriteLine` to display messages.
- **Arrays**: Utilizes arrays to store and display the list of movies and their ratings.
- **Loops**: Uses `do-while` and `for` loops to handle multiple customers and validate inputs.
- **Conditional Statements**: Employs `if-else` statements to validate movie ratings and customer age.

#### Example Usage

Welcome to our Multiplex
Enter name for film for number 1 : Movie1 (15)
Enter name for film for number 2 : Movie2 (12)
Enter name for film for number 3 : Movie3 (18)
Enter name for film for number 4 : Movie4 (U)
Enter name for film for number 5 : Movie5 (12A)

We are presently showing:
1. Movie1 (15)
2. Movie2 (12)
3. Movie3 (18)
4. Movie4 (U)
5. Movie5 (12A)

Enter the number of the film you wish to see: 1
Enter your age: 14
Access denied – you are too young

Another Customer? Y or N : Y

We are presently showing:
1. Movie1 (15)
2. Movie2 (12)
3. Movie3 (18)
4. Movie4 (U)
5. Movie5 (12A)

Enter the number of the film you wish to see: 4
Enter your age: 5
Enjoy the film

Another Customer? Y or N : N

# Enjoy the simulations of cinema ticketing and degree classification experiences!
