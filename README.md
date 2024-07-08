# Json-Serailizer-Using-Recursion-and-Reflection

# JSON Serializer in C#

## Overview

This project involves creating a JSON serializer in C# using recursion and reflection. The goal is to develop a method that converts any object into a JSON string. The objects can contain nested child objects, arrays, and lists, but other collection types will not be used. The primitive data types involved are `int`, `double`, `decimal`, `bool`, `string`, `char`, and `DateTime`.

## Task Description

Implement a class `JsonFormatter` with a static method `string Convert(object item)` that converts a given object into its JSON string representation. The object can include nested structures such as other objects, arrays, and lists.

## Files and Classes

### JsonFormatter.cs

Contains the `JsonFormatter` class, which provides functionality to convert objects to JSON format using recursion and reflection. This is the main class responsible for the serialization of objects into JSON format.

### JSON Validation

To validate your JSON string, use the JSON validator available at [JSONLint](https://jsonlint.com/).

## How to Use

1. **Clone the repository:** Clone the repository to your local machine using:
    ```sh
    git clone <repository_url>
    ```

2. **Open the project:** Open the project in your preferred C# IDE (e.g., Visual Studio).

3. **Build the project:** Build the project to restore the necessary packages and dependencies.

4. **Run the application:** Execute the `Program.cs` file to run the application. The program will perform various tasks including formatting and displaying JSON data.
