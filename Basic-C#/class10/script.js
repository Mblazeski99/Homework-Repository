// let numbers = [1, 2, 3];

// let a = numbers[0];
// let b = numbers[1];

// console.log(a, b);

// let [a, b, c, d = "something"] = numbers;

// console.log(a,b,d);

// let[a, , b] = numbers;

// console.log(b);

// let [a, ...b ] = numbers;

// console.log()

// let a =5;
// let b = 10;

// [b,a] = [a,b];

// let newNumbers = () =>{
//     return[5,10];
// }

// let [a] = newNumbers();

// let person = {
//     name: "Mike",
//     age: 26,
//     greet: function()
// {   
//      console.log("hello")
//     }
// }   
//     let{age,name,greet} = person;

//     console.log(age,name);
//     console.log(age);

// let [a] = newNumbers();

// let obj = {
//     name: "Mike",
//     age: 26,
//     greetl: function()
// {   
//      console.log("hello")
//     }

// let person {
//     name: let anotherPerson = Object.create(person);
//     anotherPerson.age = 20;
//     console.log(person);
//     console.log(anotherPerson.age);
//     console.log(person.another());
//     console.log(oersib,toString());
//     console.log(oersib,_proto_)
// person.another;
// }

// Object.prototype.greet = function() {
//     console.log(`hello there, i am ${this.name}`);
// }

// console.log(person._proto_)
// let mike = Object.create(person);
// let john = Object.create(person);
// john.name = "john";

// mike.greet();
// john.greet();

// console.log()

// function Person() {

// }

// Person.prototype.greet = function() {
//     console.log("helllooos");
// }

// let person = new Person()
// person.name = "Mike";
// console.log(person);
// person.greet();


// console.log(person._proto_ === Object.prototype);
// console.log(person._proto_ === person.prototype);

// function Person() {
//     this.name = "Mike";
// }

// Person.prototype.greet = function() {
//     console.log(`hello i am`, +this.name)
// }

// let perons = new Person()
// person.greet();

// function Person () {
//     this.name = "Mike";
//     this.greet = function() {
//         console.log(`hello i am ${this.name}`)
//     }
// }

// Person.prototype.name = "John";
// let person = new Person ();
// person.name ="John";
// person.greet();

function Person(name, age) {
    this.name = name;
    this.age = age;
}

let mike = new Person("Mike", 23);
let john = new Person("John", 30);


console.log(mike);
console.log(john);

let account = {
    cash: 12000,
    _name: "Default",
    withdraw: function(amount) {
        this.cash -= amount
        console.log(`Withdraw ${amount}, new cash reserve is: ${this.cash}`);
    }
}

// account.withdraw(1000);

Object.defineProperty(account, "deposit", {
    value: function(amount) {
        this.cash += amount;
    }
})

account.deposit(3000);
account.withdraw(1000);

Object.defineProperty(account, "name", {
    value: "Mike",
    writable: true
})

console.log(account.name);
account.name = "john";
console.log(account.name);

Object.defineProperty(account, "anotherName", {
    get: function () {
        return this._name
    },
    set: function(anotherName) {
        if(anotherName === "Mike") {
            this._name = anotherName;
        }
    }
})

account.anotherName = "John";
account.anotherName = "Mike";
console.log(account.anotherName);










