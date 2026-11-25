# Delta Decoding Utility

## English
**Description:**
Reconstructs an original numerical sequence from its delta-encoded representation. The initial value is not known, but the minimum value of the original sequence is provided.

**Task:**
Write a method `DecodeDelta` that takes an array of deltas (`originalArray`) and the minimum value (`minNumbers`), reconstructs the original sequence, and prints it to the console, separated by spaces.

**How it works:**
1. The sequence is initially reconstructed starting from `minNumbers` as the first element.
2. A "draft" sequence is built by adding deltas.
3. The actual minimum value in the draft sequence is found.
4. A shift is calculated: `shift = minNumbers - minValue`.
5. The shift is applied to all elements to produce the final correct sequence.

---

## Русский
**Описание:**
Восстанавливает исходную числовую последовательность из её дельта-кодированного представления. Начальное значение неизвестно, но дано минимальное значение исходной последовательности.

**Задача:**
Написать метод `DecodeDelta`, который принимает массив дельт (`originalArray`) и минимальное значение (`minNumbers`), восстанавливает исходную последовательность и выводит её в консоль через пробел.

**Как это работает:**
1. Последовательность изначально восстанавливается, начиная с `minNumbers` как первого элемента.
2. Строится «черновик» последовательности путём прибавления дельт.
3. В черновике находится фактическое минимальное значение.
4. Вычисляется сдвиг: `shift = minNumbers - minValue`.
5. Сдвиг применяется ко всем элементам для получения итоговой правильной последовательности.
