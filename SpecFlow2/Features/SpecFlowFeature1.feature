Feature: Calculator - Addition and Subtraction

Scenario Outline: Addition - Two numbers added together correctly
	Given I have two numbers <number1> and <number2>
	When I add these together
	Then the correct result of <result> is provided

	Examples: 
	| number1 | number2 | result |
	| 1       | 1       | 2      |
	| 10      | 20      | 30     |