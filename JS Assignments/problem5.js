let number = 7;  // Change value to test

// 1. Positive or Negative (Ternary)
let result = (number >= 0) ? "Positive" : "Negative";
console.log("Number is: " + result);

// 2. Even or Odd
if (number % 2 === 0) {
    console.log("Even Number");
}
else {
    console.log("Odd Number");
}

// 3. Print numbers from 1 to given number
console.log("Numbers from 1 to " + number + ":");

for (let i = 1; i <= number; i++) {
    console.log(i);
}