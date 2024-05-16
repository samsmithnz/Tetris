# Tetris

Welcome to Tetris! This classic game has been recreated as a .NET 8, Winforms application for you to enjoy.

## How to Play

The game is simple to play but challenging to master. Shapes composed of four square blocks each fall down the playing field. The objective of the game is to manipulate these shapes, by moving each one sideways and rotating it by 90-degree units, with the aim of creating a horizontal line of blocks without gaps. When such a line is created, it disappears, and any block above the deleted line will fall.

### Controls

- **Left Arrow**: Move the piece left
- **Right Arrow**: Move the piece right
- **Up Arrow**: Rotate the piece clockwise
- **Down Arrow**: Move the piece down faster

### Game Rules

- The game continues until the stack of shapes reaches the top of the playing field and no new shapes can enter.
- The player earns points by completing horizontal lines of blocks without empty spaces.
- As the game progresses, the shapes will fall faster, increasing the difficulty.

Enjoy the game and try to beat your high score!

## Running the Application

To run the Tetris game as a .NET 8, Winforms application, you will need to have .NET 8 installed on your machine. After ensuring that .NET 8 is installed, you can clone the repository and navigate to the `TetrisWinForms` directory. From there, you can build and run the application using the .NET CLI commands:

```bash
dotnet build
dotnet run
```

This will launch the Tetris game in a new window, where you can play the game using the controls listed above.
