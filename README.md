# Gemini.CommandLine2
A rewrite of the infamous reflection based CLI library

## Concept

This library aims to make creating CLI tools as easy as possible. 
Other than adding a bit of bootstrapping code, there's no more need
to add any more logic to try and parse the arguments passed to the 
program. 

Gemini.CommandLine2 uses reflection to find the method required to run 
the program and bind the passed arguments to parameters required by 
the method selected. If not all of the required arguments are passed,
it tries to aid the user as much as possible.

This is a complete rewrite of my older Gemini.CommandLine library, that 
I will keep as is for backwards compatibility, as this new library has 
a very different style of passing options, making it more easy to user
from the CLI.

## New in this library:

* Support Dependency Injection containers
* Use a different style of passing options that is more intuitive, especially with arguments that contain spaces.
* Give help in case of errors (my old library was notoriously unfriendly) using (among other things) XML documentation.

## Getting started

## Adding help

## Using Dependency Injection

 
