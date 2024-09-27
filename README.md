
---

# Encapsulation Example in C#

This project is a simple demonstration of encapsulation in object-oriented programming (OOP) using C#. It defines a `SoccerPlayer` class with a private field and uses getter and setter methods to access and modify that field.

## Description

The program demonstrates how to use **encapsulation** to hide the internal details of a class and control access to its members. The `SoccerPlayer` class has a private field `bonservicePrice` (representing the transfer fee of the soccer player), and two public methods (`getBonservicePrice()` and `setBonservicePrice()`) to safely access and modify this field.

### Class: `SoccerPlayer`

#### Properties:
- **bonservicePrice** (private): Represents the transfer fee of a soccer player. It is hidden from outside access directly.

#### Methods:
1. **getBonservicePrice()**: A getter method that returns the value of the `bonservicePrice`.
2. **setBonservicePrice(int price)**: A setter method that assigns a new value to the `bonservicePrice`. This method is used to ensure controlled access to the private field.

## Main Method:
In the `Main` method, an object of the `SoccerPlayer` class is created. The program sets the player's `bonservicePrice` using the `setBonservicePrice()` method and then retrieves and prints it using the `getBonservicePrice()` method.

### Code Example:

```csharp
SoccerPlayer player = new SoccerPlayer();
player.setBonservicePrice(25000000);
Console.WriteLine(player.getBonservicePrice());
```

### Output Example:

```
25000000
```

## Key Concepts:

- **Encapsulation**: Encapsulation is a core concept in OOP that restricts access to certain components of an object. In this example, the `bonservicePrice` field is private, and access to it is controlled through public getter and setter methods.
  
  By using this approach, you ensure that:
  - The `bonservicePrice` is accessed and modified safely.
  - Any future validation or processing logic on `bonservicePrice` can be handled within the setter method without affecting other parts of the program.

## How to Run:
1. Clone or download the project to your local machine.
2. Open the project in a C# IDE (like Visual Studio).
3. Run the program by pressing `F5` or clicking "Start" in your IDE.

## Purpose:
This project serves as a simple example of how to implement encapsulation in C#. It helps to understand:
- The use of private fields in a class.
- The purpose of getter and setter methods to control access to private data.
- How encapsulation improves data security and helps maintain the integrity of an object's state.

---

