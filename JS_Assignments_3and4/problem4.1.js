// Assignment 1 – Online Book Store

let books = [
    { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
    { id: 2, title: "React Guide", price: 650, stock: 5 },
    { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
    { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

// 1. Display all book titles
let titles = books.map(book => book.title);
console.log("Titles:", titles);

// 2. Total inventory value
let totalValue = books.reduce((sum, book) =>
    sum + (book.price * book.stock), 0);
console.log("Total Inventory Value:", totalValue);

// 3. Books above ₹500
let costlyBooks = books.filter(book => book.price > 500);
console.log("Books above 500:", costlyBooks);

// 4. Increase price by 5%
let increasedPrices = books.map(book => ({
    ...book,
    price: +(book.price * 1.05).toFixed(2)
}));
console.log("After 5% Increase:", increasedPrices);

// 5. Sort by price (low → high)
let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log("Sorted Books:", sortedBooks);

// 6. Remove book by ID (example: id=2)
let updatedBooks = books.filter(book => book.id !== 2);
console.log("After Removing ID 2:", updatedBooks);

// 7. Any book out of stock?
let outOfStock = books.some(book => book.stock === 0);
console.log("Any Out of Stock?", outOfStock);