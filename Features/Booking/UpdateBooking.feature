Feature: Update Booking

Scenario: Successfully update an existing booking
  Given I have a valid booking ID and updated details
  When I send an update booking request
  Then the booking should be updated successfully