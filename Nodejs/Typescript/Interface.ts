interface IEmployee{
    id:number,
    salary:number,
    job:string,
    name:string
}
function printDatails(employes:IEmployee[]){
    for(let e of employes){
        console.log(e.id+" "+e.salary+" "+e.job+" "+e.name);
    }
}

printDatails([{id:123,job:"Tester",name:"ABC",salary:100000},
              {id:456,job:"Tester",name:"XYZ",salary:100000},
               {id:789,job:"Developer",name:"LMN",salary:300000}]);