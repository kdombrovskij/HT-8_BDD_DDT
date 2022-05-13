Feature: RozetkaCartTest
	In order to buy new kettle
	As a Junior QA Test Automation Engineer
	I want to buy kettle on Rozetka 

@smoke
Scenario Outline: Adding the most expensive kettle to card and checking if total is less than limit
	Given I have entered '<item>' in search field
	When I press the search button
	When I choose the producer '<producer>'
	When I sort items from the most expensive to cheaper
	When I click buy button
	When I click cart button
	Then I check if total amount in cart is less than '<topAmount>'

Examples:
| item    | producer | topAmount |
| Чайник  | Maestro  | 10000     |