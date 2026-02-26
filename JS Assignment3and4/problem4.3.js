

let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

// 1. Total cart value
let total = cart.reduce((sum, item) =>
  sum + (item.price * item.qty), 0);
console.log("Total Cart Value:", total);

// 2. Increase quantity of product id=2
cart = cart.map(item =>
  item.id === 2 ? { ...item, qty: item.qty + 1 } : item
);
console.log("After Quantity Increase:", cart);

// 3. Remove product id=3
cart = cart.filter(item => item.id !== 3);
console.log("After Removing Product:", cart);

// 4. Apply 10% discount above ₹10000
cart = cart.map(item =>
  item.price > 10000
    ? { ...item, price: item.price * 0.9 }
    : item
);
console.log("After Discount:", cart);

// 5. Sort by total item price
let sortedCart = [...cart].sort((a, b) =>
  (a.price * a.qty) - (b.price * b.qty)
);
console.log("Sorted Cart:", sortedCart);

// 6. Any product > ₹50000
let costly = cart.some(item => item.price > 50000);
console.log("Any item > 50000?", costly);

// 7. All items in stock?
let allInStock = cart.every(item => item.qty > 0);
console.log("All In Stock?", allInStock);