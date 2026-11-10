# AmeKhanooom 🍪

A simple Windows desktop application for managing a cookie business. It helps manage customers, orders, customer credits, cookie prices, and deliveries in one place.

## Features

- Add, edit, and remove customers (subscribers).
- Manage customer credit balances.
- Create and manage orders for five cookie types: Simple, Saffron, Chocolate, Raisin, and Ginger.
- Automatically calculate order prices using the configured cookie prices.
- Generate a delivery code for each order.
- Check hourly order capacity and suggest another delivery time when a slot is full.
- Track pending, delivered, and sold orders.
- Import and export customer and order data as CSV files.
- Save application data locally using CSV and configuration files.

## Built With

- C#
- Windows Forms
- .NET Framework 4.7.2

## Getting Started

### Requirements

- Windows
- Visual Studio with the **.NET desktop development** workload
- .NET Framework 4.7.2 Developer Pack

### Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/rezakn82/AmeKhanooom.git
   ```

2. Open `AmeKhanoom.sln` in Visual Studio.
3. Restore dependencies, if prompted.
4. Build the solution and run the application.

## Data & Backups

The application stores its data locally in CSV and configuration files in its working directory. Use the built-in backup screen to import or export customer and order records. Keep copies of these files safe to avoid losing business data.

---

Made with ❤️ by [Reza Nouri](https://github.com/rezakn82).
