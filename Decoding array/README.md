## Problem
Uncle Vasya recorded only the differences between numbers (delta encoding), but forgot to write down the first initial number. He remembered the minimum number in the sequence, which is passed as `minNumbers`.

## Task
Write a method `DecodeDelta` that takes an array of deltas (`originalArray`) and the minimum value (`minNumbers`), reconstructs the original sequence (`result`), and prints it to the console, separated by spaces.

## How it works
1. The sequence is reconstructed starting from `minNumbers` as the first element.
2. Then, a "draft" sequence is built by adding deltas.
3. The actual minimum value in the draft is found.
4. A shift is calculated: `shift = minNumbers - minValue`.
5. The shift is applied to all elements to get the correct sequence.
