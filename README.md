# Portfolio Rebalancing

An application using basic portfolio algorithms

## Getting Started

Pick an IDE such as visual studio, or Jetbrains rider or run with the dotnet command line

### Prerequisites

Install netcore 2.1 

## Running the tests

Test projects follow the convention Project.Tests

You can run using the dotnet command below or simply run testsin your ide of choice
```
dotnet test project.csproj
```
### Storage
Input data taken from .... is stored on Redis

### Project Deployment
Project is deployed on Heroku

### Rational of Project
Instead of rebalancing using typical methods such as calendar basis or tolerance band triggers balance based on the cost of rebalancing in terms of risk-adjusted returns net of transaction costs.

## Acknowledgments

The algorithms are built on ideas from this MIT whitepaper http://ssg.mit.edu/group/fan/papers/SSRN_opt_rebal.pdf