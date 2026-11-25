# Clock Angle Problem

## Problem
Given a number `n` (representing a specific number of clicks), calculate the time on a clock when the hour hand passes a certain angle.

## Task
Write a program that reads `n` from the console, calculates the time, and outputs it in `HH:MM` format.

## How it works
- The hour hand starts at -195 degrees.
- The angle increases by 5.5 degrees per minute (because the hour hand moves 360 degrees in 12 hours = 0.5 deg/min, and the minute hand moves 6 deg/min; their relative speed is 5.5 deg/min).
- When the angle reaches 30 degrees, a "click" is counted.
- The total time is calculated and formatted as `hours:minutes`.
