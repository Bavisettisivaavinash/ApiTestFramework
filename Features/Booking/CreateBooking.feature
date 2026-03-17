Feature: Create Booking

Scenario: Successfully create a new booking
  Given I have valid booking details
  When I send a create booking request
  Then the booking should be created successfully