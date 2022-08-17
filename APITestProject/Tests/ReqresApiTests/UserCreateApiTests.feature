Feature: UserCreateTests

Scenario: CheckThatPostUserCreateWorksCorrect
	When Create new user with following data
		| name	   | job    |
		| morpheus | leader |
		#|  |  |  |
		#|  |  |  |
	Then User get response after successful created
		|  |  |
		|  |  | 
		#| name     | job    |
		#| morpheus | leader | 