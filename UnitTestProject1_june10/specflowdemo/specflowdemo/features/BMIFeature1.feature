Feature: Test BMI functionality
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: enter bmi details
	Given when the user is on BMI home page
	And the user enters age35
	And the user selects sex
	And the user enters heightfeet
	And the user enters heightinch
	And the user enters weight
	When the user clicks on Calculate Button
	Then the user should be dispalyed with BMI and BMI category
	And  the user verifies the BMI category


	Scenario Outline: enter calorie details 1
	When the user clicks on BMI link
	And the user provides the age as <age>
	And the user provides the heightfeet as <feet>
	And the user enters heightinch <inch>
	And the user enters weight <weight>
	When the user clicks on Calculate Button
	Then the user should be dispalyed with BMI and BMI category
	And  the user verifies the BMI category
