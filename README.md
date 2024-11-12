# Coke Freestyle Machine 

## Introduction

This project outlines the proposed design for the Coke Freestyle Machine, aiming to enhance user experience and streamline business operations. The design introduces features for product tracking, improved maintenance, user-friendly interfaces, and customer satisfaction. This README provides an overview of the project’s specifications and structure as outlined in the System Design Document.

## System Overview

The Freestyle Machine software will feature a user-friendly interface allowing consumers to select and customize their drinks, including mixing up to three flavors. It will also dispense precise quantities based on selected cup sizes, minimizing waste. The machine owners will have access to features for syrup and CO₂ level monitoring, manual reordering, and viewing usage statistics.

![image](https://github.com/user-attachments/assets/15fa6dc9-a87a-4d2d-8760-dcc494dfacbd)

## Design Considerations

This project considers both hardware and software requirements, including:
- Database structure to manage drink statistics
- User input controls
- Compatibility with Windows 7 or higher
- 24/7 availability
- Minimum specifications of a 2-core processor, 4GB RAM, and 50GB storage

## Assumptions and Dependencies

- Operating System: Windows 7 or higher
- Display: HD color
- Hardware and environment: protected from harsh conditions, color-blind accessible, and Wi-Fi capable

## General Constraints

Constraints include:
- 2-core processor, 4GB RAM, and 50GB storage
- Food and health compliance standards
- Instant load times and easy-to-read data reports
- Two-click dispense functionality
- Limits on data storage for local reports

## Goals and Guidelines

Key objectives include:
- Simple, accessible UI
- Access keys and tab indexing
- Reorder and tracking options for syrup and CO₂
- Flavor mixing (up to 3 flavors)
- Dispensing in 8oz, 16oz, 24oz, and 32oz options
- Maintenance and usage reports

## Development Methods

The software adopts a modular approach with private subroutines (subs) to streamline coding, enhance readability, and ease future updates. A Visual Studio environment is used to support a dataset-driven SQL database connection.

### Data Base
![image](https://github.com/user-attachments/assets/63b7b172-1682-4d04-9772-493c1d4a4f6e)

## Architectural Strategies

Using C# .NET in Visual Studio, the system leverages modular coding, touch/mouse inputs, and error logging for reliability. Data on machine usage is uploaded online to facilitate remote management and auto-reordering of resources.

## System Architecture

A modular flowchart model was implemented, with subs handling repetitive tasks to minimize redundancy. Key private subs include:
- `hidegrpSize()` / `showgrpSize()` – Show/hide size selection
- `MixCountCheck()` – Restrict flavor mix count to 3
- `CalcSyrupUsed()` – Calculate syrup/CO₂ usage
- `ResourceLowCheck()` – Alert if levels are low

## Policies and Tactics

Coding conventions such as C# .NET naming systems and modular design principles will be strictly followed, with proper tab indexing and access key implementation.

## Detailed System Design

The application provides a structured layout with flavor selection at the top and key functionality buttons below (e.g., dispense, mix, size selection). Database tables include:
- **Inventory Table** – Manages syrup/CO₂ levels and refill dates
- **Order Table** – Records transaction details
- **Order Info Table** – Logs order components and quantities

Subsystems handle functions like syrup level monitoring and product dispensing.

## Interface and Export

The application communicates with a remote database to export and update data. When a flavor is selected, it stores the selection and updates the UI to reflect available options and order summary.

## Glossary

- **Freestyle**: A Coca-Cola soda fountain providing diverse drink options through one nozzle.

---

This project is led by:
- **Jesus Aguilar** – Programmer
- **Cody Rockwell** – Programmer
