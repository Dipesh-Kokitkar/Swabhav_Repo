export class Customer{
    constructor(private id:number,
                private firstname:string,
                private lastname:string){}
    get Id(){
        return this.id;
    }
    get Fullname(){
        return this.firstname+" "+this.lastname;
    }
}
export class Address{
    constructor(private streetname:string,
                private cityname:string,
                private zipcode:number){}
    get Fulladdress(){
        return this.streetname+" "+this.cityname+" "+this.zipcode;
    }
}