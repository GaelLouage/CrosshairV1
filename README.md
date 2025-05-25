🎯 CrosshairPickerV1

CrosshairPickerV1 is a WPF-based desktop application that allows users to visually customize a crosshair overlay for their screen. It’s particularly useful for gamers, designers, or accessibility needs.
✨ Features

    🎨 Color Picker: Select from a list of colors to style your crosshair.

    📏 Size Control: Dynamically change the size of the crosshair using a slider.

    ⚙️ Stroke Thickness: Customize how thick the crosshair lines appear.

    ↔️ Gap Adjustment: Modify the inner gap between crosshair lines.

    🪟 Frameless Window: Clean, modern UI with no OS window borders.

    🖱️ Draggable Window: Drag the application window around easily by mouse click.

🖼️ UI Preview

Add screenshots or gifs here to demonstrate the functionality visually.
🛠️ Tech Stack

    .NET / WPF (XAML)

    C#

    MVVM-lite pattern

    Custom Styles and Templates

🚀 Getting Started
Prerequisites

    .NET 6.0 SDK or later

    Visual Studio 2022+ (or any compatible IDE)

Clone the Repository

git clone https://github.com/yourusername/CrosshairPickerV1.git
cd CrosshairPickerV1

Build and Run

    Open the .sln file in Visual Studio.

    Restore NuGet packages if needed.

    Build the solution.

    Run the application.

🧱 Project Structure

CrosshairPickerV1/
├── Crosshairs/             # Crosshair rendering logic
├── Extensions/             # Extension methods
├── Helpers/                # Static helper functions
├── Models/                 # Data models like ColorEntity
├── Singleton/              # Singleton for crosshair instance handling
├── MainWindow.xaml         # Main WPF UI definition
├── MainWindow.xaml.cs      # Main UI logic
└── README.md

🧠 Core Components
MainWindow.xaml & .cs

    Defines the UI and interactions such as sliders, combo box for color selection, and event handlers for each change.

CrosshairCrossSingleton

    Implements a thread-safe singleton for managing and rendering the crosshair overlay.

CrosshairHelpers

    Provides static methods to update crosshair size, color, and stroke thickness.

ColorEntity

    Binds color names and brush values to the combo box.
