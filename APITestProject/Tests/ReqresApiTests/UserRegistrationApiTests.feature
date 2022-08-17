Feature: UserRegistrationApiTests

Scenario: CheckThatPostUserRegistrationWorksCorrect
	When Registration user with following data
		| email              | password |
		| eve.holt@reqres.in | pistol   |
	Then User get response after successful registration
		| id | token             |
		| 4  | QpwL5tke4Pnpja7X4 |

Scenario: CheckThatPostUserLoginWorksCorrect
	When Login user with following data
		| email              | password   |
		| eve.holt@reqres.in | cityslicka |
	Then User get response after successful login
		| token             |
		| QpwL5tke4Pnpja7X4 |