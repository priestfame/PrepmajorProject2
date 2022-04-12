Feature: EyeIcon
   As a User of the www.eac.prepmajor.com website
   I want to be able to click on the Eye icon on the Email and settings page
   So that I can reveal or hide my password

#Rule: Every student should be able to hide or reveal password

@workitem942
Scenario: Hide Generated Password
    Given a user navigates to EAC Prepmajor member website
    When a user clicks log in on the menu
    And a user enters username "priestfame"
    And a user enters a password "Alakada22"
    And a user click login button
    And a user click on the setting cog icon
	And a user click on the setting page
	And a user enter current password"Alakada22"
	And a user enter email "bammy579@gmail.com"
	And a user click on generate password
	And a user enter new password "Dtester01"
    And a user click on the eye icon
    #Then the eyeicon button is enabled
    #And a user click on the save button
    #Then a user can see "Enrolled Courses" displayed on the page