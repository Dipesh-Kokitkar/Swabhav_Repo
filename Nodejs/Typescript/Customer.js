"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Customer = /** @class */ (function () {
    function Customer(id, firstname, lastname) {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
    }
    Object.defineProperty(Customer.prototype, "Id", {
        get: function () {
            return this.id;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Customer.prototype, "Fullname", {
        get: function () {
            return this.firstname + " " + this.lastname;
        },
        enumerable: true,
        configurable: true
    });
    return Customer;
}());
exports.Customer = Customer;
var Address = /** @class */ (function () {
    function Address(streetname, cityname, zipcode) {
        this.streetname = streetname;
        this.cityname = cityname;
        this.zipcode = zipcode;
    }
    Object.defineProperty(Address.prototype, "Fulladdress", {
        get: function () {
            return this.streetname + " " + this.cityname + " " + this.zipcode;
        },
        enumerable: true,
        configurable: true
    });
    return Address;
}());
exports.Address = Address;
