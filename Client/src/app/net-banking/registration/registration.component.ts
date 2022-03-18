import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private fb : FormBuilder) { }

  registration = this.fb.group({
    AccountNumber : ['']
  })


  ngOnInit(): void {
  }

}
