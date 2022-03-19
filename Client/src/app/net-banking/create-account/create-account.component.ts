import { Component ,OnInit} from '@angular/core';
import {  FormBuilder,FormControl,FormGroup,Validators } from '@angular/forms';
import { LengthValidator } from '../customvalidators/length-validators';

@Component(
  {
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styleUrls: ['./create-account.component.css']
  })
  
export class CreateAccountComponent implements OnInit {
  Accountinfo:FormGroup=this._ai.group({
    customerId :['',[Validators.required]],
    title : ['',[Validators.required]],
    firstName: ['',[Validators.required]],
    lastName : ['',[Validators.required]],
    mobileno : ['',[Validators.required,
                    LengthValidator.Length]],
    emailId : ['',[Validators.required,
                   Validators.email]],
    aadhaarCardNumber :['',[Validators.required,
                            LengthValidator.Length]] 
  })
  constructor(private _ai:FormBuilder){}
  ngOnInit():void{

  }
  submitData() {
    console.log(this.Accountinfo)
  }
  
    
}
