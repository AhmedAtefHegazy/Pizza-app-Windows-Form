# Pizza Ordering App 🍕

A simple desktop application for customizing and ordering pizzas, built with C# and Windows Forms.

## Features

- **Pizza Size Selection**: Choose from Small, Medium, or Large sizes with dynamic price adjustments.
- **Crust Options**: Select between Thin Crust and Thick Crust.
- **Toppings Customization**: Add up to six toppings, including:
  - Extra Cheese
  - Onion
  - Mushrooms
  - Olives
  - Tomatoes
  - Green Peppers
- **Dining Options**: Choose between "Eat In" or "Take Out".
- **Real-Time Price Updates**: See price changes as you customize your order.
- **User-Friendly Interface**: Clean and intuitive UI with labels displaying current selections and prices.

## Installation

1. Clone the repository:

```bash
 git clone https://github.com/yourusername/pizza-ordering-app.git

```

2. Open the solution in Visual Studio.
3. Build the solution to restore dependencies.
4. Run the application.

## Usage

1. Launch the app.
2. Select pizza size, crust type, and toppings using the radio buttons and checkboxes.
3. View the total price and selected options dynamically on the interface.
4. Decide between dining in or taking out.

## Code Overview

- Forms: frmOrderPizza - The main form for the pizza ordering process.
- Dynamic Price Calculation: Real-time updates based on user selections for size, crust, and toppings.
- Custom Methods:
  - ChangeToppingText: Updates the displayed toppings list.
  - IsNoToppings: Handles scenarios where no toppings are selected.

# Technologies Used

- Language: C#
- Framework: .NET Framework
- UI Framework: Windows Forms

# License

License
This project is licensed under the MIT License.
