"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer_1 = require("./Customer");
var customer = new Customer_1.Customer(123, "ABC", "XYZ");
var address = new Customer_1.Address("Kolsheth Road", "Thane", 400607);
console.log("ID:" + customer.Id + "\nName:" + customer.Fullname);
console.log("\nAddress:" + address.Fulladdress);
