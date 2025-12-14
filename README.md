# 📐 Geometric Calculator - Console Based

<div align="center">

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)

**A colorful and user-friendly console-based geometric calculator for calculating perimeter, area, and volume of various shapes**

[Features](#-features) • [Installation](#-installation) • [Usage](#-usage) • [Project Structure](#-project-structure) • [License](#-license)

</div>

---

## 📋 About

Geometric Calculator is a comprehensive console-based application developed with .NET 8.0 and C#. It provides an intuitive interface for calculating the perimeter, area, and volume of various geometric shapes. The application features a colorful console interface with UTF-8 support and robust error handling.

### ✨ Features

- 🎨 **Colorful Console Interface** - Visual appeal with different colors for each operation category
- 📏 **Perimeter Calculations** - Calculate perimeter for Square, Rectangle, Circle, Parallelogram, and Regular Polygon
- 📐 **Area Calculations** - Calculate area for Triangle, Square, Rectangle, Trapezoid, Parallelogram, Circle, and Rhombus
- 🔵 **Volume Calculations** - Calculate volume for Cube, Cuboid, Cylinder, Cone, Sphere, Square Pyramid, Triangular Prism, Hemisphere, and Regular Pyramid
- ✅ **Error Handling** - Comprehensive error catching and user-friendly messages
- 🔄 **Type-Safe Input** - Safe data input with generic type parameters and validation
- 🌐 **UTF-8 Support** - Full Unicode support for emoji and special characters
- 🔄 **Interactive Menus** - Easy navigation through nested menus
- 📚 **XML Documentation** - All methods and classes are fully documented with XML comments for better IntelliSense support

---

## 🚀 Installation

### Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/Kaaner4mir/geometric-calculator-console-based.git
   cd geometric-calculator-console-based
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

---

## 🎮 Usage

When the application starts, the main menu screen is displayed. You can select the desired operation by entering its number from the menu.

### Main Menu Options

1. **Perimeter Calculation** 📏
   - Square
   - Rectangle
   - Circle
   - Parallelogram
   - Regular Polygon

2. **Area Calculation** 📐
   - Triangle
   - Square
   - Rectangle
   - Trapezoid
   - Parallelogram
   - Circle
   - Rhombus

3. **Volume Calculation** 🔵
   - Cube
   - Cuboid
   - Cylinder
   - Cone
   - Sphere
   - Square Pyramid
   - Triangular Prism
   - Hemisphere
   - Regular Pyramid

4. **Exit** - Exit the application

### Example Usage

**Calculating the area of a triangle:**
```
👉 Please enter the operation you wish to perform numerically: 2

👉 Please enter the operation you wish to perform numerically: 1

➡️ Enter the base length: 10
➡️ Enter the height: 8

✅ The area of the triangle is 40
```

**Calculating the perimeter of a circle:**
```
👉 Please enter the operation you wish to perform numerically: 1

👉 Please enter the operation you wish to perform numerically: 3

➡️ Enter the radius: 5

✅ The perimeter of the circle is 31.41592653589793
```

**Calculating the volume of a cube:**
```
👉 Please enter the operation you wish to perform numerically: 3

👉 Please enter the operation you wish to perform numerically: 1

➡️ Enter the side length: 4

✅ The volume of the cube is 64
```

---

## 📁 Project Structure

```
GeometricCalculator/
├── Operations/
│   ├── Area.cs                 # Area calculation operations
│   ├── Perimeter.cs            # Perimeter calculation operations
│   ├── Volume.cs               # Volume calculation operations
│   ├── Exit.cs                 # Exit operation
│   └── EnumExtensions.cs       # Extension methods for enums
├── Menu.cs                     # Menu management and display
├── Utils.cs                    # Utility functions (input/output, colors)
├── Initializer.cs              # Main entry point
├── GeometricCalculator.csproj  # Project file
└── README.md                   # This file
```

### Key Classes

- **Initializer** - Main entry point, handles the main application loop
- **Menu** - Manages and displays all menu screens (Main, Perimeter, Area, Volume)
- **Utils** - Provides utility methods for colored console output, type-safe input, and waiting screens
- **Area** - Contains methods for calculating areas of various shapes
- **Perimeter** - Contains methods for calculating perimeters of various shapes
- **Volume** - Contains methods for calculating volumes of various 3D shapes
- **Exit** - Handles the exit operation with user confirmation
- **EnumExtensions** - Provides extension methods for enum descriptions

---

## 🛠️ Technologies

- **.NET 8.0** - Framework
- **C#** - Programming language
- **Console Application** - Command-line interface
- **System.ComponentModel** - For enum descriptions

---

## 📊 Supported Calculations

### Perimeter Calculations
- **Square**: P = 4 × side
- **Rectangle**: P = 2 × (length + width)
- **Circle**: P = 2 × π × radius
- **Parallelogram**: P = 2 × (side₁ + side₂)
- **Regular Polygon**: P = number of sides × side length

### Area Calculations
- **Triangle**: A = (base × height) / 2
- **Square**: A = side²
- **Rectangle**: A = length × width
- **Trapezoid**: A = ((base₁ + base₂) × height) / 2
- **Parallelogram**: A = base × height
- **Circle**: A = π × radius²
- **Rhombus**: A = (diagonal₁ × diagonal₂) / 2

### Volume Calculations
- **Cube**: V = side³
- **Cuboid**: V = length × width × height
- **Cylinder**: V = π × radius² × height
- **Cone**: V = (π × radius² × height) / 3
- **Sphere**: V = (4 × π × radius³) / 3
- **Square Pyramid**: V = (side² × height) / 3
- **Triangular Prism**: V = base area × height
- **Hemisphere**: V = (2 × π × radius³) / 3
- **Regular Pyramid**: V = (base area × height) / 3

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork this repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📝 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## 👤 Author

**Kaaner4mir**

- GitHub: [@Kaaner4mir](https://github.com/Kaaner4mir)

---

<div align="center">

⭐ If you like this project, don't forget to give it a star!

Made with ❤️ using C# and .NET

</div>
