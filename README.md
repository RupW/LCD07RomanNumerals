This is my solution for the London Code Dojo 7 exercise, generating modern Roman numerals for a given integer. Rules:

* we only allow one subtract symbol, i.e. 8=VIII, 9=IX
* digits are generated one at a time, i.e. 99=XCIX and not IC

We ran an initial iteration, changed programming pairs then started again only keeping the unit tests from the first iteration.

1. Iteration one: pairing with Adnan, we implemented a solution based on a sorted list of digit values, dividing the remaining number and repeating digits as necessary. Here we use include the allowed subtractions in the list of digits to simplify computing those cases. (We did also have a lot of tests for internal calculations here which did not survice past the second iteration.)
2. Iteration two: pairing with Matt, based around a switch() statement to generate each digit at a time which we eventually refactored away.

The London Code Dojos are organised by @sleepyfox - thanks!   
http://www.meetup.com/London-Code-Dojo/events/62738162/
