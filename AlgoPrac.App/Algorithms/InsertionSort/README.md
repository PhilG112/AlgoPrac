# Insertion Sort

**Input:** A sequence of *n* numbers { a*1*, a*2*, a*3* ...., a*n*}

**Output:** A permutation (reordering) of the input sequence such that a*1* <= a*2* <= .... <= a*n*

## Pseudocode

```js
INSERTION-SORT(A)
for j = 2 to A.length
    key = A[j]
    // Insert A[j] into the sorted sequence A[1...j - 1]
    i = j - 1
    while i > 0 and A[i] > key
        A[i + 1] = A[i]
        i = i - 1
    A[i + 1] = key
```
