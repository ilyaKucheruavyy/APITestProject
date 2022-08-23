Feature: UserInfoApiTests

Scenario: CheckThatGetInfoAboutSingleUserWorksCorrect
	When Get info about '2' user
	Then User checks 'data' class from response body for single user
		| id | email                  | first_name | last_name |
		| 2  | janet.weaver@reqres.in | Janet      | Weaver    |
	Then User checks 'support' class from response body
		| text                                                                     | url                                |
		| To keep ReqRes free, contributions towards server costs are appreciated! | https://reqres.in/#support-heading |

Scenario: CheckThatGetListOfTheUsersWorksCorrect
	When Get list of the users from '2' page
	Then User checks page info from response body for list of the users
		| page | pre_page | total | total_pages |
		| 2    | 6        | 12    | 2           |
	Then User checks 'data' class from response body for list of the users
		| id | email                      | first_name | last_name |
		| 7  | michael.lawson@reqres.in   | Michael    | Lawson    |
		| 8  | lindsay.ferguson@reqres.in | Lindsay    | Ferguson  |
		| 9  | tobias.funke@reqres.in     | Tobias     | Funke     |
		| 10 | byron.fields@reqres.in     | Byron      | Fields    |
		| 11 | george.edwards@reqres.in   | George     | Edwards   |
		| 12 | rachel.howell@reqres.in    | Rachel     | Howell    |
