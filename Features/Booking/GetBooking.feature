Feature: Get Booking

Scenario: Successfully retrieve a booking
  Given I have a valid booking ID
  When I send a get booking request
  Then I should receive the booking details