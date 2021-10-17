# Introduction 

This app reads from a local table containing 'some' transactions inspired by Ethereum. :) (connecting to the Ethereum API totally stumped me although I've consumed APIs in the past).

The homepage allows the user to search using a block address and all matching transactions are returned

# Getting Started

1. I think you might need Visual Studio 2019 installed and run the following commands to create the database locally.

In Visual Studio, go to menu Tools > NuGet Package Manager > Package Manager Console

Run commands:

Add-Migration InitialCreate
Update-Database

2. Click on the IIS Server button to run the app.

# Author

Lisa Boardman, 17/10/21