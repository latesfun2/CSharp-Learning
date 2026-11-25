# Delta Decoding Utility

## Description
This program implements a utility for decoding delta-encoded sequences. Delta encoding stores data as the difference between consecutive values. When the initial value is lost, this algorithm reconstructs the original sequence using the known minimum value.

## Task
Write a method `DecodeDelta` that takes an array of deltas (`originalArray`) and the minimum value (`minNumbers`), reconstructs the original sequence, and prints it to the console, separated by spaces.

## How it works
1. The sequence is initially reconstructed starting from `minNumbers` as the first element.
2. A "draft" sequence is built by adding deltas.
3. The actual minimum value in the draft sequence is found.
4. A shift is calculated: `shift = minNumbers - minValue`.
5. The shift is applied to all elements to produce the final correct sequence.
