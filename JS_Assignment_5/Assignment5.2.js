class BankAccount {
    constructor(accountHolder, balance) {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    deposit(amount) {
        this.balance += amount;
        console.log(`Deposited ${amount}.`);
    }

    withdraw(amount) {
        if (amount > this.balance) {
            console.log("Insufficient balance.");
        } else {
            this.balance -= amount;
            console.log(`Withdrawn ${amount}.`);
        }
    }

    checkBalance() {
        console.log(`Current balance is ${this.balance}.`);
    }
}

let acc = new BankAccount("Bhuvan", 1000);
acc.deposit(500);
acc.withdraw(200);
acc.checkBalance();