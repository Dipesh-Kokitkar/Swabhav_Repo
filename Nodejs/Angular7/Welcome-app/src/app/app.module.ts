import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { StudentComponent } from './student-app/student.component';

@NgModule({
  declarations: [
    StudentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [StudentComponent]
})
export class AppModule { }
