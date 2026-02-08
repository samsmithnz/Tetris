# Tetris

## Objective
Score as many points as possible by clearing horizontal lines before the playing field fills up to the top.

## Gameplay Basics
- The Playing Field is rectangular grid, typically 10 blocks wide and 20 blocks tall
- Pieces (tetrominoes) fall from the top
- Tetrominoes (The Pieces)
- Seven distinct shapes, each made of 4 blocks:
  - I-piece: Straight line (4 blocks)
  - O-piece: Square (2×2)
  - T-piece: T-shape
  - L-piece: L-shape
  - J-piece: Reverse L-shape
  - S-piece: S-shape (zigzag left)
  - Z-piece: Z-shape (zigzag right)

## Controls
- Left/Right arrows: Move piece horizontally
- Down arrow: Soft drop (faster descent)
- Rotation button: Rotate piece 90° clockwise (some versions allow counter-clockwise)
- Drop button: Hard drop (instant placement at bottom)

## Rules
- Piece Generation: A random tetromino appears at the top center of the playing field
- Gravity: The piece automatically falls downward at regular intervals (speed increases with level)
- Player Actions: While falling, you can move the piece left/right and rotate it to position it optimally
- Placement: When a piece reaches the bottom or lands on another piece, it locks into place

### Line Clearing:
- When a horizontal row is completely filled with blocks, it disappears
- All blocks above the cleared line(s) drop down by one row
- You can clear multiple lines simultaneously (up to 4)

### Scoring:
- Single: 1 line = 100 points × level
- Double: 2 lines = 300 points × level
- Triple: 3 lines = 500 points × level
- Tetris: 4 lines = 800 points × level (highest scoring move)

### Level Progression:
- Typically increases every 10 lines cleared
- Higher levels = faster falling speed
- Some versions start you at a chosen level
- Game Over: The game ends when a new piece cannot be placed because the playing field has filled to the top

## Strategy Tips
- Plan ahead for where pieces will fit
- Keep the stack as low and flat as possible
- Save a column open for I-pieces to score Tetrises
- Avoid creating gaps that are difficult to fill
