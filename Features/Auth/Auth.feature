Feature: Authentication

Scenario: Successful login
  Given I have valid credentials
  When I send a login request
  Then I should receive an authentication token