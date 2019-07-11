import {Customer,Address} from "./Customer";
let customer =new Customer(123,"ABC","XYZ");
let address =new Address("Kolsheth Road","Thane",400607);

console.log("ID:"+customer.Id+"\nName:"+customer.Fullname);
console.log("\nAddress:"+address.Fulladdress);