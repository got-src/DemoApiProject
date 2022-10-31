# Demo API Project

## Description

This repository demonstrates a simple architecture that divides HTTP concerns from business logic to promote scalability.

## Projects

### DemoApiProject

Cares for the HTTP concerns, exposing HTTP controllers and bootstrapping the main application.

### DemoApiProject.Domain

Cares for business logic, such as retrieving data from any accessible source.

### DemoApiProject.Common

A common class library for sharing models and other common types.
