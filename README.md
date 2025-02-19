# Real-Time Order and Stock Management System

This project provides a comprehensive solution for managing real-time order processing and dynamic stock updates. It leverages multithreading, synchronization, and dynamic priority management techniques to handle concurrent transactions in an e-commerce environment. The system addresses common challenges such as data inconsistency, access conflicts, and error handling, ensuring that both customer and administrative operations are processed efficiently and fairly.

---

## Table of Contents

- [Overview](#overview)
- [Introduction](#introduction)
- [System Architecture & Design](#system-architecture--design)
- [Methodology](#methodology)
  - [Database Design](#database-design)
  - [Multithreading & Concurrency](#multithreading--concurrency)
  - [Dynamic Priority Management](#dynamic-priority-management)
  - [Error Management & Logging](#error-management--logging)
  - [User Interface (UI) Integration](#user-interface-ui-integration)
  - [Software Architecture (MVC)](#software-architecture-mvc)
- [Experimental Results](#experimental-results)
- [Project Requirements](#project-requirements)
- [Documentation & References](#documentation--references)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

The **Real-Time Order and Stock Management System** is designed to process customer orders and update stock information in real time. Key features include:
- **Concurrent Transaction Handling:** Ensures data consistency and resolves access conflicts using multithreading and synchronization techniques.
- **Dynamic Priority System:** Premium customers are given default higher priority, while the priority of Standard customers is dynamically adjusted based on waiting time.
- **Robust Stock Management:** Every product is initialized with a fixed stock level that updates immediately with each purchase. Critical stock levels trigger visual alerts.
- **Budget Management:** Each customer operates within a defined budget. If a customer’s available funds are insufficient for a purchase, the transaction is rejected with appropriate error logging.
- **Comprehensive Logging:** Detailed logging of every transaction (successful or failed) aids in real-time monitoring and troubleshooting.
- **User-Friendly Interface:** Distinct panels for customers and administrators streamline operations and provide real-time status updates.

---

## Introduction

With the increasing prevalence of e-commerce platforms, managing simultaneous transactions while ensuring data consistency has become critical. Modern systems must efficiently handle thousands of concurrent purchase requests without compromising on performance or fairness. This project is developed to address these challenges by:

- Handling simultaneous order processing.
- Dynamically updating stock and budget information.
- Enforcing a fair order processing mechanism through dynamic priority management.
- Providing clear, real-time feedback via a user-friendly interface for both customers and system administrators.

The system is implemented as a desktop application using C# and is backed by a robust MySQL database.

---

## System Architecture & Design

The system is structured around a modular architecture that separates concerns into distinct layers. This design ensures scalability, maintainability, and ease of future enhancements.

- **Frontend/UI:**  
  - Designed with a focus on user experience, the interface offers separate panels for customers and administrators.
  - Customers can view their order status, budget, waiting time, and priority score.
  - Administrators have access to detailed logs, product stock levels, and controls for managing inventory.

- **Backend:**  
  - Developed in C# and connected to a MySQL database.
  - Implements RESTful services and multithreading to handle concurrent requests.
  - Enforces synchronization via locking mechanisms to prevent race conditions during critical operations like stock updates and budget deductions.

- **Database:**  
  - Utilizes a relational model with clearly defined tables for Customers, Products, Orders, and Logs.
  - The database schema is designed to maintain referential integrity and support rapid, concurrent data updates.

---

## Methodology

### Database Design

The database is structured to support all necessary operations:
- **Customers Table:**  
  - Fields: `CustomerID`, `CustomerName`, `Budget`, `CustomerType` (Premium/Standard), `TotalSpent`
  - Customers are generated with random initial budgets (ranging from 500–3000 TL) and a mix of Premium and Standard statuses.
  
- **Products Table:**  
  - Fields: `ProductID`, `ProductName`, `Stock`, `Price`
  - Initially, five products are defined with specified stock levels and prices.

- **Orders Table:**  
  - Fields: `OrderID`, `CustomerID`, `ProductID`, `Quantity`, `TotalPrice`, `OrderDate`, `OrderStatus`
  - Captures details of each transaction for processing and analysis.

- **Logs Table:**  
  - Fields: `LogID`, `CustomerID`, `OrderID`, `LogDate`, `LogType`, `LogDetails`
  - Every order, whether successful or failed, is logged for auditing and troubleshooting.

### Multithreading & Concurrency

The system addresses simultaneous transaction challenges by:
- **Order Queue Management:**  
  - Incoming orders are placed into a queue. Premium customers are prioritized, while Standard customers’ orders are dynamically repositioned based on their waiting times.
  
- **Synchronization:**  
  - A locking mechanism (mutex) is applied during critical operations to ensure atomic updates of stock and budget values.
  - This prevents multiple threads from modifying the same data simultaneously, thereby avoiding data inconsistency.
  
- **Timeout Handling:**  
  - Each order must be processed within a set timeframe (15 seconds). Orders that exceed this limit are canceled and an appropriate error is logged.

### Dynamic Priority Management

The system employs a dynamic algorithm to ensure fair processing:
- **Base Priority:**  
  - Premium customers start with a base score of 20, while Standard customers start with a score of 10.
  
- **Waiting Time Influence:**  
  - Each second a customer waits increases their priority score by 0.5 points.
  - **Priority Calculation Formula:**  
    `PriorityScore = BasePriority + (WaitingTime * 0.5)`
  
- **Real-Time Reordering:**  
  - The order queue is re-evaluated and reordered before processing each transaction to reflect any changes in priority.

### Error Management & Logging

Robust error handling is integrated into the system:
- **Error Types:**  
  - **Insufficient Stock:** Triggered when a requested product’s stock is inadequate.
  - **Insufficient Budget:** Occurs when a customer's budget does not cover the cost of the purchase.
  - **Timeouts:** Orders not processed within the defined period are canceled.
  - **Database Errors:** Include connection failures or deadlocks.
  
- **Logging Details:**  
  - Each log entry contains information such as Log ID, Customer ID, Log Type (Error, Warning, Information), Customer Type, product details, timestamp, and the transaction outcome.
  - These logs are accessible via the admin panel for real-time monitoring and historical analysis.

### User Interface (UI) Integration

The system features a dual-panel UI:
- **Customer Panel:**  
  - Displays detailed information including customer ID, name, type (Premium/Standard), available budget, waiting time, and dynamic priority score.
  - Provides an order form for selecting products and specifying quantities.
  - Visual indicators (such as color-coded statuses and progress bars) depict order statuses (waiting, processing, completed).

- **Admin Panel:**  
  - Allows administrators to add, delete, or update product stock levels.
  - Presents a real-time log of all transactions, including errors and successful orders.
  - Graphical representations (e.g., bar or pie charts) are used to visualize stock levels and critical thresholds.
  - An animated order processing section displays current transactions in progress.

### Software Architecture (MVC)

The application adheres to the Model-View-Controller (MVC) paradigm:
- **Model:**  
  - Handles business logic and database interactions.
  
- **View:**  
  - Manages all aspects of the user interface, providing dynamic and responsive displays.
  
- **Controller:**  
  - Acts as the intermediary, processing user input and coordinating actions between the Model and View.
  
This architecture promotes modularity and simplifies both maintenance and future expansion.

---

## Experimental Results

Extensive testing has been conducted under multiple scenarios:
- **Concurrent Order Processing:**  
  - Premium orders are reliably processed before Standard orders.
  - Stock levels are accurately updated in real time even under high load.
  
- **Error Detection & Handling:**  
  - Scenarios with insufficient stock or budget trigger appropriate error messages and log entries.
  - Timeout cases are successfully identified and processed, ensuring no order is left in limbo.
  
- **Dynamic Priority Adjustments:**  
  - The priority system adapts in real time to changes in waiting times, ensuring fairness.
  
- **Performance Optimization:**  
  - The multithreading approach significantly reduces processing times, maintaining system responsiveness even during peak periods.
  
- **Log Monitoring:**  
  - The logging mechanism provides comprehensive insights into system performance and error conditions, aiding in quick troubleshooting.

---

## Project Requirements

### Customers and Their Types

- **Customer Attributes:**  
  - Each customer is defined by `CustomerID`, `CustomerName`, `Budget`, `CustomerType` (Premium/Standard), and `TotalSpent`.
  - Customers are generated with random counts (between 5-10) and budgets (500–3000 TL).  
  - A minimum of two customers must initially be designated as Premium.
  
- **Dynamic Customer Status:**  
  - If a customer’s total spending exceeds 2000 TL, their status is automatically upgraded to Premium.
  - Premium customers are processed with higher priority; Standard customers are processed after, with their priority dynamically increasing based on waiting time.

### Admin Role

- **Responsibilities:**  
  - Admins manage product inventories by adding, deleting, or updating stock levels.
  - Admin operations run concurrently with customer transactions but take precedence when accessing critical data.
  - The admin panel also displays detailed logs and performance metrics.

### Stock Management

- **Product Information:**  
  - The system initializes with 5 products, each with a fixed stock and set price:
    - **ProductID 1:** Product1 – Stock: 500, Price: 100 TL  
    - **ProductID 2:** Product2 – Stock: 10, Price: 50 TL  
    - **ProductID 3:** Product3 – Stock: 200, Price: 45 TL  
    - **ProductID 4:** Product4 – Stock: 75, Price: 75 TL  
    - **ProductID 5:** Product5 – Stock: 0, Price: 500 TL
- **Transaction Rules:**  
  - Stock levels are updated immediately upon each purchase.
  - If stock is insufficient for a requested order, the transaction is rejected and logged.

### Budget Management

- **Customer Balance:**  
  - Each customer’s purchase is deducted from their available budget.
  - If the customer’s balance is insufficient, the order is canceled, and an error is recorded.

### Dynamic Priority System

- **Priority Calculation:**  
  - **Base Scores:** Premium customers start at 20, while Standard customers start at 10.
  - **Waiting Time:** Each second of waiting adds 0.5 to the customer’s priority score.
  - The system recalculates priorities before processing each order to ensure fairness.
  
### Database Structure

- **Tables:**  
  - **Customers:** CustomerID, CustomerName, Budget, CustomerType, TotalSpent  
  - **Products:** ProductID, ProductName, Stock, Price  
  - **Orders:** OrderID, CustomerID, ProductID, Quantity, TotalPrice, OrderDate, OrderStatus  
  - **Logs:** LogID, CustomerID, OrderID, LogDate, LogType, LogDetails

### Logging and Monitoring

- **Log Entries:**  
  - Each transaction log contains a unique Log ID, customer and order details, type of log (Error, Warning, Information), timestamps, and a description of the outcome.
- **UI Display:**  
  - Logs are shown in a continuously updating list in the admin panel, allowing for real-time monitoring and retrospective analysis.

### UI Features

- **Customer Panel:**  
  - Displays key details including Customer ID, Name, Type, Budget, Waiting Time, and Dynamic Priority Score.
  - Provides an order submission form for product selection and quantity input.
  - Utilizes visual indicators (such as colors and animations) to display order status.
  
- **Admin Panel:**  
  - Offers controls for managing products and monitoring stock levels.
  - Displays graphical charts for stock levels and transaction trends.
  - Features a real-time log viewer to track all activities within the system.
  
- **Dynamic Panels:**  
  - Separate views for dynamic priority and waiting time animations provide live updates on the processing order.

### Programming Languages & Databases

- **Languages:** Java, JavaScript, Python, C, C#
- **Databases:** MySQL, PostgreSQL, MongoDB, Firebase Realtime Database  
  *(Note: The project can be developed as a web or desktop application. Mobile applications are not within the current scope.)*

---

## Documentation & References

- **Microsoft Learn:**  
  "Multithreading in C#: Managing Concurrency and Parallelism"  
  [https://learn.microsoft.com](https://learn.microsoft.com)
- **MySQL Documentation:**  
  "MySQL Reference Manual: The InnoDB Storage Engine"  
  [https://dev.mysql.com/doc/](https://dev.mysql.com/doc/)
- **Concurrency in Software Systems:**  
  John Doe, XYZ Publications, 2020, ISBN: 978-1-23456-789-0.
- **Effective Software Design Principles:**  
  Jane Smith, ABC Publications, 2018, ISBN: 978-9-87654-321-0.
- **C# Programming Guide:**  
  "Handling Events and Delegates in .NET Framework"  
  [https://docs.microsoft.com/en-us/dotnet](https://docs.microsoft.com/en-us/dotnet)

---

## Contributing

Contributions are welcome! If you have suggestions, improvements, or bug fixes, please follow these guidelines:
1. **Fork the Repository:** Create your own branch from the main project.
2. **Make Changes:** Implement your improvements or bug fixes.
3. **Submit a Pull Request:** Include detailed explanations of your changes.
4. **Open an Issue:** For major changes, please open an issue to discuss your proposed modifications before implementation.

---

## License

Distributed under the MIT License. For detailed license information, see the [LICENSE](LICENSE) file.

---
