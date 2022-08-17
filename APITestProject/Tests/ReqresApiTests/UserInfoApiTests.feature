Feature: UserInfoApiTests

Scenario: CheckThatGetInfoAboutSingleUserWorksCorrect
	When Get info about '2' user
	Then User get response after successful got info about single user
		|  |  |  |
		|  |  |  |

Scenario: CheckThatGetListOfTheUsersWorksCorrect
	When Get list of the user from '2' page
	Then User get response after successful got list of the user
	|  |  |  |  
	|  |  |  |  


