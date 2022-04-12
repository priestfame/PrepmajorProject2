Feature: Login
As a user 
i want to login as a student
So that i can have access to courses


@workitem248
Scenario: valid login
    Given a user navigates to EAC Prepmajor website
    When a user clicks login on the menu
    And a user enters a username "priestfame"
    And a user enters password "Alakada22"
    And a user clicks login button
    Then a user is logged in and logo is correctly displayed on the page



	
	
	