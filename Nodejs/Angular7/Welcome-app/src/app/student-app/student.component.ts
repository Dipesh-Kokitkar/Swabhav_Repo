import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './student.component.html',
  //styleUrls: ['./app.component.css']
})
export class StudentComponent{
    
    student:Istudent={rollno:123,name:"ABC",cgpa:9.5};
    test:number=100;
    students1:Istudent[];
    students:Istudent[]=[{rollno:123,name:"ABC",cgpa:9.5},
    {rollno:456,name:"XYZ",cgpa:8.5},
     {rollno:789,name:"LMN",cgpa:7.5}];
    
    loadData=function ($event) {
        console.log($event);
        this.students1=this.students;
        
    }

}

interface Istudent{
    rollno:number,
    name:string,
    cgpa:number
}
