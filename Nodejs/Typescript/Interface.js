function printDatails(employes) {
    for (var _i = 0, employes_1 = employes; _i < employes_1.length; _i++) {
        var e = employes_1[_i];
        console.log(e.id + " " + e.salary + " " + e.job + " " + e.name);
    }
}
printDatails([{ id: 123, job: "Tester", name: "ABC", salary: 100000 },
    { id: 456, job: "Tester", name: "XYZ", salary: 100000 },
    { id: 789, job: "Developer", name: "LMN", salary: 300000 }]);
