Feature: UserDeleteApiTests

Scenario: CheckThatDeleteUserWorksCorrect
	When Delete '2' user
	Then User get response after successful deleting

