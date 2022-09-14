Feature: UserUpdateApiTests

Scenario: CheckThatUpdateInfoWorksCorrect
	When Update info about '2' user
		| name		   | job			  |
		| morpheus     | zion resident    |
	Then User get response after successful updated
		| name		   | job			  |
		| morpheus     | zion resident    |