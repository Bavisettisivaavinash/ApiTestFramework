Feature: Delete Booking

Scenario: Successfully delete a booking
  Given I have a valid booking ID
  When I send a delete booking request
  Then the booking should be deleted successfully