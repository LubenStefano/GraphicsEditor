# Graphics Editor Application - OOP Course Project

This curse project is for FPMI-ISN TU SOFIA OOP, a Windows Forms application designed to allow users to create, manipulate, and interact with different graphical shapes using object-oriented programming principles. The application provides a variety of drawing tools and supports various shapes such as circles, rectangles, triangles, trapezoids, and more. The shapes can be filled or unfilled, and their size and color can be modified.

## Features

- **Shape Creation**: Users can draw various shapes including:
  - Rectangle
  - Circle
  - Triangle
  - Trapezoid
  - And more
- **Shape Manipulation**: You can interact with shapes by:
  - Moving them on the canvas
  - Editing their size and dimensions (e.g., width, height, radius, etc.)
  - Changing the fill color
  - Switching between filled and outlined shapes
- **Area Calculation**: The application supports automatic calculation of the area of each shape based on its size and properties.
- **Event-Driven Interaction**: User interactions such as selecting, moving, and editing shapes trigger corresponding events.
- **Object-Oriented Design**: The application leverages key OOP concepts such as:
  - **Inheritance**: Shapes inherit from a base `Shape` class.
  - **Encapsulation**: Shapes have encapsulated properties like position, size, and color.
  - **Polymorphism**: Operations on shapes (e.g., drawing, resizing) are handled uniformly.
  - **Virtual Methods**: Shapes can override methods like `Draw` and `CalculateArea`.

## Technologies Used

- **C#**: Programming language used for the development.
- **Windows Forms**: For creating the graphical user interface.
- **Object-Oriented Programming (OOP)**: Inheritance, encapsulation, polymorphism, and other OOP principles are heavily utilized.
- **GDI+**: For drawing shapes and handling graphical operations.

## Requirements

- **Microsoft Visual Studio**: Recommended IDE for working with Windows Forms applications.
- **.NET Framework**: Ensure you have .NET Framework installed (usually .NET 4.5 or above for Windows Forms projects).

## Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/yourusername/GraphicsEditorApp.git
    ```

2. Open the solution file (`GraphicsEditorApp_OOP_course_project.sln`) in **Microsoft Visual Studio**.

3. Build the project to restore dependencies and ensure everything is correctly set up.

4. Run the project to start the application.

## Usage

Once the application is running, you will see a canvas where you can:

1. **Create a Shape**: Select the desired shape (Rectangle, Circle, etc.) from the menu or toolbar.
2. **Edit Shape**: Click on a shape to select it, then use the properties window to edit its dimensions, color, and other properties.
3. **Resize Shape**: Drag the shape's borders or corners to resize it (if supported by the shape).
4. **Move Shape**: Click and drag shapes to move them around the canvas.
5. **Delete Shape**: Select a shape and press the delete button to remove it from the canvas.

### Example of Shapes

- **Rectangle**: You can create a rectangle and modify its width and height.
- **Circle**: Adjust the radius and toggle between filled and outlined.
- **Trapezoid**: You can adjust the bases and height of the trapezoid.

## Key Concepts

### Object-Oriented Programming Principles

1. **Inheritance**: The base class `Shape` provides common properties and methods like `Draw`, `CalculateArea`, and `EditSize`. Other shapes (like `Circle`, `Rectangle`, etc.) inherit from this class and override the methods to provide specific behavior.

2. **Encapsulation**: Each shape encapsulates its properties (like position, size, color) and exposes only necessary methods for interacting with it.

3. **Polymorphism**: Shapes are handled polymorphically, meaning the application can perform the same operations (draw, resize, etc.) on different shapes without needing to know their specific type.

4. **Virtual Methods**: Methods like `Draw` and `CalculateArea` are defined as virtual in the `Shape` class and overridden in derived classes (like `Circle`, `Rectangle`, etc.) to provide shape-specific behavior.

### Event Handling

The application uses events and delegates to handle user interactions (like clicking a shape to select or dragging a shape to move it).

### Graphics Management

- **Pen and Brush**: The drawing operations for shapes (like filling or outlining) are handled using `Pen` and `Brush` objects. These are disposed of properly when no longer needed, to avoid memory leaks.
- **GDI+**: Graphics are drawn on the canvas using GDI+ methods for drawing shapes and filling them.

## Contributing

Feel free to fork the repository, make changes, and submit pull requests. You can contribute by:

- Adding new shapes or editing existing shapes.
- Improving the user interface.
- Fixing bugs or improving the codebase.

